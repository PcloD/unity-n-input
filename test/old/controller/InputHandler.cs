using UnityEngine;
using N;

namespace N.Package.Controller {

  /** This is the configuration for a single player's controller */
  [AddComponentMenu("")]
  public class InputHandler : MonoBehaviour {

    [Tooltip("Id of the event")]
    public string eventId;
  }
}