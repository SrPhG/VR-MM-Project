using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneswitch4 : MonoBehaviour
{
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.W))
		{
			Application.LoadLevel("RunwayStreet");
		}
	}
}
