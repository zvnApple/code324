﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Just_Nom.Classes
{
    public class MenuHelper
    {
        internal abstract class ConsoleMenu : MenuItem
        {
            protected List<MenuItem> _menuItems = new List<MenuItem>();

            public bool IsActive { get; set; }

            public abstract void CreateMenu();

            public override void Select()
            {
                IsActive = true;
                do
                {
                    CreateMenu();
                    string output = $"{MenuText()}{Environment.NewLine}";
                    int selection = ConsoleUI.GetIntegerInRange(1, _menuItems.Count);
                    _menuItems[selection - 1].Select();
                } while (IsActive);
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(MenuText());
                for (int i = 0; i < _menuItems.Count; i++)
                {
                    sb.AppendLine($"{i + 1}. {_menuItems[i].MenuText()}");
                }
                return sb.ToString();
            }
        }
    }


}

