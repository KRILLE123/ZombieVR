using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public int gunDamage;
    public int gunFireRate;
    public int gunClip;
    public int gunMaxAmmo;
    float lastFired = 0;
    float startTime;
    // Start is called before the first frame update
    void Start()
    {
        lastFired = Time.time;
    }

    public void Fire()
    {
        if(Time.time - lastFired >= gunFireRate)
        {
            lastFired = Time.time;
            GameObject.Find("handgun").GetComponent<Animator>().Play("Entry");
            print("hej");
            RaycastHit hit;

            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);

                if(hit.collider.CompareTag("zombie"))
                {
                    print("pang");
                    hit.collider.GetComponent<Health>().Damage(gunDamage);
                }
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        //Fire();
        //RaycastHit hit;
        //// Does the ray intersect any objects excluding the player layer
        //if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        //{
        //    Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
        //    Debug.Log("Did Hit");
        //}
        //else
        //{
        //    Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
        //    Debug.Log("Did not Hit");
        //}
    }
}
