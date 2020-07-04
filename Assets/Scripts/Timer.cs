using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    public Text textimer;
    public Text MoneyText;
    public GameObject stop;
    int T;

    // Start is called before the first frame update
    void Start()
    {
        T = 0;
        StartCoroutine(Timervoid());
    }

    // Update is called once per frame
    IEnumerator Timervoid()
    {
        while (JoystickMY.S)
        {
            T = Mathf.FloorToInt(Time.timeSinceLevelLoad);
            textimer.text = "" + T.ToString();
            MoneyText.text = "" + GamePlay.Money.ToString();

            if (T > StopGame.rec)
            { 
                PlayerPrefs.SetInt("SaveScore", T);
            }

            yield return new WaitForSeconds(1f);
        }

    }
}
