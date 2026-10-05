using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.DualShock.LowLevel
{
	// Token: 0x02000163 RID: 355
	[Token(Token = "0x2000163")]
	[StructLayout(2)]
	internal struct DualShockHIDOutputReport : IInputDeviceCommandInfo
	{
		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06000F0B RID: 3851 RVA: 0x00007710 File Offset: 0x00005910
		[Token(Token = "0x1700040B")]
		public static FourCC Type
		{
			[Token(Token = "0x6000F0B")]
			[Address(RVA = "0x56C9CB0", Offset = "0x56C88B0", VA = "0x1856C9CB0")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06000F0C RID: 3852 RVA: 0x00007728 File Offset: 0x00005928
		[Token(Token = "0x1700040C")]
		public FourCC typeStatic
		{
			[Token(Token = "0x6000F0C")]
			[Address(RVA = "0x56C9CF0", Offset = "0x56C88F0", VA = "0x1856C9CF0", Slot = "4")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x06000F0D RID: 3853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F0D")]
		[Address(RVA = "0x56D2760", Offset = "0x56D1360", VA = "0x1856D2760")]
		public void SetMotorSpeeds(float lowFreq, float highFreq)
		{
		}

		// Token: 0x06000F0E RID: 3854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F0E")]
		[Address(RVA = "0x56D26E0", Offset = "0x56D12E0", VA = "0x1856D26E0")]
		public void SetColor(Color color)
		{
		}

		// Token: 0x06000F0F RID: 3855 RVA: 0x00007740 File Offset: 0x00005940
		[Token(Token = "0x6000F0F")]
		[Address(RVA = "0x56D2670", Offset = "0x56D1270", VA = "0x1856D2670")]
		public static DualShockHIDOutputReport Create()
		{
			return default(DualShockHIDOutputReport);
		}

		// Token: 0x040008C8 RID: 2248
		[Token(Token = "0x40008C8")]
		internal const int kSize = 40;

		// Token: 0x040008C9 RID: 2249
		[Token(Token = "0x40008C9")]
		internal const int kReportId = 5;

		// Token: 0x040008CA RID: 2250
		[Token(Token = "0x40008CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InputDeviceCommand baseCommand;

		// Token: 0x040008CB RID: 2251
		[Token(Token = "0x40008CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public byte reportId;

		// Token: 0x040008CC RID: 2252
		[Token(Token = "0x40008CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
		public byte flags;

		// Token: 0x040008CD RID: 2253
		[Token(Token = "0x40008CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		[FixedBuffer(typeof(byte), 2)]
		public DualShockHIDOutputReport.<unknown1>e__FixedBuffer unknown1;

		// Token: 0x040008CE RID: 2254
		[Token(Token = "0x40008CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public byte highFrequencyMotorSpeed;

		// Token: 0x040008CF RID: 2255
		[Token(Token = "0x40008CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
		public byte lowFrequencyMotorSpeed;

		// Token: 0x040008D0 RID: 2256
		[Token(Token = "0x40008D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
		public byte redColor;

		// Token: 0x040008D1 RID: 2257
		[Token(Token = "0x40008D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
		public byte greenColor;

		// Token: 0x040008D2 RID: 2258
		[Token(Token = "0x40008D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public byte blueColor;

		// Token: 0x040008D3 RID: 2259
		[Token(Token = "0x40008D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		[FixedBuffer(typeof(byte), 23)]
		public DualShockHIDOutputReport.<unknown2>e__FixedBuffer unknown2;

		// Token: 0x02000164 RID: 356
		[Token(Token = "0x2000164")]
		[Flags]
		public enum Flags
		{
			// Token: 0x040008D5 RID: 2261
			[Token(Token = "0x40008D5")]
			Rumble = 1,
			// Token: 0x040008D6 RID: 2262
			[Token(Token = "0x40008D6")]
			Color = 2
		}

		// Token: 0x02000165 RID: 357
		[Token(Token = "0x2000165")]
		[CompilerGenerated]
		[UnsafeValueType]
		public struct <unknown1>e__FixedBuffer
		{
			// Token: 0x040008D7 RID: 2263
			[Token(Token = "0x40008D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public byte FixedElementField;
		}

		// Token: 0x02000166 RID: 358
		[Token(Token = "0x2000166")]
		[CompilerGenerated]
		[UnsafeValueType]
		public struct <unknown2>e__FixedBuffer
		{
			// Token: 0x040008D8 RID: 2264
			[Token(Token = "0x40008D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public byte FixedElementField;
		}
	}
}
