using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel
{
	// Token: 0x020001CF RID: 463
	[Token(Token = "0x20001CF")]
	public static class InputState
	{
		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06001112 RID: 4370 RVA: 0x00008E20 File Offset: 0x00007020
		[Token(Token = "0x170004E6")]
		public static InputUpdateType currentUpdateType
		{
			[Token(Token = "0x6001112")]
			[Address(RVA = "0x56F5040", Offset = "0x56F3C40", VA = "0x1856F5040")]
			get
			{
				return InputUpdateType.None;
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06001113 RID: 4371 RVA: 0x00008E38 File Offset: 0x00007038
		[Token(Token = "0x170004E7")]
		public static uint updateCount
		{
			[Token(Token = "0x6001113")]
			[Address(RVA = "0x56F5080", Offset = "0x56F3C80", VA = "0x1856F5080")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06001114 RID: 4372 RVA: 0x00008E50 File Offset: 0x00007050
		[Token(Token = "0x170004E8")]
		public static double currentTime
		{
			[Token(Token = "0x6001114")]
			[Address(RVA = "0x56F4FC0", Offset = "0x56F3BC0", VA = "0x1856F4FC0")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x14000025 RID: 37
		// (add) Token: 0x06001115 RID: 4373 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06001116 RID: 4374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000025")]
		public static event Action<InputDevice, InputEventPtr> onChange
		{
			[Token(Token = "0x6001115")]
			[Address(RVA = "0x56F4F50", Offset = "0x56F3B50", VA = "0x1856F4F50")]
			add
			{
			}
			[Token(Token = "0x6001116")]
			[Address(RVA = "0x56F50C0", Offset = "0x56F3CC0", VA = "0x1856F50C0")]
			remove
			{
			}
		}

		// Token: 0x06001117 RID: 4375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001117")]
		[Address(RVA = "0x56F4880", Offset = "0x56F3480", VA = "0x1856F4880")]
		public static void Change(InputDevice device, InputEventPtr eventPtr, InputUpdateType updateType = InputUpdateType.None)
		{
		}

		// Token: 0x06001118 RID: 4376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001118")]
		public static void Change<TState>(InputControl control, TState state, InputUpdateType updateType = InputUpdateType.None, [Optional] InputEventPtr eventPtr) where TState : struct
		{
		}

		// Token: 0x06001119 RID: 4377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001119")]
		public static void Change<TState>(InputControl control, ref TState state, InputUpdateType updateType = InputUpdateType.None, [Optional] InputEventPtr eventPtr) where TState : struct
		{
		}

		// Token: 0x0600111A RID: 4378 RVA: 0x00008E68 File Offset: 0x00007068
		[Token(Token = "0x600111A")]
		[Address(RVA = "0x56F4BA0", Offset = "0x56F37A0", VA = "0x1856F4BA0")]
		public static bool IsIntegerFormat(this FourCC format)
		{
			return default(bool);
		}

		// Token: 0x0600111B RID: 4379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600111B")]
		[Address(RVA = "0x56F4580", Offset = "0x56F3180", VA = "0x1856F4580")]
		public static void AddChangeMonitor(InputControl control, IInputStateChangeMonitor monitor, long monitorIndex = -1L, uint groupIndex = 0U)
		{
		}

		// Token: 0x0600111C RID: 4380 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600111C")]
		[Address(RVA = "0x56F4760", Offset = "0x56F3360", VA = "0x1856F4760")]
		public static IInputStateChangeMonitor AddChangeMonitor(InputControl control, Action<InputControl, double, InputEventPtr, long> valueChangeCallback, int monitorIndex = -1, [Optional] Action<InputControl, double, long, int> timerExpiredCallback)
		{
			return null;
		}

		// Token: 0x0600111D RID: 4381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600111D")]
		[Address(RVA = "0x56F4E10", Offset = "0x56F3A10", VA = "0x1856F4E10")]
		public static void RemoveChangeMonitor(InputControl control, IInputStateChangeMonitor monitor, long monitorIndex = -1L)
		{
		}

		// Token: 0x0600111E RID: 4382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600111E")]
		[Address(RVA = "0x56F4470", Offset = "0x56F3070", VA = "0x1856F4470")]
		public static void AddChangeMonitorTimeout(InputControl control, IInputStateChangeMonitor monitor, double time, long monitorIndex = -1L, int timerIndex = -1)
		{
		}

		// Token: 0x0600111F RID: 4383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600111F")]
		[Address(RVA = "0x56F4D20", Offset = "0x56F3920", VA = "0x1856F4D20")]
		public static void RemoveChangeMonitorTimeout(IInputStateChangeMonitor monitor, long monitorIndex = -1L, int timerIndex = -1)
		{
		}

		// Token: 0x020001D0 RID: 464
		[Token(Token = "0x20001D0")]
		private class StateChangeMonitorDelegate : IInputStateChangeMonitor
		{
			// Token: 0x06001120 RID: 4384 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001120")]
			[Address(RVA = "0x56FA1E0", Offset = "0x56F8DE0", VA = "0x1856FA1E0", Slot = "4")]
			public void NotifyControlStateChanged(InputControl control, double time, InputEventPtr eventPtr, long monitorIndex)
			{
			}

			// Token: 0x06001121 RID: 4385 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001121")]
			[Address(RVA = "0x56FA210", Offset = "0x56F8E10", VA = "0x1856FA210", Slot = "5")]
			public void NotifyTimerExpired(InputControl control, double time, long monitorIndex, int timerIndex)
			{
			}

			// Token: 0x06001122 RID: 4386 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001122")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public StateChangeMonitorDelegate()
			{
			}

			// Token: 0x04000A2F RID: 2607
			[Token(Token = "0x4000A2F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action<InputControl, double, InputEventPtr, long> valueChangeCallback;

			// Token: 0x04000A30 RID: 2608
			[Token(Token = "0x4000A30")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action<InputControl, double, long, int> timerExpiredCallback;
		}
	}
}
