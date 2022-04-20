using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class melee : MonoBehaviour
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
    void OnCollisionEnter(Collision collision)
    {
        print("he");

        if (collision.collider.tag == "zombie")
        {
            float totalForce = Mathf.Abs(collision.relativeVelocity.x) + Mathf.Abs(collision.relativeVelocity.y) + Mathf.Abs(collision.relativeVelocity.z);
            

            if(totalForce > maxForce)
            {
                totalForce = maxForce;
            }
            collision.gameObject.GetComponent<Health>().Damage(totalForce* meleeDamage);
        }
    }
}
