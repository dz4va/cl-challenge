using UnityEngine;
using UnityEngine.Events;
using System.Collections;

namespace Challenge {
    public static class CoroutineUtilities {

        public static IEnumerator DelayedExecution(float time, UnityAction action) {
            yield return new WaitForSeconds(time);
            action();
            yield return null;
        }

    }
}