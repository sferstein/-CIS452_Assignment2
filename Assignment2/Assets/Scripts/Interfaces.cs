using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Sam Ferstein
 * Interfaces.cs
 * Assignment 2
 * The 'interface' for the Strategy Design Pattern to get the method for the Asteroid class.
 */

public abstract class ChangeExplodeBehavior : MonoBehaviour
{
    public abstract void BlowUp();
}

