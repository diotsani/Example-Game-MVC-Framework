using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace ExampleGame.Boot
{
    public class SplashScreen : BaseSplash<SplashScreen>
    {
        public GameObject loading;
        float interval = 3f;
        public float timer;
        protected override ILoad GetLoader()
        {
            return SceneLoader.Instance;
        }

        protected override IMain GetMain()
        {
            return GameMain.Instance;
        }

        void Loading()
        {
            loading.SetActive(true);
            timer += Time.deltaTime;
            print(timer);
            if (timer >= interval)
            {
                loading.SetActive(false);
                base.FinishSplash();
                base.FinishTransition();
                timer -= interval;
            }
        }
    }

}
