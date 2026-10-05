using System;
using Il2CppDummyDll;

namespace Mono
{
	// Token: 0x02000046 RID: 70
	[Token(Token = "0x2000046")]
	internal struct SafeGPtrArrayHandle : System.IDisposable
	{
		// Token: 0x0600007B RID: 123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x4AB0E00", Offset = "0x4AAFA00", VA = "0x184AB0E00")]
		internal SafeGPtrArrayHandle(System.IntPtr ptr)
		{
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x4AB0F30", Offset = "0x4AAFB30", VA = "0x184AB0F30", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600007D RID: 125 RVA: 0x000023E8 File Offset: 0x000005E8
		[Token(Token = "0x1700000D")]
		internal int Length
		{
			[Token(Token = "0x600007D")]
			[Address(RVA = "0x4AB0FF0", Offset = "0x4AAFBF0", VA = "0x184AB0FF0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700000E RID: 14
		[Token(Token = "0x1700000E")]
		internal System.IntPtr this[int i]
		{
			[Token(Token = "0x600007E")]
			[Address(RVA = "0x4AB0FE0", Offset = "0x4AAFBE0", VA = "0x184AB0FE0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x04000141 RID: 321
		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0x0")]
		private RuntimeGPtrArrayHandle handle;
	}
}
