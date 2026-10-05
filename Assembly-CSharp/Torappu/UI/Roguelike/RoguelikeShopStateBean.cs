using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005515 RID: 21781
	[Token(Token = "0x2005515")]
	public class RoguelikeShopStateBean : IStateBean, IHotfixable
	{
		// Token: 0x17004B21 RID: 19233
		// (get) Token: 0x06020094 RID: 131220 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06020095 RID: 131221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004B21")]
		public string topicId
		{
			[Token(Token = "0x6020094")]
			[Address(RVA = "0x1A276A0", Offset = "0x1A262A0", VA = "0x181A276A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6020095")]
			[Address(RVA = "0x1A27780", Offset = "0x1A26380", VA = "0x181A27780")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004B22 RID: 19234
		// (get) Token: 0x06020096 RID: 131222 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06020097 RID: 131223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004B22")]
		public string controllerPath
		{
			[Token(Token = "0x6020096")]
			[Address(RVA = "0x1A27640", Offset = "0x1A26240", VA = "0x181A27640")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6020097")]
			[Address(RVA = "0x1A27700", Offset = "0x1A26300", VA = "0x181A27700")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06020098 RID: 131224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020098")]
		[Address(RVA = "0x1A262F0", Offset = "0x1A24EF0", VA = "0x181A262F0")]
		public void Init(string topicId, RoguelikeShopPlugin shopPlugin)
		{
		}

		// Token: 0x06020099 RID: 131225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020099")]
		[Address(RVA = "0x1A26990", Offset = "0x1A25590", VA = "0x181A26990")]
		public void LoadShopData()
		{
		}

		// Token: 0x0602009A RID: 131226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602009A")]
		[Address(RVA = "0x1A26870", Offset = "0x1A25470", VA = "0x181A26870")]
		public void LoadBankData()
		{
		}

		// Token: 0x0602009B RID: 131227 RVA: 0x000B44F8 File Offset: 0x000B26F8
		[Token(Token = "0x602009B")]
		[Address(RVA = "0x1A26130", Offset = "0x1A24D30", VA = "0x181A26130")]
		public bool CheckCanWithdraw()
		{
			return default(bool);
		}

		// Token: 0x0602009C RID: 131228 RVA: 0x000B4510 File Offset: 0x000B2710
		[Token(Token = "0x602009C")]
		[Address(RVA = "0x1A261C0", Offset = "0x1A24DC0", VA = "0x181A261C0")]
		public bool CheckWithdrawReachLimit(int hasWithdrawnCount)
		{
			return default(bool);
		}

		// Token: 0x0602009D RID: 131229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602009D")]
		[Address(RVA = "0x1A26BE0", Offset = "0x1A257E0", VA = "0x181A26BE0")]
		public void WithdrawIncrementCurrent()
		{
		}

		// Token: 0x0602009E RID: 131230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602009E")]
		[Address(RVA = "0x1A26B50", Offset = "0x1A25750", VA = "0x181A26B50")]
		public void WithdrawDecrementCurrent()
		{
		}

		// Token: 0x0602009F RID: 131231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602009F")]
		[Address(RVA = "0x1A26C70", Offset = "0x1A25870", VA = "0x181A26C70")]
		public void WithdrawMaxCurrent()
		{
		}

		// Token: 0x060200A0 RID: 131232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60200A0")]
		[Address(RVA = "0x1A26D00", Offset = "0x1A25900", VA = "0x181A26D00")]
		public void WithdrawMinCurrent()
		{
		}

		// Token: 0x060200A1 RID: 131233 RVA: 0x000B4528 File Offset: 0x000B2728
		[Token(Token = "0x60200A1")]
		[Address(RVA = "0x1A26260", Offset = "0x1A24E60", VA = "0x181A26260")]
		public int GetWithdrawCount()
		{
			return 0;
		}

		// Token: 0x060200A2 RID: 131234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60200A2")]
		[Address(RVA = "0x1A27220", Offset = "0x1A25E20", VA = "0x181A27220")]
		private void _InjectShopPluginAndLoadData(RoguelikeGameShopViewModelPlugin shopViewModelPlugin)
		{
		}

		// Token: 0x060200A3 RID: 131235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60200A3")]
		[Address(RVA = "0x1A26F20", Offset = "0x1A25B20", VA = "0x181A26F20")]
		private void _InjectBankPluginAndLoadData(RoguelikeGameBankViewModel.BankWithdrawModelPlugin bankWithdrawModelPlugin)
		{
		}

		// Token: 0x060200A4 RID: 131236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60200A4")]
		[Address(RVA = "0x1A270D0", Offset = "0x1A25CD0", VA = "0x181A270D0")]
		private void _InjectDialogPluginAndLoadData(RoguelikeGameShopDialogViewModel.DialogViewModelPlugin dialogViewModelPlugin)
		{
		}

		// Token: 0x060200A5 RID: 131237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60200A5")]
		[Address(RVA = "0x1A26D90", Offset = "0x1A25990", VA = "0x181A26D90")]
		private PlayerRoguelikePendingEvent.ShopContent _GetGameShopPlayerData()
		{
			return null;
		}

		// Token: 0x060200A6 RID: 131238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60200A6")]
		[Address(RVA = "0x1A27460", Offset = "0x1A26060", VA = "0x181A27460")]
		public RoguelikeShopStateBean()
		{
		}

		// Token: 0x0402B417 RID: 177175
		[Token(Token = "0x402B417")]
		[FieldOffset(Offset = "0x10")]
		public RoguelikeGoodsViewModel selectedGoods;

		// Token: 0x0402B418 RID: 177176
		[Token(Token = "0x402B418")]
		[FieldOffset(Offset = "0x18")]
		public RoguelikeGameShopStatusProperty shopStatusProp;

		// Token: 0x0402B419 RID: 177177
		[Token(Token = "0x402B419")]
		[FieldOffset(Offset = "0x20")]
		public RoguelikeGameShopDialogProp shopDialogProp;

		// Token: 0x0402B41A RID: 177178
		[Token(Token = "0x402B41A")]
		[FieldOffset(Offset = "0x28")]
		public RoguelikeGameShopGoodsProperty shopGoodsProp;

		// Token: 0x0402B41B RID: 177179
		[Token(Token = "0x402B41B")]
		[FieldOffset(Offset = "0x30")]
		public RoguelikeGameBankProperty bankProp;

		// Token: 0x0402B41E RID: 177182
		[Token(Token = "0x402B41E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x0402B41F RID: 177183
		[Token(Token = "0x402B41F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_topicId;

		// Token: 0x0402B420 RID: 177184
		[Token(Token = "0x402B420")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_controllerPath;

		// Token: 0x0402B421 RID: 177185
		[Token(Token = "0x402B421")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_controllerPath;

		// Token: 0x0402B422 RID: 177186
		[Token(Token = "0x402B422")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402B423 RID: 177187
		[Token(Token = "0x402B423")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadShopData;

		// Token: 0x0402B424 RID: 177188
		[Token(Token = "0x402B424")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_LoadBankData;

		// Token: 0x0402B425 RID: 177189
		[Token(Token = "0x402B425")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CheckCanWithdraw;

		// Token: 0x0402B426 RID: 177190
		[Token(Token = "0x402B426")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CheckWithdrawReachLimit;

		// Token: 0x0402B427 RID: 177191
		[Token(Token = "0x402B427")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_WithdrawIncrementCurrent;

		// Token: 0x0402B428 RID: 177192
		[Token(Token = "0x402B428")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_WithdrawDecrementCurrent;

		// Token: 0x0402B429 RID: 177193
		[Token(Token = "0x402B429")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_WithdrawMaxCurrent;

		// Token: 0x0402B42A RID: 177194
		[Token(Token = "0x402B42A")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_WithdrawMinCurrent;

		// Token: 0x0402B42B RID: 177195
		[Token(Token = "0x402B42B")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetWithdrawCount;

		// Token: 0x0402B42C RID: 177196
		[Token(Token = "0x402B42C")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__InjectShopPluginAndLoadData;

		// Token: 0x0402B42D RID: 177197
		[Token(Token = "0x402B42D")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__InjectBankPluginAndLoadData;

		// Token: 0x0402B42E RID: 177198
		[Token(Token = "0x402B42E")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__InjectDialogPluginAndLoadData;

		// Token: 0x0402B42F RID: 177199
		[Token(Token = "0x402B42F")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__GetGameShopPlayerData;

		// Token: 0x0402B430 RID: 177200
		[Token(Token = "0x402B430")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
