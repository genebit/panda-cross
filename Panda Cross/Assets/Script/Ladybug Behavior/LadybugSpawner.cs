using System.Collections;
using UnityEngine;

public class LadybugSpawner : MonoBehaviour
{
    public DestroyObject currentSpeed;
    public GameObject bugPrefab;
    void Start() 
    {
        //Center Spawner
        StartCoroutine(StartSpawnAt_CENTER_LEFT());
        StartCoroutine(StartSpawnAt_CENTER_RIGHT());
        //Left Spawner
        StartCoroutine(StartSpawnAt_LEFT_LEFT());
        StartCoroutine(StartSpawnAt_LEFT_RIGHT());
        //Right Spawner
        StartCoroutine(StartSpawnAt_RIGHT_LEFT());
        StartCoroutine(StartSpawnAt_RIGHT_RIGHT());
    }
    //Spawner_LOCATION_LEFTorRIGHT(starting y-Position to spawn(min), (max));
    void Spawner_CENTER_LEFT(float min, float max) { //Center
        GameObject clone = Instantiate(bugPrefab) as GameObject;
        clone.transform.position = new Vector2(-0.43f, Random.Range(min, max));
        clone.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 90));
        clone.transform.parent = GameObject.Find("Ladybug (Spawner)").transform;
    }
    IEnumerator StartSpawnAt_CENTER_LEFT() {
        while (true) {
            if (currentSpeed.speed == 4) {
                yield return new WaitForSeconds(Random.Range(1f, 9f));
                Spawner_CENTER_LEFT(-7.5f, -10f);
                Debug.Log("Ladybug movement increasses to 4");
            }
            else if (currentSpeed.speed == 5) {
                yield return new WaitForSeconds(Random.Range(0.5f, 5f));
                Spawner_CENTER_LEFT(-7.5f, -10f);
                Debug.Log("Ladybug movement increasses to 5");
            }
            else if (currentSpeed.speed == 6) {
                yield return new WaitForSeconds(Random.Range(0.5f, 4f));
                Spawner_CENTER_LEFT(-7.5f, -10f);
                Debug.Log("Ladybug movement increasses to 6");
            }
            else {
                yield return new WaitForSeconds(Random.Range(1f, 10f));
                Spawner_CENTER_LEFT(-7.5f, -10f);
            }
        }
    }
    void Spawner_CENTER_RIGHT(float min, float max) {
        GameObject clone = Instantiate(bugPrefab) as GameObject;
        clone.transform.position = new Vector2(0.50f, Random.Range(min, max));
        clone.transform.localRotation = Quaternion.Euler(new Vector3(0, 180, 90));
        clone.transform.parent = GameObject.Find("Ladybug (Spawner)").transform;
    }
    IEnumerator StartSpawnAt_CENTER_RIGHT() {
        while (true) {
            if (currentSpeed.speed == 4) {
                yield return new WaitForSeconds(Random.Range(1f, 9f));
                Spawner_CENTER_RIGHT(-7.5f, -10f);
            }
            else if (currentSpeed.speed == 5) {
                yield return new WaitForSeconds(Random.Range(0.5f, 5f));
                Spawner_CENTER_RIGHT(-7.5f, -10f);
            }
            else if (currentSpeed.speed == 6) {
                yield return new WaitForSeconds(Random.Range(0.5f, 4f));
                Spawner_CENTER_RIGHT(-7.5f, -10f);
            }
            else {
                yield return new WaitForSeconds(Random.Range(1f, 10f));
                Spawner_CENTER_RIGHT(-7.5f, -10f);
            }
        }
    }
    void Spawner_LEFT_LEFT(float min, float max) { //Left
        GameObject clone = Instantiate(bugPrefab) as GameObject;
        clone.transform.position = new Vector2(-4.40f, Random.Range(min, max));
        clone.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 90));
        clone.transform.parent = GameObject.Find("Ladybug (Spawner)").transform;
    }
    IEnumerator StartSpawnAt_LEFT_LEFT() {
        while (true) {
            if (currentSpeed.speed == 4) {
                yield return new WaitForSeconds(Random.Range(1f, 9f));
                Spawner_LEFT_LEFT(-7.5f, -10f);
            }
            else if (currentSpeed.speed == 5) {
                yield return new WaitForSeconds(Random.Range(0.5f, 5f));
                Spawner_LEFT_LEFT(-7.5f, -10f);
            }
            else if (currentSpeed.speed == 6) {
                yield return new WaitForSeconds(Random.Range(0.5f, 4f));
                Spawner_LEFT_LEFT(-7.5f, -10f);
            }
            else {
                yield return new WaitForSeconds(Random.Range(1f, 10f));
                Spawner_LEFT_LEFT(-7.5f, -10f);
            }
        }
    }
    void Spawner_LEFT_RIGHT(float min, float max) {
        GameObject clone = Instantiate(bugPrefab) as GameObject;
        clone.transform.position = new Vector2(-3.50f, Random.Range(min, max));
        clone.transform.localRotation = Quaternion.Euler(new Vector3(0, 180, 90));
        clone.transform.parent = GameObject.Find("Ladybug (Spawner)").transform;
    }
    IEnumerator StartSpawnAt_LEFT_RIGHT() {
        while (true) {
            if (currentSpeed.speed == 4) {
                yield return new WaitForSeconds(Random.Range(1f, 9f));
                Spawner_LEFT_RIGHT(-7.5f, -10f);
            }
            else if (currentSpeed.speed == 5) {
                yield return new WaitForSeconds(Random.Range(0.5f, 5f));
                Spawner_LEFT_RIGHT(-7.5f, -10f);
            }
            else if (currentSpeed.speed == 6) {
                yield return new WaitForSeconds(Random.Range(0.5f, 4f));
                Spawner_LEFT_RIGHT(-7.5f, -10f);
            }
            else {
                yield return new WaitForSeconds(Random.Range(1f, 10f));
                Spawner_LEFT_RIGHT(-7.5f, -10f);
            }
        }
    }
    void Spawner_RIGHT_LEFT(float min, float max) { //Right
        GameObject clone = Instantiate(bugPrefab) as GameObject;
        clone.transform.position = new Vector2(3.48f, Random.Range(min, max));
        clone.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 90));
        clone.transform.parent = GameObject.Find("Ladybug (Spawner)").transform;
    }
    IEnumerator StartSpawnAt_RIGHT_LEFT() {
        while (true) {
            if (currentSpeed.speed == 4) {
                yield return new WaitForSeconds(Random.Range(1f, 9f));
                Spawner_RIGHT_LEFT(-7.5f, -10f);
            }
            else if (currentSpeed.speed == 5) {
                yield return new WaitForSeconds(Random.Range(0.5f, 5f));
                Spawner_RIGHT_LEFT(-7.5f, -10f);
            }
            else if (currentSpeed.speed == 6) {
                yield return new WaitForSeconds(Random.Range(0.5f, 4f));
                Spawner_RIGHT_LEFT(-7.5f, -10f);
            }
            else {
                yield return new WaitForSeconds(Random.Range(1f, 10f));
                Spawner_RIGHT_LEFT(-7.5f, -10f);
            }
        }
    }
    void Spawner_RIGHT_RIGHT(float min, float max) {
        GameObject clone = Instantiate(bugPrefab) as GameObject;
        clone.transform.position = new Vector2(4.43f, Random.Range(min, max));
        clone.transform.localRotation = Quaternion.Euler(new Vector3(0, 180, 90));
        clone.transform.parent = GameObject.Find("Ladybug (Spawner)").transform;
    }
    IEnumerator StartSpawnAt_RIGHT_RIGHT() {
        while (true) {
            if (currentSpeed.speed == 4) {
                yield return new WaitForSeconds(Random.Range(1f, 9f));
                Spawner_RIGHT_RIGHT(-7.5f, -10f);
            }
            else if (currentSpeed.speed == 5) {
                yield return new WaitForSeconds(Random.Range(0.5f, 5f));
                Spawner_RIGHT_RIGHT(-7.5f, -10f);
            }
            else if (currentSpeed.speed == 6) {
                yield return new WaitForSeconds(Random.Range(0.5f, 4f));
                Spawner_RIGHT_RIGHT(-7.5f, -10f);
            }
            else {
                yield return new WaitForSeconds(Random.Range(1f, 10f));
                Spawner_RIGHT_RIGHT(-7.5f, -10f);
            }

        }
    }
}
