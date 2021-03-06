﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1.Composite
{
    class Map: IComponent
    {
        private readonly List<IComponent> _map = new List<IComponent>();
        public string Title { get; set; }

        public void AddComponent(IComponent component)
        {
            _map.Add(component);
        }

        public void Draw()
        {
            Console.WriteLine(Title);
            foreach (var component in _map)
            {
                component.Draw();
            }
        }

        public IComponent Find(string title)
        {
            if (Title == title)
            {
                return this;
            }
            foreach (var component in _map)
            {
                var found = component.Find(title);
                if (found != null)
                {
                    return found;
                }
            }
            return null;
        }
    }
}
