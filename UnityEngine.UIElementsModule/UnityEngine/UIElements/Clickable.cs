using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200000F RID: 15
	[Token(Token = "0x200000F")]
	public class Clickable : PointerManipulator
	{
		// Token: 0x14000003 RID: 3
		// (add) Token: 0x0600003E RID: 62 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600003F RID: 63 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000003")]
		public event Action clicked
		{
			[Token(Token = "0x600003E")]
			[Address(RVA = "0x5A29610", Offset = "0x5A28210", VA = "0x185A29610")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600003F")]
			[Address(RVA = "0x5A296E0", Offset = "0x5A282E0", VA = "0x185A296E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000040 RID: 64 RVA: 0x00002178 File Offset: 0x00000378
		// (set) Token: 0x06000041 RID: 65 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000E")]
		protected bool active
		{
			[Token(Token = "0x6000040")]
			[Address(RVA = "0x6DF210", Offset = "0x6DDE10", VA = "0x1806DF210")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000041")]
			[Address(RVA = "0xC97C20", Offset = "0xC96820", VA = "0x180C97C20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00002190 File Offset: 0x00000390
		// (set) Token: 0x06000043 RID: 67 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000F")]
		public Vector2 lastMousePosition
		{
			[Token(Token = "0x6000042")]
			[Address(RVA = "0x5A296C0", Offset = "0x5A282C0", VA = "0x185A296C0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000043")]
			[Address(RVA = "0x4A9EF10", Offset = "0x4A9DB10", VA = "0x184A9EF10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000044 RID: 68 RVA: 0x000021A8 File Offset: 0x000003A8
		[Token(Token = "0x17000010")]
		internal bool acceptClicksIfDisabled
		{
			[Token(Token = "0x6000044")]
			[Address(RVA = "0xE31BB0", Offset = "0xE307B0", VA = "0x180E31BB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000045 RID: 69 RVA: 0x000021C0 File Offset: 0x000003C0
		[Token(Token = "0x17000011")]
		private InvokePolicy invokePolicy
		{
			[Token(Token = "0x6000045")]
			[Address(RVA = "0x5A296B0", Offset = "0x5A282B0", VA = "0x185A296B0")]
			get
			{
				return InvokePolicy.Default;
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x5A292F0", Offset = "0x5A27EF0", VA = "0x185A292F0")]
		public Clickable(Action handler, long delay, long interval)
		{
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x5A29410", Offset = "0x5A28010", VA = "0x185A29410")]
		public Clickable(Action<EventBase> handler)
		{
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x5A29510", Offset = "0x5A28110", VA = "0x185A29510")]
		public Clickable(Action handler)
		{
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x5A27F60", Offset = "0x5A26B60", VA = "0x185A27F60")]
		private void OnTimer(TimerState timerState)
		{
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000021D8 File Offset: 0x000003D8
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x5A27640", Offset = "0x5A26240", VA = "0x185A27640")]
		private bool IsRepeatable()
		{
			return default(bool);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x5A28850", Offset = "0x5A27450", VA = "0x185A28850", Slot = "5")]
		protected override void RegisterCallbacksOnTarget()
		{
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x5A28EB0", Offset = "0x5A27AB0", VA = "0x185A28EB0", Slot = "6")]
		protected override void UnregisterCallbacksFromTarget()
		{
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x5A27700", Offset = "0x5A26300", VA = "0x185A27700")]
		protected void OnMouseDown(MouseDownEvent evt)
		{
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x5A277C0", Offset = "0x5A263C0", VA = "0x185A277C0")]
		protected void OnMouseMove(MouseMoveEvent evt)
		{
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x5A27850", Offset = "0x5A26450", VA = "0x185A27850")]
		protected void OnMouseUp(MouseUpEvent evt)
		{
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x5A27660", Offset = "0x5A26260", VA = "0x185A27660")]
		private void OnMouseCaptureOut(MouseCaptureOutEvent evt)
		{
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x5A27AF0", Offset = "0x5A266F0", VA = "0x185A27AF0")]
		private void OnPointerDown(PointerDownEvent evt)
		{
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x5A27C60", Offset = "0x5A26860", VA = "0x185A27C60")]
		private void OnPointerMove(PointerMoveEvent evt)
		{
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x5A27DC0", Offset = "0x5A269C0", VA = "0x185A27DC0")]
		private void OnPointerUp(PointerUpEvent evt)
		{
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x5A27940", Offset = "0x5A26540", VA = "0x185A27940")]
		private void OnPointerCancel(PointerCancelEvent evt)
		{
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x5A27A30", Offset = "0x5A26630", VA = "0x185A27A30")]
		private void OnPointerCaptureOut(PointerCaptureOutEvent evt)
		{
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000021F0 File Offset: 0x000003F0
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x5A27530", Offset = "0x5A26130", VA = "0x185A27530")]
		private bool ContainsPointer(int pointerId)
		{
			return default(bool);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002208 File Offset: 0x00000408
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x5A275E0", Offset = "0x5A261E0", VA = "0x185A275E0")]
		private static bool IsNotMouseEvent(int pointerId)
		{
			return default(bool);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x5A27590", Offset = "0x5A26190", VA = "0x185A27590")]
		protected void Invoke(EventBase evt)
		{
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x5A28D10", Offset = "0x5A27910", VA = "0x185A28D10")]
		internal void SimulateSingleClick(EventBase evt, int delayMs = 100)
		{
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x5A28200", Offset = "0x5A26E00", VA = "0x185A28200", Slot = "8")]
		protected virtual void ProcessDownEvent(EventBase evt, Vector2 localPosition, int pointerId)
		{
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x5A28550", Offset = "0x5A27150", VA = "0x185A28550", Slot = "9")]
		protected virtual void ProcessMoveEvent(EventBase evt, Vector2 localPosition)
		{
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x5A28610", Offset = "0x5A27210", VA = "0x185A28610", Slot = "10")]
		protected virtual void ProcessUpEvent(EventBase evt, Vector2 localPosition, int pointerId)
		{
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x5A28070", Offset = "0x5A26C70", VA = "0x185A28070", Slot = "11")]
		protected virtual void ProcessCancelEvent(EventBase evt, int pointerId)
		{
		}

		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x38")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Action<EventBase> clickedWithEventInfo;

		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x48")]
		private readonly long m_Delay;

		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x50")]
		private readonly long m_Interval;

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x64")]
		private int m_ActivePointerId;

		// Token: 0x0400002C RID: 44
		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x68")]
		private bool m_AcceptClicksIfDisabled;

		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x70")]
		private IVisualElementScheduledItem m_Repeater;
	}
}
