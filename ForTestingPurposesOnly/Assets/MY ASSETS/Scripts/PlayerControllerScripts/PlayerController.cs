using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour, ICharaController
{
    public MyKinematicMotor motor;

    // Start is called before the first frame update
    void Start()
    {
        //assign to motor
        //motor.CharacterController = this;
    }

    //this is called before the motor does anything
    public void BeforeCharacterUpdate(float deltaTime)
    {

    }
    
    // This is called when the motor wants to know what its rotation should be right now
    public void UpdateRotation(ref Quaternion currentRotation, float deltaTime)
    {

    }

    // This is called when the motor wants to know what its velocity should be right now
    public void UpdateVelocity(ref Vector3 currentVelocity, float deltaTime)
    {

    }
    
    //this is called after the motor has finished everything in its update
    public void AfterCharacterUpdate(float deltaTime)
    {

    }

    //this is called after when the motor wants to know if the collider can be collided with (or if we just go with it)
    public bool IsColliderValidForCollisions(Collider col)
    {
        return true;
    }

    //this is called when the motors ground probing detects a ground hit
    public void OnGroundHit(Collider hitCollider, Vector3 hitNormal, Vector3 hitPoint, ref HitStabilityReport hitStabilityReport)
    {

    }

    //this is called when the motors movement logic detects a hit
    public void OnMovementHit(Collider hitCollider, Vector3 hitNormal, Vector3 hitPoint, ref HitStabilityReport hitStabilityReport)
    {

    }

    //this is called after every hit detected in the motor, to give you a chance to modify the HitStabilityReport any way you want
    public void ProcessHitStabilityReport(Collider hitCollider, Vector3 hitNormal, Vector3 hitPoint, Vector3 atCharacterPosition, Quaternion atCharacterRotation, ref HitStabilityReport hitStabilityReport)
    {

    }

    //this is called after the motor has finished its ground probing, but before PhysicsMover/Velocity/etc...handling?
    public void PostGroundingUpdate(float deltaTime)
    {

    }

    //this is called by the motor when it is detecting a collision that did not result from a "movement hit"
    public void OnDiscreteCollisionDetected(Collider hitCollider)
    {

    }
}
