using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Roguelike;

namespace Torappu.Battle.AntiCheat
{
	// Token: 0x02002A8E RID: 10894
	[Token(Token = "0x2002A8E")]
	public struct RelicSnapshot
	{
		// Token: 0x06012159 RID: 74073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012159")]
		[Address(RVA = "0xA27A50", Offset = "0xA26650", VA = "0x180A27A50")]
		public List<object> ToList()
		{
			return null;
		}

		// Token: 0x0601215A RID: 74074 RVA: 0x0006EAC0 File Offset: 0x0006CCC0
		[Token(Token = "0x601215A")]
		[Address(RVA = "0xA27B30", Offset = "0xA26730", VA = "0x180A27B30")]
		public static bool TryCreateFrom(BasicRelic relic, out RelicSnapshot snapshot)
		{
			return default(bool);
		}

		// Token: 0x04014784 RID: 83844
		[Token(Token = "0x4014784")]
		[FieldOffset(Offset = "0x0")]
		public string key;

		// Token: 0x04014785 RID: 83845
		[Token(Token = "0x4014785")]
		[FieldOffset(Offset = "0x8")]
		public int layer;

		// Token: 0x04014786 RID: 83846
		[Token(Token = "0x4014786")]
		[FieldOffset(Offset = "0x10")]
		public BlackboardSnapshot blackboard;
	}
}
