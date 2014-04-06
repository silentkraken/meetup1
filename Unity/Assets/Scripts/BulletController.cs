using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour {

	public float bulletSpeed;
	public Vector3 bulletDir;

	public Rect clipRect;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position;
		pos += bulletDir.normalized*(bulletSpeed*Time.fixedDeltaTime);
		transform.position = pos;
		
		if (!clipRect.Contains(new Vector2(pos.x, pos.z)))
		{
			Destroy(gameObject);
		}
	}
}
