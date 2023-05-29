using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnitiyEngine.SceneManagement
public class LogikManus : MonoBehaviour
{  // Variabel för spelarens poäng 
    public int spelarPoäng;
   // Referens til Text-komponenten som visar poäng 
    public Text scoreText;
    // Referens till Gameobject som visar spelet över skärmen 
    public GameObject speletÖverSkärm;

    [ContextMenu("Öka Poäng")]
    public void addScore(int läggTillPoäng)
    {  // Ökar spelarens poäng med det angivna värdet 
        spelarPoäng = spelarPoäng + läggTillPoäng;
       // Uppdaterar poängtexten med spelarens nuvarande poäng 
        scoreText.text = spelarPoäng.ToString(); 
    }

    public void börjaOmSpelet()
    {  // Laddar om den aktiva scenen för att starta om spelet 
        SceneManager.LoadScene(SceneManager.GetActiveScene().name();
    }
    public void gameOver()
    {  // Aktiverar spelet över skärmen för att visa att spelet är över 
        speletÖverSkärm.SetActive(true);
    }

}
