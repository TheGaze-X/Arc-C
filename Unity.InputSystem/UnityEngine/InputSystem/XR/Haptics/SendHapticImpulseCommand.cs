using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.XR.Haptics
{
	// Token: 0x020000F6 RID: 246
	[Token(Token = "0x20000F6")]
	[StructLayout(2)]
	public struct SendHapticImpulseCommand : IInputDeviceCommandInfo
	{
		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06000C4E RID: 3150 RVA: 0x00005F28 File Offset: 0x00004128
		[Token(Token = "0x17000338")]
		private static FourCC Type
		{
			[Token(Token = "0x6000C4E")]
			[Address(RVA = "0x56B03F0", Offset = "0x56AEFF0", VA = "0x1856B03F0")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06000C4F RID: 3151 RVA: 0x00005F40 File Offset: 0x00004140
		[Token(Token = "0x17000339")]
		public FourCC typeStatic
		{
			[Token(Token = "0x6000C4F")]
			[Address(RVA = "0x56B0430", Offset = "0x56AF030", VA = "0x1856B0430", Slot = "4")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x06000C50 RID: 3152 RVA: 0x00005F58 File Offset: 0x00004158
		[Token(Token = "0x6000C50")]
		[Address(RVA = "0x56B0340", Offset = "0x56AEF40", VA = "0x1856B0340")]
		public static SendHapticImpulseCommand Create(int motorChannel, float motorAmplitude, float motorDuration)
		{
			return default(SendHapticImpulseCommand);
		}

		// Token: 0x04000582 RID: 1410
		[Token(Token = "0x4000582")]
		private const int kSize = 20;

		// Token: 0x04000583 RID: 1411
		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private InputDeviceCommand baseCommand;

		// Token: 0x04000584 RID: 1412
		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private int channel;

		// Token: 0x04000585 RID: 1413
		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private float amplitude;

		// Token: 0x04000586 RID: 1414
		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private float duration;
	}
}
