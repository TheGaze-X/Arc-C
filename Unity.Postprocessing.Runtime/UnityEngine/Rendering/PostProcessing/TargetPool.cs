using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000096 RID: 150
	[Token(Token = "0x2000096")]
	internal class TargetPool
	{
		// Token: 0x06000265 RID: 613 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000265")]
		[Address(RVA = "0x584E6D0", Offset = "0x584D2D0", VA = "0x18584E6D0")]
		internal TargetPool()
		{
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00002F9C File Offset: 0x0000119C
		[Token(Token = "0x6000266")]
		[Address(RVA = "0x584E450", Offset = "0x584D050", VA = "0x18584E450")]
		internal int Get()
		{
			return 0;
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00002FB4 File Offset: 0x000011B4
		[Token(Token = "0x6000267")]
		[Address(RVA = "0x584E590", Offset = "0x584D190", VA = "0x18584E590")]
		private int Get(int i)
		{
			return 0;
		}

		// Token: 0x06000268 RID: 616 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000268")]
		[Address(RVA = "0x1FC1100", Offset = "0x1FBFD00", VA = "0x181FC1100")]
		internal void Reset()
		{
		}

		// Token: 0x0400036E RID: 878
		[Token(Token = "0x400036E")]
		[FieldOffset(Offset = "0x10")]
		private readonly List<int> m_Pool;

		// Token: 0x0400036F RID: 879
		[Token(Token = "0x400036F")]
		[FieldOffset(Offset = "0x18")]
		private int m_Current;
	}
}
