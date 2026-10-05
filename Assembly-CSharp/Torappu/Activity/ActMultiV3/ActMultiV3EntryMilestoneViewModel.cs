using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F29 RID: 28457
	[Token(Token = "0x2006F29")]
	public class ActMultiV3EntryMilestoneViewModel : IHotfixable
	{
		// Token: 0x060286D2 RID: 165586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286D2")]
		[Address(RVA = "0x23AC840", Offset = "0x23AB440", VA = "0x1823AC840")]
		private void _CalculateRank(string actId, ActMultiV3Data actData, PlayerActivity.PlayerMultiV3Activity playerActivity)
		{
		}

		// Token: 0x060286D3 RID: 165587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286D3")]
		[Address(RVA = "0x23AC6B0", Offset = "0x23AB2B0", VA = "0x1823AC6B0")]
		public void LoadData(string actId, PlayerActivity.PlayerMultiV3Activity playerActivity, ActMultiV3Data actData)
		{
		}

		// Token: 0x060286D4 RID: 165588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286D4")]
		[Address(RVA = "0x23ACAD0", Offset = "0x23AB6D0", VA = "0x1823ACAD0")]
		public ActMultiV3EntryMilestoneViewModel()
		{
		}

		// Token: 0x040397E8 RID: 235496
		[Token(Token = "0x40397E8")]
		[FieldOffset(Offset = "0x10")]
		public int currPoint;

		// Token: 0x040397E9 RID: 235497
		[Token(Token = "0x40397E9")]
		[FieldOffset(Offset = "0x14")]
		public int currRank;

		// Token: 0x040397EA RID: 235498
		[Token(Token = "0x40397EA")]
		[FieldOffset(Offset = "0x18")]
		public bool isMaxRank;

		// Token: 0x040397EB RID: 235499
		[Token(Token = "0x40397EB")]
		[FieldOffset(Offset = "0x1C")]
		public int currRankStartPoint;

		// Token: 0x040397EC RID: 235500
		[Token(Token = "0x40397EC")]
		[FieldOffset(Offset = "0x20")]
		public int nextRankStartPoint;

		// Token: 0x040397ED RID: 235501
		[Token(Token = "0x40397ED")]
		[FieldOffset(Offset = "0x24")]
		public bool hasNewRank;

		// Token: 0x040397EE RID: 235502
		[Token(Token = "0x40397EE")]
		[FieldOffset(Offset = "0x25")]
		public bool hasUnreceivedReward;

		// Token: 0x040397EF RID: 235503
		[Token(Token = "0x40397EF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__CalculateRank;

		// Token: 0x040397F0 RID: 235504
		[Token(Token = "0x40397F0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040397F1 RID: 235505
		[Token(Token = "0x40397F1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
