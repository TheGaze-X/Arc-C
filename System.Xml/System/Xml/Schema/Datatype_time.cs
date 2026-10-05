using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x020000F2 RID: 242
	[Token(Token = "0x20000F2")]
	internal class Datatype_time : Datatype_dateTimeBase
	{
		// Token: 0x1700024A RID: 586
		// (get) Token: 0x060008FA RID: 2298 RVA: 0x00004DA0 File Offset: 0x00002FA0
		[Token(Token = "0x1700024A")]
		public override XmlTypeCode TypeCode
		{
			[Token(Token = "0x60008FA")]
			[Address(RVA = "0x5001810", Offset = "0x5000410", VA = "0x185001810", Slot = "8")]
			get
			{
				return XmlTypeCode.None;
			}
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008FB")]
		[Address(RVA = "0x50017C0", Offset = "0x50003C0", VA = "0x1850017C0")]
		internal Datatype_time()
		{
		}
	}
}
