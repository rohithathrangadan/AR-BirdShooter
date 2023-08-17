using UnityEngine;

public class ShootScript : MonoBehaviour
{
    [SerializeField] GameObject arCamera;
    [SerializeField] GameObject bloodSplatter;

    public void Shoot()
    {
        RaycastHit hit;

        if (Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hit))
        {
            Debug.Log("Raycast is hit");
            if (hit.transform.name == "MamaBird_Red(Clone)" || hit.transform.name == "MamaBird_Blue(Clone)" || hit.transform.name == "BabyBird(Clone)")
            {
                Debug.Log(hit.transform.name + "is destroyed");
                Destroy(hit.transform.gameObject);
                Instantiate(bloodSplatter, hit.point, Quaternion.LookRotation(hit.normal));
            }
        }
    }

}
