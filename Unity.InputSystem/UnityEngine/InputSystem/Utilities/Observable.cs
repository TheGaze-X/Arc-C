using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.InputSystem.LowLevel;

namespace UnityEngine.InputSystem.Utilities
{
	// Token: 0x0200024A RID: 586
	[Token(Token = "0x200024A")]
	public static class Observable
	{
		// Token: 0x06001542 RID: 5442 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001542")]
		public static IObservable<TValue> Where<TValue>(this IObservable<TValue> source, Func<TValue, bool> predicate)
		{
			return null;
		}

		// Token: 0x06001543 RID: 5443 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001543")]
		public static IObservable<TResult> Select<TSource, TResult>(this IObservable<TSource> source, Func<TSource, TResult> filter)
		{
			return null;
		}

		// Token: 0x06001544 RID: 5444 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001544")]
		public static IObservable<TResult> SelectMany<TSource, TResult>(this IObservable<TSource> source, Func<TSource, IEnumerable<TResult>> filter)
		{
			return null;
		}

		// Token: 0x06001545 RID: 5445 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001545")]
		public static IObservable<TValue> Take<TValue>(this IObservable<TValue> source, int count)
		{
			return null;
		}

		// Token: 0x06001546 RID: 5446 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001546")]
		[Address(RVA = "0x56120C0", Offset = "0x5610CC0", VA = "0x1856120C0")]
		public static IObservable<InputEventPtr> ForDevice(this IObservable<InputEventPtr> source, InputDevice device)
		{
			return null;
		}

		// Token: 0x06001547 RID: 5447 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001547")]
		public static IObservable<InputEventPtr> ForDevice<TDevice>(this IObservable<InputEventPtr> source) where TDevice : InputDevice
		{
			return null;
		}

		// Token: 0x06001548 RID: 5448 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001548")]
		public static IDisposable CallOnce<TValue>(this IObservable<TValue> source, Action<TValue> action)
		{
			return null;
		}

		// Token: 0x06001549 RID: 5449 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001549")]
		public static IDisposable Call<TValue>(this IObservable<TValue> source, Action<TValue> action)
		{
			return null;
		}
	}
}
