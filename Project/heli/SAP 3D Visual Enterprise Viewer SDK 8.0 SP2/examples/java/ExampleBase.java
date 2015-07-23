package com.sap.visualenterprise.examples;

import org.eclipse.swt.SWT;
import org.eclipse.swt.layout.RowData;
import org.eclipse.swt.layout.RowLayout;
import org.eclipse.swt.widgets.Composite;
import org.eclipse.swt.widgets.Display;
import org.eclipse.swt.widgets.Shell;

import com.sap.visualenterprise.viewer.DeepView;

public abstract class ExampleBase {
	private Display			display;
	private Shell			shell;
	private Composite		controlFrame;
	protected String		folder = System.getProperty("user.dir");
	
	// SAP Visual Enterprise Viewer control
	protected DeepView		dv;
	
	private final void setUp()
	{
		// Create SWT window
		display = new Display();
	    shell = new Shell(display);
	    shell.setSize(640, 510);
	    shell.setMinimumSize(640, 510);
	    shell.setText("SAP Visual Enterprise Viewer for Java Example");
	    
	    // Add window layout
	    RowLayout layout = new RowLayout();
	    layout.type = SWT.VERTICAL;
	    layout.fill = true;
	    layout.spacing = 1;
	    layout.marginWidth = layout.marginHeight = 1;
	    shell.setLayout(layout);
	    
	    // Create SAP Visual Enterprise Viewer control
	    dv = new DeepView(shell);
	    RowData rdv = new RowData(640, 480);
	    dv.getOleFrame().setLayoutData(rdv);
	    
	    // Create control frame at bottom of window for examples
	    RowData rd = new RowData(640, 30);
	    controlFrame = new Composite(shell, SWT.NONE);
	    controlFrame.setLayoutData(rd);
	    RowLayout layout2 = new RowLayout();
	    layout2.type = SWT.HORIZONTAL;
	    layout2.fill = true;
	    layout2.spacing = 1;
	    layout2.marginWidth = layout.marginHeight = 1;
	    controlFrame.setLayout(layout2);
	}
	
	// Put example specific UI elements here
	protected void init(Composite controlFrame)
	{
	}
	
	// Run the example core
	protected abstract void run();
	
	private final void tearDown()
	{
		// Wait for events and clean up
		while (!shell.isDisposed()) {
		    if (!display.readAndDispatch())
		    	display.sleep();
		}

		display.dispose();
	}
	
	protected void print(String t)
	{
		System.out.println(t);
	}
	
	public ExampleBase()
	{
		setUp();
		init(controlFrame);
		controlFrame.pack();
	    shell.pack();
	    shell.open();
		run();
		tearDown();
	}
}
