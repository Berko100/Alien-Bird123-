using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelarManus : MonoBehaviour
{   // En variabel för rörelsehastigheten
    public float rörelseHastighet = 5;
    // X-position där pelaren ska förstöras 
    public float dödsZon = -45;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        
        // Vi använder Vector3 för att omvandlingen har tre nummer, deltaTime hjälper att det ska gälla samma oavsett frame rate
        transform.position = transform.position + (Vector3.left * rörelseHastighet) * Time.deltaTime;

        if (transform.position.x < dödsZon)
        {
            // Skriver ut ett meddelande i konsolen för att indikera att pelarem har förstörts
            Debug.Log("Pipe Deleted");
            // Förstör pelarobjektet när det når dödszon.
            Destroy(gameObject);
        }
    }
}
