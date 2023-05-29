using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelarSpawnManus : MonoBehaviour
{   // G�r en referens f�r pelarna 
    public GameObject pelare;
    // Tidsintervall mellan pelarSpawner 
    public float spawnRate = 2;
    // Timer f�r att h�lla koll p� tidden mellan spawnar 
    private float timer = 0;
    // Vertikal f�rskjutning f�r pelarposition 
    public float heightOffset = 10;

    // Start is called before the first frame update
    void Start()
    {
        // Spawnar en pelare n�r spelet startar 
        spawnPelare();
    }

    // Update is called once per frame
    void Update()
    {  // F�r att kunna spawna pelarna
        if (timer < spawnRate)
        {  // �kar timerv�rdet med tiden som g�tt sedan f�rra uppdateringen 
            timer = timer + Time.deltaTime;
        }
        else
        {  // Spawnar en pelare n�r timern n�r spawnRate-v�rdet 
            spawnPelare();
           // �terst�ller timern till o 
            timer = 0;
        }
        

    }
    void spawnPelare()
    {
        // L�gsta m�jligha Y-position f�r pelaren 
        float l�gstaPo�ng = transform.position.y - heightOffset; 
        // H�gsta m�jligha Y-position f�r pelaren 
        float h�gstaPo�ng = transform.position.y - heightOffset;
        // Skapar en ny instans av pelare-objektet med en slumpm�ssig Y-position inom det definerade intervallet. S� att pelarna inte spawnar i samma st�lle hela tiden. 
        Instantiate(pelare, new Vector3(transform.position.x, Random.Range(l�gstaPo�ng, h�gstaPo�ng), 0), transform.rotation);
    }
}
