using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel
{
	// Token: 0x02000184 RID: 388
	[Token(Token = "0x2000184")]
	[StructLayout(2)]
	public struct SetSamplingFrequencyCommand : IInputDeviceCommandInfo
	{
		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06000F62 RID: 3938 RVA: 0x00007C50 File Offset: 0x00005E50
		[Token(Token = "0x17000436")]
		public static FourCC Type
		{
			[Token(Token = "0x6000F62")]
			[Address(RVA = "0x56DFDD0", Offset = "0x56DE9D0", VA = "0x1856DFDD0")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06000F63 RID: 3939 RVA: 0x00007C68 File Offset: 0x00005E68
		[Token(Token = "0x17000437")]
		public FourCC typeStatic
		{
			[Token(Token = "0x6000F63")]
			[Address(RVA = "0x56DFE10", Offset = "0x56DEA10", VA = "0x1856DFE10", Slot = "4")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x06000F64 RID: 3940 RVA: 0x00007C80 File Offset: 0x00005E80
		[Token(Token = "0x6000F64")]
		[Address(RVA = "0x56DFD60", Offset = "0x56DE960", VA = "0x1856DFD60")]
		public static SetSamplingFrequencyCommand Create(float frequency)
		{
			return default(SetSamplingFrequencyCommand);
		}

		// Token: 0x0400091E RID: 2334
		[Token(Token = "0x400091E")]
		internal const int kSize = 12;

		// Token: 0x0400091F RID: 2335
		[Token(Token = "0x400091F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InputDeviceCommand baseCommand;

		// Token: 0x04000920 RID: 2336
		[Token(Token = "0x4000920")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float frequency;
	}
}
