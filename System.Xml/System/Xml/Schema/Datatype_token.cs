using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x020000FF RID: 255
	[Token(Token = "0x20000FF")]
	internal class Datatype_token : Datatype_normalizedString
	{
		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000935 RID: 2357 RVA: 0x00004FB0 File Offset: 0x000031B0
		[Token(Token = "0x17000269")]
		public override XmlTypeCode TypeCode
		{
			[Token(Token = "0x6000935")]
			[Address(RVA = "0x3D28750", Offset = "0x3D27350", VA = "0x183D28750", Slot = "8")]
			get
			{
				return XmlTypeCode.None;
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000936 RID: 2358 RVA: 0x00004FC8 File Offset: 0x000031C8
		[Token(Token = "0x1700026A")]
		internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		{
			[Token(Token = "0x6000936")]
			[Address(RVA = "0x54B0E0", Offset = "0x549CE0", VA = "0x18054B0E0", Slot = "14")]
			get
			{
				return XmlSchemaWhiteSpace.Preserve;
			}
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000937")]
		[Address(RVA = "0x4FF9F50", Offset = "0x4FF8B50", VA = "0x184FF9F50")]
		public Datatype_token()
		{
		}
	}
}
