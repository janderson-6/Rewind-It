using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private float horizontal;
    private float vertical;

    public GameObject gameManager;
    public GameObject panel;
    public Text TimerDisplay;

    [SerializeField] private Rigidbody rb;
    [SerializeField] private float speed = 3;
    //[SerializeField] private float jumpingPower = 10f;

    void Start()
    {
        panel.SetActive(false);
    }

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }
    
    private void FixedUpdate()
    {
        rb.velocity = new Vector3(horizontal * speed, rb.velocity.y, vertical * speed);
    }
    
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Vector3 jump = new Vector3(0, 100, 0);
            rb.AddForce(jump /** jumpingPower*/);
        }
    }

    private void OnTriggerEnter(Collider target)
    {
        if (target.gameObject.tag.Equals("EndTrigger") == true)
        {
            TimerDisplay.gameObject.SetActive(false);
            gameManager.SetActive(false);
            panel.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}