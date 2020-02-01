using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Sam Ferstein
 * Asteroid.cs
 * Assignment 2
 * This is the abstract class that applies the Strategy Design Pattern method into the game.
 */

public abstract class Asteroid : MonoBehaviour
{
    public ChangeExplodeBehavior ChangeExplodeBehavior { get; set; }

    private float boundary = -10;
    public float speedInit;
    public float cooldown = 5;
    private float nextFire = 10;

    public virtual void DoExplode()
    {
        ChangeExplodeBehavior.BlowUp();
    }

    /* I attempted to make a cooldown for the ability to destroy the asteroids so that there is still some challenge in the game, but for some reason I could not get rid of being
     * able to spam the spacebar and always being able to use the ability. The code includes what I have tried for the cooldown but could not get to work.
     */
    public void Update()
    {
        if (Time.time > nextFire)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                DoExplode();
                nextFire = Time.time + cooldown;
            }
        }
        if (transform.position.z < boundary)
        {
            Destroy(gameObject);
        }
        transform.Translate(Vector3.back * Time.deltaTime * speedInit);
    }
}