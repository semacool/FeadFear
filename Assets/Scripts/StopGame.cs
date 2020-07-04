using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StopGame : MonoBehaviour
{

    public Text Record;
    public static int rec = 0;

    void Start()
    {
        rec = PlayerPrefs.GetInt("SaveScore");
        Debug.Log("Загрузка рекорда: "+rec);

        Record.text = "" + rec.ToString();
    }

}
