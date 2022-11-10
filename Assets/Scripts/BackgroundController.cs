using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    [SerializeField]
    private GameObject background;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        iTween.MoveTo(background, iTween.Hash("x", -4.5, "time", 10, "looptype", iTween.LoopType.pingPong, "easetype", iTween.EaseType.linear));
    }
}
