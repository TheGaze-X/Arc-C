using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel
{
	// Token: 0x0200016E RID: 366
	[Token(Token = "0x200016E")]
	[StructLayout(2)]
	public struct InitiateUserAccountPairingCommand : IInputDeviceCommandInfo
	{
		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06000F28 RID: 3880 RVA: 0x00007890 File Offset: 0x00005A90
		[Token(Token = "0x17000418")]
		public static FourCC Type
		{
			[Token(Token = "0x6000F28")]
			[Address(RVA = "0x56D9A90", Offset = "0x56D8690", VA = "0x1856D9A90")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06000F29 RID: 3881 RVA: 0x000078A8 File Offset: 0x00005AA8
		[Token(Token = "0x17000419")]
		public FourCC typeStatic
		{
			[Token(Token = "0x6000F29")]
			[Address(RVA = "0x56D9AD0", Offset = "0x56D86D0", VA = "0x1856D9AD0", Slot = "4")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x06000F2A RID: 3882 RVA: 0x000078C0 File Offset: 0x00005AC0
		[Token(Token = "0x6000F2A")]
		[Address(RVA = "0x56D9A40", Offset = "0x56D8640", VA = "0x1856D9A40")]
		public static InitiateUserAccountPairingCommand Create()
		{
			return default(InitiateUserAccountPairingCommand);
		}

		// Token: 0x040008E2 RID: 2274
		[Token(Token = "0x40008E2")]
		internal const int kSize = 8;

		// Token: 0x040008E3 RID: 2275
		[Token(Token = "0x40008E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InputDeviceCommand baseCommand;

		// Token: 0x0200016F RID: 367
		[Token(Token = "0x200016F")]
		public enum Result
		{
			// Token: 0x040008E5 RID: 2277
			[Token(Token = "0x40008E5")]
			SuccessfullyInitiated = 1,
			// Token: 0x040008E6 RID: 2278
			[Token(Token = "0x40008E6")]
			ErrorNotSupported = -1,
			// Token: 0x040008E7 RID: 2279
			[Token(Token = "0x40008E7")]
			ErrorAlreadyInProgress = -2
		}
	}
}
