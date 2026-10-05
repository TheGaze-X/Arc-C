using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020051FC RID: 20988
	[Token(Token = "0x20051FC")]
	public class RoguelikeChangeBossDialogPlugin : IHotfixable
	{
		// Token: 0x0601EFBC RID: 126908 RVA: 0x000B0520 File Offset: 0x000AE720
		[Token(Token = "0x601EFBC")]
		[Address(RVA = "0x18AFAB0", Offset = "0x18AE6B0", VA = "0x1818AFAB0")]
		public static bool CheckOpenFlag()
		{
			return default(bool);
		}

		// Token: 0x0601EFBD RID: 126909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EFBD")]
		[Address(RVA = "0x18AFB60", Offset = "0x18AE760", VA = "0x1818AFB60")]
		public static IEnumerator ShowDialog(string topicId)
		{
			return null;
		}

		// Token: 0x0601EFBE RID: 126910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EFBE")]
		[Address(RVA = "0x18AFC10", Offset = "0x18AE810", VA = "0x1818AFC10")]
		public RoguelikeChangeBossDialogPlugin()
		{
		}

		// Token: 0x0402994B RID: 170315
		[Token(Token = "0x402994B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckOpenFlag;

		// Token: 0x0402994C RID: 170316
		[Token(Token = "0x402994C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ShowDialog;

		// Token: 0x0402994D RID: 170317
		[Token(Token = "0x402994D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020051FD RID: 20989
		[Token(Token = "0x20051FD")]
		public class DialogMgr : RoguelikeDialogMgr
		{
			// Token: 0x0601EFBF RID: 126911 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601EFBF")]
			[Address(RVA = "0x18AE730", Offset = "0x18AD330", VA = "0x1818AE730", Slot = "4")]
			public override IEnumerator OnShowDialog(UICompDialogMgr compDialogMgr, string topicId)
			{
				return null;
			}

			// Token: 0x0601EFC0 RID: 126912 RVA: 0x000B0538 File Offset: 0x000AE738
			[Token(Token = "0x601EFC0")]
			[Address(RVA = "0x18AE370", Offset = "0x18ACF70", VA = "0x1818AE370", Slot = "5")]
			public override bool OnCheckNeedShowDialog(string topicId, List<SortableString> sortableList)
			{
				return default(bool);
			}

			// Token: 0x0601EFC1 RID: 126913 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601EFC1")]
			[Address(RVA = "0x18AEC10", Offset = "0x18AD810", VA = "0x1818AEC10")]
			public DialogMgr()
			{
			}

			// Token: 0x0402994E RID: 170318
			[Token(Token = "0x402994E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_OnShowDialog;

			// Token: 0x0402994F RID: 170319
			[Token(Token = "0x402994F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnCheckNeedShowDialog;

			// Token: 0x04029950 RID: 170320
			[Token(Token = "0x4029950")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
