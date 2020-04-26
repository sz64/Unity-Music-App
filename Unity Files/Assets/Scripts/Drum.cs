using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drum : MonoBehaviour
{
    public AudioSource Bass;
    public AudioSource Cymbal;
    public AudioSource FloorTom;
    public AudioSource HiHat;
    public AudioSource LargeTom;
    public AudioSource SmallTom;
    public AudioSource Snare;
    
    public void Play_Bass ()
    {
        Bass.Play();
    }
    public void Play_Cymbal ()
    {
        Cymbal.Play();
    }
    public void Play_FloorTom ()
    {
        FloorTom.Play();
    }
    public void Play_HiHat ()
    {
        HiHat.Play();
    }
    public void Play_LargeTom ()
    {
        LargeTom.Play();
    }
    public void Play_SmallTom ()
    {
        SmallTom.Play();
    }
    public void Play_Snare ()
    {
        Snare.Play();
    }
}
