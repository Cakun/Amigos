using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaSound : MonoBehaviour
{
	[SerializeField]
	private AudioSource footStep;

	private void Start()
	{
		footStep = GetComponent<AudioSource>();
	}

	private void FootStep()
	{
		footStep.Play();
	}
}
