using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Managers : MonoBehaviour {
  /**
   * Returns the manager of the specified type.
   */
  public static T Get<T>() where T : Manager {
    return Instance.GetManager<T>();
  }

  private T GetManager<T>() where T : Manager {
    var type = typeof(T);
    Manager manager = default(T);
    managers.TryGetValue(type, out manager);
    if (manager == null) {
      Debug.LogError("Manager not found: " + type.ToString());
    }
    return (T) System.Convert.ChangeType(manager, type);
  }

  /// This holds all the managers that this class is aware of.
  private Dictionary<System.Type, Manager> managers =
    new Dictionary<System.Type, Manager>();

  /// Singleton.
  private static Managers instance;
  private static Managers Instance {
    get {
      if(instance == null) {
        Debug.LogError("There is no Managers object in the scene. Set it as " +
          "a top level GameObject in the scene and add all of your Manager " +
          "scripts to the same GameObject");
      }
      return instance;
    }
  }

  private void Awake() {
    if (instance != null) {
      Debug.LogError("The Managers class is being instantiated more than once." +
          "Make sure there is only one Managers GameObject in the scene.");
    }
    instance = this;
    managers = new Dictionary<System.Type, Manager>();
    var managerList = GetComponents<Manager>();
    foreach (var manager in managerList) {
      var type = manager.GetType();
      if (managers.ContainsKey(type)) {
        Debug.LogError("Multiple managers registered for type " + type);
      }
      managers.Add(type, manager);
    }
  }
}
