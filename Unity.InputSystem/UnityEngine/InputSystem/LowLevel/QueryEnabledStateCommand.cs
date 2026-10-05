using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel
{
	// Token: 0x02000175 RID: 373
	[Token(Token = "0x2000175")]
	[StructLayout(2)]
	public struct QueryEnabledStateCommand : IInputDeviceCommandInfo
	{
		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06000F3E RID: 3902 RVA: 0x000079B0 File Offset: 0x00005BB0
		[Token(Token = "0x17000421")]
		public static FourCC Type
		{
			[Token(Token = "0x6000F3E")]
			[Address(RVA = "0x56DF2D0", Offset = "0x56DDED0", VA = "0x1856DF2D0")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06000F3F RID: 3903 RVA: 0x000079C8 File Offset: 0x00005BC8
		[Token(Token = "0x17000422")]
		public FourCC typeStatic
		{
			[Token(Token = "0x6000F3F")]
			[Address(RVA = "0x56DF310", Offset = "0x56DDF10", VA = "0x1856DF310", Slot = "4")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x06000F40 RID: 3904 RVA: 0x000079E0 File Offset: 0x00005BE0
		[Token(Token = "0x6000F40")]
		[Address(RVA = "0x56DF270", Offset = "0x56DDE70", VA = "0x1856DF270")]
		public static QueryEnabledStateCommand Create()
		{
			return default(QueryEnabledStateCommand);
		}

		// Token: 0x040008F4 RID: 2292
		[Token(Token = "0x40008F4")]
		internal const int kSize = 9;

		// Token: 0x040008F5 RID: 2293
		[Token(Token = "0x40008F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InputDeviceCommand baseCommand;

		// Token: 0x040008F6 RID: 2294
		[Token(Token = "0x40008F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool isEnabled;
	}
}
