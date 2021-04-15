using UnityEngine;

public class PandaMovement : MonoBehaviour
{
    public Transform panda;
    public int moveCount;
    void Start() {
        
    }
    public void moveLeft() {
        moveCount--;
        Move();
    }
    public void moveRight() {
        moveCount++;
        Move();
    }
    void Move() {
        switch (moveCount) 
        {
            case -3:
                panda.position = new Vector2(-5.30f, 2);
                panda.localRotation = Quaternion.Euler(0, 180, 0);
                break;
            case -2:
                panda.position = new Vector2(-2.65f, 2);
                panda.localRotation = Quaternion.Euler(0, 0, 0);
                break;
            case -1:
                panda.position = new Vector2(-1.31f, 2);
                panda.localRotation = Quaternion.Euler(0, 180, 0);
                break;
            case 0:
                panda.position = new Vector2(1.40f, 2);
                panda.localRotation = Quaternion.Euler(0, 0, 0);
                break;
            case 1:
                panda.position = new Vector2(2.65f, 2);
                panda.localRotation = Quaternion.Euler(0, 180, 0);
                break;
            case 2:
                panda.position = new Vector2(5.30f, 2);
                panda.localRotation = Quaternion.Euler(0, 0, 0);
                break;
        }
        // Limiter
        if (moveCount < -3) moveCount = -3;
        else if (moveCount > 2) moveCount = 2;
    }
}
