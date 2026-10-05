using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x020056BB RID: 22203
	[Token(Token = "0x20056BB")]
	public class RL04FragmentCharSelectDialog : UICompDialog<RL04FragmentCharSelectDialog.Options>
	{
		// Token: 0x06020909 RID: 133385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020909")]
		[Address(RVA = "0x1AA8F70", Offset = "0x1AA7B70", VA = "0x181AA8F70")]
		private void _Render()
		{
		}

		// Token: 0x0602090A RID: 133386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602090A")]
		[Address(RVA = "0x1AA8DA0", Offset = "0x1AA79A0", VA = "0x181AA8DA0")]
		private void _OnCharCardClicked(int index)
		{
		}

		// Token: 0x0602090B RID: 133387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602090B")]
		[Address(RVA = "0x1AA9450", Offset = "0x1AA8050", VA = "0x181AA9450")]
		private void _SendFragmentSelectCharRequest()
		{
		}

		// Token: 0x0602090C RID: 133388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602090C")]
		[Address(RVA = "0x1AA8E50", Offset = "0x1AA7A50", VA = "0x181AA8E50")]
		private void _OnFragmentSelectCharResponse(RL04SetFragmentCharResponse response)
		{
		}

		// Token: 0x0602090D RID: 133389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602090D")]
		[Address(RVA = "0x1AA8BA0", Offset = "0x1AA77A0", VA = "0x181AA8BA0", Slot = "18")]
		protected override void OnRender(RL04FragmentCharSelectDialog.Options input)
		{
		}

		// Token: 0x0602090E RID: 133390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602090E")]
		[Address(RVA = "0x1AA8A30", Offset = "0x1AA7630", VA = "0x181AA8A30")]
		public void EventOnBackBtnClicked()
		{
		}

		// Token: 0x0602090F RID: 133391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602090F")]
		[Address(RVA = "0x1AA8B00", Offset = "0x1AA7700", VA = "0x181AA8B00")]
		public void EventOnConfirmClicked()
		{
		}

		// Token: 0x06020910 RID: 133392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020910")]
		[Address(RVA = "0x1AA9AC0", Offset = "0x1AA86C0", VA = "0x181AA9AC0")]
		public RL04FragmentCharSelectDialog()
		{
		}

		// Token: 0x0402C1F7 RID: 180727
		[Token(Token = "0x402C1F7")]
		[FieldOffset(Offset = "0x0")]
		private static readonly List<ProfessionCategory> PROFESSION_ORDER_LIST;

		// Token: 0x0402C1F8 RID: 180728
		[Token(Token = "0x402C1F8")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _textSelect;

		// Token: 0x0402C1F9 RID: 180729
		[Token(Token = "0x402C1F9")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _textWeightLimit;

		// Token: 0x0402C1FA RID: 180730
		[Token(Token = "0x402C1FA")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _panelEmpty;

		// Token: 0x0402C1FB RID: 180731
		[Token(Token = "0x402C1FB")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _panelNotEmpty;

		// Token: 0x0402C1FC RID: 180732
		[Token(Token = "0x402C1FC")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private RL04FragmentCharSelectListAdapter _adapter;

		// Token: 0x0402C1FD RID: 180733
		[Token(Token = "0x402C1FD")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _panelScrollbar;

		// Token: 0x0402C1FE RID: 180734
		[Token(Token = "0x402C1FE")]
		[FieldOffset(Offset = "0xA0")]
		private RL04FragmentCharSelectDialog.RL04FragmentCharSelectModel m_viewModel;

		// Token: 0x0402C1FF RID: 180735
		[Token(Token = "0x402C1FF")]
		[FieldOffset(Offset = "0xA8")]
		private List<string> m_cachedSelectedChar;

		// Token: 0x0402C200 RID: 180736
		[Token(Token = "0x402C200")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_hasConfirmed;

		// Token: 0x0402C201 RID: 180737
		[Token(Token = "0x402C201")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0402C202 RID: 180738
		[Token(Token = "0x402C202")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnCharCardClicked;

		// Token: 0x0402C203 RID: 180739
		[Token(Token = "0x402C203")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SendFragmentSelectCharRequest;

		// Token: 0x0402C204 RID: 180740
		[Token(Token = "0x402C204")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnFragmentSelectCharResponse;

		// Token: 0x0402C205 RID: 180741
		[Token(Token = "0x402C205")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0402C206 RID: 180742
		[Token(Token = "0x402C206")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnBackBtnClicked;

		// Token: 0x0402C207 RID: 180743
		[Token(Token = "0x402C207")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnConfirmClicked;

		// Token: 0x0402C208 RID: 180744
		[Token(Token = "0x402C208")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020056BC RID: 22204
		[Token(Token = "0x20056BC")]
		public class Options
		{
			// Token: 0x06020912 RID: 133394 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020912")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Options()
			{
			}

			// Token: 0x0402C209 RID: 180745
			[Token(Token = "0x402C209")]
			[FieldOffset(Offset = "0x10")]
			public string topicId;
		}

		// Token: 0x020056BD RID: 22205
		[Token(Token = "0x20056BD")]
		public class RL04FragmentCharViewModel : RL04FragmentCharCardViewModel
		{
			// Token: 0x06020913 RID: 133395 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020913")]
			[Address(RVA = "0x1AAB620", Offset = "0x1AAA220", VA = "0x181AAB620")]
			public RL04FragmentCharViewModel()
			{
			}

			// Token: 0x0402C20A RID: 180746
			[Token(Token = "0x402C20A")]
			[FieldOffset(Offset = "0x30")]
			public ProfessionCategory profession;

			// Token: 0x0402C20B RID: 180747
			[Token(Token = "0x402C20B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020056BE RID: 22206
		[Token(Token = "0x20056BE")]
		private class RL04FragmentCharSelectModel : IHotfixable
		{
			// Token: 0x17004C51 RID: 19537
			// (get) Token: 0x06020914 RID: 133396 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17004C51")]
			public List<RL04FragmentCharSelectDialog.RL04FragmentCharViewModel> charListData
			{
				[Token(Token = "0x6020914")]
				[Address(RVA = "0x1AAB4B0", Offset = "0x1AAA0B0", VA = "0x181AAB4B0")]
				get
				{
					return null;
				}
			}

			// Token: 0x06020915 RID: 133397 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020915")]
			[Address(RVA = "0x1AAA260", Offset = "0x1AA8E60", VA = "0x181AAA260")]
			public void LoadData(string topicId)
			{
			}

			// Token: 0x06020916 RID: 133398 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020916")]
			[Address(RVA = "0x1AAB060", Offset = "0x1AA9C60", VA = "0x181AAB060")]
			private void _RefreshWeight()
			{
			}

			// Token: 0x06020917 RID: 133399 RVA: 0x000B66B8 File Offset: 0x000B48B8
			[Token(Token = "0x6020917")]
			[Address(RVA = "0x1AAB230", Offset = "0x1AA9E30", VA = "0x181AAB230")]
			private int _SortWeightCharData(RL04FragmentCharSelectDialog.RL04FragmentCharViewModel lhs, RL04FragmentCharSelectDialog.RL04FragmentCharViewModel rhs)
			{
				return 0;
			}

			// Token: 0x06020918 RID: 133400 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020918")]
			[Address(RVA = "0x1AAAB30", Offset = "0x1AA9730", VA = "0x181AAAB30")]
			private void _LoadWeightCharData(PlayerRoguelikeV2.CurrentData playerData, PlayerRoguelikeV2.CurrentData.Module.Fragment playerFragment)
			{
			}

			// Token: 0x06020919 RID: 133401 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020919")]
			[Address(RVA = "0x1AAA9E0", Offset = "0x1AA95E0", VA = "0x181AAA9E0")]
			private void _LoadSelectedChar(PlayerRoguelikeV2.CurrentData.Module.Fragment playerFragment)
			{
			}

			// Token: 0x0602091A RID: 133402 RVA: 0x000B66D0 File Offset: 0x000B48D0
			[Token(Token = "0x602091A")]
			[Address(RVA = "0x1AAA660", Offset = "0x1AA9260", VA = "0x181AAA660")]
			public bool SelectChar(int index)
			{
				return default(bool);
			}

			// Token: 0x0602091B RID: 133403 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602091B")]
			[Address(RVA = "0x1AAB3B0", Offset = "0x1AA9FB0", VA = "0x181AAB3B0")]
			public RL04FragmentCharSelectModel()
			{
			}

			// Token: 0x0402C20C RID: 180748
			[Token(Token = "0x402C20C")]
			[FieldOffset(Offset = "0x10")]
			public int maxSelectedNum;

			// Token: 0x0402C20D RID: 180749
			[Token(Token = "0x402C20D")]
			[FieldOffset(Offset = "0x14")]
			public int baseLimitWeight;

			// Token: 0x0402C20E RID: 180750
			[Token(Token = "0x402C20E")]
			[FieldOffset(Offset = "0x18")]
			public int currLimitWeight;

			// Token: 0x0402C20F RID: 180751
			[Token(Token = "0x402C20F")]
			[FieldOffset(Offset = "0x20")]
			public ListDict<int, RL04FragmentCharSelectDialog.RL04FragmentCharViewModel> charList;

			// Token: 0x0402C210 RID: 180752
			[Token(Token = "0x402C210")]
			[FieldOffset(Offset = "0x28")]
			public List<int> selectedChar;

			// Token: 0x0402C211 RID: 180753
			[Token(Token = "0x402C211")]
			[FieldOffset(Offset = "0x30")]
			private List<RL04FragmentCharSelectDialog.RL04FragmentCharViewModel> m_charListData;

			// Token: 0x0402C212 RID: 180754
			[Token(Token = "0x402C212")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_charListData;

			// Token: 0x0402C213 RID: 180755
			[Token(Token = "0x402C213")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_LoadData;

			// Token: 0x0402C214 RID: 180756
			[Token(Token = "0x402C214")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0__RefreshWeight;

			// Token: 0x0402C215 RID: 180757
			[Token(Token = "0x402C215")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__SortWeightCharData;

			// Token: 0x0402C216 RID: 180758
			[Token(Token = "0x402C216")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__LoadWeightCharData;

			// Token: 0x0402C217 RID: 180759
			[Token(Token = "0x402C217")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0__LoadSelectedChar;

			// Token: 0x0402C218 RID: 180760
			[Token(Token = "0x402C218")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_SelectChar;

			// Token: 0x0402C219 RID: 180761
			[Token(Token = "0x402C219")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
