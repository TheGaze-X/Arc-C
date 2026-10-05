using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000026 RID: 38
	[Token(Token = "0x2000026")]
	public sealed class EventDispatcher
	{
		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000023")]
		internal PointerDispatchState pointerState
		{
			[Token(Token = "0x60000C0")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x5A2DA90", Offset = "0x5A2C690", VA = "0x185A2DA90")]
		internal static EventDispatcher CreateForRuntime(IList<IEventDispatchingStrategy> strategies)
		{
			return null;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x5A2E870", Offset = "0x5A2D470", VA = "0x185A2E870")]
		private EventDispatcher(IList<IEventDispatchingStrategy> strategies)
		{
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x000024D8 File Offset: 0x000006D8
		[Token(Token = "0x17000024")]
		private bool dispatchImmediately
		{
			[Token(Token = "0x60000C3")]
			[Address(RVA = "0x5A2EC00", Offset = "0x5A2D800", VA = "0x185A2EC00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000025 RID: 37
		// (set) Token: 0x060000C4 RID: 196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000025")]
		private bool processingEvents
		{
			[Token(Token = "0x60000C4")]
			[Address(RVA = "0x31208C0", Offset = "0x311F4C0", VA = "0x1831208C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x5A2DAF0", Offset = "0x5A2C6F0", VA = "0x185A2DAF0")]
		internal void Dispatch(EventBase evt, IPanel panel, DispatchMode dispatchMode)
		{
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x5A2DA80", Offset = "0x5A2C680", VA = "0x185A2DA80")]
		internal void CloseGate()
		{
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x5A2DCA0", Offset = "0x5A2C8A0", VA = "0x185A2DCA0")]
		internal void OpenGate()
		{
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x5A2DD20", Offset = "0x5A2C920", VA = "0x185A2DD20")]
		private void ProcessEventQueue()
		{
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x5A2E000", Offset = "0x5A2CC00", VA = "0x185A2E000")]
		private void ProcessEvent(EventBase evt, IPanel panel)
		{
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x5A2D7C0", Offset = "0x5A2C3C0", VA = "0x185A2D7C0")]
		private void ApplyDispatchingStrategies(EventBase evt, IPanel panel, bool imguiEventIsInitiallyUsed)
		{
		}

		// Token: 0x0400006C RID: 108
		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x10")]
		internal ClickDetector m_ClickDetector;

		// Token: 0x0400006D RID: 109
		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x18")]
		private List<IEventDispatchingStrategy> m_DispatchingStrategies;

		// Token: 0x0400006E RID: 110
		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ObjectPool<Queue<EventDispatcher.EventRecord>> k_EventQueuePool;

		// Token: 0x0400006F RID: 111
		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x20")]
		private Queue<EventDispatcher.EventRecord> m_Queue;

		// Token: 0x04000071 RID: 113
		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x30")]
		private uint m_GateCount;

		// Token: 0x04000072 RID: 114
		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x38")]
		private Stack<EventDispatcher.DispatchContext> m_DispatchContexts;

		// Token: 0x04000073 RID: 115
		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x8")]
		private static readonly IEventDispatchingStrategy[] s_EditorStrategies;

		// Token: 0x04000074 RID: 116
		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x40")]
		private bool m_Immediate;

		// Token: 0x02000027 RID: 39
		[Token(Token = "0x2000027")]
		private struct EventRecord
		{
			// Token: 0x04000076 RID: 118
			[Token(Token = "0x4000076")]
			[FieldOffset(Offset = "0x0")]
			public EventBase m_Event;

			// Token: 0x04000077 RID: 119
			[Token(Token = "0x4000077")]
			[FieldOffset(Offset = "0x8")]
			public IPanel m_Panel;
		}

		// Token: 0x02000028 RID: 40
		[Token(Token = "0x2000028")]
		private struct DispatchContext
		{
			// Token: 0x04000078 RID: 120
			[Token(Token = "0x4000078")]
			[FieldOffset(Offset = "0x0")]
			public uint m_GateCount;

			// Token: 0x04000079 RID: 121
			[Token(Token = "0x4000079")]
			[FieldOffset(Offset = "0x8")]
			public Queue<EventDispatcher.EventRecord> m_Queue;
		}
	}
}
