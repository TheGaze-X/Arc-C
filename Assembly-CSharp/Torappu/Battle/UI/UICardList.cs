using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x020032C0 RID: 12992
	[Token(Token = "0x20032C0")]
	public class UICardList : UIBehaviour, IHotfixable
	{
		// Token: 0x170030E5 RID: 12517
		// (get) Token: 0x06014A5A RID: 84570 RVA: 0x00087E40 File Offset: 0x00086040
		[Token(Token = "0x170030E5")]
		public int cardCnt
		{
			[Token(Token = "0x6014A5A")]
			[Address(RVA = "0xCE6210", Offset = "0xCE4E10", VA = "0x180CE6210")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170030E6 RID: 12518
		// (get) Token: 0x06014A5B RID: 84571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170030E6")]
		public UICard activeCard
		{
			[Token(Token = "0x6014A5B")]
			[Address(RVA = "0xCE61B0", Offset = "0xCE4DB0", VA = "0x180CE61B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170030E7 RID: 12519
		// (get) Token: 0x06014A5C RID: 84572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170030E7")]
		public ToggleGroup toggleGroup
		{
			[Token(Token = "0x6014A5C")]
			[Address(RVA = "0xCE63D0", Offset = "0xCE4FD0", VA = "0x180CE63D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170030E8 RID: 12520
		// (get) Token: 0x06014A5D RID: 84573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170030E8")]
		public UIFollower cardHighlighter
		{
			[Token(Token = "0x6014A5D")]
			[Address(RVA = "0xCE6290", Offset = "0xCE4E90", VA = "0x180CE6290")]
			get
			{
				return null;
			}
		}

		// Token: 0x170030E9 RID: 12521
		// (get) Token: 0x06014A5E RID: 84574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170030E9")]
		protected RectTransform layoutRectTransform
		{
			[Token(Token = "0x6014A5E")]
			[Address(RVA = "0xCE62F0", Offset = "0xCE4EF0", VA = "0x180CE62F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06014A5F RID: 84575 RVA: 0x00087E58 File Offset: 0x00086058
		[Token(Token = "0x6014A5F")]
		[Address(RVA = "0xCE3170", Offset = "0xCE1D70", VA = "0x180CE3170")]
		public bool TryGetCardScreenPos(int index, out Vector3 pos)
		{
			return default(bool);
		}

		// Token: 0x06014A60 RID: 84576 RVA: 0x00087E70 File Offset: 0x00086070
		[Token(Token = "0x6014A60")]
		[Address(RVA = "0xCE2EF0", Offset = "0xCE1AF0", VA = "0x180CE2EF0")]
		public bool TryGetCardScreenPosByUniqueId(uint cardUid, out Vector3 pos)
		{
			return default(bool);
		}

		// Token: 0x06014A61 RID: 84577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A61")]
		[Address(RVA = "0xCE28B0", Offset = "0xCE14B0", VA = "0x180CE28B0")]
		public void OnDrag(UICard uiCard, PointerEventData eventData)
		{
		}

		// Token: 0x06014A62 RID: 84578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A62")]
		[Address(RVA = "0xCE22D0", Offset = "0xCE0ED0", VA = "0x180CE22D0")]
		public void OnBeginDrag(UICard uiCard, PointerEventData eventData)
		{
		}

		// Token: 0x06014A63 RID: 84579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A63")]
		[Address(RVA = "0xCE2970", Offset = "0xCE1570", VA = "0x180CE2970")]
		public void OnEndDrag(UICard uiCard, PointerEventData eventData)
		{
		}

		// Token: 0x06014A64 RID: 84580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A64")]
		[Address(RVA = "0xCE2690", Offset = "0xCE1290", VA = "0x180CE2690")]
		public void OnCardToggled(UICard uiCard)
		{
		}

		// Token: 0x06014A65 RID: 84581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A65")]
		[Address(RVA = "0xCE25E0", Offset = "0xCE11E0", VA = "0x180CE25E0")]
		public void OnCardSelected(UICard uiCard)
		{
		}

		// Token: 0x06014A66 RID: 84582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A66")]
		[Address(RVA = "0xCE24E0", Offset = "0xCE10E0", VA = "0x180CE24E0")]
		public void OnCardHover(UICard uiCard, bool isHover)
		{
		}

		// Token: 0x06014A67 RID: 84583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A67")]
		[Address(RVA = "0xCE3480", Offset = "0xCE2080", VA = "0x180CE3480")]
		public void UpdateToggleGroup(bool isEnabled)
		{
		}

		// Token: 0x06014A68 RID: 84584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A68")]
		[Address(RVA = "0xCE33D0", Offset = "0xCE1FD0", VA = "0x180CE33D0")]
		public void UnSelectActiveCard()
		{
		}

		// Token: 0x06014A69 RID: 84585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A69")]
		[Address(RVA = "0xCE2B40", Offset = "0xCE1740", VA = "0x180CE2B40")]
		public void OnUpdate()
		{
		}

		// Token: 0x06014A6A RID: 84586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A6A")]
		[Address(RVA = "0xCE19E0", Offset = "0xCE05E0", VA = "0x180CE19E0")]
		public void AttachPlugin(UICard.IUICardPlugin pluginPrefabRef)
		{
		}

		// Token: 0x06014A6B RID: 84587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A6B")]
		[Address(RVA = "0xCE4620", Offset = "0xCE3220", VA = "0x180CE4620")]
		private void _OnCardRecycle(object cardObj)
		{
		}

		// Token: 0x06014A6C RID: 84588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A6C")]
		[Address(RVA = "0xCE1BF0", Offset = "0xCE07F0", VA = "0x180CE1BF0")]
		public void AttachTalentPlugin(UIPluginTalent.UnitTalentUIPlugin pluginPrefabRef, Character source, UIPluginTalent pluginTalent)
		{
		}

		// Token: 0x06014A6D RID: 84589 RVA: 0x00087E88 File Offset: 0x00086088
		[Token(Token = "0x6014A6D")]
		[Address(RVA = "0xCE2130", Offset = "0xCE0D30", VA = "0x180CE2130")]
		public bool HasTalentPlugin(string pluginId)
		{
			return default(bool);
		}

		// Token: 0x06014A6E RID: 84590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A6E")]
		[Address(RVA = "0xCE1FB0", Offset = "0xCE0BB0", VA = "0x180CE1FB0")]
		public void DetachTalentPlugin(UIPluginTalent.UnitTalentUIPlugin pluginPrefabRef)
		{
		}

		// Token: 0x06014A6F RID: 84591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A6F")]
		[Address(RVA = "0xCE5090", Offset = "0xCE3C90", VA = "0x180CE5090")]
		private void _RefreshCardList(IList<Deck.Card> cards)
		{
		}

		// Token: 0x06014A70 RID: 84592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A70")]
		[Address(RVA = "0xCE3FC0", Offset = "0xCE2BC0", VA = "0x180CE3FC0")]
		private void _OnBeforeCardlistRefresh(UICard card, Dictionary<uint, GameObject> cardAnimCache, Dictionary<uint, string> animKeyCache)
		{
		}

		// Token: 0x06014A71 RID: 84593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A71")]
		[Address(RVA = "0xCE5DA0", Offset = "0xCE49A0", VA = "0x180CE5DA0")]
		private void _RefreshCardPlugins()
		{
		}

		// Token: 0x06014A72 RID: 84594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A72")]
		[Address(RVA = "0xCE5E80", Offset = "0xCE4A80", VA = "0x180CE5E80")]
		private void _RefreshCardTweener(bool forceRebuild, bool isRefreshList)
		{
		}

		// Token: 0x06014A73 RID: 84595 RVA: 0x00087EA0 File Offset: 0x000860A0
		[Token(Token = "0x6014A73")]
		[Address(RVA = "0xCE2090", Offset = "0xCE0C90", VA = "0x180CE2090")]
		public int GetMaxVisibleCnt()
		{
			return 0;
		}

		// Token: 0x06014A74 RID: 84596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A74")]
		[Address(RVA = "0xCE4DD0", Offset = "0xCE39D0", VA = "0x180CE4DD0")]
		private void _RefreshCardCost(Deck.Card card)
		{
		}

		// Token: 0x06014A75 RID: 84597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A75")]
		[Address(RVA = "0xCE4F30", Offset = "0xCE3B30", VA = "0x180CE4F30")]
		private void _RefreshCardEffect(Deck.Card card)
		{
		}

		// Token: 0x06014A76 RID: 84598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A76")]
		[Address(RVA = "0xCE4C70", Offset = "0xCE3870", VA = "0x180CE4C70")]
		private void _RefreshCardAppearanceE(Deck.Card card)
		{
		}

		// Token: 0x06014A77 RID: 84599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A77")]
		[Address(RVA = "0xCE5F70", Offset = "0xCE4B70", VA = "0x180CE5F70")]
		private void _UpdateRectTransform()
		{
		}

		// Token: 0x06014A78 RID: 84600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A78")]
		[Address(RVA = "0xCE42D0", Offset = "0xCE2ED0", VA = "0x180CE42D0")]
		private void _OnBlinkCard(object arg)
		{
		}

		// Token: 0x06014A79 RID: 84601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A79")]
		[Address(RVA = "0xCE2470", Offset = "0xCE1070", VA = "0x180CE2470", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		// Token: 0x06014A7A RID: 84602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A7A")]
		[Address(RVA = "0xCE2A60", Offset = "0xCE1660", VA = "0x180CE2A60", Slot = "10")]
		protected override void OnRectTransformDimensionsChange()
		{
		}

		// Token: 0x06014A7B RID: 84603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A7B")]
		[Address(RVA = "0xCE2AD0", Offset = "0xCE16D0", VA = "0x180CE2AD0", Slot = "12")]
		protected override void OnTransformParentChanged()
		{
		}

		// Token: 0x06014A7C RID: 84604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A7C")]
		[Address(RVA = "0xCE1E60", Offset = "0xCE0A60", VA = "0x180CE1E60", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x06014A7D RID: 84605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A7D")]
		[Address(RVA = "0xCE2BB0", Offset = "0xCE17B0", VA = "0x180CE2BB0", Slot = "6")]
		protected override void Start()
		{
		}

		// Token: 0x06014A7E RID: 84606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A7E")]
		[Address(RVA = "0xCE27E0", Offset = "0xCE13E0", VA = "0x180CE27E0", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06014A7F RID: 84607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A7F")]
		[Address(RVA = "0xCE46E0", Offset = "0xCE32E0", VA = "0x180CE46E0")]
		private void _OnDeckCreated(object arg)
		{
		}

		// Token: 0x06014A80 RID: 84608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A80")]
		[Address(RVA = "0xCE3700", Offset = "0xCE2300", VA = "0x180CE3700")]
		private void _BindDeckEvents(Deck deck)
		{
		}

		// Token: 0x06014A81 RID: 84609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A81")]
		[Address(RVA = "0xCE3B70", Offset = "0xCE2770", VA = "0x180CE3B70")]
		private void _ClearDeckEvents(Deck deck)
		{
		}

		// Token: 0x06014A82 RID: 84610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A82")]
		[Address(RVA = "0xCE48B0", Offset = "0xCE34B0", VA = "0x180CE48B0")]
		private void _OnPlayCardAnim(Deck.Card card, string animName)
		{
		}

		// Token: 0x06014A83 RID: 84611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A83")]
		[Address(RVA = "0xCE60A0", Offset = "0xCE4CA0", VA = "0x180CE60A0")]
		public UICardList()
		{
		}

		// Token: 0x06014A84 RID: 84612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A84")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private void <>xLuaBaseProxy_OnCanvasHierarchyChanged()
		{
		}

		// Token: 0x06014A85 RID: 84613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A85")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private void <>xLuaBaseProxy_OnRectTransformDimensionsChange()
		{
		}

		// Token: 0x06014A86 RID: 84614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A86")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private void <>xLuaBaseProxy_OnTransformParentChanged()
		{
		}

		// Token: 0x06014A87 RID: 84615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A87")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private void <>xLuaBaseProxy_Awake()
		{
		}

		// Token: 0x06014A88 RID: 84616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A88")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private void <>xLuaBaseProxy_Start()
		{
		}

		// Token: 0x06014A89 RID: 84617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A89")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private void <>xLuaBaseProxy_OnDestroy()
		{
		}

		// Token: 0x04018792 RID: 100242
		[Token(Token = "0x4018792")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private EasyInstancePool _instancePool;

		// Token: 0x04018793 RID: 100243
		[Token(Token = "0x4018793")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ToggleGroup _toggleGroup;

		// Token: 0x04018794 RID: 100244
		[Token(Token = "0x4018794")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LayoutGroup _layoutGroup;

		// Token: 0x04018795 RID: 100245
		[Token(Token = "0x4018795")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIFollower _cardHighlighter;

		// Token: 0x04018796 RID: 100246
		[Token(Token = "0x4018796")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x04018797 RID: 100247
		[Token(Token = "0x4018797")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Vector2 _cardWidthRange;

		// Token: 0x04018798 RID: 100248
		[Token(Token = "0x4018798")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private EasyInstancePool _cardEffectHolderPool;

		// Token: 0x04018799 RID: 100249
		[Token(Token = "0x4018799")]
		[FieldOffset(Offset = "0x50")]
		private RectTransform m_layoutRectTransform;

		// Token: 0x0401879A RID: 100250
		[Token(Token = "0x401879A")]
		[FieldOffset(Offset = "0x58")]
		private UICard m_activeCard;

		// Token: 0x0401879B RID: 100251
		[Token(Token = "0x401879B")]
		[FieldOffset(Offset = "0x60")]
		private UICard m_hoverCard;

		// Token: 0x0401879C RID: 100252
		[Token(Token = "0x401879C")]
		[FieldOffset(Offset = "0x68")]
		private UICardList.CardListTweener m_cardTweener;

		// Token: 0x0401879D RID: 100253
		[Token(Token = "0x401879D")]
		[FieldOffset(Offset = "0x70")]
		private List<UICard.IUICardPlugin> m_pluginPrefabs;

		// Token: 0x0401879E RID: 100254
		[Token(Token = "0x401879E")]
		[FieldOffset(Offset = "0x78")]
		private Transform m_talentCardPluginRoot;

		// Token: 0x0401879F RID: 100255
		[Token(Token = "0x401879F")]
		[FieldOffset(Offset = "0x80")]
		private List<UICard> m_uiCards;

		// Token: 0x040187A0 RID: 100256
		[Token(Token = "0x40187A0")]
		private const float CARD_TOGGLE_WIDTH = 120f;

		// Token: 0x040187A1 RID: 100257
		[Token(Token = "0x40187A1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_cardCnt;

		// Token: 0x040187A2 RID: 100258
		[Token(Token = "0x40187A2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_activeCard;

		// Token: 0x040187A3 RID: 100259
		[Token(Token = "0x40187A3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_toggleGroup;

		// Token: 0x040187A4 RID: 100260
		[Token(Token = "0x40187A4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_cardHighlighter;

		// Token: 0x040187A5 RID: 100261
		[Token(Token = "0x40187A5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_layoutRectTransform;

		// Token: 0x040187A6 RID: 100262
		[Token(Token = "0x40187A6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_TryGetCardScreenPos;

		// Token: 0x040187A7 RID: 100263
		[Token(Token = "0x40187A7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_TryGetCardScreenPosByUniqueId;

		// Token: 0x040187A8 RID: 100264
		[Token(Token = "0x40187A8")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnDrag;

		// Token: 0x040187A9 RID: 100265
		[Token(Token = "0x40187A9")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnBeginDrag;

		// Token: 0x040187AA RID: 100266
		[Token(Token = "0x40187AA")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnEndDrag;

		// Token: 0x040187AB RID: 100267
		[Token(Token = "0x40187AB")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnCardToggled;

		// Token: 0x040187AC RID: 100268
		[Token(Token = "0x40187AC")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnCardSelected;

		// Token: 0x040187AD RID: 100269
		[Token(Token = "0x40187AD")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnCardHover;

		// Token: 0x040187AE RID: 100270
		[Token(Token = "0x40187AE")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_UpdateToggleGroup;

		// Token: 0x040187AF RID: 100271
		[Token(Token = "0x40187AF")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_UnSelectActiveCard;

		// Token: 0x040187B0 RID: 100272
		[Token(Token = "0x40187B0")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnUpdate;

		// Token: 0x040187B1 RID: 100273
		[Token(Token = "0x40187B1")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_AttachPlugin;

		// Token: 0x040187B2 RID: 100274
		[Token(Token = "0x40187B2")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__OnCardRecycle;

		// Token: 0x040187B3 RID: 100275
		[Token(Token = "0x40187B3")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_AttachTalentPlugin;

		// Token: 0x040187B4 RID: 100276
		[Token(Token = "0x40187B4")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_HasTalentPlugin;

		// Token: 0x040187B5 RID: 100277
		[Token(Token = "0x40187B5")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_DetachTalentPlugin;

		// Token: 0x040187B6 RID: 100278
		[Token(Token = "0x40187B6")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__RefreshCardList;

		// Token: 0x040187B7 RID: 100279
		[Token(Token = "0x40187B7")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__OnBeforeCardlistRefresh;

		// Token: 0x040187B8 RID: 100280
		[Token(Token = "0x40187B8")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__RefreshCardPlugins;

		// Token: 0x040187B9 RID: 100281
		[Token(Token = "0x40187B9")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__RefreshCardTweener;

		// Token: 0x040187BA RID: 100282
		[Token(Token = "0x40187BA")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_GetMaxVisibleCnt;

		// Token: 0x040187BB RID: 100283
		[Token(Token = "0x40187BB")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__RefreshCardCost;

		// Token: 0x040187BC RID: 100284
		[Token(Token = "0x40187BC")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__RefreshCardEffect;

		// Token: 0x040187BD RID: 100285
		[Token(Token = "0x40187BD")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__RefreshCardAppearanceE;

		// Token: 0x040187BE RID: 100286
		[Token(Token = "0x40187BE")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__UpdateRectTransform;

		// Token: 0x040187BF RID: 100287
		[Token(Token = "0x40187BF")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__OnBlinkCard;

		// Token: 0x040187C0 RID: 100288
		[Token(Token = "0x40187C0")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_OnCanvasHierarchyChanged;

		// Token: 0x040187C1 RID: 100289
		[Token(Token = "0x40187C1")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_OnRectTransformDimensionsChange;

		// Token: 0x040187C2 RID: 100290
		[Token(Token = "0x40187C2")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_OnTransformParentChanged;

		// Token: 0x040187C3 RID: 100291
		[Token(Token = "0x40187C3")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x040187C4 RID: 100292
		[Token(Token = "0x40187C4")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x040187C5 RID: 100293
		[Token(Token = "0x40187C5")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x040187C6 RID: 100294
		[Token(Token = "0x40187C6")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__OnDeckCreated;

		// Token: 0x040187C7 RID: 100295
		[Token(Token = "0x40187C7")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__BindDeckEvents;

		// Token: 0x040187C8 RID: 100296
		[Token(Token = "0x40187C8")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0__ClearDeckEvents;

		// Token: 0x040187C9 RID: 100297
		[Token(Token = "0x40187C9")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0__OnPlayCardAnim;

		// Token: 0x040187CA RID: 100298
		[Token(Token = "0x40187CA")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020032C1 RID: 12993
		[Token(Token = "0x20032C1")]
		private class CardListTweener
		{
			// Token: 0x170030EA RID: 12522
			// (get) Token: 0x06014A8A RID: 84618 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170030EA")]
			protected List<UICard> cards
			{
				[Token(Token = "0x6014A8A")]
				[Address(RVA = "0xCE05E0", Offset = "0xCDF1E0", VA = "0x180CE05E0")]
				get
				{
					return null;
				}
			}

			// Token: 0x06014A8B RID: 84619 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014A8B")]
			[Address(RVA = "0xCE0490", Offset = "0xCDF090", VA = "0x180CE0490")]
			public CardListTweener(UICardList cardList, Vector2 sizeRange)
			{
			}

			// Token: 0x06014A8C RID: 84620 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014A8C")]
			[Address(RVA = "0xCDF6C0", Offset = "0xCDE2C0", VA = "0x180CDF6C0")]
			public void OnUpdate()
			{
			}

			// Token: 0x06014A8D RID: 84621 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014A8D")]
			[Address(RVA = "0xCDF5F0", Offset = "0xCDE1F0", VA = "0x180CDF5F0")]
			public void OnPossibleTotalSizeChange()
			{
			}

			// Token: 0x06014A8E RID: 84622 RVA: 0x00087EB8 File Offset: 0x000860B8
			[Token(Token = "0x6014A8E")]
			[Address(RVA = "0xCDF8A0", Offset = "0xCDE4A0", VA = "0x180CDF8A0")]
			public bool TryRefreshCards(int focusIndex, bool forceRebuild, bool isRefreshList)
			{
				return default(bool);
			}

			// Token: 0x06014A8F RID: 84623 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014A8F")]
			[Address(RVA = "0xCDFAF0", Offset = "0xCDE6F0", VA = "0x180CDFAF0")]
			private void _CalculateTargetSizes(int cardCnt)
			{
			}

			// Token: 0x06014A90 RID: 84624 RVA: 0x00087ED0 File Offset: 0x000860D0
			[Token(Token = "0x6014A90")]
			[Address(RVA = "0xCE0010", Offset = "0xCDEC10", VA = "0x180CE0010")]
			private bool _CheckUnchanged()
			{
				return default(bool);
			}

			// Token: 0x06014A91 RID: 84625 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014A91")]
			[Address(RVA = "0xCE0110", Offset = "0xCDED10", VA = "0x180CE0110")]
			private void _DoApplyChanges(bool isRefreshList)
			{
			}

			// Token: 0x040187CB RID: 100299
			[Token(Token = "0x40187CB")]
			private const float TWEEN_STOP_EPS = 0.01f;

			// Token: 0x040187CC RID: 100300
			[Token(Token = "0x40187CC")]
			private const float TWEEN_FRAME_STEP = 0.33333334f;

			// Token: 0x040187CD RID: 100301
			[Token(Token = "0x40187CD")]
			[FieldOffset(Offset = "0x10")]
			private UICardList m_cardList;

			// Token: 0x040187CE RID: 100302
			[Token(Token = "0x40187CE")]
			[FieldOffset(Offset = "0x18")]
			private Vector2 m_sizeRange;

			// Token: 0x040187CF RID: 100303
			[Token(Token = "0x40187CF")]
			[FieldOffset(Offset = "0x20")]
			private int m_focusIndex;

			// Token: 0x040187D0 RID: 100304
			[Token(Token = "0x40187D0")]
			[FieldOffset(Offset = "0x28")]
			private List<float> m_curSizes;

			// Token: 0x040187D1 RID: 100305
			[Token(Token = "0x40187D1")]
			[FieldOffset(Offset = "0x30")]
			private List<float> m_targetSizes;

			// Token: 0x040187D2 RID: 100306
			[Token(Token = "0x40187D2")]
			[FieldOffset(Offset = "0x38")]
			private bool m_tweening;

			// Token: 0x040187D3 RID: 100307
			[Token(Token = "0x40187D3")]
			[FieldOffset(Offset = "0x3C")]
			private float m_cachedTotalSize;
		}

		// Token: 0x020032C2 RID: 12994
		[Token(Token = "0x20032C2")]
		private enum DragMode
		{
			// Token: 0x040187D5 RID: 100309
			[Token(Token = "0x40187D5")]
			NONE,
			// Token: 0x040187D6 RID: 100310
			[Token(Token = "0x40187D6")]
			VERTICAL,
			// Token: 0x040187D7 RID: 100311
			[Token(Token = "0x40187D7")]
			HORIZONTAL
		}
	}
}
