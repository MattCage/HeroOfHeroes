using UnityEngine;
using System.Collections;

public class Powerup : MonoBehaviour {

    HUD hud; // Setto la HUD del gioco come classe HUD script

    // All'entrata nel trigger...
    void OnTriggerEnter2D( Collider2D other )
    {

        // ...se tocco un collider taggato Player...
        if( other.tag == "Player" )
        {

            // Cerco lo script HUD e lo setto nella variabile dedicata
            hud = GameObject.Find("Main Camera").GetComponent<HUD>();

            // Aumento il punteggio di 10 (con la funzione nello script HUD)
            hud.IncreaseScore(10);

            // Distruggo questo stesso oggetto
            Destroy(this.gameObject);

        }

    }

}
