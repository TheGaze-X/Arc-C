using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x020055A6 RID: 21926
	[Token(Token = "0x20055A6")]
	public class RL05CopperPackageDialog : UICompDialog<RL05CopperPackageDialog.Options>, ICompDialogCallBack
	{
		// Token: 0x06020329 RID: 131881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020329")]
		[Address(RVA = "0x1A4B720", Offset = "0x1A4A320", VA = "0x181A4B720", Slot = "18")]
		protected override void OnRender(RL05CopperPackageDialog.Options input)
		{
		}

		// Token: 0x0602032A RID: 131882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602032A")]
		[Address(RVA = "0x1A4B460", Offset = "0x1A4A060", VA = "0x181A4B460", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x0602032B RID: 131883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602032B")]
		[Address(RVA = "0x1A4B3E0", Offset = "0x1A49FE0", VA = "0x181A4B3E0", Slot = "10")]
		protected override void OnFinishShowTransition()
		{
		}

		// Token: 0x0602032C RID: 131884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602032C")]
		[Address(RVA = "0x1A4BAD0", Offset = "0x1A4A6D0", VA = "0x181A4BAD0")]
		private void _EventClickCopper(string instId)
		{
		}

		// Token: 0x0602032D RID: 131885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602032D")]
		[Address(RVA = "0x1A4BC30", Offset = "0x1A4A830", VA = "0x181A4BC30")]
		private void _EventRefreshCopper()
		{
		}

		// Token: 0x0602032E RID: 131886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602032E")]
		[Address(RVA = "0x1A4BF40", Offset = "0x1A4AB40", VA = "0x181A4BF40")]
		private void _OpenCopperFreezeDialog()
		{
		}

		// Token: 0x0602032F RID: 131887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602032F")]
		[Address(RVA = "0x1A4C170", Offset = "0x1A4AD70", VA = "0x181A4C170")]
		private void _SendRedrawCopperRequest()
		{
		}

		// Token: 0x06020330 RID: 131888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020330")]
		[Address(RVA = "0x1A4B320", Offset = "0x1A49F20", VA = "0x181A4B320")]
		public void OnClickBackBtn()
		{
		}

		// Token: 0x06020331 RID: 131889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020331")]
		[Address(RVA = "0x1A4B1A0", Offset = "0x1A49DA0", VA = "0x181A4B1A0", Slot = "19")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x06020332 RID: 131890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020332")]
		[Address(RVA = "0x1A4C380", Offset = "0x1A4AF80", VA = "0x181A4C380")]
		public RL05CopperPackageDialog()
		{
		}

		// Token: 0x06020334 RID: 131892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020334")]
		[Address(RVA = "0xE613C0", Offset = "0xE5FFC0", VA = "0x180E613C0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x06020335 RID: 131893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020335")]
		[Address(RVA = "0x1A4B800", Offset = "0x1A4A400", VA = "0x181A4B800")]
		private void <>xLuaBaseProxy_OnFinishShowTransition()
		{
		}

		// Token: 0x0402B892 RID: 178322
		[Token(Token = "0x402B892")]
		private const string GUIDE_BOOK_SUB_SIGNAL = "rogue_5_copper";

		// Token: 0x0402B893 RID: 178323
		[Token(Token = "0x402B893")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RL05CopperPackageMainView _mainView;

		// Token: 0x0402B894 RID: 178324
		[Token(Token = "0x402B894")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RL05CopperPackageDetailView _detailView;

		// Token: 0x0402B895 RID: 178325
		[Token(Token = "0x402B895")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIGuidebookTrigger _guidebookTrigger;

		// Token: 0x0402B896 RID: 178326
		[Token(Token = "0x402B896")]
		[FieldOffset(Offset = "0x88")]
		private RL05CopperPackageProperty m_prop;

		// Token: 0x0402B897 RID: 178327
		[Token(Token = "0x402B897")]
		[FieldOffset(Offset = "0x90")]
		private RL05CopperPackageDialog.Options m_cachedInput;

		// Token: 0x0402B898 RID: 178328
		[Token(Token = "0x402B898")]
		[FieldOffset(Offset = "0x98")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402B899 RID: 178329
		[Token(Token = "0x402B899")]
		[FieldOffset(Offset = "0xA8")]
		private int m_redrawCopperDialog;

		// Token: 0x0402B89A RID: 178330
		[Token(Token = "0x402B89A")]
		[FieldOffset(Offset = "0xAC")]
		private int m_freezeCopperDialog;

		// Token: 0x0402B89B RID: 178331
		[Token(Token = "0x402B89B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0402B89C RID: 178332
		[Token(Token = "0x402B89C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0402B89D RID: 178333
		[Token(Token = "0x402B89D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnFinishShowTransition;

		// Token: 0x0402B89E RID: 178334
		[Token(Token = "0x402B89E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__EventClickCopper;

		// Token: 0x0402B89F RID: 178335
		[Token(Token = "0x402B89F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__EventRefreshCopper;

		// Token: 0x0402B8A0 RID: 178336
		[Token(Token = "0x402B8A0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OpenCopperFreezeDialog;

		// Token: 0x0402B8A1 RID: 178337
		[Token(Token = "0x402B8A1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SendRedrawCopperRequest;

		// Token: 0x0402B8A2 RID: 178338
		[Token(Token = "0x402B8A2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnClickBackBtn;

		// Token: 0x0402B8A3 RID: 178339
		[Token(Token = "0x402B8A3")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x0402B8A4 RID: 178340
		[Token(Token = "0x402B8A4")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020055A7 RID: 21927
		[Token(Token = "0x20055A7")]
		public class Options
		{
			// Token: 0x06020336 RID: 131894 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020336")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Options()
			{
			}

			// Token: 0x0402B8A5 RID: 178341
			[Token(Token = "0x402B8A5")]
			[FieldOffset(Offset = "0x10")]
			public string topicId;

			// Token: 0x0402B8A6 RID: 178342
			[Token(Token = "0x402B8A6")]
			[FieldOffset(Offset = "0x18")]
			public RL05CopperPackageType verType;
		}
	}
}
