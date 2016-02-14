using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HUD : MonoBehaviour {

    float playerScore = 0.0f; // Setto il punteggio del giocatore
    public Text scoreText; // Setto l'oggetto Text che mostra il punteggio
	
	// Aggiorno il punteggio ad ogni frame e lo faccio aumentare ogni millisecondo
	void Update () {
        playerScore += Time.deltaTime;

        scoreText.text = "Score: " + (int)(playerScore * 100);
	}

    public void IncreaseScore( int amount )
    {
        playerScore += amount;
    }

    void OnDisable()
    {
        PlayerPrefs.SetInt("Score", (int)(playerScore * 100));
    }

}
