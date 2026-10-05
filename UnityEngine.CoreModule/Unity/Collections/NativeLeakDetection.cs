using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Unity.Collections
{
	// Token: 0x02000023 RID: 35
	[Token(Token = "0x2000023")]
	public static class NativeLeakDetection
	{
		// Token: 0x06000020 RID: 32 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x5935BC0", Offset = "0x59347C0", VA = "0x185935BC0")]
		[RuntimeInitializeOnLoadMethod]
		private static void Initialize()
		{
		}

		// Token: 0x0400005D RID: 93
		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x0")]
		private static int s_NativeLeakDetectionMode;
	}
}
