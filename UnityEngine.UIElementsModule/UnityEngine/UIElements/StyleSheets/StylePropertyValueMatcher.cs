using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.UIElements.StyleSheets.Syntax;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x020002FD RID: 765
	[Token(Token = "0x20002FD")]
	internal class StylePropertyValueMatcher : BaseStyleMatcher
	{
		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x060014ED RID: 5357 RVA: 0x0000B328 File Offset: 0x00009528
		[Token(Token = "0x17000524")]
		private StylePropertyValue current
		{
			[Token(Token = "0x60014ED")]
			[Address(RVA = "0x5A840F0", Offset = "0x5A82CF0", VA = "0x185A840F0")]
			get
			{
				return default(StylePropertyValue);
			}
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x060014EE RID: 5358 RVA: 0x0000B340 File Offset: 0x00009540
		[Token(Token = "0x17000525")]
		public override int valueCount
		{
			[Token(Token = "0x60014EE")]
			[Address(RVA = "0x5A84260", Offset = "0x5A82E60", VA = "0x185A84260", Slot = "15")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x060014EF RID: 5359 RVA: 0x0000B358 File Offset: 0x00009558
		[Token(Token = "0x17000526")]
		public override bool isCurrentVariable
		{
			[Token(Token = "0x60014EF")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x060014F0 RID: 5360 RVA: 0x0000B370 File Offset: 0x00009570
		[Token(Token = "0x17000527")]
		public override bool isCurrentComma
		{
			[Token(Token = "0x60014F0")]
			[Address(RVA = "0x5A841A0", Offset = "0x5A82DA0", VA = "0x185A841A0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060014F1 RID: 5361 RVA: 0x0000B388 File Offset: 0x00009588
		[Token(Token = "0x60014F1")]
		[Address(RVA = "0x5A83E20", Offset = "0x5A82A20", VA = "0x185A83E20")]
		public MatchResult Match(Expression exp, List<StylePropertyValue> values)
		{
			return default(MatchResult);
		}

		// Token: 0x060014F2 RID: 5362 RVA: 0x0000B3A0 File Offset: 0x000095A0
		[Token(Token = "0x60014F2")]
		[Address(RVA = "0x5A83850", Offset = "0x5A82450", VA = "0x185A83850", Slot = "4")]
		protected override bool MatchKeyword(string keyword)
		{
			return default(bool);
		}

		// Token: 0x060014F3 RID: 5363 RVA: 0x0000B3B8 File Offset: 0x000095B8
		[Token(Token = "0x60014F3")]
		[Address(RVA = "0x5A837A0", Offset = "0x5A823A0", VA = "0x185A837A0", Slot = "5")]
		protected override bool MatchNumber()
		{
			return default(bool);
		}

		// Token: 0x060014F4 RID: 5364 RVA: 0x0000B3D0 File Offset: 0x000095D0
		[Token(Token = "0x60014F4")]
		[Address(RVA = "0x5A837A0", Offset = "0x5A823A0", VA = "0x185A837A0", Slot = "6")]
		protected override bool MatchInteger()
		{
			return default(bool);
		}

		// Token: 0x060014F5 RID: 5365 RVA: 0x0000B3E8 File Offset: 0x000095E8
		[Token(Token = "0x60014F5")]
		[Address(RVA = "0x5A83970", Offset = "0x5A82570", VA = "0x185A83970", Slot = "7")]
		protected override bool MatchLength()
		{
			return default(bool);
		}

		// Token: 0x060014F6 RID: 5366 RVA: 0x0000B400 File Offset: 0x00009600
		[Token(Token = "0x60014F6")]
		[Address(RVA = "0x5A83A90", Offset = "0x5A82690", VA = "0x185A83A90", Slot = "8")]
		protected override bool MatchPercentage()
		{
			return default(bool);
		}

		// Token: 0x060014F7 RID: 5367 RVA: 0x0000B418 File Offset: 0x00009618
		[Token(Token = "0x60014F7")]
		[Address(RVA = "0x5A83510", Offset = "0x5A82110", VA = "0x185A83510", Slot = "9")]
		protected override bool MatchColor()
		{
			return default(bool);
		}

		// Token: 0x060014F8 RID: 5368 RVA: 0x0000B430 File Offset: 0x00009630
		[Token(Token = "0x60014F8")]
		[Address(RVA = "0x5A83BB0", Offset = "0x5A827B0", VA = "0x185A83BB0", Slot = "10")]
		protected override bool MatchResource()
		{
			return default(bool);
		}

		// Token: 0x060014F9 RID: 5369 RVA: 0x0000B448 File Offset: 0x00009648
		[Token(Token = "0x60014F9")]
		[Address(RVA = "0x5A83D60", Offset = "0x5A82960", VA = "0x185A83D60", Slot = "11")]
		protected override bool MatchUrl()
		{
			return default(bool);
		}

		// Token: 0x060014FA RID: 5370 RVA: 0x0000B460 File Offset: 0x00009660
		[Token(Token = "0x60014FA")]
		[Address(RVA = "0x5A83C60", Offset = "0x5A82860", VA = "0x185A83C60", Slot = "12")]
		protected override bool MatchTime()
		{
			return default(bool);
		}

		// Token: 0x060014FB RID: 5371 RVA: 0x0000B478 File Offset: 0x00009678
		[Token(Token = "0x60014FB")]
		[Address(RVA = "0x5A83650", Offset = "0x5A82250", VA = "0x185A83650", Slot = "14")]
		protected override bool MatchCustomIdent()
		{
			return default(bool);
		}

		// Token: 0x060014FC RID: 5372 RVA: 0x0000B490 File Offset: 0x00009690
		[Token(Token = "0x60014FC")]
		[Address(RVA = "0x5A833F0", Offset = "0x5A81FF0", VA = "0x185A833F0", Slot = "13")]
		protected override bool MatchAngle()
		{
			return default(bool);
		}

		// Token: 0x060014FD RID: 5373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014FD")]
		[Address(RVA = "0x5A84030", Offset = "0x5A82C30", VA = "0x185A84030")]
		public StylePropertyValueMatcher()
		{
		}

		// Token: 0x04000C74 RID: 3188
		[Token(Token = "0x4000C74")]
		[FieldOffset(Offset = "0x20")]
		private List<StylePropertyValue> m_Values;
	}
}
