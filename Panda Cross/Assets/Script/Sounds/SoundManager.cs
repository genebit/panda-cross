using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip playerHurtSound, ladybugHitSound, pointSound;
    static AudioSource audioSource;
    void Start()
    {
        playerHurtSound = Resources.Load<AudioClip>("Panda_Hurt");
        ladybugHitSound = Resources.Load<AudioClip>("Ladybug_Hit");
        pointSound = Resources.Load<AudioClip>("AddPoints");

        audioSource = GetComponent<AudioSource>();
    }
    public static void PlaySound(string clipName) {
        switch (clipName) {
            case "Panda_Hurt":
                audioSource.PlayOneShot(playerHurtSound);
                break;
            case "Ladybug_Hit":
                audioSource.PlayOneShot(ladybugHitSound);
                break;
            case "AddPoints":
                audioSource.PlayOneShot(pointSound);
                break;
        }
    }
}
