using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005201 RID: 20993
	[Token(Token = "0x2005201")]
	public class RoguelikeExpedDialogPlugin : IHotfixable
	{
		// Token: 0x0601EFD3 RID: 126931 RVA: 0x000B0598 File Offset: 0x000AE798
		[Token(Token = "0x601EFD3")]
		[Address(RVA = "0x18B91F0", Offset = "0x18B7DF0", VA = "0x1818B91F0")]
		public static bool CheckOpenFlag()
		{
			return default(bool);
		}

		// Token: 0x0601EFD4 RID: 126932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EFD4")]
		[Address(RVA = "0x18B92B0", Offset = "0x18B7EB0", VA = "0x1818B92B0")]
		public static IEnumerator ShowDialog(string topicId)
		{
			return null;
		}

		// Token: 0x0601EFD5 RID: 126933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EFD5")]
		[Address(RVA = "0x18B9360", Offset = "0x18B7F60", VA = "0x1818B9360")]
		private static void _SendExpedDialogRequeset(Action onFinish)
		{
		}

		// Token: 0x0601EFD6 RID: 126934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EFD6")]
		[Address(RVA = "0x18B9610", Offset = "0x18B8210", VA = "0x1818B9610")]
		public RoguelikeExpedDialogPlugin()
		{
		}

		// Token: 0x0402995A RID: 170330
		[Token(Token = "0x402995A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckOpenFlag;

		// Token: 0x0402995B RID: 170331
		[Token(Token = "0x402995B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ShowDialog;

		// Token: 0x0402995C RID: 170332
		[Token(Token = "0x402995C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SendExpedDialogRequeset;

		// Token: 0x0402995D RID: 170333
		[Token(Token = "0x402995D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005202 RID: 20994
		[Token(Token = "0x2005202")]
		public class DialogMgr : RoguelikeDialogMgr
		{
			// Token: 0x0601EFD7 RID: 126935 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601EFD7")]
			[Address(RVA = "0x18AE590", Offset = "0x18AD190", VA = "0x1818AE590", Slot = "4")]
			public override IEnumerator OnShowDialog(UICompDialogMgr compDialogMgr, string topicId)
			{
				return null;
			}

			// Token: 0x0601EFD8 RID: 126936 RVA: 0x000B05B0 File Offset: 0x000AE7B0
			[Token(Token = "0x601EFD8")]
			[Address(RVA = "0x18AE120", Offset = "0x18ACD20", VA = "0x1818AE120", Slot = "5")]
			public override bool OnCheckNeedShowDialog(string topicId, List<SortableString> sortableList)
			{
				return default(bool);
			}

			// Token: 0x0601EFD9 RID: 126937 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601EFD9")]
			[Address(RVA = "0x18AEAD0", Offset = "0x18AD6D0", VA = "0x1818AEAD0")]
			public DialogMgr()
			{
			}

			// Token: 0x0402995E RID: 170334
			[Token(Token = "0x402995E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_OnShowDialog;

			// Token: 0x0402995F RID: 170335
			[Token(Token = "0x402995F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnCheckNeedShowDialog;

			// Token: 0x04029960 RID: 170336
			[Token(Token = "0x4029960")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
