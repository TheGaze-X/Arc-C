using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006344 RID: 25412
	[Token(Token = "0x2006344")]
	public class AutoChessItemDetailView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06024AA8 RID: 150184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024AA8")]
		[Address(RVA = "0x1F80310", Offset = "0x1F7EF10", VA = "0x181F80310")]
		public void Render(AutoChessItemDetailViewModel viewModel)
		{
		}

		// Token: 0x06024AA9 RID: 150185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024AA9")]
		[Address(RVA = "0x1F806C0", Offset = "0x1F7F2C0", VA = "0x181F806C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06024AAA RID: 150186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024AAA")]
		[Address(RVA = "0x1F80910", Offset = "0x1F7F510", VA = "0x181F80910")]
		private void _RenderItem(AutoChessItemDetailItemViewModel itemViewModel)
		{
		}

		// Token: 0x06024AAB RID: 150187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024AAB")]
		[Address(RVA = "0x1F80750", Offset = "0x1F7F350", VA = "0x181F80750")]
		private void _OnMoveHideTweenComplete()
		{
		}

		// Token: 0x06024AAC RID: 150188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024AAC")]
		[Address(RVA = "0x1F80B30", Offset = "0x1F7F730", VA = "0x181F80B30")]
		private void _ResetScrollRect()
		{
		}

		// Token: 0x06024AAD RID: 150189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024AAD")]
		[Address(RVA = "0x1F80C10", Offset = "0x1F7F810", VA = "0x181F80C10")]
		public AutoChessItemDetailView()
		{
		}

		// Token: 0x04033287 RID: 209543
		[Token(Token = "0x4033287")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _itemIconImg;

		// Token: 0x04033288 RID: 209544
		[Token(Token = "0x4033288")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _itemLevelIconImg;

		// Token: 0x04033289 RID: 209545
		[Token(Token = "0x4033289")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _itemNameText;

		// Token: 0x0403328A RID: 209546
		[Token(Token = "0x403328A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AutoChessItemDetailView.SingleDescPanel _singleDescPanel;

		// Token: 0x0403328B RID: 209547
		[Token(Token = "0x403328B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AutoChessItemDetailView.FullDescPanel _fullDescPanel;

		// Token: 0x0403328C RID: 209548
		[Token(Token = "0x403328C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AutoChessItemDetailView.MoveAnimGroup _rightMoveAnimGroup;

		// Token: 0x0403328D RID: 209549
		[Token(Token = "0x403328D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AutoChessItemDetailView.MoveAnimGroup _leftMoveAnimGroup;

		// Token: 0x0403328E RID: 209550
		[Token(Token = "0x403328E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ScrollRect[] _descScrollRects;

		// Token: 0x0403328F RID: 209551
		[Token(Token = "0x403328F")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isInited;

		// Token: 0x04033290 RID: 209552
		[Token(Token = "0x4033290")]
		[FieldOffset(Offset = "0x60")]
		private UICompDialogFinder m_dialogFinder;

		// Token: 0x04033291 RID: 209553
		[Token(Token = "0x4033291")]
		[FieldOffset(Offset = "0x70")]
		private int m_cachedMoveSeqNum;

		// Token: 0x04033292 RID: 209554
		[Token(Token = "0x4033292")]
		[FieldOffset(Offset = "0x78")]
		private AutoChessItemDetailItemViewModel m_cachedItemViewModelForKill;

		// Token: 0x04033293 RID: 209555
		[Token(Token = "0x4033293")]
		[FieldOffset(Offset = "0x80")]
		private Tween m_cachedMoveTween;

		// Token: 0x04033294 RID: 209556
		[Token(Token = "0x4033294")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04033295 RID: 209557
		[Token(Token = "0x4033295")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04033296 RID: 209558
		[Token(Token = "0x4033296")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderItem;

		// Token: 0x04033297 RID: 209559
		[Token(Token = "0x4033297")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnMoveHideTweenComplete;

		// Token: 0x04033298 RID: 209560
		[Token(Token = "0x4033298")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ResetScrollRect;

		// Token: 0x04033299 RID: 209561
		[Token(Token = "0x4033299")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006345 RID: 25413
		[Token(Token = "0x2006345")]
		[Serializable]
		private class SingleDescPanel : IHotfixable
		{
			// Token: 0x06024AAE RID: 150190 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024AAE")]
			[Address(RVA = "0x1F956D0", Offset = "0x1F942D0", VA = "0x181F956D0")]
			public void Render(AutoChessItemDetailItemViewModel itemViewModel)
			{
			}

			// Token: 0x06024AAF RID: 150191 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024AAF")]
			[Address(RVA = "0x1F958E0", Offset = "0x1F944E0", VA = "0x181F958E0")]
			public SingleDescPanel()
			{
			}

			// Token: 0x0403329A RID: 209562
			[Token(Token = "0x403329A")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private GameObject _container;

			// Token: 0x0403329B RID: 209563
			[Token(Token = "0x403329B")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Text _descText;

			// Token: 0x0403329C RID: 209564
			[Token(Token = "0x403329C")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Text _storyText;

			// Token: 0x0403329D RID: 209565
			[Token(Token = "0x403329D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Render;

			// Token: 0x0403329E RID: 209566
			[Token(Token = "0x403329E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02006346 RID: 25414
		[Token(Token = "0x2006346")]
		[Serializable]
		private class FullDescPanel : IHotfixable
		{
			// Token: 0x06024AB0 RID: 150192 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024AB0")]
			[Address(RVA = "0x1F94E10", Offset = "0x1F93A10", VA = "0x181F94E10")]
			public void Render(AutoChessItemDetailItemViewModel itemViewModel)
			{
			}

			// Token: 0x06024AB1 RID: 150193 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024AB1")]
			[Address(RVA = "0x1F950B0", Offset = "0x1F93CB0", VA = "0x181F950B0")]
			public FullDescPanel()
			{
			}

			// Token: 0x0403329F RID: 209567
			[Token(Token = "0x403329F")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private GameObject _container;

			// Token: 0x040332A0 RID: 209568
			[Token(Token = "0x40332A0")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Text _descText;

			// Token: 0x040332A1 RID: 209569
			[Token(Token = "0x40332A1")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Text _goldenDescText;

			// Token: 0x040332A2 RID: 209570
			[Token(Token = "0x40332A2")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private Text _storyText;

			// Token: 0x040332A3 RID: 209571
			[Token(Token = "0x40332A3")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Render;

			// Token: 0x040332A4 RID: 209572
			[Token(Token = "0x40332A4")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02006347 RID: 25415
		[Token(Token = "0x2006347")]
		[Serializable]
		private class MoveAnimGroup : IHotfixable
		{
			// Token: 0x06024AB2 RID: 150194 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024AB2")]
			[Address(RVA = "0x1F95110", Offset = "0x1F93D10", VA = "0x181F95110")]
			public void InitIfNot()
			{
			}

			// Token: 0x06024AB3 RID: 150195 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6024AB3")]
			[Address(RVA = "0x1F95190", Offset = "0x1F93D90", VA = "0x181F95190")]
			public Tween PlayWithTween(Action callBackOnHide)
			{
				return null;
			}

			// Token: 0x06024AB4 RID: 150196 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024AB4")]
			[Address(RVA = "0x1F95300", Offset = "0x1F93F00", VA = "0x181F95300")]
			public MoveAnimGroup()
			{
			}

			// Token: 0x040332A5 RID: 209573
			[Token(Token = "0x40332A5")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private UIAnimationLocation _enterAnim;

			// Token: 0x040332A6 RID: 209574
			[Token(Token = "0x40332A6")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private UIAnimationLocation _hideAnim;

			// Token: 0x040332A7 RID: 209575
			[Token(Token = "0x40332A7")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_InitIfNot;

			// Token: 0x040332A8 RID: 209576
			[Token(Token = "0x40332A8")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_PlayWithTween;

			// Token: 0x040332A9 RID: 209577
			[Token(Token = "0x40332A9")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
