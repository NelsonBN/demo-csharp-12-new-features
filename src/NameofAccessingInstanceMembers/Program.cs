﻿using System.ComponentModel;

var foo = new Foo();

public class Foo
{
    public string S { get; } = "";
    public static int StaticField;
    public string NameOfLength { get; } = nameof(S.Length);

    public static void NameOfExamples()
    {
        Console.WriteLine(nameof(S.Length));
        Console.WriteLine(nameof(StaticField.MinValue));
    }

    [Description($"String {nameof(S.Length)}")]
    public int StringLength(string s) { return s.Length; }
}