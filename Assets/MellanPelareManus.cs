using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MellanPelareManus : MonoBehaviour
{
    public LogikManus logik; // Referens till LogikManuset 

    // Start is called before the first frame update
    void Start()
    {
        logik = GameObject.FindGameObjectWithTag("Logik").GetComponet<LogikManus>();// H�mtar LogikManuset fr�n ett GameObject med taggen "Logik"
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OntriggerEnter2d(Collider2D collision)
    {
        if (collision.GameObject.layer == 3) // Om kolliderande GameObject har layer 3 (definerad layer f�r f�geln)
        {
            logik.spelarPo�ng(1); // Anropar addScore-metoden i LogikManus klassen f�r att �ka spelarens po�ng med 1 efter att f�geln har g�tt igenom pelaren. 
        }

    }

}
