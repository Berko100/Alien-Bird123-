using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MellanPelareManus : MonoBehaviour
{
    public LogikManus logik; // Referens till LogikManuset 

    // Start is called before the first frame update
    void Start()
    {
        logik = GameObject.FindGameObjectWithTag("Logik").GetComponet<LogikManus>();// Hämtar LogikManuset från ett GameObject med taggen "Logik"
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OntriggerEnter2d(Collider2D collision)
    {
        if (collision.GameObject.layer == 3) // Om kolliderande GameObject har layer 3 (definerad layer för fågeln)
        {
            logik.spelarPoäng(1); // Anropar addScore-metoden i LogikManus klassen för att öka spelarens poäng med 1 efter att fågeln har gått igenom pelaren. 
        }

    }

}
