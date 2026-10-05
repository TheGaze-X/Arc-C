using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel
{
	// Token: 0x02000185 RID: 389
	[Token(Token = "0x2000185")]
	[StructLayout(2)]
	internal struct UseWindowsGamingInputCommand : IInputDeviceCommandInfo
	{
		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06000F65 RID: 3941 RVA: 0x00007C98 File Offset: 0x00005E98
		[Token(Token = "0x17000438")]
		public static FourCC Type
		{
			[Token(Token = "0x6000F65")]
			[Address(RVA = "0x56E4240", Offset = "0x56E2E40", VA = "0x1856E4240")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06000F66 RID: 3942 RVA: 0x00007CB0 File Offset: 0x00005EB0
		[Token(Token = "0x17000439")]
		public FourCC typeStatic
		{
			[Token(Token = "0x6000F66")]
			[Address(RVA = "0x56E4280", Offset = "0x56E2E80", VA = "0x1856E4280", Slot = "4")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x06000F67 RID: 3943 RVA: 0x00007CC8 File Offset: 0x00005EC8
		[Token(Token = "0x6000F67")]
		[Address(RVA = "0x56E41D0", Offset = "0x56E2DD0", VA = "0x1856E41D0")]
		public static UseWindowsGamingInputCommand Create(bool enable)
		{
			return default(UseWindowsGamingInputCommand);
		}

		// Token: 0x04000921 RID: 2337
		[Token(Token = "0x4000921")]
		internal const int kSize = 9;

		// Token: 0x04000922 RID: 2338
		[Token(Token = "0x4000922")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InputDeviceCommand baseCommand;

		// Token: 0x04000923 RID: 2339
		[Token(Token = "0x4000923")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public byte enable;
	}
}
