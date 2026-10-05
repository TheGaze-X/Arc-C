using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Battle.AutoChess;
using UnityEngine;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x020064F4 RID: 25844
	[Token(Token = "0x20064F4")]
	public class AutoChessBattleUISettleEndingView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170057A2 RID: 22434
		// (get) Token: 0x06025232 RID: 152114 RVA: 0x000C6A68 File Offset: 0x000C4C68
		[Token(Token = "0x170057A2")]
		public AutoChessSettleDataModel.EndingStatus endingStatus
		{
			[Token(Token = "0x6025232")]
			[Address(RVA = "0x2023B40", Offset = "0x2022740", VA = "0x182023B40")]
			get
			{
				return AutoChessSettleDataModel.EndingStatus.NONE;
			}
		}

		// Token: 0x06025233 RID: 152115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025233")]
		[Address(RVA = "0x2023880", Offset = "0x2022480", VA = "0x182023880")]
		public void Render(AutoChessSettleDataModel settleModel)
		{
		}

		// Token: 0x06025234 RID: 152116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025234")]
		[Address(RVA = "0x2023A50", Offset = "0x2022650", VA = "0x182023A50")]
		private void _OnAnimEnd()
		{
		}

		// Token: 0x06025235 RID: 152117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025235")]
		[Address(RVA = "0x2023AE0", Offset = "0x20226E0", VA = "0x182023AE0")]
		public AutoChessBattleUISettleEndingView()
		{
		}

		// Token: 0x04034110 RID: 213264
		[Token(Token = "0x4034110")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AutoChessSettleDataModel.EndingStatus _endingStatus;

		// Token: 0x04034111 RID: 213265
		[Token(Token = "0x4034111")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAnimationLocation _animEnter;

		// Token: 0x04034112 RID: 213266
		[Token(Token = "0x4034112")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AutoChessBattleUISettleEndingWidget _widget;

		// Token: 0x04034113 RID: 213267
		[Token(Token = "0x4034113")]
		[FieldOffset(Offset = "0x38")]
		private UICompDialogFinder m_dialogFinder;

		// Token: 0x04034114 RID: 213268
		[Token(Token = "0x4034114")]
		[FieldOffset(Offset = "0x48")]
		private Tween m_enterTween;

		// Token: 0x04034115 RID: 213269
		[Token(Token = "0x4034115")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_endingStatus;

		// Token: 0x04034116 RID: 213270
		[Token(Token = "0x4034116")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04034117 RID: 213271
		[Token(Token = "0x4034117")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnAnimEnd;

		// Token: 0x04034118 RID: 213272
		[Token(Token = "0x4034118")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
