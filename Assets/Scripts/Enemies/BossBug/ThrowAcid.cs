using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowAcid : MonoBehaviour
{
    [SerializeField] GameObject acidProjectile;

    public float minForce;
    public float maxForce;
    public float upwardsForce;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BeginAttack()
    {
        GameObject projectile = Instantiate(acidProjectile, transform.position, Quaternion.identity);

        float force = Random.Range(minForce, maxForce);
        projectile.GetComponent<Rigidbody2D>().AddForce(new Vector2(force, upwardsForce));

    }
    
}