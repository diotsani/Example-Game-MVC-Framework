using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using ExampleGame.Boot;
using ExampleGame.Home;
using ExampleGame.Module.ClickGame;

namespace ExampleGame.Gameplay
{
    public class GameplayView : BaseSceneView
    {
        [SerializeField] public ClickGameView clickGameView;
    }
}


