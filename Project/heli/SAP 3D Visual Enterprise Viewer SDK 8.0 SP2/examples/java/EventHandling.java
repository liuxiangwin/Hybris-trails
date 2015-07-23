package com.sap.visualenterprise.examples;

import org.eclipse.swt.SWT;
import org.eclipse.swt.ole.win32.Variant;
import org.eclipse.swt.widgets.Composite;
import org.eclipse.swt.widgets.Label;

import com.sap.visualenterprise.viewer.Creator;
import com.sap.visualenterprise.viewer.MouseEvent;
import com.sap.visualenterprise.viewer.MouseEventHandler;
import com.sap.visualenterprise.viewer.MouseEventListener;
import com.sap.visualenterprise.viewer.NodeCollection;
import com.sap.visualenterprise.viewer.NodesSelectedEventListener;
import com.sap.visualenterprise.viewer.ProgressEventListener;
import com.sap.visualenterprise.viewer.Runtime;
import com.sap.visualenterprise.viewer.SceneLoadedEventListener;
import com.sap.visualenterprise.viewer.StepEvent;
import com.sap.visualenterprise.viewer.StepEventHandler;
import com.sap.visualenterprise.viewer.StepEventListener;

public class EventHandling extends ExampleBase {
	@Override
	protected void init(Composite controlFrame)
	{
		Label title = new Label(controlFrame, SWT.NONE);
		title.setText("EventHandling");
	}
	
	@Override
	protected void run()
	{
		final MouseEventListener onMouseEvent = new MouseEventListener() {
			@Override
			public void handleEvent(MouseEvent event)
	    	{
				String mtype = "Unknown";
				
				// Use event.getIs... to filter out interested mouse event
				if (event.getIsDoubleClick())
					mtype = ("Mouse Double Clicked");
				if (event.getIsMouseDown())
					mtype = ("Mouse Down");
				if (event.getIsMouseUp())
					mtype = ("Mouse Up");
				if (event.getIsMouseHit())
					mtype = ("Mouse Hit");
				if (event.getIsMouseOut())
					mtype = ("Mouse Out");
				if (event.getIsMouseOver())
					mtype = ("Mouse Over");
				
	    		System.out.println("Event: " + mtype + ", x: " + event.getMouseX() + ", y: " + event.getMouseY());
	    	}
		};
		
		final NodesSelectedEventListener onNodesSelected = new NodesSelectedEventListener() {
			@Override
			public boolean handleEvent(NodeCollection selected)
			{
				if (selected.getCount() > 0)
				{
					System.out.println("Event: NodesSelected: " + selected.getItem(new Variant(0)).getName());
				}
				
				return false;
			}
		};
		
		final StepEventListener onStepEvent = new StepEventListener() {
			@Override
			public void handleEvent(StepEvent event)
			{
				// Use event.getIs... to filter out interested step event
				if (event.getIsStepStarted())
				{
					print("Event: Step Started");					
				}
				else if (event.getIsStepFinished())
				{
					print("Event: Step Finished");
				}
			}
		};
		
		final SceneLoadedEventListener onSceneLoaded = new SceneLoadedEventListener() {
			@Override
			public void handleEvent(int bResult)
	    	{
	    		System.out.println("Event: SceneLoaded, succeeded: " + bResult);
	    		
	    		// Creator and Runtime are only available after a scene is loaded
	    		// so install other event handlers inside the SceneLoaded event
	    		Creator creator = dv.getCreator();
	    		Runtime runtime = dv.getRuntime();
	    		
	    		MouseEventHandler m = creator.getMouseEventHandler().Create();
	    		m.setOnEvent(onMouseEvent);
	    		// Mouse event filters, comment out to enable the type of event:
	    		m.setOnMouseDown(true);
	    		m.setOnMouseDoubleClick(true);
	    		m.setOnMouseUp(true);
	    		m.setOnMouseHit(true);
	    		// m.setOnMouseMove(true);
	    		m.setOnMouseOut(true);
	    		m.setOnMouseOver(true);
	    		runtime.AddEventHandler(m);
	    		
	    		dv.setNodesSelected(onNodesSelected);
	    		
	    		StepEventHandler s = creator.getStepEventHandler().Create();
	    		s.setOnEvent(onStepEvent);
	    		runtime.AddEventHandler(s);
	    	}
	    };
	    
	    ProgressEventListener onProgress = new ProgressEventListener() {
	    	@Override
	    	public void handleEvent(long prog, long progMax, String message)
	    	{
	    		print("Event: Progress " + prog + " / " + progMax + " Message: " + message);
	    	}
	    };
		
	    dv.setSceneLoaded(onSceneLoaded);
	    dv.setProgress(onProgress);
		dv.LoadFile(folder + "\\models\\RealiteTransmissioncomp Steps.rh");
	}
}
