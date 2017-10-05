using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class CameraDrawModes
{

	[Test]
	public void DeferredModesAreDisabled()
	{
	    SceneView sceneView = EditorWindow.GetWindow<SceneView>();
	    Assert.IsFalse(sceneView.IsCameraDrawModeEnabled(SceneView.GetBuiltinCameraMode(DrawCameraMode.DeferredDiffuse)), "Deferred modes should always be disabled under SRP");
	}
}
