using System;
using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;
using Il2CppDummyDll;
using Torappu.Battle.Runes;

namespace Torappu.Battle.AntiCheat
{
	// Token: 0x02002A8D RID: 10893
	[Token(Token = "0x2002A8D")]
	public struct RuneSnapShot
	{
		// Token: 0x06012157 RID: 74071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012157")]
		[Address(RVA = "0xA27C40", Offset = "0xA26840", VA = "0x180A27C40")]
		public List<object> ToList()
		{
			return null;
		}

		// Token: 0x06012158 RID: 74072 RVA: 0x0006EAA8 File Offset: 0x0006CCA8
		[Token(Token = "0x6012158")]
		[Address(RVA = "0xA27D60", Offset = "0xA26960", VA = "0x180A27D60")]
		public static bool TryCreateFrom(Rune data, out RuneSnapShot snapshot)
		{
			return default(bool);
		}

		// Token: 0x0401477F RID: 83839
		[Token(Token = "0x401477F")]
		[FieldOffset(Offset = "0x0")]
		public long ts;

		// Token: 0x04014780 RID: 83840
		[Token(Token = "0x4014780")]
		[FieldOffset(Offset = "0x8")]
		public string key;

		// Token: 0x04014781 RID: 83841
		[Token(Token = "0x4014781")]
		[FieldOffset(Offset = "0x10")]
		public ObscuredInt professionMask;

		// Token: 0x04014782 RID: 83842
		[Token(Token = "0x4014782")]
		[FieldOffset(Offset = "0x24")]
		public ObscuredInt buildableMask;

		// Token: 0x04014783 RID: 83843
		[Token(Token = "0x4014783")]
		[FieldOffset(Offset = "0x38")]
		public List<Blackboard.DataPair> blackboard;
	}
}
