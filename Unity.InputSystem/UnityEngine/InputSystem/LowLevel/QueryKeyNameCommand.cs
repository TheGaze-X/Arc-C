using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel
{
	// Token: 0x02000178 RID: 376
	[Token(Token = "0x2000178")]
	[StructLayout(2)]
	public struct QueryKeyNameCommand : IInputDeviceCommandInfo
	{
		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06000F46 RID: 3910 RVA: 0x00007A40 File Offset: 0x00005C40
		[Token(Token = "0x17000425")]
		public static FourCC Type
		{
			[Token(Token = "0x6000F46")]
			[Address(RVA = "0x56DF3E0", Offset = "0x56DDFE0", VA = "0x1856DF3E0")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x06000F47 RID: 3911 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000F47")]
		[Address(RVA = "0x56DF3C0", Offset = "0x56DDFC0", VA = "0x1856DF3C0")]
		public string ReadKeyName()
		{
			return null;
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06000F48 RID: 3912 RVA: 0x00007A58 File Offset: 0x00005C58
		[Token(Token = "0x17000426")]
		public FourCC typeStatic
		{
			[Token(Token = "0x6000F48")]
			[Address(RVA = "0x56DF420", Offset = "0x56DE020", VA = "0x1856DF420", Slot = "4")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x06000F49 RID: 3913 RVA: 0x00007A70 File Offset: 0x00005C70
		[Token(Token = "0x6000F49")]
		[Address(RVA = "0x56DF350", Offset = "0x56DDF50", VA = "0x1856DF350")]
		public static QueryKeyNameCommand Create(Key key)
		{
			return default(QueryKeyNameCommand);
		}

		// Token: 0x040008FB RID: 2299
		[Token(Token = "0x40008FB")]
		internal const int kMaxNameLength = 256;

		// Token: 0x040008FC RID: 2300
		[Token(Token = "0x40008FC")]
		internal const int kSize = 268;

		// Token: 0x040008FD RID: 2301
		[Token(Token = "0x40008FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InputDeviceCommand baseCommand;

		// Token: 0x040008FE RID: 2302
		[Token(Token = "0x40008FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int scanOrKeyCode;

		// Token: 0x040008FF RID: 2303
		[Token(Token = "0x40008FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[FixedBuffer(typeof(byte), 256)]
		public QueryKeyNameCommand.<nameBuffer>e__FixedBuffer nameBuffer;

		// Token: 0x02000179 RID: 377
		[Token(Token = "0x2000179")]
		[CompilerGenerated]
		[UnsafeValueType]
		public struct <nameBuffer>e__FixedBuffer
		{
			// Token: 0x04000900 RID: 2304
			[Token(Token = "0x4000900")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public byte FixedElementField;
		}
	}
}
