using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel
{
	// Token: 0x0200017E RID: 382
	[Token(Token = "0x200017E")]
	[StructLayout(2)]
	internal struct QuerySamplingFrequencyCommand : IInputDeviceCommandInfo
	{
		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06000F51 RID: 3921 RVA: 0x00007AD0 File Offset: 0x00005CD0
		[Token(Token = "0x1700042B")]
		public static FourCC Type
		{
			[Token(Token = "0x6000F51")]
			[Address(RVA = "0x56DF970", Offset = "0x56DE570", VA = "0x1856DF970")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06000F52 RID: 3922 RVA: 0x00007AE8 File Offset: 0x00005CE8
		[Token(Token = "0x1700042C")]
		public FourCC typeStatic
		{
			[Token(Token = "0x6000F52")]
			[Address(RVA = "0x56DF9B0", Offset = "0x56DE5B0", VA = "0x1856DF9B0", Slot = "4")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x06000F53 RID: 3923 RVA: 0x00007B00 File Offset: 0x00005D00
		[Token(Token = "0x6000F53")]
		[Address(RVA = "0x56DF910", Offset = "0x56DE510", VA = "0x1856DF910")]
		public static QuerySamplingFrequencyCommand Create()
		{
			return default(QuerySamplingFrequencyCommand);
		}

		// Token: 0x0400090F RID: 2319
		[Token(Token = "0x400090F")]
		internal const int kSize = 12;

		// Token: 0x04000910 RID: 2320
		[Token(Token = "0x4000910")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InputDeviceCommand baseCommand;

		// Token: 0x04000911 RID: 2321
		[Token(Token = "0x4000911")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float frequency;
	}
}
