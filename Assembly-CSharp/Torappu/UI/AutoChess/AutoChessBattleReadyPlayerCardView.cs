using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x020062A4 RID: 25252
	[Token(Token = "0x20062A4")]
	public class AutoChessBattleReadyPlayerCardView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06024673 RID: 149107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024673")]
		[Address(RVA = "0x1F299E0", Offset = "0x1F285E0", VA = "0x181F299E0")]
		public void Render(bool isSingle, AutoChessBattleReadyPlayerModel model)
		{
		}

		// Token: 0x06024674 RID: 149108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024674")]
		[Address(RVA = "0x1F29DA0", Offset = "0x1F289A0", VA = "0x181F29DA0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06024675 RID: 149109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024675")]
		[Address(RVA = "0x1F29EC0", Offset = "0x1F28AC0", VA = "0x181F29EC0")]
		public AutoChessBattleReadyPlayerCardView()
		{
		}

		// Token: 0x04032A7C RID: 207484
		[Token(Token = "0x4032A7C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelLeft;

		// Token: 0x04032A7D RID: 207485
		[Token(Token = "0x4032A7D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelRight;

		// Token: 0x04032A7E RID: 207486
		[Token(Token = "0x4032A7E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text[] _textIndex;

		// Token: 0x04032A7F RID: 207487
		[Token(Token = "0x4032A7F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _leftAvatarContainer;

		// Token: 0x04032A80 RID: 207488
		[Token(Token = "0x4032A80")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _rightAvatarContainer;

		// Token: 0x04032A81 RID: 207489
		[Token(Token = "0x4032A81")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAnimationLocation _multiEnterAnim;

		// Token: 0x04032A82 RID: 207490
		[Token(Token = "0x4032A82")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAnimationLocation _singleEnterAnim;

		// Token: 0x04032A83 RID: 207491
		[Token(Token = "0x4032A83")]
		[FieldOffset(Offset = "0x60")]
		private PlayerAvatarView m_leftAvatarView;

		// Token: 0x04032A84 RID: 207492
		[Token(Token = "0x4032A84")]
		[FieldOffset(Offset = "0x68")]
		private PlayerAvatarView m_rightAvatarView;

		// Token: 0x04032A85 RID: 207493
		[Token(Token = "0x4032A85")]
		[FieldOffset(Offset = "0x70")]
		private bool m_hasInited;

		// Token: 0x04032A86 RID: 207494
		[Token(Token = "0x4032A86")]
		[FieldOffset(Offset = "0x78")]
		private Tween m_tween;

		// Token: 0x04032A87 RID: 207495
		[Token(Token = "0x4032A87")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04032A88 RID: 207496
		[Token(Token = "0x4032A88")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04032A89 RID: 207497
		[Token(Token = "0x4032A89")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
