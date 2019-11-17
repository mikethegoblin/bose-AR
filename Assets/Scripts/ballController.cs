using Bose.Wearable;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    public float speed;
    public Text countText;
    public Text winText;

    Rigidbody rb;
    //int count;
    //GameObject[] getCount;
    //int pickUpCount;
    //WearableControl wearableControl;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //count = 0;
        //SetCountText();
        //winText.text = "You Win!";
        //winText.gameObject.SetActive(false);
        //getCount = GameObject.FindGameObjectsWithTag("Pick Up");
        //pickUpCount = getCount.Length;

        //wearableControl = WearableControl.Instance;

        //WearableRequirement requirement = GetComponent<WearableRequirement>();
        //if (requirement == null)
        //{
        //    requirement = gameObject.AddComponent<WearableRequirement>();
        //}
        //requirement.EnableSensor(SensorId.RotationNineDof);
        //requirement.SetSensorUpdateInterval(SensorUpdateInterval.EightyMs);
    }

    void FixedUpdate()
    {
        //if (wearableControl.ConnectedDevice == null)
        //{
        //    return;
        //}

        //SensorFrame sensorFrame = wearableControl.LastSensorFrame;

        //float moveHorizontal = sensorFrame.rotationNineDof.value.z;
        //float moveVertical = sensorFrame.rotationNineDof.value.x;

        //// Disable keyboard behavior
        //// float moveHorizontal = Input.GetAxis("Horizontal");
        //// float moveVertical = Input.GetAxis("Vertical");

        //Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        //rb.AddForce(movement * speed);
        float moveH = Input.gyro.userAcceleration.x;
        float moveV = Input.gyro.userAcceleration.y;

        Vector3 movement = new Vector3(moveH, 0.0f, moveV);

        rb.AddForce(movement * speed * Time.deltaTime);
    }

    //void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.CompareTag("Pick Up"))
    //    {
    //        other.gameObject.SetActive(false);
    //        count += 1;
    //        SetCountText();
    //    }

    //    if (other.gameObject.CompareTag("Crazy Pick Up"))
    //    {
    //        other.gameObject.transform.localScale += new Vector3(5, 0, 0);
    //        count += 1;
    //        SetCountText();
    //    }

    //    if (count == pickUpCount)
    //    {
    //        winText.gameObject.SetActive(true);
    //        rb.isKinematic = true;
    //        rb.velocity = new Vector3(0, 0, 0);
    //    }
    //}

    //void SetCountText()
    //{
    //    countText.text = "Count: " + count.ToString();
    //}
}
