using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SocialCardAlbum
{
	// Token: 0x02003EBD RID: 16061
	[Token(Token = "0x2003EBD")]
	public class SocialCardAlbumSideView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018EDE RID: 102110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018EDE")]
		[Address(RVA = "0x11A85D0", Offset = "0x11A71D0", VA = "0x1811A85D0")]
		public void Render(SocialCardAlbumViewModel model)
		{
		}

		// Token: 0x06018EDF RID: 102111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018EDF")]
		[Address(RVA = "0x11A8490", Offset = "0x11A7090", VA = "0x1811A8490")]
		public void OnSwitchClicked(bool forward)
		{
		}

		// Token: 0x06018EE0 RID: 102112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018EE0")]
		[Address(RVA = "0x11A8560", Offset = "0x11A7160", VA = "0x1811A8560")]
		public void OnToFirstClicked()
		{
		}

		// Token: 0x06018EE1 RID: 102113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018EE1")]
		[Address(RVA = "0x11A8830", Offset = "0x11A7430", VA = "0x1811A8830")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018EE2 RID: 102114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018EE2")]
		[Address(RVA = "0x11A8AE0", Offset = "0x11A76E0", VA = "0x1811A8AE0")]
		private void _OnPagerIndex(int currentPage)
		{
		}

		// Token: 0x06018EE3 RID: 102115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018EE3")]
		[Address(RVA = "0x11A90B0", Offset = "0x11A7CB0", VA = "0x1811A90B0")]
		private void _RenderSwitchButtons(int currentPage, bool immediate)
		{
		}

		// Token: 0x06018EE4 RID: 102116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018EE4")]
		[Address(RVA = "0x11A8B60", Offset = "0x11A7760", VA = "0x1811A8B60")]
		private void _OnPagerUpdating(float position)
		{
		}

		// Token: 0x06018EE5 RID: 102117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018EE5")]
		[Address(RVA = "0x11A8D10", Offset = "0x11A7910", VA = "0x1811A8D10")]
		private void _RenderContentGroup(float position)
		{
		}

		// Token: 0x06018EE6 RID: 102118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018EE6")]
		[Address(RVA = "0x11A8E60", Offset = "0x11A7A60", VA = "0x1811A8E60")]
		private void _RenderCurrentContent(float position)
		{
		}

		// Token: 0x06018EE7 RID: 102119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018EE7")]
		[Address(RVA = "0x11A9230", Offset = "0x11A7E30", VA = "0x1811A9230")]
		public SocialCardAlbumSideView()
		{
		}

		// Token: 0x0401EC31 RID: 126001
		[Token(Token = "0x401EC31")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _leftButtonGroup;

		// Token: 0x0401EC32 RID: 126002
		[Token(Token = "0x401EC32")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _rightButtonGroup;

		// Token: 0x0401EC33 RID: 126003
		[Token(Token = "0x401EC33")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _buttonFadeDuration;

		// Token: 0x0401EC34 RID: 126004
		[Token(Token = "0x401EC34")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _contentGroup;

		// Token: 0x0401EC35 RID: 126005
		[Token(Token = "0x401EC35")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Ease _easeType;

		// Token: 0x0401EC36 RID: 126006
		[Token(Token = "0x401EC36")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SocialCardAlbumSideSubBase[] _subSides;

		// Token: 0x0401EC37 RID: 126007
		[Token(Token = "0x401EC37")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _toFirstButton;

		// Token: 0x0401EC38 RID: 126008
		[Token(Token = "0x401EC38")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ScrollViewMoveToughPager _listPager;

		// Token: 0x0401EC39 RID: 126009
		[Token(Token = "0x401EC39")]
		[FieldOffset(Offset = "0x58")]
		private bool m_hasInited;

		// Token: 0x0401EC3A RID: 126010
		[Token(Token = "0x401EC3A")]
		[FieldOffset(Offset = "0x60")]
		private FadeSwitchTween m_leftButtonSwitchTween;

		// Token: 0x0401EC3B RID: 126011
		[Token(Token = "0x401EC3B")]
		[FieldOffset(Offset = "0x68")]
		private FadeSwitchTween m_rightButtonSwitchTween;

		// Token: 0x0401EC3C RID: 126012
		[Token(Token = "0x401EC3C")]
		[FieldOffset(Offset = "0x70")]
		private SocialCardAlbumViewModel m_cachedModel;

		// Token: 0x0401EC3D RID: 126013
		[Token(Token = "0x401EC3D")]
		[FieldOffset(Offset = "0x78")]
		private int m_showingIndex;

		// Token: 0x0401EC3E RID: 126014
		[Token(Token = "0x401EC3E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401EC3F RID: 126015
		[Token(Token = "0x401EC3F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnSwitchClicked;

		// Token: 0x0401EC40 RID: 126016
		[Token(Token = "0x401EC40")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnToFirstClicked;

		// Token: 0x0401EC41 RID: 126017
		[Token(Token = "0x401EC41")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401EC42 RID: 126018
		[Token(Token = "0x401EC42")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnPagerIndex;

		// Token: 0x0401EC43 RID: 126019
		[Token(Token = "0x401EC43")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderSwitchButtons;

		// Token: 0x0401EC44 RID: 126020
		[Token(Token = "0x401EC44")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnPagerUpdating;

		// Token: 0x0401EC45 RID: 126021
		[Token(Token = "0x401EC45")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RenderContentGroup;

		// Token: 0x0401EC46 RID: 126022
		[Token(Token = "0x401EC46")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RenderCurrentContent;

		// Token: 0x0401EC47 RID: 126023
		[Token(Token = "0x401EC47")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
