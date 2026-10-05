using System;
using System.Runtime.Serialization;
using System.Xml;
using Il2CppDummyDll;

namespace System.Configuration
{
	// Token: 0x020003E2 RID: 994
	[Token(Token = "0x20003E2")]
	[Serializable]
	public class ConfigurationException : SystemException
	{
		// Token: 0x06001A7C RID: 6780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A7C")]
		[Address(RVA = "0x50BB6A0", Offset = "0x50BA2A0", VA = "0x1850BB6A0")]
		[Obsolete("This class is obsolete, to create a new exception create a System.Configuration!System.Configuration.ConfigurationErrorsException")]
		public ConfigurationException()
		{
		}

		// Token: 0x06001A7D RID: 6781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A7D")]
		[Address(RVA = "0x50BB5B0", Offset = "0x50BA1B0", VA = "0x1850BB5B0")]
		protected ConfigurationException(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x06001A7E RID: 6782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A7E")]
		[Address(RVA = "0x50BB5E0", Offset = "0x50BA1E0", VA = "0x1850BB5E0")]
		[Obsolete("This class is obsolete, to create a new exception create a System.Configuration!System.Configuration.ConfigurationErrorsException")]
		public ConfigurationException(string message)
		{
		}

		// Token: 0x06001A7F RID: 6783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A7F")]
		[Address(RVA = "0x50BB6D0", Offset = "0x50BA2D0", VA = "0x1850BB6D0")]
		[Obsolete("This class is obsolete, to create a new exception create a System.Configuration!System.Configuration.ConfigurationErrorsException")]
		public ConfigurationException(string message, Exception inner)
		{
		}

		// Token: 0x06001A80 RID: 6784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A80")]
		[Address(RVA = "0x50BB610", Offset = "0x50BA210", VA = "0x1850BB610")]
		[Obsolete("This class is obsolete, to create a new exception create a System.Configuration!System.Configuration.ConfigurationErrorsException")]
		public ConfigurationException(string message, Exception inner, string filename, int line)
		{
		}

		// Token: 0x06001A81 RID: 6785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A81")]
		[Address(RVA = "0x50BB640", Offset = "0x50BA240", VA = "0x1850BB640")]
		[Obsolete("This class is obsolete, to create a new exception create a System.Configuration!System.Configuration.ConfigurationErrorsException")]
		public ConfigurationException(string message, Exception inner, XmlNode node)
		{
		}

		// Token: 0x06001A82 RID: 6786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A82")]
		[Address(RVA = "0x50BB700", Offset = "0x50BA300", VA = "0x1850BB700")]
		[Obsolete("This class is obsolete, to create a new exception create a System.Configuration!System.Configuration.ConfigurationErrorsException")]
		public ConfigurationException(string message, string filename, int line)
		{
		}

		// Token: 0x06001A83 RID: 6787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A83")]
		[Address(RVA = "0x50BB670", Offset = "0x50BA270", VA = "0x1850BB670")]
		[Obsolete("This class is obsolete, to create a new exception create a System.Configuration!System.Configuration.ConfigurationErrorsException")]
		public ConfigurationException(string message, XmlNode node)
		{
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x06001A84 RID: 6788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005D1")]
		public virtual string BareMessage
		{
			[Token(Token = "0x6001A84")]
			[Address(RVA = "0x50BB730", Offset = "0x50BA330", VA = "0x1850BB730", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06001A85 RID: 6789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005D2")]
		public virtual string Filename
		{
			[Token(Token = "0x6001A85")]
			[Address(RVA = "0x50BB760", Offset = "0x50BA360", VA = "0x1850BB760", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06001A86 RID: 6790 RVA: 0x0000BC88 File Offset: 0x00009E88
		[Token(Token = "0x170005D3")]
		public virtual int Line
		{
			[Token(Token = "0x6001A86")]
			[Address(RVA = "0x50BB790", Offset = "0x50BA390", VA = "0x1850BB790", Slot = "16")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001A87 RID: 6791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A87")]
		[Address(RVA = "0x50BB550", Offset = "0x50BA150", VA = "0x1850BB550")]
		[Obsolete("This class is obsolete, use System.Configuration!System.Configuration.ConfigurationErrorsException.GetFilename instead")]
		public static string GetXmlNodeFilename(XmlNode node)
		{
			return null;
		}

		// Token: 0x06001A88 RID: 6792 RVA: 0x0000BCA0 File Offset: 0x00009EA0
		[Token(Token = "0x6001A88")]
		[Address(RVA = "0x50BB580", Offset = "0x50BA180", VA = "0x1850BB580")]
		[Obsolete("This class is obsolete, use System.Configuration!System.Configuration.ConfigurationErrorsException.GetLinenumber instead")]
		public static int GetXmlNodeLineNumber(XmlNode node)
		{
			return 0;
		}
	}
}
