using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x020062FD RID: 25341
	[Token(Token = "0x20062FD")]
	public class AutoChessSettleGamePersonalCharItemViewModel : IComparable<AutoChessSettleGamePersonalCharItemViewModel>, IHotfixable
	{
		// Token: 0x170055F5 RID: 22005
		// (get) Token: 0x0602486D RID: 149613 RVA: 0x000C4770 File Offset: 0x000C2970
		[Token(Token = "0x170055F5")]
		public bool allowSpSkin
		{
			[Token(Token = "0x602486D")]
			[Address(RVA = "0x1F56010", Offset = "0x1F54C10", VA = "0x181F56010")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602486E RID: 149614 RVA: 0x000C4788 File Offset: 0x000C2988
		[Token(Token = "0x602486E")]
		[Address(RVA = "0x1F55EB0", Offset = "0x1F54AB0", VA = "0x181F55EB0", Slot = "4")]
		public int CompareTo(AutoChessSettleGamePersonalCharItemViewModel other)
		{
			return 0;
		}

		// Token: 0x0602486F RID: 149615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602486F")]
		[Address(RVA = "0x1F55FB0", Offset = "0x1F54BB0", VA = "0x181F55FB0")]
		public AutoChessSettleGamePersonalCharItemViewModel()
		{
		}

		// Token: 0x04032EF9 RID: 208633
		[Token(Token = "0x4032EF9")]
		[FieldOffset(Offset = "0x10")]
		public int chessLevel;

		// Token: 0x04032EFA RID: 208634
		[Token(Token = "0x4032EFA")]
		[FieldOffset(Offset = "0x14")]
		public EvolvePhase evolvePhase;

		// Token: 0x04032EFB RID: 208635
		[Token(Token = "0x4032EFB")]
		[FieldOffset(Offset = "0x18")]
		public string evolveIconId;

		// Token: 0x04032EFC RID: 208636
		[Token(Token = "0x4032EFC")]
		[FieldOffset(Offset = "0x20")]
		public int charLevel;

		// Token: 0x04032EFD RID: 208637
		[Token(Token = "0x4032EFD")]
		[FieldOffset(Offset = "0x24")]
		public bool isGolden;

		// Token: 0x04032EFE RID: 208638
		[Token(Token = "0x4032EFE")]
		[FieldOffset(Offset = "0x28")]
		public string charId;

		// Token: 0x04032EFF RID: 208639
		[Token(Token = "0x4032EFF")]
		[FieldOffset(Offset = "0x30")]
		public string tmplId;

		// Token: 0x04032F00 RID: 208640
		[Token(Token = "0x4032F00")]
		[FieldOffset(Offset = "0x38")]
		public string skinId;

		// Token: 0x04032F01 RID: 208641
		[Token(Token = "0x4032F01")]
		[FieldOffset(Offset = "0x40")]
		public bool isAssist;

		// Token: 0x04032F02 RID: 208642
		[Token(Token = "0x4032F02")]
		[FieldOffset(Offset = "0x41")]
		public bool isBackup;

		// Token: 0x04032F03 RID: 208643
		[Token(Token = "0x4032F03")]
		[FieldOffset(Offset = "0x42")]
		public bool isPreset;

		// Token: 0x04032F04 RID: 208644
		[Token(Token = "0x4032F04")]
		[FieldOffset(Offset = "0x44")]
		public int sortId;

		// Token: 0x04032F05 RID: 208645
		[Token(Token = "0x4032F05")]
		[FieldOffset(Offset = "0x48")]
		public List<AutoChessSettleGamePersonalEquipItemViewModel> equipItems;

		// Token: 0x04032F06 RID: 208646
		[Token(Token = "0x4032F06")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_allowSpSkin;

		// Token: 0x04032F07 RID: 208647
		[Token(Token = "0x4032F07")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x04032F08 RID: 208648
		[Token(Token = "0x4032F08")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
