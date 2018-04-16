using UnityEngine;

public class BombScript : MonoBehaviour 
{
    public float countdown = 2f;
	 
	// Update is called once per frame
	void Update () {
        countdown -= Time.deltaTime;

        if(countdown <= 0)
        {
            FindObjectOfType<Explosion>().Explode(transform.position); // Make this a singelton.
            Destroy(gameObject);
        }
	}
}
