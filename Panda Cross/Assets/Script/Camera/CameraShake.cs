using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public PandaHurt panda;
    void Update() 
    {
        if (panda.isHurt == true) {
            this.GetComponent<Animator>().SetBool("Shake", true);
        } else {
            this.GetComponent<Animator>().SetBool("Shake", false);
        }
    }
}
