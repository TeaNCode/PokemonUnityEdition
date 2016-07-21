using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour {

    public Transform target;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float x = target.position.x - transform.position.x;
        float y = target.position.y - transform.position.y;
        transform.Translate(new Vector3(x, y, 0f));
    }
}
