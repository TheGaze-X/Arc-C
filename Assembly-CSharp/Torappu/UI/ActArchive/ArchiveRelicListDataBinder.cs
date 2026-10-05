using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006C05 RID: 27653
	[Token(Token = "0x2006C05")]
	public class ArchiveRelicListDataBinder : DataBinder<RelicProperty>
	{
		// Token: 0x17005D30 RID: 23856
		// (get) Token: 0x060277CC RID: 161740 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060277CD RID: 161741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005D30")]
		public ArchiveRelicController controller
		{
			[Token(Token = "0x60277CC")]
			[Address(RVA = "0x22AF570", Offset = "0x22AE170", VA = "0x1822AF570")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60277CD")]
			[Address(RVA = "0x22AF5D0", Offset = "0x22AE1D0", VA = "0x1822AF5D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060277CE RID: 161742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60277CE")]
		[Address(RVA = "0x22AE3A0", Offset = "0x22ACFA0", VA = "0x1822AE3A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060277CF RID: 161743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60277CF")]
		[Address(RVA = "0x22ADFB0", Offset = "0x22ACBB0", VA = "0x1822ADFB0", Slot = "7")]
		public override void OnValueChanged(RelicProperty property)
		{
		}

		// Token: 0x060277D0 RID: 161744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60277D0")]
		[Address(RVA = "0x22AE5C0", Offset = "0x22AD1C0", VA = "0x1822AE5C0")]
		private void _RenderDetail(ArchiveRelicModel model)
		{
		}

		// Token: 0x060277D1 RID: 161745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60277D1")]
		[Address(RVA = "0x22AEDF0", Offset = "0x22AD9F0", VA = "0x1822AEDF0")]
		private void _RenderNormalDetail(RelicItemModel detailItem)
		{
		}

		// Token: 0x060277D2 RID: 161746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60277D2")]
		[Address(RVA = "0x22AE7D0", Offset = "0x22AD3D0", VA = "0x1822AE7D0")]
		private void _RenderDifficultyDetail(RelicItemModel rootRelic, int index)
		{
		}

		// Token: 0x060277D3 RID: 161747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60277D3")]
		[Address(RVA = "0x22AF4E0", Offset = "0x22AE0E0", VA = "0x1822AF4E0")]
		public ArchiveRelicListDataBinder()
		{
		}

		// Token: 0x04037F72 RID: 229234
		[Token(Token = "0x4037F72")]
		private const string LOCKED_RELIC_DETAIL_TITLE = "???";

		// Token: 0x04037F73 RID: 229235
		[Token(Token = "0x4037F73")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ArchiveRelicRecycleAdapter _adapter;

		// Token: 0x04037F74 RID: 229236
		[Token(Token = "0x4037F74")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LoopVerticalScrollRect _scrollRect;

		// Token: 0x04037F75 RID: 229237
		[Token(Token = "0x4037F75")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Item detail panel")]
		private Text _textTitle;

		// Token: 0x04037F76 RID: 229238
		[Token(Token = "0x4037F76")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Item detail panel")]
		private Image _imgItem;

		// Token: 0x04037F77 RID: 229239
		[Token(Token = "0x4037F77")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Item detail panel")]
		private Text _textUsage;

		// Token: 0x04037F78 RID: 229240
		[Token(Token = "0x4037F78")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Item detail panel")]
		private Text _textDesc;

		// Token: 0x04037F79 RID: 229241
		[Token(Token = "0x4037F79")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Item detail panel")]
		private Text _textOrderId;

		// Token: 0x04037F7A RID: 229242
		[Token(Token = "0x4037F7A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Item detail panel")]
		private Color _attainedColor;

		// Token: 0x04037F7B RID: 229243
		[Token(Token = "0x4037F7B")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Item detail panel")]
		private Color _unattainedColor;

		// Token: 0x04037F7C RID: 229244
		[Token(Token = "0x4037F7C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Item detail panel")]
		private Text _textLockedTitle;

		// Token: 0x04037F7D RID: 229245
		[Token(Token = "0x4037F7D")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Item detail panel")]
		private GameObject _lockedBg;

		// Token: 0x04037F7E RID: 229246
		[Token(Token = "0x4037F7E")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Item detail panel")]
		private GameObject _emptyPanel;

		// Token: 0x04037F7F RID: 229247
		[Token(Token = "0x4037F7F")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Item detail panel")]
		private Text _emptyText;

		// Token: 0x04037F80 RID: 229248
		[Token(Token = "0x4037F80")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Item detail panel")]
		private CanvasGroup _textGroup;

		// Token: 0x04037F81 RID: 229249
		[Token(Token = "0x4037F81")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Item detail panel")]
		private Text _difficultyDescText;

		// Token: 0x04037F82 RID: 229250
		[Token(Token = "0x4037F82")]
		[FieldOffset(Offset = "0xA8")]
		[Space(8f)]
		[SerializeField]
		[Group("Item detail panel")]
		private GameObject _switchPanel;

		// Token: 0x04037F83 RID: 229251
		[Token(Token = "0x4037F83")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Item detail panel")]
		private SimpleLayoutContent _switchSpotContent;

		// Token: 0x04037F84 RID: 229252
		[Token(Token = "0x4037F84")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private List<ArchiveRelicSortButtonView> _sortRuleList;

		// Token: 0x04037F85 RID: 229253
		[Token(Token = "0x4037F85")]
		[FieldOffset(Offset = "0xC0")]
		private ArchiveRelicController m_controller;

		// Token: 0x04037F86 RID: 229254
		[Token(Token = "0x4037F86")]
		[FieldOffset(Offset = "0xC8")]
		private bool m_hasInited;

		// Token: 0x04037F87 RID: 229255
		[Token(Token = "0x4037F87")]
		[FieldOffset(Offset = "0xCC")]
		private FilterRule m_cachedRule;

		// Token: 0x04037F88 RID: 229256
		[Token(Token = "0x4037F88")]
		[FieldOffset(Offset = "0xD0")]
		private ArchiveRelicListDataBinder.Adapter m_spotAdapter;

		// Token: 0x04037F89 RID: 229257
		[Token(Token = "0x4037F89")]
		[FieldOffset(Offset = "0xD8")]
		private int m_cachedSelectedDifficultyCount;

		// Token: 0x04037F8A RID: 229258
		[Token(Token = "0x4037F8A")]
		[FieldOffset(Offset = "0xDC")]
		private int m_cachedSelectedDifficultyIndex;

		// Token: 0x04037F8B RID: 229259
		[Token(Token = "0x4037F8B")]
		[FieldOffset(Offset = "0xE0")]
		private int m_cachedDefaultDifficultyIndex;

		// Token: 0x04037F8C RID: 229260
		[Token(Token = "0x4037F8C")]
		[FieldOffset(Offset = "0xE4")]
		private int m_cachedSelectLine;

		// Token: 0x04037F8E RID: 229262
		[Token(Token = "0x4037F8E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x04037F8F RID: 229263
		[Token(Token = "0x4037F8F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x04037F90 RID: 229264
		[Token(Token = "0x4037F90")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04037F91 RID: 229265
		[Token(Token = "0x4037F91")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04037F92 RID: 229266
		[Token(Token = "0x4037F92")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderDetail;

		// Token: 0x04037F93 RID: 229267
		[Token(Token = "0x4037F93")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderNormalDetail;

		// Token: 0x04037F94 RID: 229268
		[Token(Token = "0x4037F94")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderDifficultyDetail;

		// Token: 0x04037F95 RID: 229269
		[Token(Token = "0x4037F95")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006C06 RID: 27654
		[Token(Token = "0x2006C06")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x17005D31 RID: 23857
			// (get) Token: 0x060277D4 RID: 161748 RVA: 0x000CE880 File Offset: 0x000CCA80
			[Token(Token = "0x17005D31")]
			public override int count
			{
				[Token(Token = "0x60277D4")]
				[Address(RVA = "0x22A7AC0", Offset = "0x22A66C0", VA = "0x1822A7AC0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060277D5 RID: 161749 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60277D5")]
			[Address(RVA = "0x22A7A40", Offset = "0x22A6640", VA = "0x1822A7A40")]
			public Adapter(ArchiveRelicListDataBinder closure)
			{
			}

			// Token: 0x060277D6 RID: 161750 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60277D6")]
			[Address(RVA = "0x22A7870", Offset = "0x22A6470", VA = "0x1822A7870", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04037F96 RID: 229270
			[Token(Token = "0x4037F96")]
			[FieldOffset(Offset = "0x20")]
			private ArchiveRelicListDataBinder m_closure;

			// Token: 0x04037F97 RID: 229271
			[Token(Token = "0x4037F97")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04037F98 RID: 229272
			[Token(Token = "0x4037F98")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04037F99 RID: 229273
			[Token(Token = "0x4037F99")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
