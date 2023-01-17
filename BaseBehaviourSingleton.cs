using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DodGame
{ 
    //统一的基类
    public class BaseBehaviourSingleton : MonoBehaviour
    {
        // Start is called before the first frame update
        public virtual void Awake()
        {
        }
        public virtual bool IsHaveLateUpdate()
        {
            return false;
        }
        public virtual void Start()
        {
        }
        public virtual void Update()
        {
        }
        public virtual void LateUpdate()
        {
        }
    }
}

