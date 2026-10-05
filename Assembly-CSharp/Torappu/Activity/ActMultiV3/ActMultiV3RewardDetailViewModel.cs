using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F36 RID: 28470
	[Token(Token = "0x2006F36")]
	public class ActMultiV3RewardDetailViewModel : IHotfixable
	{
		// Token: 0x060286F5 RID: 165621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286F5")]
		[Address(RVA = "0x23BB0C0", Offset = "0x23B9CC0", VA = "0x1823BB0C0")]
		public void LoadData(string actId, int totalCount, int currCount)
		{
		}

		// Token: 0x060286F6 RID: 165622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286F6")]
		[Address(RVA = "0x23BB1D0", Offset = "0x23B9DD0", VA = "0x1823BB1D0")]
		public ActMultiV3RewardDetailViewModel()
		{
		}

		// Token: 0x04039849 RID: 235593
		[Token(Token = "0x4039849")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x0403984A RID: 235594
		[Token(Token = "0x403984A")]
		[FieldOffset(Offset = "0x18")]
		public int totalCount;

		// Token: 0x0403984B RID: 235595
		[Token(Token = "0x403984B")]
		[FieldOffset(Offset = "0x1C")]
		public int currCount;

		// Token: 0x0403984C RID: 235596
		[Token(Token = "0x403984C")]
		[FieldOffset(Offset = "0x20")]
		public string dailyMissionName;

		// Token: 0x0403984D RID: 235597
		[Token(Token = "0x403984D")]
		[FieldOffset(Offset = "0x28")]
		public string dailyMissionRule;

		// Token: 0x0403984E RID: 235598
		[Token(Token = "0x403984E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403984F RID: 235599
		[Token(Token = "0x403984F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
