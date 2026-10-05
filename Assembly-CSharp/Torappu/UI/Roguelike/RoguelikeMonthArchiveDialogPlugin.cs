using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200520D RID: 21005
	[Token(Token = "0x200520D")]
	public class RoguelikeMonthArchiveDialogPlugin : IHotfixable
	{
		// Token: 0x0601F005 RID: 126981 RVA: 0x000B0688 File Offset: 0x000AE888
		[Token(Token = "0x601F005")]
		[Address(RVA = "0x18BDDD0", Offset = "0x18BC9D0", VA = "0x1818BDDD0")]
		public static bool CheckOpenFlag(string topicId)
		{
			return default(bool);
		}

		// Token: 0x0601F006 RID: 126982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F006")]
		[Address(RVA = "0x18BDEE0", Offset = "0x18BCAE0", VA = "0x1818BDEE0")]
		public static IEnumerator ShowDialog(string topicId)
		{
			return null;
		}

		// Token: 0x0601F007 RID: 126983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F007")]
		[Address(RVA = "0x18BDF90", Offset = "0x18BCB90", VA = "0x1818BDF90")]
		public RoguelikeMonthArchiveDialogPlugin()
		{
		}

		// Token: 0x0402997A RID: 170362
		[Token(Token = "0x402997A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckOpenFlag;

		// Token: 0x0402997B RID: 170363
		[Token(Token = "0x402997B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ShowDialog;

		// Token: 0x0402997C RID: 170364
		[Token(Token = "0x402997C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200520E RID: 21006
		[Token(Token = "0x200520E")]
		public class DialogMgr : RoguelikeDialogMgr
		{
			// Token: 0x0601F008 RID: 126984 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601F008")]
			[Address(RVA = "0x18AE800", Offset = "0x18AD400", VA = "0x1818AE800", Slot = "4")]
			public override IEnumerator OnShowDialog(UICompDialogMgr compDialogMgr, string topicId)
			{
				return null;
			}

			// Token: 0x0601F009 RID: 126985 RVA: 0x000B06A0 File Offset: 0x000AE8A0
			[Token(Token = "0x601F009")]
			[Address(RVA = "0x18ADC60", Offset = "0x18AC860", VA = "0x1818ADC60", Slot = "5")]
			public override bool OnCheckNeedShowDialog(string topicId, List<SortableString> sortableList)
			{
				return default(bool);
			}

			// Token: 0x0601F00A RID: 126986 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F00A")]
			[Address(RVA = "0x18AEB70", Offset = "0x18AD770", VA = "0x1818AEB70")]
			public DialogMgr()
			{
			}

			// Token: 0x0402997D RID: 170365
			[Token(Token = "0x402997D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_OnShowDialog;

			// Token: 0x0402997E RID: 170366
			[Token(Token = "0x402997E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnCheckNeedShowDialog;

			// Token: 0x0402997F RID: 170367
			[Token(Token = "0x402997F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
