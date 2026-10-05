using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005207 RID: 20999
	[Token(Token = "0x2005207")]
	public class RoguelikeFinishMissionDialogPlugin : IHotfixable
	{
		// Token: 0x0601EFEC RID: 126956 RVA: 0x000B0610 File Offset: 0x000AE810
		[Token(Token = "0x601EFEC")]
		[Address(RVA = "0x18B9B60", Offset = "0x18B8760", VA = "0x1818B9B60")]
		public static bool CheckOpenFlag()
		{
			return default(bool);
		}

		// Token: 0x0601EFED RID: 126957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EFED")]
		[Address(RVA = "0x18B9C40", Offset = "0x18B8840", VA = "0x1818B9C40")]
		public static IEnumerator ShowDialog(string topicId)
		{
			return null;
		}

		// Token: 0x0601EFEE RID: 126958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EFEE")]
		[Address(RVA = "0x18B9CF0", Offset = "0x18B88F0", VA = "0x1818B9CF0")]
		private static void _SendFinishMissionRequeset(Action onFinish)
		{
		}

		// Token: 0x0601EFEF RID: 126959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EFEF")]
		[Address(RVA = "0x18B9FC0", Offset = "0x18B8BC0", VA = "0x1818B9FC0")]
		public RoguelikeFinishMissionDialogPlugin()
		{
		}

		// Token: 0x0402996A RID: 170346
		[Token(Token = "0x402996A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckOpenFlag;

		// Token: 0x0402996B RID: 170347
		[Token(Token = "0x402996B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ShowDialog;

		// Token: 0x0402996C RID: 170348
		[Token(Token = "0x402996C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SendFinishMissionRequeset;

		// Token: 0x0402996D RID: 170349
		[Token(Token = "0x402996D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005208 RID: 21000
		[Token(Token = "0x2005208")]
		public class DialogMgr : RoguelikeDialogMgr
		{
			// Token: 0x0601EFF0 RID: 126960 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601EFF0")]
			[Address(RVA = "0x18AE660", Offset = "0x18AD260", VA = "0x1818AE660", Slot = "4")]
			public override IEnumerator OnShowDialog(UICompDialogMgr compDialogMgr, string topicId)
			{
				return null;
			}

			// Token: 0x0601EFF1 RID: 126961 RVA: 0x000B0628 File Offset: 0x000AE828
			[Token(Token = "0x601EFF1")]
			[Address(RVA = "0x18ADEE0", Offset = "0x18ACAE0", VA = "0x1818ADEE0", Slot = "5")]
			public override bool OnCheckNeedShowDialog(string topicId, List<SortableString> sortableList)
			{
				return default(bool);
			}

			// Token: 0x0601EFF2 RID: 126962 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601EFF2")]
			[Address(RVA = "0x18AECB0", Offset = "0x18AD8B0", VA = "0x1818AECB0")]
			public DialogMgr()
			{
			}

			// Token: 0x0402996E RID: 170350
			[Token(Token = "0x402996E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_OnShowDialog;

			// Token: 0x0402996F RID: 170351
			[Token(Token = "0x402996F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnCheckNeedShowDialog;

			// Token: 0x04029970 RID: 170352
			[Token(Token = "0x4029970")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
