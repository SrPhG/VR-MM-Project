using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneswitch3 : MonoBehaviour
{
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.W))
		{
			Application.LoadLevel("RunwayGallery");
		}
	}
}
