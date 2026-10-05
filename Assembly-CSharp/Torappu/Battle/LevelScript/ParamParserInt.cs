using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Torappu.Battle.LevelScript
{
	// Token: 0x02002876 RID: 10358
	[Token(Token = "0x2002876")]
	public class ParamParserInt : ParamParser<int>
	{
		// Token: 0x17002602 RID: 9730
		// (get) Token: 0x060113E3 RID: 70627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002602")]
		public override ParamRealType[] paramRealTypeMask
		{
			[Token(Token = "0x60113E3")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17002603 RID: 9731
		// (get) Token: 0x060113E4 RID: 70628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002603")]
		public override ParamValueType[] paramValueTypeMask
		{
			[Token(Token = "0x60113E4")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17002604 RID: 9732
		// (get) Token: 0x060113E5 RID: 70629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002604")]
		public override ParamRealType[] paramListRealTypeMask
		{
			[Token(Token = "0x60113E5")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17002605 RID: 9733
		// (get) Token: 0x060113E6 RID: 70630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002605")]
		public override ParamValueType[] paramListValueTypeMask
		{
			[Token(Token = "0x60113E6")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070", Slot = "21")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17002606 RID: 9734
		// (get) Token: 0x060113E7 RID: 70631 RVA: 0x0006A440 File Offset: 0x00068640
		[Token(Token = "0x17002606")]
		public override int lengthPerItem
		{
			[Token(Token = "0x60113E7")]
			[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40", Slot = "22")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060113E8 RID: 70632 RVA: 0x0006A458 File Offset: 0x00068658
		[Token(Token = "0x60113E8")]
		[Address(RVA = "0x923450", Offset = "0x922050", VA = "0x180923450", Slot = "23")]
		protected override int ValueAtIndexGetter(ParamValue paramValue, int index)
		{
			return 0;
		}

		// Token: 0x060113E9 RID: 70633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60113E9")]
		[Address(RVA = "0x923510", Offset = "0x922110", VA = "0x180923510", Slot = "24")]
		protected override void ValueAtIndexSetter(ParamValue paramValue, int value, int index)
		{
		}

		// Token: 0x060113EA RID: 70634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60113EA")]
		[Address(RVA = "0x923400", Offset = "0x922000", VA = "0x180923400", Slot = "25")]
		public override string ToStringPerItem(ParamValue paramValue, int itemIndex)
		{
			return null;
		}

		// Token: 0x060113EB RID: 70635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60113EB")]
		[Address(RVA = "0x923550", Offset = "0x922150", VA = "0x180923550")]
		public ParamParserInt()
		{
		}
	}
}
