using System;
using System.Configuration.Internal;
using System.Xml;
using Il2CppDummyDll;

namespace System.Configuration
{
	// Token: 0x02000423 RID: 1059
	[Token(Token = "0x2000423")]
	public sealed class ConfigXmlDocument : XmlDocument, IConfigErrorInfo
	{
		// Token: 0x06001C51 RID: 7249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C51")]
		[Address(RVA = "0x50BB4C0", Offset = "0x50BA0C0", VA = "0x1850BB4C0")]
		public ConfigXmlDocument()
		{
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x06001C52 RID: 7250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000685")]
		public string Filename
		{
			[Token(Token = "0x6001C52")]
			[Address(RVA = "0x50BB4F0", Offset = "0x50BA0F0", VA = "0x1850BB4F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x06001C53 RID: 7251 RVA: 0x0000C330 File Offset: 0x0000A530
		[Token(Token = "0x17000686")]
		public int LineNumber
		{
			[Token(Token = "0x6001C53")]
			[Address(RVA = "0x50BB520", Offset = "0x50BA120", VA = "0x1850BB520")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001C54 RID: 7252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C54")]
		[Address(RVA = "0x50BB460", Offset = "0x50BA060", VA = "0x1850BB460", Slot = "64")]
		private string get_Filename()
		{
			return null;
		}

		// Token: 0x06001C55 RID: 7253 RVA: 0x0000C348 File Offset: 0x0000A548
		[Token(Token = "0x6001C55")]
		[Address(RVA = "0x50BB490", Offset = "0x50BA090", VA = "0x1850BB490", Slot = "65")]
		private int get_LineNumber()
		{
			return 0;
		}

		// Token: 0x06001C56 RID: 7254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C56")]
		[Address(RVA = "0x50BB430", Offset = "0x50BA030", VA = "0x1850BB430")]
		public void LoadSingleElement(string filename, XmlTextReader sourceReader)
		{
		}
	}
}
