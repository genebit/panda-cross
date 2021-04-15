using UnityEngine;
using UnityEngine.EventSystems;
public class SkillButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject movement;
    [HideInInspector]
    public bool isUsingSkill;
    
    public void OnPointerDown(PointerEventData data) {
        isUsingSkill = true;
        movement.SetActive(false);
    }
    public void OnPointerUp(PointerEventData data) {
        Invoke("ReturnFalse", 0.50f);
    }
    void ReturnFalse() {
        isUsingSkill = false;
        movement.SetActive(true);
    }
}
