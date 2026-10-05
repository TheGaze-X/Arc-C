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
	// Token: 0x02000151 RID: 337
	[Token(Token = "0x2000151")]
	[InputControlLayout(stateType = typeof(DualSenseHIDInputReport), displayName = "DualSense HID")]
	public class DualSenseGamepadHID : DualShockGamepad, IEventMerger, IEventPreProcessor, IInputStateCallbackReceiver
	{
		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06000EC7 RID: 3783 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000EC8 RID: 3784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003F9")]
		public ButtonControl leftTriggerButton
		{
			[Token(Token = "0x6000EC7")]
			[Address(RVA = "0x56D0E50", Offset = "0x56CFA50", VA = "0x1856D0E50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000EC8")]
			[Address(RVA = "0x56D0E80", Offset = "0x56CFA80", VA = "0x1856D0E80")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06000EC9 RID: 3785 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000ECA RID: 3786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003FA")]
		public ButtonControl rightTriggerButton
		{
			[Token(Token = "0x6000EC9")]
			[Address(RVA = "0x56D0E70", Offset = "0x56CFA70", VA = "0x1856D0E70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000ECA")]
			[Address(RVA = "0x56D0EA0", Offset = "0x56CFAA0", VA = "0x1856D0EA0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06000ECB RID: 3787 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000ECC RID: 3788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003FB")]
		public ButtonControl playStationButton
		{
			[Token(Token = "0x6000ECB")]
			[Address(RVA = "0x56D0E60", Offset = "0x56CFA60", VA = "0x1856D0E60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000ECC")]
			[Address(RVA = "0x56D0E90", Offset = "0x56CFA90", VA = "0x1856D0E90")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06000ECD RID: 3789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ECD")]
		[Address(RVA = "0x56CFEC0", Offset = "0x56CEAC0", VA = "0x1856CFEC0", Slot = "13")]
		protected override void FinishSetup()
		{
		}

		// Token: 0x06000ECE RID: 3790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ECE")]
		[Address(RVA = "0x56D0210", Offset = "0x56CEE10", VA = "0x1856D0210", Slot = "26")]
		public override void PauseHaptics()
		{
		}

		// Token: 0x06000ECF RID: 3791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ECF")]
		[Address(RVA = "0x56D02D0", Offset = "0x56CEED0", VA = "0x1856D02D0", Slot = "28")]
		public override void ResetHaptics()
		{
		}

		// Token: 0x06000ED0 RID: 3792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ED0")]
		[Address(RVA = "0x56D0360", Offset = "0x56CEF60", VA = "0x1856D0360", Slot = "27")]
		public override void ResumeHaptics()
		{
		}

		// Token: 0x06000ED1 RID: 3793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ED1")]
		[Address(RVA = "0x56D03E0", Offset = "0x56CEFE0", VA = "0x1856D03E0", Slot = "31")]
		public override void SetLightBarColor(Color color)
		{
		}

		// Token: 0x06000ED2 RID: 3794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ED2")]
		[Address(RVA = "0x56D07A0", Offset = "0x56CF3A0", VA = "0x1856D07A0", Slot = "29")]
		public override void SetMotorSpeeds(float lowFrequency, float highFrequency)
		{
		}

		// Token: 0x06000ED3 RID: 3795 RVA: 0x000074B8 File Offset: 0x000056B8
		[Token(Token = "0x6000ED3")]
		[Address(RVA = "0x56D0490", Offset = "0x56CF090", VA = "0x1856D0490")]
		public bool SetMotorSpeedsAndLightBarColor(float? lowFrequency, float? highFrequency, Color? color)
		{
			return default(bool);
		}

		// Token: 0x06000ED4 RID: 3796 RVA: 0x000074D0 File Offset: 0x000056D0
		[Token(Token = "0x6000ED4")]
		[Address(RVA = "0x56CFF90", Offset = "0x56CEB90", VA = "0x1856CFF90")]
		[MethodImpl(256)]
		private unsafe static bool MergeForward(DualSenseGamepadHID.DualSenseHIDUSBInputReport* currentState, DualSenseGamepadHID.DualSenseHIDUSBInputReport* nextState)
		{
			return default(bool);
		}

		// Token: 0x06000ED5 RID: 3797 RVA: 0x000074E8 File Offset: 0x000056E8
		[Token(Token = "0x6000ED5")]
		[Address(RVA = "0x56CFFD0", Offset = "0x56CEBD0", VA = "0x1856CFFD0")]
		[MethodImpl(256)]
		private unsafe static bool MergeForward(DualSenseGamepadHID.DualSenseHIDBluetoothInputReport* currentState, DualSenseGamepadHID.DualSenseHIDBluetoothInputReport* nextState)
		{
			return default(bool);
		}

		// Token: 0x06000ED6 RID: 3798 RVA: 0x00007500 File Offset: 0x00005700
		[Token(Token = "0x6000ED6")]
		[Address(RVA = "0x56D0010", Offset = "0x56CEC10", VA = "0x1856D0010")]
		[MethodImpl(256)]
		private unsafe static bool MergeForward(DualSenseGamepadHID.DualSenseHIDMinimalInputReport* currentState, DualSenseGamepadHID.DualSenseHIDMinimalInputReport* nextState)
		{
			return default(bool);
		}

		// Token: 0x06000ED7 RID: 3799 RVA: 0x00007518 File Offset: 0x00005718
		[Token(Token = "0x6000ED7")]
		[Address(RVA = "0x56D0880", Offset = "0x56CF480", VA = "0x1856D0880", Slot = "32")]
		private bool MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr)
		{
			return default(bool);
		}

		// Token: 0x06000ED8 RID: 3800 RVA: 0x00007530 File Offset: 0x00005730
		[Token(Token = "0x6000ED8")]
		[Address(RVA = "0x56D0B40", Offset = "0x56CF740", VA = "0x1856D0B40", Slot = "33")]
		private bool PreProcessEvent(InputEventPtr eventPtr)
		{
			return default(bool);
		}

		// Token: 0x06000ED9 RID: 3801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ED9")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "34")]
		public void OnNextUpdate()
		{
		}

		// Token: 0x06000EDA RID: 3802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EDA")]
		[Address(RVA = "0x56D0050", Offset = "0x56CEC50", VA = "0x1856D0050", Slot = "35")]
		public void OnStateEvent(InputEventPtr eventPtr)
		{
		}

		// Token: 0x06000EDB RID: 3803 RVA: 0x00007548 File Offset: 0x00005748
		[Token(Token = "0x6000EDB")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "36")]
		public bool GetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, ref uint offset)
		{
			return default(bool);
		}

		// Token: 0x06000EDC RID: 3804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EDC")]
		[Address(RVA = "0x55DCFE0", Offset = "0x55DBBE0", VA = "0x1855DCFE0")]
		public DualSenseGamepadHID()
		{
		}

		// Token: 0x04000856 RID: 2134
		[Token(Token = "0x4000856")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private float? m_LowFrequencyMotorSpeed;

		// Token: 0x04000857 RID: 2135
		[Token(Token = "0x4000857")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private float? m_HighFrequenceyMotorSpeed;

		// Token: 0x04000858 RID: 2136
		[Token(Token = "0x4000858")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private Color? m_LightBarColor;

		// Token: 0x04000859 RID: 2137
		[Token(Token = "0x4000859")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x274")]
		private byte outputSequenceId;

		// Token: 0x0400085A RID: 2138
		[Token(Token = "0x400085A")]
		internal const byte JitterMaskLow = 120;

		// Token: 0x0400085B RID: 2139
		[Token(Token = "0x400085B")]
		internal const byte JitterMaskHigh = 135;

		// Token: 0x02000152 RID: 338
		[Token(Token = "0x2000152")]
		[StructLayout(2)]
		internal struct DualSenseHIDGenericInputReport
		{
			// Token: 0x170003FC RID: 1020
			// (get) Token: 0x06000EDD RID: 3805 RVA: 0x00007560 File Offset: 0x00005760
			[Token(Token = "0x170003FC")]
			public static FourCC Format
			{
				[Token(Token = "0x6000EDD")]
				[Address(RVA = "0x56C9890", Offset = "0x56C8490", VA = "0x1856C9890")]
				get
				{
					return default(FourCC);
				}
			}

			// Token: 0x0400085C RID: 2140
			[Token(Token = "0x400085C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public byte reportId;
		}

		// Token: 0x02000153 RID: 339
		[Token(Token = "0x2000153")]
		[StructLayout(2)]
		internal struct DualSenseHIDUSBInputReport
		{
			// Token: 0x06000EDE RID: 3806 RVA: 0x00007578 File Offset: 0x00005778
			[Token(Token = "0x6000EDE")]
			[Address(RVA = "0x56D1130", Offset = "0x56CFD30", VA = "0x1856D1130")]
			[MethodImpl(256)]
			public DualSenseHIDInputReport ToHIDInputReport()
			{
				return default(DualSenseHIDInputReport);
			}

			// Token: 0x0400085D RID: 2141
			[Token(Token = "0x400085D")]
			public const int ExpectedReportId = 1;

			// Token: 0x0400085E RID: 2142
			[Token(Token = "0x400085E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public byte reportId;

			// Token: 0x0400085F RID: 2143
			[Token(Token = "0x400085F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public byte leftStickX;

			// Token: 0x04000860 RID: 2144
			[Token(Token = "0x4000860")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
			public byte leftStickY;

			// Token: 0x04000861 RID: 2145
			[Token(Token = "0x4000861")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
			public byte rightStickX;

			// Token: 0x04000862 RID: 2146
			[Token(Token = "0x4000862")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public byte rightStickY;

			// Token: 0x04000863 RID: 2147
			[Token(Token = "0x4000863")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
			public byte leftTrigger;

			// Token: 0x04000864 RID: 2148
			[Token(Token = "0x4000864")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
			public byte rightTrigger;

			// Token: 0x04000865 RID: 2149
			[Token(Token = "0x4000865")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public byte buttons0;

			// Token: 0x04000866 RID: 2150
			[Token(Token = "0x4000866")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
			public byte buttons1;

			// Token: 0x04000867 RID: 2151
			[Token(Token = "0x4000867")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
			public byte buttons2;
		}

		// Token: 0x02000154 RID: 340
		[Token(Token = "0x2000154")]
		[StructLayout(2)]
		internal struct DualSenseHIDBluetoothInputReport
		{
			// Token: 0x06000EDF RID: 3807 RVA: 0x00007590 File Offset: 0x00005790
			[Token(Token = "0x6000EDF")]
			[Address(RVA = "0x56D0EB0", Offset = "0x56CFAB0", VA = "0x1856D0EB0")]
			[MethodImpl(256)]
			public DualSenseHIDInputReport ToHIDInputReport()
			{
				return default(DualSenseHIDInputReport);
			}

			// Token: 0x04000868 RID: 2152
			[Token(Token = "0x4000868")]
			public const int ExpectedReportId = 49;

			// Token: 0x04000869 RID: 2153
			[Token(Token = "0x4000869")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public byte reportId;

			// Token: 0x0400086A RID: 2154
			[Token(Token = "0x400086A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
			public byte leftStickX;

			// Token: 0x0400086B RID: 2155
			[Token(Token = "0x400086B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
			public byte leftStickY;

			// Token: 0x0400086C RID: 2156
			[Token(Token = "0x400086C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public byte rightStickX;

			// Token: 0x0400086D RID: 2157
			[Token(Token = "0x400086D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
			public byte rightStickY;

			// Token: 0x0400086E RID: 2158
			[Token(Token = "0x400086E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
			public byte leftTrigger;

			// Token: 0x0400086F RID: 2159
			[Token(Token = "0x400086F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7")]
			public byte rightTrigger;

			// Token: 0x04000870 RID: 2160
			[Token(Token = "0x4000870")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
			public byte buttons0;

			// Token: 0x04000871 RID: 2161
			[Token(Token = "0x4000871")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
			public byte buttons1;

			// Token: 0x04000872 RID: 2162
			[Token(Token = "0x4000872")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB")]
			public byte buttons2;
		}

		// Token: 0x02000155 RID: 341
		[Token(Token = "0x2000155")]
		[StructLayout(2)]
		internal struct DualSenseHIDMinimalInputReport
		{
			// Token: 0x06000EE0 RID: 3808 RVA: 0x000075A8 File Offset: 0x000057A8
			[Token(Token = "0x6000EE0")]
			[Address(RVA = "0x56D1090", Offset = "0x56CFC90", VA = "0x1856D1090")]
			[MethodImpl(256)]
			public DualSenseHIDInputReport ToHIDInputReport()
			{
				return default(DualSenseHIDInputReport);
			}

			// Token: 0x04000873 RID: 2163
			[Token(Token = "0x4000873")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static int ExpectedSize1;

			// Token: 0x04000874 RID: 2164
			[Token(Token = "0x4000874")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public static int ExpectedSize2;

			// Token: 0x04000875 RID: 2165
			[Token(Token = "0x4000875")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public byte reportId;

			// Token: 0x04000876 RID: 2166
			[Token(Token = "0x4000876")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public byte leftStickX;

			// Token: 0x04000877 RID: 2167
			[Token(Token = "0x4000877")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
			public byte leftStickY;

			// Token: 0x04000878 RID: 2168
			[Token(Token = "0x4000878")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
			public byte rightStickX;

			// Token: 0x04000879 RID: 2169
			[Token(Token = "0x4000879")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public byte rightStickY;

			// Token: 0x0400087A RID: 2170
			[Token(Token = "0x400087A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
			public byte buttons0;

			// Token: 0x0400087B RID: 2171
			[Token(Token = "0x400087B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
			public byte buttons1;

			// Token: 0x0400087C RID: 2172
			[Token(Token = "0x400087C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7")]
			public byte buttons2;

			// Token: 0x0400087D RID: 2173
			[Token(Token = "0x400087D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public byte leftTrigger;

			// Token: 0x0400087E RID: 2174
			[Token(Token = "0x400087E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
			public byte rightTrigger;
		}
	}
}
