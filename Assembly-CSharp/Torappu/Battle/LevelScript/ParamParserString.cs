using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Torappu.Battle.LevelScript
{
	// Token: 0x02002877 RID: 10359
	[Token(Token = "0x2002877")]
	public class ParamParserString : ParamParser<string>
	{
		// Token: 0x17002607 RID: 9735
		// (get) Token: 0x060113EC RID: 70636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002607")]
		public override ParamRealType[] paramRealTypeMask
		{
			[Token(Token = "0x60113EC")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17002608 RID: 9736
		// (get) Token: 0x060113ED RID: 70637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002608")]
		public override ParamValueType[] paramValueTypeMask
		{
			[Token(Token = "0x60113ED")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17002609 RID: 9737
		// (get) Token: 0x060113EE RID: 70638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002609")]
		public override ParamRealType[] paramListRealTypeMask
		{
			[Token(Token = "0x60113EE")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700260A RID: 9738
		// (get) Token: 0x060113EF RID: 70639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700260A")]
		public override ParamValueType[] paramListValueTypeMask
		{
			[Token(Token = "0x60113EF")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070", Slot = "21")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700260B RID: 9739
		// (get) Token: 0x060113F0 RID: 70640 RVA: 0x0006A470 File Offset: 0x00068670
		[Token(Token = "0x1700260B")]
		public override int lengthPerItem
		{
			[Token(Token = "0x60113F0")]
			[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40", Slot = "22")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060113F1 RID: 70641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60113F1")]
		[Address(RVA = "0x923700", Offset = "0x922300", VA = "0x180923700", Slot = "23")]
		protected override string ValueAtIndexGetter(ParamValue paramValue, int index)
		{
			return null;
		}

		// Token: 0x060113F2 RID: 70642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60113F2")]
		[Address(RVA = "0x9237D0", Offset = "0x9223D0", VA = "0x1809237D0", Slot = "24")]
		protected override void ValueAtIndexSetter(ParamValue paramValue, string value, int index)
		{
		}

		// Token: 0x060113F3 RID: 70643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60113F3")]
		[Address(RVA = "0x923690", Offset = "0x922290", VA = "0x180923690", Slot = "25")]
		public override string ToStringPerItem(ParamValue paramValue, int itemIndex)
		{
			return null;
		}

		// Token: 0x060113F4 RID: 70644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60113F4")]
		[Address(RVA = "0x923820", Offset = "0x922420", VA = "0x180923820")]
		public ParamParserString()
		{
		}
	}
}
