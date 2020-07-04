using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveDog : MonoBehaviour
{
    public Animator DogAnim;
    public Transform Purpose;
    public NavMeshAgent agent;
    public Transform Arrow;
    public SpriteRenderer SpriteArrow;
    public SpriteRenderer SpriteDanger;
    public BoxCollider godmod;

    public static bool D;

    // Start is called before the first frame update
    void Start()
    {
        
        D = true;
        StartCoroutine(Timervoid());

    }

    // Update is called once per frame
    void Update()     
    {
        godmod.enabled = D;
        var color = SpriteArrow.color;
        var color2 = SpriteDanger.color;

        Vector2 dogOnScreen = Camera.main.WorldToViewportPoint(transform.position);
        Vector2 positionOnScreen = Camera.main.WorldToViewportPoint(Arrow.transform.position);

        float angle = AngleBetweenTwoPoints(positionOnScreen, dogOnScreen);

        Arrow.transform.rotation = Quaternion.Euler(new Vector3(90f, -angle + 90f, 0));


        color.a = 1f - longBetweenTwoPoints(positionOnScreen, dogOnScreen);
        color2.a = 1f - longBetweenTwoPoints(positionOnScreen, dogOnScreen);


        SpriteDanger.color = color2;
        SpriteArrow.color = color;
        if (D) { agent.SetDestination(Purpose.position); StopCoroutine(MoveDoge()); }
        else { agent.speed /= 1.01f ; StartCoroutine(MoveDoge());  }
    }

    IEnumerator Timervoid()
    {
        

        while (true)
        {
            double T = Mathf.FloorToInt(Time.time);

            agent.speed += 1f;
            yield return new WaitForSeconds(1f);
        }   

    }

    float AngleBetweenTwoPoints(Vector3 a, Vector3 b)
    {
        return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
    }

    float longBetweenTwoPoints(Vector3 a, Vector3 b)
    {
        return Mathf.Sqrt(Mathf.Pow(a.x - b.x, 2) + Mathf.Pow(a.y - b.y, 2));
    }

    IEnumerator MoveDoge()
    {
        DogAnim.SetBool("Eat", true);
        yield return new WaitForSeconds(2f);
        D = true;
       // Debug.Log(D);
        DogAnim.SetBool("Eat", false);
        
       
    }


}
