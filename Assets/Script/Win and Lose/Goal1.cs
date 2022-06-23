using System.Collections;
using UnityEngine;

public class Goal1 : MonoBehaviour
{
    public Animator _gateEmossion;
    public GameObject _gateOpen;
    public GameObject arrowGate;
    public AudioSource audioDie;

    public int jumlahWin;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            _gateEmossion.SetBool("Check", true);
            audioDie.Pause();

            if (collision.gameObject.layer == LayerMask.NameToLayer("Win"))
            {
                jumlahWin++;
                _gateEmossion.SetBool("isRight", true);

                if (collision.gameObject.layer == LayerMask.NameToLayer("Win"))
                {
                    _gateEmossion.SetBool("isRight2", true);
                    if (collision.gameObject.layer == LayerMask.NameToLayer("Win"))
                    {
                        _gateEmossion.SetBool("isRight3", true);
                        _gateEmossion.SetBool("isRight4", true);
                        _gateEmossion.SetBool("isRight5", false);
                        if (collision.gameObject.layer == LayerMask.NameToLayer("Win"))
                        {
                            _gateEmossion.SetBool("isRight5", true);
                        }
                            if (jumlahWin == 4)
                        {
                            _gateEmossion.SetBool("isRight3", false);
                            StartCoroutine(WaitThenLoad());
                        }
                    }
                }
                if (collision.gameObject.layer == LayerMask.NameToLayer("Lose"))
                {
                    _gateEmossion.SetBool("Ulang2", false);
                }
            }

            if (collision.gameObject.layer == LayerMask.NameToLayer("Lose"))
            {
                _gateEmossion.SetBool("isRight", false);
            }
            if (collision.gameObject.layer == LayerMask.NameToLayer("Lose"))
            {
                _gateEmossion.SetBool("isRight4", false);
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

        if (Idle.gameObject.layer == LayerMask.NameToLayer("Win"))
        {
            jumlahWin--;
            _gateEmossion.SetTrigger("Ulang");

        }
    }



    private IEnumerator WaitThenLoad()
    {
        yield return new WaitForSecondsRealtime(5.0f);
        arrowGate.SetActive(true);
        audioDie.UnPause();
        _gateOpen.SetActive(false);
    }

    private IEnumerator WaitThenUnPause()
    {
        yield return new WaitForSecondsRealtime(5.0f);
        audioDie.UnPause();
    }
}