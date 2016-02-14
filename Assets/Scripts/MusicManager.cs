using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {

	/*
	 * PROPRIETA'
	 */
	// Array contenente le clip ordinate secondo i livelli
	public AudioClip[] levelMusicChange;

	// L'audiosource del music manager
	private AudioSource audioSource;

	/*
	 * METODI
	 */
	void Awake() {

		// Non distruggere questo oggetto!
		DontDestroyOnLoad (gameObject);
		Debug.Log ("Don't destroy on load: " + name);

	}

	// Use this for initialization
	void Start () {

		// Setto l'audiosource
		audioSource = GetComponent<AudioSource> ();
	
	}

	void OnLevelWasLoaded( int level ) {

		// Setto la clip del livello attuale
		AudioClip thisLevelMusic = levelMusicChange [level];

		Debug.Log ("Playing clip: " + thisLevelMusic);

		// Se la clip esiste...
		if (thisLevelMusic) {

			// ... la setto come clip dell'audiosource, la metto in looping e la suono
			audioSource.clip = thisLevelMusic;
			audioSource.loop = true;
			audioSource.Play ();

		}

	}
}
