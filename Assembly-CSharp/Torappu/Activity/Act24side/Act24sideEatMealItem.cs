using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x0200757D RID: 30077
	[Token(Token = "0x200757D")]
	public class Act24sideEatMealItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602A58A RID: 173450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A58A")]
		[Address(RVA = "0x25FDD70", Offset = "0x25FC970", VA = "0x1825FDD70")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602A58B RID: 173451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A58B")]
		[Address(RVA = "0x25FDC70", Offset = "0x25FC870", VA = "0x1825FDC70")]
		private void _ChooseImgLike()
		{
		}

		// Token: 0x0602A58C RID: 173452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A58C")]
		[Address(RVA = "0x25FD9E0", Offset = "0x25FC5E0", VA = "0x1825FD9E0")]
		public void Render(string mealId, Act24sideMealViewModel mealViewModel, Act24sideEatViewModel eatViewModel, bool isInit)
		{
		}

		// Token: 0x0602A58D RID: 173453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A58D")]
		[Address(RVA = "0x25FD8D0", Offset = "0x25FC4D0", VA = "0x1825FD8D0")]
		public void OnClicked()
		{
		}

		// Token: 0x0602A58E RID: 173454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A58E")]
		[Address(RVA = "0x25FE0C0", Offset = "0x25FCCC0", VA = "0x1825FE0C0")]
		public Act24sideEatMealItem()
		{
		}

		// Token: 0x0403CE62 RID: 249442
		[Token(Token = "0x403CE62")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgMeal;

		// Token: 0x0403CE63 RID: 249443
		[Token(Token = "0x403CE63")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgItem;

		// Token: 0x0403CE64 RID: 249444
		[Token(Token = "0x403CE64")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textMealName;

		// Token: 0x0403CE65 RID: 249445
		[Token(Token = "0x403CE65")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _animSelected;

		// Token: 0x0403CE66 RID: 249446
		[Token(Token = "0x403CE66")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject[] _itemLikes;

		// Token: 0x0403CE67 RID: 249447
		[Token(Token = "0x403CE67")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _pnlEaten;

		// Token: 0x0403CE68 RID: 249448
		[Token(Token = "0x403CE68")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Button _btnItem;

		// Token: 0x0403CE69 RID: 249449
		[Token(Token = "0x403CE69")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RectTransform _posHandler;

		// Token: 0x0403CE6A RID: 249450
		[Token(Token = "0x403CE6A")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _posSelected;

		// Token: 0x0403CE6B RID: 249451
		[Token(Token = "0x403CE6B")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float _posTweenDuration;

		// Token: 0x0403CE6C RID: 249452
		[Token(Token = "0x403CE6C")]
		[FieldOffset(Offset = "0x68")]
		private bool m_inited;

		// Token: 0x0403CE6D RID: 249453
		[Token(Token = "0x403CE6D")]
		[FieldOffset(Offset = "0x70")]
		private UISwitchTween m_selectedSwitchTween;

		// Token: 0x0403CE6E RID: 249454
		[Token(Token = "0x403CE6E")]
		[FieldOffset(Offset = "0x78")]
		private Act24sideEatMealItem.TranslateSwitchTween m_selectedTranslateTween;

		// Token: 0x0403CE6F RID: 249455
		[Token(Token = "0x403CE6F")]
		[FieldOffset(Offset = "0x80")]
		private UIStateFinder m_finder;

		// Token: 0x0403CE70 RID: 249456
		[Token(Token = "0x403CE70")]
		[FieldOffset(Offset = "0x90")]
		private string m_cachedMealId;

		// Token: 0x0403CE71 RID: 249457
		[Token(Token = "0x403CE71")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403CE72 RID: 249458
		[Token(Token = "0x403CE72")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__ChooseImgLike;

		// Token: 0x0403CE73 RID: 249459
		[Token(Token = "0x403CE73")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403CE74 RID: 249460
		[Token(Token = "0x403CE74")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClicked;

		// Token: 0x0403CE75 RID: 249461
		[Token(Token = "0x403CE75")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200757E RID: 30078
		[Token(Token = "0x200757E")]
		private class TranslateSwitchTween : UISwitchTween
		{
			// Token: 0x0602A58F RID: 173455 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A58F")]
			[Address(RVA = "0x26046B0", Offset = "0x26032B0", VA = "0x1826046B0")]
			public TranslateSwitchTween(Act24sideEatMealItem closure)
			{
			}

			// Token: 0x0602A590 RID: 173456 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602A590")]
			[Address(RVA = "0x2604440", Offset = "0x2603040", VA = "0x182604440", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0602A591 RID: 173457 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602A591")]
			[Address(RVA = "0x2604520", Offset = "0x2603120", VA = "0x182604520", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x0602A592 RID: 173458 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A592")]
			[Address(RVA = "0x2604600", Offset = "0x2603200", VA = "0x182604600", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x0602A593 RID: 173459 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A593")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x0403CE76 RID: 249462
			[Token(Token = "0x403CE76")]
			[FieldOffset(Offset = "0x48")]
			private Act24sideEatMealItem m_closure;

			// Token: 0x0403CE77 RID: 249463
			[Token(Token = "0x403CE77")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403CE78 RID: 249464
			[Token(Token = "0x403CE78")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x0403CE79 RID: 249465
			[Token(Token = "0x403CE79")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x0403CE7A RID: 249466
			[Token(Token = "0x403CE7A")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}
	}
}
