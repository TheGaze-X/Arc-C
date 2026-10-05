using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000242 RID: 578
	[Token(Token = "0x2000242")]
	internal struct InheritedData : IStyleDataGroup<InheritedData>, IEquatable<InheritedData>
	{
		// Token: 0x0600109B RID: 4251 RVA: 0x00008FA0 File Offset: 0x000071A0
		[Token(Token = "0x600109B")]
		[Address(RVA = "0x5B1AE50", Offset = "0x5B19A50", VA = "0x185B1AE50", Slot = "4")]
		public InheritedData Copy()
		{
			return default(InheritedData);
		}

		// Token: 0x0600109C RID: 4252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600109C")]
		[Address(RVA = "0x5B1ADC0", Offset = "0x5B199C0", VA = "0x185B1ADC0", Slot = "5")]
		public void CopyFrom(ref InheritedData other)
		{
		}

		// Token: 0x0600109D RID: 4253 RVA: 0x00008FB8 File Offset: 0x000071B8
		[Token(Token = "0x600109D")]
		[Address(RVA = "0x5B1B240", Offset = "0x5B19E40", VA = "0x185B1B240")]
		public static bool operator ==(InheritedData lhs, InheritedData rhs)
		{
			return default(bool);
		}

		// Token: 0x0600109E RID: 4254 RVA: 0x00008FD0 File Offset: 0x000071D0
		[Token(Token = "0x600109E")]
		[Address(RVA = "0x5B1AEA0", Offset = "0x5B19AA0", VA = "0x185B1AEA0", Slot = "6")]
		public bool Equals(InheritedData other)
		{
			return default(bool);
		}

		// Token: 0x0600109F RID: 4255 RVA: 0x00008FE8 File Offset: 0x000071E8
		[Token(Token = "0x600109F")]
		[Address(RVA = "0x5B1AF70", Offset = "0x5B19B70", VA = "0x185B1AF70", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060010A0 RID: 4256 RVA: 0x00009000 File Offset: 0x00007200
		[Token(Token = "0x60010A0")]
		[Address(RVA = "0x5B1B070", Offset = "0x5B19C70", VA = "0x185B1B070", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0400083A RID: 2106
		[Token(Token = "0x400083A")]
		[FieldOffset(Offset = "0x0")]
		public Color color;

		// Token: 0x0400083B RID: 2107
		[Token(Token = "0x400083B")]
		[FieldOffset(Offset = "0x10")]
		public Length fontSize;

		// Token: 0x0400083C RID: 2108
		[Token(Token = "0x400083C")]
		[FieldOffset(Offset = "0x18")]
		public Length letterSpacing;

		// Token: 0x0400083D RID: 2109
		[Token(Token = "0x400083D")]
		[FieldOffset(Offset = "0x20")]
		public TextShadow textShadow;

		// Token: 0x0400083E RID: 2110
		[Token(Token = "0x400083E")]
		[FieldOffset(Offset = "0x40")]
		public Font unityFont;

		// Token: 0x0400083F RID: 2111
		[Token(Token = "0x400083F")]
		[FieldOffset(Offset = "0x48")]
		public FontDefinition unityFontDefinition;

		// Token: 0x04000840 RID: 2112
		[Token(Token = "0x4000840")]
		[FieldOffset(Offset = "0x58")]
		public FontStyle unityFontStyleAndWeight;

		// Token: 0x04000841 RID: 2113
		[Token(Token = "0x4000841")]
		[FieldOffset(Offset = "0x5C")]
		public Length unityParagraphSpacing;

		// Token: 0x04000842 RID: 2114
		[Token(Token = "0x4000842")]
		[FieldOffset(Offset = "0x64")]
		public TextAnchor unityTextAlign;

		// Token: 0x04000843 RID: 2115
		[Token(Token = "0x4000843")]
		[FieldOffset(Offset = "0x68")]
		public Color unityTextOutlineColor;

		// Token: 0x04000844 RID: 2116
		[Token(Token = "0x4000844")]
		[FieldOffset(Offset = "0x78")]
		public float unityTextOutlineWidth;

		// Token: 0x04000845 RID: 2117
		[Token(Token = "0x4000845")]
		[FieldOffset(Offset = "0x7C")]
		public Visibility visibility;

		// Token: 0x04000846 RID: 2118
		[Token(Token = "0x4000846")]
		[FieldOffset(Offset = "0x80")]
		public WhiteSpace whiteSpace;

		// Token: 0x04000847 RID: 2119
		[Token(Token = "0x4000847")]
		[FieldOffset(Offset = "0x84")]
		public Length wordSpacing;
	}
}
