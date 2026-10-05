using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x020064DA RID: 25818
	[Token(Token = "0x20064DA")]
	public class AutoChessBattleUIBondViewModel : IHotfixable
	{
		// Token: 0x0602518F RID: 151951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602518F")]
		[Address(RVA = "0x1FE4CF0", Offset = "0x1FE38F0", VA = "0x181FE4CF0")]
		public void Init(AutoChessBattleUIViewModel viewModel)
		{
		}

		// Token: 0x06025190 RID: 151952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025190")]
		[Address(RVA = "0x1FE4F30", Offset = "0x1FE3B30", VA = "0x181FE4F30")]
		public void UpdateData(AutoChessBattleUIViewModel viewModel, int targetIdx)
		{
		}

		// Token: 0x06025191 RID: 151953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025191")]
		[Address(RVA = "0x1FE55F0", Offset = "0x1FE41F0", VA = "0x181FE55F0")]
		private void _InitBannedBond(AutoChessBattleUIViewModel viewModel)
		{
		}

		// Token: 0x06025192 RID: 151954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025192")]
		[Address(RVA = "0x1FE5370", Offset = "0x1FE3F70", VA = "0x181FE5370")]
		private AutoChessBondItemModel _EnsureAndInitBondItemModel(string bondId)
		{
			return null;
		}

		// Token: 0x06025193 RID: 151955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025193")]
		[Address(RVA = "0x1FE5760", Offset = "0x1FE4360", VA = "0x181FE5760")]
		public AutoChessBattleUIBondViewModel()
		{
		}

		// Token: 0x04033FA2 RID: 212898
		[Token(Token = "0x4033FA2")]
		[FieldOffset(Offset = "0x10")]
		public List<AutoChessBondItemModel> bondModels;

		// Token: 0x04033FA3 RID: 212899
		[Token(Token = "0x4033FA3")]
		[FieldOffset(Offset = "0x18")]
		public List<UISimpleRecycleLayoutItemViewModel> modelList;

		// Token: 0x04033FA4 RID: 212900
		[Token(Token = "0x4033FA4")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<string, AutoChessBondItemModel> m_bondModelDict;

		// Token: 0x04033FA5 RID: 212901
		[Token(Token = "0x4033FA5")]
		[FieldOffset(Offset = "0x28")]
		private List<string> m_bannedChessIds;

		// Token: 0x04033FA6 RID: 212902
		[Token(Token = "0x4033FA6")]
		[FieldOffset(Offset = "0x30")]
		private int m_cachedTgtIdx;

		// Token: 0x04033FA7 RID: 212903
		[Token(Token = "0x4033FA7")]
		[FieldOffset(Offset = "0x34")]
		public SeqNumSource playerIdxNum;

		// Token: 0x04033FA8 RID: 212904
		[Token(Token = "0x4033FA8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04033FA9 RID: 212905
		[Token(Token = "0x4033FA9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x04033FAA RID: 212906
		[Token(Token = "0x4033FAA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitBannedBond;

		// Token: 0x04033FAB RID: 212907
		[Token(Token = "0x4033FAB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__EnsureAndInitBondItemModel;

		// Token: 0x04033FAC RID: 212908
		[Token(Token = "0x4033FAC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
