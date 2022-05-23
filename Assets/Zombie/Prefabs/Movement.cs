using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update

    GameObject target;
    GameObject ground;
    void Start()
    {
        target = GameObject.Find("AvatarObjects");
        gameObject.GetComponent<Animator>().Play("Entry");
        for (int i = 0; i < transform.childCount; i++)
        {
            if(transform.GetChild(i).name == "groundOffset")
            {
                ground = transform.GetChild(i).gameObject;
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookPos = new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z);
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(lookPos - transform.position), 1.5f * Time.deltaTime);
        Vector3 diff = Vector3.Normalize(target.transform.position - transform.position) * Time.deltaTime;

        RaycastHit hit;
        if (Physics.Raycast(ground.transform.position, Vector3.down, out hit))
        {
            transform.position = new Vector3(transform.position.x, hit.point.y, transform.position.z);
        }
        transform.position += diff;
    }
}
