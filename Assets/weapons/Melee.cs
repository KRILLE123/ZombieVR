using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melee : MonoBehaviour
{
    public int meleeDamage;
    public int maxForce;
    // Start is called before the first frame update
    void Start()
    {
        print("he");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        print("byyu");
        if (collider.CompareTag("zombie"))
        {
            print("as");
            //float totalForce = Mathf.Abs(collider..relativeVelocity.x) + Mathf.Abs(collision.relativeVelocity.y) + Mathf.Abs(collision.relativeVelocity.z);


            //if (totalForce > maxForce)
            //{
            //    totalForce = maxForce;
            //}
            collider.gameObject.GetComponent<Health>().Damage(meleeDamage);
        }
    }

}
