using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    Camera ARCamera;
    [SerializeField] float rotationDamping;
    [SerializeField] float speed;

    // Start is called before the first frame update
    void Start()
    {
        ARCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        //bird rotate towards phone
        Quaternion _rotation = Quaternion.LookRotation(ARCamera.transform.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, _rotation, rotationDamping * Time.deltaTime);

        //bird flies up
        //transform.Translate(Vector3.up * Time.deltaTime * speed);
        transform.position = transform.position + Vector3.up * Time.deltaTime * speed;
    }
}
