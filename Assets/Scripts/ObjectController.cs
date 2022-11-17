using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{   public GameObject[] falling_objects;
    // Start is called before the first frame update
    void Start()
    {
        falling_objects[Random.Range(0, 3)].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y < -15)
        {
            GameObject.Destroy(gameObject);
        }
    }
}
