using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Monopoly
{
	// Token: 0x02004837 RID: 18487
	[Token(Token = "0x2004837")]
	public class MonopolySettleModel : IHotfixable
	{
		// Token: 0x0601BEE9 RID: 114409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BEE9")]
		[Address(RVA = "0x155BB60", Offset = "0x155A760", VA = "0x18155BB60")]
		public void LoadData(string actId, MonopolySettleGameResponse response)
		{
		}

		// Token: 0x0601BEEA RID: 114410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BEEA")]
		[Address(RVA = "0x155C090", Offset = "0x155AC90", VA = "0x18155C090")]
		public MonopolySettleModel()
		{
		}

		// Token: 0x040246AE RID: 149166
		[Token(Token = "0x40246AE")]
		[FieldOffset(Offset = "0x10")]
		public string stageId;

		// Token: 0x040246AF RID: 149167
		[Token(Token = "0x40246AF")]
		[FieldOffset(Offset = "0x18")]
		public string stageName;

		// Token: 0x040246B0 RID: 149168
		[Token(Token = "0x40246B0")]
		[FieldOffset(Offset = "0x20")]
		public ListDict<string, int> resourceDict;

		// Token: 0x040246B1 RID: 149169
		[Token(Token = "0x40246B1")]
		[FieldOffset(Offset = "0x28")]
		public int score;

		// Token: 0x040246B2 RID: 149170
		[Token(Token = "0x40246B2")]
		[FieldOffset(Offset = "0x2C")]
		public int target;

		// Token: 0x040246B3 RID: 149171
		[Token(Token = "0x40246B3")]
		[FieldOffset(Offset = "0x30")]
		public Act46SideData.Act46SideSettleType settleType;

		// Token: 0x040246B4 RID: 149172
		[Token(Token = "0x40246B4")]
		[FieldOffset(Offset = "0x34")]
		public bool isHighScore;

		// Token: 0x040246B5 RID: 149173
		[Token(Token = "0x40246B5")]
		[FieldOffset(Offset = "0x38")]
		public List<RewardItemModel> rewards;

		// Token: 0x040246B6 RID: 149174
		[Token(Token = "0x40246B6")]
		[FieldOffset(Offset = "0x40")]
		public string randomSettleDialog;

		// Token: 0x040246B7 RID: 149175
		[Token(Token = "0x40246B7")]
		[FieldOffset(Offset = "0x48")]
		public string randomSettleCharAvaterId;

		// Token: 0x040246B8 RID: 149176
		[Token(Token = "0x40246B8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040246B9 RID: 149177
		[Token(Token = "0x40246B9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
