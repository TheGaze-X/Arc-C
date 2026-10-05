using System;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.Utilities
{
	// Token: 0x02000255 RID: 597
	[Token(Token = "0x2000255")]
	internal struct PredictiveParser
	{
		// Token: 0x06001570 RID: 5488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001570")]
		[Address(RVA = "0x5612C40", Offset = "0x5611840", VA = "0x185612C40")]
		public void ExpectSingleChar(ReadOnlySpan<char> str, char c)
		{
		}

		// Token: 0x06001571 RID: 5489 RVA: 0x0000B5F8 File Offset: 0x000097F8
		[Token(Token = "0x6001571")]
		[Address(RVA = "0x5612AE0", Offset = "0x56116E0", VA = "0x185612AE0")]
		public int ExpectInt(ReadOnlySpan<char> str)
		{
			return 0;
		}

		// Token: 0x06001572 RID: 5490 RVA: 0x0000B610 File Offset: 0x00009810
		[Token(Token = "0x6001572")]
		[Address(RVA = "0x5612D60", Offset = "0x5611960", VA = "0x185612D60")]
		public ReadOnlySpan<char> ExpectString(ReadOnlySpan<char> str)
		{
			return default(ReadOnlySpan<char>);
		}

		// Token: 0x06001573 RID: 5491 RVA: 0x0000B628 File Offset: 0x00009828
		[Token(Token = "0x6001573")]
		[Address(RVA = "0x5612930", Offset = "0x5611530", VA = "0x185612930")]
		public bool AcceptSingleChar(ReadOnlySpan<char> str, char c)
		{
			return default(bool);
		}

		// Token: 0x06001574 RID: 5492 RVA: 0x0000B640 File Offset: 0x00009840
		[Token(Token = "0x6001574")]
		[Address(RVA = "0x5612970", Offset = "0x5611570", VA = "0x185612970")]
		public bool AcceptString(ReadOnlySpan<char> input, out ReadOnlySpan<char> output)
		{
			return default(bool);
		}

		// Token: 0x06001575 RID: 5493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001575")]
		[Address(RVA = "0x56128D0", Offset = "0x56114D0", VA = "0x1856128D0")]
		public void AcceptInt(ReadOnlySpan<char> str)
		{
		}

		// Token: 0x04000C52 RID: 3154
		[Token(Token = "0x4000C52")]
		[FieldOffset(Offset = "0x0")]
		private int m_Position;
	}
}
