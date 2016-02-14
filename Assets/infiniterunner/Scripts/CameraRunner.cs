using UnityEngine;
using System.Collections;

public class CameraRunner : MonoBehaviour {

    public Transform player; // Setto la trasform dell'avatar
	
	// Ad ogni update setto la transform della Camera a +6 dal player
	void Update () {

        transform.position = new Vector3(player.position.x + 6, 0, -10);

	}
}
