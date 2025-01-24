using UnityEngine;


public class character : MonoBehaviour
{
    private CharacterController characterController;
    public Transform cam;
    private Vector3 movement;
    public float Speed = 5f;
    public float health;
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = cam.transform.forward * verticalInput + cam.transform.right * horizontalInput;
        movement.y = 0;
        characterController.Move(movement * Time.deltaTime * Speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            health = health - 5;
        }
    }
}
