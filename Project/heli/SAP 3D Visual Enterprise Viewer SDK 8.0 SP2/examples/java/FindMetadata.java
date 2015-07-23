package com.sap.visualenterprise.examples;

import java.util.HashMap;
import java.util.Iterator;
import java.util.Map;
import java.util.Map.Entry;

import org.eclipse.swt.SWT;
import org.eclipse.swt.events.SelectionAdapter;
import org.eclipse.swt.events.SelectionEvent;
import org.eclipse.swt.layout.RowData;
import org.eclipse.swt.ole.win32.Variant;
import org.eclipse.swt.widgets.Button;
import org.eclipse.swt.widgets.Composite;
import org.eclipse.swt.widgets.Label;
import org.eclipse.swt.widgets.Text;

import com.sap.visualenterprise.viewer.MetadataVariable;
import com.sap.visualenterprise.viewer.Node;
import com.sap.visualenterprise.viewer.SceneLoadedEventListener;
import com.sap.visualenterprise.viewer.SceneObjectList;

public class FindMetadata extends ExampleBase {
	@Override
	protected void init(Composite controlFrame)
	{
		Label title = new Label(controlFrame, SWT.NONE);
		title.setText("FindMetadata");
		
		final Text txtSearch = new Text(controlFrame, SWT.NONE);
		RowData cd = new RowData(180, 28);
		txtSearch.setLayoutData(cd);
		
		// Select node based on metadata value
		Button btnSearch = new Button(controlFrame, SWT.NONE);
		btnSearch.setText("Select by Metadata Value");
		btnSearch.addSelectionListener(new SelectionAdapter() {
			@Override
			public void widgetSelected(SelectionEvent e)
			{
				String val = txtSearch.getText();				
				Iterator<Entry<Node, Map<String, String>>> iter = sceneMetaData.entrySet().iterator();
				
				while (iter.hasNext())
				{
					Map.Entry<Node, Map<String, String>> pairs = (Map.Entry<Node, Map<String,String>>) iter.next();
					
					Node node = pairs.getKey();
					Map<String, String> meta = pairs.getValue();
					
					if (meta.containsKey(val) || meta.containsValue(val))
					{
						node.setSelected(true);
					}
				}
			}
		});
	}
	
	@Override
	protected void run()
	{
		final SceneLoadedEventListener onSceneLoaded = new SceneLoadedEventListener() {
			@Override
			public void handleEvent(int bResult)
	    	{
				getNodeMetadataStrings();
	    	}
		};
		
		sceneMetaData = new HashMap<Node, Map<String, String>>();
		
		dv.setSceneLoaded(onSceneLoaded);
		dv.LoadFile(folder + "\\models\\meta.rh");
	}
	
	private void getNodeMetadataStrings()
	{
		SceneObjectList nodes = dv.getScene().getNodes();
		long count = nodes.getCount();
		
		for (long i = 0; i < count; i ++)
		{
			Node node = nodes.GetByIndex(i).toNode();
			
			populateMetadataForNode(node, node.getMetadata(), "");
		}
	}
	
	private void populateMetadataForNode(Node node, MetadataVariable meta, String path)
	{
		// Recursively get metadata entries for node, store them in a map in flattened key->value pairs
		if (node == null || meta == null)
			return;
		
		final String T_ARRAY = meta.getTYPE_ARRAY();
		final String T_OBJECT = meta.getTYPE_OBJECT();
		
		String type = meta.getType();
		
		if (type.equals(T_ARRAY) || type.equals(T_OBJECT))
		{
			int size = meta.getSize();
			
			for (int i = 0; i < size; i ++)
			{
				String key = meta.KeyAt(i).toString();
				MetadataVariable value = meta.ValueAt(i);
				
				String newPath;				
				if (!path.isEmpty())
					newPath = path + "/" + key;
				else
					newPath = key;
				
				populateMetadataForNode(node, value, newPath);
			}
		}
		
		final String T_STRING = meta.getTYPE_STRING();
		
		if (type.equals(T_STRING))
		{
			Variant val = meta.getValue();
			if (val != null)
			{
				Map<String, String> nodeMeta;
				
				if (!sceneMetaData.containsKey(node))
				{
					nodeMeta = new HashMap<String, String>();
					sceneMetaData.put(node, nodeMeta);
				}
				else
				{
					nodeMeta = sceneMetaData.get(node);
				}
				
				nodeMeta.put(path, val.getString());
			}
		}
	}
	
	private Map<Node, Map<String, String>> sceneMetaData;
}
