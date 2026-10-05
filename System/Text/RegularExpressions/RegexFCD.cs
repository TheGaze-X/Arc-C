using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace System.Text.RegularExpressions
{
	// Token: 0x020000F1 RID: 241
	[Token(Token = "0x20000F1")]
	internal ref struct RegexFCD
	{
		// Token: 0x0600057D RID: 1405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600057D")]
		[Address(RVA = "0x50FB1E0", Offset = "0x50F9DE0", VA = "0x1850FB1E0")]
		private RegexFCD(Span<int> intStack)
		{
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x000041A0 File Offset: 0x000023A0
		[Token(Token = "0x600057E")]
		[Address(RVA = "0x50FA580", Offset = "0x50F9180", VA = "0x1850FA580")]
		public static RegexPrefix? FirstChars(RegexTree t)
		{
			return null;
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x000041B8 File Offset: 0x000023B8
		[Token(Token = "0x600057F")]
		[Address(RVA = "0x50FAB70", Offset = "0x50F9770", VA = "0x1850FAB70")]
		public static RegexPrefix Prefix(RegexTree tree)
		{
			return default(RegexPrefix);
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x000041D0 File Offset: 0x000023D0
		[Token(Token = "0x6000580")]
		[Address(RVA = "0x50F9C50", Offset = "0x50F8850", VA = "0x1850F9C50")]
		public static int Anchors(RegexTree tree)
		{
			return 0;
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x000041E8 File Offset: 0x000023E8
		[Token(Token = "0x6000581")]
		[Address(RVA = "0x50F9BD0", Offset = "0x50F87D0", VA = "0x1850F9BD0")]
		private static int AnchorFromType(int type)
		{
			return 0;
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000582")]
		[Address(RVA = "0x50FAE60", Offset = "0x50F9A60", VA = "0x1850FAE60")]
		private void PushInt(int i)
		{
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x00004200 File Offset: 0x00002400
		[Token(Token = "0x6000583")]
		[Address(RVA = "0x50FAA30", Offset = "0x50F9630", VA = "0x1850FAA30")]
		private bool IntIsEmpty()
		{
			return default(bool);
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x00004218 File Offset: 0x00002418
		[Token(Token = "0x6000584")]
		[Address(RVA = "0x50FAB20", Offset = "0x50F9720", VA = "0x1850FAB20")]
		private int PopInt()
		{
			return 0;
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000585")]
		[Address(RVA = "0x50FAE00", Offset = "0x50F9A00", VA = "0x1850FAE00")]
		private void PushFC(RegexFC fc)
		{
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x00004230 File Offset: 0x00002430
		[Token(Token = "0x6000586")]
		[Address(RVA = "0x50FA540", Offset = "0x50F9140", VA = "0x1850FA540")]
		private bool FCIsEmpty()
		{
			return default(bool);
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000587")]
		[Address(RVA = "0x50FAA70", Offset = "0x50F9670", VA = "0x1850FAA70")]
		private RegexFC PopFC()
		{
			return null;
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000588")]
		[Address(RVA = "0x50FB180", Offset = "0x50F9D80", VA = "0x1850FB180")]
		private RegexFC TopFC()
		{
			return null;
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000589")]
		[Address(RVA = "0x50FA420", Offset = "0x50F9020", VA = "0x1850FA420")]
		public void Dispose()
		{
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600058A")]
		[Address(RVA = "0x50FAF10", Offset = "0x50F9B10", VA = "0x1850FAF10")]
		private RegexFC RegexFCFromRegexTree(RegexTree tree)
		{
			return null;
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600058B")]
		[Address(RVA = "0x50967B0", Offset = "0x50953B0", VA = "0x1850967B0")]
		private void SkipChild()
		{
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600058C")]
		[Address(RVA = "0x50F9E10", Offset = "0x50F8A10", VA = "0x1850F9E10")]
		private void CalculateFC(int NodeType, RegexNode node, int CurIndex)
		{
		}

		// Token: 0x040003EF RID: 1007
		[Token(Token = "0x40003EF")]
		[FieldOffset(Offset = "0x0")]
		private readonly List<RegexFC> _fcStack;

		// Token: 0x040003F0 RID: 1008
		[Token(Token = "0x40003F0")]
		[FieldOffset(Offset = "0x8")]
		private ValueListBuilder<int> _intStack;

		// Token: 0x040003F1 RID: 1009
		[Token(Token = "0x40003F1")]
		[FieldOffset(Offset = "0x28")]
		private bool _skipAllChildren;

		// Token: 0x040003F2 RID: 1010
		[Token(Token = "0x40003F2")]
		[FieldOffset(Offset = "0x29")]
		private bool _skipchild;

		// Token: 0x040003F3 RID: 1011
		[Token(Token = "0x40003F3")]
		[FieldOffset(Offset = "0x2A")]
		private bool _failed;
	}
}
