using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie_Spawner : MonoBehaviour
{
    public List<GameObject> zombies = new List<GameObject>();
    public int level = 0;
    public GameObject zombie;

    void Start()
    {
        NextLevel();
    }

    // Update is called once per frame
    void Update()
    {
        int count = 0;
        for (int i = 0; i < zombies.Count; i++)
        {
            if(zombies[i].gameObject == null)
            {
                count++;
            }
        }
        if(count == zombies.Count)
        {
            StartCoroutine(NextLevel());
        }
    }

    //public void NextLevel()
    //{
    //    level++;
    //    for (int i = 0; i < level; i++)
    //    {
    //        print(level);
    //        GameObject loadedZombie = Instantiate(zombie, new Vector3(0, 0, 0), Quaternion.identity);
    //        loadedZombie.GetComponent<Health>().health = 100;
    //        zombies.Add(loadedZombie);
    //    }
    //}

    IEnumerator NextLevel()
    {
        level++;
        for (int i = 0; i < level; i++)
        {
            print("spawned");
            GameObject loadedZombie = Instantiate(zombie, new Vector3(-3.776f, 4.993f, 2.464f), Quaternion.identity);
            loadedZombie.GetComponent<Health>().health = 100;
            zombies.Add(loadedZombie);
        }
        yield return new WaitForSeconds(1);
    }
}
