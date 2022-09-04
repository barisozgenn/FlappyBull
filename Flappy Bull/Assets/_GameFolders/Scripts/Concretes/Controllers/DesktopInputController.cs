using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlappyBull.Controllers
{
    public class DesktopInputController
    {
        public bool LeftMouseClickDown => Input.GetMouseButtonDown(0);
        public bool SpaceButtonClickDown => Input.GetKeyDown(KeyCode.Space);
        public bool FButtonClickDown => Input.GetKeyDown(KeyCode.F);
    }

}
