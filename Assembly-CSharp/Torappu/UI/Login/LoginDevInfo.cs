using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Login
{
	// Token: 0x020049C8 RID: 18888
	[Token(Token = "0x20049C8")]
	public class LoginDevInfo : UICustomDialog<object>
	{
		// Token: 0x0601C724 RID: 116516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C724")]
		[Address(RVA = "0x15DE710", Offset = "0x15DD310", VA = "0x1815DE710", Slot = "7")]
		protected override void OnRender(object options)
		{
		}

		// Token: 0x0601C725 RID: 116517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C725")]
		[Address(RVA = "0x15DE6A0", Offset = "0x15DD2A0", VA = "0x1815DE6A0", Slot = "10")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0601C726 RID: 116518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C726")]
		[Address(RVA = "0x15DF1D0", Offset = "0x15DDDD0", VA = "0x1815DF1D0")]
		private void _UpdateCopyButton()
		{
		}

		// Token: 0x0601C727 RID: 116519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C727")]
		[Address(RVA = "0x15DED40", Offset = "0x15DD940", VA = "0x1815DED40")]
		public static void UpdateDevInfo(GameObject panel, Text text, GameObject dialog)
		{
		}

		// Token: 0x0601C728 RID: 116520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C728")]
		[Address(RVA = "0x15DEFD0", Offset = "0x15DDBD0", VA = "0x1815DEFD0")]
		private static string _GenerateDevInfo()
		{
			return null;
		}

		// Token: 0x0601C729 RID: 116521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C729")]
		[Address(RVA = "0x15DF3A0", Offset = "0x15DDFA0", VA = "0x1815DF3A0")]
		public LoginDevInfo()
		{
		}

		// Token: 0x04025471 RID: 152689
		[Token(Token = "0x4025471")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textDetail;

		// Token: 0x04025472 RID: 152690
		[Token(Token = "0x4025472")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button _btnCopy;

		// Token: 0x04025473 RID: 152691
		[Token(Token = "0x4025473")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04025474 RID: 152692
		[Token(Token = "0x4025474")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x04025475 RID: 152693
		[Token(Token = "0x4025475")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateCopyButton;

		// Token: 0x04025476 RID: 152694
		[Token(Token = "0x4025476")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateDevInfo;

		// Token: 0x04025477 RID: 152695
		[Token(Token = "0x4025477")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GenerateDevInfo;

		// Token: 0x04025478 RID: 152696
		[Token(Token = "0x4025478")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
