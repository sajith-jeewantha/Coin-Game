using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using TMPro;

public class PlayerController : MonoBehaviour
{

    private Animator animator;
    public GameObject GameOverText;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        GameOverText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        /* animator.SetBool("Run", false);

         if (Input.GetKey(KeyCode.W))
         {


         }*/
        transform.position += new Vector3(0, 0, 1) * Time.deltaTime * 5;
        animator.SetBool("Run", true);

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-1, 0, 0) * Time.deltaTime * 3;

        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, 0, -1) * Time.deltaTime * 5;

        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(1, 0, 0) * Time.deltaTime * 3;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position += new Vector3(0, 1, 0) * Time.deltaTime * 10;
            animator.SetTrigger("Jump");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Debug.Log("Collision Enter : " + collision.gameObject.name);

        if (collision.gameObject.CompareTag("Obstacle"))
        {
            // Debug.Log("Game Over");

            Time.timeScale = 0;
            GameOverText.gameObject.SetActive(true);
        }
    }

    /*private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Enter : " + other.gameObject.name);

        if (other.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
        }
    }*/
}
