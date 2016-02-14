using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	/*
	 * METODI
	 */
	// Metodo che carica la scena passatagli per nome
	public void LoadScene (string name) {
		
		Debug.Log ("New Level loading: " + name);
		
		Application.LoadLevel (name);
		
	}
	
	// Metodo che avvia una richiesta di chiusura dell'applicazione
	// ATTENZIONE: Funziona solo su mobile!
	public void QuitRequest () {
		
		Debug.Log ("Quit requested");
		
		Application.Quit ();
		
	}
	
	// Metodo che carica la prossima scena (ordinate nelle Build Settings)
	public void LoadNextScene () {
		
		Application.LoadLevel (Application.loadedLevel + 1);
		
	}

}
