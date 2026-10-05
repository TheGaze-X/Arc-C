using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Collections;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel
{
	// Token: 0x02000172 RID: 370
	[Token(Token = "0x2000172")]
	[StructLayout(2)]
	public struct InputDeviceCommand : IInputDeviceCommandInfo
	{
		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06000F33 RID: 3891 RVA: 0x000078D8 File Offset: 0x00005AD8
		[Token(Token = "0x1700041A")]
		public int payloadSizeInBytes
		{
			[Token(Token = "0x6000F33")]
			[Address(RVA = "0x56D9BD0", Offset = "0x56D87D0", VA = "0x1856D9BD0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06000F34 RID: 3892 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700041B")]
		public unsafe void* payloadPtr
		{
			[Token(Token = "0x6000F34")]
			[Address(RVA = "0x56D9BC0", Offset = "0x56D87C0", VA = "0x1856D9BC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000F35 RID: 3893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F35")]
		[Address(RVA = "0x4F1E60", Offset = "0x4F0A60", VA = "0x1804F1E60")]
		public InputDeviceCommand(FourCC type, int sizeInBytes = 8)
		{
		}

		// Token: 0x06000F36 RID: 3894 RVA: 0x000078F0 File Offset: 0x00005AF0
		[Token(Token = "0x6000F36")]
		[Address(RVA = "0x56D9B10", Offset = "0x56D8710", VA = "0x1856D9B10")]
		public static NativeArray<byte> AllocateNative(FourCC type, int payloadSize)
		{
			return default(NativeArray<byte>);
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06000F37 RID: 3895 RVA: 0x00007908 File Offset: 0x00005B08
		[Token(Token = "0x1700041C")]
		public FourCC typeStatic
		{
			[Token(Token = "0x6000F37")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "4")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x040008E8 RID: 2280
		[Token(Token = "0x40008E8")]
		internal const int kBaseCommandSize = 8;

		// Token: 0x040008E9 RID: 2281
		[Token(Token = "0x40008E9")]
		public const int BaseCommandSize = 8;

		// Token: 0x040008EA RID: 2282
		[Token(Token = "0x40008EA")]
		public const long GenericFailure = -1L;

		// Token: 0x040008EB RID: 2283
		[Token(Token = "0x40008EB")]
		public const long GenericSuccess = 1L;

		// Token: 0x040008EC RID: 2284
		[Token(Token = "0x40008EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public FourCC type;

		// Token: 0x040008ED RID: 2285
		[Token(Token = "0x40008ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int sizeInBytes;
	}
}
