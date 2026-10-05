using System;
using System.Text;
using Il2CppDummyDll;

namespace System.Xml.Linq
{
	// Token: 0x02000018 RID: 24
	[Token(Token = "0x2000018")]
	public abstract class XNode : XObject
	{
		// Token: 0x060000AC RID: 172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		internal XNode()
		{
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x4F8CF20", Offset = "0x4F8BB20", VA = "0x184F8CF20")]
		public void Remove()
		{
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x4F8CFA0", Offset = "0x4F8BBA0", VA = "0x184F8CFA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060000AF RID: 175
		[Token(Token = "0x60000AF")]
		public abstract void WriteTo(XmlWriter writer);

		// Token: 0x060000B0 RID: 176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
		internal virtual void AppendText(StringBuilder sb)
		{
		}

		// Token: 0x060000B1 RID: 177
		[Token(Token = "0x60000B1")]
		internal abstract XNode CloneNode();

		// Token: 0x060000B2 RID: 178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x4F8CBB0", Offset = "0x4F8B7B0", VA = "0x184F8CBB0")]
		private string GetXmlString(SaveOptions o)
		{
			return null;
		}

		// Token: 0x04000040 RID: 64
		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x20")]
		internal XNode next;
	}
}
