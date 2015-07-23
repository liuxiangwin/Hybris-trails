package com.sap.visualenterprise.examples;

import org.eclipse.swt.SWT;
import org.eclipse.swt.events.SelectionAdapter;
import org.eclipse.swt.events.SelectionEvent;
import org.eclipse.swt.widgets.Button;
import org.eclipse.swt.widgets.Composite;
import org.eclipse.swt.widgets.Label;

public class FileSaving extends ExampleBase {
	@Override
	protected void init(Composite controlFrame)
	{
		Label title = new Label(controlFrame, SWT.NONE);
		title.setText("FileSaving");
		
		Button btnAddModel = new Button(controlFrame, SWT.NONE);
		btnAddModel.setText("Save As RH File");
		
		btnAddModel.addSelectionListener(new SelectionAdapter() {
			@Override
			public void widgetSelected(SelectionEvent e)
			{
				// Add model to current scene
				saveAsRhFile(folder + "\\models\\_temp_saveas.rh");
			}
		});
	}
	
	@Override
	protected void run()
	{
		dv.LoadFile(folder + "\\models\\RealiteTransmissioncomp Steps.rh");		
	}
	
	private void saveAsRhFile(String file)
	{
		int showDialog = 1;
		
		// showDialog = 0: silent background save
		// showDialog = 1: shows progress modal dialog
		dv.SaveAsRH(file, showDialog);
	}
}
