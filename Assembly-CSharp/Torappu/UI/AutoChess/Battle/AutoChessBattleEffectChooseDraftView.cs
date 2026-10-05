using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Battle.AutoChess;
using UnityEngine;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x020064B2 RID: 25778
	[Token(Token = "0x20064B2")]
	public class AutoChessBattleEffectChooseDraftView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060250ED RID: 151789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60250ED")]
		[Address(RVA = "0x1FE0470", Offset = "0x1FDF070", VA = "0x181FE0470")]
		public void Render(AutoChessBattleEffectChooseDraftModel draftModel, AutoChessBattleSpPrepareStepModel stepModel, AutoChessEffectChooseDataModel.AutoChessBattleEffectChooseMode renderMode, bool isFirstShow)
		{
		}

		// Token: 0x060250EE RID: 151790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60250EE")]
		[Address(RVA = "0x1FE06D0", Offset = "0x1FDF2D0", VA = "0x181FE06D0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060250EF RID: 151791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60250EF")]
		[Address(RVA = "0x1FE0830", Offset = "0x1FDF430", VA = "0x181FE0830")]
		private void _PlayPlayerTurnAnim(AutoChessBattleSpPrepareStepModel stepModel, AutoChessEffectChooseDataModel.AutoChessBattleEffectChooseMode renderMode)
		{
		}

		// Token: 0x060250F0 RID: 151792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60250F0")]
		[Address(RVA = "0x1FE0A80", Offset = "0x1FDF680", VA = "0x181FE0A80")]
		public AutoChessBattleEffectChooseDraftView()
		{
		}

		// Token: 0x04033E23 RID: 212515
		[Token(Token = "0x4033E23")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _draftItemContent;

		// Token: 0x04033E24 RID: 212516
		[Token(Token = "0x4033E24")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _pnlPlayerTurn;

		// Token: 0x04033E25 RID: 212517
		[Token(Token = "0x4033E25")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _playerTurnAnim;

		// Token: 0x04033E26 RID: 212518
		[Token(Token = "0x4033E26")]
		[FieldOffset(Offset = "0x38")]
		private bool m_inited;

		// Token: 0x04033E27 RID: 212519
		[Token(Token = "0x4033E27")]
		[FieldOffset(Offset = "0x40")]
		private AutoChessBattleEffectChooseDraftView.DraftItemLayoutAdapter m_adapter;

		// Token: 0x04033E28 RID: 212520
		[Token(Token = "0x4033E28")]
		[FieldOffset(Offset = "0x48")]
		private AutoChessBattleEffectChooseDraftModel m_cachedModel;

		// Token: 0x04033E29 RID: 212521
		[Token(Token = "0x4033E29")]
		[FieldOffset(Offset = "0x50")]
		private AutoChessBattleEffectChooseDraftItemView.Params m_cachedParams;

		// Token: 0x04033E2A RID: 212522
		[Token(Token = "0x4033E2A")]
		[FieldOffset(Offset = "0x60")]
		private Tween m_playerTurnTween;

		// Token: 0x04033E2B RID: 212523
		[Token(Token = "0x4033E2B")]
		[FieldOffset(Offset = "0x68")]
		private SeqNumSource.Checker m_stepChecker;

		// Token: 0x04033E2C RID: 212524
		[Token(Token = "0x4033E2C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04033E2D RID: 212525
		[Token(Token = "0x4033E2D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04033E2E RID: 212526
		[Token(Token = "0x4033E2E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__PlayPlayerTurnAnim;

		// Token: 0x04033E2F RID: 212527
		[Token(Token = "0x4033E2F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020064B3 RID: 25779
		[Token(Token = "0x20064B3")]
		private class DraftItemLayoutAdapter : SimpleLayoutAdapter
		{
			// Token: 0x060250F2 RID: 151794 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60250F2")]
			[Address(RVA = "0x1FF1080", Offset = "0x1FEFC80", VA = "0x181FF1080")]
			public DraftItemLayoutAdapter(AutoChessBattleEffectChooseDraftView closure)
			{
			}

			// Token: 0x17005774 RID: 22388
			// (get) Token: 0x060250F3 RID: 151795 RVA: 0x000C6540 File Offset: 0x000C4740
			[Token(Token = "0x17005774")]
			public override int count
			{
				[Token(Token = "0x60250F3")]
				[Address(RVA = "0x1FF1140", Offset = "0x1FEFD40", VA = "0x181FF1140", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060250F4 RID: 151796 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60250F4")]
			[Address(RVA = "0x1FF0E20", Offset = "0x1FEFA20", VA = "0x181FF0E20", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04033E30 RID: 212528
			[Token(Token = "0x4033E30")]
			[FieldOffset(Offset = "0x20")]
			private AutoChessBattleEffectChooseDraftView m_closure;

			// Token: 0x04033E31 RID: 212529
			[Token(Token = "0x4033E31")]
			[FieldOffset(Offset = "0x28")]
			private ExclusiveSelectionGroup m_exclusiveGroup;

			// Token: 0x04033E32 RID: 212530
			[Token(Token = "0x4033E32")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04033E33 RID: 212531
			[Token(Token = "0x4033E33")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04033E34 RID: 212532
			[Token(Token = "0x4033E34")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
