using System;
using System.Collections;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x020002D1 RID: 721
	[Token(Token = "0x20002D1")]
	internal class HeaderInfoTable
	{
		// Token: 0x0600140B RID: 5131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600140B")]
		[Address(RVA = "0x50577C0", Offset = "0x50563C0", VA = "0x1850577C0")]
		private static string[] ParseSingleValue(string value)
		{
			return null;
		}

		// Token: 0x0600140C RID: 5132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600140C")]
		[Address(RVA = "0x50575C0", Offset = "0x50561C0", VA = "0x1850575C0")]
		private static string[] ParseMultiValue(string value)
		{
			return null;
		}

		// Token: 0x1700042C RID: 1068
		[Token(Token = "0x1700042C")]
		internal HeaderInfo this[string name]
		{
			[Token(Token = "0x600140E")]
			[Address(RVA = "0x5059FC0", Offset = "0x5058BC0", VA = "0x185059FC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600140F RID: 5135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600140F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HeaderInfoTable()
		{
		}

		// Token: 0x04000AD4 RID: 2772
		[Token(Token = "0x4000AD4")]
		[FieldOffset(Offset = "0x0")]
		private static Hashtable HeaderHashTable;

		// Token: 0x04000AD5 RID: 2773
		[Token(Token = "0x4000AD5")]
		[FieldOffset(Offset = "0x8")]
		private static HeaderInfo UnknownHeaderInfo;

		// Token: 0x04000AD6 RID: 2774
		[Token(Token = "0x4000AD6")]
		[FieldOffset(Offset = "0x10")]
		private static HeaderParser SingleParser;

		// Token: 0x04000AD7 RID: 2775
		[Token(Token = "0x4000AD7")]
		[FieldOffset(Offset = "0x18")]
		private static HeaderParser MultiParser;
	}
}
