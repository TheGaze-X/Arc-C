using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Linq.Expressions
{
	// Token: 0x0200004B RID: 75
	[Token(Token = "0x200004B")]
	internal sealed class ScopeWithType : ScopeN
	{
		// Token: 0x0600022C RID: 556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600022C")]
		[Address(RVA = "0x4F3D630", Offset = "0x4F3C230", VA = "0x184F3D630")]
		internal ScopeWithType(IReadOnlyList<ParameterExpression> variables, IReadOnlyList<Expression> expressions, Type type)
		{
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600022D RID: 557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000052")]
		public sealed override Type Type
		{
			[Token(Token = "0x600022D")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022E")]
		[Address(RVA = "0x4F3D460", Offset = "0x4F3C060", VA = "0x184F3D460", Slot = "13")]
		internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args)
		{
			return null;
		}
	}
}
