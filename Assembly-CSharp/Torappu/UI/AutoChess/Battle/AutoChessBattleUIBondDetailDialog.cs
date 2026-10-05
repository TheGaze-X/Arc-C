using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x020064CF RID: 25807
	[Token(Token = "0x20064CF")]
	public class AutoChessBattleUIBondDetailDialog : UICompDialog<AutoChessBattleUIBondDetailDialog.Input>
	{
		// Token: 0x06025163 RID: 151907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025163")]
		[Address(RVA = "0x1FE2630", Offset = "0x1FE1230", VA = "0x181FE2630", Slot = "18")]
		protected override void OnRender(AutoChessBattleUIBondDetailDialog.Input input)
		{
		}

		// Token: 0x06025164 RID: 151908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025164")]
		[Address(RVA = "0x1FE2850", Offset = "0x1FE1450", VA = "0x181FE2850")]
		private void _PlayEnterAnim()
		{
		}

		// Token: 0x06025165 RID: 151909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025165")]
		[Address(RVA = "0x1FE2990", Offset = "0x1FE1590", VA = "0x181FE2990")]
		public AutoChessBattleUIBondDetailDialog()
		{
		}

		// Token: 0x04033F1D RID: 212765
		[Token(Token = "0x4033F1D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private AutoChessBattleUIBondDetailView _view;

		// Token: 0x04033F1E RID: 212766
		[Token(Token = "0x4033F1E")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _viewRoot;

		// Token: 0x04033F1F RID: 212767
		[Token(Token = "0x4033F1F")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x04033F20 RID: 212768
		[Token(Token = "0x4033F20")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private CanvasGroup _viewAlphaHolder;

		// Token: 0x04033F21 RID: 212769
		[Token(Token = "0x4033F21")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private float _fadeDuration;

		// Token: 0x04033F22 RID: 212770
		[Token(Token = "0x4033F22")]
		[FieldOffset(Offset = "0xA0")]
		private Tween m_tween;

		// Token: 0x04033F23 RID: 212771
		[Token(Token = "0x4033F23")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04033F24 RID: 212772
		[Token(Token = "0x4033F24")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__PlayEnterAnim;

		// Token: 0x04033F25 RID: 212773
		[Token(Token = "0x4033F25")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020064D0 RID: 25808
		[Token(Token = "0x20064D0")]
		public class Input
		{
			// Token: 0x06025166 RID: 151910 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025166")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x04033F26 RID: 212774
			[Token(Token = "0x4033F26")]
			[FieldOffset(Offset = "0x10")]
			public AutoChessBattleUIViewModelProperty prop;
		}
	}
}
