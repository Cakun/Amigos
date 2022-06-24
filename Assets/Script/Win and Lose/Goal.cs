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
                _gateEmossion.SetBool("isRight6", true);

                _gateOpen.SetActive(false);

            }

            if(collision.gameObject.layer == LayerMask.NameToLayer("Win"))
            {
                StartCoroutine(WaitThenLoad());
            }
            if (collision.gameObject.layer == LayerMask.NameToLayer("Win"))
            {
                _gateEmossion.SetBool("isRight5", true);
            }

            if (collision.gameObject.layer == LayerMask.NameToLayer("Lose"))
            {
                _gateEmossion.SetBool("isRight", false);
            }
            if (collision.gameObject.layer == LayerMask.NameToLayer("Lose"))
            {
                StartCoroutine(WaitThenUnPause());
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



    private IEnumerator WaitThenLoad()
    {
        yield return new WaitForSecondsRealtime(5.0f);
        arrowGate.SetActive(true);
        audioDie.UnPause();
    }

    private IEnumerator WaitThenUnPause()
    {
        yield return new WaitForSecondsRealtime(5.0f);
        audioDie.UnPause();
    }
}