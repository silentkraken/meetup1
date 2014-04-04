using UnityEngine;
using System.Collections;

public class DifficultyManager : Manager {

  public GameObject spawnArea;

  // Use this for initialization
  void Start () {
    Debug.Log("Starting DifficultyManager");
  }

  // Update is called once per frame
  void Update () {
  }

  public override void Restart() {
    Debug.Log("Re-Starting DifficultyManager");
  }

  public void SpawnEnemy() {
    Debug.Log("Spawning an enemy.");
  }
}
