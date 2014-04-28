using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

  public float movementSpeed = 1f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
    Vector3 pos = transform.position;
    if (Input.GetKey(KeyCode.UpArrow)) {
      pos.z += movementSpeed;
     // DifficultyManager d = Managers.Get<DifficultyManager>();
     // d.SpawnEnemy();
    }
    if (Input.GetKey(KeyCode.DownArrow)) {
      pos.z -= movementSpeed;
    }
    transform.position = pos;
	}
}
