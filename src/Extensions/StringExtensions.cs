﻿// ReSharper disable MemberCanBePrivate.Global UnusedMember.Global UnusedMethodReturnValue.Global UnusedType.Global
using System;
using UnityEngine;

static class StringExtensions
{
    public static string Bold(this string str)
    {
        return $"<b>{str}</b>";
    }

    public static string Italic(this string str)
    {
        return $"<i>{str}</i>";
    }

    public static string Size(this string str, int size)
    {
        return $"<size={size.ToString()}>{str}</size>";
    }

    public static string Color(this string str, string color)
    {
        return $"<color={color}>{str}</color>";
    }

    public static string Color(this string str, Color color)
    {
        return str.Color($"#{ColorUtility.ToHtmlStringRGB(color)}");
    }
}
