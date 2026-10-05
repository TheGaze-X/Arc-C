using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.XR.Haptics
{
	// Token: 0x020000F4 RID: 244
	[Token(Token = "0x20000F4")]
	[StructLayout(2)]
	public struct SendBufferedHapticCommand : IInputDeviceCommandInfo
	{
		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06000C4B RID: 3147 RVA: 0x00005EE0 File Offset: 0x000040E0
		[Token(Token = "0x17000336")]
		private static FourCC Type
		{
			[Token(Token = "0x6000C4B")]
			[Address(RVA = "0x56B02C0", Offset = "0x56AEEC0", VA = "0x1856B02C0")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06000C4C RID: 3148 RVA: 0x00005EF8 File Offset: 0x000040F8
		[Token(Token = "0x17000337")]
		public FourCC typeStatic
		{
			[Token(Token = "0x6000C4C")]
			[Address(RVA = "0x56B0300", Offset = "0x56AEF00", VA = "0x1856B0300", Slot = "4")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x06000C4D RID: 3149 RVA: 0x00005F10 File Offset: 0x00004110
		[Token(Token = "0x6000C4D")]
		[Address(RVA = "0x56B0100", Offset = "0x56AED00", VA = "0x1856B0100")]
		public static SendBufferedHapticCommand Create(byte[] rumbleBuffer)
		{
			return default(SendBufferedHapticCommand);
		}

		// Token: 0x0400057B RID: 1403
		[Token(Token = "0x400057B")]
		private const int kMaxHapticBufferSize = 1024;

		// Token: 0x0400057C RID: 1404
		[Token(Token = "0x400057C")]
		private const int kSize = 1040;

		// Token: 0x0400057D RID: 1405
		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private InputDeviceCommand baseCommand;

		// Token: 0x0400057E RID: 1406
		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private int channel;

		// Token: 0x0400057F RID: 1407
		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private int bufferSize;

		// Token: 0x04000580 RID: 1408
		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[FixedBuffer(typeof(byte), 1024)]
		private SendBufferedHapticCommand.<buffer>e__FixedBuffer buffer;

		// Token: 0x020000F5 RID: 245
		[Token(Token = "0x20000F5")]
		[UnsafeValueType]
		[CompilerGenerated]
		public struct <buffer>e__FixedBuffer
		{
			// Token: 0x04000581 RID: 1409
			[Token(Token = "0x4000581")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public byte FixedElementField;
		}
	}
}
