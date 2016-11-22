using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour {

    public GameObject explosion;
    public GameObject playerExplosion;
    public int scoreValue;
    public GameController gameController;

    void Start()
    {
        gameController = GameObject.FindObjectOfType<GameController>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boundary")
        {
            return;
        }

        //Asteroid Explosion
        Instantiate(explosion, transform.position, transform.rotation);

        //Player Explosion
        if (other.tag == "Player")
        {
            Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
        }

        //Destroy Player
        Destroy(other.gameObject);

        //Destroy Asteroid
        Destroy(gameObject);
    }
}
