package com.sap.visualenterprise.examples;

import org.eclipse.swt.SWT;
import org.eclipse.swt.events.SelectionAdapter;
import org.eclipse.swt.events.SelectionEvent;
import org.eclipse.swt.ole.win32.Variant;
import org.eclipse.swt.widgets.Button;
import org.eclipse.swt.widgets.Composite;
import org.eclipse.swt.widgets.Label;

import com.sap.visualenterprise.viewer.Node;
import com.sap.visualenterprise.viewer.SceneObject;
import com.sap.visualenterprise.viewer.SceneObjectList;
import com.sap.visualenterprise.viewer.Vector3;

public class TranslateRotateScale extends ExampleBase {
	@Override
	protected void init(Composite controlFrame)
	{
		Label title = new Label(controlFrame, SWT.NONE);
		title.setText("TranslateRotateScale");
		
		// Move node in world coordinates
		Button btnWorldMove = new Button(controlFrame, SWT.NONE);
		btnWorldMove.setText("World Move");
		btnWorldMove.addSelectionListener(new SelectionAdapter() {
			@Override
			public void widgetSelected(SelectionEvent e)
			{
				Node node = getSelected();
				
				if (node == null)
				{
					badNodeWarning();
					return;
				}
				
				// Create translate vector
				Vector3 v = dv.getCreator().getVector3().Create(10, 0, 0);

				// In-place transform of selected node by translation (linear move)
				node.getTransform().TranslateInPlace(v);
				
				updateScene();
			}
		});
		
		// Rotate node in world coordinates
		Button btnWorldRotate = new Button(controlFrame, SWT.NONE);
		btnWorldRotate.setText("World Rotate");
		btnWorldRotate.addSelectionListener(new SelectionAdapter() {
			@Override
			public void widgetSelected(SelectionEvent e)
			{
				Node node = getSelected();
				
				if (node == null)
				{
					badNodeWarning();
					return;
				}
				
				// In-place transform of selected node by rotation around Z axis
				node.getTransform().RotateAboutZInPlace(3.14159 / 7);
				
				updateScene();
			}
		});
		
		// Scale node in world coordinates
		Button btnWorldScale = new Button(controlFrame, SWT.NONE);
		btnWorldScale.setText("World Scale");
		btnWorldScale.addSelectionListener(new SelectionAdapter() {
			@Override
			public void widgetSelected(SelectionEvent e)
			{
				Node node = getSelected();
				
				if (node == null)
				{
					badNodeWarning();
					return;
				}
				
				// In-place transform of selected node by scaling among x/y/z axes
				node.getTransform().ScaleInPlace(1.1, 1.1, 1.1);
				
				updateScene();
			}
		});
		
		// Move node in local coordinates
		Button btnLocalMove = new Button(controlFrame, SWT.NONE);
		btnLocalMove.setText("Local Move");
		btnLocalMove.addSelectionListener(new SelectionAdapter() {
			@Override
			public void widgetSelected(SelectionEvent e)
			{
				Node node = getSelected();
				
				if (node == null)
				{
					badNodeWarning();
					return;
				}
				
				// Create translate vector
				Vector3 v = dv.getCreator().getVector3().Create(10, 0, 0);
				
				// To do local translation, we apply the direction vector with parent's transformation
				v = node.getParent().getTransform().TransformDirection(v);

				// Then use the transformed direction for node translation
				node.getTransform().TranslateInPlace(v);
				
				updateScene();
			}
		});
		
		// Rotate node in local coordinates
		Button btnLocalRotate = new Button(controlFrame, SWT.NONE);
		btnLocalRotate.setText("Local Rotate");
		btnLocalRotate.addSelectionListener(new SelectionAdapter() {
			@Override
			public void widgetSelected(SelectionEvent e)
			{
				Node node = getSelected();
				
				if (node == null)
				{
					badNodeWarning();
					return;
				}
				
				// Get translation vector for selected object
				Vector3 vFromOrigin = node.getTransform().getTranslation();
				// Inverse transform vector which puts object in world origin (0,0,0)
				Vector3 vToOrigin = dv.getCreator().getVector3().Create(-vFromOrigin.getX(), -vFromOrigin.getY(), -vFromOrigin.getZ());
				
				// Inverse transform the object so it sets at (0,0,0) coordinates
				node.getTransform().TranslateInPlace(vToOrigin);

				// Rotation then takes place around (0,0,0)
				node.getTransform().RotateAboutZInPlace(3.14159 / 7);

				// Transform the object back to it's original position
				node.getTransform().TranslateInPlace(vFromOrigin);
				
				updateScene();
			}
		});
		
		// Scale node in local coordinates
		Button btnLocalScale = new Button(controlFrame, SWT.NONE);
		btnLocalScale.setText("Local Scale");
		btnLocalScale.addSelectionListener(new SelectionAdapter() {
			@Override
			public void widgetSelected(SelectionEvent e)
			{
				Node node = getSelected();
				
				if (node == null)
				{
					badNodeWarning();
					return;
				}
				
				// Get translation vector for selected object
				Vector3 vFromOrigin = node.getTransform().getTranslation();
				// Inverse transform vector which puts object in world origin (0,0,0)
				Vector3 vToOrigin = dv.getCreator().getVector3().Create(-vFromOrigin.getX(), -vFromOrigin.getY(), -vFromOrigin.getZ());
				
				// Inverse transform the object so it sets at (0,0,0) coordinates
				node.getTransform().TranslateInPlace(vToOrigin);

				// Scale then takes place around (0,0,0)
				node.getTransform().ScaleInPlace(1.1, 1.1, 1.1);
				
				// Transform the object back to it's original position
				node.getTransform().TranslateInPlace(vFromOrigin);
				
				updateScene();
			}
		});
	}
	
	@Override
	protected void run()
	{
		// Load blank scene
		dv.LoadFile(folder + "\\models\\4 materials.rh");		
	}
	
	private void badNodeWarning()
	{
		print("Warning: nothing selected");
	}
	
	private void updateScene()
	{
		dv.getScene().Update();
	}
	
	private Node getSelected()
	{
		SceneObjectList coll = dv.getScene().getNodes();
		
		for (int i = 0; i < coll.getCount(); i ++)
		{
			SceneObject obj = coll.getItem(new Variant(i));
			if (obj.getType().getIsRenderable())
			{
				Node n = obj.toNode();
				
				if (n.getSelected())
					return n;
			}
		}
		
		return null;
	}
}
