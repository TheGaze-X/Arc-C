using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Linq.Expressions
{
	// Token: 0x0200005F RID: 95
	[Token(Token = "0x200005F")]
	internal sealed class FullExpression<TDelegate> : ExpressionN<TDelegate>
	{
		// Token: 0x060002ED RID: 749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002ED")]
		public FullExpression(Expression body, string name, bool tailCall, IReadOnlyList<ParameterExpression> parameters)
		{
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060002EE RID: 750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000072")]
		internal override string NameCore
		{
			[Token(Token = "0x60002EE")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060002EF RID: 751 RVA: 0x00002A18 File Offset: 0x00000C18
		[Token(Token = "0x17000073")]
		internal override bool TailCallCore
		{
			[Token(Token = "0x60002EF")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}
	}
}
