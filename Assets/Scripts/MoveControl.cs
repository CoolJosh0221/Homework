using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveControl : MonoBehaviour
{
    public int score;
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
        transform.position += new Vector3(0.1f, 0, 0);
        transform.localScale = new Vector3(-0.1f, 0.1f, 1f);
    }

    public void move_left()
    {
        transform.position += new Vector3(-0.1f, 0, 0);
        transform.localScale = new Vector3(0.1f, 0.1f, 1f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);   
        score++;
    }
}
