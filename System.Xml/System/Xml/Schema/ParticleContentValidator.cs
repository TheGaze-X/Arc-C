using System;
using System.Collections;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x020000D4 RID: 212
	[Token(Token = "0x20000D4")]
	internal sealed class ParticleContentValidator : ContentValidator
	{
		// Token: 0x06000854 RID: 2132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000854")]
		[Address(RVA = "0x4FE58F0", Offset = "0x4FE44F0", VA = "0x184FE58F0")]
		public ParticleContentValidator(XmlSchemaContentType contentType)
		{
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000855")]
		[Address(RVA = "0x4FE5950", Offset = "0x4FE4550", VA = "0x184FE5950")]
		public ParticleContentValidator(XmlSchemaContentType contentType, bool enableUpaCheck)
		{
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000856")]
		[Address(RVA = "0x4FE5720", Offset = "0x4FE4320", VA = "0x184FE5720")]
		public void Start()
		{
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000857")]
		[Address(RVA = "0x4FE56D0", Offset = "0x4FE42D0", VA = "0x184FE56D0")]
		public void OpenGroup()
		{
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000858")]
		[Address(RVA = "0x4FE3740", Offset = "0x4FE2340", VA = "0x184FE3740")]
		public void CloseGroup()
		{
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x00004980 File Offset: 0x00002B80
		[Token(Token = "0x6000859")]
		[Address(RVA = "0x4FE3BC0", Offset = "0x4FE27C0", VA = "0x184FE3BC0")]
		public bool Exists(XmlQualifiedName name)
		{
			return default(bool);
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600085A")]
		[Address(RVA = "0x4FE2240", Offset = "0x4FE0E40", VA = "0x184FE2240")]
		public void AddName(XmlQualifiedName name, object particle)
		{
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600085B")]
		[Address(RVA = "0x4FE2300", Offset = "0x4FE0F00", VA = "0x184FE2300")]
		public void AddNamespaceList(NamespaceList namespaceList, object particle)
		{
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600085C")]
		[Address(RVA = "0x4FE20C0", Offset = "0x4FE0CC0", VA = "0x184FE20C0")]
		private void AddLeafNode(SyntaxTreeNode node)
		{
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600085D")]
		[Address(RVA = "0x4FE1F60", Offset = "0x4FE0B60", VA = "0x184FE1F60")]
		public void AddChoice()
		{
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600085E")]
		[Address(RVA = "0x4FE24A0", Offset = "0x4FE10A0", VA = "0x184FE24A0")]
		public void AddSequence()
		{
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600085F")]
		[Address(RVA = "0x4FE2600", Offset = "0x4FE1200", VA = "0x184FE2600")]
		public void AddStar()
		{
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000860")]
		[Address(RVA = "0x4FE23C0", Offset = "0x4FE0FC0", VA = "0x184FE23C0")]
		public void AddPlus()
		{
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000861")]
		[Address(RVA = "0x4FE2430", Offset = "0x4FE1030", VA = "0x184FE2430")]
		public void AddQMark()
		{
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000862")]
		[Address(RVA = "0x4FE3980", Offset = "0x4FE2580", VA = "0x184FE3980")]
		private void Closure(InteriorNode node)
		{
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000863")]
		[Address(RVA = "0x4FE3C20", Offset = "0x4FE2820", VA = "0x184FE3C20")]
		public ContentValidator Finish(bool useDFA)
		{
			return null;
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000864")]
		[Address(RVA = "0x4FE2D30", Offset = "0x4FE1930", VA = "0x184FE2D30")]
		private BitSet[] CalculateTotalFollowposForRangeNodes(BitSet firstpos, BitSet[] followpos, out BitSet posWithRangeTerminals)
		{
			return null;
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000865")]
		[Address(RVA = "0x4FE3180", Offset = "0x4FE1D80", VA = "0x184FE3180")]
		private void CheckCMUPAWithLeafRangeNodes(BitSet curpos)
		{
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000866")]
		[Address(RVA = "0x4FE5150", Offset = "0x4FE3D50", VA = "0x184FE5150")]
		private BitSet GetApplicableMinMaxFollowPos(BitSet curpos, BitSet posWithRangeTerminals, BitSet[] minmaxFollowPos)
		{
			return null;
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000867")]
		[Address(RVA = "0x4FE3680", Offset = "0x4FE2280", VA = "0x184FE3680")]
		private void CheckUniqueParticleAttribution(BitSet firstpos, BitSet[] followpos)
		{
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000868")]
		[Address(RVA = "0x4FE33D0", Offset = "0x4FE1FD0", VA = "0x184FE33D0")]
		private void CheckUniqueParticleAttribution(BitSet curpos)
		{
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000869")]
		[Address(RVA = "0x4FE2670", Offset = "0x4FE1270", VA = "0x184FE2670")]
		private int[][] BuildTransitionTable(BitSet firstpos, BitSet[] followpos, int endMarkerPos)
		{
			return null;
		}

		// Token: 0x04000437 RID: 1079
		[Token(Token = "0x4000437")]
		[FieldOffset(Offset = "0x18")]
		private SymbolsDictionary symbols;

		// Token: 0x04000438 RID: 1080
		[Token(Token = "0x4000438")]
		[FieldOffset(Offset = "0x20")]
		private Positions positions;

		// Token: 0x04000439 RID: 1081
		[Token(Token = "0x4000439")]
		[FieldOffset(Offset = "0x28")]
		private Stack stack;

		// Token: 0x0400043A RID: 1082
		[Token(Token = "0x400043A")]
		[FieldOffset(Offset = "0x30")]
		private SyntaxTreeNode contentNode;

		// Token: 0x0400043B RID: 1083
		[Token(Token = "0x400043B")]
		[FieldOffset(Offset = "0x38")]
		private bool isPartial;

		// Token: 0x0400043C RID: 1084
		[Token(Token = "0x400043C")]
		[FieldOffset(Offset = "0x3C")]
		private int minMaxNodesCount;

		// Token: 0x0400043D RID: 1085
		[Token(Token = "0x400043D")]
		[FieldOffset(Offset = "0x40")]
		private bool enableUpaCheck;
	}
}
