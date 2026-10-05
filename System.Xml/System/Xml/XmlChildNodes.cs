using System;
using System.Collections;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x02000067 RID: 103
	[Token(Token = "0x2000067")]
	internal class XmlChildNodes : XmlNodeList
	{
		// Token: 0x060004AA RID: 1194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
		public XmlChildNodes(XmlNode container)
		{
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060004AB RID: 1195 RVA: 0x00003240 File Offset: 0x00001440
		[Token(Token = "0x17000100")]
		public override int Count
		{
			[Token(Token = "0x60004AB")]
			[Address(RVA = "0x4FA8C00", Offset = "0x4FA7800", VA = "0x184FA8C00", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x4FA8AD0", Offset = "0x4FA76D0", VA = "0x184FA8AD0", Slot = "7")]
		public override IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x04000293 RID: 659
		[Token(Token = "0x4000293")]
		[FieldOffset(Offset = "0x10")]
		private XmlNode container;
	}
}
