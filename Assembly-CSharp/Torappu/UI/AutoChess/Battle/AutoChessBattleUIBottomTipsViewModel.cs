using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.Battle.AutoChess;
using Torappu.Battle.DataCenter;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x02006490 RID: 25744
	[Token(Token = "0x2006490")]
	public class AutoChessBattleUIBottomTipsViewModel : IHotfixable
	{
		// Token: 0x17005766 RID: 22374
		// (get) Token: 0x06025067 RID: 151655 RVA: 0x000C6348 File Offset: 0x000C4548
		// (set) Token: 0x06025068 RID: 151656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005766")]
		public AutoChessBattleUIBottomTipsShowType showType
		{
			[Token(Token = "0x6025067")]
			[Address(RVA = "0x1FE65A0", Offset = "0x1FE51A0", VA = "0x181FE65A0")]
			[CompilerGenerated]
			get
			{
				return AutoChessBattleUIBottomTipsShowType.NONE;
			}
			[Token(Token = "0x6025068")]
			[Address(RVA = "0x1FE6670", Offset = "0x1FE5270", VA = "0x181FE6670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005767 RID: 22375
		// (get) Token: 0x06025069 RID: 151657 RVA: 0x000C6360 File Offset: 0x000C4560
		// (set) Token: 0x0602506A RID: 151658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005767")]
		public bool isShopOpen
		{
			[Token(Token = "0x6025069")]
			[Address(RVA = "0x1FE6540", Offset = "0x1FE5140", VA = "0x181FE6540")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602506A")]
			[Address(RVA = "0x1FE6600", Offset = "0x1FE5200", VA = "0x181FE6600")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0602506B RID: 151659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602506B")]
		[Address(RVA = "0x1FE62C0", Offset = "0x1FE4EC0", VA = "0x181FE62C0")]
		public void UpdateData(AutoChessBattleUIViewModel viewModel, AutoChessDataCenter dataCenter, AutoChessGameStatus gameStatus)
		{
		}

		// Token: 0x0602506C RID: 151660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602506C")]
		[Address(RVA = "0x1FE64E0", Offset = "0x1FE50E0", VA = "0x181FE64E0")]
		public AutoChessBattleUIBottomTipsViewModel()
		{
		}

		// Token: 0x04033D4C RID: 212300
		[Token(Token = "0x4033D4C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_showType;

		// Token: 0x04033D4D RID: 212301
		[Token(Token = "0x4033D4D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_showType;

		// Token: 0x04033D4E RID: 212302
		[Token(Token = "0x4033D4E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isShopOpen;

		// Token: 0x04033D4F RID: 212303
		[Token(Token = "0x4033D4F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_isShopOpen;

		// Token: 0x04033D50 RID: 212304
		[Token(Token = "0x4033D50")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x04033D51 RID: 212305
		[Token(Token = "0x4033D51")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
