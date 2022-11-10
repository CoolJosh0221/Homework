using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyController : MonoBehaviour
{    
    [SerializeField] private GameObject linux;
    // Start is called before the first frame update
    void Start()
    {
        Copy();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Copy()
    {
        GameObject cloned_obj = Instantiate(linux);
        cloned_obj.SetActive(true);
        cloned_obj.transform.position = new Vector3(Random.Range(-10, 10), 10, 0);
        iTween.MoveTo(gameObject, iTween.Hash("time", Random.Range(0.01f, 0.5f), "oncomplete", "Copy", "oncompletetarget", gameObject));
    }
}
