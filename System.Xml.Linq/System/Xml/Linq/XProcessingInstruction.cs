using System;
using Il2CppDummyDll;

namespace System.Xml.Linq
{
	// Token: 0x0200001C RID: 28
	[Token(Token = "0x200001C")]
	public class XProcessingInstruction : XNode
	{
		// Token: 0x060000BE RID: 190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x4F8DA80", Offset = "0x4F8C680", VA = "0x184F8DA80")]
		public XProcessingInstruction(string target, string data)
		{
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x4F8DBF0", Offset = "0x4F8C7F0", VA = "0x184F8DBF0")]
		public XProcessingInstruction(XProcessingInstruction other)
		{
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000025")]
		public string Data
		{
			[Token(Token = "0x60000C0")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000C1")]
			[Address(RVA = "0x4F8DC90", Offset = "0x4F8C890", VA = "0x184F8DC90")]
			set
			{
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x000022F8 File Offset: 0x000004F8
		[Token(Token = "0x17000026")]
		public override XmlNodeType NodeType
		{
			[Token(Token = "0x60000C2")]
			[Address(RVA = "0x54AC30", Offset = "0x549830", VA = "0x18054AC30", Slot = "4")]
			get
			{
				return XmlNodeType.None;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000027")]
		public string Target
		{
			[Token(Token = "0x60000C3")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x4F8D9D0", Offset = "0x4F8C5D0", VA = "0x184F8D9D0", Slot = "5")]
		public override void WriteTo(XmlWriter writer)
		{
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x4F8D810", Offset = "0x4F8C410", VA = "0x184F8D810", Slot = "7")]
		internal override XNode CloneNode()
		{
			return null;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x4F8D8F0", Offset = "0x4F8C4F0", VA = "0x184F8D8F0")]
		private static void ValidateName(string name)
		{
		}

		// Token: 0x0400004A RID: 74
		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x28")]
		internal string target;

		// Token: 0x0400004B RID: 75
		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x30")]
		internal string data;
	}
}
