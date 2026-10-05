using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel
{
	// Token: 0x02000176 RID: 374
	[Token(Token = "0x2000176")]
	[StructLayout(2)]
	public struct QueryKeyboardLayoutCommand : IInputDeviceCommandInfo
	{
		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06000F41 RID: 3905 RVA: 0x000079F8 File Offset: 0x00005BF8
		[Token(Token = "0x17000423")]
		public static FourCC Type
		{
			[Token(Token = "0x6000F41")]
			[Address(RVA = "0x56DF510", Offset = "0x56DE110", VA = "0x1856DF510")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x06000F42 RID: 3906 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000F42")]
		[Address(RVA = "0x56DF4C0", Offset = "0x56DE0C0", VA = "0x1856DF4C0")]
		public string ReadLayoutName()
		{
			return null;
		}

		// Token: 0x06000F43 RID: 3907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F43")]
		[Address(RVA = "0x56DF4E0", Offset = "0x56DE0E0", VA = "0x1856DF4E0")]
		public void WriteLayoutName(string name)
		{
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06000F44 RID: 3908 RVA: 0x00007A10 File Offset: 0x00005C10
		[Token(Token = "0x17000424")]
		public FourCC typeStatic
		{
			[Token(Token = "0x6000F44")]
			[Address(RVA = "0x56DF550", Offset = "0x56DE150", VA = "0x1856DF550", Slot = "4")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x06000F45 RID: 3909 RVA: 0x00007A28 File Offset: 0x00005C28
		[Token(Token = "0x6000F45")]
		[Address(RVA = "0x56DF460", Offset = "0x56DE060", VA = "0x1856DF460")]
		public static QueryKeyboardLayoutCommand Create()
		{
			return default(QueryKeyboardLayoutCommand);
		}

		// Token: 0x040008F7 RID: 2295
		[Token(Token = "0x40008F7")]
		internal const int kMaxNameLength = 256;

		// Token: 0x040008F8 RID: 2296
		[Token(Token = "0x40008F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InputDeviceCommand baseCommand;

		// Token: 0x040008F9 RID: 2297
		[Token(Token = "0x40008F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[FixedBuffer(typeof(byte), 256)]
		public QueryKeyboardLayoutCommand.<nameBuffer>e__FixedBuffer nameBuffer;

		// Token: 0x02000177 RID: 375
		[Token(Token = "0x2000177")]
		[CompilerGenerated]
		[UnsafeValueType]
		public struct <nameBuffer>e__FixedBuffer
		{
			// Token: 0x040008FA RID: 2298
			[Token(Token = "0x40008FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public byte FixedElementField;
		}
	}
}
