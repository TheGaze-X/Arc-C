using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Carving
{
	// Token: 0x02006050 RID: 24656
	[Token(Token = "0x2006050")]
	public class CarvingBoardView : DataBinder<CarvingMainProperty>
	{
		// Token: 0x1700542A RID: 21546
		// (get) Token: 0x06023A6A RID: 146026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700542A")]
		public TouchHandler touchHandler
		{
			[Token(Token = "0x6023A6A")]
			[Address(RVA = "0x1E40730", Offset = "0x1E3F330", VA = "0x181E40730")]
			get
			{
				return null;
			}
		}

		// Token: 0x06023A6B RID: 146027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023A6B")]
		[Address(RVA = "0x1E3FBF0", Offset = "0x1E3E7F0", VA = "0x181E3FBF0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06023A6C RID: 146028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023A6C")]
		[Address(RVA = "0x1E3FAC0", Offset = "0x1E3E6C0", VA = "0x181E3FAC0")]
		public void RegisterSlotViewListToDragHandler(List<CarvingMainCardDeskView.CarvingSlot> carvingSlots)
		{
		}

		// Token: 0x06023A6D RID: 146029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023A6D")]
		[Address(RVA = "0x1E3F800", Offset = "0x1E3E400", VA = "0x181E3F800", Slot = "7")]
		public override void OnValueChanged(CarvingMainProperty property)
		{
		}

		// Token: 0x06023A6E RID: 146030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023A6E")]
		[Address(RVA = "0x1E3FB80", Offset = "0x1E3E780", VA = "0x181E3FB80")]
		private void Update()
		{
		}

		// Token: 0x06023A6F RID: 146031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023A6F")]
		[Address(RVA = "0x1E40220", Offset = "0x1E3EE20", VA = "0x181E40220")]
		private void _OnHandCardDragOut(string cardId)
		{
		}

		// Token: 0x06023A70 RID: 146032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023A70")]
		[Address(RVA = "0x1E40320", Offset = "0x1E3EF20", VA = "0x181E40320")]
		private void _OnSlotCardDragOut(string cardId)
		{
		}

		// Token: 0x06023A71 RID: 146033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023A71")]
		[Address(RVA = "0x1E3FF80", Offset = "0x1E3EB80", VA = "0x181E3FF80")]
		private void _OnDragCancelToHandCard(string cardId)
		{
		}

		// Token: 0x06023A72 RID: 146034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023A72")]
		[Address(RVA = "0x1E40080", Offset = "0x1E3EC80", VA = "0x181E40080")]
		private void _OnDragCancelToSlotCard(string cardId, int slotIdx)
		{
		}

		// Token: 0x06023A73 RID: 146035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023A73")]
		[Address(RVA = "0x1E405C0", Offset = "0x1E3F1C0", VA = "0x181E405C0")]
		private void _OnTokenHoverSlotChanged(string cardId, int slotIdx)
		{
		}

		// Token: 0x06023A74 RID: 146036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023A74")]
		[Address(RVA = "0x1E404C0", Offset = "0x1E3F0C0", VA = "0x181E404C0")]
		private void _OnTokenHoverInHandAreaChanged(string cardId, bool inHandArea)
		{
		}

		// Token: 0x06023A75 RID: 146037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023A75")]
		[Address(RVA = "0x1E40420", Offset = "0x1E3F020", VA = "0x181E40420")]
		private void _OnStartDragBlocker()
		{
		}

		// Token: 0x06023A76 RID: 146038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023A76")]
		[Address(RVA = "0x1E40180", Offset = "0x1E3ED80", VA = "0x181E40180")]
		private void _OnEndDragBlocker()
		{
		}

		// Token: 0x06023A77 RID: 146039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023A77")]
		[Address(RVA = "0x1E406C0", Offset = "0x1E3F2C0", VA = "0x181E406C0")]
		public CarvingBoardView()
		{
		}

		// Token: 0x0403161B RID: 202267
		[Token(Token = "0x403161B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _tokenContainer;

		// Token: 0x0403161C RID: 202268
		[Token(Token = "0x403161C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CarvingTokenViewHolder _prefabToken;

		// Token: 0x0403161D RID: 202269
		[Token(Token = "0x403161D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CarvingCardListView _cardListView;

		// Token: 0x0403161E RID: 202270
		[Token(Token = "0x403161E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CanvasGroup _pnlHandArea;

		// Token: 0x0403161F RID: 202271
		[Token(Token = "0x403161F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textHandAreaTip;

		// Token: 0x04031620 RID: 202272
		[Token(Token = "0x4031620")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CanvasGroup _pnlHandAreaBkg;

		// Token: 0x04031621 RID: 202273
		[Token(Token = "0x4031621")]
		[FieldOffset(Offset = "0x50")]
		private CarvingMainViewModel m_cachedViewModel;

		// Token: 0x04031622 RID: 202274
		[Token(Token = "0x4031622")]
		[FieldOffset(Offset = "0x58")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04031623 RID: 202275
		[Token(Token = "0x4031623")]
		[FieldOffset(Offset = "0x68")]
		private bool m_inited;

		// Token: 0x04031624 RID: 202276
		[Token(Token = "0x4031624")]
		[FieldOffset(Offset = "0x70")]
		private TouchHandler<CarvingBoardView.CarvingDragContext> m_touchHandler;

		// Token: 0x04031625 RID: 202277
		[Token(Token = "0x4031625")]
		[FieldOffset(Offset = "0x78")]
		private CarvingBoardView.CarvingDragContext m_dragContext;

		// Token: 0x04031626 RID: 202278
		[Token(Token = "0x4031626")]
		[FieldOffset(Offset = "0x80")]
		private UISwitchTween m_handAreaTipShowTween;

		// Token: 0x04031627 RID: 202279
		[Token(Token = "0x4031627")]
		[FieldOffset(Offset = "0x88")]
		private UISwitchTween m_handAreaTipBkgShowTween;

		// Token: 0x04031628 RID: 202280
		[Token(Token = "0x4031628")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_touchHandler;

		// Token: 0x04031629 RID: 202281
		[Token(Token = "0x4031629")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403162A RID: 202282
		[Token(Token = "0x403162A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RegisterSlotViewListToDragHandler;

		// Token: 0x0403162B RID: 202283
		[Token(Token = "0x403162B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403162C RID: 202284
		[Token(Token = "0x403162C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0403162D RID: 202285
		[Token(Token = "0x403162D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnHandCardDragOut;

		// Token: 0x0403162E RID: 202286
		[Token(Token = "0x403162E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnSlotCardDragOut;

		// Token: 0x0403162F RID: 202287
		[Token(Token = "0x403162F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnDragCancelToHandCard;

		// Token: 0x04031630 RID: 202288
		[Token(Token = "0x4031630")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnDragCancelToSlotCard;

		// Token: 0x04031631 RID: 202289
		[Token(Token = "0x4031631")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnTokenHoverSlotChanged;

		// Token: 0x04031632 RID: 202290
		[Token(Token = "0x4031632")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnTokenHoverInHandAreaChanged;

		// Token: 0x04031633 RID: 202291
		[Token(Token = "0x4031633")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnStartDragBlocker;

		// Token: 0x04031634 RID: 202292
		[Token(Token = "0x4031634")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnEndDragBlocker;

		// Token: 0x04031635 RID: 202293
		[Token(Token = "0x4031635")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006051 RID: 24657
		[Token(Token = "0x2006051")]
		public class CarvingDragParam
		{
			// Token: 0x06023A78 RID: 146040 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023A78")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CarvingDragParam()
			{
			}

			// Token: 0x04031636 RID: 202294
			[Token(Token = "0x4031636")]
			[FieldOffset(Offset = "0x10")]
			public string cardId;

			// Token: 0x04031637 RID: 202295
			[Token(Token = "0x4031637")]
			[FieldOffset(Offset = "0x18")]
			public CarvingCardPosition source;

			// Token: 0x04031638 RID: 202296
			[Token(Token = "0x4031638")]
			[FieldOffset(Offset = "0x1C")]
			public Quaternion rotation;

			// Token: 0x04031639 RID: 202297
			[Token(Token = "0x4031639")]
			[FieldOffset(Offset = "0x2C")]
			public float scale;
		}

		// Token: 0x02006052 RID: 24658
		[Token(Token = "0x2006052")]
		public class CarvingDragContext : DragWithTokenContext
		{
			// Token: 0x06023A79 RID: 146041 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023A79")]
			[Address(RVA = "0x1E44790", Offset = "0x1E43390", VA = "0x181E44790")]
			public CarvingDragContext(CarvingBoardView closure, RectTransform handAreaRect)
			{
			}

			// Token: 0x06023A7A RID: 146042 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023A7A")]
			[Address(RVA = "0x1E43DE0", Offset = "0x1E429E0", VA = "0x181E43DE0")]
			public void SetSlots(List<CarvingMainCardDeskView.CarvingSlot> carvingSlots)
			{
			}

			// Token: 0x06023A7B RID: 146043 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6023A7B")]
			[Address(RVA = "0x1E43A90", Offset = "0x1E42690", VA = "0x181E43A90", Slot = "17")]
			protected override RectTransform GetTokenInst(RectTransform tokenContainer, Vector2 touchPos, ValueBundle param)
			{
				return null;
			}

			// Token: 0x06023A7C RID: 146044 RVA: 0x000C1770 File Offset: 0x000BF970
			[Token(Token = "0x6023A7C")]
			[Address(RVA = "0x1E43200", Offset = "0x1E41E00", VA = "0x181E43200", Slot = "14")]
			protected override bool DragBeginInternal(ValueBundle param)
			{
				return default(bool);
			}

			// Token: 0x06023A7D RID: 146045 RVA: 0x000C1788 File Offset: 0x000BF988
			[Token(Token = "0x6023A7D")]
			[Address(RVA = "0x1E43920", Offset = "0x1E42520", VA = "0x181E43920", Slot = "15")]
			protected override bool DragUpdateInternal()
			{
				return default(bool);
			}

			// Token: 0x06023A7E RID: 146046 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023A7E")]
			[Address(RVA = "0x1E43690", Offset = "0x1E42290", VA = "0x181E43690", Slot = "16")]
			protected override void DragClearInternal()
			{
			}

			// Token: 0x06023A7F RID: 146047 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023A7F")]
			[Address(RVA = "0x1E43EE0", Offset = "0x1E42AE0", VA = "0x181E43EE0")]
			private void _CalculateBounds()
			{
			}

			// Token: 0x06023A80 RID: 146048 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023A80")]
			[Address(RVA = "0x1E44480", Offset = "0x1E43080", VA = "0x181E44480")]
			private void _OnDragEndOnSlot()
			{
			}

			// Token: 0x06023A81 RID: 146049 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023A81")]
			[Address(RVA = "0x1E44690", Offset = "0x1E43290", VA = "0x181E44690")]
			private void _OnDragEnd()
			{
			}

			// Token: 0x06023A82 RID: 146050 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6023A82")]
			[Address(RVA = "0x1E43EB0", Offset = "0x1E42AB0", VA = "0x181E43EB0")]
			private RectTransform <>xLuaBaseProxy_GetTokenInst(RectTransform P0, Vector2 P1, ValueBundle P2)
			{
				return null;
			}

			// Token: 0x06023A83 RID: 146051 RVA: 0x000C17A0 File Offset: 0x000BF9A0
			[Token(Token = "0x6023A83")]
			[Address(RVA = "0x1E43E60", Offset = "0x1E42A60", VA = "0x181E43E60")]
			private bool <>xLuaBaseProxy_DragBeginInternal(ValueBundle P0)
			{
				return default(bool);
			}

			// Token: 0x06023A84 RID: 146052 RVA: 0x000C17B8 File Offset: 0x000BF9B8
			[Token(Token = "0x6023A84")]
			[Address(RVA = "0x1E43EA0", Offset = "0x1E42AA0", VA = "0x181E43EA0")]
			private bool <>xLuaBaseProxy_DragUpdateInternal()
			{
				return default(bool);
			}

			// Token: 0x06023A85 RID: 146053 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023A85")]
			[Address(RVA = "0x1E43E90", Offset = "0x1E42A90", VA = "0x181E43E90")]
			private void <>xLuaBaseProxy_DragClearInternal()
			{
			}

			// Token: 0x0403163A RID: 202298
			[Token(Token = "0x403163A")]
			[FieldOffset(Offset = "0x38")]
			private CarvingBoardView m_closure;

			// Token: 0x0403163B RID: 202299
			[Token(Token = "0x403163B")]
			[FieldOffset(Offset = "0x40")]
			private CarvingBoardView.CarvingDragContext.CarvingDragStatus m_carvingDragStatus;

			// Token: 0x0403163C RID: 202300
			[Token(Token = "0x403163C")]
			[FieldOffset(Offset = "0x68")]
			private List<CarvingMainCardDeskView.CarvingSlot> m_slots;

			// Token: 0x0403163D RID: 202301
			[Token(Token = "0x403163D")]
			[FieldOffset(Offset = "0x70")]
			private RectTransform m_handAreaRect;

			// Token: 0x0403163E RID: 202302
			[Token(Token = "0x403163E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403163F RID: 202303
			[Token(Token = "0x403163F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_SetSlots;

			// Token: 0x04031640 RID: 202304
			[Token(Token = "0x4031640")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetTokenInst;

			// Token: 0x04031641 RID: 202305
			[Token(Token = "0x4031641")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_DragBeginInternal;

			// Token: 0x04031642 RID: 202306
			[Token(Token = "0x4031642")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_DragUpdateInternal;

			// Token: 0x04031643 RID: 202307
			[Token(Token = "0x4031643")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_DragClearInternal;

			// Token: 0x04031644 RID: 202308
			[Token(Token = "0x4031644")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0__CalculateBounds;

			// Token: 0x04031645 RID: 202309
			[Token(Token = "0x4031645")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0__OnDragEndOnSlot;

			// Token: 0x04031646 RID: 202310
			[Token(Token = "0x4031646")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0__OnDragEnd;

			// Token: 0x02006053 RID: 24659
			[Token(Token = "0x2006053")]
			public struct CarvingDragStatus
			{
				// Token: 0x04031647 RID: 202311
				[Token(Token = "0x4031647")]
				[FieldOffset(Offset = "0x0")]
				public static readonly CarvingBoardView.CarvingDragContext.CarvingDragStatus NONE;

				// Token: 0x04031648 RID: 202312
				[Token(Token = "0x4031648")]
				[FieldOffset(Offset = "0x0")]
				public string dragCardId;

				// Token: 0x04031649 RID: 202313
				[Token(Token = "0x4031649")]
				[FieldOffset(Offset = "0x8")]
				public CarvingCardPosition dragSource;

				// Token: 0x0403164A RID: 202314
				[Token(Token = "0x403164A")]
				[FieldOffset(Offset = "0x10")]
				public CarvingTokenViewHolder target;

				// Token: 0x0403164B RID: 202315
				[Token(Token = "0x403164B")]
				[FieldOffset(Offset = "0x18")]
				public int origSlotIdx;

				// Token: 0x0403164C RID: 202316
				[Token(Token = "0x403164C")]
				[FieldOffset(Offset = "0x1C")]
				public int currSlotIdx;

				// Token: 0x0403164D RID: 202317
				[Token(Token = "0x403164D")]
				[FieldOffset(Offset = "0x20")]
				public bool inHandArea;
			}
		}
	}
}
