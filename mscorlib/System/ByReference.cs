using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x0200016F RID: 367
	[Token(Token = "0x200016F")]
	[System.Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
	internal ref struct ByReference<T>
	{
		// Token: 0x06000D89 RID: 3465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D89")]
		[Intrinsic]
		public ByReference(ref T value)
		{
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000D8A RID: 3466 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000125")]
		public ref T Value
		{
			[Token(Token = "0x6000D8A")]
			[Intrinsic]
			get
			{
				return null;
			}
		}

		// Token: 0x040005D1 RID: 1489
		[Token(Token = "0x40005D1")]
		[FieldOffset(Offset = "0x0")]
		private System.IntPtr _value;
	}
}
