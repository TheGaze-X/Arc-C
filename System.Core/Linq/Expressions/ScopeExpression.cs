using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Il2CppDummyDll;

namespace System.Linq.Expressions
{
	// Token: 0x02000048 RID: 72
	[Token(Token = "0x2000048")]
	internal class ScopeExpression : BlockExpression
	{
		// Token: 0x0600021E RID: 542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600021E")]
		[Address(RVA = "0x4F24420", Offset = "0x4F23020", VA = "0x184F24420")]
		internal ScopeExpression(IReadOnlyList<ParameterExpression> variables)
		{
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021F")]
		[Address(RVA = "0x4F3D1C0", Offset = "0x4F3BDC0", VA = "0x184F3D1C0", Slot = "12")]
		internal override ReadOnlyCollection<ParameterExpression> GetOrMakeVariables()
		{
			return null;
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000220 RID: 544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004E")]
		protected IReadOnlyList<ParameterExpression> VariablesList
		{
			[Token(Token = "0x6000220")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000221")]
		[Address(RVA = "0x4F3D200", Offset = "0x4F3BE00", VA = "0x184F3D200")]
		internal IReadOnlyList<ParameterExpression> ReuseOrValidateVariables(ReadOnlyCollection<ParameterExpression> variables)
		{
			return null;
		}

		// Token: 0x040000E5 RID: 229
		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0x10")]
		private IReadOnlyList<ParameterExpression> _variables;
	}
}
