using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAim : MonoBehaviour
{
    public float speed = 10f;
    public GameObject missilePrefab;
    private Rigidbody2D rigidbody;
    public Transform spawn;
    Vector2 force = new Vector2(5, 0);
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(missilePrefab, spawn.position, spawn.rotation);
        }
        rigidbody.AddForce(force * 0 * Time.deltaTime);
    }
}
