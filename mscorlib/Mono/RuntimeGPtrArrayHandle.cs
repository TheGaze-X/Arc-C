using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Mono
{
	// Token: 0x02000037 RID: 55
	[Token(Token = "0x2000037")]
	internal struct RuntimeGPtrArrayHandle
	{
		// Token: 0x0600006F RID: 111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x4AB0E00", Offset = "0x4AAFA00", VA = "0x184AB0E00")]
		internal RuntimeGPtrArrayHandle(System.IntPtr ptr)
		{
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000070 RID: 112 RVA: 0x00002358 File Offset: 0x00000558
		[Token(Token = "0x1700000B")]
		internal int Length
		{
			[Token(Token = "0x6000070")]
			[Address(RVA = "0x4AB0FF0", Offset = "0x4AAFBF0", VA = "0x184AB0FF0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700000C RID: 12
		[Token(Token = "0x1700000C")]
		internal System.IntPtr this[int i]
		{
			[Token(Token = "0x6000071")]
			[Address(RVA = "0x4AB0FE0", Offset = "0x4AAFBE0", VA = "0x184AB0FE0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002388 File Offset: 0x00000588
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x4AB0F60", Offset = "0x4AAFB60", VA = "0x184AB0F60")]
		internal System.IntPtr Lookup(int i)
		{
			return 0;
		}

		// Token: 0x06000073 RID: 115
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x4AB0F50", Offset = "0x4AAFB50", VA = "0x184AB0F50")]
		[MethodImpl(4096)]
		private unsafe static extern void GPtrArrayFree(RuntimeStructs.GPtrArray* value);

		// Token: 0x06000074 RID: 116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x4AB0F30", Offset = "0x4AAFB30", VA = "0x184AB0F30")]
		internal static void DestroyAndFree(ref RuntimeGPtrArrayHandle h)
		{
		}

		// Token: 0x04000117 RID: 279
		[Token(Token = "0x4000117")]
		[FieldOffset(Offset = "0x0")]
		private unsafe RuntimeStructs.GPtrArray* value;
	}
}
