using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectPowerUp : MonoBehaviour
{
	private void OnTriggerEnter(Collider coll)
	{
		Debug.Log("Hit");
		if (coll.TryGetComponent<AudioSource>(out AudioSource audio))
			audio.Play();
	}
}
