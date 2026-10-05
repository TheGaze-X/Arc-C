using System;
using Il2CppDummyDll;

namespace System.Reflection
{
	// Token: 0x02000516 RID: 1302
	[Token(Token = "0x2000516")]
	internal sealed class SignatureByRefType : SignatureHasElementType
	{
		// Token: 0x0600250A RID: 9482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600250A")]
		[Address(RVA = "0x4BE65A0", Offset = "0x4BE51A0", VA = "0x184BE65A0")]
		internal SignatureByRefType(SignatureType elementType)
		{
		}

		// Token: 0x0600250B RID: 9483 RVA: 0x00014C58 File Offset: 0x00012E58
		[Token(Token = "0x600250B")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "32")]
		protected sealed override bool IsArrayImpl()
		{
			return default(bool);
		}

		// Token: 0x0600250C RID: 9484 RVA: 0x00014C70 File Offset: 0x00012E70
		[Token(Token = "0x600250C")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "34")]
		protected sealed override bool IsByRefImpl()
		{
			return default(bool);
		}

		// Token: 0x0600250D RID: 9485 RVA: 0x00014C88 File Offset: 0x00012E88
		[Token(Token = "0x600250D")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "36")]
		protected sealed override bool IsPointerImpl()
		{
			return default(bool);
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x0600250E RID: 9486 RVA: 0x00014CA0 File Offset: 0x00012EA0
		[Token(Token = "0x170004ED")]
		public sealed override bool IsSZArray
		{
			[Token(Token = "0x600250E")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "42")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x0600250F RID: 9487 RVA: 0x00014CB8 File Offset: 0x00012EB8
		[Token(Token = "0x170004EE")]
		public sealed override bool IsVariableBoundArray
		{
			[Token(Token = "0x600250F")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "43")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002510 RID: 9488 RVA: 0x00014CD0 File Offset: 0x00012ED0
		[Token(Token = "0x6002510")]
		[Address(RVA = "0x4BE6540", Offset = "0x4BE5140", VA = "0x184BE6540", Slot = "47")]
		public sealed override int GetArrayRank()
		{
			return 0;
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06002511 RID: 9489 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170004EF")]
		protected sealed override string Suffix
		{
			[Token(Token = "0x6002511")]
			[Address(RVA = "0x4BE6610", Offset = "0x4BE5210", VA = "0x184BE6610", Slot = "137")]
			get
			{
				return null;
			}
		}
	}
}
