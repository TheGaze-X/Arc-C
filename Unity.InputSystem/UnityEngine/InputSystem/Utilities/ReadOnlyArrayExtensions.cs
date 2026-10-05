using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.Utilities
{
	// Token: 0x02000259 RID: 601
	[Token(Token = "0x2000259")]
	public static class ReadOnlyArrayExtensions
	{
		// Token: 0x060015C9 RID: 5577 RVA: 0x0000BB80 File Offset: 0x00009D80
		[Token(Token = "0x60015C9")]
		public static bool Contains<TValue>(this ReadOnlyArray<TValue> array, TValue value) where TValue : IComparable<TValue>
		{
			return default(bool);
		}

		// Token: 0x060015CA RID: 5578 RVA: 0x0000BB98 File Offset: 0x00009D98
		[Token(Token = "0x60015CA")]
		public static bool ContainsReference<TValue>(this ReadOnlyArray<TValue> array, TValue value) where TValue : class
		{
			return default(bool);
		}

		// Token: 0x060015CB RID: 5579 RVA: 0x0000BBB0 File Offset: 0x00009DB0
		[Token(Token = "0x60015CB")]
		public static int IndexOfReference<TValue>(this ReadOnlyArray<TValue> array, TValue value) where TValue : class
		{
			return 0;
		}

		// Token: 0x060015CC RID: 5580 RVA: 0x0000BBC8 File Offset: 0x00009DC8
		[Token(Token = "0x60015CC")]
		internal static bool HaveEqualReferences<TValue>(this ReadOnlyArray<TValue> array1, IReadOnlyList<TValue> array2, int count = 2147483647)
		{
			return default(bool);
		}
	}
}
