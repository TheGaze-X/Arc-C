using System;
using Il2CppDummyDll;

namespace System.Globalization
{
	// Token: 0x0200059A RID: 1434
	[Token(Token = "0x200059A")]
	internal class Bootstring
	{
		// Token: 0x06002B1E RID: 11038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B1E")]
		[Address(RVA = "0x4C45B90", Offset = "0x4C44790", VA = "0x184C45B90")]
		public Bootstring(char delimiter, int baseNum, int tmin, int tmax, int skew, int damp, int initialBias, int initialN)
		{
		}

		// Token: 0x06002B1F RID: 11039 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002B1F")]
		[Address(RVA = "0x4C457B0", Offset = "0x4C443B0", VA = "0x184C457B0")]
		public string Encode(string s, int offset)
		{
			return null;
		}

		// Token: 0x06002B20 RID: 11040 RVA: 0x00017E98 File Offset: 0x00016098
		[Token(Token = "0x6002B20")]
		[Address(RVA = "0x4C45790", Offset = "0x4C44390", VA = "0x184C45790")]
		private char EncodeDigit(int d)
		{
			return '\0';
		}

		// Token: 0x06002B21 RID: 11041 RVA: 0x00017EB0 File Offset: 0x000160B0
		[Token(Token = "0x6002B21")]
		[Address(RVA = "0x4C454A0", Offset = "0x4C440A0", VA = "0x184C454A0")]
		private int DecodeDigit(char c)
		{
			return 0;
		}

		// Token: 0x06002B22 RID: 11042 RVA: 0x00017EC8 File Offset: 0x000160C8
		[Token(Token = "0x6002B22")]
		[Address(RVA = "0x4C45420", Offset = "0x4C44020", VA = "0x184C45420")]
		private int Adapt(int delta, int numPoints, bool firstTime)
		{
			return 0;
		}

		// Token: 0x06002B23 RID: 11043 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002B23")]
		[Address(RVA = "0x4C454D0", Offset = "0x4C440D0", VA = "0x184C454D0")]
		public string Decode(string s, int offset)
		{
			return null;
		}

		// Token: 0x04001911 RID: 6417
		[Token(Token = "0x4001911")]
		[FieldOffset(Offset = "0x10")]
		private readonly char delimiter;

		// Token: 0x04001912 RID: 6418
		[Token(Token = "0x4001912")]
		[FieldOffset(Offset = "0x14")]
		private readonly int base_num;

		// Token: 0x04001913 RID: 6419
		[Token(Token = "0x4001913")]
		[FieldOffset(Offset = "0x18")]
		private readonly int tmin;

		// Token: 0x04001914 RID: 6420
		[Token(Token = "0x4001914")]
		[FieldOffset(Offset = "0x1C")]
		private readonly int tmax;

		// Token: 0x04001915 RID: 6421
		[Token(Token = "0x4001915")]
		[FieldOffset(Offset = "0x20")]
		private readonly int skew;

		// Token: 0x04001916 RID: 6422
		[Token(Token = "0x4001916")]
		[FieldOffset(Offset = "0x24")]
		private readonly int damp;

		// Token: 0x04001917 RID: 6423
		[Token(Token = "0x4001917")]
		[FieldOffset(Offset = "0x28")]
		private readonly int initial_bias;

		// Token: 0x04001918 RID: 6424
		[Token(Token = "0x4001918")]
		[FieldOffset(Offset = "0x2C")]
		private readonly int initial_n;
	}
}
