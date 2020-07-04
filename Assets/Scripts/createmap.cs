using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createmap : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject map1;
    public GameObject map2;
    public GameObject map3;
    public GameObject map4;
    public GameObject map5;
    

    void Start()
    {
        Random rand = new Random();
       
        for (float i = -90f; i < 90f; i += 2.764f)
        {
            for (float j = -90f; j < 90f; j += 2.764f)
            {
                switch (Random.Range(1, 6))
                {
                    case 1: Instantiate(map1, new Vector3(i, 0f, j), Quaternion.Euler(90f, 0f, 0f)); break;
                    case 2: Instantiate(map2, new Vector3(i, 0f, j), Quaternion.Euler(90f, 0f, 0f)); break;
                    case 3: Instantiate(map3, new Vector3(i, 0f, j), Quaternion.Euler(90f, 0f, 0f)); break;
                    case 4: Instantiate(map4, new Vector3(i, 0f, j), Quaternion.Euler(90f, 0f, 0f)); break;
                    case 5: Instantiate(map5, new Vector3(i, 0f, j), Quaternion.Euler(90f, 0f, 0f)); break;
                }
            }
           
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
