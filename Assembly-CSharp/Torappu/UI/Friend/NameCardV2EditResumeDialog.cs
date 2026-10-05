using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004DE6 RID: 19942
	[Token(Token = "0x2004DE6")]
	public class NameCardV2EditResumeDialog : UICustomDialog<Action<bool>>
	{
		// Token: 0x0601DCFD RID: 122109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DCFD")]
		[Address(RVA = "0x175AC60", Offset = "0x1759860", VA = "0x18175AC60", Slot = "7")]
		protected override void OnRender(Action<bool> callback)
		{
		}

		// Token: 0x0601DCFE RID: 122110 RVA: 0x000AC6C8 File Offset: 0x000AA8C8
		[Token(Token = "0x601DCFE")]
		[Address(RVA = "0x175ABA0", Offset = "0x17597A0", VA = "0x18175ABA0", Slot = "13")]
		protected override float DefaultShowTweenDuration()
		{
			return 0f;
		}

		// Token: 0x0601DCFF RID: 122111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DCFF")]
		[Address(RVA = "0x175AC00", Offset = "0x1759800", VA = "0x18175AC00", Slot = "10")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0601DD00 RID: 122112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD00")]
		[Address(RVA = "0x175B220", Offset = "0x1759E20", VA = "0x18175B220")]
		private void _OnConfirmClicked()
		{
		}

		// Token: 0x0601DD01 RID: 122113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD01")]
		[Address(RVA = "0x175B150", Offset = "0x1759D50", VA = "0x18175B150")]
		private void _OnCancelClicked()
		{
		}

		// Token: 0x0601DD02 RID: 122114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD02")]
		[Address(RVA = "0x175B560", Offset = "0x175A160", VA = "0x18175B560")]
		public NameCardV2EditResumeDialog()
		{
		}

		// Token: 0x040277A9 RID: 161705
		[Token(Token = "0x40277A9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIRenderTextureImage _blurImg;

		// Token: 0x040277AA RID: 161706
		[Token(Token = "0x40277AA")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private InputField _input;

		// Token: 0x040277AB RID: 161707
		[Token(Token = "0x40277AB")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Button _btnConfirm;

		// Token: 0x040277AC RID: 161708
		[Token(Token = "0x40277AC")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Button _btnCancel;

		// Token: 0x040277AD RID: 161709
		[Token(Token = "0x40277AD")]
		[FieldOffset(Offset = "0x60")]
		private Action<bool> m_callback;

		// Token: 0x040277AE RID: 161710
		[Token(Token = "0x40277AE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x040277AF RID: 161711
		[Token(Token = "0x40277AF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DefaultShowTweenDuration;

		// Token: 0x040277B0 RID: 161712
		[Token(Token = "0x40277B0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x040277B1 RID: 161713
		[Token(Token = "0x40277B1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnConfirmClicked;

		// Token: 0x040277B2 RID: 161714
		[Token(Token = "0x40277B2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnCancelClicked;

		// Token: 0x040277B3 RID: 161715
		[Token(Token = "0x40277B3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
