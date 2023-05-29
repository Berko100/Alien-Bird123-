using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fågelmanus : MonoBehaviour
{
    // Så att koden blir medveten om att Rigidbody finns och att kunna lägga till/ändra hastigheten på "fågeln" genom unity 
    public Rigidbody2D minRigidbody2D;
    // En variabel så för hoppstyrkan 
    public float fågelnsHoppstyrka;
    public LogikManus Logik;
    public bool fågelÄrLevande = true;

    // Start is called before the first frame update
    void Start()
    {
        logik = GameObject.FindGameObjectWithTag("Logik").GetComponet<LogikManus>();
    }

    // Update is called once per frame
    void Update()
    {   // Om spacebar tangentet trycks går fågels uppåt genom vektorn
        if (Input.GetKeyDown(KeyCode.Space) && fågelÄrLevande)
        {   // Så att jag kan ändra hoppstyrkan i unity
            minRigidbody2D.velocity = Vector2.up * fågelnsHoppstyrka;
        }
    }
    private void OnCollisionEnter2d(Collision2d collision)
    {  // Anropar gameOver metoden i LogikManus-klassen för att markera att se spelet är över 
        logik.gameOver();
       // Sätter fågelns livsstatus til falsk, inte vid liv
        fågelÄrLevande = falsk;
    }
    
}
