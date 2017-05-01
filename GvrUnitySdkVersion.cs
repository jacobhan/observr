
using UnityEngine;

/// <summary>
/// Provides and logs versioning information for the GVR Unity SDK.
/// </summary>
public class GvrUnitySdkVersion {
  public const string GVR_SDK_VERSION = "1.40";

// Only log GVR SDK version when the current build platform is Android or iOS.
#if UNITY_ANDROID || UNITY_IOS
  private const string VERSION_HEADER = "GVR Unity SDK Version: ";

  [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
  static void LogGvrUnitySdkVersion() {
    Debug.Log(VERSION_HEADER + GVR_SDK_VERSION);
  }
#endif  // UNITY_ANDROID || UNITY_IOS
}
