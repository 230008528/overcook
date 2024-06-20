using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogoAnimation : MonoBehaviour
{
    [SerializeField] Animator logoBaiceAnimator;
    [SerializeField] Animator logoTailAnimator;
    [SerializeField] Animator logoNum2;
    [SerializeField] Animator logoG;
    [SerializeField] Animator logoGNum;
    private float delay = 0.2f;
    private float timer = 0f;
    private bool played=false;
    private bool played2 = false;
    // Start is called before the first frame update
    void Start()
    {
        played = false;
        timer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        logoBaiceAnimator.Play("LogoBaice_Animation");
        played = true;
        if (played == true)
        {

            LogoAnimaWaitAmoment();


            logoNum2.Play("LogoNum2_Animation");
            played2 = true;
            if (played2 == true) { logoG.SetBool("goBaicePlayed", true); }
            logoG.Play("LogoG_Animation");
            logoTailAnimator.SetBool("LogoBaicePlayed", true);
            logoGNum.Play("LogoG2B5_Animation");
        }
    }
    IEnumerator LogoAnimaWaitAmoment()
    {
        yield return new WaitForSeconds(delay);
    }
    

}
