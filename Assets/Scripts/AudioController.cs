using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
   AudioSource audioSource;

void Start(){
   audioSource.Play();
}

void Stop(){
  audioSource.Stop();
}
}
