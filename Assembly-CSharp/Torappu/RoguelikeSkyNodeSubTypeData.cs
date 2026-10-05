using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020011C5 RID: 4549
	[Token(Token = "0x20011C5")]
	public class RoguelikeSkyNodeSubTypeData
	{
		// Token: 0x06006FB1 RID: 28593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FB1")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeSkyNodeSubTypeData()
		{
		}

		// Token: 0x04006161 RID: 24929
		[Token(Token = "0x4006161")]
		[FieldOffset(Offset = "0x10")]
		public RoguelikeSkyZoneNodeType evtType;

		// Token: 0x04006162 RID: 24930
		[Token(Token = "0x4006162")]
		[FieldOffset(Offset = "0x14")]
		public int subTypeId;

		// Token: 0x04006163 RID: 24931
		[Token(Token = "0x4006163")]
		[FieldOffset(Offset = "0x18")]
		public string desc;
	}
}
