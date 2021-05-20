using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoObstaculos : MonoBehaviour
{
    public int rSpeed; 

    public float speed=20;

    // Start is called before the first frame update
    void Start()
    {
        rSpeed = Random.Range(15,25);
        Invoke(nameof(Autodestruccion), 5f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * -rSpeed * Time.deltaTime);
    }

    void Autodestruccion()
    {
        Destroy(gameObject);
    }
}
