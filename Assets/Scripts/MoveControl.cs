using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void move_right()
    {
        transform.position += new Vector3(0.5f, 0, 0);
    }

    public void move_left()
    {
        transform.position += new Vector3(-0.5f, 0, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);   
    }
}
