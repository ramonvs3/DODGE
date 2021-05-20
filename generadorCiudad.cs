using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class generadorCiudad : MonoBehaviour
{
    public List<GameObject> roads;
    public float offset = 18.5f;
    // Start is called before the first frame update
    void Start()
    {
        if(roads !=null && roads.Count > 0)
        {
            roads=roads.OrderBy(r => r.transform.position.z).ToList();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveRoad()
    {
        GameObject moveRoad = roads[0];
        roads.Remove(moveRoad);
        float newZ= roads[roads.Count-1].transform.position.z+offset;
        moveRoad.transform.position=new Vector3(0, 0, newZ);
        roads.Add(moveRoad);
    }
}
