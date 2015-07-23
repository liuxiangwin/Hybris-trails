using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Exploration3D;

namespace FindMetadata
{
    public partial class MetadataSearch : Form
    {
        public MetadataSearch()
        {
            InitializeComponent();
            _NodeMetaData = new Dictionary<Node, Dictionary<string, string>>();
            this.Load += new EventHandler(MetadataSearch_Load);
        }

        private Dictionary<Node, Dictionary<string, string>> _NodeMetaData;


        private void MetadataSearch_Load(object sender, EventArgs e)
        {
            axDeepView.FileName = "RealightTransmissionWithMetadata.rh";
            axDeepView.SceneLoadedEvent += new AxExploration3D.IDeepViewEvents_SceneLoadedEventHandler(axDeepView_SceneLoadedEvent);
            axDeepView.SelectionChangedEvent += new AxExploration3D.IDeepViewEvents_SelectionChangedEventHandler(axDeepView_SelectionChangedEvent);
        }

        void axDeepView_SelectionChangedEvent(object sender, AxExploration3D.IDeepViewEvents_SelectionChangedEvent e)
        {
            SceneObjectList nodes = axDeepView.Scene.Nodes;

            List<string> sel = new List<string>();
            int nodeCount = axDeepView.Scene.Nodes.Count;
            for (int i = 0; i < nodeCount; i++)
            {
                Node node = nodes.GetByIndex(i) as Node;
                if (!node.Selected) continue;

                MetadataVariable m = node.Metadata.Item("Test Metadata").Item("Color");
                sel.Add(GetMetadataVariableStringValue(m));
            }

            txtSelection.Text = sel.Count > 0 ? string.Join(", ", sel.ToArray()) : "None";
        }

        private void axDeepView_SceneLoadedEvent(object sender, AxExploration3D.IDeepViewEvents_SceneLoadedEvent e)
        {
            axDeepView.ExecuteCommand("Zoom Best Fit");
            GetNodeMetadataStrings();
        }

        private void GetNodeMetadataStrings()
        {
            SceneObjectList nodes = axDeepView.Scene.Nodes;

            int nodeCount = axDeepView.Scene.Nodes.Count;
            for (int i = 0; i < nodeCount; i++)
            {
                Node node = nodes.GetByIndex(i) as Node;
                _NodeMetaData.Add(node, new Dictionary<string, string>());
                PopulateMetaDataForNode(_NodeMetaData, node, node.Metadata, "");
            }
        }

        private void PopulateMetaDataForNode(
            Dictionary<Node, Dictionary<string, string>> nodeMetaData,
            Node node,
            MetadataVariable metadataVariable,
            string pathToVariable)
        {
            if (node != null && metadataVariable != null)
            {
                if (
                    metadataVariable.Type == metadataVariable.TYPE_ARRAY ||
                    metadataVariable.Type == metadataVariable.TYPE_OBJECT)
                {
                    int size = metadataVariable.Size;
                    for (int j = 0; j < size; j++)
                    {
                        string key = metadataVariable.KeyAt(j).ToString();
                        MetadataVariable metadataVariableValue = metadataVariable.ValueAt(j);

                        string newPath =
                            pathToVariable == "" ?
                            key :
                            pathToVariable + "." + key;

                        PopulateMetaDataForNode(
                            nodeMetaData,
                            node,
                            metadataVariableValue,
                            newPath);
                    }
                }

                string metadataVariableStringValue =
                    GetMetadataVariableStringValue(metadataVariable);

                if (metadataVariableStringValue != null)
                {
                    nodeMetaData[node].Add(
                        pathToVariable,
                        GetMetadataVariableStringValue(metadataVariable));
                }
            }
        }

        private string GetMetadataVariableStringValue(MetadataVariable metadataVariable)
        {
            if (
                metadataVariable.Type == metadataVariable.TYPE_BOOL ||
                metadataVariable.Type == metadataVariable.TYPE_DOUBLE ||
                metadataVariable.Type == metadataVariable.TYPE_FLOAT ||
                metadataVariable.Type == metadataVariable.TYPE_INT ||
                metadataVariable.Type == metadataVariable.TYPE_INT64 ||
                metadataVariable.Type == metadataVariable.TYPE_STRING)
            {
                return metadataVariable.Value.ToString();
            }
            if (metadataVariable.Type == metadataVariable.TYPE_POINT3D)
            {
                Vector3 vector = metadataVariable.Value as Vector3;
                if (vector != null)
                {
                    return string.Format("({0},{1},{2})", vector.X, vector.Y, vector.Z);
                }
            }

            // Can't get the matrix coefficient values currently
            //if (metadataVariable.Type == metadataVariable.TYPE_MATRIX3D)
            //{
            //    Matrix4x4 matrix = metadataVariable.Value as Matrix4x4;
            //    if (matrix != null)
            //    {
            //    }
            //}

            // Value is not implemented for the other types
            return null;
        }

        private void btnSelectNodes_Click(object sender, EventArgs e)
        {
            axDeepView.Scene.SelectAll(false);

            foreach (Node node in FindMatchingNodes(txtMetadata.Text))
            {
                node.Selected = true;
            }
        }

        private List<Node> FindMatchingNodes(string metadataString)
        {
            List<Node> matchingNodes = new List<Node>();
            SceneObjectList nodes = axDeepView.Scene.Nodes;

            int nodeCount = axDeepView.Scene.Nodes.Count;
            for (int i = 0; i < nodeCount; i++)
            {
                Node node = nodes.GetByIndex(i) as Node;
                if (node != null && _NodeMetaData.ContainsKey(node))
                {
                    foreach (KeyValuePair<string, string> kvp in _NodeMetaData[node])
                    {
                        if (
                            kvp.Key.Contains(metadataString) ||
                            kvp.Value.Contains(metadataString))
                        {
                            matchingNodes.Add(node);
                            break;
                        }
                    }
                }
            }
            return matchingNodes;
        }
    }
}