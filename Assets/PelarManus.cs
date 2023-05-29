using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelarManus : MonoBehaviour
{   // En variabel f�r r�relsehastigheten
    public float r�relseHastighet = 5;
    // X-position d�r pelaren ska f�rst�ras 
    public float d�dsZon = -45;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        
        // Vi anv�nder Vector3 f�r att omvandlingen har tre nummer, deltaTime hj�lper att det ska g�lla samma oavsett frame rate
        transform.position = transform.position + (Vector3.left * r�relseHastighet) * Time.deltaTime;

        if (transform.position.x < d�dsZon)
        {
            // Skriver ut ett meddelande i konsolen f�r att indikera att pelarem har f�rst�rts
            Debug.Log("Pipe Deleted");
            // F�rst�r pelarobjektet n�r det n�r d�dszon.
            Destroy(gameObject);
        }
    }
}
