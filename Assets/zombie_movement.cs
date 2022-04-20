using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombie_movement : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject target;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 diff = Vector3.Normalize(target.transform.position - transform.position) * Time.deltaTime;
        transform.position += diff;
    }
}
