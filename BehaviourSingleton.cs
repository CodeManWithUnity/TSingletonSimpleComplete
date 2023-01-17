using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace DodGame
{
    class BehaviourSingleton<T> : BaseBehaviourSingleton where T : BaseBehaviourSingleton, new()
    {
        private static T sInstance;
        public static T Instance
        {
            get
            {
                if (null == sInstance)
                {
                    sInstance = new T();
                    Debug.Log(sInstance != null);
                    sInstance.Awake();
                }
                return sInstance;
            }
        }
    }
}
