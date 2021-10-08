using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    public Transform firePoint;
    public GameObject tiroPrefab;
    public UnityEngine.UI.Text fireTxt;

    public static float tiros = 0;

    private void Start()
    {
        tiros = 0;
    }

    // Update is called once per frame
    void Update()
    {
        fireTxt.text = tiros.ToString();

        if (tiros > 0)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Shoot();
            }
        }
    }

    void Shoot()
    {        
        Instantiate(tiroPrefab, firePoint.position, firePoint.rotation);
        tiros--;
        fireTxt.text = tiros.ToString();
    }
}
