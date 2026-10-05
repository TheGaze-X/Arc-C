using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.XR.Haptics
{
	// Token: 0x020000F3 RID: 243
	[Token(Token = "0x20000F3")]
	[StructLayout(2)]
	public struct GetHapticCapabilitiesCommand : IInputDeviceCommandInfo
	{
		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06000C47 RID: 3143 RVA: 0x00005E80 File Offset: 0x00004080
		[Token(Token = "0x17000333")]
		private static FourCC Type
		{
			[Token(Token = "0x6000C47")]
			[Address(RVA = "0x569DFD0", Offset = "0x569CBD0", VA = "0x18569DFD0")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06000C48 RID: 3144 RVA: 0x00005E98 File Offset: 0x00004098
		[Token(Token = "0x17000334")]
		public FourCC typeStatic
		{
			[Token(Token = "0x6000C48")]
			[Address(RVA = "0x569E030", Offset = "0x569CC30", VA = "0x18569E030", Slot = "4")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06000C49 RID: 3145 RVA: 0x00005EB0 File Offset: 0x000040B0
		[Token(Token = "0x17000335")]
		public HapticCapabilities capabilities
		{
			[Token(Token = "0x6000C49")]
			[Address(RVA = "0x569E010", Offset = "0x569CC10", VA = "0x18569E010")]
			get
			{
				return default(HapticCapabilities);
			}
		}

		// Token: 0x06000C4A RID: 3146 RVA: 0x00005EC8 File Offset: 0x000040C8
		[Token(Token = "0x6000C4A")]
		[Address(RVA = "0x569DF60", Offset = "0x569CB60", VA = "0x18569DF60")]
		public static GetHapticCapabilitiesCommand Create()
		{
			return default(GetHapticCapabilitiesCommand);
		}

		// Token: 0x04000576 RID: 1398
		[Token(Token = "0x4000576")]
		private const int kSize = 20;

		// Token: 0x04000577 RID: 1399
		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private InputDeviceCommand baseCommand;

		// Token: 0x04000578 RID: 1400
		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint numChannels;

		// Token: 0x04000579 RID: 1401
		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint frequencyHz;

		// Token: 0x0400057A RID: 1402
		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint maxBufferSize;
	}
}
