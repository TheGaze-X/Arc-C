using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E10 RID: 28176
	[Token(Token = "0x2006E10")]
	public class ActVecBreakV2DefenseBuffListPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x060281BD RID: 164285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60281BD")]
		[Address(RVA = "0x235EC70", Offset = "0x235D870", VA = "0x18235EC70")]
		public void Render(ActVecBreakV2DefenseStageSelectViewModel viewModel)
		{
		}

		// Token: 0x060281BE RID: 164286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60281BE")]
		[Address(RVA = "0x235F310", Offset = "0x235DF10", VA = "0x18235F310")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060281BF RID: 164287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60281BF")]
		[Address(RVA = "0x235F220", Offset = "0x235DE20", VA = "0x18235F220")]
		private void _EventOnBuffItemClick(string stageId)
		{
		}

		// Token: 0x060281C0 RID: 164288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60281C0")]
		[Address(RVA = "0x235F500", Offset = "0x235E100", VA = "0x18235F500")]
		private void _PlaySelectPanelEnterAnim()
		{
		}

		// Token: 0x060281C1 RID: 164289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60281C1")]
		[Address(RVA = "0x235F640", Offset = "0x235E240", VA = "0x18235F640")]
		public ActVecBreakV2DefenseBuffListPanel()
		{
		}

		// Token: 0x04038EB2 RID: 233138
		[Token(Token = "0x4038EB2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _buffListContent;

		// Token: 0x04038EB3 RID: 233139
		[Token(Token = "0x4038EB3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _rewardContent;

		// Token: 0x04038EB4 RID: 233140
		[Token(Token = "0x4038EB4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _selectedBuffPanel;

		// Token: 0x04038EB5 RID: 233141
		[Token(Token = "0x4038EB5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _selectedBuffNum;

		// Token: 0x04038EB6 RID: 233142
		[Token(Token = "0x4038EB6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _maxBuffNum;

		// Token: 0x04038EB7 RID: 233143
		[Token(Token = "0x4038EB7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ActVecBreakV2DefenseBuffItem _itemPrefab;

		// Token: 0x04038EB8 RID: 233144
		[Token(Token = "0x4038EB8")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private VerticalLayoutGroup _vertLayoutGroup;

		// Token: 0x04038EB9 RID: 233145
		[Token(Token = "0x4038EB9")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private HorizontalLayoutGroup _horizonLayoutGroup;

		// Token: 0x04038EBA RID: 233146
		[Token(Token = "0x4038EBA")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAnimationLocation _selectInAnim;

		// Token: 0x04038EBB RID: 233147
		[Token(Token = "0x4038EBB")]
		[FieldOffset(Offset = "0x68")]
		private bool m_hasInited;

		// Token: 0x04038EBC RID: 233148
		[Token(Token = "0x4038EBC")]
		[FieldOffset(Offset = "0x70")]
		private List<ActVecBreakV2DefenseBuffListItemModel> m_cacheListItemModels;

		// Token: 0x04038EBD RID: 233149
		[Token(Token = "0x4038EBD")]
		[FieldOffset(Offset = "0x78")]
		private List<string> m_cacheSelectedBuffIds;

		// Token: 0x04038EBE RID: 233150
		[Token(Token = "0x4038EBE")]
		[FieldOffset(Offset = "0x80")]
		private ActVecBreakV2DefenseBuffListPanel.Adapter m_buffItemAdapter;

		// Token: 0x04038EBF RID: 233151
		[Token(Token = "0x4038EBF")]
		[FieldOffset(Offset = "0x88")]
		private ActVecBreakV2DefenseBuffListPanel.Adapter m_rewardAdapter;

		// Token: 0x04038EC0 RID: 233152
		[Token(Token = "0x4038EC0")]
		[FieldOffset(Offset = "0x90")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04038EC1 RID: 233153
		[Token(Token = "0x4038EC1")]
		[FieldOffset(Offset = "0xA0")]
		private Tween m_selectPanelEnterTween;

		// Token: 0x04038EC2 RID: 233154
		[Token(Token = "0x4038EC2")]
		[FieldOffset(Offset = "0xA8")]
		private int m_cacheSelectStageSeqNum;

		// Token: 0x04038EC3 RID: 233155
		[Token(Token = "0x4038EC3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04038EC4 RID: 233156
		[Token(Token = "0x4038EC4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04038EC5 RID: 233157
		[Token(Token = "0x4038EC5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__EventOnBuffItemClick;

		// Token: 0x04038EC6 RID: 233158
		[Token(Token = "0x4038EC6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__PlaySelectPanelEnterAnim;

		// Token: 0x04038EC7 RID: 233159
		[Token(Token = "0x4038EC7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006E11 RID: 28177
		[Token(Token = "0x2006E11")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x060281C2 RID: 164290 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60281C2")]
			[Address(RVA = "0x2372880", Offset = "0x2371480", VA = "0x182372880")]
			public Adapter(ActVecBreakV2DefenseBuffListPanel closure)
			{
			}

			// Token: 0x17005ED6 RID: 24278
			// (get) Token: 0x060281C3 RID: 164291 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060281C4 RID: 164292 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17005ED6")]
			public Action<string> onItemClick
			{
				[Token(Token = "0x60281C3")]
				[Address(RVA = "0x2372B60", Offset = "0x2371760", VA = "0x182372B60")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x60281C4")]
				[Address(RVA = "0x2372C40", Offset = "0x2371840", VA = "0x182372C40")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17005ED7 RID: 24279
			// (get) Token: 0x060281C5 RID: 164293 RVA: 0x000D0B00 File Offset: 0x000CED00
			[Token(Token = "0x17005ED7")]
			public override int count
			{
				[Token(Token = "0x60281C5")]
				[Address(RVA = "0x2372A00", Offset = "0x2371600", VA = "0x182372A00", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060281C6 RID: 164294 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60281C6")]
			[Address(RVA = "0x23725C0", Offset = "0x23711C0", VA = "0x1823725C0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04038EC8 RID: 233160
			[Token(Token = "0x4038EC8")]
			[FieldOffset(Offset = "0x20")]
			private ActVecBreakV2DefenseBuffListPanel m_closure;

			// Token: 0x04038ECA RID: 233162
			[Token(Token = "0x4038ECA")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04038ECB RID: 233163
			[Token(Token = "0x4038ECB")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_onItemClick;

			// Token: 0x04038ECC RID: 233164
			[Token(Token = "0x4038ECC")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_set_onItemClick;

			// Token: 0x04038ECD RID: 233165
			[Token(Token = "0x4038ECD")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04038ECE RID: 233166
			[Token(Token = "0x4038ECE")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
