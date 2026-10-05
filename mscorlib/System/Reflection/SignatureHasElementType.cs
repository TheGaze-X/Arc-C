using System;
using Il2CppDummyDll;

namespace System.Reflection
{
	// Token: 0x02000518 RID: 1304
	[Token(Token = "0x2000518")]
	internal abstract class SignatureHasElementType : SignatureType
	{
		// Token: 0x06002527 RID: 9511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002527")]
		[Address(RVA = "0x4BE65A0", Offset = "0x4BE51A0", VA = "0x184BE65A0")]
		protected SignatureHasElementType(SignatureType elementType)
		{
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06002528 RID: 9512 RVA: 0x00014E20 File Offset: 0x00013020
		[Token(Token = "0x170004FC")]
		public sealed override bool IsGenericTypeDefinition
		{
			[Token(Token = "0x6002528")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "41")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002529 RID: 9513 RVA: 0x00014E38 File Offset: 0x00013038
		[Token(Token = "0x6002529")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "45")]
		protected sealed override bool HasElementTypeImpl()
		{
			return default(bool);
		}

		// Token: 0x0600252A RID: 9514
		[Token(Token = "0x600252A")]
		protected abstract override bool IsArrayImpl();

		// Token: 0x0600252B RID: 9515
		[Token(Token = "0x600252B")]
		protected abstract override bool IsByRefImpl();

		// Token: 0x0600252C RID: 9516
		[Token(Token = "0x600252C")]
		protected abstract override bool IsPointerImpl();

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x0600252D RID: 9517
		[Token(Token = "0x170004FD")]
		public abstract override bool IsSZArray { [Token(Token = "0x600252D")] get; }

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x0600252E RID: 9518
		[Token(Token = "0x170004FE")]
		public abstract override bool IsVariableBoundArray { [Token(Token = "0x600252E")] get; }

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x0600252F RID: 9519 RVA: 0x00014E50 File Offset: 0x00013050
		[Token(Token = "0x170004FF")]
		public sealed override bool IsConstructedGenericType
		{
			[Token(Token = "0x600252F")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "37")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06002530 RID: 9520 RVA: 0x00014E68 File Offset: 0x00013068
		[Token(Token = "0x17000500")]
		public sealed override bool IsGenericParameter
		{
			[Token(Token = "0x6002530")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "38")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06002531 RID: 9521 RVA: 0x00014E80 File Offset: 0x00013080
		[Token(Token = "0x17000501")]
		public sealed override bool IsGenericMethodParameter
		{
			[Token(Token = "0x6002531")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "39")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06002532 RID: 9522 RVA: 0x00014E98 File Offset: 0x00013098
		[Token(Token = "0x17000502")]
		public sealed override bool ContainsGenericParameters
		{
			[Token(Token = "0x6002532")]
			[Address(RVA = "0x4BE6DD0", Offset = "0x4BE59D0", VA = "0x184BE6DD0", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x06002533 RID: 9523 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000503")]
		internal sealed override SignatureType ElementType
		{
			[Token(Token = "0x6002533")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "136")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002534 RID: 9524
		[Token(Token = "0x6002534")]
		public abstract override int GetArrayRank();

		// Token: 0x06002535 RID: 9525 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002535")]
		[Address(RVA = "0x4BE6CE0", Offset = "0x4BE58E0", VA = "0x184BE6CE0", Slot = "48")]
		public sealed override System.Type GetGenericTypeDefinition()
		{
			return null;
		}

		// Token: 0x06002536 RID: 9526 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002536")]
		[Address(RVA = "0x4BE6CB0", Offset = "0x4BE58B0", VA = "0x184BE6CB0", Slot = "50")]
		public sealed override System.Type[] GetGenericArguments()
		{
			return null;
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06002537 RID: 9527 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000504")]
		public sealed override System.Type[] GenericTypeArguments
		{
			[Token(Token = "0x6002537")]
			[Address(RVA = "0x4BE6E80", Offset = "0x4BE5A80", VA = "0x184BE6E80", Slot = "49")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06002538 RID: 9528 RVA: 0x00014EB0 File Offset: 0x000130B0
		[Token(Token = "0x17000505")]
		public sealed override int GenericParameterPosition
		{
			[Token(Token = "0x6002538")]
			[Address(RVA = "0x4BE6E20", Offset = "0x4BE5A20", VA = "0x184BE6E20", Slot = "51")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06002539 RID: 9529 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000506")]
		public sealed override string Name
		{
			[Token(Token = "0x6002539")]
			[Address(RVA = "0x4BE6EB0", Offset = "0x4BE5AB0", VA = "0x184BE6EB0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x0600253A RID: 9530 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000507")]
		public sealed override string Namespace
		{
			[Token(Token = "0x600253A")]
			[Address(RVA = "0x1F1AB40", Offset = "0x1F19740", VA = "0x181F1AB40", Slot = "24")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600253B RID: 9531 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600253B")]
		[Address(RVA = "0x4BE6D40", Offset = "0x4BE5940", VA = "0x184BE6D40", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x0600253C RID: 9532
		[Token(Token = "0x17000508")]
		protected abstract string Suffix { [Token(Token = "0x600253C")] get; }

		// Token: 0x0400154D RID: 5453
		[Token(Token = "0x400154D")]
		[FieldOffset(Offset = "0x18")]
		private readonly SignatureType _elementType;
	}
}
