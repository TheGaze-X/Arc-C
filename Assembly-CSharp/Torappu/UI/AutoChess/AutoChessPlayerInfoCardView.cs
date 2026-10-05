using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x020062B8 RID: 25272
	[Token(Token = "0x20062B8")]
	public class AutoChessPlayerInfoCardView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060246AB RID: 149163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60246AB")]
		[Address(RVA = "0x1F49470", Offset = "0x1F48070", VA = "0x181F49470")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060246AC RID: 149164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60246AC")]
		[Address(RVA = "0x1F490A0", Offset = "0x1F47CA0", VA = "0x181F490A0")]
		public void Render(AutoChessPlayerInfo info)
		{
		}

		// Token: 0x060246AD RID: 149165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60246AD")]
		[Address(RVA = "0x1F49540", Offset = "0x1F48140", VA = "0x181F49540")]
		public AutoChessPlayerInfoCardView()
		{
		}

		// Token: 0x04032AE1 RID: 207585
		[Token(Token = "0x4032AE1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _avatarContainer;

		// Token: 0x04032AE2 RID: 207586
		[Token(Token = "0x4032AE2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _shortNameCardImg;

		// Token: 0x04032AE3 RID: 207587
		[Token(Token = "0x4032AE3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _nameText;

		// Token: 0x04032AE4 RID: 207588
		[Token(Token = "0x4032AE4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _noteNameText;

		// Token: 0x04032AE5 RID: 207589
		[Token(Token = "0x4032AE5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TwoStateToggle _noteNameToggle;

		// Token: 0x04032AE6 RID: 207590
		[Token(Token = "0x4032AE6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _medalIconImg;

		// Token: 0x04032AE7 RID: 207591
		[Token(Token = "0x4032AE7")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isInited;

		// Token: 0x04032AE8 RID: 207592
		[Token(Token = "0x4032AE8")]
		[FieldOffset(Offset = "0x50")]
		private PlayerAvatarView m_avatarView;

		// Token: 0x04032AE9 RID: 207593
		[Token(Token = "0x4032AE9")]
		[FieldOffset(Offset = "0x58")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04032AEA RID: 207594
		[Token(Token = "0x4032AEA")]
		[FieldOffset(Offset = "0x68")]
		private string m_cacheNameCardId;

		// Token: 0x04032AEB RID: 207595
		[Token(Token = "0x4032AEB")]
		[FieldOffset(Offset = "0x70")]
		private string m_cacheMedalIconId;

		// Token: 0x04032AEC RID: 207596
		[Token(Token = "0x4032AEC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04032AED RID: 207597
		[Token(Token = "0x4032AED")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04032AEE RID: 207598
		[Token(Token = "0x4032AEE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
