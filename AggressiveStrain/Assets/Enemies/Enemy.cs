using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int Virus;
    public int Health;
    private float alpha;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("VirusDamage", 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
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
            Infect();
        }
     
    }

    void VirusDamage()
    {
        Health = Health - Virus;
    }
}
