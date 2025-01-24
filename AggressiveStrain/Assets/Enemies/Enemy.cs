using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public int Virus;
    public int Health;
    private float alpha;
    public Transform target;
    private NavMeshAgent agent;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("VirusDamage", 1f, 1f);
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = target.position;
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
        if (Health < 0)
        {
            Destroy(gameObject);
            print("Virus Kill!");
        }
    }
}
