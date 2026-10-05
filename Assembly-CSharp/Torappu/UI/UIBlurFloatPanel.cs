using System;
using System.Collections;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020039D4 RID: 14804
	[Token(Token = "0x20039D4")]
	[RequireComponent(typeof(RectTransform))]
	public class UIBlurFloatPanel : UIReentrantFloatPanel
	{
		// Token: 0x06017622 RID: 95778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017622")]
		[Address(RVA = "0xFBC440", Offset = "0xFBB040", VA = "0x180FBC440", Slot = "4")]
		protected override IEnumerator ShowEffect()
		{
			return null;
		}

		// Token: 0x06017623 RID: 95779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017623")]
		[Address(RVA = "0xFBC390", Offset = "0xFBAF90", VA = "0x180FBC390", Slot = "5")]
		protected override IEnumerator HideEffect()
		{
			return null;
		}

		// Token: 0x06017624 RID: 95780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017624")]
		[Address(RVA = "0xFBC910", Offset = "0xFBB510", VA = "0x180FBC910")]
		private void _ResetSharedTween()
		{
		}

		// Token: 0x06017625 RID: 95781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017625")]
		[Address(RVA = "0xFBC4F0", Offset = "0xFBB0F0", VA = "0x180FBC4F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06017626 RID: 95782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017626")]
		[Address(RVA = "0xFBC9E0", Offset = "0xFBB5E0", VA = "0x180FBC9E0")]
		private void _ShotBlurBackground()
		{
		}

		// Token: 0x06017627 RID: 95783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017627")]
		[Address(RVA = "0xFBCA90", Offset = "0xFBB690", VA = "0x180FBCA90")]
		public UIBlurFloatPanel()
		{
		}

		// Token: 0x06017628 RID: 95784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017628")]
		[Address(RVA = "0xFBC280", Offset = "0xFBAE80", VA = "0x180FBC280")]
		private IEnumerator <>xLuaBaseProxy_ShowEffect()
		{
			return null;
		}

		// Token: 0x06017629 RID: 95785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017629")]
		[Address(RVA = "0xFBC270", Offset = "0xFBAE70", VA = "0x180FBC270")]
		private IEnumerator <>xLuaBaseProxy_HideEffect()
		{
			return null;
		}

		// Token: 0x0401C3DC RID: 115676
		[Token(Token = "0x401C3DC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Color _color;

		// Token: 0x0401C3DD RID: 115677
		[Token(Token = "0x401C3DD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _raycastTarget;

		// Token: 0x0401C3DE RID: 115678
		[Token(Token = "0x401C3DE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Tooltip("Blur bkg's anchors would be reset. To avoid reseting panel self's anchor, use a specified bkg")]
		private UIRenderTextureImage _blurBkg;

		// Token: 0x0401C3DF RID: 115679
		[Token(Token = "0x401C3DF")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isInited;

		// Token: 0x0401C3E0 RID: 115680
		[Token(Token = "0x401C3E0")]
		[FieldOffset(Offset = "0x48")]
		private UIRenderTextureImage m_bkgImage;

		// Token: 0x0401C3E1 RID: 115681
		[Token(Token = "0x401C3E1")]
		[FieldOffset(Offset = "0x50")]
		private CanvasGroup m_alphaHandler;

		// Token: 0x0401C3E2 RID: 115682
		[Token(Token = "0x401C3E2")]
		[FieldOffset(Offset = "0x58")]
		private Tween m_sharedTween;

		// Token: 0x0401C3E3 RID: 115683
		[Token(Token = "0x401C3E3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ShowEffect;

		// Token: 0x0401C3E4 RID: 115684
		[Token(Token = "0x401C3E4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HideEffect;

		// Token: 0x0401C3E5 RID: 115685
		[Token(Token = "0x401C3E5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ResetSharedTween;

		// Token: 0x0401C3E6 RID: 115686
		[Token(Token = "0x401C3E6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401C3E7 RID: 115687
		[Token(Token = "0x401C3E7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ShotBlurBackground;

		// Token: 0x0401C3E8 RID: 115688
		[Token(Token = "0x401C3E8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
