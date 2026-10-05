using System;
using System.Collections;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Core
{
	// Token: 0x02000019 RID: 25
	[Token(Token = "0x2000019")]
	public class NameFilter : IScanFilter
	{
		// Token: 0x060000B9 RID: 185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x4A40770", Offset = "0x4A3F370", VA = "0x184A40770")]
		public NameFilter(string filter)
		{
		}

		// Token: 0x060000BA RID: 186 RVA: 0x000023E8 File Offset: 0x000005E8
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x4A401B0", Offset = "0x4A3EDB0", VA = "0x184A401B0")]
		public static bool IsValidExpression(string expression)
		{
			return default(bool);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00002400 File Offset: 0x00000600
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x4A40220", Offset = "0x4A3EE20", VA = "0x184A40220")]
		public static bool IsValidFilterExpression(string toTest)
		{
			return default(bool);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x4A40430", Offset = "0x4A3F030", VA = "0x184A40430")]
		public static string[] SplitQuoted(string original)
		{
			return null;
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00002418 File Offset: 0x00000618
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x4A3FEE0", Offset = "0x4A3EAE0", VA = "0x184A3FEE0")]
		public bool IsIncluded(string name)
		{
			return default(bool);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00002430 File Offset: 0x00000630
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x4A3FCA0", Offset = "0x4A3E8A0", VA = "0x184A3FCA0")]
		public bool IsExcluded(string name)
		{
			return default(bool);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00002448 File Offset: 0x00000648
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x4A40160", Offset = "0x4A3ED60", VA = "0x184A40160", Slot = "4")]
		public bool IsMatch(string name)
		{
			return default(bool);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x4A3FAF0", Offset = "0x4A3E6F0", VA = "0x184A3FAF0")]
		private void Compile()
		{
		}

		// Token: 0x0400007F RID: 127
		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x10")]
		private string filter_;

		// Token: 0x04000080 RID: 128
		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x18")]
		private ArrayList inclusions_;

		// Token: 0x04000081 RID: 129
		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x20")]
		private ArrayList exclusions_;
	}
}
