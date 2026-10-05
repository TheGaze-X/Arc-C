using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004FA1 RID: 20385
	[Token(Token = "0x2004FA1")]
	public class EnemyDuelEntryRewardViewModel : IHotfixable
	{
		// Token: 0x0601E4CE RID: 124110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E4CE")]
		[Address(RVA = "0x17FD5E0", Offset = "0x17FC1E0", VA = "0x1817FD5E0")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x0601E4CF RID: 124111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E4CF")]
		[Address(RVA = "0x17FD850", Offset = "0x17FC450", VA = "0x1817FD850")]
		public EnemyDuelEntryRewardViewModel()
		{
		}

		// Token: 0x04028738 RID: 165688
		[Token(Token = "0x4028738")]
		[FieldOffset(Offset = "0x10")]
		public List<int> basicSore;

		// Token: 0x04028739 RID: 165689
		[Token(Token = "0x4028739")]
		[FieldOffset(Offset = "0x18")]
		public List<ActivityEnemyDuelExtraScoreData> operationScoreData;

		// Token: 0x0402873A RID: 165690
		[Token(Token = "0x402873A")]
		[FieldOffset(Offset = "0x20")]
		public List<ActivityEnemyDuelExtraScoreData> standScoreData;

		// Token: 0x0402873B RID: 165691
		[Token(Token = "0x402873B")]
		[FieldOffset(Offset = "0x28")]
		public float operationSkipRate;

		// Token: 0x0402873C RID: 165692
		[Token(Token = "0x402873C")]
		[FieldOffset(Offset = "0x2C")]
		public float operationBetRate;

		// Token: 0x0402873D RID: 165693
		[Token(Token = "0x402873D")]
		[FieldOffset(Offset = "0x30")]
		public float operationAllinRate;

		// Token: 0x0402873E RID: 165694
		[Token(Token = "0x402873E")]
		[FieldOffset(Offset = "0x34")]
		public float standRate;

		// Token: 0x0402873F RID: 165695
		[Token(Token = "0x402873F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04028740 RID: 165696
		[Token(Token = "0x4028740")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
