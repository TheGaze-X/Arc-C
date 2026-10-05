using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL05
{
	// Token: 0x0200458E RID: 17806
	[Token(Token = "0x200458E")]
	public class RL05DifficultyItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601B1BA RID: 111034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B1BA")]
		[Address(RVA = "0x1430BD0", Offset = "0x142F7D0", VA = "0x181430BD0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601B1BB RID: 111035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B1BB")]
		[Address(RVA = "0x14300C0", Offset = "0x142ECC0", VA = "0x1814300C0")]
		public void Render(RL05DifficultyItem.ViewData data)
		{
		}

		// Token: 0x0601B1BC RID: 111036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B1BC")]
		[Address(RVA = "0x1430800", Offset = "0x142F400", VA = "0x181430800")]
		public void UpdateState(RL05DifficultyItem.ViewData data, bool include, bool selected, bool immediately)
		{
		}

		// Token: 0x0601B1BD RID: 111037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B1BD")]
		[Address(RVA = "0x1430040", Offset = "0x142EC40", VA = "0x181430040")]
		public void EventOnClick()
		{
		}

		// Token: 0x0601B1BE RID: 111038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B1BE")]
		[Address(RVA = "0x1430D50", Offset = "0x142F950", VA = "0x181430D50")]
		public RL05DifficultyItem()
		{
		}

		// Token: 0x04022DFF RID: 142847
		[Token(Token = "0x4022DFF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _normalTitle;

		// Token: 0x04022E00 RID: 142848
		[Token(Token = "0x4022E00")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _hardTitle;

		// Token: 0x04022E01 RID: 142849
		[Token(Token = "0x4022E01")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _name;

		// Token: 0x04022E02 RID: 142850
		[Token(Token = "0x4022E02")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _subName;

		// Token: 0x04022E03 RID: 142851
		[Token(Token = "0x4022E03")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _gradeLvl;

		// Token: 0x04022E04 RID: 142852
		[Token(Token = "0x4022E04")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SimpleLayoutContent _descList;

		// Token: 0x04022E05 RID: 142853
		[Token(Token = "0x4022E05")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _descNormalColor;

		// Token: 0x04022E06 RID: 142854
		[Token(Token = "0x4022E06")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Color _descBuffColor;

		// Token: 0x04022E07 RID: 142855
		[Token(Token = "0x4022E07")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _warnningTag;

		// Token: 0x04022E08 RID: 142856
		[Token(Token = "0x4022E08")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _lockedTag;

		// Token: 0x04022E09 RID: 142857
		[Token(Token = "0x4022E09")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _lockedDesc;

		// Token: 0x04022E0A RID: 142858
		[Token(Token = "0x4022E0A")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _newTag;

		// Token: 0x04022E0B RID: 142859
		[Token(Token = "0x4022E0B")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private TwoStateFadeSwitcher _buffTag;

		// Token: 0x04022E0C RID: 142860
		[Token(Token = "0x4022E0C")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private RoguelikeTopicDifficultyItemColors[] _stateClrTargets;

		// Token: 0x04022E0D RID: 142861
		[Token(Token = "0x4022E0D")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private RoguelikeTopicDifficultyItemColors[] _mainClrTargets;

		// Token: 0x04022E0E RID: 142862
		[Token(Token = "0x4022E0E")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private UIAtlasImage _colorLine;

		// Token: 0x04022E0F RID: 142863
		[Token(Token = "0x4022E0F")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Sprite _exclusiveTag;

		// Token: 0x04022E10 RID: 142864
		[Token(Token = "0x4022E10")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private List<RL05DifficultyItem.TagSpriteWarningGroup> _tagSpriteWarningGroups;

		// Token: 0x04022E11 RID: 142865
		[Token(Token = "0x4022E11")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Image _tagImg;

		// Token: 0x04022E12 RID: 142866
		[Token(Token = "0x4022E12")]
		[FieldOffset(Offset = "0xC0")]
		private Action<int> m_onClick;

		// Token: 0x04022E13 RID: 142867
		[Token(Token = "0x4022E13")]
		[FieldOffset(Offset = "0xC8")]
		private int m_index;

		// Token: 0x04022E14 RID: 142868
		[Token(Token = "0x4022E14")]
		[FieldOffset(Offset = "0xD0")]
		private RL05DifficultyItem.DescListAdapter m_descAdapter;

		// Token: 0x04022E15 RID: 142869
		[Token(Token = "0x4022E15")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04022E16 RID: 142870
		[Token(Token = "0x4022E16")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04022E17 RID: 142871
		[Token(Token = "0x4022E17")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x04022E18 RID: 142872
		[Token(Token = "0x4022E18")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnClick;

		// Token: 0x04022E19 RID: 142873
		[Token(Token = "0x4022E19")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200458F RID: 17807
		[Token(Token = "0x200458F")]
		[Serializable]
		public class TagSpriteWarningGroup
		{
			// Token: 0x0601B1BF RID: 111039 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B1BF")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public TagSpriteWarningGroup()
			{
			}

			// Token: 0x04022E1A RID: 142874
			[Token(Token = "0x4022E1A")]
			[FieldOffset(Offset = "0x10")]
			public RoguelikeTopicDifficultyWarningType type;

			// Token: 0x04022E1B RID: 142875
			[Token(Token = "0x4022E1B")]
			[FieldOffset(Offset = "0x18")]
			public Sprite tagSprite;
		}

		// Token: 0x02004590 RID: 17808
		[Token(Token = "0x2004590")]
		public struct ViewData
		{
			// Token: 0x04022E1C RID: 142876
			[Token(Token = "0x4022E1C")]
			[FieldOffset(Offset = "0x0")]
			public RL05DifficultyItem prefab;

			// Token: 0x04022E1D RID: 142877
			[Token(Token = "0x4022E1D")]
			[FieldOffset(Offset = "0x8")]
			public RL05DifficultyViewModel itemModel;

			// Token: 0x04022E1E RID: 142878
			[Token(Token = "0x4022E1E")]
			[FieldOffset(Offset = "0x10")]
			public int pageIndex;

			// Token: 0x04022E1F RID: 142879
			[Token(Token = "0x4022E1F")]
			[FieldOffset(Offset = "0x18")]
			public Action<int> onItemClicked;
		}

		// Token: 0x02004591 RID: 17809
		[Token(Token = "0x2004591")]
		public class VirtualView : UIRecycleLayoutAdapter.VirtualView<RL05DifficultyItem>
		{
			// Token: 0x0601B1C0 RID: 111040 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B1C0")]
			[Address(RVA = "0x14435B0", Offset = "0x14421B0", VA = "0x1814435B0")]
			public VirtualView(RL05DifficultyItem.ViewData data)
			{
			}

			// Token: 0x0601B1C1 RID: 111041 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601B1C1")]
			[Address(RVA = "0x1443240", Offset = "0x1441E40", VA = "0x181443240", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x0601B1C2 RID: 111042 RVA: 0x000A4670 File Offset: 0x000A2870
			[Token(Token = "0x601B1C2")]
			[Address(RVA = "0x14432B0", Offset = "0x1441EB0", VA = "0x1814432B0", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x0601B1C3 RID: 111043 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B1C3")]
			[Address(RVA = "0x1443340", Offset = "0x1441F40", VA = "0x181443340", Slot = "10")]
			protected override void OnViewAttached()
			{
			}

			// Token: 0x0601B1C4 RID: 111044 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B1C4")]
			[Address(RVA = "0x1443440", Offset = "0x1442040", VA = "0x181443440", Slot = "11")]
			protected override void OnViewDetached()
			{
			}

			// Token: 0x0601B1C5 RID: 111045 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B1C5")]
			[Address(RVA = "0x14434A0", Offset = "0x14420A0", VA = "0x1814434A0")]
			public void UpdateState(int selectPage)
			{
			}

			// Token: 0x04022E20 RID: 142880
			[Token(Token = "0x4022E20")]
			[FieldOffset(Offset = "0x20")]
			private RL05DifficultyItem.ViewData m_data;

			// Token: 0x04022E21 RID: 142881
			[Token(Token = "0x4022E21")]
			[FieldOffset(Offset = "0x40")]
			private int m_selectPage;

			// Token: 0x04022E22 RID: 142882
			[Token(Token = "0x4022E22")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04022E23 RID: 142883
			[Token(Token = "0x4022E23")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x04022E24 RID: 142884
			[Token(Token = "0x4022E24")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetPreferSize;

			// Token: 0x04022E25 RID: 142885
			[Token(Token = "0x4022E25")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnViewAttached;

			// Token: 0x04022E26 RID: 142886
			[Token(Token = "0x4022E26")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_OnViewDetached;

			// Token: 0x04022E27 RID: 142887
			[Token(Token = "0x4022E27")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_UpdateState;
		}

		// Token: 0x02004592 RID: 17810
		[Token(Token = "0x2004592")]
		private class DescListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601B1C6 RID: 111046 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B1C6")]
			[Address(RVA = "0x142F250", Offset = "0x142DE50", VA = "0x18142F250")]
			public DescListAdapter(RL05DifficultyItem item)
			{
			}

			// Token: 0x1700409A RID: 16538
			// (get) Token: 0x0601B1C7 RID: 111047 RVA: 0x000A4688 File Offset: 0x000A2888
			[Token(Token = "0x1700409A")]
			public override int count
			{
				[Token(Token = "0x601B1C7")]
				[Address(RVA = "0x142F320", Offset = "0x142DF20", VA = "0x18142F320", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601B1C8 RID: 111048 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601B1C8")]
			[Address(RVA = "0x142EEA0", Offset = "0x142DAA0", VA = "0x18142EEA0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0601B1C9 RID: 111049 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B1C9")]
			[Address(RVA = "0x142F0D0", Offset = "0x142DCD0", VA = "0x18142F0D0")]
			public void Swtich(RoguelikeTopicDifficultyItemStatus stateName, bool immediately)
			{
			}

			// Token: 0x04022E28 RID: 142888
			[Token(Token = "0x4022E28")]
			[FieldOffset(Offset = "0x20")]
			private RL05DifficultyItem m_item;

			// Token: 0x04022E29 RID: 142889
			[Token(Token = "0x4022E29")]
			[FieldOffset(Offset = "0x28")]
			public List<string> descriptions;

			// Token: 0x04022E2A RID: 142890
			[Token(Token = "0x4022E2A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04022E2B RID: 142891
			[Token(Token = "0x4022E2B")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04022E2C RID: 142892
			[Token(Token = "0x4022E2C")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04022E2D RID: 142893
			[Token(Token = "0x4022E2D")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_Swtich;
		}
	}
}
