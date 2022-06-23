using System.Collections;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public Animator _gateEmossion;
    public GameObject _gateOpen;
    public GameObject arrowGate;
    public AudioSource audioDie;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            _gateEmossion.SetBool("Check", true);
            audioDie.Pause();


            if (collision.gameObject.layer == LayerMask.NameToLayer("Win"))
            {
                _gateEmossion.SetBool("isRight", true);

                _gateOpen.SetActive(false);

            }

            if(collision.gameObject.layer == LayerMask.NameToLayer("Win"))
            {
                StartCoroutine(waitThenLoad());
            }

            if (collision.gameObject.layer == LayerMask.NameToLayer("Lose"))
            {
                _gateEmossion.SetBool("isRight", false);
            }
            if (collision.gameObject.layer == LayerMask.NameToLayer("Lose"))
            {
                StartCoroutine(waitThenUnPause());
            }
        }
    }

    private void OnTriggerExit2D(Collider2D Idle)
    {
        if (Idle.gameObject.name == "Ball")
        {
            _gateEmossion.SetBool("Check", false);
        }
    }



    private IEnumerator waitThenLoad()
    {
        yield return new WaitForSecondsRealtime(5.0f);
        arrowGate.SetActive(true);
        audioDie.UnPause();
    }

    private IEnumerator waitThenUnPause()
    {
        yield return new WaitForSecondsRealtime(5.0f);
        audioDie.UnPause();
    }
}