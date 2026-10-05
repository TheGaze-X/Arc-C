using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Events;

namespace UnityEngine
{
	// Token: 0x02000070 RID: 112
	[Token(Token = "0x2000070")]
	internal static class BeforeRenderHelper
	{
		// Token: 0x060002BD RID: 701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x591FB90", Offset = "0x591E790", VA = "0x18591FB90")]
		public static void Invoke()
		{
		}

		// Token: 0x0400015C RID: 348
		[Token(Token = "0x400015C")]
		[FieldOffset(Offset = "0x0")]
		private static List<BeforeRenderHelper.OrderBlock> s_OrderBlocks;

		// Token: 0x02000071 RID: 113
		[Token(Token = "0x2000071")]
		private struct OrderBlock
		{
			// Token: 0x0400015D RID: 349
			[Token(Token = "0x400015D")]
			[FieldOffset(Offset = "0x0")]
			internal int order;

			// Token: 0x0400015E RID: 350
			[Token(Token = "0x400015E")]
			[FieldOffset(Offset = "0x8")]
			internal UnityAction callback;
		}
	}
}
