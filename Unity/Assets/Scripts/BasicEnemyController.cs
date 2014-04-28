using UnityEngine;
using System.Collections;

public class BasicEnemyController : MonoBehaviour {

    public float speed;
    public Vector3 direction;

    public Rect clipRect;

    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update () {
        Vector3 position = transform.position;
        position += direction.normalized * (speed * Time.fixedDeltaTime);
        transform.position = position;

        if (!clipRect.Contains(new Vector2(position.x, position.z))) {
            Destroy(gameObject);
        }
    }
}
