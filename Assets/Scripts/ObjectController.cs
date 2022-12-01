using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObjectController : MonoBehaviour
{
    public GameObject[] falling_objects;
    public int index;
    public GameObject score_text;
    // Start is called before the first frame update
    void Start()
    {
        index = Random.Range(0, 4);
        falling_objects[index].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y < -15)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "linux")
        {
            if (index != 3)
            {
                score_text.GetComponent<ScoreController>().score++;
            }
            else
            {
                if (score_text.GetComponent<ScoreController>().score > 2)
                    score_text.GetComponent<ScoreController>().score -= 3;
            }
            Destroy(gameObject);
        }
    }
}
