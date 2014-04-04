using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {

	public GameObject bulletType;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) {
			GameObject.Instantiate(bulletType, transform.position, Quaternion.identity);
		}
	}
}
