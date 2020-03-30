using UnityEngine;
using System.Collections;

public class SharkScript : MonoBehaviour
{
    //public AnimationCurve myCurveX;
    //public AnimationCurve myCurveY;
    //public AnimationCurve myCurveZ;
    int times = 0;
    int ran = 0;

    void Update()
    {
        if (times == 0)
        {
            ran = (int)Random.Range(-1, 2);
            times = 390;
        }
        else if (times > 300 && times < 391)
        {
            transform.rotation = Quaternion.Euler(0, transform.rotation.eulerAngles.y + ran, 0);
            times -= 1;
        }
        else
        {
            //var y = myCurveY.Evaluate((Time.time % myCurveY.length));

            if (System.Math.Abs(transform.rotation.eulerAngles.y) < 1)
            {
                transform.position = new Vector3(transform.position.x, Terrain.activeTerrain.SampleHeight(transform.position) + 1f, transform.position.z + Random.Range(0.0f, 0.05f));
            }
            else if (System.Math.Abs(transform.rotation.eulerAngles.y - 90) < 1)
            {
                transform.position = new Vector3(transform.position.x + Random.Range(0.0f, 0.05f), Terrain.activeTerrain.SampleHeight(transform.position) + 1f, transform.position.z);
            }
            else if (System.Math.Abs(transform.rotation.eulerAngles.y - 180) < 1)
            {
                transform.position = new Vector3(transform.position.x, Terrain.activeTerrain.SampleHeight(transform.position) + 1f, transform.position.z - Random.Range(0.0f, 0.05f));
            }
            else if (System.Math.Abs(transform.rotation.eulerAngles.y - 270) < 1)
            {
                transform.position = new Vector3(transform.position.x - Random.Range(0.0f, 0.05f), Terrain.activeTerrain.SampleHeight(transform.position) + 1f, transform.position.z);
            }
            times -= 1;
        }
    }
}


