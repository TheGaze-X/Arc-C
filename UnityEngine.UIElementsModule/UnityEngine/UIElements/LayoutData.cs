using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000243 RID: 579
	[Token(Token = "0x2000243")]
	internal struct LayoutData : IStyleDataGroup<LayoutData>, IEquatable<LayoutData>
	{
		// Token: 0x060010A1 RID: 4257 RVA: 0x00009018 File Offset: 0x00007218
		[Token(Token = "0x60010A1")]
		[Address(RVA = "0x5B1B8D0", Offset = "0x5B1A4D0", VA = "0x185B1B8D0", Slot = "4")]
		public LayoutData Copy()
		{
			return default(LayoutData);
		}

		// Token: 0x060010A2 RID: 4258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010A2")]
		[Address(RVA = "0x5B1B7C0", Offset = "0x5B1A3C0", VA = "0x185B1B7C0", Slot = "5")]
		public void CopyFrom(ref LayoutData other)
		{
		}

		// Token: 0x060010A3 RID: 4259 RVA: 0x00009030 File Offset: 0x00007230
		[Token(Token = "0x60010A3")]
		[Address(RVA = "0x5B1BF40", Offset = "0x5B1AB40", VA = "0x185B1BF40")]
		public static bool operator ==(LayoutData lhs, LayoutData rhs)
		{
			return default(bool);
		}

		// Token: 0x060010A4 RID: 4260 RVA: 0x00009048 File Offset: 0x00007248
		[Token(Token = "0x60010A4")]
		[Address(RVA = "0x5B1BA80", Offset = "0x5B1A680", VA = "0x185B1BA80", Slot = "6")]
		public bool Equals(LayoutData other)
		{
			return default(bool);
		}

		// Token: 0x060010A5 RID: 4261 RVA: 0x00009060 File Offset: 0x00007260
		[Token(Token = "0x60010A5")]
		[Address(RVA = "0x5B1B950", Offset = "0x5B1A550", VA = "0x185B1B950", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060010A6 RID: 4262 RVA: 0x00009078 File Offset: 0x00007278
		[Token(Token = "0x60010A6")]
		[Address(RVA = "0x5B1BBB0", Offset = "0x5B1A7B0", VA = "0x185B1BBB0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000848 RID: 2120
		[Token(Token = "0x4000848")]
		[FieldOffset(Offset = "0x0")]
		public Align alignContent;

		// Token: 0x04000849 RID: 2121
		[Token(Token = "0x4000849")]
		[FieldOffset(Offset = "0x4")]
		public Align alignItems;

		// Token: 0x0400084A RID: 2122
		[Token(Token = "0x400084A")]
		[FieldOffset(Offset = "0x8")]
		public Align alignSelf;

		// Token: 0x0400084B RID: 2123
		[Token(Token = "0x400084B")]
		[FieldOffset(Offset = "0xC")]
		public float borderBottomWidth;

		// Token: 0x0400084C RID: 2124
		[Token(Token = "0x400084C")]
		[FieldOffset(Offset = "0x10")]
		public float borderLeftWidth;

		// Token: 0x0400084D RID: 2125
		[Token(Token = "0x400084D")]
		[FieldOffset(Offset = "0x14")]
		public float borderRightWidth;

		// Token: 0x0400084E RID: 2126
		[Token(Token = "0x400084E")]
		[FieldOffset(Offset = "0x18")]
		public float borderTopWidth;

		// Token: 0x0400084F RID: 2127
		[Token(Token = "0x400084F")]
		[FieldOffset(Offset = "0x1C")]
		public Length bottom;

		// Token: 0x04000850 RID: 2128
		[Token(Token = "0x4000850")]
		[FieldOffset(Offset = "0x24")]
		public DisplayStyle display;

		// Token: 0x04000851 RID: 2129
		[Token(Token = "0x4000851")]
		[FieldOffset(Offset = "0x28")]
		public Length flexBasis;

		// Token: 0x04000852 RID: 2130
		[Token(Token = "0x4000852")]
		[FieldOffset(Offset = "0x30")]
		public FlexDirection flexDirection;

		// Token: 0x04000853 RID: 2131
		[Token(Token = "0x4000853")]
		[FieldOffset(Offset = "0x34")]
		public float flexGrow;

		// Token: 0x04000854 RID: 2132
		[Token(Token = "0x4000854")]
		[FieldOffset(Offset = "0x38")]
		public float flexShrink;

		// Token: 0x04000855 RID: 2133
		[Token(Token = "0x4000855")]
		[FieldOffset(Offset = "0x3C")]
		public Wrap flexWrap;

		// Token: 0x04000856 RID: 2134
		[Token(Token = "0x4000856")]
		[FieldOffset(Offset = "0x40")]
		public Length height;

		// Token: 0x04000857 RID: 2135
		[Token(Token = "0x4000857")]
		[FieldOffset(Offset = "0x48")]
		public Justify justifyContent;

		// Token: 0x04000858 RID: 2136
		[Token(Token = "0x4000858")]
		[FieldOffset(Offset = "0x4C")]
		public Length left;

		// Token: 0x04000859 RID: 2137
		[Token(Token = "0x4000859")]
		[FieldOffset(Offset = "0x54")]
		public Length marginBottom;

		// Token: 0x0400085A RID: 2138
		[Token(Token = "0x400085A")]
		[FieldOffset(Offset = "0x5C")]
		public Length marginLeft;

		// Token: 0x0400085B RID: 2139
		[Token(Token = "0x400085B")]
		[FieldOffset(Offset = "0x64")]
		public Length marginRight;

		// Token: 0x0400085C RID: 2140
		[Token(Token = "0x400085C")]
		[FieldOffset(Offset = "0x6C")]
		public Length marginTop;

		// Token: 0x0400085D RID: 2141
		[Token(Token = "0x400085D")]
		[FieldOffset(Offset = "0x74")]
		public Length maxHeight;

		// Token: 0x0400085E RID: 2142
		[Token(Token = "0x400085E")]
		[FieldOffset(Offset = "0x7C")]
		public Length maxWidth;

		// Token: 0x0400085F RID: 2143
		[Token(Token = "0x400085F")]
		[FieldOffset(Offset = "0x84")]
		public Length minHeight;

		// Token: 0x04000860 RID: 2144
		[Token(Token = "0x4000860")]
		[FieldOffset(Offset = "0x8C")]
		public Length minWidth;

		// Token: 0x04000861 RID: 2145
		[Token(Token = "0x4000861")]
		[FieldOffset(Offset = "0x94")]
		public Length paddingBottom;

		// Token: 0x04000862 RID: 2146
		[Token(Token = "0x4000862")]
		[FieldOffset(Offset = "0x9C")]
		public Length paddingLeft;

		// Token: 0x04000863 RID: 2147
		[Token(Token = "0x4000863")]
		[FieldOffset(Offset = "0xA4")]
		public Length paddingRight;

		// Token: 0x04000864 RID: 2148
		[Token(Token = "0x4000864")]
		[FieldOffset(Offset = "0xAC")]
		public Length paddingTop;

		// Token: 0x04000865 RID: 2149
		[Token(Token = "0x4000865")]
		[FieldOffset(Offset = "0xB4")]
		public Position position;

		// Token: 0x04000866 RID: 2150
		[Token(Token = "0x4000866")]
		[FieldOffset(Offset = "0xB8")]
		public Length right;

		// Token: 0x04000867 RID: 2151
		[Token(Token = "0x4000867")]
		[FieldOffset(Offset = "0xC0")]
		public Length top;

		// Token: 0x04000868 RID: 2152
		[Token(Token = "0x4000868")]
		[FieldOffset(Offset = "0xC8")]
		public Length width;
	}
}
