using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x020064E5 RID: 25829
	[Token(Token = "0x20064E5")]
	public class AutoChessBattleUIPlayerInfoViewModel : IHotfixable
	{
		// Token: 0x060251BD RID: 151997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60251BD")]
		[Address(RVA = "0x20209D0", Offset = "0x201F5D0", VA = "0x1820209D0")]
		public void Init(AutoChessBattleUIViewModel viewModel)
		{
		}

		// Token: 0x060251BE RID: 151998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60251BE")]
		[Address(RVA = "0x2020C70", Offset = "0x201F870", VA = "0x182020C70")]
		public void UpdateData(AutoChessBattleUIViewModel viewModel, int targetViewIdx)
		{
		}

		// Token: 0x060251BF RID: 151999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60251BF")]
		[Address(RVA = "0x2020D30", Offset = "0x201F930", VA = "0x182020D30")]
		public AutoChessBattleUIPlayerInfoViewModel()
		{
		}

		// Token: 0x04034021 RID: 213025
		[Token(Token = "0x4034021")]
		[FieldOffset(Offset = "0x10")]
		public AutoChessHUDBandInfoModel bandInfo;

		// Token: 0x04034022 RID: 213026
		[Token(Token = "0x4034022")]
		[FieldOffset(Offset = "0x18")]
		public AutoChessHUDStageInfoModel stageInfo;

		// Token: 0x04034023 RID: 213027
		[Token(Token = "0x4034023")]
		[FieldOffset(Offset = "0x20")]
		public List<AutoChessBannedBondItemModel> bannedBondModelList;

		// Token: 0x04034024 RID: 213028
		[Token(Token = "0x4034024")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04034025 RID: 213029
		[Token(Token = "0x4034025")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x04034026 RID: 213030
		[Token(Token = "0x4034026")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
