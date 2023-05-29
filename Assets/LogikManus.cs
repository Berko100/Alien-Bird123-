using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnitiyEngine.SceneManagement
public class LogikManus : MonoBehaviour
{  // Variabel f�r spelarens po�ng 
    public int spelarPo�ng;
   // Referens til Text-komponenten som visar po�ng 
    public Text scoreText;
    // Referens till Gameobject som visar spelet �ver sk�rmen 
    public GameObject spelet�verSk�rm;

    [ContextMenu("�ka Po�ng")]
    public void addScore(int l�ggTillPo�ng)
    {  // �kar spelarens po�ng med det angivna v�rdet 
        spelarPo�ng = spelarPo�ng + l�ggTillPo�ng;
       // Uppdaterar po�ngtexten med spelarens nuvarande po�ng 
        scoreText.text = spelarPo�ng.ToString(); 
    }

    public void b�rjaOmSpelet()
    {  // Laddar om den aktiva scenen f�r att starta om spelet 
        SceneManager.LoadScene(SceneManager.GetActiveScene().name();
    }
    public void gameOver()
    {  // Aktiverar spelet �ver sk�rmen f�r att visa att spelet �r �ver 
        spelet�verSk�rm.SetActive(true);
    }

}
