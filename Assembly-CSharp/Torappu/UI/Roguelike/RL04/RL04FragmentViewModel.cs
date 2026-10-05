using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Roguelike.Fragment;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x020056DB RID: 22235
	[Token(Token = "0x20056DB")]
	public class RL04FragmentViewModel : IHotfixable
	{
		// Token: 0x17004C70 RID: 19568
		// (get) Token: 0x060209C0 RID: 133568 RVA: 0x000B67D8 File Offset: 0x000B49D8
		[Token(Token = "0x17004C70")]
		public int focusIndex
		{
			[Token(Token = "0x60209C0")]
			[Address(RVA = "0x1AC07B0", Offset = "0x1ABF3B0", VA = "0x181AC07B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17004C71 RID: 19569
		// (get) Token: 0x060209C1 RID: 133569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004C71")]
		public List<RL04FragmentItemGroupViewModel> fragmentGroupList
		{
			[Token(Token = "0x60209C1")]
			[Address(RVA = "0x1AC0820", Offset = "0x1ABF420", VA = "0x181AC0820")]
			get
			{
				return null;
			}
		}

		// Token: 0x060209C2 RID: 133570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60209C2")]
		[Address(RVA = "0x1ABEF10", Offset = "0x1ABDB10", VA = "0x181ABEF10")]
		public void LoadData(string topicId, RoguelikeFragmentDialogMode panelMode, RoguelikeFragmentDialogListType listType)
		{
		}

		// Token: 0x060209C3 RID: 133571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60209C3")]
		[Address(RVA = "0x1ABF0B0", Offset = "0x1ABDCB0", VA = "0x181ABF0B0")]
		public void RefreshPlayerData()
		{
		}

		// Token: 0x060209C4 RID: 133572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60209C4")]
		[Address(RVA = "0x1ABF4B0", Offset = "0x1ABE0B0", VA = "0x181ABF4B0")]
		public void TryFocusItem(int itemIndex)
		{
		}

		// Token: 0x060209C5 RID: 133573 RVA: 0x000B67F0 File Offset: 0x000B49F0
		[Token(Token = "0x60209C5")]
		[Address(RVA = "0x1AC0380", Offset = "0x1ABEF80", VA = "0x181AC0380")]
		private int _TryFocusItem(int itemIndex, List<RL04FragmentItemGroupViewModel> groupViewModel)
		{
			return 0;
		}

		// Token: 0x060209C6 RID: 133574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60209C6")]
		[Address(RVA = "0x1ABFFD0", Offset = "0x1ABEBD0", VA = "0x181ABFFD0")]
		private void _LoadWeightCharData(PlayerRoguelikeV2.CurrentData playerData, PlayerRoguelikeV2.CurrentData.Module.Fragment playerFragment)
		{
		}

		// Token: 0x060209C7 RID: 133575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60209C7")]
		[Address(RVA = "0x1ABFA10", Offset = "0x1ABE610", VA = "0x181ABFA10")]
		private void _LoadFragmentData(PlayerRoguelikeV2.CurrentData.Module.Fragment playerFragment)
		{
		}

		// Token: 0x060209C8 RID: 133576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60209C8")]
		[Address(RVA = "0x1ABF8A0", Offset = "0x1ABE4A0", VA = "0x181ABF8A0")]
		private void _GenerateFragmentGroup()
		{
		}

		// Token: 0x060209C9 RID: 133577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60209C9")]
		[Address(RVA = "0x1ABF560", Offset = "0x1ABE160", VA = "0x181ABF560")]
		private void _GenerateFragmentGroup(List<RL04FragmentItemGroupViewModel> groupList, int itemCountPerRow)
		{
		}

		// Token: 0x060209CA RID: 133578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60209CA")]
		[Address(RVA = "0x1AC05D0", Offset = "0x1ABF1D0", VA = "0x181AC05D0")]
		public RL04FragmentViewModel()
		{
		}

		// Token: 0x0402C360 RID: 181088
		[Token(Token = "0x402C360")]
		public const int DEFAULT_FOCUS_INDEX = 0;

		// Token: 0x0402C361 RID: 181089
		[Token(Token = "0x402C361")]
		[FieldOffset(Offset = "0x10")]
		public FragmentBagStatus status;

		// Token: 0x0402C362 RID: 181090
		[Token(Token = "0x402C362")]
		[FieldOffset(Offset = "0x14")]
		public int totalWeight;

		// Token: 0x0402C363 RID: 181091
		[Token(Token = "0x402C363")]
		[FieldOffset(Offset = "0x18")]
		public int limitWeight;

		// Token: 0x0402C364 RID: 181092
		[Token(Token = "0x402C364")]
		[FieldOffset(Offset = "0x1C")]
		public int overWeight;

		// Token: 0x0402C365 RID: 181093
		[Token(Token = "0x402C365")]
		[FieldOffset(Offset = "0x20")]
		public float weightProgress;

		// Token: 0x0402C366 RID: 181094
		[Token(Token = "0x402C366")]
		[FieldOffset(Offset = "0x24")]
		public float limitWeightScale;

		// Token: 0x0402C367 RID: 181095
		[Token(Token = "0x402C367")]
		[FieldOffset(Offset = "0x28")]
		public float overWeightScale;

		// Token: 0x0402C368 RID: 181096
		[Token(Token = "0x402C368")]
		[FieldOffset(Offset = "0x30")]
		public string safeDesc;

		// Token: 0x0402C369 RID: 181097
		[Token(Token = "0x402C369")]
		[FieldOffset(Offset = "0x38")]
		public string limitDesc;

		// Token: 0x0402C36A RID: 181098
		[Token(Token = "0x402C36A")]
		[FieldOffset(Offset = "0x40")]
		public string overWeightDesc;

		// Token: 0x0402C36B RID: 181099
		[Token(Token = "0x402C36B")]
		[FieldOffset(Offset = "0x48")]
		public bool troopCarryNotBest;

		// Token: 0x0402C36C RID: 181100
		[Token(Token = "0x402C36C")]
		[FieldOffset(Offset = "0x50")]
		private string m_limitDescConstDesc;

		// Token: 0x0402C36D RID: 181101
		[Token(Token = "0x402C36D")]
		[FieldOffset(Offset = "0x58")]
		public int focusSequence;

		// Token: 0x0402C36E RID: 181102
		[Token(Token = "0x402C36E")]
		[FieldOffset(Offset = "0x60")]
		public List<RL04FragmentCharCardViewModel> weightCharList;

		// Token: 0x0402C36F RID: 181103
		[Token(Token = "0x402C36F")]
		[FieldOffset(Offset = "0x68")]
		public RoguelikeFragmentDialogListType listType;

		// Token: 0x0402C370 RID: 181104
		[Token(Token = "0x402C370")]
		[FieldOffset(Offset = "0x70")]
		public string topicId;

		// Token: 0x0402C371 RID: 181105
		[Token(Token = "0x402C371")]
		[FieldOffset(Offset = "0x78")]
		public List<RL04FragmentItemViewModel> fragmentList;

		// Token: 0x0402C372 RID: 181106
		[Token(Token = "0x402C372")]
		[FieldOffset(Offset = "0x80")]
		public RoguelikeFragmentDialogMode mode;

		// Token: 0x0402C373 RID: 181107
		[Token(Token = "0x402C373")]
		[FieldOffset(Offset = "0x84")]
		public int weightCharCount;

		// Token: 0x0402C374 RID: 181108
		[Token(Token = "0x402C374")]
		[FieldOffset(Offset = "0x88")]
		private ListDict<string, RL04FragmentItemViewModel> m_fragmentList;

		// Token: 0x0402C375 RID: 181109
		[Token(Token = "0x402C375")]
		[FieldOffset(Offset = "0x90")]
		private List<RL04FragmentItemGroupViewModel> m_detailGroupList;

		// Token: 0x0402C376 RID: 181110
		[Token(Token = "0x402C376")]
		[FieldOffset(Offset = "0x98")]
		private List<RL04FragmentItemGroupViewModel> m_summaryGroupList;

		// Token: 0x0402C377 RID: 181111
		[Token(Token = "0x402C377")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_hasUsedFood;

		// Token: 0x0402C378 RID: 181112
		[Token(Token = "0x402C378")]
		[FieldOffset(Offset = "0xA4")]
		private int m_detailFocusIndex;

		// Token: 0x0402C379 RID: 181113
		[Token(Token = "0x402C379")]
		[FieldOffset(Offset = "0xA8")]
		private int m_summaryFocusIndex;

		// Token: 0x0402C37A RID: 181114
		[Token(Token = "0x402C37A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_focusIndex;

		// Token: 0x0402C37B RID: 181115
		[Token(Token = "0x402C37B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_fragmentGroupList;

		// Token: 0x0402C37C RID: 181116
		[Token(Token = "0x402C37C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402C37D RID: 181117
		[Token(Token = "0x402C37D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RefreshPlayerData;

		// Token: 0x0402C37E RID: 181118
		[Token(Token = "0x402C37E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_TryFocusItem;

		// Token: 0x0402C37F RID: 181119
		[Token(Token = "0x402C37F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__TryFocusItem;

		// Token: 0x0402C380 RID: 181120
		[Token(Token = "0x402C380")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__LoadWeightCharData;

		// Token: 0x0402C381 RID: 181121
		[Token(Token = "0x402C381")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__LoadFragmentData;

		// Token: 0x0402C382 RID: 181122
		[Token(Token = "0x402C382")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GenerateFragmentGroup;

		// Token: 0x0402C383 RID: 181123
		[Token(Token = "0x402C383")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix1__GenerateFragmentGroup;

		// Token: 0x0402C384 RID: 181124
		[Token(Token = "0x402C384")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
