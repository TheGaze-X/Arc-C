using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.UI;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.Legion
{
	// Token: 0x02002A0B RID: 10763
	[Token(Token = "0x2002A0B")]
	public class UIBattleLegionShowCardLibraryPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x06011DAE RID: 73134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011DAE")]
		[Address(RVA = "0x9BC5F0", Offset = "0x9BB1F0", VA = "0x1809BC5F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06011DAF RID: 73135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011DAF")]
		[Address(RVA = "0x9BC4C0", Offset = "0x9BB0C0", VA = "0x1809BC4C0")]
		public void Init(LegionUICardShowCardLibraryState legionState, BattleLegionCardLibraryParam libraryData)
		{
		}

		// Token: 0x06011DB0 RID: 73136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011DB0")]
		[Address(RVA = "0x9BC820", Offset = "0x9BB420", VA = "0x1809BC820")]
		private void _ShowCardLibrary()
		{
		}

		// Token: 0x06011DB1 RID: 73137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011DB1")]
		[Address(RVA = "0x9BCB20", Offset = "0x9BB720", VA = "0x1809BCB20")]
		private void _SortPending(List<Deck.Card> source)
		{
		}

		// Token: 0x06011DB2 RID: 73138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011DB2")]
		[Address(RVA = "0x9BCC60", Offset = "0x9BB860", VA = "0x1809BCC60")]
		private void _SortUsed(List<Deck.Card> source)
		{
		}

		// Token: 0x06011DB3 RID: 73139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011DB3")]
		[Address(RVA = "0x9BC450", Offset = "0x9BB050", VA = "0x1809BC450")]
		public void CloseLibraryPanel()
		{
		}

		// Token: 0x06011DB4 RID: 73140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011DB4")]
		[Address(RVA = "0x9BCCF0", Offset = "0x9BB8F0", VA = "0x1809BCCF0")]
		public UIBattleLegionShowCardLibraryPanel()
		{
		}

		// Token: 0x04014146 RID: 82246
		[Token(Token = "0x4014146")]
		private const int DOUBLE_LINE_LIST_COUNT = 16;

		// Token: 0x04014147 RID: 82247
		[Token(Token = "0x4014147")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _cardListScrollView;

		// Token: 0x04014148 RID: 82248
		[Token(Token = "0x4014148")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _usedCardIcon;

		// Token: 0x04014149 RID: 82249
		[Token(Token = "0x4014149")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _pendingCardIcon;

		// Token: 0x0401414A RID: 82250
		[Token(Token = "0x401414A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAtlasImage _mask;

		// Token: 0x0401414B RID: 82251
		[Token(Token = "0x401414B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SimpleLayoutContent _cardList;

		// Token: 0x0401414C RID: 82252
		[Token(Token = "0x401414C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ContentSizeFitter _contentFitter;

		// Token: 0x0401414D RID: 82253
		[Token(Token = "0x401414D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _grid;

		// Token: 0x0401414E RID: 82254
		[Token(Token = "0x401414E")]
		[FieldOffset(Offset = "0x50")]
		private UIBattleLegionShowCardLibraryPanel.CardListAdapter m_cardListAdapter;

		// Token: 0x0401414F RID: 82255
		[Token(Token = "0x401414F")]
		[FieldOffset(Offset = "0x58")]
		private List<Deck.Card> m_cardList;

		// Token: 0x04014150 RID: 82256
		[Token(Token = "0x4014150")]
		[FieldOffset(Offset = "0x60")]
		private LegionUICardShowCardLibraryState m_legionState;

		// Token: 0x04014151 RID: 82257
		[Token(Token = "0x4014151")]
		[FieldOffset(Offset = "0x68")]
		private BattleLegionCardLibraryParam m_libraryData;

		// Token: 0x04014152 RID: 82258
		[Token(Token = "0x4014152")]
		[FieldOffset(Offset = "0x78")]
		private bool m_hasInited;

		// Token: 0x04014153 RID: 82259
		[Token(Token = "0x4014153")]
		[FieldOffset(Offset = "0x80")]
		private CanvasGroup m_svCanScroll;

		// Token: 0x04014154 RID: 82260
		[Token(Token = "0x4014154")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04014155 RID: 82261
		[Token(Token = "0x4014155")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04014156 RID: 82262
		[Token(Token = "0x4014156")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ShowCardLibrary;

		// Token: 0x04014157 RID: 82263
		[Token(Token = "0x4014157")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SortPending;

		// Token: 0x04014158 RID: 82264
		[Token(Token = "0x4014158")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SortUsed;

		// Token: 0x04014159 RID: 82265
		[Token(Token = "0x4014159")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CloseLibraryPanel;

		// Token: 0x0401415A RID: 82266
		[Token(Token = "0x401415A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002A0C RID: 10764
		[Token(Token = "0x2002A0C")]
		private class CardListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06011DB5 RID: 73141 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011DB5")]
			[Address(RVA = "0x9A8A20", Offset = "0x9A7620", VA = "0x1809A8A20")]
			public CardListAdapter(UIBattleLegionShowCardLibraryPanel closure)
			{
			}

			// Token: 0x1700274E RID: 10062
			// (get) Token: 0x06011DB6 RID: 73142 RVA: 0x0006D398 File Offset: 0x0006B598
			[Token(Token = "0x1700274E")]
			public override int count
			{
				[Token(Token = "0x6011DB6")]
				[Address(RVA = "0x9A8AA0", Offset = "0x9A76A0", VA = "0x1809A8AA0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06011DB7 RID: 73143 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6011DB7")]
			[Address(RVA = "0x9A87F0", Offset = "0x9A73F0", VA = "0x1809A87F0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0401415B RID: 82267
			[Token(Token = "0x401415B")]
			[FieldOffset(Offset = "0x20")]
			private UIBattleLegionShowCardLibraryPanel m_closure;

			// Token: 0x0401415C RID: 82268
			[Token(Token = "0x401415C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401415D RID: 82269
			[Token(Token = "0x401415D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401415E RID: 82270
			[Token(Token = "0x401415E")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
