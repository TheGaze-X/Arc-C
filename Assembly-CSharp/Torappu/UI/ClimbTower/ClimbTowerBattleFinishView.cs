using System;
using System.Collections;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.AVG;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005DD9 RID: 24025
	[Token(Token = "0x2005DD9")]
	public class ClimbTowerBattleFinishView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06022CD4 RID: 142548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022CD4")]
		[Address(RVA = "0x1D50510", Offset = "0x1D4F110", VA = "0x181D50510")]
		public void Render(ClimbTowerBattleFinishViewModel viewModel)
		{
		}

		// Token: 0x06022CD5 RID: 142549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022CD5")]
		[Address(RVA = "0x1D510A0", Offset = "0x1D4FCA0", VA = "0x181D510A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06022CD6 RID: 142550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022CD6")]
		[Address(RVA = "0x1D51810", Offset = "0x1D50410", VA = "0x181D51810")]
		private void _RetTweenElementsToBegin()
		{
		}

		// Token: 0x06022CD7 RID: 142551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022CD7")]
		[Address(RVA = "0x1D51360", Offset = "0x1D4FF60", VA = "0x181D51360")]
		private void _RenderIllust(string showInstId, bool isHardStage)
		{
		}

		// Token: 0x06022CD8 RID: 142552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022CD8")]
		[Address(RVA = "0x1D518D0", Offset = "0x1D504D0", VA = "0x181D518D0")]
		private IEnumerator _ShowPanelAnim()
		{
			return null;
		}

		// Token: 0x06022CD9 RID: 142553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022CD9")]
		[Address(RVA = "0x1D512A0", Offset = "0x1D4FEA0", VA = "0x181D512A0")]
		private IEnumerator _PlayPanelPopUpSound(int count)
		{
			return null;
		}

		// Token: 0x06022CDA RID: 142554 RVA: 0x000BEF08 File Offset: 0x000BD108
		[Token(Token = "0x6022CDA")]
		[Address(RVA = "0x1D51010", Offset = "0x1D4FC10", VA = "0x181D51010")]
		private CharWordShowType _GetCompleteProperVoiceShowType(bool isHardStage)
		{
			return CharWordShowType.HOME_SHOW;
		}

		// Token: 0x06022CDB RID: 142555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022CDB")]
		[Address(RVA = "0x1D50470", Offset = "0x1D4F070", VA = "0x181D50470")]
		public void EventOnViewClicked()
		{
		}

		// Token: 0x06022CDC RID: 142556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022CDC")]
		[Address(RVA = "0x1D519F0", Offset = "0x1D505F0", VA = "0x181D519F0")]
		public ClimbTowerBattleFinishView()
		{
		}

		// Token: 0x0402FE32 RID: 196146
		[Token(Token = "0x402FE32")]
		private const string TOTAL_LAYER_FORMAT = "/{0}";

		// Token: 0x0402FE33 RID: 196147
		[Token(Token = "0x402FE33")]
		private const string ITEM_GAIN_COUNT_FORMAT = "+{0}";

		// Token: 0x0402FE34 RID: 196148
		[Token(Token = "0x402FE34")]
		private const string NEW_RECORD_IMG_PREFIX = "img_new_record{0}";

		// Token: 0x0402FE35 RID: 196149
		[Token(Token = "0x402FE35")]
		private const int TWEEN_WIDTH_OFFSET = 192;

		// Token: 0x0402FE36 RID: 196150
		[Token(Token = "0x402FE36")]
		private const float TWEEN_MOVE_DURATION = 0.383f;

		// Token: 0x0402FE37 RID: 196151
		[Token(Token = "0x402FE37")]
		private const float TWEEN_MOVE_INTERVAL = 0.233f;

		// Token: 0x0402FE38 RID: 196152
		[Token(Token = "0x402FE38")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color ITEM_GAIN_TEXT_DEFAULT_COLOR;

		// Token: 0x0402FE39 RID: 196153
		[Token(Token = "0x402FE39")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Color ITEM_GAIN_TEXT_ZERO_COLOR;

		// Token: 0x0402FE3A RID: 196154
		[Token(Token = "0x402FE3A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIFullScreenImage _fullScreenImage;

		// Token: 0x0402FE3B RID: 196155
		[Token(Token = "0x402FE3B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _illustContainer;

		// Token: 0x0402FE3C RID: 196156
		[Token(Token = "0x402FE3C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AVGTypeWriterText _illustText;

		// Token: 0x0402FE3D RID: 196157
		[Token(Token = "0x402FE3D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelIllustText;

		// Token: 0x0402FE3E RID: 196158
		[Token(Token = "0x402FE3E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _txtBattleName;

		// Token: 0x0402FE3F RID: 196159
		[Token(Token = "0x402FE3F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAtlasObject _atlas;

		// Token: 0x0402FE40 RID: 196160
		[Token(Token = "0x402FE40")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Tower Status")]
		private Image _imgTowerLogo;

		// Token: 0x0402FE41 RID: 196161
		[Token(Token = "0x402FE41")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Tower Status")]
		private Text _txtTowerName;

		// Token: 0x0402FE42 RID: 196162
		[Token(Token = "0x402FE42")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Tower Status")]
		private Text _txtTowerSubName;

		// Token: 0x0402FE43 RID: 196163
		[Token(Token = "0x402FE43")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Tower Status")]
		private Text _txtCurProcess;

		// Token: 0x0402FE44 RID: 196164
		[Token(Token = "0x402FE44")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Tower Status")]
		private Text _txtTotalProcess;

		// Token: 0x0402FE45 RID: 196165
		[Token(Token = "0x402FE45")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Tower Status")]
		private GameObject _panelNewRecord;

		// Token: 0x0402FE46 RID: 196166
		[Token(Token = "0x402FE46")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Tower Status")]
		private UIAtlasImage _imgNewRecord;

		// Token: 0x0402FE47 RID: 196167
		[Token(Token = "0x402FE47")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Tower Status")]
		private GameObject _objHardTag;

		// Token: 0x0402FE48 RID: 196168
		[Token(Token = "0x402FE48")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Unit")]
		private GameObject _panelUnit;

		// Token: 0x0402FE49 RID: 196169
		[Token(Token = "0x402FE49")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Unit")]
		private SimpleLayoutContent _unitLayoutContent;

		// Token: 0x0402FE4A RID: 196170
		[Token(Token = "0x402FE4A")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Tween")]
		private RectTransform _transformPanelStatus;

		// Token: 0x0402FE4B RID: 196171
		[Token(Token = "0x402FE4B")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Tween")]
		private CanvasGroup _canvasGroupPanelStatus;

		// Token: 0x0402FE4C RID: 196172
		[Token(Token = "0x402FE4C")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Tween")]
		private RectTransform _transformPanelUnit;

		// Token: 0x0402FE4D RID: 196173
		[Token(Token = "0x402FE4D")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Tween")]
		private CanvasGroup _canvasGroupPanelUnit;

		// Token: 0x0402FE4E RID: 196174
		[Token(Token = "0x402FE4E")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Tween")]
		private RectTransform _transformPanelReward;

		// Token: 0x0402FE4F RID: 196175
		[Token(Token = "0x402FE4F")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Tween")]
		private CanvasGroup _canvasGroupPanelReward;

		// Token: 0x0402FE50 RID: 196176
		[Token(Token = "0x402FE50")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Items")]
		private Image _iconLowerItem;

		// Token: 0x0402FE51 RID: 196177
		[Token(Token = "0x402FE51")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("Items")]
		private Image _iconHigherItem;

		// Token: 0x0402FE52 RID: 196178
		[Token(Token = "0x402FE52")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("Items")]
		private Text _textLowerItemName;

		// Token: 0x0402FE53 RID: 196179
		[Token(Token = "0x402FE53")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Group("Items")]
		private Text _textHigherItemName;

		// Token: 0x0402FE54 RID: 196180
		[Token(Token = "0x402FE54")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[Group("Items")]
		private UISingleValueChangeBar _barLowerItem;

		// Token: 0x0402FE55 RID: 196181
		[Token(Token = "0x402FE55")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[Group("Items")]
		private UISingleValueChangeBar _barHigherItem;

		// Token: 0x0402FE56 RID: 196182
		[Token(Token = "0x402FE56")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[Group("Items")]
		private GameObject _iconLowerItemMax;

		// Token: 0x0402FE57 RID: 196183
		[Token(Token = "0x402FE57")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		[Group("Items")]
		private GameObject _iconHigherItemMax;

		// Token: 0x0402FE58 RID: 196184
		[Token(Token = "0x402FE58")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		[Group("Items")]
		private Text _textLowerItemGain;

		// Token: 0x0402FE59 RID: 196185
		[Token(Token = "0x402FE59")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		[Group("Items")]
		private Text _textHigherItemGain;

		// Token: 0x0402FE5A RID: 196186
		[Token(Token = "0x402FE5A")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		[Group("Items")]
		private CanvasGroup _canvasLowerItemGain;

		// Token: 0x0402FE5B RID: 196187
		[Token(Token = "0x402FE5B")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		[Group("Items")]
		private CanvasGroup _canvasHigherItemGain;

		// Token: 0x0402FE5C RID: 196188
		[Token(Token = "0x402FE5C")]
		[FieldOffset(Offset = "0x128")]
		private bool m_inited;

		// Token: 0x0402FE5D RID: 196189
		[Token(Token = "0x402FE5D")]
		[FieldOffset(Offset = "0x130")]
		private ClimbTowerBattleFinishView.Adapter m_adapter;

		// Token: 0x0402FE5E RID: 196190
		[Token(Token = "0x402FE5E")]
		[FieldOffset(Offset = "0x138")]
		private UICharacterIllust m_illust;

		// Token: 0x0402FE5F RID: 196191
		[Token(Token = "0x402FE5F")]
		[FieldOffset(Offset = "0x140")]
		private bool m_needPanelUnit;

		// Token: 0x0402FE60 RID: 196192
		[Token(Token = "0x402FE60")]
		[FieldOffset(Offset = "0x141")]
		private bool m_hasPlayedAnim;

		// Token: 0x0402FE61 RID: 196193
		[Token(Token = "0x402FE61")]
		[FieldOffset(Offset = "0x142")]
		private bool m_isLowerItemMax;

		// Token: 0x0402FE62 RID: 196194
		[Token(Token = "0x402FE62")]
		[FieldOffset(Offset = "0x143")]
		private bool m_isHigherItemMax;

		// Token: 0x0402FE63 RID: 196195
		[Token(Token = "0x402FE63")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402FE64 RID: 196196
		[Token(Token = "0x402FE64")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402FE65 RID: 196197
		[Token(Token = "0x402FE65")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RetTweenElementsToBegin;

		// Token: 0x0402FE66 RID: 196198
		[Token(Token = "0x402FE66")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RenderIllust;

		// Token: 0x0402FE67 RID: 196199
		[Token(Token = "0x402FE67")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ShowPanelAnim;

		// Token: 0x0402FE68 RID: 196200
		[Token(Token = "0x402FE68")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__PlayPanelPopUpSound;

		// Token: 0x0402FE69 RID: 196201
		[Token(Token = "0x402FE69")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__GetCompleteProperVoiceShowType;

		// Token: 0x0402FE6A RID: 196202
		[Token(Token = "0x402FE6A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_EventOnViewClicked;

		// Token: 0x0402FE6B RID: 196203
		[Token(Token = "0x402FE6B")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005DDA RID: 24026
		[Token(Token = "0x2005DDA")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x1700523C RID: 21052
			// (get) Token: 0x06022CE2 RID: 142562 RVA: 0x000BEF20 File Offset: 0x000BD120
			[Token(Token = "0x1700523C")]
			public override int count
			{
				[Token(Token = "0x6022CE2")]
				[Address(RVA = "0x1D498A0", Offset = "0x1D484A0", VA = "0x181D498A0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06022CE3 RID: 142563 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6022CE3")]
			[Address(RVA = "0x1D49590", Offset = "0x1D48190", VA = "0x181D49590", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06022CE4 RID: 142564 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022CE4")]
			[Address(RVA = "0x1D497C0", Offset = "0x1D483C0", VA = "0x181D497C0")]
			public Adapter()
			{
			}

			// Token: 0x0402FE6C RID: 196204
			[Token(Token = "0x402FE6C")]
			[FieldOffset(Offset = "0x20")]
			public ClimbTowerBattleFinishViewModel viewModel;

			// Token: 0x0402FE6D RID: 196205
			[Token(Token = "0x402FE6D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402FE6E RID: 196206
			[Token(Token = "0x402FE6E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0402FE6F RID: 196207
			[Token(Token = "0x402FE6F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
