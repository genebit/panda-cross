using UnityEngine;
using UnityEngine.UI;

public class SkillBehavior : MonoBehaviour
{
    [Header("Panda Animator")]
    public Animator yPositionAnimator;
    public Animator skillPandaAnimator;
    
    private int pressCount;
    
    [Header("Skill Icon Animator")]
    public Animator skill1Animator;
    public Animator skill2Animator;
    public Animator skill3Animator;

    [Header("Skill Icon GameObject")]
    public GameObject skillIcon1;
    public GameObject skillIcon2;
    public GameObject skillIcon3;
    
    [Header("Skill Button")]
    public Animator skillAnimator;
    public GameObject skill;
    public Button skillButton;

    public void UseSkill()
    {
        pressCount++;
        yPositionAnimator.SetTrigger("IsSliding");

        skillPandaAnimator.SetTrigger("IsSliding");
        skillPandaAnimator.SetBool("IsAvailable", true);

        skillAnimator.SetTrigger("IsPressed");

        skillButton.interactable = false;
        Invoke("ReturnTrue", 0.80f);
    }

    void SkillIcon1() => skillIcon1.SetActive(false);
    void SkillIcon2() => skillIcon2.SetActive(false);
    void SkillIcon3() => skillIcon3.SetActive(false);

    private void Update()
    {
        switch (pressCount)
        {
            case 1:
                skill1Animator.SetBool("IsUsed", true);
                Invoke("SkillIcon1", 1);
                break;
            case 2:
                skill2Animator.SetBool("IsUsed", true);
                Invoke("SkillIcon2", 1);
                break;
            case 3:
                skill3Animator.SetBool("IsUsed", true);
                Invoke("SkillIcon3", 1);
                
                skillButton.interactable = false;
                
                skillAnimator.SetTrigger("IsUsed");
                Invoke("SkillButton", 1.5f);
                break;
        }
    }
   
    void ReturnTrue() => skillButton.interactable = true;
    void SetInactive() => skill.SetActive(false);
    
    void SkillButton()
    {
        yPositionAnimator.enabled = false;
        skillPandaAnimator.SetBool("IsAvailable", false);
        Invoke("SetInactive", 1f);
    }
}
