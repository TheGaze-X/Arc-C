using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel
{
	// Token: 0x0200016A RID: 362
	[Token(Token = "0x200016A")]
	[StructLayout(2)]
	public struct DisableDeviceCommand : IInputDeviceCommandInfo
	{
		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06000F1D RID: 3869 RVA: 0x000077A0 File Offset: 0x000059A0
		[Token(Token = "0x17000410")]
		public static FourCC Type
		{
			[Token(Token = "0x6000F1D")]
			[Address(RVA = "0x56CF790", Offset = "0x56CE390", VA = "0x1856CF790")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06000F1E RID: 3870 RVA: 0x000077B8 File Offset: 0x000059B8
		[Token(Token = "0x17000411")]
		public FourCC typeStatic
		{
			[Token(Token = "0x6000F1E")]
			[Address(RVA = "0x56CF7D0", Offset = "0x56CE3D0", VA = "0x1856CF7D0", Slot = "4")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x06000F1F RID: 3871 RVA: 0x000077D0 File Offset: 0x000059D0
		[Token(Token = "0x6000F1F")]
		[Address(RVA = "0x56CF740", Offset = "0x56CE340", VA = "0x1856CF740")]
		public static DisableDeviceCommand Create()
		{
			return default(DisableDeviceCommand);
		}

		// Token: 0x040008DB RID: 2267
		[Token(Token = "0x40008DB")]
		internal const int kSize = 8;

		// Token: 0x040008DC RID: 2268
		[Token(Token = "0x40008DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InputDeviceCommand baseCommand;
	}
}
