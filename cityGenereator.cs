using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cityGenereator : MonoBehaviour
{
    public Transform city;
    public float citySpeed;

    public List<Transform> cityPieces;
    public Transform cityPiece;

    Transform lastPiece;
    // Start is called before the first frame update
    void Start()
    {
        generateCity();
    }

    // Update is called once per frame
    void Update()
    {
        city.Translate(Vector3.back * citySpeed * Time.deltaTime);
    }

    void generateCity()
    {
        lastPiece = cityPiece;

        cityPiece = cityPieces[Random.Range(0, cityPieces.Count)];
        cityPiece.position = new Vector3(0, 0, lastPiece.position.z + 18.5f);
        cityPiece.gameObject.SetActive(true);
        cityPiece.SetParent(city);

        cityPieces.Remove(cityPiece);
        Invoke(nameof(generateCity), 1.85f);
    }

    private void OnTriggerEnter(Collider other)
    {
        Transform t = other.GetComponent<Transform>();
        t.SetParent(null);
        cityPieces.Add(t);
        other.gameObject.SetActive(false);
    }
}
