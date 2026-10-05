using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI.Roguelike.Copper;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005369 RID: 21353
	[Token(Token = "0x2005369")]
	public class RoguelikeGildCompDialog : UICompDialog<RoguelikeGildCompDialog.Options>, IValueMsgReceiver
	{
		// Token: 0x0601F7AA RID: 128938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F7AA")]
		[Address(RVA = "0x1923840", Offset = "0x1922440", VA = "0x181923840", Slot = "18")]
		protected override void OnRender(RoguelikeGildCompDialog.Options input)
		{
		}

		// Token: 0x0601F7AB RID: 128939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F7AB")]
		[Address(RVA = "0x1923CA0", Offset = "0x19228A0", VA = "0x181923CA0")]
		private void _LoadData()
		{
		}

		// Token: 0x0601F7AC RID: 128940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F7AC")]
		[Address(RVA = "0x19244C0", Offset = "0x19230C0", VA = "0x1819244C0")]
		private void _Refresh()
		{
		}

		// Token: 0x0601F7AD RID: 128941 RVA: 0x000B2170 File Offset: 0x000B0370
		[Token(Token = "0x601F7AD")]
		[Address(RVA = "0x1923B60", Offset = "0x1922760", VA = "0x181923B60")]
		private static int _ItemComparison(RoguelikePlayerCopperItemViewModel xModel, RoguelikePlayerCopperItemViewModel yModel)
		{
			return 0;
		}

		// Token: 0x0601F7AE RID: 128942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F7AE")]
		[Address(RVA = "0x19243B0", Offset = "0x1922FB0", VA = "0x1819243B0")]
		private void _OnItemClicked(string copperInstId)
		{
		}

		// Token: 0x0601F7AF RID: 128943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F7AF")]
		[Address(RVA = "0x19233D0", Offset = "0x1921FD0", VA = "0x1819233D0")]
		public void OnBackClicked()
		{
		}

		// Token: 0x0601F7B0 RID: 128944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F7B0")]
		[Address(RVA = "0x1923430", Offset = "0x1922030", VA = "0x181923430")]
		public void OnConfirmClicked()
		{
		}

		// Token: 0x0601F7B1 RID: 128945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F7B1")]
		[Address(RVA = "0x1924130", Offset = "0x1922D30", VA = "0x181924130")]
		private void _OnConfirmGild(RoguelikePlayerCopperItemViewModel selectItem)
		{
		}

		// Token: 0x0601F7B2 RID: 128946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F7B2")]
		[Address(RVA = "0x19236A0", Offset = "0x19222A0", VA = "0x1819236A0", Slot = "19")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0601F7B3 RID: 128947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F7B3")]
		[Address(RVA = "0x19245E0", Offset = "0x19231E0", VA = "0x1819245E0")]
		public RoguelikeGildCompDialog()
		{
		}

		// Token: 0x0402A586 RID: 173446
		[Token(Token = "0x402A586")]
		[NonSerialized]
		public const int MSG_ITEM_CLICKED = 100;

		// Token: 0x0402A587 RID: 173447
		[Token(Token = "0x402A587")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RoguelikeGildSelectedView _selectedView;

		// Token: 0x0402A588 RID: 173448
		[Token(Token = "0x402A588")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RoguelikeGildListAdapter _itemListAdapter;

		// Token: 0x0402A589 RID: 173449
		[Token(Token = "0x402A589")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Confirm")]
		private GameObject _panelBtnSelected;

		// Token: 0x0402A58A RID: 173450
		[Token(Token = "0x402A58A")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Confirm")]
		private GameObject _panelBtnUnSelected;

		// Token: 0x0402A58B RID: 173451
		[Token(Token = "0x402A58B")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Confirm")]
		private GameObject _panelCost;

		// Token: 0x0402A58C RID: 173452
		[Token(Token = "0x402A58C")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Confirm")]
		private Text _textCost;

		// Token: 0x0402A58D RID: 173453
		[Token(Token = "0x402A58D")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Confirm")]
		private Image _costItemIcon;

		// Token: 0x0402A58E RID: 173454
		[Token(Token = "0x402A58E")]
		[FieldOffset(Offset = "0xA8")]
		private Dictionary<string, RoguelikePlayerCopperItemViewModel> m_itemDict;

		// Token: 0x0402A58F RID: 173455
		[Token(Token = "0x402A58F")]
		[FieldOffset(Offset = "0xB0")]
		private List<RoguelikePlayerCopperItemViewModel> m_itemList;

		// Token: 0x0402A590 RID: 173456
		[Token(Token = "0x402A590")]
		[FieldOffset(Offset = "0xB8")]
		private RoguelikePlayerCopperItemViewModel m_selectedItem;

		// Token: 0x0402A591 RID: 173457
		[Token(Token = "0x402A591")]
		[FieldOffset(Offset = "0xC0")]
		private string m_gildTypeId;

		// Token: 0x0402A592 RID: 173458
		[Token(Token = "0x402A592")]
		[FieldOffset(Offset = "0xC8")]
		private string m_priceId;

		// Token: 0x0402A593 RID: 173459
		[Token(Token = "0x402A593")]
		[FieldOffset(Offset = "0xD0")]
		private int m_cost;

		// Token: 0x0402A594 RID: 173460
		[Token(Token = "0x402A594")]
		[FieldOffset(Offset = "0xD8")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402A595 RID: 173461
		[Token(Token = "0x402A595")]
		[FieldOffset(Offset = "0xE8")]
		private ILoadAsset m_assetLoader;

		// Token: 0x0402A596 RID: 173462
		[Token(Token = "0x402A596")]
		[FieldOffset(Offset = "0xF0")]
		private string m_topicId;

		// Token: 0x0402A597 RID: 173463
		[Token(Token = "0x402A597")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0402A598 RID: 173464
		[Token(Token = "0x402A598")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadData;

		// Token: 0x0402A599 RID: 173465
		[Token(Token = "0x402A599")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__Refresh;

		// Token: 0x0402A59A RID: 173466
		[Token(Token = "0x402A59A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ItemComparison;

		// Token: 0x0402A59B RID: 173467
		[Token(Token = "0x402A59B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnItemClicked;

		// Token: 0x0402A59C RID: 173468
		[Token(Token = "0x402A59C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnBackClicked;

		// Token: 0x0402A59D RID: 173469
		[Token(Token = "0x402A59D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnConfirmClicked;

		// Token: 0x0402A59E RID: 173470
		[Token(Token = "0x402A59E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnConfirmGild;

		// Token: 0x0402A59F RID: 173471
		[Token(Token = "0x402A59F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0402A5A0 RID: 173472
		[Token(Token = "0x402A5A0")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200536A RID: 21354
		[Token(Token = "0x200536A")]
		public class Options
		{
			// Token: 0x0601F7B6 RID: 128950 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F7B6")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Options()
			{
			}

			// Token: 0x0402A5A1 RID: 173473
			[Token(Token = "0x402A5A1")]
			[FieldOffset(Offset = "0x10")]
			public string topicId;
		}
	}
}
