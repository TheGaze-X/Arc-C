using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL04
{
	// Token: 0x020046C5 RID: 18117
	[Token(Token = "0x20046C5")]
	public class RL04DifficultyItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601B790 RID: 112528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B790")]
		[Address(RVA = "0x14C42C0", Offset = "0x14C2EC0", VA = "0x1814C42C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601B791 RID: 112529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B791")]
		[Address(RVA = "0x14C3880", Offset = "0x14C2480", VA = "0x1814C3880")]
		public void Render(RL04DifficultyItem.ViewData data)
		{
		}

		// Token: 0x0601B792 RID: 112530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B792")]
		[Address(RVA = "0x14C3FD0", Offset = "0x14C2BD0", VA = "0x1814C3FD0")]
		public void UpdateState(RL04DifficultyItem.ViewData data, bool include, bool selected, bool immediately)
		{
		}

		// Token: 0x0601B793 RID: 112531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B793")]
		[Address(RVA = "0x14C3800", Offset = "0x14C2400", VA = "0x1814C3800")]
		public void EventOnClick()
		{
		}

		// Token: 0x0601B794 RID: 112532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B794")]
		[Address(RVA = "0x14C4440", Offset = "0x14C3040", VA = "0x1814C4440")]
		public RL04DifficultyItem()
		{
		}

		// Token: 0x04023927 RID: 145703
		[Token(Token = "0x4023927")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _normalTitle;

		// Token: 0x04023928 RID: 145704
		[Token(Token = "0x4023928")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _hardTitle;

		// Token: 0x04023929 RID: 145705
		[Token(Token = "0x4023929")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _name;

		// Token: 0x0402392A RID: 145706
		[Token(Token = "0x402392A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _subName;

		// Token: 0x0402392B RID: 145707
		[Token(Token = "0x402392B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _gradeLvl;

		// Token: 0x0402392C RID: 145708
		[Token(Token = "0x402392C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SimpleLayoutContent _descList;

		// Token: 0x0402392D RID: 145709
		[Token(Token = "0x402392D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _descNormalColor;

		// Token: 0x0402392E RID: 145710
		[Token(Token = "0x402392E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Color _descBuffColor;

		// Token: 0x0402392F RID: 145711
		[Token(Token = "0x402392F")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _warnningTag;

		// Token: 0x04023930 RID: 145712
		[Token(Token = "0x4023930")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _lockedTag;

		// Token: 0x04023931 RID: 145713
		[Token(Token = "0x4023931")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _lockedDesc;

		// Token: 0x04023932 RID: 145714
		[Token(Token = "0x4023932")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _newTag;

		// Token: 0x04023933 RID: 145715
		[Token(Token = "0x4023933")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private TwoStateFadeSwitcher _buffTag;

		// Token: 0x04023934 RID: 145716
		[Token(Token = "0x4023934")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private RoguelikeTopicDifficultyItemColors[] _stateClrTargets;

		// Token: 0x04023935 RID: 145717
		[Token(Token = "0x4023935")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private RoguelikeTopicDifficultyItemColors[] _mainClrTargets;

		// Token: 0x04023936 RID: 145718
		[Token(Token = "0x4023936")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Image _colorLine;

		// Token: 0x04023937 RID: 145719
		[Token(Token = "0x4023937")]
		[FieldOffset(Offset = "0xA8")]
		private Action<int> m_onClick;

		// Token: 0x04023938 RID: 145720
		[Token(Token = "0x4023938")]
		[FieldOffset(Offset = "0xB0")]
		private int m_index;

		// Token: 0x04023939 RID: 145721
		[Token(Token = "0x4023939")]
		[FieldOffset(Offset = "0xB8")]
		private RL04DifficultyItem.DescListAdapter m_descAdapter;

		// Token: 0x0402393A RID: 145722
		[Token(Token = "0x402393A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402393B RID: 145723
		[Token(Token = "0x402393B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402393C RID: 145724
		[Token(Token = "0x402393C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0402393D RID: 145725
		[Token(Token = "0x402393D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnClick;

		// Token: 0x0402393E RID: 145726
		[Token(Token = "0x402393E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020046C6 RID: 18118
		[Token(Token = "0x20046C6")]
		public struct ViewData
		{
			// Token: 0x0402393F RID: 145727
			[Token(Token = "0x402393F")]
			[FieldOffset(Offset = "0x0")]
			public RL04DifficultyItem prefab;

			// Token: 0x04023940 RID: 145728
			[Token(Token = "0x4023940")]
			[FieldOffset(Offset = "0x8")]
			public RL04DifficultyViewModel itemModel;

			// Token: 0x04023941 RID: 145729
			[Token(Token = "0x4023941")]
			[FieldOffset(Offset = "0x10")]
			public int pageIndex;

			// Token: 0x04023942 RID: 145730
			[Token(Token = "0x4023942")]
			[FieldOffset(Offset = "0x18")]
			public Action<int> onItemClicked;
		}

		// Token: 0x020046C7 RID: 18119
		[Token(Token = "0x20046C7")]
		public class VirtualView : UIRecycleLayoutAdapter.VirtualView<RL04DifficultyItem>
		{
			// Token: 0x0601B795 RID: 112533 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B795")]
			[Address(RVA = "0x14D9060", Offset = "0x14D7C60", VA = "0x1814D9060")]
			public VirtualView(RL04DifficultyItem.ViewData data)
			{
			}

			// Token: 0x0601B796 RID: 112534 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601B796")]
			[Address(RVA = "0x14D8CF0", Offset = "0x14D78F0", VA = "0x1814D8CF0", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x0601B797 RID: 112535 RVA: 0x000A5540 File Offset: 0x000A3740
			[Token(Token = "0x601B797")]
			[Address(RVA = "0x14D8D60", Offset = "0x14D7960", VA = "0x1814D8D60", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x0601B798 RID: 112536 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B798")]
			[Address(RVA = "0x14D8DF0", Offset = "0x14D79F0", VA = "0x1814D8DF0", Slot = "10")]
			protected override void OnViewAttached()
			{
			}

			// Token: 0x0601B799 RID: 112537 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B799")]
			[Address(RVA = "0x14D8EF0", Offset = "0x14D7AF0", VA = "0x1814D8EF0", Slot = "11")]
			protected override void OnViewDetached()
			{
			}

			// Token: 0x0601B79A RID: 112538 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B79A")]
			[Address(RVA = "0x14D8F50", Offset = "0x14D7B50", VA = "0x1814D8F50")]
			public void UpdateState(int selectPage)
			{
			}

			// Token: 0x04023943 RID: 145731
			[Token(Token = "0x4023943")]
			[FieldOffset(Offset = "0x20")]
			private RL04DifficultyItem.ViewData m_data;

			// Token: 0x04023944 RID: 145732
			[Token(Token = "0x4023944")]
			[FieldOffset(Offset = "0x40")]
			private int m_selectPage;

			// Token: 0x04023945 RID: 145733
			[Token(Token = "0x4023945")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04023946 RID: 145734
			[Token(Token = "0x4023946")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x04023947 RID: 145735
			[Token(Token = "0x4023947")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetPreferSize;

			// Token: 0x04023948 RID: 145736
			[Token(Token = "0x4023948")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnViewAttached;

			// Token: 0x04023949 RID: 145737
			[Token(Token = "0x4023949")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_OnViewDetached;

			// Token: 0x0402394A RID: 145738
			[Token(Token = "0x402394A")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_UpdateState;
		}

		// Token: 0x020046C8 RID: 18120
		[Token(Token = "0x20046C8")]
		private class DescListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601B79B RID: 112539 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B79B")]
			[Address(RVA = "0x14C2200", Offset = "0x14C0E00", VA = "0x1814C2200")]
			public DescListAdapter(RL04DifficultyItem item)
			{
			}

			// Token: 0x17004168 RID: 16744
			// (get) Token: 0x0601B79C RID: 112540 RVA: 0x000A5558 File Offset: 0x000A3758
			[Token(Token = "0x17004168")]
			public override int count
			{
				[Token(Token = "0x601B79C")]
				[Address(RVA = "0x14C22D0", Offset = "0x14C0ED0", VA = "0x1814C22D0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601B79D RID: 112541 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601B79D")]
			[Address(RVA = "0x14C1E50", Offset = "0x14C0A50", VA = "0x1814C1E50", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0601B79E RID: 112542 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B79E")]
			[Address(RVA = "0x14C2080", Offset = "0x14C0C80", VA = "0x1814C2080")]
			public void Swtich(RoguelikeTopicDifficultyItemStatus stateName, bool immediately)
			{
			}

			// Token: 0x0402394B RID: 145739
			[Token(Token = "0x402394B")]
			[FieldOffset(Offset = "0x20")]
			private RL04DifficultyItem m_item;

			// Token: 0x0402394C RID: 145740
			[Token(Token = "0x402394C")]
			[FieldOffset(Offset = "0x28")]
			public List<string> descriptions;

			// Token: 0x0402394D RID: 145741
			[Token(Token = "0x402394D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402394E RID: 145742
			[Token(Token = "0x402394E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402394F RID: 145743
			[Token(Token = "0x402394F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04023950 RID: 145744
			[Token(Token = "0x4023950")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_Swtich;
		}
	}
}
