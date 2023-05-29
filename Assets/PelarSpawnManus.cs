using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelarSpawnManus : MonoBehaviour
{   // Gör en referens för pelarna 
    public GameObject pelare;
    // Tidsintervall mellan pelarSpawner 
    public float spawnRate = 2;
    // Timer för att hålla koll på tidden mellan spawnar 
    private float timer = 0;
    // Vertikal förskjutning för pelarposition 
    public float heightOffset = 10;

    // Start is called before the first frame update
    void Start()
    {
        // Spawnar en pelare när spelet startar 
        spawnPelare();
    }

    // Update is called once per frame
    void Update()
    {  // För att kunna spawna pelarna
        if (timer < spawnRate)
        {  // Ökar timervärdet med tiden som gått sedan förra uppdateringen 
            timer = timer + Time.deltaTime;
        }
        else
        {  // Spawnar en pelare när timern når spawnRate-värdet 
            spawnPelare();
           // Återställer timern till o 
            timer = 0;
        }
        

    }
    void spawnPelare()
    {
        // Lägsta möjligha Y-position för pelaren 
        float lägstaPoäng = transform.position.y - heightOffset; 
        // Högsta möjligha Y-position för pelaren 
        float högstaPoäng = transform.position.y - heightOffset;
        // Skapar en ny instans av pelare-objektet med en slumpmässig Y-position inom det definerade intervallet. Så att pelarna inte spawnar i samma ställe hela tiden. 
        Instantiate(pelare, new Vector3(transform.position.x, Random.Range(lägstaPoäng, högstaPoäng), 0), transform.rotation);
    }
}
