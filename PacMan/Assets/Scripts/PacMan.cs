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

    [SerializeField]
    private GameObject item;
    private Tweener tweener;

    // Start is called before the first frame update
    void Start()
    {
        /*startTime = Time.time;

        TravelRight = Vector3.Distance(TopLeft.position, TopRight.position);
        TravelDown = Vector3.Distance(TopRight.position, BottomRight.position);
        TravelLeft = Vector3.Distance(BottomRight.position, BottomLeft.position);
        TravelUp = Vector3.Distance(BottomLeft.position, TopLeft.position); */

        tweener = gameObject.GetComponent<Tweener>();
    }

    // Update is called once per frame
    void Update()
    {
        //StartCoroutine(MoveRight());

        if (item.transform.position == TopLeft.position) {
            tweener.AddTween(item.transform, item.transform.position, new Vector3(8.274508f,-0.93f,-120.4215f), 1.5f);
        }
        else if(item.transform.position == TopRight.position) {
            tweener.AddTween(item.transform, item.transform.position, new Vector3(8.274508f,-6.05f,-120.4215f), 1.5f);
        }
    }

    IEnumerator MoveRight() {

        transform.position = new Vector3(1.92f, -0.93f, -120.4215f);
        
        float distCovered1 =  (Time.time - startTime) * speed;
        float fractionOfDistance1 = distCovered1 / TravelRight;

        transform.position = Vector3.Lerp(TopLeft.position, TopRight.position, fractionOfDistance1);

        Debug.Log("Moved Right");
        yield return new WaitForSeconds(5);

        StartCoroutine(MoveDown());
    }

    IEnumerator MoveDown() {
        transform.position = new Vector3(8.274508f, -0.93f, -120.4215f);

        float distCovered2 =  (Time.time - startTime) * speed;
        float fractionOfDistance2 = distCovered2 / TravelDown;

        transform.position = Vector3.Lerp(TopRight.position, BottomRight.position, fractionOfDistance2);

        Debug.Log("Moved Down");
        yield return new WaitForSeconds(5);

        StartCoroutine(MoveLeft());
    }

    IEnumerator MoveLeft() {
        transform.position = new Vector3(8.274508f, -6.05f, -120.4215f);

        float distCovered3 =  (Time.time - startTime) * speed;
        float fractionOfDistance3 = distCovered3 / TravelLeft;

        transform.position = Vector3.Lerp(BottomRight.position, BottomLeft.position, fractionOfDistance3);

        Debug.Log("Moved Left");
        yield return new WaitForSeconds(5);

        StartCoroutine(MoveUp());
    }

    IEnumerator MoveUp() {
        transform.position = new Vector3(1.92f, -6.05f, -120.4215f);

        float distCovered4 =  (Time.time - startTime) * speed;
        float fractionOfDistance4 = distCovered4 / TravelUp;

        transform.position = Vector3.Lerp(BottomLeft.position, TopLeft.position, fractionOfDistance4);

        Debug.Log("Moved Up");
        yield return new WaitForSeconds(5);
    }
}
