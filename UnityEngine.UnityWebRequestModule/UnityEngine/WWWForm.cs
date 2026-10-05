using System;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;
using UnityEngine.Internal;

namespace UnityEngine
{
	// Token: 0x02000003 RID: 3
	[Token(Token = "0x2000003")]
	public class WWWForm
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000001")]
		internal static Encoding DefaultEncoding
		{
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x5B9C780", Offset = "0x5B9B380", VA = "0x185B9C780")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x5B9C5B0", Offset = "0x5B9B1B0", VA = "0x185B9C5B0")]
		public WWWForm()
		{
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x5B9C150", Offset = "0x5B9AD50", VA = "0x185B9C150")]
		public void AddField(string fieldName, string value)
		{
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x5B9BF90", Offset = "0x5B9AB90", VA = "0x185B9BF90")]
		public void AddField(string fieldName, string value, Encoding e)
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x5B9BD90", Offset = "0x5B9A990", VA = "0x185B9BD90")]
		[ExcludeFromDocs]
		public void AddBinaryData(string fieldName, byte[] contents)
		{
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x5B9BD70", Offset = "0x5B9A970", VA = "0x185B9BD70")]
		[ExcludeFromDocs]
		public void AddBinaryData(string fieldName, byte[] contents, string fileName)
		{
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x5B9BDB0", Offset = "0x5B9A9B0", VA = "0x185B9BDB0")]
		public void AddBinaryData(string fieldName, byte[] contents, [DefaultValue("null")] string fileName, [DefaultValue("null")] string mimeType)
		{
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000002")]
		public Dictionary<string, string> headers
		{
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x5B9DAC0", Offset = "0x5B9C6C0", VA = "0x185B9DAC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000E RID: 14 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000003")]
		public byte[] data
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x5B9C790", Offset = "0x5B9B390", VA = "0x185B9C790")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000002 RID: 2
		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x10")]
		private List<byte[]> formData;

		// Token: 0x04000003 RID: 3
		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x18")]
		private List<string> fieldNames;

		// Token: 0x04000004 RID: 4
		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x20")]
		private List<string> fileNames;

		// Token: 0x04000005 RID: 5
		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x28")]
		private List<string> types;

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x30")]
		private byte[] boundary;

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x38")]
		private bool containsFiles;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x0")]
		private static byte[] dDash;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x8")]
		private static byte[] crlf;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x10")]
		private static byte[] contentTypeHeader;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x18")]
		private static byte[] dispositionHeader;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x20")]
		private static byte[] endQuote;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x28")]
		private static byte[] fileNameField;

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x30")]
		private static byte[] ampersand;

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x38")]
		private static byte[] equal;
	}
}
