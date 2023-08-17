using UnityEngine;

public class DestroyBirds : MonoBehaviour
{
    [SerializeField] float maxHeight = 8.0f;

    // Update is called once per frame
    void Update()
    {
        GameObject[] allBirds = GameObject.FindGameObjectsWithTag("Bird");
        foreach (GameObject bird in allBirds)
        {
            //if bird's fly heigher than maxHeight destroy
            if (bird.transform.position.y > maxHeight || Input.GetKeyDown(KeyCode.X))
            {
                Destroy(bird);
            }
        }
    }
}
