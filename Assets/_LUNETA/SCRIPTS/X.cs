using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using HutongGames.PlayMaker;

public class X : MonoBehaviour
{
    public GameObject spawnGameObject;
    bool noShoot;

    void Update()
    {
        noShoot = FsmVariables.GlobalVariables.GetFsmBool("NOSHOOT").Value;
        if (Input.GetMouseButtonDown(0))
        {
            if (EventSystem.current.IsPointerOverGameObject(Input.GetTouch(0).fingerId) == false && noShoot == false)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out RaycastHit hit))
                {
                    GameObject gobj = Instantiate(spawnGameObject, Camera.main.transform.position + (ray.direction * 17.5f), Quaternion.identity);
                }
            }
        }
    }
}