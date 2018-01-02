using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCloneGenerator : MonoBehaviour {

	public int cnt;
	public float gap;
	public GameObject obj;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < cnt; i++) {
			for (int j = 0; j < cnt; j++) {
				for (int k = 0; k < cnt; k++) { 
					Instantiate (obj, new Vector3 (i * gap, -j * gap, k * gap), Quaternion.identity);
				}
			}
		}
	}
}
