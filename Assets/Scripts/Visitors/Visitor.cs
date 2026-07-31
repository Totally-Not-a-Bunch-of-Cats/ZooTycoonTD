using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Visitor : MonoBehaviour
{

    VisitorInfo visitorInfo;

    VisitorWeights visitorWeights;

    float currentCash;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float ChargeVisitor(float chargeAmount)
    {
        float actualChargeAmount = Math.Min(currentCash,chargeAmount);

        currentCash -= actualChargeAmount;

        return actualChargeAmount;
    }
}
