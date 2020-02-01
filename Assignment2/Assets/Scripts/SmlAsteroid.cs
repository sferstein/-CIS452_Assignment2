using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Sam Ferstein
 * SmlAsteroid.cs
 * Assignment 2
 * This is the class that activates the behavior for the small asteroid
 */

public class SmlAsteroid : Asteroid
{
    public void Awake()
    {
        ChangeExplodeBehavior = gameObject.AddComponent<BlowUpSml>();
    }
}

