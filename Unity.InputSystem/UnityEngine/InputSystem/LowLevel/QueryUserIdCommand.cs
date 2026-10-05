using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel
{
	// Token: 0x0200017F RID: 383
	[Token(Token = "0x200017F")]
	[StructLayout(2)]
	internal struct QueryUserIdCommand : IInputDeviceCommandInfo
	{
		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06000F54 RID: 3924 RVA: 0x00007B18 File Offset: 0x00005D18
		[Token(Token = "0x1700042D")]
		public static FourCC Type
		{
			[Token(Token = "0x6000F54")]
			[Address(RVA = "0x56DFA50", Offset = "0x56DE650", VA = "0x1856DFA50")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x06000F55 RID: 3925 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000F55")]
		[Address(RVA = "0x56DF4C0", Offset = "0x56DE0C0", VA = "0x1856DF4C0")]
		public string ReadId()
		{
			return null;
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06000F56 RID: 3926 RVA: 0x00007B30 File Offset: 0x00005D30
		[Token(Token = "0x1700042E")]
		public FourCC typeStatic
		{
			[Token(Token = "0x6000F56")]
			[Address(RVA = "0x56DFA90", Offset = "0x56DE690", VA = "0x1856DFA90", Slot = "4")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x00007B48 File Offset: 0x00005D48
		[Token(Token = "0x6000F57")]
		[Address(RVA = "0x56DF9F0", Offset = "0x56DE5F0", VA = "0x1856DF9F0")]
		public static QueryUserIdCommand Create()
		{
			return default(QueryUserIdCommand);
		}

		// Token: 0x04000912 RID: 2322
		[Token(Token = "0x4000912")]
		public const int kMaxIdLength = 256;

		// Token: 0x04000913 RID: 2323
		[Token(Token = "0x4000913")]
		internal const int kSize = 520;

		// Token: 0x04000914 RID: 2324
		[Token(Token = "0x4000914")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InputDeviceCommand baseCommand;

		// Token: 0x04000915 RID: 2325
		[Token(Token = "0x4000915")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[FixedBuffer(typeof(byte), 512)]
		public QueryUserIdCommand.<idBuffer>e__FixedBuffer idBuffer;

		// Token: 0x02000180 RID: 384
		[Token(Token = "0x2000180")]
		[UnsafeValueType]
		[CompilerGenerated]
		public struct <idBuffer>e__FixedBuffer
		{
			// Token: 0x04000916 RID: 2326
			[Token(Token = "0x4000916")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public byte FixedElementField;
		}
	}
}
