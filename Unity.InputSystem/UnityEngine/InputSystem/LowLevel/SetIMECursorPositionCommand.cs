using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel
{
	// Token: 0x02000183 RID: 387
	[Token(Token = "0x2000183")]
	[StructLayout(2)]
	public struct SetIMECursorPositionCommand : IInputDeviceCommandInfo
	{
		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06000F5E RID: 3934 RVA: 0x00007BF0 File Offset: 0x00005DF0
		[Token(Token = "0x17000433")]
		public static FourCC Type
		{
			[Token(Token = "0x6000F5E")]
			[Address(RVA = "0x56DFCE0", Offset = "0x56DE8E0", VA = "0x1856DFCE0")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06000F5F RID: 3935 RVA: 0x00007C08 File Offset: 0x00005E08
		[Token(Token = "0x17000434")]
		public Vector2 position
		{
			[Token(Token = "0x6000F5F")]
			[Address(RVA = "0x15795A0", Offset = "0x15781A0", VA = "0x1815795A0")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06000F60 RID: 3936 RVA: 0x00007C20 File Offset: 0x00005E20
		[Token(Token = "0x17000435")]
		public FourCC typeStatic
		{
			[Token(Token = "0x6000F60")]
			[Address(RVA = "0x56DFD20", Offset = "0x56DE920", VA = "0x1856DFD20", Slot = "4")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x06000F61 RID: 3937 RVA: 0x00007C38 File Offset: 0x00005E38
		[Token(Token = "0x6000F61")]
		[Address(RVA = "0x56DFC70", Offset = "0x56DE870", VA = "0x1856DFC70")]
		public static SetIMECursorPositionCommand Create(Vector2 cursorPosition)
		{
			return default(SetIMECursorPositionCommand);
		}

		// Token: 0x0400091B RID: 2331
		[Token(Token = "0x400091B")]
		internal const int kSize = 16;

		// Token: 0x0400091C RID: 2332
		[Token(Token = "0x400091C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InputDeviceCommand baseCommand;

		// Token: 0x0400091D RID: 2333
		[Token(Token = "0x400091D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private Vector2 m_Position;
	}
}
