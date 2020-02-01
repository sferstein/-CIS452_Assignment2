using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Sam Ferstein
 * BigAsteroid.cs
 * Assignment 2
 * This is the class that activates the behavior for the big asteroid
 */

public class BigAsteroid : Asteroid
{
    public void Awake()
    {
        ChangeExplodeBehavior = gameObject.AddComponent<BlowUpBig>();
    }
}

