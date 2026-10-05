using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x020000A8 RID: 168
	[Token(Token = "0x20000A8")]
	[Serializable]
	public class XmlException : SystemException
	{
		// Token: 0x06000779 RID: 1913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000779")]
		[Address(RVA = "0x4FF64E0", Offset = "0x4FF50E0", VA = "0x184FF64E0")]
		protected XmlException(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600077A")]
		[Address(RVA = "0x4FF6270", Offset = "0x4FF4E70", VA = "0x184FF6270", Slot = "12")]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600077B")]
		[Address(RVA = "0x4FF69D0", Offset = "0x4FF55D0", VA = "0x184FF69D0")]
		public XmlException()
		{
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600077C")]
		[Address(RVA = "0x4FF69A0", Offset = "0x4FF55A0", VA = "0x184FF69A0")]
		public XmlException(string message)
		{
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600077D")]
		[Address(RVA = "0x4FF63C0", Offset = "0x4FF4FC0", VA = "0x184FF63C0")]
		public XmlException(string message, Exception innerException, int lineNumber, int linePosition)
		{
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600077E")]
		[Address(RVA = "0x4FF6B90", Offset = "0x4FF5790", VA = "0x184FF6B90")]
		internal XmlException(string message, Exception innerException, int lineNumber, int linePosition, string sourceUri)
		{
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600077F")]
		[Address(RVA = "0x4FF6E00", Offset = "0x4FF5A00", VA = "0x184FF6E00")]
		internal XmlException(string res, string[] args)
		{
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000780")]
		[Address(RVA = "0x4FF6FF0", Offset = "0x4FF5BF0", VA = "0x184FF6FF0")]
		internal XmlException(string res, string arg)
		{
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000781")]
		[Address(RVA = "0x4FF6F00", Offset = "0x4FF5B00", VA = "0x184FF6F00")]
		internal XmlException(string res, string arg, string sourceUri)
		{
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000782")]
		[Address(RVA = "0x4FF63F0", Offset = "0x4FF4FF0", VA = "0x184FF63F0")]
		internal XmlException(string res, string arg, int lineNumber, int linePosition)
		{
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000783")]
		[Address(RVA = "0x4FF6A30", Offset = "0x4FF5630", VA = "0x184FF6A30")]
		internal XmlException(string res, string arg, int lineNumber, int linePosition, string sourceUri)
		{
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000784")]
		[Address(RVA = "0x4FF6B20", Offset = "0x4FF5720", VA = "0x184FF6B20")]
		internal XmlException(string res, string[] args, int lineNumber, int linePosition)
		{
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000785")]
		[Address(RVA = "0x4FF6B50", Offset = "0x4FF5750", VA = "0x184FF6B50")]
		internal XmlException(string res, string[] args, int lineNumber, int linePosition, string sourceUri)
		{
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000786")]
		[Address(RVA = "0x4FF6A00", Offset = "0x4FF5600", VA = "0x184FF6A00")]
		internal XmlException(string res, string[] args, Exception innerException, int lineNumber, int linePosition)
		{
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000787")]
		[Address(RVA = "0x4FF6E30", Offset = "0x4FF5A30", VA = "0x184FF6E30")]
		internal XmlException(string res, string[] args, Exception innerException, int lineNumber, int linePosition, string sourceUri)
		{
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000788")]
		[Address(RVA = "0x4FF6130", Offset = "0x4FF4D30", VA = "0x184FF6130")]
		private static string FormatUserMessage(string message, int lineNumber, int linePosition)
		{
			return null;
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000789")]
		[Address(RVA = "0x4FF5EF0", Offset = "0x4FF4AF0", VA = "0x184FF5EF0")]
		private static string CreateMessage(string res, string[] args, int lineNumber, int linePosition)
		{
			return null;
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600078A")]
		[Address(RVA = "0x4FF5A90", Offset = "0x4FF4690", VA = "0x184FF5A90")]
		internal static string[] BuildCharExceptionArgs(string data, int invCharIndex)
		{
			return null;
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600078B")]
		[Address(RVA = "0x4FF5E90", Offset = "0x4FF4A90", VA = "0x184FF5E90")]
		internal static string[] BuildCharExceptionArgs(char[] data, int length, int invCharIndex)
		{
			return null;
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600078C")]
		[Address(RVA = "0x4FF5AF0", Offset = "0x4FF46F0", VA = "0x184FF5AF0")]
		internal static string[] BuildCharExceptionArgs(char invChar, char nextChar)
		{
			return null;
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x0600078D RID: 1933 RVA: 0x00004458 File Offset: 0x00002658
		[Token(Token = "0x170001C8")]
		public int LineNumber
		{
			[Token(Token = "0x600078D")]
			[Address(RVA = "0x371A2F0", Offset = "0x3718EF0", VA = "0x18371A2F0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x0600078E RID: 1934 RVA: 0x00004470 File Offset: 0x00002670
		[Token(Token = "0x170001C9")]
		public int LinePosition
		{
			[Token(Token = "0x600078E")]
			[Address(RVA = "0x4211E80", Offset = "0x4210A80", VA = "0x184211E80")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x0600078F RID: 1935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001CA")]
		public override string Message
		{
			[Token(Token = "0x600078F")]
			[Address(RVA = "0x4FF70D0", Offset = "0x4FF5CD0", VA = "0x184FF70D0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000790 RID: 1936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001CB")]
		internal string ResString
		{
			[Token(Token = "0x6000790")]
			[Address(RVA = "0x789270", Offset = "0x787E70", VA = "0x180789270")]
			get
			{
				return null;
			}
		}

		// Token: 0x040003BC RID: 956
		[Token(Token = "0x40003BC")]
		[FieldOffset(Offset = "0x90")]
		private string res;

		// Token: 0x040003BD RID: 957
		[Token(Token = "0x40003BD")]
		[FieldOffset(Offset = "0x98")]
		private string[] args;

		// Token: 0x040003BE RID: 958
		[Token(Token = "0x40003BE")]
		[FieldOffset(Offset = "0xA0")]
		private int lineNumber;

		// Token: 0x040003BF RID: 959
		[Token(Token = "0x40003BF")]
		[FieldOffset(Offset = "0xA4")]
		private int linePosition;

		// Token: 0x040003C0 RID: 960
		[Token(Token = "0x40003C0")]
		[FieldOffset(Offset = "0xA8")]
		[OptionalField]
		private string sourceUri;

		// Token: 0x040003C1 RID: 961
		[Token(Token = "0x40003C1")]
		[FieldOffset(Offset = "0xB0")]
		private string message;
	}
}
