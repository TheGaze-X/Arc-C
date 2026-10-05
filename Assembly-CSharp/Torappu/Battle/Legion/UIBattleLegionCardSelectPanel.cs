using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.Legion
{
	// Token: 0x02002A04 RID: 10756
	[Token(Token = "0x2002A04")]
	public class UIBattleLegionCardSelectPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x06011D83 RID: 73091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D83")]
		[Address(RVA = "0x9BA2C0", Offset = "0x9B8EC0", VA = "0x1809BA2C0")]
		public void Show(LegionUICardSelectState legionState)
		{
		}

		// Token: 0x06011D84 RID: 73092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D84")]
		[Address(RVA = "0x9B9E20", Offset = "0x9B8A20", VA = "0x1809B9E20")]
		public void Hide()
		{
		}

		// Token: 0x06011D85 RID: 73093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D85")]
		[Address(RVA = "0x9BA160", Offset = "0x9B8D60", VA = "0x1809BA160")]
		public void OnConfirmSelectClick()
		{
		}

		// Token: 0x06011D86 RID: 73094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D86")]
		[Address(RVA = "0x9B9F20", Offset = "0x9B8B20", VA = "0x1809B9F20")]
		public void OnCancelSelectClick()
		{
		}

		// Token: 0x06011D87 RID: 73095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D87")]
		[Address(RVA = "0x9BA260", Offset = "0x9B8E60", VA = "0x1809BA260")]
		public void OnDetailBgClick()
		{
		}

		// Token: 0x06011D88 RID: 73096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D88")]
		[Address(RVA = "0x9BB2C0", Offset = "0x9B9EC0", VA = "0x1809BB2C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06011D89 RID: 73097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D89")]
		[Address(RVA = "0x9BACC0", Offset = "0x9B98C0", VA = "0x1809BACC0")]
		private void _OnCancel()
		{
		}

		// Token: 0x06011D8A RID: 73098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D8A")]
		[Address(RVA = "0x9BBA00", Offset = "0x9BA600", VA = "0x1809BBA00")]
		private void _ShowCancelTips()
		{
		}

		// Token: 0x06011D8B RID: 73099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D8B")]
		[Address(RVA = "0x9BB740", Offset = "0x9BA340", VA = "0x1809BB740")]
		private void _SetSelectTips(bool isAllTrapCard, bool isAllCharCard, int canSelectNum, bool discard, LegionSelectCardType selectType)
		{
		}

		// Token: 0x06011D8C RID: 73100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D8C")]
		[Address(RVA = "0x9BB4A0", Offset = "0x9BA0A0", VA = "0x1809BB4A0")]
		private void _OnCardClick(uint cardId)
		{
		}

		// Token: 0x06011D8D RID: 73101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D8D")]
		[Address(RVA = "0x9BB600", Offset = "0x9BA200", VA = "0x1809BB600")]
		private void _OnShowTrapDetail(string desc, float posX)
		{
		}

		// Token: 0x06011D8E RID: 73102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D8E")]
		[Address(RVA = "0x9BAFA0", Offset = "0x9B9BA0", VA = "0x1809BAFA0")]
		private void _CalcSingleCardSelect(uint cardId)
		{
		}

		// Token: 0x06011D8F RID: 73103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D8F")]
		[Address(RVA = "0x9BAD60", Offset = "0x9B9960", VA = "0x1809BAD60")]
		private void _CalcMultiCardSelect(uint cardId)
		{
		}

		// Token: 0x06011D90 RID: 73104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011D90")]
		[Address(RVA = "0x9BB1B0", Offset = "0x9B9DB0", VA = "0x1809BB1B0")]
		private UICardLegionSelectItem.CardModel _GetCardModel(uint cardId)
		{
			return null;
		}

		// Token: 0x06011D91 RID: 73105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D91")]
		[Address(RVA = "0x9BBC10", Offset = "0x9BA810", VA = "0x1809BBC10")]
		private void _UpdateSelectingCount(int selectingCount)
		{
		}

		// Token: 0x06011D92 RID: 73106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D92")]
		[Address(RVA = "0x9BBD00", Offset = "0x9BA900", VA = "0x1809BBD00")]
		public UIBattleLegionCardSelectPanel()
		{
		}

		// Token: 0x040140D5 RID: 82133
		[Token(Token = "0x40140D5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _txtTopTips;

		// Token: 0x040140D6 RID: 82134
		[Token(Token = "0x40140D6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasImage _imgBgCenter;

		// Token: 0x040140D7 RID: 82135
		[Token(Token = "0x40140D7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _canvasBgCenter;

		// Token: 0x040140D8 RID: 82136
		[Token(Token = "0x40140D8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _colorBgDiscard;

		// Token: 0x040140D9 RID: 82137
		[Token(Token = "0x40140D9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _colorBgSelect;

		// Token: 0x040140DA RID: 82138
		[Token(Token = "0x40140DA")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Color _colorBgPurple;

		// Token: 0x040140DB RID: 82139
		[Token(Token = "0x40140DB")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private SimpleLayoutContent _cardList;

		// Token: 0x040140DC RID: 82140
		[Token(Token = "0x40140DC")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RectTransform _rectCancelBtn;

		// Token: 0x040140DD RID: 82141
		[Token(Token = "0x40140DD")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CanvasGroup _canvasCancelBtn;

		// Token: 0x040140DE RID: 82142
		[Token(Token = "0x40140DE")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ThreeStateToggle _confirmBtnToggle;

		// Token: 0x040140DF RID: 82143
		[Token(Token = "0x40140DF")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _rectConfirmBtn;

		// Token: 0x040140E0 RID: 82144
		[Token(Token = "0x40140E0")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RectTransform _rectConfirmDiscardBtn;

		// Token: 0x040140E1 RID: 82145
		[Token(Token = "0x40140E1")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private RectTransform _rectConfirmPurpleBtn;

		// Token: 0x040140E2 RID: 82146
		[Token(Token = "0x40140E2")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private CanvasGroup _canvasConfirmBtn;

		// Token: 0x040140E3 RID: 82147
		[Token(Token = "0x40140E3")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Button _confirmBtn;

		// Token: 0x040140E4 RID: 82148
		[Token(Token = "0x40140E4")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Button _confirmBtnRed;

		// Token: 0x040140E5 RID: 82149
		[Token(Token = "0x40140E5")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Button _confirmBtnPurple;

		// Token: 0x040140E6 RID: 82150
		[Token(Token = "0x40140E6")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Button _cancleBtn;

		// Token: 0x040140E7 RID: 82151
		[Token(Token = "0x40140E7")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private GameObject _objTrapDetail;

		// Token: 0x040140E8 RID: 82152
		[Token(Token = "0x40140E8")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Transform _transTrapDetail;

		// Token: 0x040140E9 RID: 82153
		[Token(Token = "0x40140E9")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private Text _textTrapDetail;

		// Token: 0x040140EA RID: 82154
		[Token(Token = "0x40140EA")]
		[FieldOffset(Offset = "0xD8")]
		private List<UICardLegionSelectItem.CardModel> m_cardList;

		// Token: 0x040140EB RID: 82155
		[Token(Token = "0x40140EB")]
		[FieldOffset(Offset = "0xE0")]
		private List<UICardLegionSelectItem> m_cardItemList;

		// Token: 0x040140EC RID: 82156
		[Token(Token = "0x40140EC")]
		[FieldOffset(Offset = "0xE8")]
		private UIBattleLegionCardSelectPanel.CardListAdapter m_cardListAdapter;

		// Token: 0x040140ED RID: 82157
		[Token(Token = "0x40140ED")]
		[FieldOffset(Offset = "0xF0")]
		private UIBattleLegionCardSelectPanel.CardSelectPanelShowTween m_CardSelectPanelShowTween;

		// Token: 0x040140EE RID: 82158
		[Token(Token = "0x40140EE")]
		[FieldOffset(Offset = "0xF8")]
		private LegionUICardSelectState m_legionState;

		// Token: 0x040140EF RID: 82159
		[Token(Token = "0x40140EF")]
		[FieldOffset(Offset = "0x100")]
		private List<uint> m_cardIdList;

		// Token: 0x040140F0 RID: 82160
		[Token(Token = "0x40140F0")]
		[FieldOffset(Offset = "0x108")]
		private List<uint> m_selectIdList;

		// Token: 0x040140F1 RID: 82161
		[Token(Token = "0x40140F1")]
		[FieldOffset(Offset = "0x110")]
		private bool m_isSingleChoose;

		// Token: 0x040140F2 RID: 82162
		[Token(Token = "0x40140F2")]
		[FieldOffset(Offset = "0x114")]
		private int m_canSelectNum;

		// Token: 0x040140F3 RID: 82163
		[Token(Token = "0x40140F3")]
		[FieldOffset(Offset = "0x118")]
		private bool m_hasInited;

		// Token: 0x040140F4 RID: 82164
		[Token(Token = "0x40140F4")]
		[FieldOffset(Offset = "0x120")]
		private CoroutineId m_coroutineEnterPanel;

		// Token: 0x040140F5 RID: 82165
		[Token(Token = "0x40140F5")]
		private const float ENTER_TWEEN_DELAY = 0.02f;

		// Token: 0x040140F6 RID: 82166
		[Token(Token = "0x40140F6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x040140F7 RID: 82167
		[Token(Token = "0x40140F7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x040140F8 RID: 82168
		[Token(Token = "0x40140F8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnConfirmSelectClick;

		// Token: 0x040140F9 RID: 82169
		[Token(Token = "0x40140F9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnCancelSelectClick;

		// Token: 0x040140FA RID: 82170
		[Token(Token = "0x40140FA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnDetailBgClick;

		// Token: 0x040140FB RID: 82171
		[Token(Token = "0x40140FB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040140FC RID: 82172
		[Token(Token = "0x40140FC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnCancel;

		// Token: 0x040140FD RID: 82173
		[Token(Token = "0x40140FD")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ShowCancelTips;

		// Token: 0x040140FE RID: 82174
		[Token(Token = "0x40140FE")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__SetSelectTips;

		// Token: 0x040140FF RID: 82175
		[Token(Token = "0x40140FF")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnCardClick;

		// Token: 0x04014100 RID: 82176
		[Token(Token = "0x4014100")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnShowTrapDetail;

		// Token: 0x04014101 RID: 82177
		[Token(Token = "0x4014101")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__CalcSingleCardSelect;

		// Token: 0x04014102 RID: 82178
		[Token(Token = "0x4014102")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__CalcMultiCardSelect;

		// Token: 0x04014103 RID: 82179
		[Token(Token = "0x4014103")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__GetCardModel;

		// Token: 0x04014104 RID: 82180
		[Token(Token = "0x4014104")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__UpdateSelectingCount;

		// Token: 0x04014105 RID: 82181
		[Token(Token = "0x4014105")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002A05 RID: 10757
		[Token(Token = "0x2002A05")]
		private class CardListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06011D94 RID: 73108 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011D94")]
			[Address(RVA = "0x9A89A0", Offset = "0x9A75A0", VA = "0x1809A89A0")]
			public CardListAdapter(UIBattleLegionCardSelectPanel closure)
			{
			}

			// Token: 0x1700274D RID: 10061
			// (get) Token: 0x06011D95 RID: 73109 RVA: 0x0006D368 File Offset: 0x0006B568
			[Token(Token = "0x1700274D")]
			public override int count
			{
				[Token(Token = "0x6011D95")]
				[Address(RVA = "0x9A8B20", Offset = "0x9A7720", VA = "0x1809A8B20", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06011D96 RID: 73110 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6011D96")]
			[Address(RVA = "0x9A8610", Offset = "0x9A7210", VA = "0x1809A8610", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04014106 RID: 82182
			[Token(Token = "0x4014106")]
			[FieldOffset(Offset = "0x20")]
			private UIBattleLegionCardSelectPanel m_closure;

			// Token: 0x04014107 RID: 82183
			[Token(Token = "0x4014107")]
			[FieldOffset(Offset = "0x28")]
			public Action<uint> OnCardClickEvent;

			// Token: 0x04014108 RID: 82184
			[Token(Token = "0x4014108")]
			[FieldOffset(Offset = "0x30")]
			public Action<string, float> OnShowTrapDetail;

			// Token: 0x04014109 RID: 82185
			[Token(Token = "0x4014109")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401410A RID: 82186
			[Token(Token = "0x401410A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401410B RID: 82187
			[Token(Token = "0x401410B")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x02002A06 RID: 10758
		[Token(Token = "0x2002A06")]
		private class CardSelectPanelShowTween : IHotfixable
		{
			// Token: 0x06011D97 RID: 73111 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011D97")]
			[Address(RVA = "0x9A9A40", Offset = "0x9A8640", VA = "0x1809A9A40")]
			public CardSelectPanelShowTween(UIBattleLegionCardSelectPanel closure)
			{
			}

			// Token: 0x06011D98 RID: 73112 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011D98")]
			[Address(RVA = "0x9A8BA0", Offset = "0x9A77A0", VA = "0x1809A8BA0")]
			public void PlayTween()
			{
			}

			// Token: 0x06011D99 RID: 73113 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011D99")]
			[Address(RVA = "0x9A98C0", Offset = "0x9A84C0", VA = "0x1809A98C0")]
			private void _AfterShowEffect()
			{
			}

			// Token: 0x06011D9A RID: 73114 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011D9A")]
			[Address(RVA = "0x9A97B0", Offset = "0x9A83B0", VA = "0x1809A97B0")]
			private void _AfterShowCards()
			{
			}

			// Token: 0x06011D9B RID: 73115 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011D9B")]
			[Address(RVA = "0x9A9250", Offset = "0x9A7E50", VA = "0x1809A9250")]
			public void ResetToState(bool isShow)
			{
			}

			// Token: 0x0401410C RID: 82188
			[Token(Token = "0x401410C")]
			[FieldOffset(Offset = "0x10")]
			private UIBattleLegionCardSelectPanel m_closure;

			// Token: 0x0401410D RID: 82189
			[Token(Token = "0x401410D")]
			[FieldOffset(Offset = "0x18")]
			private UISwitchTween.TweenWrapper m_tween;

			// Token: 0x0401410E RID: 82190
			[Token(Token = "0x401410E")]
			private const float ENTER_PANEL_DELAY = 0.5f;

			// Token: 0x0401410F RID: 82191
			[Token(Token = "0x401410F")]
			private const float CARD_SHOW_DUR = 0.14f;

			// Token: 0x04014110 RID: 82192
			[Token(Token = "0x4014110")]
			private const float CARD_SHOW_DELAY = 0.06f;

			// Token: 0x04014111 RID: 82193
			[Token(Token = "0x4014111")]
			private const float ENTER_BTN_DELAY = 0.1f;

			// Token: 0x04014112 RID: 82194
			[Token(Token = "0x4014112")]
			private const float ENTER_BTN_SHOW_DUR = 0.06f;

			// Token: 0x04014113 RID: 82195
			[Token(Token = "0x4014113")]
			private const float ENTER_BTN_MOVE_DUR = 0.2f;

			// Token: 0x04014114 RID: 82196
			[Token(Token = "0x4014114")]
			[FieldOffset(Offset = "0x0")]
			private static readonly Vector2 CARD_SHOW_START_POS;

			// Token: 0x04014115 RID: 82197
			[Token(Token = "0x4014115")]
			[FieldOffset(Offset = "0x8")]
			private static readonly Vector2 CARD_SHOW_END_POS;

			// Token: 0x04014116 RID: 82198
			[Token(Token = "0x4014116")]
			[FieldOffset(Offset = "0x10")]
			private static readonly Vector2 CANCEL_BTN_START_POS;

			// Token: 0x04014117 RID: 82199
			[Token(Token = "0x4014117")]
			[FieldOffset(Offset = "0x18")]
			private static readonly Vector2 CANCEL_BTN_END_POS;

			// Token: 0x04014118 RID: 82200
			[Token(Token = "0x4014118")]
			[FieldOffset(Offset = "0x20")]
			private static readonly Vector2 CONFIRM_BTN_START_POS;

			// Token: 0x04014119 RID: 82201
			[Token(Token = "0x4014119")]
			[FieldOffset(Offset = "0x28")]
			private static readonly Vector2 CONFIRM_BTN_END_POS;

			// Token: 0x0401411A RID: 82202
			[Token(Token = "0x401411A")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401411B RID: 82203
			[Token(Token = "0x401411B")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_PlayTween;

			// Token: 0x0401411C RID: 82204
			[Token(Token = "0x401411C")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0__AfterShowEffect;

			// Token: 0x0401411D RID: 82205
			[Token(Token = "0x401411D")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0__AfterShowCards;

			// Token: 0x0401411E RID: 82206
			[Token(Token = "0x401411E")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}
	}
}
