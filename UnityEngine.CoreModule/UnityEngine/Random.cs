using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x020000EA RID: 234
	[Token(Token = "0x20000EA")]
	[NativeHeader("Runtime/Export/Random/Random.bindings.h")]
	public static class Random
	{
		// Token: 0x060008CA RID: 2250
		[Token(Token = "0x60008CA")]
		[Address(RVA = "0x5952390", Offset = "0x5950F90", VA = "0x185952390")]
		[FreeFunction]
		[MethodImpl(4096)]
		public static extern float Range(float minInclusive, float maxInclusive);

		// Token: 0x060008CB RID: 2251 RVA: 0x00005AA8 File Offset: 0x00003CA8
		[Token(Token = "0x60008CB")]
		[Address(RVA = "0x5952350", Offset = "0x5950F50", VA = "0x185952350")]
		public static int Range(int minInclusive, int maxExclusive)
		{
			return 0;
		}

		// Token: 0x060008CC RID: 2252
		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x5952350", Offset = "0x5950F50", VA = "0x185952350")]
		[FreeFunction]
		[MethodImpl(4096)]
		private static extern int RandomRangeInt(int minInclusive, int maxExclusive);

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x060008CD RID: 2253
		[Token(Token = "0x170001E5")]
		public static extern float value { [Token(Token = "0x60008CD")] [Address(RVA = "0x59523E0", Offset = "0x5950FE0", VA = "0x1859523E0")] [FreeFunction] [MethodImpl(4096)] get; }
	}
}
