using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x020063AA RID: 25514
	[Token(Token = "0x20063AA")]
	public class AutoChessStageInfoChessGroupModel : UISimpleRecycleLayoutItemViewModel, IComparable
	{
		// Token: 0x06024C7C RID: 150652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024C7C")]
		[Address(RVA = "0x1FA5CE0", Offset = "0x1FA48E0", VA = "0x181FA5CE0", Slot = "4")]
		public override string GetViewType()
		{
			return null;
		}

		// Token: 0x06024C7D RID: 150653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C7D")]
		[Address(RVA = "0x1FA5D50", Offset = "0x1FA4950", VA = "0x181FA5D50")]
		public void LoadData(ActAutoChessData.ActAutoChessBondInfo bondInfo, ListDict<string, ActAutoChessData.ActAutoChessCharShopChessData> chessDataDict, Dictionary<string, ActAutoChessData.ActAutoChessCharChessData> charChessDataDict, Dictionary<string, string> chessNormalIdDict, List<string> bannedChessIdList)
		{
		}

		// Token: 0x06024C7E RID: 150654 RVA: 0x000C5700 File Offset: 0x000C3900
		[Token(Token = "0x6024C7E")]
		[Address(RVA = "0x1FA5B00", Offset = "0x1FA4700", VA = "0x181FA5B00", Slot = "6")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x06024C7F RID: 150655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C7F")]
		[Address(RVA = "0x1FA6140", Offset = "0x1FA4D40", VA = "0x181FA6140")]
		public AutoChessStageInfoChessGroupModel()
		{
		}

		// Token: 0x04033674 RID: 210548
		[Token(Token = "0x4033674")]
		public const string VIEW_TYPE = "CHESS";

		// Token: 0x04033675 RID: 210549
		[Token(Token = "0x4033675")]
		[FieldOffset(Offset = "0x10")]
		public bool isFirst;

		// Token: 0x04033676 RID: 210550
		[Token(Token = "0x4033676")]
		[FieldOffset(Offset = "0x18")]
		public AutoChessStageInfoBondViewModel bondModel;

		// Token: 0x04033677 RID: 210551
		[Token(Token = "0x4033677")]
		[FieldOffset(Offset = "0x20")]
		public List<AutoChessStageInfoChessViewModel> chessList;

		// Token: 0x04033678 RID: 210552
		[Token(Token = "0x4033678")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetViewType;

		// Token: 0x04033679 RID: 210553
		[Token(Token = "0x4033679")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403367A RID: 210554
		[Token(Token = "0x403367A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x0403367B RID: 210555
		[Token(Token = "0x403367B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
