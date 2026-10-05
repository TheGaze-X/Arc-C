using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020001C4 RID: 452
	[Token(Token = "0x20001C4")]
	internal static class MouseEventsHelper
	{
		// Token: 0x06000C40 RID: 3136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C40")]
		internal static void SendEnterLeave<TLeaveEvent, TEnterEvent>(VisualElement previousTopElementUnderMouse, VisualElement currentTopElementUnderMouse, IMouseEvent triggerEvent, Vector2 mousePosition) where TLeaveEvent : MouseEventBase<TLeaveEvent>, new() where TEnterEvent : MouseEventBase<TEnterEvent>, new()
		{
		}

		// Token: 0x06000C41 RID: 3137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C41")]
		[Address(RVA = "0x5AE8300", Offset = "0x5AE6F00", VA = "0x185AE8300")]
		internal static void SendMouseOverMouseOut(VisualElement previousTopElementUnderMouse, VisualElement currentTopElementUnderMouse, IMouseEvent triggerEvent, Vector2 mousePosition)
		{
		}
	}
}
