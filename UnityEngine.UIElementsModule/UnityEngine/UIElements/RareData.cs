using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000244 RID: 580
	[Token(Token = "0x2000244")]
	internal struct RareData : IStyleDataGroup<RareData>, IEquatable<RareData>
	{
		// Token: 0x060010A7 RID: 4263 RVA: 0x00009090 File Offset: 0x00007290
		[Token(Token = "0x60010A7")]
		[Address(RVA = "0x5B1F460", Offset = "0x5B1E060", VA = "0x185B1F460", Slot = "4")]
		public RareData Copy()
		{
			return default(RareData);
		}

		// Token: 0x060010A8 RID: 4264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010A8")]
		[Address(RVA = "0x5B1F430", Offset = "0x5B1E030", VA = "0x185B1F430", Slot = "5")]
		public void CopyFrom(ref RareData other)
		{
		}

		// Token: 0x060010A9 RID: 4265 RVA: 0x000090A8 File Offset: 0x000072A8
		[Token(Token = "0x60010A9")]
		[Address(RVA = "0x5B1F790", Offset = "0x5B1E390", VA = "0x185B1F790")]
		public static bool operator ==(RareData lhs, RareData rhs)
		{
			return default(bool);
		}

		// Token: 0x060010AA RID: 4266 RVA: 0x000090C0 File Offset: 0x000072C0
		[Token(Token = "0x60010AA")]
		[Address(RVA = "0x5B1F550", Offset = "0x5B1E150", VA = "0x185B1F550", Slot = "6")]
		public bool Equals(RareData other)
		{
			return default(bool);
		}

		// Token: 0x060010AB RID: 4267 RVA: 0x000090D8 File Offset: 0x000072D8
		[Token(Token = "0x60010AB")]
		[Address(RVA = "0x5B1F490", Offset = "0x5B1E090", VA = "0x185B1F490", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060010AC RID: 4268 RVA: 0x000090F0 File Offset: 0x000072F0
		[Token(Token = "0x60010AC")]
		[Address(RVA = "0x5B1F710", Offset = "0x5B1E310", VA = "0x185B1F710", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000869 RID: 2153
		[Token(Token = "0x4000869")]
		[FieldOffset(Offset = "0x0")]
		public Cursor cursor;

		// Token: 0x0400086A RID: 2154
		[Token(Token = "0x400086A")]
		[FieldOffset(Offset = "0x18")]
		public TextOverflow textOverflow;

		// Token: 0x0400086B RID: 2155
		[Token(Token = "0x400086B")]
		[FieldOffset(Offset = "0x1C")]
		public Color unityBackgroundImageTintColor;

		// Token: 0x0400086C RID: 2156
		[Token(Token = "0x400086C")]
		[FieldOffset(Offset = "0x2C")]
		public ScaleMode unityBackgroundScaleMode;

		// Token: 0x0400086D RID: 2157
		[Token(Token = "0x400086D")]
		[FieldOffset(Offset = "0x30")]
		public OverflowClipBox unityOverflowClipBox;

		// Token: 0x0400086E RID: 2158
		[Token(Token = "0x400086E")]
		[FieldOffset(Offset = "0x34")]
		public int unitySliceBottom;

		// Token: 0x0400086F RID: 2159
		[Token(Token = "0x400086F")]
		[FieldOffset(Offset = "0x38")]
		public int unitySliceLeft;

		// Token: 0x04000870 RID: 2160
		[Token(Token = "0x4000870")]
		[FieldOffset(Offset = "0x3C")]
		public int unitySliceRight;

		// Token: 0x04000871 RID: 2161
		[Token(Token = "0x4000871")]
		[FieldOffset(Offset = "0x40")]
		public int unitySliceTop;

		// Token: 0x04000872 RID: 2162
		[Token(Token = "0x4000872")]
		[FieldOffset(Offset = "0x44")]
		public TextOverflowPosition unityTextOverflowPosition;
	}
}
