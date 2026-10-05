using System;
using Il2CppDummyDll;

namespace System.Reflection
{
	// Token: 0x02000519 RID: 1305
	[Token(Token = "0x2000519")]
	internal sealed class SignaturePointerType : SignatureHasElementType
	{
		// Token: 0x0600253D RID: 9533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600253D")]
		[Address(RVA = "0x4BE65A0", Offset = "0x4BE51A0", VA = "0x184BE65A0")]
		internal SignaturePointerType(SignatureType elementType)
		{
		}

		// Token: 0x0600253E RID: 9534 RVA: 0x00014EC8 File Offset: 0x000130C8
		[Token(Token = "0x600253E")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "32")]
		protected sealed override bool IsArrayImpl()
		{
			return default(bool);
		}

		// Token: 0x0600253F RID: 9535 RVA: 0x00014EE0 File Offset: 0x000130E0
		[Token(Token = "0x600253F")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "34")]
		protected sealed override bool IsByRefImpl()
		{
			return default(bool);
		}

		// Token: 0x06002540 RID: 9536 RVA: 0x00014EF8 File Offset: 0x000130F8
		[Token(Token = "0x6002540")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "36")]
		protected sealed override bool IsPointerImpl()
		{
			return default(bool);
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06002541 RID: 9537 RVA: 0x00014F10 File Offset: 0x00013110
		[Token(Token = "0x17000509")]
		public sealed override bool IsSZArray
		{
			[Token(Token = "0x6002541")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "42")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06002542 RID: 9538 RVA: 0x00014F28 File Offset: 0x00013128
		[Token(Token = "0x1700050A")]
		public sealed override bool IsVariableBoundArray
		{
			[Token(Token = "0x6002542")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "43")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002543 RID: 9539 RVA: 0x00014F40 File Offset: 0x00013140
		[Token(Token = "0x6002543")]
		[Address(RVA = "0x4BE6F40", Offset = "0x4BE5B40", VA = "0x184BE6F40", Slot = "47")]
		public sealed override int GetArrayRank()
		{
			return 0;
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06002544 RID: 9540 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700050B")]
		protected sealed override string Suffix
		{
			[Token(Token = "0x6002544")]
			[Address(RVA = "0x4BE6FA0", Offset = "0x4BE5BA0", VA = "0x184BE6FA0", Slot = "137")]
			get
			{
				return null;
			}
		}
	}
}
