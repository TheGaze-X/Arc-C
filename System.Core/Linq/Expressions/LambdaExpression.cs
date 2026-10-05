using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Il2CppDummyDll;

namespace System.Linq.Expressions
{
	// Token: 0x02000057 RID: 87
	[Token(Token = "0x2000057")]
	[DebuggerTypeProxy(typeof(Expression.LambdaExpressionProxy))]
	public abstract class LambdaExpression : Expression, IParameterProvider
	{
		// Token: 0x060002C5 RID: 709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x4F42030", Offset = "0x4F40C30", VA = "0x184F42030")]
		internal LambdaExpression(Expression body)
		{
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000060")]
		public sealed override Type Type
		{
			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x4F242E0", Offset = "0x4F22EE0", VA = "0x184F242E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060002C7 RID: 711
		[Token(Token = "0x17000061")]
		internal abstract Type TypeCore { [Token(Token = "0x60002C7")] get; }

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060002C8 RID: 712
		[Token(Token = "0x17000062")]
		internal abstract Type PublicType { [Token(Token = "0x60002C8")] get; }

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060002C9 RID: 713 RVA: 0x00002928 File Offset: 0x00000B28
		[Token(Token = "0x17000063")]
		public sealed override ExpressionType NodeType
		{
			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x4BF3FC0", Offset = "0x4BF2BC0", VA = "0x184BF3FC0", Slot = "4")]
			get
			{
				return ExpressionType.Add;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060002CA RID: 714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000064")]
		public string Name
		{
			[Token(Token = "0x60002CA")]
			[Address(RVA = "0xFACF50", Offset = "0xFABB50", VA = "0x180FACF50")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060002CB RID: 715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000065")]
		internal virtual string NameCore
		{
			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060002CC RID: 716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000066")]
		public Expression Body
		{
			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060002CD RID: 717 RVA: 0x00002940 File Offset: 0x00000B40
		[Token(Token = "0x17000067")]
		public bool TailCall
		{
			[Token(Token = "0x60002CD")]
			[Address(RVA = "0x4F420D0", Offset = "0x4F40CD0", VA = "0x184F420D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060002CE RID: 718 RVA: 0x00002958 File Offset: 0x00000B58
		[Token(Token = "0x17000068")]
		internal virtual bool TailCallCore
		{
			[Token(Token = "0x60002CE")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060002CF RID: 719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x4F41FA0", Offset = "0x4F40BA0", VA = "0x184F41FA0", Slot = "10")]
		[ExcludeFromCodeCoverage]
		private ParameterExpression GetParameter(int index)
		{
			return null;
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x4F41F70", Offset = "0x4F40B70", VA = "0x184F41F70", Slot = "16")]
		[ExcludeFromCodeCoverage]
		internal virtual ParameterExpression GetParameter(int index)
		{
			return null;
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060002D1 RID: 721 RVA: 0x00002970 File Offset: 0x00000B70
		[Token(Token = "0x17000069")]
		[ExcludeFromCodeCoverage]
		private int ParameterCount
		{
			[Token(Token = "0x60002D1")]
			[Address(RVA = "0x4F41FF0", Offset = "0x4F40BF0", VA = "0x184F41FF0", Slot = "11")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060002D2 RID: 722 RVA: 0x00002988 File Offset: 0x00000B88
		[Token(Token = "0x1700006A")]
		[ExcludeFromCodeCoverage]
		internal virtual int ParameterCount
		{
			[Token(Token = "0x60002D2")]
			[Address(RVA = "0x4F420A0", Offset = "0x4F40CA0", VA = "0x184F420A0", Slot = "17")]
			get
			{
				return 0;
			}
		}

		// Token: 0x04000148 RID: 328
		[Token(Token = "0x4000148")]
		[FieldOffset(Offset = "0x10")]
		private readonly Expression _body;
	}
}
