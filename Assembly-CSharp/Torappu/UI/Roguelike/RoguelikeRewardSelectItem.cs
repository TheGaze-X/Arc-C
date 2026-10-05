using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.RoguelikeTopic;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020053FB RID: 21499
	[Token(Token = "0x20053FB")]
	public class RoguelikeRewardSelectItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004A19 RID: 18969
		// (get) Token: 0x0601FA1A RID: 129562 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601FA1B RID: 129563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004A19")]
		[HideInInspector]
		public RoguelikeRewardStyle uiStyle
		{
			[Token(Token = "0x601FA1A")]
			[Address(RVA = "0x195F8A0", Offset = "0x195E4A0", VA = "0x18195F8A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601FA1B")]
			[Address(RVA = "0x195F900", Offset = "0x195E500", VA = "0x18195F900")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601FA1C RID: 129564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FA1C")]
		[Address(RVA = "0x195E1A0", Offset = "0x195CDA0", VA = "0x18195E1A0")]
		public void OnClick()
		{
		}

		// Token: 0x0601FA1D RID: 129565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FA1D")]
		[Address(RVA = "0x195E240", Offset = "0x195CE40", VA = "0x18195E240")]
		public void RenderCard(RoguelikeSortItemViewStruct viewStruct)
		{
		}

		// Token: 0x0601FA1E RID: 129566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FA1E")]
		[Address(RVA = "0x195E8D0", Offset = "0x195D4D0", VA = "0x18195E8D0")]
		private void _SetCommonItemInfo(string topicId, RoguelikeRewardShowType rewardShowType, RoguelikeTopicItemModel itemData)
		{
		}

		// Token: 0x0601FA1F RID: 129567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FA1F")]
		[Address(RVA = "0x195E800", Offset = "0x195D400", VA = "0x18195E800")]
		private void _SetClickable(bool canClick)
		{
		}

		// Token: 0x0601FA20 RID: 129568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FA20")]
		[Address(RVA = "0x195F490", Offset = "0x195E090", VA = "0x18195F490")]
		private void _SetStyle(RoguelikeGameItemType type, RoguelikeRewardShowType showType)
		{
		}

		// Token: 0x0601FA21 RID: 129569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FA21")]
		[Address(RVA = "0x195ECD0", Offset = "0x195D8D0", VA = "0x18195ECD0")]
		private void _SetInfo(RoguelikeSortItemViewStruct viewStruct)
		{
		}

		// Token: 0x0601FA22 RID: 129570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FA22")]
		[Address(RVA = "0x195F840", Offset = "0x195E440", VA = "0x18195F840")]
		public RoguelikeRewardSelectItem()
		{
		}

		// Token: 0x0402A9E6 RID: 174566
		[Token(Token = "0x402A9E6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _itemTitle;

		// Token: 0x0402A9E7 RID: 174567
		[Token(Token = "0x402A9E7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _recruitIcon;

		// Token: 0x0402A9E8 RID: 174568
		[Token(Token = "0x402A9E8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RoguelikeRewardSelectItemIconPlugin _iconPlugin;

		// Token: 0x0402A9E9 RID: 174569
		[Token(Token = "0x402A9E9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _description;

		// Token: 0x0402A9EA RID: 174570
		[Token(Token = "0x402A9EA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _shortDesc;

		// Token: 0x0402A9EB RID: 174571
		[Token(Token = "0x402A9EB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _titleText;

		// Token: 0x0402A9EC RID: 174572
		[Token(Token = "0x402A9EC")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _extraInfoObj;

		// Token: 0x0402A9ED RID: 174573
		[Token(Token = "0x402A9ED")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _extraInfoText;

		// Token: 0x0402A9EE RID: 174574
		[Token(Token = "0x402A9EE")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _imgButton;

		// Token: 0x0402A9EF RID: 174575
		[Token(Token = "0x402A9EF")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _imgTextBg;

		// Token: 0x0402A9F0 RID: 174576
		[Token(Token = "0x402A9F0")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image _itemBg;

		// Token: 0x0402A9F1 RID: 174577
		[Token(Token = "0x402A9F1")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _objBtn;

		// Token: 0x0402A9F2 RID: 174578
		[Token(Token = "0x402A9F2")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _objBtnHideTips;

		// Token: 0x0402A9F3 RID: 174579
		[Token(Token = "0x402A9F3")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Image _imgHideBg;

		// Token: 0x0402A9F4 RID: 174580
		[Token(Token = "0x402A9F4")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _btnHideTxt;

		// Token: 0x0402A9F5 RID: 174581
		[Token(Token = "0x402A9F5")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Button _btn;

		// Token: 0x0402A9F6 RID: 174582
		[Token(Token = "0x402A9F6")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private RoguelikeRewardSelectItem.ItemIconConfig[] _itemIconConfigs;

		// Token: 0x0402A9F7 RID: 174583
		[Token(Token = "0x402A9F7")]
		[FieldOffset(Offset = "0xA0")]
		[NonSerialized]
		public UIIntEvent onClickEvent;

		// Token: 0x0402A9F9 RID: 174585
		[Token(Token = "0x402A9F9")]
		[FieldOffset(Offset = "0xB0")]
		private RoguelikeSortItemViewStruct m_cacheViewStruct;

		// Token: 0x0402A9FA RID: 174586
		[Token(Token = "0x402A9FA")]
		[FieldOffset(Offset = "0x160")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402A9FB RID: 174587
		[Token(Token = "0x402A9FB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_uiStyle;

		// Token: 0x0402A9FC RID: 174588
		[Token(Token = "0x402A9FC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_uiStyle;

		// Token: 0x0402A9FD RID: 174589
		[Token(Token = "0x402A9FD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402A9FE RID: 174590
		[Token(Token = "0x402A9FE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RenderCard;

		// Token: 0x0402A9FF RID: 174591
		[Token(Token = "0x402A9FF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SetCommonItemInfo;

		// Token: 0x0402AA00 RID: 174592
		[Token(Token = "0x402AA00")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SetClickable;

		// Token: 0x0402AA01 RID: 174593
		[Token(Token = "0x402AA01")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SetStyle;

		// Token: 0x0402AA02 RID: 174594
		[Token(Token = "0x402AA02")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__SetInfo;

		// Token: 0x0402AA03 RID: 174595
		[Token(Token = "0x402AA03")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020053FC RID: 21500
		[Token(Token = "0x20053FC")]
		[Serializable]
		private class ItemIconConfig
		{
			// Token: 0x0601FA23 RID: 129571 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601FA23")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ItemIconConfig()
			{
			}

			// Token: 0x0402AA04 RID: 174596
			[Token(Token = "0x402AA04")]
			[FieldOffset(Offset = "0x10")]
			public RoguelikeRewardShowType showType;

			// Token: 0x0402AA05 RID: 174597
			[Token(Token = "0x402AA05")]
			[FieldOffset(Offset = "0x18")]
			public Image imgItem;
		}
	}
}
