using System;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	internal class XmlRawWriterBase64Encoder : Base64Encoder
	{
		// Token: 0x06000008 RID: 8 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x4F83180", Offset = "0x4F81D80", VA = "0x184F83180")]
		internal XmlRawWriterBase64Encoder(XmlRawWriter rawWriter)
		{
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x4F83100", Offset = "0x4F81D00", VA = "0x184F83100", Slot = "4")]
		internal override void WriteChars(char[] chars, int index, int count)
		{
		}

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x28")]
		private XmlRawWriter rawWriter;
	}
}
