using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Il2CppDummyDll;

namespace BestHTTP.Forms
{
	// Token: 0x020004D3 RID: 1235
	[Token(Token = "0x20004D3")]
	public class HTTPFormBase
	{
		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x060028F0 RID: 10480 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060028F1 RID: 10481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005E9")]
		public List<HTTPFieldData> Fields
		{
			[Token(Token = "0x60028F0")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60028F1")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x060028F2 RID: 10482 RVA: 0x000115E0 File Offset: 0x0000F7E0
		[Token(Token = "0x170005EA")]
		public bool IsEmpty
		{
			[Token(Token = "0x60028F2")]
			[Address(RVA = "0x53A4990", Offset = "0x53A3590", VA = "0x1853A4990")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x060028F3 RID: 10483 RVA: 0x000115F8 File Offset: 0x0000F7F8
		// (set) Token: 0x060028F4 RID: 10484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005EB")]
		public bool IsChanged
		{
			[Token(Token = "0x60028F3")]
			[Address(RVA = "0x4F4E70", Offset = "0x4F3A70", VA = "0x1804F4E70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60028F4")]
			[Address(RVA = "0x4F4E80", Offset = "0x4F3A80", VA = "0x1804F4E80")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x060028F5 RID: 10485 RVA: 0x00011610 File Offset: 0x0000F810
		// (set) Token: 0x060028F6 RID: 10486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005EC")]
		public bool HasBinary
		{
			[Token(Token = "0x60028F5")]
			[Address(RVA = "0x54A770", Offset = "0x549370", VA = "0x18054A770")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60028F6")]
			[Address(RVA = "0x54A790", Offset = "0x549390", VA = "0x18054A790")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x060028F7 RID: 10487 RVA: 0x00011628 File Offset: 0x0000F828
		// (set) Token: 0x060028F8 RID: 10488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005ED")]
		public bool HasLongValue
		{
			[Token(Token = "0x60028F7")]
			[Address(RVA = "0x2205330", Offset = "0x2203F30", VA = "0x182205330")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60028F8")]
			[Address(RVA = "0x2205340", Offset = "0x2203F40", VA = "0x182205340")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060028F9 RID: 10489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028F9")]
		[Address(RVA = "0x53A45F0", Offset = "0x53A31F0", VA = "0x1853A45F0")]
		public void AddBinaryData(string fieldName, byte[] content)
		{
		}

		// Token: 0x060028FA RID: 10490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028FA")]
		[Address(RVA = "0x53A4610", Offset = "0x53A3210", VA = "0x1853A4610")]
		public void AddBinaryData(string fieldName, byte[] content, string fileName)
		{
		}

		// Token: 0x060028FB RID: 10491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028FB")]
		[Address(RVA = "0x53A4460", Offset = "0x53A3060", VA = "0x1853A4460")]
		public void AddBinaryData(string fieldName, byte[] content, string fileName, string mimeType)
		{
		}

		// Token: 0x060028FC RID: 10492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028FC")]
		[Address(RVA = "0x53A4630", Offset = "0x53A3230", VA = "0x1853A4630")]
		public void AddField(string fieldName, string value)
		{
		}

		// Token: 0x060028FD RID: 10493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028FD")]
		[Address(RVA = "0x53A4680", Offset = "0x53A3280", VA = "0x1853A4680")]
		public void AddField(string fieldName, string value, Encoding e)
		{
		}

		// Token: 0x060028FE RID: 10494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028FE")]
		[Address(RVA = "0x53A4840", Offset = "0x53A3440", VA = "0x1853A4840", Slot = "4")]
		public virtual void CopyFrom(HTTPFormBase fields)
		{
		}

		// Token: 0x060028FF RID: 10495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028FF")]
		[Address(RVA = "0x53A4940", Offset = "0x53A3540", VA = "0x1853A4940", Slot = "5")]
		public virtual void PrepareRequest(HTTPRequest request)
		{
		}

		// Token: 0x06002900 RID: 10496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002900")]
		[Address(RVA = "0x53A48F0", Offset = "0x53A34F0", VA = "0x1853A48F0", Slot = "6")]
		public virtual byte[] GetData()
		{
			return null;
		}

		// Token: 0x06002901 RID: 10497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002901")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HTTPFormBase()
		{
		}

		// Token: 0x040016A9 RID: 5801
		[Token(Token = "0x40016A9")]
		private const int LongLength = 256;
	}
}
