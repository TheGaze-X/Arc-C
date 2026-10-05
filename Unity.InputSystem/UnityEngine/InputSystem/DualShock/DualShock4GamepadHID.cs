using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.DualShock.LowLevel;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.DualShock
{
	// Token: 0x02000156 RID: 342
	[Token(Token = "0x2000156")]
	[InputControlLayout(stateType = typeof(DualShock4HIDInputReport), hideInUI = true, isNoisy = true)]
	public class DualShock4GamepadHID : DualShockGamepad, IEventPreProcessor, IInputStateCallbackReceiver
	{
		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06000EE2 RID: 3810 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000EE3 RID: 3811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003FD")]
		public ButtonControl leftTriggerButton
		{
			[Token(Token = "0x6000EE2")]
			[Address(RVA = "0x56D0E50", Offset = "0x56CFA50", VA = "0x1856D0E50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000EE3")]
			[Address(RVA = "0x56D0E80", Offset = "0x56CFA80", VA = "0x1856D0E80")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06000EE4 RID: 3812 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000EE5 RID: 3813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003FE")]
		public ButtonControl rightTriggerButton
		{
			[Token(Token = "0x6000EE4")]
			[Address(RVA = "0x56D0E70", Offset = "0x56CFA70", VA = "0x1856D0E70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000EE5")]
			[Address(RVA = "0x56D0EA0", Offset = "0x56CFAA0", VA = "0x1856D0EA0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06000EE6 RID: 3814 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000EE7 RID: 3815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003FF")]
		public ButtonControl playStationButton
		{
			[Token(Token = "0x6000EE6")]
			[Address(RVA = "0x56D0E60", Offset = "0x56CFA60", VA = "0x1856D0E60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000EE7")]
			[Address(RVA = "0x56D0E90", Offset = "0x56CFA90", VA = "0x1856D0E90")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06000EE8 RID: 3816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EE8")]
		[Address(RVA = "0x56D1340", Offset = "0x56CFF40", VA = "0x1856D1340", Slot = "13")]
		protected override void FinishSetup()
		{
		}

		// Token: 0x06000EE9 RID: 3817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EE9")]
		[Address(RVA = "0x56D15D0", Offset = "0x56D01D0", VA = "0x1856D15D0", Slot = "26")]
		public override void PauseHaptics()
		{
		}

		// Token: 0x06000EEA RID: 3818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EEA")]
		[Address(RVA = "0x56D1710", Offset = "0x56D0310", VA = "0x1856D1710", Slot = "28")]
		public override void ResetHaptics()
		{
		}

		// Token: 0x06000EEB RID: 3819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EEB")]
		[Address(RVA = "0x56D1870", Offset = "0x56D0470", VA = "0x1856D1870", Slot = "27")]
		public override void ResumeHaptics()
		{
		}

		// Token: 0x06000EEC RID: 3820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EEC")]
		[Address(RVA = "0x56D1AD0", Offset = "0x56D06D0", VA = "0x1856D1AD0", Slot = "31")]
		public override void SetLightBarColor(Color color)
		{
		}

		// Token: 0x06000EED RID: 3821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EED")]
		[Address(RVA = "0x56D1ED0", Offset = "0x56D0AD0", VA = "0x1856D1ED0", Slot = "29")]
		public override void SetMotorSpeeds(float lowFrequency, float highFrequency)
		{
		}

		// Token: 0x06000EEE RID: 3822 RVA: 0x000075C0 File Offset: 0x000057C0
		[Token(Token = "0x6000EEE")]
		[Address(RVA = "0x56D1C70", Offset = "0x56D0870", VA = "0x1856D1C70")]
		public bool SetMotorSpeedsAndLightBarColor(float lowFrequency, float highFrequency, Color color)
		{
			return default(bool);
		}

		// Token: 0x06000EEF RID: 3823 RVA: 0x000075D8 File Offset: 0x000057D8
		[Token(Token = "0x6000EEF")]
		[Address(RVA = "0x56D2090", Offset = "0x56D0C90", VA = "0x1856D2090", Slot = "32")]
		private bool PreProcessEvent(InputEventPtr eventPtr)
		{
			return default(bool);
		}

		// Token: 0x06000EF0 RID: 3824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EF0")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "33")]
		public void OnNextUpdate()
		{
		}

		// Token: 0x06000EF1 RID: 3825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EF1")]
		[Address(RVA = "0x56D1410", Offset = "0x56D0010", VA = "0x1856D1410", Slot = "34")]
		public void OnStateEvent(InputEventPtr eventPtr)
		{
		}

		// Token: 0x06000EF2 RID: 3826 RVA: 0x000075F0 File Offset: 0x000057F0
		[Token(Token = "0x6000EF2")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "35")]
		public bool GetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, ref uint offset)
		{
			return default(bool);
		}

		// Token: 0x06000EF3 RID: 3827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EF3")]
		[Address(RVA = "0x55DCFE0", Offset = "0x55DBBE0", VA = "0x1855DCFE0")]
		public DualShock4GamepadHID()
		{
		}

		// Token: 0x04000882 RID: 2178
		[Token(Token = "0x4000882")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private float? m_LowFrequencyMotorSpeed;

		// Token: 0x04000883 RID: 2179
		[Token(Token = "0x4000883")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private float? m_HighFrequenceyMotorSpeed;

		// Token: 0x04000884 RID: 2180
		[Token(Token = "0x4000884")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private Color? m_LightBarColor;

		// Token: 0x04000885 RID: 2181
		[Token(Token = "0x4000885")]
		internal const byte JitterMaskLow = 120;

		// Token: 0x04000886 RID: 2182
		[Token(Token = "0x4000886")]
		internal const byte JitterMaskHigh = 135;

		// Token: 0x02000157 RID: 343
		[Token(Token = "0x2000157")]
		[StructLayout(2)]
		internal struct DualShock4HIDGenericInputReport
		{
			// Token: 0x17000400 RID: 1024
			// (get) Token: 0x06000EF4 RID: 3828 RVA: 0x00007608 File Offset: 0x00005808
			[Token(Token = "0x17000400")]
			public static FourCC Format
			{
				[Token(Token = "0x6000EF4")]
				[Address(RVA = "0x56C9890", Offset = "0x56C8490", VA = "0x1856C9890")]
				get
				{
					return default(FourCC);
				}
			}

			// Token: 0x06000EF5 RID: 3829 RVA: 0x00007620 File Offset: 0x00005820
			[Token(Token = "0x6000EF5")]
			[Address(RVA = "0x56D22B0", Offset = "0x56D0EB0", VA = "0x1856D22B0")]
			[MethodImpl(256)]
			public DualShock4HIDInputReport ToHIDInputReport()
			{
				return default(DualShock4HIDInputReport);
			}

			// Token: 0x04000887 RID: 2183
			[Token(Token = "0x4000887")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public byte leftStickX;

			// Token: 0x04000888 RID: 2184
			[Token(Token = "0x4000888")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public byte leftStickY;

			// Token: 0x04000889 RID: 2185
			[Token(Token = "0x4000889")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
			public byte rightStickX;

			// Token: 0x0400088A RID: 2186
			[Token(Token = "0x400088A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
			public byte rightStickY;

			// Token: 0x0400088B RID: 2187
			[Token(Token = "0x400088B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public byte buttons0;

			// Token: 0x0400088C RID: 2188
			[Token(Token = "0x400088C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
			public byte buttons1;

			// Token: 0x0400088D RID: 2189
			[Token(Token = "0x400088D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
			public byte buttons2;

			// Token: 0x0400088E RID: 2190
			[Token(Token = "0x400088E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7")]
			public byte leftTrigger;

			// Token: 0x0400088F RID: 2191
			[Token(Token = "0x400088F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public byte rightTrigger;
		}
	}
}
