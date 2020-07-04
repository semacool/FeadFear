using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnbone : MonoBehaviour
{
    public GameObject Bone;
    public GameObject bonusHP;
    public GameObject bonusSPEED;
    public GameObject Money;
    public GameObject bomb;
    public Transform Dog;



    void Start()
    {

        StartCoroutine(Spawners());
    }
    IEnumerator Spawners()
    {

        while (true)
        {
            Instantiate(Bone, new Vector3(Random.Range(-50f, 50f), 0f, Random.Range(-52f, 52f)), Quaternion.Euler(90f, Random.Range(-180, 180), 0f));
            Instantiate(bonusHP, new Vector3(Random.Range(-50f, 50f), 0f, Random.Range(-52f, 52f)), Quaternion.Euler(90f, Random.Range(-180, 180), 0f));
            Instantiate(bonusSPEED, new Vector3(Random.Range(-50f, 50f), 0f, Random.Range(-52f, 52f)), Quaternion.Euler(90f, Random.Range(-180, 180), 0f));
            Instantiate(Money, new Vector3(Random.Range(-50f, 50f), 0f, Random.Range(-52f, 52f)), Quaternion.Euler(90f, Random.Range(-180, 180), 0f));
            Instantiate(bomb, Dog.position, Quaternion.Euler(90f, Random.Range(-180, 180), 0f));


            yield return new WaitForSeconds(4f);

        }
    }
}
