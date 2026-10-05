using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006BF8 RID: 27640
	[Token(Token = "0x2006BF8")]
	public class ArchiveQuestListView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005D27 RID: 23847
		// (get) Token: 0x0602777E RID: 161662 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602777F RID: 161663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005D27")]
		public Action<int> itemSelectEvent
		{
			[Token(Token = "0x602777E")]
			[Address(RVA = "0x22AB820", Offset = "0x22AA420", VA = "0x1822AB820")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602777F")]
			[Address(RVA = "0x22AB880", Offset = "0x22AA480", VA = "0x1822AB880")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06027780 RID: 161664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027780")]
		[Address(RVA = "0x22AA260", Offset = "0x22A8E60", VA = "0x1822AA260")]
		public void InitItems(SandboxV2ArchiveQuestType type, List<ArchiveQuestItemModel> items)
		{
		}

		// Token: 0x06027781 RID: 161665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027781")]
		[Address(RVA = "0x22AA7E0", Offset = "0x22A93E0", VA = "0x1822AA7E0")]
		public void UpdateItems(int focusIndex)
		{
		}

		// Token: 0x06027782 RID: 161666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027782")]
		[Address(RVA = "0x22AB710", Offset = "0x22AA310", VA = "0x1822AB710")]
		private void _SetFirstAndLast()
		{
		}

		// Token: 0x06027783 RID: 161667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027783")]
		[Address(RVA = "0x22AB290", Offset = "0x22A9E90", VA = "0x1822AB290")]
		private void _GenerateMainItems(List<ArchiveQuestItemModel> items)
		{
		}

		// Token: 0x06027784 RID: 161668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027784")]
		[Address(RVA = "0x22AB410", Offset = "0x22AA010", VA = "0x1822AB410")]
		private void _GenerateSideItems(List<ArchiveQuestItemModel> items)
		{
		}

		// Token: 0x06027785 RID: 161669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027785")]
		[Address(RVA = "0x22AB160", Offset = "0x22A9D60", VA = "0x1822AB160")]
		private ArchiveQuestListItemView.ViewParam _GenerateItemView(int index, ArchiveQuestItemModel item)
		{
			return null;
		}

		// Token: 0x06027786 RID: 161670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027786")]
		[Address(RVA = "0x22AA9D0", Offset = "0x22A95D0", VA = "0x1822AA9D0")]
		private Tween _FocusOnItemIndex(int index)
		{
			return null;
		}

		// Token: 0x06027787 RID: 161671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027787")]
		[Address(RVA = "0x22AB570", Offset = "0x22AA170", VA = "0x1822AB570")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06027788 RID: 161672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027788")]
		[Address(RVA = "0x22AB7C0", Offset = "0x22AA3C0", VA = "0x1822AB7C0")]
		public ArchiveQuestListView()
		{
		}

		// Token: 0x04037EF8 RID: 229112
		[Token(Token = "0x4037EF8")]
		private const int FOCUS_HALF_RANGE = 5;

		// Token: 0x04037EF9 RID: 229113
		[Token(Token = "0x4037EF9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _mainPanel;

		// Token: 0x04037EFA RID: 229114
		[Token(Token = "0x4037EFA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _sidePanel;

		// Token: 0x04037EFB RID: 229115
		[Token(Token = "0x4037EFB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LoopScrollRect _loopRect;

		// Token: 0x04037EFC RID: 229116
		[Token(Token = "0x4037EFC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ArchiveQuestListLoopAdapter _loopAdapter;

		// Token: 0x04037EFD RID: 229117
		[Token(Token = "0x4037EFD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GridLayoutGroup _loopLayout;

		// Token: 0x04037EFE RID: 229118
		[Token(Token = "0x4037EFE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CanvasGroup _loopGroup;

		// Token: 0x04037EFF RID: 229119
		[Token(Token = "0x4037EFF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _focusDuration;

		// Token: 0x04037F00 RID: 229120
		[Token(Token = "0x4037F00")]
		[FieldOffset(Offset = "0x4C")]
		private bool m_hasInited;

		// Token: 0x04037F01 RID: 229121
		[Token(Token = "0x4037F01")]
		[FieldOffset(Offset = "0x50")]
		private List<ArchiveQuestListItemView.ViewParam> m_viewParams;

		// Token: 0x04037F02 RID: 229122
		[Token(Token = "0x4037F02")]
		[FieldOffset(Offset = "0x58")]
		private int m_cachedFocusIndex;

		// Token: 0x04037F03 RID: 229123
		[Token(Token = "0x4037F03")]
		[FieldOffset(Offset = "0x60")]
		private Tween m_focusTween;

		// Token: 0x04037F05 RID: 229125
		[Token(Token = "0x4037F05")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_itemSelectEvent;

		// Token: 0x04037F06 RID: 229126
		[Token(Token = "0x4037F06")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_itemSelectEvent;

		// Token: 0x04037F07 RID: 229127
		[Token(Token = "0x4037F07")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitItems;

		// Token: 0x04037F08 RID: 229128
		[Token(Token = "0x4037F08")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateItems;

		// Token: 0x04037F09 RID: 229129
		[Token(Token = "0x4037F09")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SetFirstAndLast;

		// Token: 0x04037F0A RID: 229130
		[Token(Token = "0x4037F0A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GenerateMainItems;

		// Token: 0x04037F0B RID: 229131
		[Token(Token = "0x4037F0B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GenerateSideItems;

		// Token: 0x04037F0C RID: 229132
		[Token(Token = "0x4037F0C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GenerateItemView;

		// Token: 0x04037F0D RID: 229133
		[Token(Token = "0x4037F0D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__FocusOnItemIndex;

		// Token: 0x04037F0E RID: 229134
		[Token(Token = "0x4037F0E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04037F0F RID: 229135
		[Token(Token = "0x4037F0F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
