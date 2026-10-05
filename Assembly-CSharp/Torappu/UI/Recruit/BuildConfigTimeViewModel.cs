using System;
using Il2CppDummyDll;

namespace Torappu.UI.Recruit
{
	// Token: 0x02004708 RID: 18184
	[Token(Token = "0x2004708")]
	public class BuildConfigTimeViewModel
	{
		// Token: 0x170041A3 RID: 16803
		// (get) Token: 0x0601B91E RID: 112926 RVA: 0x000A5858 File Offset: 0x000A3A58
		// (set) Token: 0x0601B91F RID: 112927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170041A3")]
		public long buildTimeMillsec
		{
			[Token(Token = "0x601B91E")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x601B91F")]
			[Address(RVA = "0x14DA1B0", Offset = "0x14D8DB0", VA = "0x1814DA1B0")]
			set
			{
			}
		}

		// Token: 0x170041A4 RID: 16804
		// (get) Token: 0x0601B920 RID: 112928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170041A4")]
		public string hour
		{
			[Token(Token = "0x601B920")]
			[Address(RVA = "0x14DA0D0", Offset = "0x14D8CD0", VA = "0x1814DA0D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170041A5 RID: 16805
		// (get) Token: 0x0601B921 RID: 112929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170041A5")]
		public string minute
		{
			[Token(Token = "0x601B921")]
			[Address(RVA = "0x14DA140", Offset = "0x14D8D40", VA = "0x1814DA140")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601B922 RID: 112930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B922")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BuildConfigTimeViewModel()
		{
		}

		// Token: 0x04023B4E RID: 146254
		[Token(Token = "0x4023B4E")]
		[FieldOffset(Offset = "0x10")]
		private long m_buildTimeMillsec;

		// Token: 0x04023B4F RID: 146255
		[Token(Token = "0x4023B4F")]
		[FieldOffset(Offset = "0x18")]
		private int m_hour;

		// Token: 0x04023B50 RID: 146256
		[Token(Token = "0x4023B50")]
		[FieldOffset(Offset = "0x1C")]
		private int m_minute;

		// Token: 0x04023B51 RID: 146257
		[Token(Token = "0x4023B51")]
		[FieldOffset(Offset = "0x20")]
		private int m_second;
	}
}
