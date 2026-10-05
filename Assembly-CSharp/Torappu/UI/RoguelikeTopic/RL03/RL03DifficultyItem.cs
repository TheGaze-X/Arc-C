using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL03
{
	// Token: 0x020045B1 RID: 17841
	[Token(Token = "0x20045B1")]
	public class RL03DifficultyItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601B25B RID: 111195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B25B")]
		[Address(RVA = "0x1446BF0", Offset = "0x14457F0", VA = "0x181446BF0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601B25C RID: 111196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B25C")]
		[Address(RVA = "0x1446180", Offset = "0x1444D80", VA = "0x181446180")]
		public void Render(RL03DifficultyItem.ViewData data)
		{
		}

		// Token: 0x0601B25D RID: 111197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B25D")]
		[Address(RVA = "0x14468E0", Offset = "0x14454E0", VA = "0x1814468E0")]
		public void UpdateState(RL03DifficultyItem.ViewData data, bool include, bool selected, bool immediately)
		{
		}

		// Token: 0x0601B25E RID: 111198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B25E")]
		[Address(RVA = "0x1446100", Offset = "0x1444D00", VA = "0x181446100")]
		public void EventOnClick()
		{
		}

		// Token: 0x0601B25F RID: 111199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B25F")]
		[Address(RVA = "0x1446D70", Offset = "0x1445970", VA = "0x181446D70")]
		public RL03DifficultyItem()
		{
		}

		// Token: 0x04022F38 RID: 143160
		[Token(Token = "0x4022F38")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _normalTitle;

		// Token: 0x04022F39 RID: 143161
		[Token(Token = "0x4022F39")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _hardTitle;

		// Token: 0x04022F3A RID: 143162
		[Token(Token = "0x4022F3A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _name;

		// Token: 0x04022F3B RID: 143163
		[Token(Token = "0x4022F3B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _subName;

		// Token: 0x04022F3C RID: 143164
		[Token(Token = "0x4022F3C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _gradeLvl;

		// Token: 0x04022F3D RID: 143165
		[Token(Token = "0x4022F3D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SimpleLayoutContent _descList;

		// Token: 0x04022F3E RID: 143166
		[Token(Token = "0x4022F3E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _descNormalColor;

		// Token: 0x04022F3F RID: 143167
		[Token(Token = "0x4022F3F")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Color _descBuffColor;

		// Token: 0x04022F40 RID: 143168
		[Token(Token = "0x4022F40")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _warnningTag;

		// Token: 0x04022F41 RID: 143169
		[Token(Token = "0x4022F41")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _lockedTag;

		// Token: 0x04022F42 RID: 143170
		[Token(Token = "0x4022F42")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _lockedDesc;

		// Token: 0x04022F43 RID: 143171
		[Token(Token = "0x4022F43")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _newTag;

		// Token: 0x04022F44 RID: 143172
		[Token(Token = "0x4022F44")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private TwoStateFadeSwitcher _buffTag;

		// Token: 0x04022F45 RID: 143173
		[Token(Token = "0x4022F45")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private RoguelikeTopicDifficultyItemColors[] _stateClrTargets;

		// Token: 0x04022F46 RID: 143174
		[Token(Token = "0x4022F46")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private RoguelikeTopicDifficultyItemColors[] _mainClrTargets;

		// Token: 0x04022F47 RID: 143175
		[Token(Token = "0x4022F47")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Image _colorLine;

		// Token: 0x04022F48 RID: 143176
		[Token(Token = "0x4022F48")]
		[FieldOffset(Offset = "0xA8")]
		private Action<int> m_onClick;

		// Token: 0x04022F49 RID: 143177
		[Token(Token = "0x4022F49")]
		[FieldOffset(Offset = "0xB0")]
		private int m_index;

		// Token: 0x04022F4A RID: 143178
		[Token(Token = "0x4022F4A")]
		[FieldOffset(Offset = "0xB8")]
		private RL03DifficultyItem.DescListAdapter m_descAdapter;

		// Token: 0x04022F4B RID: 143179
		[Token(Token = "0x4022F4B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04022F4C RID: 143180
		[Token(Token = "0x4022F4C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04022F4D RID: 143181
		[Token(Token = "0x4022F4D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x04022F4E RID: 143182
		[Token(Token = "0x4022F4E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnClick;

		// Token: 0x04022F4F RID: 143183
		[Token(Token = "0x4022F4F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020045B2 RID: 17842
		[Token(Token = "0x20045B2")]
		public struct ViewData
		{
			// Token: 0x04022F50 RID: 143184
			[Token(Token = "0x4022F50")]
			[FieldOffset(Offset = "0x0")]
			public RL03DifficultyItem prefab;

			// Token: 0x04022F51 RID: 143185
			[Token(Token = "0x4022F51")]
			[FieldOffset(Offset = "0x8")]
			public RL03DifficultyViewModel itemModel;

			// Token: 0x04022F52 RID: 143186
			[Token(Token = "0x4022F52")]
			[FieldOffset(Offset = "0x10")]
			public int pageIndex;

			// Token: 0x04022F53 RID: 143187
			[Token(Token = "0x4022F53")]
			[FieldOffset(Offset = "0x18")]
			public Action<int> onItemClicked;
		}

		// Token: 0x020045B3 RID: 17843
		[Token(Token = "0x20045B3")]
		public class VirtualView : UIRecycleLayoutAdapter.VirtualView<RL03DifficultyItem>
		{
			// Token: 0x0601B260 RID: 111200 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B260")]
			[Address(RVA = "0x145A020", Offset = "0x1458C20", VA = "0x18145A020")]
			public VirtualView(RL03DifficultyItem.ViewData data)
			{
			}

			// Token: 0x0601B261 RID: 111201 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601B261")]
			[Address(RVA = "0x1459CB0", Offset = "0x14588B0", VA = "0x181459CB0", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x0601B262 RID: 111202 RVA: 0x000A47F0 File Offset: 0x000A29F0
			[Token(Token = "0x601B262")]
			[Address(RVA = "0x1459D20", Offset = "0x1458920", VA = "0x181459D20", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x0601B263 RID: 111203 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B263")]
			[Address(RVA = "0x1459DB0", Offset = "0x14589B0", VA = "0x181459DB0", Slot = "10")]
			protected override void OnViewAttached()
			{
			}

			// Token: 0x0601B264 RID: 111204 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B264")]
			[Address(RVA = "0x1459EB0", Offset = "0x1458AB0", VA = "0x181459EB0", Slot = "11")]
			protected override void OnViewDetached()
			{
			}

			// Token: 0x0601B265 RID: 111205 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B265")]
			[Address(RVA = "0x1459F10", Offset = "0x1458B10", VA = "0x181459F10")]
			public void UpdateState(int selectPage)
			{
			}

			// Token: 0x04022F54 RID: 143188
			[Token(Token = "0x4022F54")]
			[FieldOffset(Offset = "0x20")]
			private RL03DifficultyItem.ViewData m_data;

			// Token: 0x04022F55 RID: 143189
			[Token(Token = "0x4022F55")]
			[FieldOffset(Offset = "0x40")]
			private int m_selectPage;

			// Token: 0x04022F56 RID: 143190
			[Token(Token = "0x4022F56")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04022F57 RID: 143191
			[Token(Token = "0x4022F57")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x04022F58 RID: 143192
			[Token(Token = "0x4022F58")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetPreferSize;

			// Token: 0x04022F59 RID: 143193
			[Token(Token = "0x4022F59")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnViewAttached;

			// Token: 0x04022F5A RID: 143194
			[Token(Token = "0x4022F5A")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_OnViewDetached;

			// Token: 0x04022F5B RID: 143195
			[Token(Token = "0x4022F5B")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_UpdateState;
		}

		// Token: 0x020045B4 RID: 17844
		[Token(Token = "0x20045B4")]
		public static class StateNames
		{
			// Token: 0x04022F5C RID: 143196
			[Token(Token = "0x4022F5C")]
			[FieldOffset(Offset = "0x0")]
			public static string INCLUDE;

			// Token: 0x04022F5D RID: 143197
			[Token(Token = "0x4022F5D")]
			[FieldOffset(Offset = "0x8")]
			public static string SELECTED;

			// Token: 0x04022F5E RID: 143198
			[Token(Token = "0x4022F5E")]
			[FieldOffset(Offset = "0x10")]
			public static string EXCLUSIVE;
		}

		// Token: 0x020045B5 RID: 17845
		[Token(Token = "0x20045B5")]
		private class DescListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601B267 RID: 111207 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B267")]
			[Address(RVA = "0x1444AC0", Offset = "0x14436C0", VA = "0x181444AC0")]
			public DescListAdapter(RL03DifficultyItem item)
			{
			}

			// Token: 0x170040AE RID: 16558
			// (get) Token: 0x0601B268 RID: 111208 RVA: 0x000A4808 File Offset: 0x000A2A08
			[Token(Token = "0x170040AE")]
			public override int count
			{
				[Token(Token = "0x601B268")]
				[Address(RVA = "0x1444B90", Offset = "0x1443790", VA = "0x181444B90", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601B269 RID: 111209 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601B269")]
			[Address(RVA = "0x1444710", Offset = "0x1443310", VA = "0x181444710", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0601B26A RID: 111210 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B26A")]
			[Address(RVA = "0x1444940", Offset = "0x1443540", VA = "0x181444940")]
			public void Swtich(RoguelikeTopicDifficultyItemStatus stateName, bool immediately)
			{
			}

			// Token: 0x04022F5F RID: 143199
			[Token(Token = "0x4022F5F")]
			[FieldOffset(Offset = "0x20")]
			private RL03DifficultyItem m_item;

			// Token: 0x04022F60 RID: 143200
			[Token(Token = "0x4022F60")]
			[FieldOffset(Offset = "0x28")]
			public List<string> descriptions;

			// Token: 0x04022F61 RID: 143201
			[Token(Token = "0x4022F61")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04022F62 RID: 143202
			[Token(Token = "0x4022F62")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04022F63 RID: 143203
			[Token(Token = "0x4022F63")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04022F64 RID: 143204
			[Token(Token = "0x4022F64")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_Swtich;
		}
	}
}
