using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.XR.Haptics
{
	// Token: 0x020000F1 RID: 241
	[Token(Token = "0x20000F1")]
	[StructLayout(2)]
	public struct GetCurrentHapticStateCommand : IInputDeviceCommandInfo
	{
		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000C3C RID: 3132 RVA: 0x00005DD8 File Offset: 0x00003FD8
		[Token(Token = "0x1700032D")]
		private static FourCC Type
		{
			[Token(Token = "0x6000C3C")]
			[Address(RVA = "0x569DEC0", Offset = "0x569CAC0", VA = "0x18569DEC0")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000C3D RID: 3133 RVA: 0x00005DF0 File Offset: 0x00003FF0
		[Token(Token = "0x1700032E")]
		public FourCC typeStatic
		{
			[Token(Token = "0x6000C3D")]
			[Address(RVA = "0x569DF20", Offset = "0x569CB20", VA = "0x18569DF20", Slot = "4")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000C3E RID: 3134 RVA: 0x00005E08 File Offset: 0x00004008
		[Token(Token = "0x1700032F")]
		public HapticState currentState
		{
			[Token(Token = "0x6000C3E")]
			[Address(RVA = "0x569DF00", Offset = "0x569CB00", VA = "0x18569DF00")]
			get
			{
				return default(HapticState);
			}
		}

		// Token: 0x06000C3F RID: 3135 RVA: 0x00005E20 File Offset: 0x00004020
		[Token(Token = "0x6000C3F")]
		[Address(RVA = "0x569DE50", Offset = "0x569CA50", VA = "0x18569DE50")]
		public static GetCurrentHapticStateCommand Create()
		{
			return default(GetCurrentHapticStateCommand);
		}

		// Token: 0x0400056F RID: 1391
		[Token(Token = "0x400056F")]
		private const int kSize = 16;

		// Token: 0x04000570 RID: 1392
		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private InputDeviceCommand baseCommand;

		// Token: 0x04000571 RID: 1393
		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint samplesQueued;

		// Token: 0x04000572 RID: 1394
		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint samplesAvailable;
	}
}
