using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using XLua;

namespace Torappu.UI.Carving
{
	// Token: 0x02006059 RID: 24665
	[Token(Token = "0x2006059")]
	public class CarvingCardViewHolder : MonoBehaviour, UICustomAnimDrivenLayouter<KeyValuePair<string, CarvingMainCardViewModel>, CarvingCardViewHolder>.ICustomAnimDrivenLayoutElement, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler, IHotfixable
	{
		// Token: 0x1700542C RID: 21548
		// (get) Token: 0x06023A9B RID: 146075 RVA: 0x000C17E8 File Offset: 0x000BF9E8
		// (set) Token: 0x06023A9C RID: 146076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700542C")]
		public int sortId
		{
			[Token(Token = "0x6023A9B")]
			[Address(RVA = "0x1E42F20", Offset = "0x1E41B20", VA = "0x181E42F20")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6023A9C")]
			[Address(RVA = "0x1E43050", Offset = "0x1E41C50", VA = "0x181E43050")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700542D RID: 21549
		// (get) Token: 0x06023A9D RID: 146077 RVA: 0x000C1800 File Offset: 0x000BFA00
		// (set) Token: 0x06023A9E RID: 146078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700542D")]
		public float samplePos
		{
			[Token(Token = "0x6023A9D")]
			[Address(RVA = "0x1E42E60", Offset = "0x1E41A60", VA = "0x181E42E60", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6023A9E")]
			[Address(RVA = "0x1E42FE0", Offset = "0x1E41BE0", VA = "0x181E42FE0", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700542E RID: 21550
		// (get) Token: 0x06023A9F RID: 146079 RVA: 0x000C1818 File Offset: 0x000BFA18
		[Token(Token = "0x1700542E")]
		public float showPos
		{
			[Token(Token = "0x6023A9F")]
			[Address(RVA = "0x1E42EC0", Offset = "0x1E41AC0", VA = "0x181E42EC0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700542F RID: 21551
		// (get) Token: 0x06023AA0 RID: 146080 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06023AA1 RID: 146081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700542F")]
		public TouchHandler touchHandler
		{
			[Token(Token = "0x6023AA0")]
			[Address(RVA = "0x1E42F80", Offset = "0x1E41B80", VA = "0x181E42F80")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6023AA1")]
			[Address(RVA = "0x1E430C0", Offset = "0x1E41CC0", VA = "0x181E430C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06023AA2 RID: 146082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023AA2")]
		[Address(RVA = "0x1E42C60", Offset = "0x1E41860", VA = "0x181E42C60")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06023AA3 RID: 146083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023AA3")]
		[Address(RVA = "0x1E42BB0", Offset = "0x1E417B0", VA = "0x181E42BB0")]
		public void SetShowPos(float showPos)
		{
		}

		// Token: 0x06023AA4 RID: 146084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023AA4")]
		[Address(RVA = "0x1E428C0", Offset = "0x1E414C0", VA = "0x181E428C0")]
		public void Render(CarvingMainCardViewModel viewModel, CarvingMainViewModel carvingViewModel, bool isProcessed)
		{
		}

		// Token: 0x06023AA5 RID: 146085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023AA5")]
		[Address(RVA = "0x1E42560", Offset = "0x1E41160", VA = "0x181E42560", Slot = "6")]
		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		// Token: 0x06023AA6 RID: 146086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023AA6")]
		[Address(RVA = "0x1E42800", Offset = "0x1E41400", VA = "0x181E42800", Slot = "7")]
		public void OnDrag(PointerEventData eventData)
		{
		}

		// Token: 0x06023AA7 RID: 146087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023AA7")]
		[Address(RVA = "0x1E42860", Offset = "0x1E41460", VA = "0x181E42860", Slot = "8")]
		public void OnEndDrag(PointerEventData eventData)
		{
		}

		// Token: 0x06023AA8 RID: 146088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023AA8")]
		[Address(RVA = "0x1E42710", Offset = "0x1E41310", VA = "0x181E42710")]
		public void OnCardClicked()
		{
		}

		// Token: 0x06023AA9 RID: 146089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023AA9")]
		[Address(RVA = "0x1E42DC0", Offset = "0x1E419C0", VA = "0x181E42DC0")]
		public CarvingCardViewHolder()
		{
		}

		// Token: 0x04031676 RID: 202358
		[Token(Token = "0x4031676")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CarvingMainCardView _prefabCard;

		// Token: 0x04031677 RID: 202359
		[Token(Token = "0x4031677")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _cardContainer;

		// Token: 0x04031678 RID: 202360
		[Token(Token = "0x4031678")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _showAnim;

		// Token: 0x04031679 RID: 202361
		[Token(Token = "0x4031679")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIColorGraphic _colorGraphic;

		// Token: 0x0403167A RID: 202362
		[Token(Token = "0x403167A")]
		[FieldOffset(Offset = "0x40")]
		private bool m_inited;

		// Token: 0x0403167B RID: 202363
		[Token(Token = "0x403167B")]
		[FieldOffset(Offset = "0x44")]
		private float m_showPos;

		// Token: 0x0403167C RID: 202364
		[Token(Token = "0x403167C")]
		[FieldOffset(Offset = "0x48")]
		private CarvingMainCardView m_cardView;

		// Token: 0x0403167D RID: 202365
		[Token(Token = "0x403167D")]
		[FieldOffset(Offset = "0x50")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403167E RID: 202366
		[Token(Token = "0x403167E")]
		[FieldOffset(Offset = "0x60")]
		private string m_cachedCardId;

		// Token: 0x0403167F RID: 202367
		[Token(Token = "0x403167F")]
		[FieldOffset(Offset = "0x68")]
		private CarvingBoardView.CarvingDragParam m_dragParam;

		// Token: 0x04031683 RID: 202371
		[Token(Token = "0x4031683")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_sortId;

		// Token: 0x04031684 RID: 202372
		[Token(Token = "0x4031684")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_sortId;

		// Token: 0x04031685 RID: 202373
		[Token(Token = "0x4031685")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_samplePos;

		// Token: 0x04031686 RID: 202374
		[Token(Token = "0x4031686")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_samplePos;

		// Token: 0x04031687 RID: 202375
		[Token(Token = "0x4031687")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_showPos;

		// Token: 0x04031688 RID: 202376
		[Token(Token = "0x4031688")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_touchHandler;

		// Token: 0x04031689 RID: 202377
		[Token(Token = "0x4031689")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_touchHandler;

		// Token: 0x0403168A RID: 202378
		[Token(Token = "0x403168A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403168B RID: 202379
		[Token(Token = "0x403168B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SetShowPos;

		// Token: 0x0403168C RID: 202380
		[Token(Token = "0x403168C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403168D RID: 202381
		[Token(Token = "0x403168D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnBeginDrag;

		// Token: 0x0403168E RID: 202382
		[Token(Token = "0x403168E")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnDrag;

		// Token: 0x0403168F RID: 202383
		[Token(Token = "0x403168F")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnEndDrag;

		// Token: 0x04031690 RID: 202384
		[Token(Token = "0x4031690")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnCardClicked;

		// Token: 0x04031691 RID: 202385
		[Token(Token = "0x4031691")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
