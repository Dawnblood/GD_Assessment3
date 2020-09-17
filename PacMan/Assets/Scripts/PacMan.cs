using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacMan : MonoBehaviour
{
    public Transform TopLeft;
    public Transform TopRight;
    public Transform BottomLeft;
    public Transform BottomRight;

    private float startTime;

    private float speed = 30.0f;

    private float TravelRight;
    private float TravelDown;
    private float TravelLeft;
    private float TravelUp;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;

        TravelRight = Vector3.Distance(TopLeft.position, TopRight.position);
        TravelDown = Vector3.Distance(TopRight.position, BottomRight.position);
        TravelLeft = Vector3.Distance(BottomRight.position, BottomLeft.position);
        TravelUp = Vector3.Distance(BottomLeft.position, TopLeft.position);
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(MoveRight());
    }

    IEnumerator MoveRight() {
        float distCovered1 =  (Time.time - startTime) * speed;
        float fractionOfDistance1 = distCovered1 / TravelRight;

        transform.position = Vector3.Lerp(TopLeft.position, TopRight.position, fractionOfDistance1);

        yield return new WaitForSeconds(5);

        float distCovered2 =  (Time.time - startTime) * speed;
        float fractionOfDistance2 = distCovered2 / TravelDown;

        transform.position = Vector3.Lerp(TopRight.position, BottomRight.position, fractionOfDistance2);

        yield return new WaitForSeconds(5);

        float distCovered3 =  (Time.time - startTime) * speed;
        float fractionOfDistance3 = distCovered3 / TravelLeft;

        transform.position = Vector3.Lerp(BottomRight.position, BottomLeft.position, fractionOfDistance3);

        yield return new WaitForSeconds(5);

        float distCovered4 =  (Time.time - startTime) * speed;
        float fractionOfDistance4 = distCovered4 / TravelUp;

        transform.position = Vector3.Lerp(BottomLeft.position, TopLeft.position, fractionOfDistance4);

        yield return new WaitForSeconds(5);
    }
}
