using UnityEngine;
using System.Collections;

public class PlayerGun : MonoBehaviour {

	public GameObject bulletType;
	public float frequency = 0.5f;

	private float lastShotTime = 0;

	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.Space) &&
			Time.time - lastShotTime > frequency) {
			GameObject.Instantiate(bulletType, transform.position, Quaternion.identity);
			lastShotTime = Time.time;
		}
	}

	void OnDrawGizmosSelected () {
		Gizmos.color = Color.yellow;
		Gizmos.DrawSphere(transform.position, 0.02f);
	}
}

