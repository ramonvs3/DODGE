using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerController : MonoBehaviour
{
    public int movSpeed=14;
    public List<GameObject> obsPref;

    public int rCount;

    public float rTime;
    // Start is called before the first frame update
    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        float vMovement=movSpeed;

        transform.Translate(new Vector3(0, 0, vMovement)*Time.deltaTime);
    }
    void Spawn()
    {
        rTime = Random.Range(1f, 2f);
        rCount = Random.Range(0, obsPref.Count);
        Instantiate(obsPref[rCount], transform.position, transform.rotation);
        Invoke("Spawn", rTime);
    }
}
