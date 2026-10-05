using System;
using System.Text;
using Il2CppDummyDll;

namespace System.Xml.Linq
{
	// Token: 0x0200001E RID: 30
	[Token(Token = "0x200001E")]
	public class XText : XNode
	{
		// Token: 0x060000C7 RID: 199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x4F86C90", Offset = "0x4F85890", VA = "0x184F86C90")]
		public XText(string value)
		{
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x4F86D20", Offset = "0x4F85920", VA = "0x184F86D20")]
		public XText(XText other)
		{
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x00002310 File Offset: 0x00000510
		[Token(Token = "0x17000028")]
		public override XmlNodeType NodeType
		{
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0x54B800", Offset = "0x54A400", VA = "0x18054B800", Slot = "4")]
			get
			{
				return XmlNodeType.None;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060000CB RID: 203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000029")]
		public string Value
		{
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x4F8E020", Offset = "0x4F8CC20", VA = "0x184F8E020")]
			set
			{
			}
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x4F8DEC0", Offset = "0x4F8CAC0", VA = "0x184F8DEC0", Slot = "5")]
		public override void WriteTo(XmlWriter writer)
		{
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x4F8DDC0", Offset = "0x4F8C9C0", VA = "0x184F8DDC0", Slot = "6")]
		internal override void AppendText(StringBuilder sb)
		{
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x4F8DDF0", Offset = "0x4F8C9F0", VA = "0x184F8DDF0", Slot = "7")]
		internal override XNode CloneNode()
		{
			return null;
		}

		// Token: 0x0400004E RID: 78
		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x28")]
		internal string text;
	}
}
