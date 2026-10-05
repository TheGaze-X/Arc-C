using System;
using Il2CppDummyDll;

namespace System.Reflection
{
	// Token: 0x02000515 RID: 1301
	[Token(Token = "0x2000515")]
	internal sealed class SignatureArrayType : SignatureHasElementType
	{
		// Token: 0x06002502 RID: 9474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002502")]
		[Address(RVA = "0x4BE63F0", Offset = "0x4BE4FF0", VA = "0x184BE63F0")]
		internal SignatureArrayType(SignatureType elementType, int rank, bool isMultiDim)
		{
		}

		// Token: 0x06002503 RID: 9475 RVA: 0x00014BC8 File Offset: 0x00012DC8
		[Token(Token = "0x6002503")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "32")]
		protected sealed override bool IsArrayImpl()
		{
			return default(bool);
		}

		// Token: 0x06002504 RID: 9476 RVA: 0x00014BE0 File Offset: 0x00012DE0
		[Token(Token = "0x6002504")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "34")]
		protected sealed override bool IsByRefImpl()
		{
			return default(bool);
		}

		// Token: 0x06002505 RID: 9477 RVA: 0x00014BF8 File Offset: 0x00012DF8
		[Token(Token = "0x6002505")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "36")]
		protected sealed override bool IsPointerImpl()
		{
			return default(bool);
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06002506 RID: 9478 RVA: 0x00014C10 File Offset: 0x00012E10
		[Token(Token = "0x170004EA")]
		public sealed override bool IsSZArray
		{
			[Token(Token = "0x6002506")]
			[Address(RVA = "0x4BE6480", Offset = "0x4BE5080", VA = "0x184BE6480", Slot = "42")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06002507 RID: 9479 RVA: 0x00014C28 File Offset: 0x00012E28
		[Token(Token = "0x170004EB")]
		public sealed override bool IsVariableBoundArray
		{
			[Token(Token = "0x6002507")]
			[Address(RVA = "0x4EA840", Offset = "0x4E9440", VA = "0x1804EA840", Slot = "43")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002508 RID: 9480 RVA: 0x00014C40 File Offset: 0x00012E40
		[Token(Token = "0x6002508")]
		[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890", Slot = "47")]
		public sealed override int GetArrayRank()
		{
			return 0;
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06002509 RID: 9481 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170004EC")]
		protected sealed override string Suffix
		{
			[Token(Token = "0x6002509")]
			[Address(RVA = "0x4BE6490", Offset = "0x4BE5090", VA = "0x184BE6490", Slot = "137")]
			get
			{
				return null;
			}
		}

		// Token: 0x04001549 RID: 5449
		[Token(Token = "0x4001549")]
		[FieldOffset(Offset = "0x20")]
		private readonly int _rank;

		// Token: 0x0400154A RID: 5450
		[Token(Token = "0x400154A")]
		[FieldOffset(Offset = "0x24")]
		private readonly bool _isMultiDim;
	}
}
