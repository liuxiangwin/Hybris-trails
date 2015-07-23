package com.sap.visualenterprise.examples;

import org.eclipse.swt.SWT;
import org.eclipse.swt.events.SelectionAdapter;
import org.eclipse.swt.events.SelectionEvent;
import org.eclipse.swt.widgets.Button;
import org.eclipse.swt.widgets.Composite;
import org.eclipse.swt.widgets.Label;

public class GetScreenshot extends ExampleBase {
	@Override
	protected void init(Composite controlFrame)
	{
		Label title = new Label(controlFrame, SWT.NONE);
		title.setText("GetScreenshot");
		
		// Save Screenshot to file
		Button btnSaveFile = new Button(controlFrame, SWT.NONE);
		btnSaveFile.setText("Save Screenshot to File");
		btnSaveFile.addSelectionListener(new SelectionAdapter() {
			@Override
			public void widgetSelected(SelectionEvent e)
			{
				String path = dv.SaveScreenshot("PNG", 640, 480);
				
				print("Screenshot saved to file: " + path);
			}
		});	

		// Get Screenshot as hex encoded R8G8B8 pixels
		Button btnGetHexR8G8B8 = new Button(controlFrame, SWT.NONE);
		btnGetHexR8G8B8.setText("Get Screenshot as hex R8G8B8 pixel data");
		btnGetHexR8G8B8.addSelectionListener(new SelectionAdapter() {
			@Override
			public void widgetSelected(SelectionEvent e)
			{
				String pixels = dv.GetScreenshot(640, 480);
				
				print("Screenshot hex encoded R8G8B8 data: " + pixels.substring(0, 64) + "..." + pixels.substring(pixels.length() - 64));
			}
		});	
	}
	
	@Override
	protected void run()
	{
		dv.LoadFile(folder + "\\models\\MVsStepsCalloutsMetadata.rh");
	}
}
