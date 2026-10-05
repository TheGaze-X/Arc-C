using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000245 RID: 581
	[Token(Token = "0x2000245")]
	internal struct TransformData : IStyleDataGroup<TransformData>, IEquatable<TransformData>
	{
		// Token: 0x060010AD RID: 4269 RVA: 0x00009108 File Offset: 0x00007308
		[Token(Token = "0x60010AD")]
		[Address(RVA = "0x5B298C0", Offset = "0x5B284C0", VA = "0x185B298C0", Slot = "4")]
		public TransformData Copy()
		{
			return default(TransformData);
		}

		// Token: 0x060010AE RID: 4270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010AE")]
		[Address(RVA = "0x5B29890", Offset = "0x5B28490", VA = "0x185B29890", Slot = "5")]
		public void CopyFrom(ref TransformData other)
		{
		}

		// Token: 0x060010AF RID: 4271 RVA: 0x00009120 File Offset: 0x00007320
		[Token(Token = "0x60010AF")]
		[Address(RVA = "0x5B29BF0", Offset = "0x5B287F0", VA = "0x185B29BF0")]
		public static bool operator ==(TransformData lhs, TransformData rhs)
		{
			return default(bool);
		}

		// Token: 0x060010B0 RID: 4272 RVA: 0x00009138 File Offset: 0x00007338
		[Token(Token = "0x60010B0")]
		[Address(RVA = "0x5B298F0", Offset = "0x5B284F0", VA = "0x185B298F0", Slot = "6")]
		public bool Equals(TransformData other)
		{
			return default(bool);
		}

		// Token: 0x060010B1 RID: 4273 RVA: 0x00009150 File Offset: 0x00007350
		[Token(Token = "0x60010B1")]
		[Address(RVA = "0x5B29980", Offset = "0x5B28580", VA = "0x185B29980", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060010B2 RID: 4274 RVA: 0x00009168 File Offset: 0x00007368
		[Token(Token = "0x60010B2")]
		[Address(RVA = "0x5B29AB0", Offset = "0x5B286B0", VA = "0x185B29AB0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000873 RID: 2163
		[Token(Token = "0x4000873")]
		[FieldOffset(Offset = "0x0")]
		public Rotate rotate;

		// Token: 0x04000874 RID: 2164
		[Token(Token = "0x4000874")]
		[FieldOffset(Offset = "0x18")]
		public Scale scale;

		// Token: 0x04000875 RID: 2165
		[Token(Token = "0x4000875")]
		[FieldOffset(Offset = "0x28")]
		public TransformOrigin transformOrigin;

		// Token: 0x04000876 RID: 2166
		[Token(Token = "0x4000876")]
		[FieldOffset(Offset = "0x3C")]
		public Translate translate;
	}
}
