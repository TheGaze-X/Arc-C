using System;
using System.Collections;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.Meeting
{
	// Token: 0x02001D1C RID: 7452
	[Token(Token = "0x2001D1C")]
	public class BuildingMessageLeaveBoardLastWeekRewardDialog : UICompDialog<BuildingMessageLeaveBoardLastWeekRewardDialog.Input>, IHotfixable
	{
		// Token: 0x0600B7F9 RID: 47097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B7F9")]
		[Address(RVA = "0x333A650", Offset = "0x3339250", VA = "0x18333A650")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0600B7FA RID: 47098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B7FA")]
		[Address(RVA = "0x333AB30", Offset = "0x3339730", VA = "0x18333AB30")]
		private void _SetRewardItemModel(int rewardNum)
		{
		}

		// Token: 0x0600B7FB RID: 47099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B7FB")]
		[Address(RVA = "0x3339EA0", Offset = "0x3338AA0", VA = "0x183339EA0", Slot = "18")]
		protected override void OnRender(BuildingMessageLeaveBoardLastWeekRewardDialog.Input input)
		{
		}

		// Token: 0x0600B7FC RID: 47100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B7FC")]
		[Address(RVA = "0x333A880", Offset = "0x3339480", VA = "0x18333A880")]
		private IEnumerator _PlayEntryAnim()
		{
			return null;
		}

		// Token: 0x0600B7FD RID: 47101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B7FD")]
		[Address(RVA = "0x333A930", Offset = "0x3339530", VA = "0x18333A930")]
		private IEnumerator _PlayLeaveAnim()
		{
			return null;
		}

		// Token: 0x0600B7FE RID: 47102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B7FE")]
		[Address(RVA = "0x333A9E0", Offset = "0x33395E0", VA = "0x18333A9E0")]
		private void _RenderRewardItem(BuildingMessageLeaveBoardModel msgBoardModel)
		{
		}

		// Token: 0x0600B7FF RID: 47103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B7FF")]
		[Address(RVA = "0x333A3E0", Offset = "0x3338FE0", VA = "0x18333A3E0")]
		private string _GetLastWeekTime()
		{
			return null;
		}

		// Token: 0x0600B800 RID: 47104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B800")]
		[Address(RVA = "0x3339E40", Offset = "0x3338A40", VA = "0x183339E40", Slot = "15")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0600B801 RID: 47105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B801")]
		[Address(RVA = "0x3339CE0", Offset = "0x33388E0", VA = "0x183339CE0")]
		public void EventOnBgClicked()
		{
		}

		// Token: 0x0600B802 RID: 47106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B802")]
		[Address(RVA = "0x333AC30", Offset = "0x3339830", VA = "0x18333AC30")]
		public BuildingMessageLeaveBoardLastWeekRewardDialog()
		{
		}

		// Token: 0x0600B805 RID: 47109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B805")]
		[Address(RVA = "0xE613B0", Offset = "0xE5FFB0", VA = "0x180E613B0")]
		private UIRenderTextureImage <>xLuaBaseProxy_GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0400B5E3 RID: 46563
		[Token(Token = "0x400B5E3")]
		private const float FADE_DURATION = 0.25f;

		// Token: 0x0400B5E4 RID: 46564
		[Token(Token = "0x400B5E4")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0400B5E5 RID: 46565
		[Token(Token = "0x400B5E5")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _textRecord;

		// Token: 0x0400B5E6 RID: 46566
		[Token(Token = "0x400B5E6")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _rewardTip;

		// Token: 0x0400B5E7 RID: 46567
		[Token(Token = "0x400B5E7")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RectTransform _itemCardContainer;

		// Token: 0x0400B5E8 RID: 46568
		[Token(Token = "0x400B5E8")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIAnimationLocation _animEntry;

		// Token: 0x0400B5E9 RID: 46569
		[Token(Token = "0x400B5E9")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private UIRenderTextureImage _blurImg;

		// Token: 0x0400B5EA RID: 46570
		[Token(Token = "0x400B5EA")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject _panelLastWeekReward;

		// Token: 0x0400B5EB RID: 46571
		[Token(Token = "0x400B5EB")]
		[FieldOffset(Offset = "0xB0")]
		private ItemBundle m_rewardSocialPointItem;

		// Token: 0x0400B5EC RID: 46572
		[Token(Token = "0x400B5EC")]
		[FieldOffset(Offset = "0xB8")]
		private bool m_canClick;

		// Token: 0x0400B5ED RID: 46573
		[Token(Token = "0x400B5ED")]
		[FieldOffset(Offset = "0xC0")]
		private Tween m_inOutTween;

		// Token: 0x0400B5EE RID: 46574
		[Token(Token = "0x400B5EE")]
		[FieldOffset(Offset = "0xC8")]
		private UIItemViewModel m_itemViewModel;

		// Token: 0x0400B5EF RID: 46575
		[Token(Token = "0x400B5EF")]
		[FieldOffset(Offset = "0xD0")]
		private int m_lastWeekReward;

		// Token: 0x0400B5F0 RID: 46576
		[Token(Token = "0x400B5F0")]
		[FieldOffset(Offset = "0xD4")]
		private bool m_isInited;

		// Token: 0x0400B5F1 RID: 46577
		[Token(Token = "0x400B5F1")]
		[FieldOffset(Offset = "0xD8")]
		private UIItemCard m_itemCard;

		// Token: 0x0400B5F2 RID: 46578
		[Token(Token = "0x400B5F2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0400B5F3 RID: 46579
		[Token(Token = "0x400B5F3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__SetRewardItemModel;

		// Token: 0x0400B5F4 RID: 46580
		[Token(Token = "0x400B5F4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0400B5F5 RID: 46581
		[Token(Token = "0x400B5F5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__PlayEntryAnim;

		// Token: 0x0400B5F6 RID: 46582
		[Token(Token = "0x400B5F6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__PlayLeaveAnim;

		// Token: 0x0400B5F7 RID: 46583
		[Token(Token = "0x400B5F7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderRewardItem;

		// Token: 0x0400B5F8 RID: 46584
		[Token(Token = "0x400B5F8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GetLastWeekTime;

		// Token: 0x0400B5F9 RID: 46585
		[Token(Token = "0x400B5F9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x0400B5FA RID: 46586
		[Token(Token = "0x400B5FA")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnBgClicked;

		// Token: 0x0400B5FB RID: 46587
		[Token(Token = "0x400B5FB")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001D1D RID: 7453
		[Token(Token = "0x2001D1D")]
		public class Input
		{
			// Token: 0x0600B806 RID: 47110 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B806")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0400B5FC RID: 46588
			[Token(Token = "0x400B5FC")]
			[FieldOffset(Offset = "0x10")]
			public BuildingMessageLeaveBoardModel msgBoardModel;
		}
	}
}
