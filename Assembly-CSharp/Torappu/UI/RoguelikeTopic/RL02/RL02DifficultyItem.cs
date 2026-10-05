using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL02
{
	// Token: 0x020045FD RID: 17917
	[Token(Token = "0x20045FD")]
	public class RL02DifficultyItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601B3C0 RID: 111552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B3C0")]
		[Address(RVA = "0x145DAF0", Offset = "0x145C6F0", VA = "0x18145DAF0")]
		public void Render(RL02DifficultyItem.ViewData data)
		{
		}

		// Token: 0x0601B3C1 RID: 111553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B3C1")]
		[Address(RVA = "0x145E290", Offset = "0x145CE90", VA = "0x18145E290")]
		public void UpdateState(RL02DifficultyItem.ViewData data, bool include, bool select, bool immediately)
		{
		}

		// Token: 0x0601B3C2 RID: 111554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B3C2")]
		[Address(RVA = "0x145DA70", Offset = "0x145C670", VA = "0x18145DA70")]
		public void EventOnClick()
		{
		}

		// Token: 0x0601B3C3 RID: 111555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B3C3")]
		[Address(RVA = "0x145E550", Offset = "0x145D150", VA = "0x18145E550")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601B3C4 RID: 111556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B3C4")]
		[Address(RVA = "0x145E6D0", Offset = "0x145D2D0", VA = "0x18145E6D0")]
		public RL02DifficultyItem()
		{
		}

		// Token: 0x040231EB RID: 143851
		[Token(Token = "0x40231EB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _normalTitle;

		// Token: 0x040231EC RID: 143852
		[Token(Token = "0x40231EC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _hardTitle;

		// Token: 0x040231ED RID: 143853
		[Token(Token = "0x40231ED")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _name;

		// Token: 0x040231EE RID: 143854
		[Token(Token = "0x40231EE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _subName;

		// Token: 0x040231EF RID: 143855
		[Token(Token = "0x40231EF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _gradeLvl;

		// Token: 0x040231F0 RID: 143856
		[Token(Token = "0x40231F0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SimpleLayoutContent _descList;

		// Token: 0x040231F1 RID: 143857
		[Token(Token = "0x40231F1")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _descNormalColor;

		// Token: 0x040231F2 RID: 143858
		[Token(Token = "0x40231F2")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Color _descBuffColor;

		// Token: 0x040231F3 RID: 143859
		[Token(Token = "0x40231F3")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _warnningTag;

		// Token: 0x040231F4 RID: 143860
		[Token(Token = "0x40231F4")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _lockedTag;

		// Token: 0x040231F5 RID: 143861
		[Token(Token = "0x40231F5")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _lockedDesc;

		// Token: 0x040231F6 RID: 143862
		[Token(Token = "0x40231F6")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _newTag;

		// Token: 0x040231F7 RID: 143863
		[Token(Token = "0x40231F7")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RoguelikeTopicDifficultyItemColors[] _stateClrTargets;

		// Token: 0x040231F8 RID: 143864
		[Token(Token = "0x40231F8")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private RoguelikeTopicDifficultyItemColors[] _mainClrTargets;

		// Token: 0x040231F9 RID: 143865
		[Token(Token = "0x40231F9")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Image _colorLine;

		// Token: 0x040231FA RID: 143866
		[Token(Token = "0x40231FA")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_inited;

		// Token: 0x040231FB RID: 143867
		[Token(Token = "0x40231FB")]
		[FieldOffset(Offset = "0xA8")]
		private Action<int> m_onClick;

		// Token: 0x040231FC RID: 143868
		[Token(Token = "0x40231FC")]
		[FieldOffset(Offset = "0xB0")]
		private int m_index;

		// Token: 0x040231FD RID: 143869
		[Token(Token = "0x40231FD")]
		[FieldOffset(Offset = "0xB8")]
		private RL02DifficultyItem.DescListAdapter m_descAdapter;

		// Token: 0x040231FE RID: 143870
		[Token(Token = "0x40231FE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040231FF RID: 143871
		[Token(Token = "0x40231FF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x04023200 RID: 143872
		[Token(Token = "0x4023200")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnClick;

		// Token: 0x04023201 RID: 143873
		[Token(Token = "0x4023201")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04023202 RID: 143874
		[Token(Token = "0x4023202")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020045FE RID: 17918
		[Token(Token = "0x20045FE")]
		public struct ViewData
		{
			// Token: 0x04023203 RID: 143875
			[Token(Token = "0x4023203")]
			[FieldOffset(Offset = "0x0")]
			public RL02DifficultyItem prefab;

			// Token: 0x04023204 RID: 143876
			[Token(Token = "0x4023204")]
			[FieldOffset(Offset = "0x8")]
			public RL02DifficultyViewModel itemModel;

			// Token: 0x04023205 RID: 143877
			[Token(Token = "0x4023205")]
			[FieldOffset(Offset = "0x10")]
			public int pageIndex;

			// Token: 0x04023206 RID: 143878
			[Token(Token = "0x4023206")]
			[FieldOffset(Offset = "0x18")]
			public Action<int> onItemClicked;
		}

		// Token: 0x020045FF RID: 17919
		[Token(Token = "0x20045FF")]
		public class VirtualView : UIRecycleLayoutAdapter.VirtualView<RL02DifficultyItem>
		{
			// Token: 0x0601B3C5 RID: 111557 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B3C5")]
			[Address(RVA = "0x146FFB0", Offset = "0x146EBB0", VA = "0x18146FFB0")]
			public VirtualView(RL02DifficultyItem.ViewData data)
			{
			}

			// Token: 0x0601B3C6 RID: 111558 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601B3C6")]
			[Address(RVA = "0x146FC40", Offset = "0x146E840", VA = "0x18146FC40", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x0601B3C7 RID: 111559 RVA: 0x000A4BF8 File Offset: 0x000A2DF8
			[Token(Token = "0x601B3C7")]
			[Address(RVA = "0x146FCB0", Offset = "0x146E8B0", VA = "0x18146FCB0", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x0601B3C8 RID: 111560 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B3C8")]
			[Address(RVA = "0x146FD40", Offset = "0x146E940", VA = "0x18146FD40", Slot = "10")]
			protected override void OnViewAttached()
			{
			}

			// Token: 0x0601B3C9 RID: 111561 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B3C9")]
			[Address(RVA = "0x146FE40", Offset = "0x146EA40", VA = "0x18146FE40", Slot = "11")]
			protected override void OnViewDetached()
			{
			}

			// Token: 0x0601B3CA RID: 111562 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B3CA")]
			[Address(RVA = "0x146FEA0", Offset = "0x146EAA0", VA = "0x18146FEA0")]
			public void UpdateState(int selectPage)
			{
			}

			// Token: 0x04023207 RID: 143879
			[Token(Token = "0x4023207")]
			[FieldOffset(Offset = "0x20")]
			private RL02DifficultyItem.ViewData m_data;

			// Token: 0x04023208 RID: 143880
			[Token(Token = "0x4023208")]
			[FieldOffset(Offset = "0x40")]
			private int m_selectPage;

			// Token: 0x04023209 RID: 143881
			[Token(Token = "0x4023209")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402320A RID: 143882
			[Token(Token = "0x402320A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x0402320B RID: 143883
			[Token(Token = "0x402320B")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetPreferSize;

			// Token: 0x0402320C RID: 143884
			[Token(Token = "0x402320C")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnViewAttached;

			// Token: 0x0402320D RID: 143885
			[Token(Token = "0x402320D")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_OnViewDetached;

			// Token: 0x0402320E RID: 143886
			[Token(Token = "0x402320E")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_UpdateState;
		}

		// Token: 0x02004600 RID: 17920
		[Token(Token = "0x2004600")]
		private class DescListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601B3CB RID: 111563 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B3CB")]
			[Address(RVA = "0x145AA80", Offset = "0x1459680", VA = "0x18145AA80")]
			public DescListAdapter(RL02DifficultyItem item)
			{
			}

			// Token: 0x170040F7 RID: 16631
			// (get) Token: 0x0601B3CC RID: 111564 RVA: 0x000A4C10 File Offset: 0x000A2E10
			[Token(Token = "0x170040F7")]
			public override int count
			{
				[Token(Token = "0x601B3CC")]
				[Address(RVA = "0x145AB50", Offset = "0x1459750", VA = "0x18145AB50", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601B3CD RID: 111565 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601B3CD")]
			[Address(RVA = "0x145A6D0", Offset = "0x14592D0", VA = "0x18145A6D0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0601B3CE RID: 111566 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B3CE")]
			[Address(RVA = "0x145A900", Offset = "0x1459500", VA = "0x18145A900")]
			public void Switch(RoguelikeTopicDifficultyItemStatus stateName, bool immediately)
			{
			}

			// Token: 0x0402320F RID: 143887
			[Token(Token = "0x402320F")]
			[FieldOffset(Offset = "0x20")]
			private RL02DifficultyItem m_item;

			// Token: 0x04023210 RID: 143888
			[Token(Token = "0x4023210")]
			[FieldOffset(Offset = "0x28")]
			public List<string> descriptions;

			// Token: 0x04023211 RID: 143889
			[Token(Token = "0x4023211")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04023212 RID: 143890
			[Token(Token = "0x4023212")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04023213 RID: 143891
			[Token(Token = "0x4023213")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04023214 RID: 143892
			[Token(Token = "0x4023214")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_Switch;
		}

		// Token: 0x02004601 RID: 17921
		[Token(Token = "0x2004601")]
		public static class StateNames
		{
			// Token: 0x04023215 RID: 143893
			[Token(Token = "0x4023215")]
			[FieldOffset(Offset = "0x0")]
			public static string INCLUDE;

			// Token: 0x04023216 RID: 143894
			[Token(Token = "0x4023216")]
			[FieldOffset(Offset = "0x8")]
			public static string SELECTED;

			// Token: 0x04023217 RID: 143895
			[Token(Token = "0x4023217")]
			[FieldOffset(Offset = "0x10")]
			public static string EXCLUSIVE;
		}
	}
}
