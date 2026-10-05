using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace FullSerializer
{
	// Token: 0x02007B7B RID: 31611
	[Token(Token = "0x2007B7B")]
	public struct fsResult
	{
		// Token: 0x0602C3DD RID: 181213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C3DD")]
		[Address(RVA = "0x2835860", Offset = "0x2834460", VA = "0x182835860")]
		public void AddMessage(string message)
		{
		}

		// Token: 0x0602C3DE RID: 181214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C3DE")]
		[Address(RVA = "0x2835910", Offset = "0x2834510", VA = "0x182835910")]
		public void AddMessages(fsResult result)
		{
		}

		// Token: 0x0602C3DF RID: 181215 RVA: 0x000DEAE0 File Offset: 0x000DCCE0
		[Token(Token = "0x602C3DF")]
		[Address(RVA = "0x2835C40", Offset = "0x2834840", VA = "0x182835C40")]
		public fsResult Merge(fsResult other)
		{
			return default(fsResult);
		}

		// Token: 0x0602C3E0 RID: 181216 RVA: 0x000DEAF8 File Offset: 0x000DCCF8
		[Token(Token = "0x602C3E0")]
		[Address(RVA = "0x2835D30", Offset = "0x2834930", VA = "0x182835D30")]
		public static fsResult Warn(string warning)
		{
			return default(fsResult);
		}

		// Token: 0x0602C3E1 RID: 181217 RVA: 0x000DEB10 File Offset: 0x000DCD10
		[Token(Token = "0x602C3E1")]
		[Address(RVA = "0x2835B90", Offset = "0x2834790", VA = "0x182835B90")]
		public static fsResult Fail(string warning)
		{
			return default(fsResult);
		}

		// Token: 0x0602C3E2 RID: 181218 RVA: 0x000DEB28 File Offset: 0x000DCD28
		[Token(Token = "0x602C3E2")]
		[Address(RVA = "0x2836180", Offset = "0x2834D80", VA = "0x182836180")]
		public static fsResult operator +(fsResult a, fsResult b)
		{
			return default(fsResult);
		}

		// Token: 0x170067A3 RID: 26531
		// (get) Token: 0x0602C3E3 RID: 181219 RVA: 0x000DEB40 File Offset: 0x000DCD40
		[Token(Token = "0x170067A3")]
		public bool Failed
		{
			[Token(Token = "0x602C3E3")]
			[Address(RVA = "0x1A15A50", Offset = "0x1A14650", VA = "0x181A15A50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170067A4 RID: 26532
		// (get) Token: 0x0602C3E4 RID: 181220 RVA: 0x000DEB58 File Offset: 0x000DCD58
		[Token(Token = "0x170067A4")]
		public bool Succeeded
		{
			[Token(Token = "0x602C3E4")]
			[Address(RVA = "0xDF9A30", Offset = "0xDF8630", VA = "0x180DF9A30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170067A5 RID: 26533
		// (get) Token: 0x0602C3E5 RID: 181221 RVA: 0x000DEB70 File Offset: 0x000DCD70
		[Token(Token = "0x170067A5")]
		public bool HasWarnings
		{
			[Token(Token = "0x602C3E5")]
			[Address(RVA = "0x28360D0", Offset = "0x2834CD0", VA = "0x1828360D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602C3E6 RID: 181222 RVA: 0x000DEB88 File Offset: 0x000DCD88
		[Token(Token = "0x602C3E6")]
		[Address(RVA = "0x2835AF0", Offset = "0x28346F0", VA = "0x182835AF0")]
		public fsResult AssertSuccess()
		{
			return default(fsResult);
		}

		// Token: 0x0602C3E7 RID: 181223 RVA: 0x000DEBA0 File Offset: 0x000DCDA0
		[Token(Token = "0x602C3E7")]
		[Address(RVA = "0x28359D0", Offset = "0x28345D0", VA = "0x1828359D0")]
		public fsResult AssertSuccessWithoutWarnings()
		{
			return default(fsResult);
		}

		// Token: 0x170067A6 RID: 26534
		// (get) Token: 0x0602C3E8 RID: 181224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170067A6")]
		public Exception AsException
		{
			[Token(Token = "0x602C3E8")]
			[Address(RVA = "0x2835E90", Offset = "0x2834A90", VA = "0x182835E90")]
			get
			{
				return null;
			}
		}

		// Token: 0x170067A7 RID: 26535
		// (get) Token: 0x0602C3E9 RID: 181225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170067A7")]
		public IEnumerable<string> RawMessages
		{
			[Token(Token = "0x602C3E9")]
			[Address(RVA = "0x2836120", Offset = "0x2834D20", VA = "0x182836120")]
			get
			{
				return null;
			}
		}

		// Token: 0x170067A8 RID: 26536
		// (get) Token: 0x0602C3EA RID: 181226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170067A8")]
		public string FormattedMessages
		{
			[Token(Token = "0x602C3EA")]
			[Address(RVA = "0x2836010", Offset = "0x2834C10", VA = "0x182836010")]
			get
			{
				return null;
			}
		}

		// Token: 0x040401B5 RID: 262581
		[Token(Token = "0x40401B5")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string[] EmptyStringArray;

		// Token: 0x040401B6 RID: 262582
		[Token(Token = "0x40401B6")]
		[FieldOffset(Offset = "0x0")]
		private bool _success;

		// Token: 0x040401B7 RID: 262583
		[Token(Token = "0x40401B7")]
		[FieldOffset(Offset = "0x8")]
		private List<string> _messages;

		// Token: 0x040401B8 RID: 262584
		[Token(Token = "0x40401B8")]
		[FieldOffset(Offset = "0x8")]
		public static fsResult Success;
	}
}
