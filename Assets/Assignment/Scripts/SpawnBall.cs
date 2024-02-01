using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    public float speed = 30f;
    public GameObject ballPrefab;
    public Transform spawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float direction = Input.GetAxis("Vertical");
        transform.Rotate(0, 0, direction * speed * Time.deltaTime);
    }
}
