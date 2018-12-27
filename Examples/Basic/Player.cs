/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 *
 * Author: Nuno Fachada
 * */

using System;
using CoreGameEngine;

namespace Basic
{
    public class Player : Component
    {
        private KeyObserver keyObserver;
        private Position position;
        public override void Start()
        {
            keyObserver = ParentGameObject.GetComponent<KeyObserver>();
            position = ParentGameObject.GetComponent<Position>();
        }

        public override void Update()
        {
            foreach (ConsoleKey key in keyObserver.GetCurrentKeys())
            {
                switch (key) {
                    case ConsoleKey.UpArrow:
                        position.Pos = new Vector3(
                            position.Pos.X, position.Pos.Y - 1, position.Pos.Z);
                        break;
                    case ConsoleKey.DownArrow:
                        position.Pos = new Vector3(
                            position.Pos.X, position.Pos.Y + 1, position.Pos.Z);
                        break;
                    case ConsoleKey.RightArrow:
                        position.Pos = new Vector3(
                            position.Pos.X + 1, position.Pos.Y, position.Pos.Z);
                        break;
                    case ConsoleKey.LeftArrow:
                        position.Pos = new Vector3(
                            position.Pos.X - 1, position.Pos.Y, position.Pos.Z);
                        break;
                }
                //Console.WriteLine($"Player position is ({position.Pos.X:f2}, {position.Pos.Y:f2})");
            }
        }

    }
}
