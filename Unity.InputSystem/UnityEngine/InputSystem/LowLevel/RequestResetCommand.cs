using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel
{
	// Token: 0x02000181 RID: 385
	[Token(Token = "0x2000181")]
	[StructLayout(2)]
	public struct RequestResetCommand : IInputDeviceCommandInfo
	{
		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06000F58 RID: 3928 RVA: 0x00007B60 File Offset: 0x00005D60
		[Token(Token = "0x1700042F")]
		public static FourCC Type
		{
			[Token(Token = "0x6000F58")]
			[Address(RVA = "0x56DFB20", Offset = "0x56DE720", VA = "0x1856DFB20")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06000F59 RID: 3929 RVA: 0x00007B78 File Offset: 0x00005D78
		[Token(Token = "0x17000430")]
		public FourCC typeStatic
		{
			[Token(Token = "0x6000F59")]
			[Address(RVA = "0x56DFB60", Offset = "0x56DE760", VA = "0x1856DFB60", Slot = "4")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x06000F5A RID: 3930 RVA: 0x00007B90 File Offset: 0x00005D90
		[Token(Token = "0x6000F5A")]
		[Address(RVA = "0x56DFAD0", Offset = "0x56DE6D0", VA = "0x1856DFAD0")]
		public static RequestResetCommand Create()
		{
			return default(RequestResetCommand);
		}

		// Token: 0x04000917 RID: 2327
		[Token(Token = "0x4000917")]
		internal const int kSize = 8;

		// Token: 0x04000918 RID: 2328
		[Token(Token = "0x4000918")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InputDeviceCommand baseCommand;
	}
}
