using System;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI.RoguelikeTopic.Mode;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL02
{
	// Token: 0x02004606 RID: 17926
	[Token(Token = "0x2004606")]
	public class RL02MonthModeView : RoguelikeTopicSubView
	{
		// Token: 0x0601B3F3 RID: 111603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B3F3")]
		[Address(RVA = "0x1461450", Offset = "0x1460050", VA = "0x181461450", Slot = "7")]
		public override void OnValueChanged(RoguelikeTopicModeViewProperty property)
		{
		}

		// Token: 0x0601B3F4 RID: 111604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B3F4")]
		[Address(RVA = "0x1461A90", Offset = "0x1460690", VA = "0x181461A90")]
		private void _Render(RoguelikeTopicModeViewModel modeViewModel)
		{
		}

		// Token: 0x0601B3F5 RID: 111605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B3F5")]
		[Address(RVA = "0x1461F50", Offset = "0x1460B50", VA = "0x181461F50")]
		private void _UpdateMonthSquadView()
		{
		}

		// Token: 0x0601B3F6 RID: 111606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B3F6")]
		[Address(RVA = "0x14614F0", Offset = "0x14600F0", VA = "0x1814614F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601B3F7 RID: 111607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B3F7")]
		[Address(RVA = "0x1461880", Offset = "0x1460480", VA = "0x181461880")]
		private void _RenderToggleGroup(RoguelikeTopicMonthSquadViewModel monthSquadGroup)
		{
		}

		// Token: 0x0601B3F8 RID: 111608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B3F8")]
		[Address(RVA = "0x14615E0", Offset = "0x14601E0", VA = "0x1814615E0")]
		private void _LoadRewardItemIcon(ItemBundle itemData)
		{
		}

		// Token: 0x0601B3F9 RID: 111609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B3F9")]
		[Address(RVA = "0x1461080", Offset = "0x145FC80", VA = "0x181461080")]
		public void EventOnOpenArchive()
		{
		}

		// Token: 0x0601B3FA RID: 111610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B3FA")]
		[Address(RVA = "0x1461260", Offset = "0x145FE60", VA = "0x181461260")]
		public void EventOnOpenRewardDetail()
		{
		}

		// Token: 0x0601B3FB RID: 111611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B3FB")]
		[Address(RVA = "0x1460F60", Offset = "0x145FB60", VA = "0x181460F60")]
		public void EventOnBtnLeftClicked()
		{
		}

		// Token: 0x0601B3FC RID: 111612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B3FC")]
		[Address(RVA = "0x1460FF0", Offset = "0x145FBF0", VA = "0x181460FF0")]
		public void EventOnBtnRightClicked()
		{
		}

		// Token: 0x0601B3FD RID: 111613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B3FD")]
		[Address(RVA = "0x14612F0", Offset = "0x145FEF0", VA = "0x1814612F0")]
		public void OnBtnCharProtraitClicked()
		{
		}

		// Token: 0x0601B3FE RID: 111614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B3FE")]
		[Address(RVA = "0x1462420", Offset = "0x1461020", VA = "0x181462420")]
		public RL02MonthModeView()
		{
		}

		// Token: 0x0601B3FF RID: 111615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B3FF")]
		[Address(RVA = "0x1406270", Offset = "0x1404E70", VA = "0x181406270")]
		private void <>xLuaBaseProxy_OnValueChanged(RoguelikeTopicModeViewProperty P0)
		{
		}

		// Token: 0x04023257 RID: 143959
		[Token(Token = "0x4023257")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Reward")]
		private GameObject _pnlAwardReceived;

		// Token: 0x04023258 RID: 143960
		[Token(Token = "0x4023258")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Reward")]
		private GameObject _pnlAwardNotReceived;

		// Token: 0x04023259 RID: 143961
		[Token(Token = "0x4023259")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Reward")]
		private RectTransform _itemIconHolder;

		// Token: 0x0402325A RID: 143962
		[Token(Token = "0x402325A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Reward")]
		private GameObject _pnlMore;

		// Token: 0x0402325B RID: 143963
		[Token(Token = "0x402325B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Reward")]
		private Image _imgIconBp;

		// Token: 0x0402325C RID: 143964
		[Token(Token = "0x402325C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Full Stored")]
		private EasyInstancePool _togglePool;

		// Token: 0x0402325D RID: 143965
		[Token(Token = "0x402325D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Full Stored")]
		private Button _btnLeft;

		// Token: 0x0402325E RID: 143966
		[Token(Token = "0x402325E")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Full Stored")]
		private Button _btnRight;

		// Token: 0x0402325F RID: 143967
		[Token(Token = "0x402325F")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIDynImage _dynImgChar;

		// Token: 0x04023260 RID: 143968
		[Token(Token = "0x4023260")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image _rarityImg;

		// Token: 0x04023261 RID: 143969
		[Token(Token = "0x4023261")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image _professionImg;

		// Token: 0x04023262 RID: 143970
		[Token(Token = "0x4023262")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _charName;

		// Token: 0x04023263 RID: 143971
		[Token(Token = "0x4023263")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x04023264 RID: 143972
		[Token(Token = "0x4023264")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private float _rewardItemScale;

		// Token: 0x04023265 RID: 143973
		[Token(Token = "0x4023265")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private UIAnimationLocation _animSwitch;

		// Token: 0x04023266 RID: 143974
		[Token(Token = "0x4023266")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_hasInited;

		// Token: 0x04023267 RID: 143975
		[Token(Token = "0x4023267")]
		[FieldOffset(Offset = "0xB0")]
		private RoguelikeTopicModeViewModel m_cachedModeViewModel;

		// Token: 0x04023268 RID: 143976
		[Token(Token = "0x4023268")]
		[FieldOffset(Offset = "0xB8")]
		private RoguelikeTopicMonthSquadModel m_cachedMonthSquadModel;

		// Token: 0x04023269 RID: 143977
		[Token(Token = "0x4023269")]
		[FieldOffset(Offset = "0xC0")]
		private RoguelikeTopicMonthSquadTeamChar m_cachedMonthCharModel;

		// Token: 0x0402326A RID: 143978
		[Token(Token = "0x402326A")]
		[FieldOffset(Offset = "0xC8")]
		private string m_cachedTopicId;

		// Token: 0x0402326B RID: 143979
		[Token(Token = "0x402326B")]
		[FieldOffset(Offset = "0xD0")]
		private string m_cachedCurrMonthTeamId;

		// Token: 0x0402326C RID: 143980
		[Token(Token = "0x402326C")]
		[FieldOffset(Offset = "0xD8")]
		private UIItemCard m_itemCard;

		// Token: 0x0402326D RID: 143981
		[Token(Token = "0x402326D")]
		[FieldOffset(Offset = "0xE0")]
		private AutoPackSpriteHub m_charSpriteHub;

		// Token: 0x0402326E RID: 143982
		[Token(Token = "0x402326E")]
		[FieldOffset(Offset = "0xE8")]
		private Tween m_tween;

		// Token: 0x0402326F RID: 143983
		[Token(Token = "0x402326F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04023270 RID: 143984
		[Token(Token = "0x4023270")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x04023271 RID: 143985
		[Token(Token = "0x4023271")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateMonthSquadView;

		// Token: 0x04023272 RID: 143986
		[Token(Token = "0x4023272")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04023273 RID: 143987
		[Token(Token = "0x4023273")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderToggleGroup;

		// Token: 0x04023274 RID: 143988
		[Token(Token = "0x4023274")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__LoadRewardItemIcon;

		// Token: 0x04023275 RID: 143989
		[Token(Token = "0x4023275")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnOpenArchive;

		// Token: 0x04023276 RID: 143990
		[Token(Token = "0x4023276")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnOpenRewardDetail;

		// Token: 0x04023277 RID: 143991
		[Token(Token = "0x4023277")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnBtnLeftClicked;

		// Token: 0x04023278 RID: 143992
		[Token(Token = "0x4023278")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_EventOnBtnRightClicked;

		// Token: 0x04023279 RID: 143993
		[Token(Token = "0x4023279")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnBtnCharProtraitClicked;

		// Token: 0x0402327A RID: 143994
		[Token(Token = "0x402327A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
