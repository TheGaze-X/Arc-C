using System;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.Utilities
{
	// Token: 0x02000239 RID: 569
	[Token(Token = "0x2000239")]
	internal static class InputArrayExtensions
	{
		// Token: 0x060014AD RID: 5293 RVA: 0x0000AD10 File Offset: 0x00008F10
		[Token(Token = "0x60014AD")]
		public static int IndexOfReference<TValue>(this InlinedArray<TValue> array, TValue value) where TValue : class
		{
			return 0;
		}

		// Token: 0x060014AE RID: 5294 RVA: 0x0000AD28 File Offset: 0x00008F28
		[Token(Token = "0x60014AE")]
		public static bool Contains<TValue>(this InlinedArray<TValue> array, TValue value)
		{
			return default(bool);
		}

		// Token: 0x060014AF RID: 5295 RVA: 0x0000AD40 File Offset: 0x00008F40
		[Token(Token = "0x60014AF")]
		public static bool ContainsReference<TValue>(this InlinedArray<TValue> array, TValue value) where TValue : class
		{
			return default(bool);
		}
	}
}
