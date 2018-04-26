using UnityEngine;
using System;

namespace LowPolyAnimalPack
{
  [Serializable]
  public class IdleState : AnimalState
  {
    public float minStateTime = 500f;
    public float maxStateTime = 600f;
    [Tooltip("Chance of it choosing this state, in comparion to other state weights.")]
    public int stateWeight = 20;
  }
}