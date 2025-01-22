using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int Virus;
    public int Health;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Health = Health - Virus;
        print(Health);

        if (Health < 0)
        {
            Destroy(gameObject);
        }
    }

    void Infect()
    {
        Virus++;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            print("work");
            Infect();
        }
     
    }
}
