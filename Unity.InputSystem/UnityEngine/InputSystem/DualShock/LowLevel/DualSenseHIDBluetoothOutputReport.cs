using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.DualShock.LowLevel
{
	// Token: 0x0200015E RID: 350
	[Token(Token = "0x200015E")]
	[StructLayout(2)]
	internal struct DualSenseHIDBluetoothOutputReport : IInputDeviceCommandInfo
	{
		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06000F05 RID: 3845 RVA: 0x00007698 File Offset: 0x00005898
		[Token(Token = "0x17000407")]
		public static FourCC Type
		{
			[Token(Token = "0x6000F05")]
			[Address(RVA = "0x56C9CB0", Offset = "0x56C88B0", VA = "0x1856C9CB0")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06000F06 RID: 3846 RVA: 0x000076B0 File Offset: 0x000058B0
		[Token(Token = "0x17000408")]
		public FourCC typeStatic
		{
			[Token(Token = "0x6000F06")]
			[Address(RVA = "0x56C9CF0", Offset = "0x56C88F0", VA = "0x1856C9CF0", Slot = "4")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x06000F07 RID: 3847 RVA: 0x000076C8 File Offset: 0x000058C8
		[Token(Token = "0x6000F07")]
		[Address(RVA = "0x56D0F00", Offset = "0x56CFB00", VA = "0x1856D0F00")]
		public static DualSenseHIDBluetoothOutputReport Create(DualSenseHIDOutputReportPayload payload, byte outputSequenceId)
		{
			return default(DualSenseHIDBluetoothOutputReport);
		}

		// Token: 0x040008A8 RID: 2216
		[Token(Token = "0x40008A8")]
		internal const int kSize = 86;

		// Token: 0x040008A9 RID: 2217
		[Token(Token = "0x40008A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InputDeviceCommand baseCommand;

		// Token: 0x040008AA RID: 2218
		[Token(Token = "0x40008AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public byte reportId;

		// Token: 0x040008AB RID: 2219
		[Token(Token = "0x40008AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
		public byte tag1;

		// Token: 0x040008AC RID: 2220
		[Token(Token = "0x40008AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		public byte tag2;

		// Token: 0x040008AD RID: 2221
		[Token(Token = "0x40008AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB")]
		public DualSenseHIDOutputReportPayload payload;

		// Token: 0x040008AE RID: 2222
		[Token(Token = "0x40008AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
		public uint crc32;

		// Token: 0x040008AF RID: 2223
		[Token(Token = "0x40008AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[FixedBuffer(typeof(byte), 74)]
		public DualSenseHIDBluetoothOutputReport.<rawData>e__FixedBuffer rawData;

		// Token: 0x0200015F RID: 351
		[Token(Token = "0x200015F")]
		[CompilerGenerated]
		[UnsafeValueType]
		public struct <rawData>e__FixedBuffer
		{
			// Token: 0x040008B0 RID: 2224
			[Token(Token = "0x40008B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public byte FixedElementField;
		}
	}
}
