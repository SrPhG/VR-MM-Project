using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneswitch2 : MonoBehaviour
{
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.W))
		{
			Application.LoadLevel("RunwayWarehouse");
		}
	}
}
