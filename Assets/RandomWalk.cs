using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomWalk : MonoBehaviour
{
	[SerializeField] AudioSource audioSource;

	float timeTillNext = .25f, currentTime;
	
	// Update is called once per frame
	void Update()
	{
		currentTime += Time.deltaTime;
		// If the character has moved and the audio is not currently playing
		if (!audioSource.isPlaying && currentTime > timeTillNext)
		{
			// Randomly change the playback speed a small amount
			audioSource.pitch = Random.Range(0.9f, 1.2f);
			// Randomly change the volume a small amount
			audioSource.volume = Random.Range(0.4f, 1f);
			// Play the step sound
			audioSource.Play();
			currentTime = 0f;
		}

	}
}
