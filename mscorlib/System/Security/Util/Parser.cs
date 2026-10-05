using System;
using Il2CppDummyDll;

namespace System.Security.Util
{
	// Token: 0x020002C6 RID: 710
	[Token(Token = "0x20002C6")]
	internal sealed class Parser
	{
		// Token: 0x060017D6 RID: 6102 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60017D6")]
		[Address(RVA = "0x4B14DE0", Offset = "0x4B139E0", VA = "0x184B14DE0")]
		internal SecurityElement GetTopElement()
		{
			return null;
		}

		// Token: 0x060017D7 RID: 6103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017D7")]
		[Address(RVA = "0x4B145C0", Offset = "0x4B131C0", VA = "0x184B145C0")]
		private void GetRequiredSizes(TokenizerStream stream, ref int index)
		{
		}

		// Token: 0x060017D8 RID: 6104 RVA: 0x00011238 File Offset: 0x0000F438
		[Token(Token = "0x60017D8")]
		[Address(RVA = "0x4B143C0", Offset = "0x4B12FC0", VA = "0x184B143C0")]
		private int DetermineFormat(TokenizerStream stream)
		{
			return 0;
		}

		// Token: 0x060017D9 RID: 6105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017D9")]
		[Address(RVA = "0x4B14E10", Offset = "0x4B13A10", VA = "0x184B14E10")]
		private void ParseContents()
		{
		}

		// Token: 0x060017DA RID: 6106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017DA")]
		[Address(RVA = "0x4B154B0", Offset = "0x4B140B0", VA = "0x184B154B0")]
		private Parser(Tokenizer t)
		{
		}

		// Token: 0x060017DB RID: 6107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017DB")]
		[Address(RVA = "0x4B153B0", Offset = "0x4B13FB0", VA = "0x184B153B0")]
		internal Parser(string input)
		{
		}

		// Token: 0x04000CD8 RID: 3288
		[Token(Token = "0x4000CD8")]
		[FieldOffset(Offset = "0x10")]
		private SecurityDocument _doc;

		// Token: 0x04000CD9 RID: 3289
		[Token(Token = "0x4000CD9")]
		[FieldOffset(Offset = "0x18")]
		private Tokenizer _t;
	}
}
