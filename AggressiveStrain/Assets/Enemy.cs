using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int Virus;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Infect()
    {
        Virus++;
        print(Virus);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            print("work");
            Player player = other.gameObject.GetComponent<player>();
            if (player != null)
            {
                Infect(); 
            }
        }
    }
}
