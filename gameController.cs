using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameController : MonoBehaviour
{
    public Text score;

    public int puntuacion;

    // Start is called before the first frame update
    void Start()
    {
        puntuacion=0;
        StartCoroutine("puntuador");
    }

    void Awake(){
        DontDestroyOnLoad(this.gameObject);
    }

    IEnumerator puntuador()
    {
        while(puntuacion>=0)
        {
            puntuacion++;
            score.text=puntuacion.ToString();
            yield return new WaitForSeconds(0.5f);
        }
    }
}
