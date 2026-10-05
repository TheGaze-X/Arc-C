using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005512 RID: 21778
	[Token(Token = "0x2005512")]
	public abstract class RoguelikeShopPlugin : MonoBehaviour, IHotfixable
	{
		// Token: 0x06020070 RID: 131184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020070")]
		[Address(RVA = "0x1A25FE0", Offset = "0x1A24BE0", VA = "0x181A25FE0", Slot = "4")]
		public virtual string GetShopControllerPath(string topicId, PlayerRoguelikeV2.CurrentData current)
		{
			return null;
		}

		// Token: 0x06020071 RID: 131185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020071")]
		[Address(RVA = "0x1A26070", Offset = "0x1A24C70", VA = "0x181A26070", Slot = "5")]
		public virtual RoguelikeGameShopViewModelPlugin GetShopViewModelPlugin()
		{
			return null;
		}

		// Token: 0x06020072 RID: 131186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020072")]
		[Address(RVA = "0x1A25C80", Offset = "0x1A24880", VA = "0x181A25C80", Slot = "6")]
		public virtual RoguelikeGameBankViewModel.BankWithdrawModelPlugin GetBankViewModelPlugin()
		{
			return null;
		}

		// Token: 0x06020073 RID: 131187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020073")]
		[Address(RVA = "0x1A25EC0", Offset = "0x1A24AC0", VA = "0x181A25EC0", Slot = "7")]
		public virtual RoguelikeGameShopDialogViewModel.DialogViewModelPlugin GetDialogViewModelPlugin()
		{
			return null;
		}

		// Token: 0x06020074 RID: 131188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020074")]
		[Address(RVA = "0x1A25F20", Offset = "0x1A24B20", VA = "0x181A25F20", Slot = "8")]
		public virtual List<RoguelikeGoodsObjPlugin> GetGoodObjPlugins()
		{
			return null;
		}

		// Token: 0x06020075 RID: 131189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020075")]
		[Address(RVA = "0x1A25E60", Offset = "0x1A24A60", VA = "0x181A25E60", Slot = "9")]
		public virtual RoguelikeGoodsObjPlugin GetDetailGoodIconPlugin()
		{
			return null;
		}

		// Token: 0x06020076 RID: 131190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020076")]
		[Address(RVA = "0x1A25E00", Offset = "0x1A24A00", VA = "0x181A25E00", Slot = "10")]
		public virtual RoguelikeShopDetailExtraInfoPlugin GetDetailExtraInfoViewPlugin()
		{
			return null;
		}

		// Token: 0x06020077 RID: 131191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020077")]
		[Address(RVA = "0x1A25DA0", Offset = "0x1A249A0", VA = "0x181A25DA0", Slot = "11")]
		public virtual RoguelikeShopDetailConfirmPlugin GetDetailConfirmPlugin()
		{
			return null;
		}

		// Token: 0x06020078 RID: 131192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020078")]
		[Address(RVA = "0x1A25F80", Offset = "0x1A24B80", VA = "0x181A25F80", Slot = "12")]
		public virtual List<RoguelikeShopLineupAddonPlugin> GetLineupAddonPlugins()
		{
			return null;
		}

		// Token: 0x06020079 RID: 131193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020079")]
		[Address(RVA = "0x1A25CE0", Offset = "0x1A248E0", VA = "0x181A25CE0", Slot = "13")]
		public virtual RoguelikeGameBankWithdrawCommonView GetBankWithDrawlViewPrefab()
		{
			return null;
		}

		// Token: 0x0602007A RID: 131194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602007A")]
		[Address(RVA = "0x1A25D40", Offset = "0x1A24940", VA = "0x181A25D40", Slot = "14")]
		public virtual RoguelikeGameShopBattleConfirmView GetBattleConfirmViewPrefab()
		{
			return null;
		}

		// Token: 0x0602007B RID: 131195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602007B")]
		[Address(RVA = "0x1A260D0", Offset = "0x1A24CD0", VA = "0x181A260D0")]
		protected RoguelikeShopPlugin()
		{
		}

		// Token: 0x0402B3F2 RID: 177138
		[Token(Token = "0x402B3F2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetShopControllerPath;

		// Token: 0x0402B3F3 RID: 177139
		[Token(Token = "0x402B3F3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetShopViewModelPlugin;

		// Token: 0x0402B3F4 RID: 177140
		[Token(Token = "0x402B3F4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetBankViewModelPlugin;

		// Token: 0x0402B3F5 RID: 177141
		[Token(Token = "0x402B3F5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetDialogViewModelPlugin;

		// Token: 0x0402B3F6 RID: 177142
		[Token(Token = "0x402B3F6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetGoodObjPlugins;

		// Token: 0x0402B3F7 RID: 177143
		[Token(Token = "0x402B3F7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetDetailGoodIconPlugin;

		// Token: 0x0402B3F8 RID: 177144
		[Token(Token = "0x402B3F8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetDetailExtraInfoViewPlugin;

		// Token: 0x0402B3F9 RID: 177145
		[Token(Token = "0x402B3F9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetDetailConfirmPlugin;

		// Token: 0x0402B3FA RID: 177146
		[Token(Token = "0x402B3FA")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetLineupAddonPlugins;

		// Token: 0x0402B3FB RID: 177147
		[Token(Token = "0x402B3FB")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetBankWithDrawlViewPrefab;

		// Token: 0x0402B3FC RID: 177148
		[Token(Token = "0x402B3FC")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetBattleConfirmViewPrefab;

		// Token: 0x0402B3FD RID: 177149
		[Token(Token = "0x402B3FD")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
