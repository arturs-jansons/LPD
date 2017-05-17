using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pacelt : MonoBehaviour
{
    private RaycastHit hit;
    public float rayLenght;
    bool skatas = false;

    void Start()
    {
        rayLenght = 1f;
    }

    void Update()
    {
        Debug.DrawRay(Camera.main.transform.position, Camera.main.transform.forward * rayLenght, Color.red, 2f);

        if(Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, rayLenght))
        {
            if(hit.collider.tag == "Dimants")
            {
                Debug.Log(hit.collider.name);
                skatas = true;

                if(Input.GetKeyDown(KeyCode.E))
                {
                    Destroy(GameObject.FindWithTag("Dimants"));
                }
            }
            else if (hit.collider.tag == "Kugis")
            {
                Debug.Log(hit.collider.name);
                skatas = true;

                if (Input.GetKeyDown(KeyCode.E))
                {
                    Destroy(GameObject.FindWithTag("Kugis"));
                }
            }
            else if (hit.collider.tag == "Galds")
            {
                Debug.Log(hit.collider.name);
                skatas = true;

                if (Input.GetKeyDown(KeyCode.E))
                {
                    Destroy(GameObject.FindWithTag("Galds"));
                }
            }
            else if (hit.collider.tag == "Astro")
            {
                Debug.Log(hit.collider.name);
                skatas = true;

                if (Input.GetKeyDown(KeyCode.E))
                {
                    Destroy(GameObject.FindWithTag("Astro"));
                }
            }
            else if (hit.collider.tag == "Glaze")
            {
                Debug.Log(hit.collider.name);
                skatas = true;

                if (Input.GetKeyDown(KeyCode.E))
                {
                    Destroy(GameObject.FindWithTag("Glaze"));
                }
            }
        }
        else { 
            skatas = false;
        }
    }
    void OnGUI()
    {
        if (skatas == true)
        {
            GUI.Box(new Rect(Screen.width / 2, Screen.height / 2 + 150, 100, 25), "Spied E");
        }
    }
}
