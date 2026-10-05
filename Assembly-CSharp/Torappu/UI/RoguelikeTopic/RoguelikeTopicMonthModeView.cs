using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI.RoguelikeTopic.Mode;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x020044D9 RID: 17625
	[Token(Token = "0x20044D9")]
	public class RoguelikeTopicMonthModeView : RoguelikeTopicSubView
	{
		// Token: 0x0601AE97 RID: 110231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE97")]
		[Address(RVA = "0x140F460", Offset = "0x140E060", VA = "0x18140F460")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601AE98 RID: 110232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE98")]
		[Address(RVA = "0x140F3B0", Offset = "0x140DFB0", VA = "0x18140F3B0", Slot = "7")]
		public override void OnValueChanged(RoguelikeTopicModeViewProperty property)
		{
		}

		// Token: 0x0601AE99 RID: 110233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE99")]
		[Address(RVA = "0x140FB00", Offset = "0x140E700", VA = "0x18140FB00")]
		public void _Render(RoguelikeTopicModeViewModel model)
		{
		}

		// Token: 0x0601AE9A RID: 110234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE9A")]
		[Address(RVA = "0x140F8F0", Offset = "0x140E4F0", VA = "0x18140F8F0")]
		private void _RenderToggleGroup(RoguelikeTopicMonthSquadViewModel monthSquadGroup)
		{
		}

		// Token: 0x0601AE9B RID: 110235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE9B")]
		[Address(RVA = "0x140F620", Offset = "0x140E220", VA = "0x18140F620")]
		private void _LoadRewardItemIcon(ItemBundle itemData)
		{
		}

		// Token: 0x0601AE9C RID: 110236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE9C")]
		[Address(RVA = "0x140F140", Offset = "0x140DD40", VA = "0x18140F140")]
		public void EventOnOpenArchive()
		{
		}

		// Token: 0x0601AE9D RID: 110237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE9D")]
		[Address(RVA = "0x140F320", Offset = "0x140DF20", VA = "0x18140F320")]
		public void EventOnOpenRewardDetail()
		{
		}

		// Token: 0x0601AE9E RID: 110238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE9E")]
		[Address(RVA = "0x140F020", Offset = "0x140DC20", VA = "0x18140F020")]
		public void EventOnBtnLeftClicked()
		{
		}

		// Token: 0x0601AE9F RID: 110239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE9F")]
		[Address(RVA = "0x140F0B0", Offset = "0x140DCB0", VA = "0x18140F0B0")]
		public void EventOnBtnRightClicked()
		{
		}

		// Token: 0x0601AEA0 RID: 110240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AEA0")]
		[Address(RVA = "0x1410460", Offset = "0x140F060", VA = "0x181410460")]
		public RoguelikeTopicMonthModeView()
		{
		}

		// Token: 0x0601AEA1 RID: 110241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AEA1")]
		[Address(RVA = "0x1406270", Offset = "0x1404E70", VA = "0x181406270")]
		private void <>xLuaBaseProxy_OnValueChanged(RoguelikeTopicModeViewProperty P0)
		{
		}

		// Token: 0x040227D4 RID: 141268
		[Token(Token = "0x40227D4")]
		private const int CHAR_PORTRAIT_COUNT = 3;

		// Token: 0x040227D5 RID: 141269
		[Token(Token = "0x40227D5")]
		private const float ITEM_CARD_SCALE = 0.38f;

		// Token: 0x040227D6 RID: 141270
		[Token(Token = "0x40227D6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textYear;

		// Token: 0x040227D7 RID: 141271
		[Token(Token = "0x40227D7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textMonth;

		// Token: 0x040227D8 RID: 141272
		[Token(Token = "0x40227D8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textName;

		// Token: 0x040227D9 RID: 141273
		[Token(Token = "0x40227D9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _bkgName;

		// Token: 0x040227DA RID: 141274
		[Token(Token = "0x40227DA")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x040227DB RID: 141275
		[Token(Token = "0x40227DB")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _bkgArchive;

		// Token: 0x040227DC RID: 141276
		[Token(Token = "0x40227DC")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _bkgAward;

		// Token: 0x040227DD RID: 141277
		[Token(Token = "0x40227DD")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Button _btnLeft;

		// Token: 0x040227DE RID: 141278
		[Token(Token = "0x40227DE")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Button _btnRight;

		// Token: 0x040227DF RID: 141279
		[Token(Token = "0x40227DF")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAtlasImage _monthBack;

		// Token: 0x040227E0 RID: 141280
		[Token(Token = "0x40227E0")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private EasyInstancePool _togglePool;

		// Token: 0x040227E1 RID: 141281
		[Token(Token = "0x40227E1")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Reward")]
		private GameObject _pnlAwardReceived;

		// Token: 0x040227E2 RID: 141282
		[Token(Token = "0x40227E2")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Reward")]
		private GameObject _pnlAwardNotReceived;

		// Token: 0x040227E3 RID: 141283
		[Token(Token = "0x40227E3")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Reward")]
		private Image _imgIconBp;

		// Token: 0x040227E4 RID: 141284
		[Token(Token = "0x40227E4")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Reward")]
		private RectTransform _itemIconHolder;

		// Token: 0x040227E5 RID: 141285
		[Token(Token = "0x40227E5")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Reward")]
		private GameObject _pnlMore;

		// Token: 0x040227E6 RID: 141286
		[Token(Token = "0x40227E6")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private RoguelikeTopicMonthSquadCharPortraitView _charPortraitPrefab;

		// Token: 0x040227E7 RID: 141287
		[Token(Token = "0x40227E7")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private RectTransform[] _charPortraitViewHolders;

		// Token: 0x040227E8 RID: 141288
		[Token(Token = "0x40227E8")]
		[FieldOffset(Offset = "0xB8")]
		private RoguelikeTopicMonthSquadCharPortraitView[] m_charPortraitViews;

		// Token: 0x040227E9 RID: 141289
		[Token(Token = "0x40227E9")]
		[FieldOffset(Offset = "0xC0")]
		private UIItemCard m_itemCard;

		// Token: 0x040227EA RID: 141290
		[Token(Token = "0x40227EA")]
		[FieldOffset(Offset = "0xC8")]
		private string m_cachedTopicId;

		// Token: 0x040227EB RID: 141291
		[Token(Token = "0x40227EB")]
		[FieldOffset(Offset = "0xD0")]
		private string m_cachedCurrMonthTeamId;

		// Token: 0x040227EC RID: 141292
		[Token(Token = "0x40227EC")]
		[FieldOffset(Offset = "0xD8")]
		private RoguelikeTopicMonthSquadModel m_cachedMonthSquadModel;

		// Token: 0x040227ED RID: 141293
		[Token(Token = "0x40227ED")]
		[FieldOffset(Offset = "0xE0")]
		private bool m_hasInited;

		// Token: 0x040227EE RID: 141294
		[Token(Token = "0x40227EE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040227EF RID: 141295
		[Token(Token = "0x40227EF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040227F0 RID: 141296
		[Token(Token = "0x40227F0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x040227F1 RID: 141297
		[Token(Token = "0x40227F1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderToggleGroup;

		// Token: 0x040227F2 RID: 141298
		[Token(Token = "0x40227F2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__LoadRewardItemIcon;

		// Token: 0x040227F3 RID: 141299
		[Token(Token = "0x40227F3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnOpenArchive;

		// Token: 0x040227F4 RID: 141300
		[Token(Token = "0x40227F4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnOpenRewardDetail;

		// Token: 0x040227F5 RID: 141301
		[Token(Token = "0x40227F5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnBtnLeftClicked;

		// Token: 0x040227F6 RID: 141302
		[Token(Token = "0x40227F6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnBtnRightClicked;

		// Token: 0x040227F7 RID: 141303
		[Token(Token = "0x40227F7")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
