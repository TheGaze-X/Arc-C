using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.Utilities
{
	// Token: 0x02000233 RID: 563
	[Token(Token = "0x2000233")]
	internal static class DelegateHelpers
	{
		// Token: 0x06001477 RID: 5239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001477")]
		[Address(RVA = "0x55FB660", Offset = "0x55FA260", VA = "0x1855FB660")]
		public static void InvokeCallbacksSafe(ref CallbackArray<Action> callbacks, string callbackName, [Optional] object context)
		{
		}

		// Token: 0x06001478 RID: 5240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001478")]
		public static void InvokeCallbacksSafe<TValue>(ref CallbackArray<Action<TValue>> callbacks, TValue argument, string callbackName, [Optional] object context)
		{
		}

		// Token: 0x06001479 RID: 5241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001479")]
		public static void InvokeCallbacksSafe<TValue1, TValue2>(ref CallbackArray<Action<TValue1, TValue2>> callbacks, TValue1 argument1, TValue2 argument2, string callbackName, [Optional] object context)
		{
		}

		// Token: 0x0600147A RID: 5242 RVA: 0x0000AB30 File Offset: 0x00008D30
		[Token(Token = "0x600147A")]
		public static bool InvokeCallbacksSafe_AnyCallbackReturnsTrue<TValue1, TValue2>(ref CallbackArray<Func<TValue1, TValue2, bool>> callbacks, TValue1 argument1, TValue2 argument2, string callbackName, [Optional] object context)
		{
			return default(bool);
		}

		// Token: 0x0600147B RID: 5243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600147B")]
		public static void InvokeCallbacksSafe_AndInvokeReturnedActions<TValue>(ref CallbackArray<Func<TValue, Action>> callbacks, TValue argument, string callbackName, [Optional] object context)
		{
		}

		// Token: 0x0600147C RID: 5244 RVA: 0x0000AB48 File Offset: 0x00008D48
		[Token(Token = "0x600147C")]
		public static bool InvokeCallbacksSafe_AnyCallbackReturnsObject<TValue, TReturn>(ref CallbackArray<Func<TValue, TReturn>> callbacks, TValue argument, string callbackName, [Optional] object context)
		{
			return default(bool);
		}
	}
}
