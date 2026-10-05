using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Torappu.Battle.LevelScript
{
	// Token: 0x02002873 RID: 10355
	[Token(Token = "0x2002873")]
	public class ParamParserBool : ParamParser<bool>
	{
		// Token: 0x170025F8 RID: 9720
		// (get) Token: 0x060113C3 RID: 70595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170025F8")]
		public override ParamRealType[] paramRealTypeMask
		{
			[Token(Token = "0x60113C3")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170025F9 RID: 9721
		// (get) Token: 0x060113C4 RID: 70596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170025F9")]
		public override ParamValueType[] paramValueTypeMask
		{
			[Token(Token = "0x60113C4")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170025FA RID: 9722
		// (get) Token: 0x060113C5 RID: 70597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170025FA")]
		public override ParamRealType[] paramListRealTypeMask
		{
			[Token(Token = "0x60113C5")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170025FB RID: 9723
		// (get) Token: 0x060113C6 RID: 70598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170025FB")]
		public override ParamValueType[] paramListValueTypeMask
		{
			[Token(Token = "0x60113C6")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070", Slot = "21")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170025FC RID: 9724
		// (get) Token: 0x060113C7 RID: 70599 RVA: 0x0006A380 File Offset: 0x00068580
		[Token(Token = "0x170025FC")]
		public override int lengthPerItem
		{
			[Token(Token = "0x60113C7")]
			[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40", Slot = "22")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060113C8 RID: 70600 RVA: 0x0006A398 File Offset: 0x00068598
		[Token(Token = "0x60113C8")]
		[Address(RVA = "0x922B50", Offset = "0x921750", VA = "0x180922B50", Slot = "23")]
		protected override bool ValueAtIndexGetter(ParamValue paramValue, int index)
		{
			return default(bool);
		}

		// Token: 0x060113C9 RID: 70601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60113C9")]
		[Address(RVA = "0x922C20", Offset = "0x921820", VA = "0x180922C20", Slot = "24")]
		protected override void ValueAtIndexSetter(ParamValue paramValue, bool value, int index)
		{
		}

		// Token: 0x060113CA RID: 70602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60113CA")]
		[Address(RVA = "0x922AC0", Offset = "0x9216C0", VA = "0x180922AC0", Slot = "25")]
		public override string ToStringPerItem(ParamValue paramValue, int itemIndex)
		{
			return null;
		}

		// Token: 0x060113CB RID: 70603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60113CB")]
		[Address(RVA = "0x922C60", Offset = "0x921860", VA = "0x180922C60")]
		public ParamParserBool()
		{
		}
	}
}
