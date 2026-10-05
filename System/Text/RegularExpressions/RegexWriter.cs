using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace System.Text.RegularExpressions
{
	// Token: 0x020000FD RID: 253
	[Token(Token = "0x20000FD")]
	internal ref struct RegexWriter
	{
		// Token: 0x06000648 RID: 1608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000648")]
		[Address(RVA = "0x5118580", Offset = "0x5117180", VA = "0x185118580")]
		private RegexWriter(Span<int> emittedSpan, Span<int> intStackSpan)
		{
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000649")]
		[Address(RVA = "0x51182E0", Offset = "0x5116EE0", VA = "0x1851182E0")]
		public static RegexCode Write(RegexTree tree)
		{
			return null;
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600064A")]
		[Address(RVA = "0x5116EB0", Offset = "0x5115AB0", VA = "0x185116EB0")]
		public void Dispose()
		{
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600064B")]
		[Address(RVA = "0x5117BC0", Offset = "0x51167C0", VA = "0x185117BC0")]
		public RegexCode RegexCodeFromRegexTree(RegexTree tree)
		{
			return null;
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600064C")]
		[Address(RVA = "0x5117B60", Offset = "0x5116760", VA = "0x185117B60")]
		private void PatchJump(int offset, int jumpDest)
		{
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600064D")]
		[Address(RVA = "0x5117980", Offset = "0x5116580", VA = "0x185117980")]
		private void Emit(int op)
		{
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600064E")]
		[Address(RVA = "0x5117900", Offset = "0x5116500", VA = "0x185117900")]
		private void Emit(int op, int opd1)
		{
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600064F")]
		[Address(RVA = "0x51179E0", Offset = "0x51165E0", VA = "0x1851179E0")]
		private void Emit(int op, int opd1, int opd2)
		{
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x00004848 File Offset: 0x00002A48
		[Token(Token = "0x6000650")]
		[Address(RVA = "0x51181E0", Offset = "0x5116DE0", VA = "0x1851181E0")]
		private int StringCode(string str)
		{
			return 0;
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x00004860 File Offset: 0x00002A60
		[Token(Token = "0x6000651")]
		[Address(RVA = "0x5117A80", Offset = "0x5116680", VA = "0x185117A80")]
		private int MapCapnum(int capnum)
		{
			return 0;
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000652")]
		[Address(RVA = "0x5116F00", Offset = "0x5115B00", VA = "0x185116F00")]
		private void EmitFragment(int nodetype, RegexNode node, int curIndex)
		{
		}

		// Token: 0x0400044C RID: 1100
		[Token(Token = "0x400044C")]
		[FieldOffset(Offset = "0x0")]
		private ValueListBuilder<int> _emitted;

		// Token: 0x0400044D RID: 1101
		[Token(Token = "0x400044D")]
		[FieldOffset(Offset = "0x20")]
		private ValueListBuilder<int> _intStack;

		// Token: 0x0400044E RID: 1102
		[Token(Token = "0x400044E")]
		[FieldOffset(Offset = "0x40")]
		private readonly Dictionary<string, int> _stringHash;

		// Token: 0x0400044F RID: 1103
		[Token(Token = "0x400044F")]
		[FieldOffset(Offset = "0x48")]
		private readonly List<string> _stringTable;

		// Token: 0x04000450 RID: 1104
		[Token(Token = "0x4000450")]
		[FieldOffset(Offset = "0x50")]
		private Hashtable _caps;

		// Token: 0x04000451 RID: 1105
		[Token(Token = "0x4000451")]
		[FieldOffset(Offset = "0x58")]
		private int _trackCount;
	}
}
