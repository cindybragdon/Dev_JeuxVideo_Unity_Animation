using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deplacement : MonoBehaviour
{

    float axeH, axeV;

    [SerializeField]
    float walkSpeed = 2f;


    Animator girlAnimation;

    // Start is called before the first frame update
    private void Awake()
    {
        girlAnimation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        axeH = Input.GetAxis("Horizontal");
        axeV = Input.GetAxis("Vertical");

        if (axeV > 0)

            if (Input.GetKey(KeyCode.LeftControl))
            {
                transform.Translate(Vector3.forward * walkSpeed * axeV * Time.deltaTime);
                girlAnimation.SetFloat("run", axeV);
            }
            else
            {
                transform.Translate(Vector3.forward * walkSpeed * axeV * Time.deltaTime);
                girlAnimation.SetBool("walk", true);
                girlAnimation.SetFloat("run", 0);
            }
        else
        {
            girlAnimation.SetBool("walk", false);
        }
    }
}
