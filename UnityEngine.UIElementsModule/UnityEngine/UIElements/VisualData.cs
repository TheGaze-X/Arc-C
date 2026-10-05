using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000247 RID: 583
	[Token(Token = "0x2000247")]
	internal struct VisualData : IStyleDataGroup<VisualData>, IEquatable<VisualData>
	{
		// Token: 0x060010B9 RID: 4281 RVA: 0x000091F8 File Offset: 0x000073F8
		[Token(Token = "0x60010B9")]
		[Address(RVA = "0x5B2EA90", Offset = "0x5B2D690", VA = "0x185B2EA90", Slot = "4")]
		public VisualData Copy()
		{
			return default(VisualData);
		}

		// Token: 0x060010BA RID: 4282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010BA")]
		[Address(RVA = "0x5B2E9F0", Offset = "0x5B2D5F0", VA = "0x185B2E9F0", Slot = "5")]
		public void CopyFrom(ref VisualData other)
		{
		}

		// Token: 0x060010BB RID: 4283 RVA: 0x00009210 File Offset: 0x00007410
		[Token(Token = "0x60010BB")]
		[Address(RVA = "0x5B2EE50", Offset = "0x5B2DA50", VA = "0x185B2EE50")]
		public static bool operator ==(VisualData lhs, VisualData rhs)
		{
			return default(bool);
		}

		// Token: 0x060010BC RID: 4284 RVA: 0x00009228 File Offset: 0x00007428
		[Token(Token = "0x60010BC")]
		[Address(RVA = "0x5B2EAF0", Offset = "0x5B2D6F0", VA = "0x185B2EAF0", Slot = "6")]
		public bool Equals(VisualData other)
		{
			return default(bool);
		}

		// Token: 0x060010BD RID: 4285 RVA: 0x00009240 File Offset: 0x00007440
		[Token(Token = "0x60010BD")]
		[Address(RVA = "0x5B2EBE0", Offset = "0x5B2D7E0", VA = "0x185B2EBE0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060010BE RID: 4286 RVA: 0x00009258 File Offset: 0x00007458
		[Token(Token = "0x60010BE")]
		[Address(RVA = "0x5B2ED00", Offset = "0x5B2D900", VA = "0x185B2ED00", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0400087B RID: 2171
		[Token(Token = "0x400087B")]
		[FieldOffset(Offset = "0x0")]
		public Color backgroundColor;

		// Token: 0x0400087C RID: 2172
		[Token(Token = "0x400087C")]
		[FieldOffset(Offset = "0x10")]
		public Background backgroundImage;

		// Token: 0x0400087D RID: 2173
		[Token(Token = "0x400087D")]
		[FieldOffset(Offset = "0x30")]
		public Color borderBottomColor;

		// Token: 0x0400087E RID: 2174
		[Token(Token = "0x400087E")]
		[FieldOffset(Offset = "0x40")]
		public Length borderBottomLeftRadius;

		// Token: 0x0400087F RID: 2175
		[Token(Token = "0x400087F")]
		[FieldOffset(Offset = "0x48")]
		public Length borderBottomRightRadius;

		// Token: 0x04000880 RID: 2176
		[Token(Token = "0x4000880")]
		[FieldOffset(Offset = "0x50")]
		public Color borderLeftColor;

		// Token: 0x04000881 RID: 2177
		[Token(Token = "0x4000881")]
		[FieldOffset(Offset = "0x60")]
		public Color borderRightColor;

		// Token: 0x04000882 RID: 2178
		[Token(Token = "0x4000882")]
		[FieldOffset(Offset = "0x70")]
		public Color borderTopColor;

		// Token: 0x04000883 RID: 2179
		[Token(Token = "0x4000883")]
		[FieldOffset(Offset = "0x80")]
		public Length borderTopLeftRadius;

		// Token: 0x04000884 RID: 2180
		[Token(Token = "0x4000884")]
		[FieldOffset(Offset = "0x88")]
		public Length borderTopRightRadius;

		// Token: 0x04000885 RID: 2181
		[Token(Token = "0x4000885")]
		[FieldOffset(Offset = "0x90")]
		public float opacity;

		// Token: 0x04000886 RID: 2182
		[Token(Token = "0x4000886")]
		[FieldOffset(Offset = "0x94")]
		public OverflowInternal overflow;
	}
}
