package com.sap.visualenterprise.examples;

import org.eclipse.swt.SWT;
import org.eclipse.swt.events.SelectionAdapter;
import org.eclipse.swt.events.SelectionEvent;
import org.eclipse.swt.widgets.Button;
import org.eclipse.swt.widgets.Composite;
import org.eclipse.swt.widgets.Label;

import com.sap.visualenterprise.viewer.Matrix4x4;
import com.sap.visualenterprise.viewer.Node;
import com.sap.visualenterprise.viewer.Resource;

public final class AssemblyLoading extends ExampleBase {
	@Override
	protected void init(Composite controlFrame)
	{
		Label title = new Label(controlFrame, SWT.NONE);
		title.setText("AssemblyLoading");
		
		Button btnAddModel = new Button(controlFrame, SWT.NONE);
		btnAddModel.setText("Add Model");
		
		btnAddModel.addSelectionListener(new SelectionAdapter() {
			@Override
			public void widgetSelected(SelectionEvent e)
			{
				// Add model to current scene
				addModel(folder + "\\models\\rh.rh", 0.0f, 0.0f, 0.5f);
			}
		});
	}
	
	@Override
	protected void run()
	{
		// Load blank scene
		dv.LoadFile("data:blank");		
	}
	
	private void addModel(String file, float x, float y, float z)
	{
		// Load target file into a resource object
		Resource resource = dv.getCreator().getResource().Create(file);
		Node node = null;
		
		try
		{
			// AddModel by resource object
			node = dv.getScene().AddModel(resource);
		}
		catch (Exception e)
		{
			print("Exception in addModel()");
		}
		
		if (node == null)
		{
			print("addModel failed to load: " + file);
			return;
		}
		
		Matrix4x4 moveVector = dv.getCreator().getMatrix4x4().Create3(1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, x, y, z, 1);
		
		// The added model is nested under the 'node' object, which can be transformed to position the added model in the scene
		node.setTransform(moveVector);
		print("added Model at (" + x + "," + y + "," + z + ")");
	}
}
