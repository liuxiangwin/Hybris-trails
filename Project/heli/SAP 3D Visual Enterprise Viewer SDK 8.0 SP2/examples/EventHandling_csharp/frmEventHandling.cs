using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Exploration3D;

namespace EventHandling
{
    public partial class frmEventHandling : Form
    {
        public frmEventHandling()
        {
            InitializeComponent();
        }

        private Exploration3D.Runtime _Runtime;

        private Exploration3D.AddModelEventHandler _AddModelEventHandler;
        private Exploration3D.KeyEventHandler _KeyEventHandler;
        private Exploration3D.MenuEventHandler _MenuEventHandler;
        private Exploration3D.TimeEventHandler _TimeEventHandler;
        private Exploration3D.ToolEventHandler _ToolEventHandler;
        private Exploration3D.StepEventHandler _StepEventHandler;
        private Exploration3D.ConversationEventHandler _ConversationEventHandler;

        private Exploration3D.MouseEventHandler _MouseDownEventHandler;
        private Exploration3D.MouseEventHandler _MouseUpEventHandler;
        private Exploration3D.MouseEventHandler _MouseDoubleClickEventHandler;
        private Exploration3D.MouseEventHandler _MouseHitEventHandler;
        private Exploration3D.MouseEventHandler _MouseOutEventHandler;
        private Exploration3D.MouseEventHandler _MouseMoveEventHandler;
        private Exploration3D.MouseEventHandler _MouseOverEventHandler;

        private void frmEventHandling_Load(object sender, EventArgs e)
        {
            this.axDeepView.ActivationEvent += new EventHandler(axDeepView_ActivationEvent);
            this.axDeepView.DeactivationEvent += new EventHandler(axDeepView_DeactivationEvent);
            this.axDeepView.FinishedSavingToServerEvent += new AxExploration3D.IDeepViewEvents_FinishedSavingToServerEventHandler(axDeepView_FinishedSavingToServerEvent);
            this.axDeepView.MarkupSelectionChangedEvent += new AxExploration3D.IDeepViewEvents_MarkupSelectionChangedEventHandler(axDeepView_MarkupSelectionChangedEvent);
            this.axDeepView.NodesSelectedEvent += new AxExploration3D.IDeepViewEvents_NodesSelectedEventHandler(axDeepView_NodesSelectedEvent);
            this.axDeepView.ProgressEvent += new AxExploration3D.IDeepViewEvents_ProgressEventHandler(axDeepView_ProgressEvent);
            this.axDeepView.RegisteredEvent += new EventHandler(axDeepView_RegisteredEvent);
            this.axDeepView.SceneLoadedEvent += new AxExploration3D.IDeepViewEvents_SceneLoadedEventHandler(axDeepView_SceneLoadedEvent);
            this.axDeepView.SelectionChangedEvent += new AxExploration3D.IDeepViewEvents_SelectionChangedEventHandler(axDeepView_SelectionChangedEvent);
            this.axDeepView.UnhandledErrorEvent += new AxExploration3D.IDeepViewEvents_UnhandledErrorEventHandler(axDeepView_UnhandledErrorEvent);
            this.axDeepView.UnhandledErrorExEvent += new AxExploration3D.IDeepViewEvents_UnhandledErrorExEventHandler(axDeepView_UnhandledErrorExEvent);
            this.axDeepView.FullscreenChangedEvent += new AxExploration3D.IDeepViewEvents_FullscreenChangedEventHandler(axDeepView_FullscreenChanged);

            Creator creator = this.axDeepView.Creator;

            _Runtime = this.axDeepView.Runtime;

            _AddModelEventHandler = creator.AddModelEventHandler.Create();
            _AddModelEventHandler.FireProgressEvents = true;
            modelToolStripMenuItem_Click(null, EventArgs.Empty);
            _Runtime.AddEventHandler(_AddModelEventHandler);

            _KeyEventHandler = creator.KeyEventHandler.Create();
            keyToolStripMenuItem_Click(null, EventArgs.Empty);
            _Runtime.AddEventHandler(_KeyEventHandler);

            _MenuEventHandler = creator.MenuEventHandler.Create();
            menuToolStripMenuItem_Click(null, EventArgs.Empty);
            _Runtime.AddEventHandler(_MenuEventHandler);

            _TimeEventHandler = creator.TimeEventHandler.Create();
            timeToolStripMenuItem_Click(null, EventArgs.Empty);
            _Runtime.AddEventHandler(_TimeEventHandler);

            _ToolEventHandler = creator.ToolEventHandler.Create();
            toolToolStripMenuItem_Click(null, EventArgs.Empty);
            _Runtime.AddEventHandler(_ToolEventHandler);

            _StepEventHandler = creator.StepEventHandler.Create();
            stepToolStripMenuItem_Click(null, EventArgs.Empty);
            _Runtime.AddEventHandler(_StepEventHandler);

            _ConversationEventHandler = creator.ConversationEventHandler.Create();
            conversationToolStripMenuItem_Click(null, EventArgs.Empty);
            _Runtime.AddEventHandler(_ConversationEventHandler);

            _MouseDownEventHandler = creator.MouseEventHandler.Create();
            _MouseDownEventHandler.OnMouseDown = mouseDownToolStripMenuItem.Checked;
            _MouseDownEventHandler.OnEvent = new EventCatcher(
                (ComEventDelegate)delegate
                {
                    DisplayMessage("MouseDown");
                    return null;
                });
            _Runtime.AddEventHandler(_MouseDownEventHandler);


            _MouseUpEventHandler = creator.MouseEventHandler.Create();
            _MouseUpEventHandler.OnMouseUp = mouseUpToolStripMenuItem.Checked;
            _MouseUpEventHandler.OnEvent = new EventCatcher(
                (ComEventDelegate)delegate
                {
                    DisplayMessage("MouseUp");
                    return null;
                });
            _Runtime.AddEventHandler(_MouseUpEventHandler);


            _MouseDoubleClickEventHandler = creator.MouseEventHandler.Create();
            _MouseDoubleClickEventHandler.OnMouseDoubleClick = mouseDoubleClickToolStripMenuItem.Checked;
            _MouseDoubleClickEventHandler.OnEvent = new EventCatcher(
                (ComEventDelegate)delegate
                {
                    DisplayMessage("MouseDoubleClick");
                    return null;
                });
            _Runtime.AddEventHandler(_MouseDoubleClickEventHandler);


            _MouseHitEventHandler = creator.MouseEventHandler.Create();
            _MouseHitEventHandler.OnMouseHit = mouseHitToolStripMenuItem.Checked;
            _MouseHitEventHandler.ReportAllTargets = true;
            _MouseHitEventHandler.OnEvent = new EventCatcher(
                (ComEventDelegate)delegate
                {
                    DisplayMessage("MouseHit");
                    return null;
                });
            _Runtime.AddEventHandler(_MouseHitEventHandler);


            _MouseOutEventHandler = creator.MouseEventHandler.Create();
            _MouseOutEventHandler.OnMouseOut = mouseOutToolStripMenuItem.Checked;
            _MouseOutEventHandler.ReportAllTargets = true;
            _MouseOutEventHandler.OnEvent = new EventCatcher(
                (ComEventDelegate)delegate
                {
                    DisplayMessage("MouseOut");
                    return null;
                });
            _Runtime.AddEventHandler(_MouseOutEventHandler);


            _MouseMoveEventHandler = creator.MouseEventHandler.Create();
            _MouseMoveEventHandler.OnMouseMove = mouseMoveToolStripMenuItem.Checked;
            _MouseMoveEventHandler.ReportAllTargets = true;
            _MouseMoveEventHandler.OnEvent = new EventCatcher(
                (ComEventDelegate)delegate
                {
                    DisplayMessage("MouseMove");
                    return null;
                });
            _Runtime.AddEventHandler(_MouseMoveEventHandler);


            _MouseOverEventHandler = creator.MouseEventHandler.Create();
            _MouseOverEventHandler.OnMouseOver = mouseOverToolStripMenuItem.Checked;
            _MouseOverEventHandler.ReportAllTargets = true;
            _MouseOverEventHandler.OnEvent = new EventCatcher(
                (ComEventDelegate)delegate
                {
                    DisplayMessage("MouseOver");
                    return null;
                });
            _Runtime.AddEventHandler(_MouseOverEventHandler);

            this.axDeepView.Runtime.AddCustomMenuItem("custommenuItem1", "custommenuItem1", "checked", true);

            this.axDeepView.FileName = "RealiteTransmissioncomp Steps.rh";
        }

        void axDeepView_FullscreenChanged(object sender, AxExploration3D.IDeepViewEvents_FullscreenChangedEvent e)
        {
            DisplayMessage("FullscreenChanged");
        }

        void axDeepView_UnhandledErrorExEvent(object sender, AxExploration3D.IDeepViewEvents_UnhandledErrorExEvent e)
        {
            DisplayMessage("UnhandledErrorExEvent");
        }

        void axDeepView_UnhandledErrorEvent(object sender, AxExploration3D.IDeepViewEvents_UnhandledErrorEvent e)
        {
            DisplayMessage("UnhandledErrorEvent");
        }

        void axDeepView_SelectionChangedEvent(object sender, AxExploration3D.IDeepViewEvents_SelectionChangedEvent e)
        {
            DisplayMessage("SelectionChangedEvent");
        }

        void axDeepView_RegisteredEvent(object sender, EventArgs e)
        {
            DisplayMessage("RegisteredEvent");
        }

        void axDeepView_ProgressEvent(object sender, AxExploration3D.IDeepViewEvents_ProgressEvent e)
        {
            DisplayMessage("ProgressEvent");
        }

        void axDeepView_NodesSelectedEvent(object sender, AxExploration3D.IDeepViewEvents_NodesSelectedEvent e)
        {
            DisplayMessage("NodesSelectedEvent");
        }

        void axDeepView_MarkupSelectionChangedEvent(object sender, AxExploration3D.IDeepViewEvents_MarkupSelectionChangedEvent e)
        {
            DisplayMessage("MarkupSelectionChangedEvent");
        }

        void axDeepView_FinishedSavingToServerEvent(object sender, AxExploration3D.IDeepViewEvents_FinishedSavingToServerEvent e)
        {
            DisplayMessage("FinishedSavingToServerEvent");
        }

        void axDeepView_DeactivationEvent(object sender, EventArgs e)
        {
            DisplayMessage("DeactivationEvent");
        }

        void axDeepView_ActivationEvent(object sender, EventArgs e)
        {
            DisplayMessage("ActivationEvent");
        }

        void axDeepView_SceneLoadedEvent(object sender, AxExploration3D.IDeepViewEvents_SceneLoadedEvent e)
        {
            DisplayMessage("SceneLoadedEvent");
        }

        Queue<string> _Lines = new Queue<string>();

        private void DisplayMessage(string message)
        {
            if (_Lines.Count > 200)
                _Lines.Dequeue();

            _Lines.Enqueue(message);

            string[] lines = _Lines.ToArray();
            Array.Reverse(lines);

            this.txtEvents.Lines = lines;
        }

        private void mouseDownToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            _MouseDownEventHandler.OnMouseDown = mouseDownToolStripMenuItem.Checked;
        }

        private void mouseUpToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            _MouseUpEventHandler.OnMouseUp = mouseUpToolStripMenuItem.Checked;
        }

        private void mouseHitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _MouseHitEventHandler.OnMouseHit = mouseHitToolStripMenuItem.Checked;
        }

        private void mouseOverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _MouseOverEventHandler.OnMouseOver = mouseOverToolStripMenuItem.Checked;
        }

        private void mouseOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _MouseOutEventHandler.OnMouseOut = mouseOutToolStripMenuItem.Checked;
        }

        private void mouseMoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _MouseMoveEventHandler.OnMouseMove = mouseMoveToolStripMenuItem.Checked;
        }

        private void mouseDoubleClickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _MouseDoubleClickEventHandler.OnMouseDoubleClick = mouseDoubleClickToolStripMenuItem.Checked;
        }

        private void timeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (timeToolStripMenuItem.Checked)
            {
                _TimeEventHandler.OnEvent = new EventCatcher(
                    (ComEventDelegate)delegate
                    {
                        DisplayMessage("TimeEvent");
                        return null;
                    });
            }
            else
                _TimeEventHandler.OnEvent = null;
        }

        private void modelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modelToolStripMenuItem.Checked)
            {
                _AddModelEventHandler.OnEvent = new EventCatcher(
                    (ComEventDelegate)delegate
                    {
                        DisplayMessage("ModelEvent");
                        return null;
                    });
            }
            else
                _AddModelEventHandler.OnEvent = null;
        }

        private void stepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (stepToolStripMenuItem.Checked)
            {
                _StepEventHandler.OnEvent = new EventCatcher(
                    (ComEventDelegate)delegate
                    {
                        DisplayMessage("StepEvent");
                        return null;
                    });
            }
            else
                _StepEventHandler.OnEvent = null;
        }

        private void conversationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (conversationToolStripMenuItem.Checked)
            {
                _ConversationEventHandler.OnEvent = new EventCatcher(
                    (ComEventDelegate)delegate
                    {
                        DisplayMessage("ConversationEvent");
                        return null;
                    });
            }
            else
                _ConversationEventHandler.OnEvent = null;
        }

        private void keyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (keyToolStripMenuItem.Checked)
            {
                _KeyEventHandler.OnEvent = new EventCatcher(
                    (ComEventDelegate)delegate
                    {
                        DisplayMessage("KeyEvent");
                        return null;
                    });
            }
            else
                _KeyEventHandler.OnEvent = null;
        }

        private void toolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolToolStripMenuItem.Checked)
            {
                _ToolEventHandler.OnEvent = new EventCatcher(
                    (ComEventDelegate)delegate
                    {
                        DisplayMessage("ToolEvent");
                        return null;
                    });
            }
            else
                _ToolEventHandler.OnEvent = null;
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (menuToolStripMenuItem.Checked)
            {
                _MenuEventHandler.OnEvent = new EventCatcher(
                    (ComEventDelegate)delegate
                    {
                        DisplayMessage("MenuEvent");
                        return null;
                    });
            }
            else
                _MenuEventHandler.OnEvent = null;
        }
    }
}