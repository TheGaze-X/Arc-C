using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200016F RID: 367
	[Token(Token = "0x200016F")]
	internal abstract class DragEventsProcessor
	{
		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000A60 RID: 2656 RVA: 0x00005AD8 File Offset: 0x00003CD8
		[Token(Token = "0x1700023D")]
		protected virtual bool supportsDragEvents
		{
			[Token(Token = "0x6000A60")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000A61 RID: 2657 RVA: 0x00005AF0 File Offset: 0x00003CF0
		[Token(Token = "0x1700023E")]
		internal bool useDragEvents
		{
			[Token(Token = "0x6000A61")]
			[Address(RVA = "0x5ADA070", Offset = "0x5AD8C70", VA = "0x185ADA070")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000A62 RID: 2658 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x1700023F")]
		protected IDragAndDrop dragAndDrop
		{
			[Token(Token = "0x6000A62")]
			[Address(RVA = "0x5AD9E30", Offset = "0x5AD8A30", VA = "0x185AD9E30")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000A63 RID: 2659 RVA: 0x00005B08 File Offset: 0x00003D08
		[Token(Token = "0x17000240")]
		internal virtual bool isEditorContext
		{
			[Token(Token = "0x6000A63")]
			[Address(RVA = "0x5AD9FA0", Offset = "0x5AD8BA0", VA = "0x185AD9FA0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000A64 RID: 2660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A64")]
		[Address(RVA = "0x5AD9CE0", Offset = "0x5AD88E0", VA = "0x185AD9CE0")]
		internal DragEventsProcessor(VisualElement target)
		{
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A65")]
		[Address(RVA = "0x5AD98D0", Offset = "0x5AD84D0", VA = "0x185AD98D0")]
		private void RegisterCallbacksFromTarget(AttachToPanelEvent evt)
		{
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A66")]
		[Address(RVA = "0x5AD95D0", Offset = "0x5AD81D0", VA = "0x185AD95D0")]
		private void RegisterCallbacksFromTarget()
		{
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A67")]
		[Address(RVA = "0x5AD9CD0", Offset = "0x5AD88D0", VA = "0x185AD9CD0")]
		private void UnregisterCallbacksFromTarget(DetachFromPanelEvent evt)
		{
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A68")]
		[Address(RVA = "0x5AD98E0", Offset = "0x5AD84E0", VA = "0x185AD98E0")]
		internal void UnregisterCallbacksFromTarget(bool unregisterPanelEvents = false)
		{
		}

		// Token: 0x06000A69 RID: 2665
		[Token(Token = "0x6000A69")]
		protected abstract bool CanStartDrag(Vector3 pointerPosition);

		// Token: 0x06000A6A RID: 2666
		[Token(Token = "0x6000A6A")]
		protected internal abstract StartDragArgs StartDrag(Vector3 pointerPosition);

		// Token: 0x06000A6B RID: 2667
		[Token(Token = "0x6000A6B")]
		protected internal abstract void UpdateDrag(Vector3 pointerPosition);

		// Token: 0x06000A6C RID: 2668
		[Token(Token = "0x6000A6C")]
		protected internal abstract void OnDrop(Vector3 pointerPosition);

		// Token: 0x06000A6D RID: 2669
		[Token(Token = "0x6000A6D")]
		protected abstract void ClearDragAndDropUI(bool dragCancelled);

		// Token: 0x06000A6E RID: 2670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A6E")]
		[Address(RVA = "0x5AD8F60", Offset = "0x5AD7B60", VA = "0x185AD8F60")]
		private void OnPointerDownEvent(PointerDownEvent evt)
		{
		}

		// Token: 0x06000A6F RID: 2671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A6F")]
		[Address(RVA = "0x5AD93D0", Offset = "0x5AD7FD0", VA = "0x185AD93D0")]
		internal void OnPointerUpEvent(PointerUpEvent evt)
		{
		}

		// Token: 0x06000A70 RID: 2672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A70")]
		[Address(RVA = "0x5AD90C0", Offset = "0x5AD7CC0", VA = "0x185AD90C0")]
		private void OnPointerLeaveEvent(PointerLeaveEvent evt)
		{
		}

		// Token: 0x06000A71 RID: 2673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A71")]
		[Address(RVA = "0x5AD8DA0", Offset = "0x5AD79A0", VA = "0x185AD8DA0")]
		private void OnPointerCancelEvent(PointerCancelEvent evt)
		{
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A72")]
		[Address(RVA = "0x5AD8E90", Offset = "0x5AD7A90", VA = "0x185AD8E90")]
		private void OnPointerCapturedOut(PointerCaptureOutEvent evt)
		{
		}

		// Token: 0x06000A73 RID: 2675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A73")]
		[Address(RVA = "0x5AD9100", Offset = "0x5AD7D00", VA = "0x185AD9100")]
		private void OnPointerMoveEvent(PointerMoveEvent evt)
		{
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000A74")]
		[Address(RVA = "0x5AD8C70", Offset = "0x5AD7870", VA = "0x185AD8C70")]
		private DragEventsProcessor GetDropTarget(Vector2 position)
		{
			return null;
		}

		// Token: 0x040005CD RID: 1485
		[Token(Token = "0x40005CD")]
		[FieldOffset(Offset = "0x10")]
		private bool m_IsRegistered;

		// Token: 0x040005CE RID: 1486
		[Token(Token = "0x40005CE")]
		[FieldOffset(Offset = "0x14")]
		internal DragEventsProcessor.DragState m_DragState;

		// Token: 0x040005CF RID: 1487
		[Token(Token = "0x40005CF")]
		[FieldOffset(Offset = "0x18")]
		private Vector3 m_Start;

		// Token: 0x040005D0 RID: 1488
		[Token(Token = "0x40005D0")]
		[FieldOffset(Offset = "0x28")]
		internal readonly VisualElement m_Target;

		// Token: 0x02000170 RID: 368
		[Token(Token = "0x2000170")]
		internal enum DragState
		{
			// Token: 0x040005D2 RID: 1490
			[Token(Token = "0x40005D2")]
			None,
			// Token: 0x040005D3 RID: 1491
			[Token(Token = "0x40005D3")]
			CanStartDrag,
			// Token: 0x040005D4 RID: 1492
			[Token(Token = "0x40005D4")]
			Dragging
		}
	}
}
