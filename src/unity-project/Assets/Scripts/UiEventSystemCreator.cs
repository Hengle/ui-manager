﻿using UnityEngine;
using UnityEngine.EventSystems;

namespace UserInterface
{
    public class UiEventSystemCreator : Singleton<UiEventSystemCreator>
    {
        private const string Name = "EventSystem";

        public void Create<TEventSystem, TStandaloneInputModule>()
            where TEventSystem : EventSystem
            where TStandaloneInputModule : StandaloneInputModule
        {
            if (FindObjectOfType<TEventSystem>() == null)
            {
                var eventSystem = new GameObject(Name);
                eventSystem.AddComponent<TEventSystem>();
                eventSystem.AddComponent<TStandaloneInputModule>();
            }
        }
    }
}