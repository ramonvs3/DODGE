using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    generadorCiudad GeneradorCiudad;
    // Start is called before the first frame update
    void Start()
    {
        GeneradorCiudad=GetComponent<generadorCiudad>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpwanTriggerEntered()
    {
        GeneradorCiudad.MoveRoad();
    }
}
