using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaSound : MonoBehaviour
{
	[SerializeField]
	private AudioSource footStep;
	[SerializeField]
	private AudioSource throwSound;
	[SerializeField]
	private AudioSource suara3;
	[SerializeField]
	private AudioSource suara4;


	private void Start()
	{
		footStep = GetComponent<AudioSource>();
	}

	private void FootStep()
	{
		footStep.Play();
	}

	private void ThrowSound()
	{
		throwSound.Play();
	}

	private void SuaraTiga()
    {
		suara3.Play();
    }

	private void SuaraEmpat()
	{
		suara4.Play();
	}
}
