using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace ExampleGame.Module.ClickGame
{
    public interface IClickGameModel : IBaseModel
    {
        public int Coin { get; }
    }
}

