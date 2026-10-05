using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200390B RID: 14603
	[Token(Token = "0x200390B")]
	public abstract class CommonDialog : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601715E RID: 94558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601715E")]
		[Address(RVA = "0xF6FE40", Offset = "0xF6EA40", VA = "0x180F6FE40")]
		public void DismissSelf()
		{
		}

		// Token: 0x17003721 RID: 14113
		// (get) Token: 0x0601715F RID: 94559 RVA: 0x00094D10 File Offset: 0x00092F10
		[Token(Token = "0x17003721")]
		public bool isShowing
		{
			[Token(Token = "0x601715F")]
			[Address(RVA = "0xF704B0", Offset = "0xF6F0B0", VA = "0x180F704B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06017160 RID: 94560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017160")]
		[Address(RVA = "0xF701C0", Offset = "0xF6EDC0", VA = "0x180F701C0", Slot = "4")]
		protected virtual void Start()
		{
		}

		// Token: 0x06017161 RID: 94561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017161")]
		[Address(RVA = "0xF70100", Offset = "0xF6ED00", VA = "0x180F70100", Slot = "5")]
		protected virtual void OnDismiss()
		{
		}

		// Token: 0x06017162 RID: 94562
		[Token(Token = "0x6017162")]
		protected abstract void OnDialogDeduplicated();

		// Token: 0x06017163 RID: 94563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017163")]
		[Address(RVA = "0xF70160", Offset = "0xF6ED60", VA = "0x180F70160", Slot = "7")]
		protected virtual void OnShow()
		{
		}

		// Token: 0x06017164 RID: 94564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017164")]
		[Address(RVA = "0xF70050", Offset = "0xF6EC50", VA = "0x180F70050")]
		public void DoShowPreparation(CommonDialog.ShowOptions options)
		{
		}

		// Token: 0x06017165 RID: 94565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017165")]
		[Address(RVA = "0xF6FEA0", Offset = "0xF6EAA0", VA = "0x180F6FEA0")]
		public void DismissSelf(Action callback)
		{
		}

		// Token: 0x06017166 RID: 94566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017166")]
		[Address(RVA = "0xF70320", Offset = "0xF6EF20", VA = "0x180F70320")]
		public void UIPopupWindow_MarkActive(bool markActive)
		{
		}

		// Token: 0x06017167 RID: 94567 RVA: 0x00094D28 File Offset: 0x00092F28
		[Token(Token = "0x6017167")]
		[Address(RVA = "0xF702C0", Offset = "0xF6EEC0", VA = "0x180F702C0")]
		public bool UIPopupWindow_IsMarkedActive()
		{
			return default(bool);
		}

		// Token: 0x06017168 RID: 94568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017168")]
		[Address(RVA = "0xF70220", Offset = "0xF6EE20", VA = "0x180F70220")]
		public void UIPopupWindow_DeduplicateInfo(out string key, out uint weight)
		{
		}

		// Token: 0x06017169 RID: 94569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017169")]
		[Address(RVA = "0xF70390", Offset = "0xF6EF90", VA = "0x180F70390")]
		public void UIPopupWindow_MarkDeduplicated()
		{
		}

		// Token: 0x17003722 RID: 14114
		// (get) Token: 0x0601716A RID: 94570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003722")]
		public virtual string message
		{
			[Token(Token = "0x601716A")]
			[Address(RVA = "0xF70510", Offset = "0xF6F110", VA = "0x180F70510", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601716B RID: 94571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601716B")]
		[Address(RVA = "0xF70410", Offset = "0xF6F010", VA = "0x180F70410")]
		protected CommonDialog()
		{
		}

		// Token: 0x0401BDBB RID: 114107
		[Token(Token = "0x401BDBB")]
		[FieldOffset(Offset = "0x18")]
		private CommonDialog.ShowOptions m_showOptions;

		// Token: 0x0401BDBC RID: 114108
		[Token(Token = "0x401BDBC")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isShowing;

		// Token: 0x0401BDBD RID: 114109
		[Token(Token = "0x401BDBD")]
		[FieldOffset(Offset = "0x29")]
		private bool m_markActive;

		// Token: 0x0401BDBE RID: 114110
		[Token(Token = "0x401BDBE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DismissSelf;

		// Token: 0x0401BDBF RID: 114111
		[Token(Token = "0x401BDBF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isShowing;

		// Token: 0x0401BDC0 RID: 114112
		[Token(Token = "0x401BDC0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0401BDC1 RID: 114113
		[Token(Token = "0x401BDC1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDismiss;

		// Token: 0x0401BDC2 RID: 114114
		[Token(Token = "0x401BDC2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnShow;

		// Token: 0x0401BDC3 RID: 114115
		[Token(Token = "0x401BDC3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_DoShowPreparation;

		// Token: 0x0401BDC4 RID: 114116
		[Token(Token = "0x401BDC4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix1_DismissSelf;

		// Token: 0x0401BDC5 RID: 114117
		[Token(Token = "0x401BDC5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_UIPopupWindow_MarkActive;

		// Token: 0x0401BDC6 RID: 114118
		[Token(Token = "0x401BDC6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_UIPopupWindow_IsMarkedActive;

		// Token: 0x0401BDC7 RID: 114119
		[Token(Token = "0x401BDC7")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_UIPopupWindow_DeduplicateInfo;

		// Token: 0x0401BDC8 RID: 114120
		[Token(Token = "0x401BDC8")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_UIPopupWindow_MarkDeduplicated;

		// Token: 0x0401BDC9 RID: 114121
		[Token(Token = "0x401BDC9")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_message;

		// Token: 0x0401BDCA RID: 114122
		[Token(Token = "0x401BDCA")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200390C RID: 14604
		[Token(Token = "0x200390C")]
		public struct ShowOptions
		{
			// Token: 0x0401BDCB RID: 114123
			[Token(Token = "0x401BDCB")]
			[FieldOffset(Offset = "0x0")]
			public static readonly CommonDialog.ShowOptions DEFAULT;

			// Token: 0x0401BDCC RID: 114124
			[Token(Token = "0x401BDCC")]
			[FieldOffset(Offset = "0x0")]
			public string deduplicateKey;

			// Token: 0x0401BDCD RID: 114125
			[Token(Token = "0x401BDCD")]
			[FieldOffset(Offset = "0x8")]
			public uint deduplicateWeight;
		}
	}
}
