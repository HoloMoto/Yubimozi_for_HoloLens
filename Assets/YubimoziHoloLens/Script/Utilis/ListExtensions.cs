using System;
using System.Collections.Generic;

/// <summary>
/// List 型の拡張メソッドを管理するクラス
/// </summary>
public static class ListExtensions
{
    /// <summary>
    /// サイズを設定します
    /// </summary>
    public static void SetSize<T>( this List<T> self, int size )
    {
        if ( self.Count <= size ) return;
        self.RemoveRange( size, self.Count - size );
    }
}