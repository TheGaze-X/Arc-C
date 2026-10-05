using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x02000102 RID: 258
	[Token(Token = "0x2000102")]
	internal class Datatype_NMTOKEN : Datatype_token
	{
		// Token: 0x1700026D RID: 621
		// (get) Token: 0x0600093C RID: 2364 RVA: 0x00005010 File Offset: 0x00003210
		[Token(Token = "0x1700026D")]
		public override XmlTypeCode TypeCode
		{
			[Token(Token = "0x600093C")]
			[Address(RVA = "0x4FFA110", Offset = "0x4FF8D10", VA = "0x184FFA110", Slot = "8")]
			get
			{
				return XmlTypeCode.None;
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x0600093D RID: 2365 RVA: 0x00005028 File Offset: 0x00003228
		[Token(Token = "0x1700026E")]
		public override XmlTokenizedType TokenizedType
		{
			[Token(Token = "0x600093D")]
			[Address(RVA = "0x54BA20", Offset = "0x54A620", VA = "0x18054BA20", Slot = "5")]
			get
			{
				return XmlTokenizedType.CDATA;
			}
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600093E")]
		[Address(RVA = "0x4FF9F50", Offset = "0x4FF8B50", VA = "0x184FF9F50")]
		public Datatype_NMTOKEN()
		{
		}
	}
}
