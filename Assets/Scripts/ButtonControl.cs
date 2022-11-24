using UnityEngine;
using System.Collections;

public class ButtonControl : MonoBehaviour {
    private Ray ray;
    private RaycastHit hit = new RaycastHit();
    private Vector3 mousepos;
    private Vector3 cameramousepos;
    public Camera g_camera;
    public GameObject player;
    void Update(){
        mousepos = Input.mousePosition;
        cameramousepos = g_camera.ScreenToWorldPoint(new Vector3(mousepos.x,mousepos.y,-100));
        if(Input.GetButton("Fire1")){//....................................down
            ray = new Ray(cameramousepos, Vector3.forward);
            if(Physics.Raycast(ray.origin, ray.direction, out hit, 4000))
            {
                if(hit.collider.name == "right arrow"){
                    player.GetComponent<MoveControl>().move_right();
                }
                if(hit.collider.name == "left arrow"){
                    player.GetComponent<MoveControl>().move_left();
                }
            }
        }
    }
}