# Dear ImGui for Unity

UPM package for the immediate mode GUI library, Dear ImGui (https://github.com/ocornut/imgui).

### Usage

- [Add package](https://docs.unity3d.com/Manual/upm-ui-giturl.html) from git URL: https://github.com/realgamessoftware/dear-imgui-unity.git .
- Add a `DearImGui` component to one of the objects in the scene.
- When using the Universal Render Pipeline, add a `Render Im Gui Feature` render feature to the renderer asset. Assign it to the `render feature` field of the DearImGui component.
- Subscribe to the `ImGuiUn.Layout` event and use ImGui functions.
- Example script:
  ```cs
  using UnityEngine;
  using UnityEngine.UI;
  using ImGuiNET;

  public class DearImGuiDemo : Graphic
  {
      void OnEnable()
      {
          ImGuiUn.Layout += OnLayout;
      }

      void OnDisable()
      {
          ImGuiUn.Layout -= OnLayout;
      }

      void OnLayout()
      {
          ImGui.ShowDemoWindow();
      }

      // Intercept mouse input for the whole Unity project including UI input by overriding this function from `Graphic`.
      // When the Unity Input System tries to decide what the mouse is over, this function will be called.
      public override bool Raycast(Vector2 sp, Camera eventCamera)
      {
          if (!isActiveAndEnabled)
          {
              return false;
          }
  
          return ImGui.GetIO().WantCaptureMouse;
      }
  }
  ```

### See Also

This package uses Dear ImGui C bindings by [cimgui](https://github.com/cimgui/cimgui) and the C# wrapper by [ImGui.NET](https://github.com/mellinoe/ImGui.NET).

The development project for the package can be found at https://github.com/realgamessoftware/dear-imgui-unity-dev .
