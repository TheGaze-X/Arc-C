using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Torappu.Battle.LevelScript
{
	// Token: 0x02002875 RID: 10357
	[Token(Token = "0x2002875")]
	public class ParamParserFloat : ParamParser<float>
	{
		// Token: 0x170025FD RID: 9725
		// (get) Token: 0x060113DA RID: 70618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170025FD")]
		public override ParamRealType[] paramRealTypeMask
		{
			[Token(Token = "0x60113DA")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170025FE RID: 9726
		// (get) Token: 0x060113DB RID: 70619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170025FE")]
		public override ParamValueType[] paramValueTypeMask
		{
			[Token(Token = "0x60113DB")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170025FF RID: 9727
		// (get) Token: 0x060113DC RID: 70620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170025FF")]
		public override ParamRealType[] paramListRealTypeMask
		{
			[Token(Token = "0x60113DC")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17002600 RID: 9728
		// (get) Token: 0x060113DD RID: 70621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002600")]
		public override ParamValueType[] paramListValueTypeMask
		{
			[Token(Token = "0x60113DD")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070", Slot = "21")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17002601 RID: 9729
		// (get) Token: 0x060113DE RID: 70622 RVA: 0x0006A410 File Offset: 0x00068610
		[Token(Token = "0x17002601")]
		public override int lengthPerItem
		{
			[Token(Token = "0x60113DE")]
			[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40", Slot = "22")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060113DF RID: 70623 RVA: 0x0006A428 File Offset: 0x00068628
		[Token(Token = "0x60113DF")]
		[Address(RVA = "0x9231B0", Offset = "0x921DB0", VA = "0x1809231B0", Slot = "23")]
		protected override float ValueAtIndexGetter(ParamValue paramValue, int index)
		{
			return 0f;
		}

		// Token: 0x060113E0 RID: 70624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60113E0")]
		[Address(RVA = "0x923270", Offset = "0x921E70", VA = "0x180923270", Slot = "24")]
		protected override void ValueAtIndexSetter(ParamValue paramValue, float value, int index)
		{
		}

		// Token: 0x060113E1 RID: 70625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60113E1")]
		[Address(RVA = "0x923160", Offset = "0x921D60", VA = "0x180923160", Slot = "25")]
		public override string ToStringPerItem(ParamValue paramValue, int itemIndex)
		{
			return null;
		}

		// Token: 0x060113E2 RID: 70626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60113E2")]
		[Address(RVA = "0x9232C0", Offset = "0x921EC0", VA = "0x1809232C0")]
		public ParamParserFloat()
		{
		}
	}
}
