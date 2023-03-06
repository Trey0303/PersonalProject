using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;


/// <summary>
/// contains all the information from a hit stability evaluation
/// </summary>
public struct HitStabilityReport
{
    public bool IsStable;

    public bool FoundInnerNormal;
    public Vector3 InnerNormal;
    public bool FoundOuterNormal;
    public Vector3 OuterNormal;

    public bool ValidStepDetection;
    public Collider SteppedCollider;

    public bool LedgeDetected;
    public bool IsOnEmptySideLedge;
    public float DistanceFromLedge;
    public bool IsMovingTowardsEmptySideOfLedge;
    public Vector3 LedgeGroundNormal;
    public Vector3 LedgeRightDirection;
    public Vector3 LedgeLeftDirection;
}


/// <summary>
/// Component that manages character collisions and movement solving(this will only work with a capsule collider)
/// </summary>
[RequireComponent(typeof(CapsuleCollider))]
public class MyKinematicMotor : MonoBehaviour
{

    [Header("Components")]
    /// <summary>
    /// The capsule collider of this motor
    /// </summary>
    [ReadOnly]
    public CapsuleCollider Capsule;

    [Header("Capsule Settings")]
    [SerializeField]
    [Tooltip("Radius of the Character Capsule")]
    private float CapsuleRadius = 0.5f;


    /// <summary>
    /// The motor's assigned controller
    /// </summary>
    [NonSerialized]
    public ICharaController CharacterController;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
