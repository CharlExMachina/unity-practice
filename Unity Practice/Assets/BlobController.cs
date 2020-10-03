using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlobController : MonoBehaviour
{
    private Animator _animator;

    private int isWalking = Animator.StringToHash("IsWalking");
    private int isDead = Animator.StringToHash("IsDead");

    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _animator.SetBool(isWalking, true);
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            _animator.SetBool(isWalking, false);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            _animator.SetBool(isDead, true);
        }
    }
}
