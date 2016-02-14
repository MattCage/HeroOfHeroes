using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class GameOver : MonoBehaviour {

    int finalScore = 0; // Setto il punteggio finale, per sicurezza a 0
    public Text finalScoreText; // Setto il Text che mostrerà il punteggio finale

	// All'avvio, prendo il punteggio finale dai Player Prefs e lo mostro a schermo
	void Start () {
        finalScore = PlayerPrefs.GetInt("Score");
        finalScoreText.text = "Score: " + finalScore;
	}

    // Funzione e richiama la prima scena del gioco
    public void Replay()
    {
        SceneManager.LoadScene(0);
    }
	
}
