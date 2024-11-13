using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraInput : MonoBehaviour
{
    private ColourGrading colourGrading;
    public Material colourMat;

    // Start is called before the first frame update
    void Start()
    {
        colourGrading = GetComponent<ColourGrading>();
        print(colourGrading);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            colourMat.SetFloat("_Contribution", colourMat.GetFloat("_Contribution") + 0.05f);
        }
    }
}
