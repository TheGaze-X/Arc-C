using System;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI
{
	// Token: 0x02001AEE RID: 6894
	[Token(Token = "0x2001AEE")]
	public class BuildingCharCtrlHomeView : DataBinder<BuildingCharCtrlHomeViewModelProperty>
	{
		// Token: 0x0600AE46 RID: 44614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE46")]
		[Address(RVA = "0x328D5E0", Offset = "0x328C1E0", VA = "0x18328D5E0", Slot = "7")]
		public override void OnValueChanged(BuildingCharCtrlHomeViewModelProperty property)
		{
		}

		// Token: 0x0600AE47 RID: 44615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE47")]
		[Address(RVA = "0x328DA30", Offset = "0x328C630", VA = "0x18328DA30")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0600AE48 RID: 44616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE48")]
		[Address(RVA = "0x328DB80", Offset = "0x328C780", VA = "0x18328DB80")]
		private void _UpdateUpDownstairsRelated(BuildingCharCtrlHomeViewModel viewModel)
		{
		}

		// Token: 0x0600AE49 RID: 44617 RVA: 0x000431D0 File Offset: 0x000413D0
		[Token(Token = "0x600AE49")]
		[Address(RVA = "0x328D4C0", Offset = "0x328C0C0", VA = "0x18328D4C0")]
		public Vector2 GetJoystickAxis()
		{
			return default(Vector2);
		}

		// Token: 0x0600AE4A RID: 44618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE4A")]
		[Address(RVA = "0x328DE10", Offset = "0x328CA10", VA = "0x18328DE10")]
		public BuildingCharCtrlHomeView()
		{
		}

		// Token: 0x0400A6B1 RID: 42673
		[Token(Token = "0x400A6B1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ETCJoystick _etcJoystick;

		// Token: 0x0400A6B2 RID: 42674
		[Token(Token = "0x400A6B2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelTouch;

		// Token: 0x0400A6B3 RID: 42675
		[Token(Token = "0x400A6B3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private BuildingCharCtrlTouchBtn _btnTouch;

		// Token: 0x0400A6B4 RID: 42676
		[Token(Token = "0x400A6B4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("UpDownstairs")]
		private GameObject _panelUpAndDown;

		// Token: 0x0400A6B5 RID: 42677
		[Token(Token = "0x400A6B5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("UpDownstairs")]
		private CanvasGroup _canvasGroupUpDownBtn;

		// Token: 0x0400A6B6 RID: 42678
		[Token(Token = "0x400A6B6")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("UpDownstairs")]
		private CanvasGroup _canvasGroupWaiting;

		// Token: 0x0400A6B7 RID: 42679
		[Token(Token = "0x400A6B7")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("UpDownstairs")]
		private Button _btnUpstairs;

		// Token: 0x0400A6B8 RID: 42680
		[Token(Token = "0x400A6B8")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("UpDownstairs")]
		private Button _btnDownstairs;

		// Token: 0x0400A6B9 RID: 42681
		[Token(Token = "0x400A6B9")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("UpDownstairs")]
		private GameObject _panelUpWaiting;

		// Token: 0x0400A6BA RID: 42682
		[Token(Token = "0x400A6BA")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("UpDownstairs")]
		private GameObject _panelDownWaiting;

		// Token: 0x0400A6BB RID: 42683
		[Token(Token = "0x400A6BB")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAnimationLocation _animationLocationShow;

		// Token: 0x0400A6BC RID: 42684
		[Token(Token = "0x400A6BC")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAnimationLocation _animationLocationHide;

		// Token: 0x0400A6BD RID: 42685
		[Token(Token = "0x400A6BD")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _panelSwitchUIBtn;

		// Token: 0x0400A6BE RID: 42686
		[Token(Token = "0x400A6BE")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private UIAnimationLocation _animationLocationShowEmoji;

		// Token: 0x0400A6BF RID: 42687
		[Token(Token = "0x400A6BF")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private UIAnimationLocation _animationLocationHideEmoji;

		// Token: 0x0400A6C0 RID: 42688
		[Token(Token = "0x400A6C0")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private SimpleLayoutContent _emojiLayoutContent;

		// Token: 0x0400A6C1 RID: 42689
		[Token(Token = "0x400A6C1")]
		[FieldOffset(Offset = "0xC0")]
		private BuildingCharCtrlHomeViewModel m_cachedViewModel;

		// Token: 0x0400A6C2 RID: 42690
		[Token(Token = "0x400A6C2")]
		[FieldOffset(Offset = "0xC8")]
		private bool m_cachedIsShowUI;

		// Token: 0x0400A6C3 RID: 42691
		[Token(Token = "0x400A6C3")]
		[FieldOffset(Offset = "0xC9")]
		private bool m_cachedShowEmoji;

		// Token: 0x0400A6C4 RID: 42692
		[Token(Token = "0x400A6C4")]
		[FieldOffset(Offset = "0xD0")]
		private BuildingCharCtrlHomeView.EmojiAdapter m_emojiAdapter;

		// Token: 0x0400A6C5 RID: 42693
		[Token(Token = "0x400A6C5")]
		[FieldOffset(Offset = "0xD8")]
		private Tween m_showHideTween;

		// Token: 0x0400A6C6 RID: 42694
		[Token(Token = "0x400A6C6")]
		[FieldOffset(Offset = "0xE0")]
		private Tween m_emojiShowHideTween;

		// Token: 0x0400A6C7 RID: 42695
		[Token(Token = "0x400A6C7")]
		[FieldOffset(Offset = "0xE8")]
		private bool m_isInited;

		// Token: 0x0400A6C8 RID: 42696
		[Token(Token = "0x400A6C8")]
		[FieldOffset(Offset = "0xE9")]
		private bool m_cachedIsUpDownstairs;

		// Token: 0x0400A6C9 RID: 42697
		[Token(Token = "0x400A6C9")]
		[FieldOffset(Offset = "0xF0")]
		private FadeSwitchTween m_upDownBtnFadeTween;

		// Token: 0x0400A6CA RID: 42698
		[Token(Token = "0x400A6CA")]
		[FieldOffset(Offset = "0xF8")]
		private FadeSwitchTween m_waitingFadeTween;

		// Token: 0x0400A6CB RID: 42699
		[Token(Token = "0x400A6CB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0400A6CC RID: 42700
		[Token(Token = "0x400A6CC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0400A6CD RID: 42701
		[Token(Token = "0x400A6CD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateUpDownstairsRelated;

		// Token: 0x0400A6CE RID: 42702
		[Token(Token = "0x400A6CE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetJoystickAxis;

		// Token: 0x0400A6CF RID: 42703
		[Token(Token = "0x400A6CF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001AEF RID: 6895
		[Token(Token = "0x2001AEF")]
		private class EmojiAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0600AE4C RID: 44620 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AE4C")]
			[Address(RVA = "0x329C360", Offset = "0x329AF60", VA = "0x18329C360")]
			public EmojiAdapter(BuildingCharCtrlHomeView closure)
			{
			}

			// Token: 0x1700149C RID: 5276
			// (get) Token: 0x0600AE4D RID: 44621 RVA: 0x000431E8 File Offset: 0x000413E8
			[Token(Token = "0x1700149C")]
			public override int count
			{
				[Token(Token = "0x600AE4D")]
				[Address(RVA = "0x329C3E0", Offset = "0x329AFE0", VA = "0x18329C3E0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0600AE4E RID: 44622 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600AE4E")]
			[Address(RVA = "0x329C050", Offset = "0x329AC50", VA = "0x18329C050", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0400A6D0 RID: 42704
			[Token(Token = "0x400A6D0")]
			[FieldOffset(Offset = "0x20")]
			private BuildingCharCtrlHomeView m_closure;

			// Token: 0x0400A6D1 RID: 42705
			[Token(Token = "0x400A6D1")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400A6D2 RID: 42706
			[Token(Token = "0x400A6D2")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0400A6D3 RID: 42707
			[Token(Token = "0x400A6D3")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
