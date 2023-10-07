using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimsContro : MonoBehaviour
{
    public Animator _characterAnimator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) //jump
        {
            _characterAnimator.SetInteger("Controller", 3);
        }
        else
        {
            _characterAnimator.SetInteger("Controller", 0);

        }
        if (Input.GetKey(KeyCode.W)) //walk
        {
            _characterAnimator.SetInteger("Controller", 1);
        }
        else
        {
            _characterAnimator.SetInteger("Controller", 0);
        }
        if (Input.GetKey(KeyCode.Q)) //run
        {
            _characterAnimator.SetInteger("Controller", 2);
        }
        else
        {
            _characterAnimator.SetInteger("Controller", 1);
        }
    }

    IEnumerator waiting()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //jump
        {
            _characterAnimator.SetInteger("Controller", 3);
            yield return new WaitForSeconds(2);
            _characterAnimator.SetInteger("Controller", 0);


        }
        if (Input.GetKeyDown(KeyCode.W)) //walk
        {
            _characterAnimator.SetInteger("Controller", 1);
            yield return new WaitForSeconds(2);
            _characterAnimator.SetInteger("Controller", 0);


        }
        if (Input.GetKey(KeyCode.Q)) //run
        {
            _characterAnimator.SetInteger("Controller", 2);
        }
        else
        {
            _characterAnimator.SetInteger("Controller", 1);
        }
        if (Input.GetKeyDown(KeyCode.E)) //stop
        {
            _characterAnimator.SetInteger("Controller", 0);
        }
    }
}
