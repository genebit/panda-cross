using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    private new Rigidbody2D rigidbody;
    public float speed;
    private void Start() 
    {
        Physics2D.IgnoreLayerCollision(8, 9, false);
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.velocity = new Vector2(0, +speed);
    }
    float offscreen = 7.62f;
    void Update() {
        if (transform.position.y > offscreen) {
            Destroy(this.gameObject);
        }
        else if (transform.position.y < -15f) {
            Destroy(this.gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Panda") 
        {
            SoundManager.PlaySound("Ladybug_Hit");
            rigidbody.gravityScale = 2;
            Physics2D.IgnoreLayerCollision(8, 9);
        }
    }
}
