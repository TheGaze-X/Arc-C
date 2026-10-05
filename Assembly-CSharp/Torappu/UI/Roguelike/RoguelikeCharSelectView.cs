using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020054A5 RID: 21669
	[Token(Token = "0x20054A5")]
	public class RoguelikeCharSelectView : DataBinder<RoguelikeSelectCharProperty>, IHotfixable
	{
		// Token: 0x0601FE1E RID: 130590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE1E")]
		[Address(RVA = "0x1A03990", Offset = "0x1A02590", VA = "0x181A03990")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601FE1F RID: 130591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE1F")]
		[Address(RVA = "0x1A03770", Offset = "0x1A02370", VA = "0x181A03770")]
		private void _InitFilter()
		{
		}

		// Token: 0x0601FE20 RID: 130592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE20")]
		[Address(RVA = "0x1A03160", Offset = "0x1A01D60", VA = "0x181A03160", Slot = "7")]
		public override void OnValueChanged(RoguelikeSelectCharProperty property)
		{
		}

		// Token: 0x0601FE21 RID: 130593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE21")]
		[Address(RVA = "0x1A03B70", Offset = "0x1A02770", VA = "0x181A03B70")]
		private void _UpdateValidSubProfs(List<RoguelikeCharCardViewModel> charCards, List<int> selectInsts, out ProfessionCategory validProf)
		{
		}

		// Token: 0x0601FE22 RID: 130594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE22")]
		[Address(RVA = "0x1A030C0", Offset = "0x1A01CC0", VA = "0x181A030C0")]
		public void InjectPlugin(IRoguelikeCharCardPlugin plugin)
		{
		}

		// Token: 0x0601FE23 RID: 130595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE23")]
		[Address(RVA = "0x1A03A80", Offset = "0x1A02680", VA = "0x181A03A80")]
		private void _OnFilterChange(UICharacterProfessionFilterHolder.FilterParam param)
		{
		}

		// Token: 0x0601FE24 RID: 130596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE24")]
		[Address(RVA = "0x1A03D60", Offset = "0x1A02960", VA = "0x181A03D60")]
		public RoguelikeCharSelectView()
		{
		}

		// Token: 0x0402AFDA RID: 176090
		[Token(Token = "0x402AFDA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _controllerContainer;

		// Token: 0x0402AFDB RID: 176091
		[Token(Token = "0x402AFDB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RoguelikeCharSelectAttrController _controller;

		// Token: 0x0402AFDC RID: 176092
		[Token(Token = "0x402AFDC")]
		[FieldOffset(Offset = "0x30")]
		private RoguelikeCharSelectAttrController m_controller;

		// Token: 0x0402AFDD RID: 176093
		[Token(Token = "0x402AFDD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RoguelikeCharRecycleAdapter _adapter;

		// Token: 0x0402AFDE RID: 176094
		[Token(Token = "0x402AFDE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _popPart;

		// Token: 0x0402AFDF RID: 176095
		[Token(Token = "0x402AFDF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RoguelikePopBarView _popText;

		// Token: 0x0402AFE0 RID: 176096
		[Token(Token = "0x402AFE0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _emptyPart;

		// Token: 0x0402AFE1 RID: 176097
		[Token(Token = "0x402AFE1")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RoguelikeCharSelectState.RoguelikeCharAttrTabTypeMessage onAttrTabClickEvent;

		// Token: 0x0402AFE2 RID: 176098
		[Token(Token = "0x402AFE2")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIStringEvent onSkillSelectEvent;

		// Token: 0x0402AFE3 RID: 176099
		[Token(Token = "0x402AFE3")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIStringEvent onBranchSelectEvent;

		// Token: 0x0402AFE4 RID: 176100
		[Token(Token = "0x402AFE4")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _filterContainer;

		// Token: 0x0402AFE5 RID: 176101
		[Token(Token = "0x402AFE5")]
		[FieldOffset(Offset = "0x78")]
		private bool m_isInited;

		// Token: 0x0402AFE6 RID: 176102
		[Token(Token = "0x402AFE6")]
		[FieldOffset(Offset = "0x7C")]
		private int m_cachedInitSeq;

		// Token: 0x0402AFE7 RID: 176103
		[Token(Token = "0x402AFE7")]
		[FieldOffset(Offset = "0x80")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402AFE8 RID: 176104
		[Token(Token = "0x402AFE8")]
		[FieldOffset(Offset = "0x90")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402AFE9 RID: 176105
		[Token(Token = "0x402AFE9")]
		[FieldOffset(Offset = "0xA0")]
		private HashSet<string> m_cachedValidSubProf;

		// Token: 0x0402AFEA RID: 176106
		[Token(Token = "0x402AFEA")]
		[FieldOffset(Offset = "0xA8")]
		private RoguelikeCharSelectView.ProfessionFilterHandler m_profFilterHandler;

		// Token: 0x0402AFEB RID: 176107
		[Token(Token = "0x402AFEB")]
		[FieldOffset(Offset = "0xB0")]
		private UICharacterProfessionFilterHolder m_profFilterHolder;

		// Token: 0x0402AFEC RID: 176108
		[Token(Token = "0x402AFEC")]
		[FieldOffset(Offset = "0xB8")]
		private List<IRoguelikeCharCardPlugin> m_plugins;

		// Token: 0x0402AFED RID: 176109
		[Token(Token = "0x402AFED")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402AFEE RID: 176110
		[Token(Token = "0x402AFEE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitFilter;

		// Token: 0x0402AFEF RID: 176111
		[Token(Token = "0x402AFEF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402AFF0 RID: 176112
		[Token(Token = "0x402AFF0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateValidSubProfs;

		// Token: 0x0402AFF1 RID: 176113
		[Token(Token = "0x402AFF1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_InjectPlugin;

		// Token: 0x0402AFF2 RID: 176114
		[Token(Token = "0x402AFF2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnFilterChange;

		// Token: 0x0402AFF3 RID: 176115
		[Token(Token = "0x402AFF3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020054A6 RID: 21670
		[Token(Token = "0x20054A6")]
		private class ProfessionFilterHandler : UICharacterProfessionFilterHolder.IProfFilterHandler, UICharacterFilterHolder.IFilterHandler, IHotfixable
		{
			// Token: 0x0601FE25 RID: 130597 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601FE25")]
			[Address(RVA = "0x19FF840", Offset = "0x19FE440", VA = "0x1819FF840")]
			public ProfessionFilterHandler(RoguelikeCharSelectView closure)
			{
			}

			// Token: 0x0601FE26 RID: 130598 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601FE26")]
			[Address(RVA = "0x19FF5E0", Offset = "0x19FE1E0", VA = "0x1819FF5E0", Slot = "5")]
			public void OnApplyFilter(ValueBundle val)
			{
			}

			// Token: 0x0601FE27 RID: 130599 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601FE27")]
			[Address(RVA = "0x19FF7E0", Offset = "0x19FE3E0", VA = "0x1819FF7E0", Slot = "4")]
			public void OnProfPanelChanged(bool isShow)
			{
			}

			// Token: 0x0402AFF4 RID: 176116
			[Token(Token = "0x402AFF4")]
			[FieldOffset(Offset = "0x10")]
			private RoguelikeCharSelectView m_closure;

			// Token: 0x0402AFF5 RID: 176117
			[Token(Token = "0x402AFF5")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402AFF6 RID: 176118
			[Token(Token = "0x402AFF6")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnApplyFilter;

			// Token: 0x0402AFF7 RID: 176119
			[Token(Token = "0x402AFF7")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OnProfPanelChanged;
		}
	}
}
