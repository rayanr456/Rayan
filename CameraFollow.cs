using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
   public Transform target; // The target to follow

   void FixedUpdate () {
      transform.position = target.position;
   }
}
