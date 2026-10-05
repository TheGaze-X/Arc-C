using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Text.RegularExpressions
{
	// Token: 0x020000F4 RID: 244
	[Token(Token = "0x20000F4")]
	[Serializable]
	public class RegexMatchTimeoutException : TimeoutException, ISerializable
	{
		// Token: 0x060005BC RID: 1468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x510C6B0", Offset = "0x510B2B0", VA = "0x18510C6B0")]
		public RegexMatchTimeoutException(string regexInput, string regexPattern, TimeSpan matchTimeout)
		{
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x510C970", Offset = "0x510B570", VA = "0x18510C970")]
		public RegexMatchTimeoutException()
		{
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x510C7E0", Offset = "0x510B3E0", VA = "0x18510C7E0")]
		protected RegexMatchTimeoutException(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x510C5C0", Offset = "0x510B1C0", VA = "0x18510C5C0", Slot = "4")]
		private void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060005C0 RID: 1472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000F6")]
		public string Input
		{
			[Token(Token = "0x60005C0")]
			[Address(RVA = "0x789270", Offset = "0x787E70", VA = "0x180789270")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060005C1 RID: 1473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000F7")]
		public string Pattern
		{
			[Token(Token = "0x60005C1")]
			[Address(RVA = "0xF93800", Offset = "0xF92400", VA = "0x180F93800")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060005C2 RID: 1474 RVA: 0x00004428 File Offset: 0x00002628
		[Token(Token = "0x170000F8")]
		public TimeSpan MatchTimeout
		{
			[Token(Token = "0x60005C2")]
			[Address(RVA = "0x4FB2F0", Offset = "0x4F9EF0", VA = "0x1804FB2F0")]
			[CompilerGenerated]
			get
			{
				return default(TimeSpan);
			}
		}
	}
}
