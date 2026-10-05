using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel
{
	// Token: 0x02000189 RID: 393
	[Token(Token = "0x2000189")]
	[StructLayout(2)]
	internal struct DualMotorRumbleCommand : IInputDeviceCommandInfo
	{
		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06000F6F RID: 3951 RVA: 0x00007D70 File Offset: 0x00005F70
		[Token(Token = "0x1700043E")]
		public static FourCC Type
		{
			[Token(Token = "0x6000F6F")]
			[Address(RVA = "0x56CF9D0", Offset = "0x56CE5D0", VA = "0x1856CF9D0")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06000F70 RID: 3952 RVA: 0x00007D88 File Offset: 0x00005F88
		[Token(Token = "0x1700043F")]
		public FourCC typeStatic
		{
			[Token(Token = "0x6000F70")]
			[Address(RVA = "0x56CFA10", Offset = "0x56CE610", VA = "0x1856CFA10", Slot = "4")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x06000F71 RID: 3953 RVA: 0x00007DA0 File Offset: 0x00005FA0
		[Token(Token = "0x6000F71")]
		[Address(RVA = "0x56CF950", Offset = "0x56CE550", VA = "0x1856CF950")]
		public static DualMotorRumbleCommand Create(float lowFrequency, float highFrequency)
		{
			return default(DualMotorRumbleCommand);
		}

		// Token: 0x04000949 RID: 2377
		[Token(Token = "0x4000949")]
		internal const int kSize = 16;

		// Token: 0x0400094A RID: 2378
		[Token(Token = "0x400094A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InputDeviceCommand baseCommand;

		// Token: 0x0400094B RID: 2379
		[Token(Token = "0x400094B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float lowFrequencyMotorSpeed;

		// Token: 0x0400094C RID: 2380
		[Token(Token = "0x400094C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float highFrequencyMotorSpeed;
	}
}
