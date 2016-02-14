using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {

	/*
	 * PROPRIETA'
	 */
	// Istanza del musicplayer
	static MusicPlayer instance = null;

	// Le clip da suonare durante il gioco
	public AudioClip menuClip;
	public AudioClip gameClip;
	public AudioClip endClip;

	// L'Audiosource che conterrà le clip
	private AudioSource music;
	
	void Start () {

		if (instance != null && instance != this) {
			Destroy (gameObject);
			print ("Duplicate music player self-destructing!");
		} else {
			instance = this;
			GameObject.DontDestroyOnLoad(gameObject);

			// Cerco l'audiosource, poi setto "menuClip" come prima clip da suonare, in loop
			music = GetComponent<AudioSource>();
			music.clip = menuClip;
			music.loop = true;
			music.Play ();

		}
		
	}

	// Metodo che viene richiamato quando un livello è stato correttamente caricato
	void OnLevelWasLoaded( int level ) {

		Debug.Log ("MusicPlayer: Loaded level " + level);

		// Fermo qualsiasi clip stia suonando
		music.Stop ();

		// Scelgo quale clip caricare
		if( level == 0 ) music.clip = menuClip;
		if( level == 1 ) music.clip = gameClip;
		if( level == 2 ) music.clip = endClip;

		// Suono la clip, in loop
		music.loop = true;
		music.Play ();

	}
}
