using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class final : MonoBehaviour
{
    public gameController gm;
    public Text puntos;

    public int puntosNum;

    public Button tryAgain;
    
    // Start is called before the first frame update
    void Start()
    {
        gm=FindObjectOfType<gameController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        puntos.text=gm.puntuacion.ToString();

        
        if(Input.GetKeyDown(KeyCode.R)){
            Retry();
        }

        if(Input.GetKeyDown(KeyCode.Escape)){
            Salir();
        }
    }

    public void Retry(){
        SceneManager.LoadSceneAsync("pruebas");
    }

    public void Salir(){
        Application.Quit();
    }


}
