using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;




public class GamePlay : MonoBehaviour
{
    public static float heroHP;
    public static float Money;
    public Transform dogy;
    private AudioSource Audio;
     public GameObject Panel;
    public GameObject NameDiy1;
    public GameObject NameDiy2;

    public CapsuleCollider Bone;
    public Transform Dog;

    private void Awake()
    {
      
    }

    void Start()
    {

        Time.timeScale = 1f;
        Audio = GetComponent<AudioSource>();
        heroHP = 10f;
        Money = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (heroHP <= 0f )
        {
            
            Panel.SetActive(true);
            NameDiy1.SetActive(true);
            Time.timeScale = 0f;
        }

        if (JoystickMY.speed <= 0f)
        {
           
            Panel.SetActive(true);
            NameDiy2.SetActive(true);
            Time.timeScale = 0f;
            
        }
        if (heroHP > 10f) { heroHP = 10f; }
       

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Dogs")
        {
            MoveDog.D = false;
            Audio.Play();
            heroHP = heroHP - 4f;
        }

    }

    public void OnMouseDown()
    {
        if (Money >= 5f)
        {
            Instantiate(Bone, new Vector3(Dog.position.x, 0f, Dog.position.z), Quaternion.Euler(90f, Random.Range(-180, 180), 0f));

            Money -= 5f;
        }
    }

}
