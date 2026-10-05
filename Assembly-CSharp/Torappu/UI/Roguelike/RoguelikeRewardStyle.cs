using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005405 RID: 21509
	[Token(Token = "0x2005405")]
	public class RoguelikeRewardStyle : UIStyle
	{
		// Token: 0x17004A23 RID: 18979
		// (get) Token: 0x0601FA4C RID: 129612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004A23")]
		public RoguelikeRewardPerfectItemView perfectItemView
		{
			[Token(Token = "0x601FA4C")]
			[Address(RVA = "0x1963CB0", Offset = "0x19628B0", VA = "0x181963CB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004A24 RID: 18980
		// (get) Token: 0x0601FA4D RID: 129613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004A24")]
		public RoguelikeRewardItemHolder rewardItemHolder
		{
			[Token(Token = "0x601FA4D")]
			[Address(RVA = "0x1963DD0", Offset = "0x19629D0", VA = "0x181963DD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004A25 RID: 18981
		// (get) Token: 0x0601FA4E RID: 129614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004A25")]
		public RoguelikeRewardCompleteBtnView rewardCompleteBtn
		{
			[Token(Token = "0x601FA4E")]
			[Address(RVA = "0x1963D10", Offset = "0x1962910", VA = "0x181963D10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004A26 RID: 18982
		// (get) Token: 0x0601FA4F RID: 129615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004A26")]
		public RoguelikeRewardSelectItem rewardSelectItem
		{
			[Token(Token = "0x601FA4F")]
			[Address(RVA = "0x1963EA0", Offset = "0x1962AA0", VA = "0x181963EA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004A27 RID: 18983
		// (get) Token: 0x0601FA50 RID: 129616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004A27")]
		public RoguelikeRewardItemExDropTagView rewardExDropTagView
		{
			[Token(Token = "0x601FA50")]
			[Address(RVA = "0x1963D70", Offset = "0x1962970", VA = "0x181963D70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004A28 RID: 18984
		// (get) Token: 0x0601FA51 RID: 129617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004A28")]
		public RLRewardEntryLevelPartView spLevelPartPrefab
		{
			[Token(Token = "0x601FA51")]
			[Address(RVA = "0x1963F00", Offset = "0x1962B00", VA = "0x181963F00")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601FA52 RID: 129618 RVA: 0x000B2740 File Offset: 0x000B0940
		[Token(Token = "0x601FA52")]
		[Address(RVA = "0x1963AC0", Offset = "0x19626C0", VA = "0x181963AC0")]
		public RoguelikeRewardSelectItemStyle GetRewardSelectItemStyle(RoguelikeGameItemType type, RoguelikeRewardShowType showType)
		{
			return default(RoguelikeRewardSelectItemStyle);
		}

		// Token: 0x17004A29 RID: 18985
		// (get) Token: 0x0601FA53 RID: 129619 RVA: 0x000B2758 File Offset: 0x000B0958
		[Token(Token = "0x17004A29")]
		public Vector2 rewardItemSize
		{
			[Token(Token = "0x601FA53")]
			[Address(RVA = "0x1963E30", Offset = "0x1962A30", VA = "0x181963E30")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x0601FA54 RID: 129620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FA54")]
		[Address(RVA = "0x1963C50", Offset = "0x1962850", VA = "0x181963C50")]
		public RoguelikeRewardStyle()
		{
		}

		// Token: 0x0402AA53 RID: 174675
		[Token(Token = "0x402AA53")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RoguelikeRewardPerfectItemView _perfectItemView;

		// Token: 0x0402AA54 RID: 174676
		[Token(Token = "0x402AA54")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RoguelikeRewardItemHolder _rewardItemHolder;

		// Token: 0x0402AA55 RID: 174677
		[Token(Token = "0x402AA55")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RoguelikeRewardCompleteBtnView _rewardCompleteBtn;

		// Token: 0x0402AA56 RID: 174678
		[Token(Token = "0x402AA56")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RoguelikeRewardSelectItem _rewardSelectItemView;

		// Token: 0x0402AA57 RID: 174679
		[Token(Token = "0x402AA57")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<RoguelikeRewardSelectItemStyle> _rewardSelectItemStyleList;

		// Token: 0x0402AA58 RID: 174680
		[Token(Token = "0x402AA58")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RoguelikeRewardItemExDropTagView _exDropTagView;

		// Token: 0x0402AA59 RID: 174681
		[Token(Token = "0x402AA59")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Vector2 _rewardItemSize;

		// Token: 0x0402AA5A RID: 174682
		[Token(Token = "0x402AA5A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RLRewardEntryLevelPartView _spLevelPartPrefab;

		// Token: 0x0402AA5B RID: 174683
		[Token(Token = "0x402AA5B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_perfectItemView;

		// Token: 0x0402AA5C RID: 174684
		[Token(Token = "0x402AA5C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_rewardItemHolder;

		// Token: 0x0402AA5D RID: 174685
		[Token(Token = "0x402AA5D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_rewardCompleteBtn;

		// Token: 0x0402AA5E RID: 174686
		[Token(Token = "0x402AA5E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_rewardSelectItem;

		// Token: 0x0402AA5F RID: 174687
		[Token(Token = "0x402AA5F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_rewardExDropTagView;

		// Token: 0x0402AA60 RID: 174688
		[Token(Token = "0x402AA60")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_spLevelPartPrefab;

		// Token: 0x0402AA61 RID: 174689
		[Token(Token = "0x402AA61")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetRewardSelectItemStyle;

		// Token: 0x0402AA62 RID: 174690
		[Token(Token = "0x402AA62")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_rewardItemSize;

		// Token: 0x0402AA63 RID: 174691
		[Token(Token = "0x402AA63")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
