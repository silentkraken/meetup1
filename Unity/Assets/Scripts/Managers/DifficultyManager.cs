using UnityEngine;
using System.Collections;

public class DifficultyManager : Manager {

  public GameObject spawnArea;

  // Enemy types.
  public GameObject basicEnemy;

  // Use this for initialization
  void Start () {
    Debug.Log("Starting DifficultyManager");
  }

  // Update is called once per frame
  void Update () {
    // Spawn an enemy?
    // TODO(dan): Clearly this is just a test. Fix this.
    if (Random.value > 0.98f) {
        SpawnBasicEnemy();
    }
  }

  public override void Restart() {
    Debug.Log("Re-Starting DifficultyManager");
  }

  public void SpawnBasicEnemy() {
    Debug.Log("Spawning a basic enemy.");
    Debug.Log(spawnArea.renderer.bounds.max.z);
    Debug.Log(spawnArea.renderer.bounds.min.z);


    Vector3 position = spawnArea.transform.position;
    position.z += (Random.value - 0.5f) *
        (spawnArea.renderer.bounds.max.z - spawnArea.renderer.bounds.min.z);

    GameObject enemy = (GameObject) GameObject.Instantiate(basicEnemy);
    enemy.transform.position = position;
  }
}
