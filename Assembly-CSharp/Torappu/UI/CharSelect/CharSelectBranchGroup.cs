using System;
using Il2CppDummyDll;
using Torappu.UI.CharacterCommon;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharSelect
{
	// Token: 0x02005E16 RID: 24086
	[Token(Token = "0x2005E16")]
	public class CharSelectBranchGroup : MonoBehaviour, IHotfixable
	{
		// Token: 0x06022E86 RID: 142982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022E86")]
		[Address(RVA = "0x1D649F0", Offset = "0x1D635F0", VA = "0x181D649F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06022E87 RID: 142983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022E87")]
		[Address(RVA = "0x1D644E0", Offset = "0x1D630E0", VA = "0x181D644E0")]
		public void RenderView(CharSelectBranchGroupViewModel branchModel)
		{
		}

		// Token: 0x06022E88 RID: 142984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022E88")]
		[Address(RVA = "0x1D64B50", Offset = "0x1D63750", VA = "0x181D64B50")]
		private void _OnBranchSelected(string equipId)
		{
		}

		// Token: 0x06022E89 RID: 142985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022E89")]
		[Address(RVA = "0x1D64BE0", Offset = "0x1D637E0", VA = "0x181D64BE0")]
		public CharSelectBranchGroup()
		{
		}

		// Token: 0x04030125 RID: 196901
		[Token(Token = "0x4030125")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _talentContainer;

		// Token: 0x04030126 RID: 196902
		[Token(Token = "0x4030126")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _contentItemPrefab;

		// Token: 0x04030127 RID: 196903
		[Token(Token = "0x4030127")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _subProfName;

		// Token: 0x04030128 RID: 196904
		[Token(Token = "0x4030128")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UICommentedText _subProfDetailBasic;

		// Token: 0x04030129 RID: 196905
		[Token(Token = "0x4030129")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UICommentedText _subProfDetailAdditive;

		// Token: 0x0403012A RID: 196906
		[Token(Token = "0x403012A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _subProfImg;

		// Token: 0x0403012B RID: 196907
		[Token(Token = "0x403012B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelUniequip;

		// Token: 0x0403012C RID: 196908
		[Token(Token = "0x403012C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SimpleLayoutContent _branchLayout;

		// Token: 0x0403012D RID: 196909
		[Token(Token = "0x403012D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIStringEvent _onBranchSelected;

		// Token: 0x0403012E RID: 196910
		[Token(Token = "0x403012E")]
		[FieldOffset(Offset = "0x60")]
		private CharacterTalentViewModel[] m_talentsCache;

		// Token: 0x0403012F RID: 196911
		[Token(Token = "0x403012F")]
		[FieldOffset(Offset = "0x68")]
		private CharSelectBranchGroup.BranchAdapter m_adapter;

		// Token: 0x04030130 RID: 196912
		[Token(Token = "0x4030130")]
		[FieldOffset(Offset = "0x70")]
		private bool m_isInited;

		// Token: 0x04030131 RID: 196913
		[Token(Token = "0x4030131")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04030132 RID: 196914
		[Token(Token = "0x4030132")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x04030133 RID: 196915
		[Token(Token = "0x4030133")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnBranchSelected;

		// Token: 0x04030134 RID: 196916
		[Token(Token = "0x4030134")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005E17 RID: 24087
		[Token(Token = "0x2005E17")]
		private class BranchAdapter : SimpleLayoutAdapter
		{
			// Token: 0x170052C1 RID: 21185
			// (get) Token: 0x06022E8A RID: 142986 RVA: 0x000BF718 File Offset: 0x000BD918
			[Token(Token = "0x170052C1")]
			public override int count
			{
				[Token(Token = "0x6022E8A")]
				[Address(RVA = "0x1D60010", Offset = "0x1D5EC10", VA = "0x181D60010", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06022E8B RID: 142987 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6022E8B")]
			[Address(RVA = "0x1D5FD30", Offset = "0x1D5E930", VA = "0x181D5FD30", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06022E8C RID: 142988 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022E8C")]
			[Address(RVA = "0x1D5FFB0", Offset = "0x1D5EBB0", VA = "0x181D5FFB0")]
			public BranchAdapter()
			{
			}

			// Token: 0x04030135 RID: 196917
			[Token(Token = "0x4030135")]
			[FieldOffset(Offset = "0x20")]
			public CharSelectBranchGroupViewModel viewModel;

			// Token: 0x04030136 RID: 196918
			[Token(Token = "0x4030136")]
			[FieldOffset(Offset = "0x28")]
			public CharSelectBranchGroup closure;

			// Token: 0x04030137 RID: 196919
			[Token(Token = "0x4030137")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04030138 RID: 196920
			[Token(Token = "0x4030138")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04030139 RID: 196921
			[Token(Token = "0x4030139")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
