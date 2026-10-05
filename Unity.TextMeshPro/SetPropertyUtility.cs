using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TMPro
{
	// Token: 0x02000061 RID: 97
	[Token(Token = "0x2000061")]
	internal static class SetPropertyUtility
	{
		// Token: 0x06000380 RID: 896 RVA: 0x000033D8 File Offset: 0x000015D8
		[Token(Token = "0x6000380")]
		[Address(RVA = "0x58C1610", Offset = "0x58C0210", VA = "0x1858C1610")]
		public static bool SetColor(ref Color currentValue, Color newValue)
		{
			return default(bool);
		}

		// Token: 0x06000381 RID: 897 RVA: 0x000033F0 File Offset: 0x000015F0
		[Token(Token = "0x6000381")]
		public static bool SetEquatableStruct<T>(ref T currentValue, T newValue) where T : IEquatable<T>
		{
			return default(bool);
		}

		// Token: 0x06000382 RID: 898 RVA: 0x00003408 File Offset: 0x00001608
		[Token(Token = "0x6000382")]
		public static bool SetStruct<T>(ref T currentValue, T newValue) where T : struct
		{
			return default(bool);
		}

		// Token: 0x06000383 RID: 899 RVA: 0x00003420 File Offset: 0x00001620
		[Token(Token = "0x6000383")]
		public static bool SetClass<T>(ref T currentValue, T newValue) where T : class
		{
			return default(bool);
		}
	}
}
