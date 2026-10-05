using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000192 RID: 402
	[Token(Token = "0x2000192")]
	internal class ElementUnderPointer
	{
		// Token: 0x06000AF7 RID: 2807 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000AF7")]
		[Address(RVA = "0x5ADAF60", Offset = "0x5AD9B60", VA = "0x185ADAF60")]
		internal VisualElement GetTopElementUnderPointer(int pointerId, out Vector2 pickPosition, out bool isTemporary)
		{
			return null;
		}

		// Token: 0x06000AF8 RID: 2808 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000AF8")]
		[Address(RVA = "0x187C640", Offset = "0x187B240", VA = "0x18187C640")]
		internal VisualElement GetTopElementUnderPointer(int pointerId)
		{
			return null;
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AF9")]
		[Address(RVA = "0x5ADB3A0", Offset = "0x5AD9FA0", VA = "0x185ADB3A0")]
		internal void SetElementUnderPointer(VisualElement newElementUnderPointer, int pointerId, Vector2 pointerPos)
		{
		}

		// Token: 0x06000AFA RID: 2810 RVA: 0x00005D78 File Offset: 0x00003F78
		[Token(Token = "0x6000AFA")]
		[Address(RVA = "0x5ADAE60", Offset = "0x5AD9A60", VA = "0x185ADAE60")]
		private Vector2 GetEventPointerPosition(EventBase triggerEvent)
		{
			return default(Vector2);
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AFB")]
		[Address(RVA = "0x5ADB520", Offset = "0x5ADA120", VA = "0x185ADB520")]
		internal void SetTemporaryElementUnderPointer(VisualElement newElementUnderPointer, int pointerId, EventBase triggerEvent)
		{
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AFC")]
		[Address(RVA = "0x5ADB380", Offset = "0x5AD9F80", VA = "0x185ADB380")]
		internal void SetElementUnderPointer(VisualElement newElementUnderPointer, int pointerId, EventBase triggerEvent)
		{
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AFD")]
		[Address(RVA = "0x5ADAFD0", Offset = "0x5AD9BD0", VA = "0x185ADAFD0")]
		private void SetElementUnderPointer(VisualElement newElementUnderPointer, int pointerId, EventBase triggerEvent, bool temporary)
		{
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AFE")]
		[Address(RVA = "0x5ADA2C0", Offset = "0x5AD8EC0", VA = "0x185ADA2C0")]
		internal void CommitElementUnderPointers(EventDispatcher dispatcher, ContextType contextType)
		{
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AFF")]
		[Address(RVA = "0x5ADB540", Offset = "0x5ADA140", VA = "0x185ADB540")]
		public ElementUnderPointer()
		{
		}

		// Token: 0x04000607 RID: 1543
		[Token(Token = "0x4000607")]
		[FieldOffset(Offset = "0x10")]
		private VisualElement[] m_PendingTopElementUnderPointer;

		// Token: 0x04000608 RID: 1544
		[Token(Token = "0x4000608")]
		[FieldOffset(Offset = "0x18")]
		private VisualElement[] m_TopElementUnderPointer;

		// Token: 0x04000609 RID: 1545
		[Token(Token = "0x4000609")]
		[FieldOffset(Offset = "0x20")]
		private IPointerEvent[] m_TriggerPointerEvent;

		// Token: 0x0400060A RID: 1546
		[Token(Token = "0x400060A")]
		[FieldOffset(Offset = "0x28")]
		private IMouseEvent[] m_TriggerMouseEvent;

		// Token: 0x0400060B RID: 1547
		[Token(Token = "0x400060B")]
		[FieldOffset(Offset = "0x30")]
		private Vector2[] m_PickingPointerPositions;

		// Token: 0x0400060C RID: 1548
		[Token(Token = "0x400060C")]
		[FieldOffset(Offset = "0x38")]
		private bool[] m_IsPickingPointerTemporaries;
	}
}
