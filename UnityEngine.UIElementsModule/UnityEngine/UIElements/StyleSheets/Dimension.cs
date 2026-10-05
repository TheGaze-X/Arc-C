using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x020002E8 RID: 744
	[Token(Token = "0x20002E8")]
	[Serializable]
	internal struct Dimension : IEquatable<Dimension>
	{
		// Token: 0x06001478 RID: 5240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001478")]
		[Address(RVA = "0x5A7AD00", Offset = "0x5A79900", VA = "0x185A7AD00")]
		public Dimension(float value, Dimension.Unit unit)
		{
		}

		// Token: 0x06001479 RID: 5241 RVA: 0x0000AD40 File Offset: 0x00008F40
		[Token(Token = "0x6001479")]
		[Address(RVA = "0x5A7AAE0", Offset = "0x5A796E0", VA = "0x185A7AAE0")]
		public Length ToLength()
		{
			return default(Length);
		}

		// Token: 0x0600147A RID: 5242 RVA: 0x0000AD58 File Offset: 0x00008F58
		[Token(Token = "0x600147A")]
		[Address(RVA = "0x5A7ACD0", Offset = "0x5A798D0", VA = "0x185A7ACD0")]
		public TimeValue ToTime()
		{
			return default(TimeValue);
		}

		// Token: 0x0600147B RID: 5243 RVA: 0x0000AD70 File Offset: 0x00008F70
		[Token(Token = "0x600147B")]
		[Address(RVA = "0x5A7AA50", Offset = "0x5A79650", VA = "0x185A7AA50")]
		public Angle ToAngle()
		{
			return default(Angle);
		}

		// Token: 0x0600147C RID: 5244 RVA: 0x0000AD88 File Offset: 0x00008F88
		[Token(Token = "0x600147C")]
		[Address(RVA = "0x5A7AD10", Offset = "0x5A79910", VA = "0x185A7AD10")]
		public static bool operator ==(Dimension lhs, Dimension rhs)
		{
			return default(bool);
		}

		// Token: 0x0600147D RID: 5245 RVA: 0x0000ADA0 File Offset: 0x00008FA0
		[Token(Token = "0x600147D")]
		[Address(RVA = "0x5A7A9E0", Offset = "0x5A795E0", VA = "0x185A7A9E0", Slot = "4")]
		public bool Equals(Dimension other)
		{
			return default(bool);
		}

		// Token: 0x0600147E RID: 5246 RVA: 0x0000ADB8 File Offset: 0x00008FB8
		[Token(Token = "0x600147E")]
		[Address(RVA = "0x5A7A920", Offset = "0x5A79520", VA = "0x185A7A920", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600147F RID: 5247 RVA: 0x0000ADD0 File Offset: 0x00008FD0
		[Token(Token = "0x600147F")]
		[Address(RVA = "0x5A7AA10", Offset = "0x5A79610", VA = "0x185A7AA10", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001480 RID: 5248 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6001480")]
		[Address(RVA = "0x5A7AB10", Offset = "0x5A79710", VA = "0x185A7AB10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000C33 RID: 3123
		[Token(Token = "0x4000C33")]
		[FieldOffset(Offset = "0x0")]
		public Dimension.Unit unit;

		// Token: 0x04000C34 RID: 3124
		[Token(Token = "0x4000C34")]
		[FieldOffset(Offset = "0x4")]
		public float value;

		// Token: 0x020002E9 RID: 745
		[Token(Token = "0x20002E9")]
		public enum Unit
		{
			// Token: 0x04000C36 RID: 3126
			[Token(Token = "0x4000C36")]
			Unitless,
			// Token: 0x04000C37 RID: 3127
			[Token(Token = "0x4000C37")]
			Pixel,
			// Token: 0x04000C38 RID: 3128
			[Token(Token = "0x4000C38")]
			Percent,
			// Token: 0x04000C39 RID: 3129
			[Token(Token = "0x4000C39")]
			Second,
			// Token: 0x04000C3A RID: 3130
			[Token(Token = "0x4000C3A")]
			Millisecond,
			// Token: 0x04000C3B RID: 3131
			[Token(Token = "0x4000C3B")]
			Degree,
			// Token: 0x04000C3C RID: 3132
			[Token(Token = "0x4000C3C")]
			Gradian,
			// Token: 0x04000C3D RID: 3133
			[Token(Token = "0x4000C3D")]
			Radian,
			// Token: 0x04000C3E RID: 3134
			[Token(Token = "0x4000C3E")]
			Turn
		}
	}
}
