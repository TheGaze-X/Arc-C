using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Informant
{
	// Token: 0x02004A47 RID: 19015
	[Token(Token = "0x2004A47")]
	public class InformantSingleSettlementViewModel : IHotfixable
	{
		// Token: 0x0601C95E RID: 117086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C95E")]
		[Address(RVA = "0x161B500", Offset = "0x161A100", VA = "0x18161B500")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x0601C95F RID: 117087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C95F")]
		[Address(RVA = "0x161B910", Offset = "0x161A510", VA = "0x18161B910")]
		public InformantSingleSettlementViewModel()
		{
		}

		// Token: 0x0402586F RID: 153711
		[Token(Token = "0x402586F")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x04025870 RID: 153712
		[Token(Token = "0x4025870")]
		[FieldOffset(Offset = "0x18")]
		public InformantInsightBarModel insightBarModel;

		// Token: 0x04025871 RID: 153713
		[Token(Token = "0x4025871")]
		[FieldOffset(Offset = "0x20")]
		public bool success;

		// Token: 0x04025872 RID: 153714
		[Token(Token = "0x4025872")]
		[FieldOffset(Offset = "0x24")]
		public int successRate;

		// Token: 0x04025873 RID: 153715
		[Token(Token = "0x4025873")]
		[FieldOffset(Offset = "0x28")]
		public float incomeRate;

		// Token: 0x04025874 RID: 153716
		[Token(Token = "0x4025874")]
		[FieldOffset(Offset = "0x2C")]
		public int bonusRate;

		// Token: 0x04025875 RID: 153717
		[Token(Token = "0x4025875")]
		[FieldOffset(Offset = "0x30")]
		public int basicIncome;

		// Token: 0x04025876 RID: 153718
		[Token(Token = "0x4025876")]
		[FieldOffset(Offset = "0x34")]
		public int income;

		// Token: 0x04025877 RID: 153719
		[Token(Token = "0x4025877")]
		[FieldOffset(Offset = "0x38")]
		public string keeperDialogText;

		// Token: 0x04025878 RID: 153720
		[Token(Token = "0x4025878")]
		[FieldOffset(Offset = "0x40")]
		public bool inCheckState;

		// Token: 0x04025879 RID: 153721
		[Token(Token = "0x4025879")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402587A RID: 153722
		[Token(Token = "0x402587A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
