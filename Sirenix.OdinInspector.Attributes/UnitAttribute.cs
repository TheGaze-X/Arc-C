using System;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000076 RID: 118
	[Token(Token = "0x2000076")]
	public class UnitAttribute : Attribute
	{
		// Token: 0x06000183 RID: 387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000183")]
		[Address(RVA = "0x4E1C460", Offset = "0x4E1B060", VA = "0x184E1C460")]
		public UnitAttribute(Units unit)
		{
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000184")]
		[Address(RVA = "0x4E1C490", Offset = "0x4E1B090", VA = "0x184E1C490")]
		public UnitAttribute(string unit)
		{
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000185")]
		[Address(RVA = "0x4E1C420", Offset = "0x4E1B020", VA = "0x184E1C420")]
		public UnitAttribute(Units @base, Units display)
		{
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000186")]
		[Address(RVA = "0x4E1C4E0", Offset = "0x4E1B0E0", VA = "0x184E1C4E0")]
		public UnitAttribute(Units @base, string display)
		{
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000187")]
		[Address(RVA = "0x4E1C3D0", Offset = "0x4E1AFD0", VA = "0x184E1C3D0")]
		public UnitAttribute(string @base, Units display)
		{
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000188")]
		[Address(RVA = "0x4E1C370", Offset = "0x4E1AF70", VA = "0x184E1C370")]
		public UnitAttribute(string @base, string display)
		{
		}

		// Token: 0x04000145 RID: 325
		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0x10")]
		public Units Base;

		// Token: 0x04000146 RID: 326
		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0x14")]
		public Units Display;

		// Token: 0x04000147 RID: 327
		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0x18")]
		public string BaseName;

		// Token: 0x04000148 RID: 328
		[Token(Token = "0x4000148")]
		[FieldOffset(Offset = "0x20")]
		public string DisplayName;

		// Token: 0x04000149 RID: 329
		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0x28")]
		public bool DisplayAsString;

		// Token: 0x0400014A RID: 330
		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0x29")]
		public bool ForceDisplayUnit;
	}
}
