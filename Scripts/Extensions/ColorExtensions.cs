﻿using UnityEngine;

namespace Fjord.Common.Extensions
{
    public static class ColorExtensions
    {
        public static Color ChangeAlpha(this Color color, float alpha)
        {
            return new Color(color.r, color.g, color.b, alpha);
        }
    }
}