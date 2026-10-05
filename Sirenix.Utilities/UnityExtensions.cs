using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sirenix.Utilities
{
	// Token: 0x02000038 RID: 56
	[Token(Token = "0x2000038")]
	public static class UnityExtensions
	{
		// Token: 0x0600020F RID: 527 RVA: 0x0000305C File Offset: 0x0000125C
		[Token(Token = "0x600020F")]
		[Address(RVA = "0x4E38100", Offset = "0x4E36D00", VA = "0x184E38100")]
		public static bool SafeIsUnityNull(this UnityEngine.Object obj)
		{
			return default(bool);
		}

		// Token: 0x04000156 RID: 342
		[Token(Token = "0x4000156")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ValueGetter<UnityEngine.Object, IntPtr> UnityObjectCachedPtrFieldGetter;
	}
}
