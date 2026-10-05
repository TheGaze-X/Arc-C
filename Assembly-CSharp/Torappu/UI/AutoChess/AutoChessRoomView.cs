using System;
using System.Collections.Generic;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x020062DB RID: 25307
	[Token(Token = "0x20062DB")]
	public class AutoChessRoomView : DataBinder<AutoChessRoomProperty>, IHotfixable
	{
		// Token: 0x060247BF RID: 149439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247BF")]
		[Address(RVA = "0x1F4DF40", Offset = "0x1F4CB40", VA = "0x181F4DF40")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060247C0 RID: 149440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247C0")]
		[Address(RVA = "0x1F4E440", Offset = "0x1F4D040", VA = "0x181F4E440")]
		private void _SetViewOrder(AutoChessRoomPlayerCardView view, int slotIdx)
		{
		}

		// Token: 0x060247C1 RID: 149441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247C1")]
		[Address(RVA = "0x1F4DD60", Offset = "0x1F4C960", VA = "0x181F4DD60")]
		private void _ApplyViewOrder()
		{
		}

		// Token: 0x060247C2 RID: 149442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247C2")]
		[Address(RVA = "0x1F4E590", Offset = "0x1F4D190", VA = "0x181F4E590")]
		private void _UpdateCardViews(AutoChessRoomViewModel model)
		{
		}

		// Token: 0x060247C3 RID: 149443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247C3")]
		[Address(RVA = "0x1F4DC80", Offset = "0x1F4C880", VA = "0x181F4DC80")]
		private void _ApplyReadyBtnState(AutoChessRoomViewModel.ReadyButtonState state)
		{
		}

		// Token: 0x060247C4 RID: 149444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247C4")]
		[Address(RVA = "0x1F4DBA0", Offset = "0x1F4C7A0", VA = "0x181F4DBA0")]
		private void _ApplyGroupModeToggle(AutoChessRoomViewModel model)
		{
		}

		// Token: 0x060247C5 RID: 149445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247C5")]
		[Address(RVA = "0x1F4D570", Offset = "0x1F4C170", VA = "0x181F4D570", Slot = "7")]
		public override void OnValueChanged(AutoChessRoomProperty property)
		{
		}

		// Token: 0x060247C6 RID: 149446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247C6")]
		[Address(RVA = "0x1F4E2D0", Offset = "0x1F4CED0", VA = "0x181F4E2D0")]
		private void _RenderMode(AutoChessRoomViewModel model)
		{
		}

		// Token: 0x060247C7 RID: 149447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60247C7")]
		[Address(RVA = "0x1F4DE90", Offset = "0x1F4CA90", VA = "0x181F4DE90")]
		private Tween _GenEntryTween()
		{
			return null;
		}

		// Token: 0x060247C8 RID: 149448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247C8")]
		[Address(RVA = "0x1F4DA60", Offset = "0x1F4C660", VA = "0x181F4DA60")]
		public void PlayEnterAnim()
		{
		}

		// Token: 0x060247C9 RID: 149449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247C9")]
		[Address(RVA = "0x1F4E950", Offset = "0x1F4D550", VA = "0x181F4E950")]
		public AutoChessRoomView()
		{
		}

		// Token: 0x04032D0C RID: 208140
		[Token(Token = "0x4032D0C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AutoChessRoomPlayerCardView _playerCardPrefab;

		// Token: 0x04032D0D RID: 208141
		[Token(Token = "0x4032D0D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _playerCardContainer;

		// Token: 0x04032D0E RID: 208142
		[Token(Token = "0x4032D0E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<AutoChessRoomView.ModeConfig> _modeConfigs;

		// Token: 0x04032D0F RID: 208143
		[Token(Token = "0x4032D0F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _roomIdText;

		// Token: 0x04032D10 RID: 208144
		[Token(Token = "0x4032D10")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TwoStateToggle _fullRoomToggle;

		// Token: 0x04032D11 RID: 208145
		[Token(Token = "0x4032D11")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _matchPlayerCntTipText;

		// Token: 0x04032D12 RID: 208146
		[Token(Token = "0x4032D12")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x04032D13 RID: 208147
		[Token(Token = "0x4032D13")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _accurateModeSwitchBtn;

		// Token: 0x04032D14 RID: 208148
		[Token(Token = "0x4032D14")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _roomIdObj;

		// Token: 0x04032D15 RID: 208149
		[Token(Token = "0x4032D15")]
		[FieldOffset(Offset = "0x70")]
		[Group("Ready Btn")]
		[SerializeField]
		private GameObject _readyBtnObj;

		// Token: 0x04032D16 RID: 208150
		[Token(Token = "0x4032D16")]
		[FieldOffset(Offset = "0x78")]
		[Group("Ready Btn")]
		[SerializeField]
		private GameObject _cancelReadyBtnObj;

		// Token: 0x04032D17 RID: 208151
		[Token(Token = "0x4032D17")]
		[FieldOffset(Offset = "0x80")]
		[Group("Ready Btn")]
		[SerializeField]
		private GameObject _unavailMatchObj;

		// Token: 0x04032D18 RID: 208152
		[Token(Token = "0x4032D18")]
		[FieldOffset(Offset = "0x88")]
		[Group("Ready Btn")]
		[SerializeField]
		private GameObject _startMatchObj;

		// Token: 0x04032D19 RID: 208153
		[Token(Token = "0x4032D19")]
		[FieldOffset(Offset = "0x90")]
		[Group("Ready Btn")]
		[SerializeField]
		private GameObject _unavailGameObj;

		// Token: 0x04032D1A RID: 208154
		[Token(Token = "0x4032D1A")]
		[FieldOffset(Offset = "0x98")]
		[Group("Ready Btn")]
		[SerializeField]
		private GameObject _startGameObj;

		// Token: 0x04032D1B RID: 208155
		[Token(Token = "0x4032D1B")]
		[FieldOffset(Offset = "0xA0")]
		[Group("Match state")]
		[SerializeField]
		private GameObject _disableMatchObj;

		// Token: 0x04032D1C RID: 208156
		[Token(Token = "0x4032D1C")]
		[FieldOffset(Offset = "0xA8")]
		[Group("Match state")]
		[SerializeField]
		private GameObject _matchWideObj;

		// Token: 0x04032D1D RID: 208157
		[Token(Token = "0x4032D1D")]
		[FieldOffset(Offset = "0xB0")]
		[Group("Match state")]
		[SerializeField]
		private GameObject _matchPreciseObj;

		// Token: 0x04032D1E RID: 208158
		[Token(Token = "0x4032D1E")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private AutoChessModeChoicePopView _modeChoicePopViewPrefab;

		// Token: 0x04032D1F RID: 208159
		[Token(Token = "0x4032D1F")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private RectTransform _modeChoicePopViewContainer;

		// Token: 0x04032D20 RID: 208160
		[Token(Token = "0x4032D20")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private CanvasGroup _rangeToggleCanvasGroup;

		// Token: 0x04032D21 RID: 208161
		[Token(Token = "0x4032D21")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private float _rangeToggleDisableAlpha;

		// Token: 0x04032D22 RID: 208162
		[Token(Token = "0x4032D22")]
		[FieldOffset(Offset = "0xD4")]
		private bool m_isInited;

		// Token: 0x04032D23 RID: 208163
		[Token(Token = "0x4032D23")]
		[FieldOffset(Offset = "0xD8")]
		private int m_playerCardViewCnt;

		// Token: 0x04032D24 RID: 208164
		[Token(Token = "0x4032D24")]
		[FieldOffset(Offset = "0xE0")]
		private List<AutoChessRoomPlayerCardView> m_playerCardViews;

		// Token: 0x04032D25 RID: 208165
		[Token(Token = "0x4032D25")]
		[FieldOffset(Offset = "0xE8")]
		private EnumIntDictionary<ActAutoChessModeDifficultyType, AutoChessRoomView.ModeConfig> m_modeConfigDict;

		// Token: 0x04032D26 RID: 208166
		[Token(Token = "0x4032D26")]
		[FieldOffset(Offset = "0xF0")]
		private AutoChessRoomPlayerCardView[] m_cardViewOrder;

		// Token: 0x04032D27 RID: 208167
		[Token(Token = "0x4032D27")]
		[FieldOffset(Offset = "0xF8")]
		private Tween m_enterTween;

		// Token: 0x04032D28 RID: 208168
		[Token(Token = "0x4032D28")]
		[FieldOffset(Offset = "0x100")]
		private AutoChessModeChoicePopView m_modeChoicePopView;

		// Token: 0x04032D29 RID: 208169
		[Token(Token = "0x4032D29")]
		[FieldOffset(Offset = "0x108")]
		private int m_enterModeChocieViewSeqNum;

		// Token: 0x04032D2A RID: 208170
		[Token(Token = "0x4032D2A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04032D2B RID: 208171
		[Token(Token = "0x4032D2B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__SetViewOrder;

		// Token: 0x04032D2C RID: 208172
		[Token(Token = "0x4032D2C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ApplyViewOrder;

		// Token: 0x04032D2D RID: 208173
		[Token(Token = "0x4032D2D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateCardViews;

		// Token: 0x04032D2E RID: 208174
		[Token(Token = "0x4032D2E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ApplyReadyBtnState;

		// Token: 0x04032D2F RID: 208175
		[Token(Token = "0x4032D2F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ApplyGroupModeToggle;

		// Token: 0x04032D30 RID: 208176
		[Token(Token = "0x4032D30")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04032D31 RID: 208177
		[Token(Token = "0x4032D31")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RenderMode;

		// Token: 0x04032D32 RID: 208178
		[Token(Token = "0x4032D32")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GenEntryTween;

		// Token: 0x04032D33 RID: 208179
		[Token(Token = "0x4032D33")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_PlayEnterAnim;

		// Token: 0x04032D34 RID: 208180
		[Token(Token = "0x4032D34")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020062DC RID: 25308
		[Token(Token = "0x20062DC")]
		[Serializable]
		private class ModeConfig
		{
			// Token: 0x060247CA RID: 149450 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60247CA")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ModeConfig()
			{
			}

			// Token: 0x04032D35 RID: 208181
			[Token(Token = "0x4032D35")]
			[FieldOffset(Offset = "0x10")]
			public ActAutoChessModeDifficultyType difficultyType;

			// Token: 0x04032D36 RID: 208182
			[Token(Token = "0x4032D36")]
			[FieldOffset(Offset = "0x18")]
			public GameObject container;

			// Token: 0x04032D37 RID: 208183
			[Token(Token = "0x4032D37")]
			[FieldOffset(Offset = "0x20")]
			public GameObject modeIconObj;

			// Token: 0x04032D38 RID: 208184
			[Token(Token = "0x4032D38")]
			[FieldOffset(Offset = "0x28")]
			public Text modeNameText;
		}
	}
}
