using UnityEngine;

public class PandaHurt : MonoBehaviour
{
    public SkillButton skill;
    public Animator health1Animator, health2Animator, health3Animator;
    public GameObject health1, health2, health3;
    [HideInInspector]
    public int currentHealth;
    public bool isHurt = false;
    private void Start() 
    {
        currentHealth = 3;
    }
    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.gameObject.tag == "Ladybug" && skill.isUsingSkill == false) {
            SoundManager.PlaySound("Panda_Hurt");
            Damage(1);
            
            isHurt = true;
            Invoke("ReturnFalse", 0.25f);
            
            this.GetComponent<Animator>().SetBool("IsHurt", true); //Refers to Animator hurt
        }

        if (collision.gameObject.tag == "Ladybug" && skill.isUsingSkill == true) {
            Damage(0);
            this.GetComponent<Animator>().SetBool("IsHurt", false);
        }
    }
    void Damage(int damage) 
    {
        currentHealth -= damage;
    }
    void ReturnFalse() => isHurt = false;
    void Health1() => health1.SetActive(false);
    void Health2() => health2.SetActive(false);
    void Health3() => health3.SetActive(false);
    private void Update() 
    {
        switch (currentHealth) {
            case 2:
                health1Animator.SetBool("IsHurt", true);
                Invoke("Health1", 1);
                break;
            case 1:
                health2Animator.SetBool("IsHurt", true);
                Invoke("Health2", 1);
                break;
            case 0:
                health3Animator.SetBool("IsHurt", true);
                Invoke("Health3", 1);
                break;
        }
        if (currentHealth < 0) {
            currentHealth = 0;
        }
    }
}
