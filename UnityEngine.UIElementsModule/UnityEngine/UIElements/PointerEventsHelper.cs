using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020001C5 RID: 453
	[Token(Token = "0x20001C5")]
	internal static class PointerEventsHelper
	{
		// Token: 0x06000C42 RID: 3138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C42")]
		internal static void SendEnterLeave<TLeaveEvent, TEnterEvent>(VisualElement previousTopElementUnderPointer, VisualElement currentTopElementUnderPointer, IPointerEvent triggerEvent, Vector2 position, int pointerId) where TLeaveEvent : PointerEventBase<TLeaveEvent>, new() where TEnterEvent : PointerEventBase<TEnterEvent>, new()
		{
		}

		// Token: 0x06000C43 RID: 3139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C43")]
		[Address(RVA = "0x5AEA890", Offset = "0x5AE9490", VA = "0x185AEA890")]
		internal static void SendOverOut(VisualElement previousTopElementUnderPointer, VisualElement currentTopElementUnderPointer, IPointerEvent triggerEvent, Vector2 position, int pointerId)
		{
		}
	}
}
