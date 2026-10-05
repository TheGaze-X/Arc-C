using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Linq.Expressions
{
	// Token: 0x02000030 RID: 48
	[Token(Token = "0x2000030")]
	[DebuggerTypeProxy(typeof(Expression.BinaryExpressionProxy))]
	public class BinaryExpression : Expression
	{
		// Token: 0x06000157 RID: 343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000157")]
		[Address(RVA = "0x4F233C0", Offset = "0x4F21FC0", VA = "0x184F233C0")]
		internal BinaryExpression(Expression left, Expression right)
		{
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000158 RID: 344 RVA: 0x000025C8 File Offset: 0x000007C8
		[Token(Token = "0x17000032")]
		public override bool CanReduce
		{
			[Token(Token = "0x6000158")]
			[Address(RVA = "0x4F23440", Offset = "0x4F22040", VA = "0x184F23440", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000159 RID: 345 RVA: 0x000025E0 File Offset: 0x000007E0
		[Token(Token = "0x6000159")]
		[Address(RVA = "0x4F21E10", Offset = "0x4F20A10", VA = "0x184F21E10")]
		private static bool IsOpAssignment(ExpressionType op)
		{
			return default(bool);
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600015A RID: 346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000033")]
		public Expression Right
		{
			[Token(Token = "0x600015A")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600015B RID: 347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000034")]
		public Expression Left
		{
			[Token(Token = "0x600015B")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600015C RID: 348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000035")]
		public MethodInfo Method
		{
			[Token(Token = "0x600015C")]
			[Address(RVA = "0x4F23820", Offset = "0x4F22420", VA = "0x184F23820")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015D")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "10")]
		internal virtual MethodInfo GetMethod()
		{
			return null;
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015E")]
		[Address(RVA = "0x4F22D90", Offset = "0x4F21990", VA = "0x184F22D90")]
		public BinaryExpression Update(Expression left, LambdaExpression conversion, Expression right)
		{
			return null;
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015F")]
		[Address(RVA = "0x4F22CD0", Offset = "0x4F218D0", VA = "0x184F22CD0", Slot = "7")]
		public override Expression Reduce()
		{
			return null;
		}

		// Token: 0x06000160 RID: 352 RVA: 0x000025F8 File Offset: 0x000007F8
		[Token(Token = "0x6000160")]
		[Address(RVA = "0x4F21CF0", Offset = "0x4F208F0", VA = "0x184F21CF0")]
		private static ExpressionType GetBinaryOpFromAssignmentOp(ExpressionType op)
		{
			return ExpressionType.Add;
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000161")]
		[Address(RVA = "0x4F22B60", Offset = "0x4F21760", VA = "0x184F22B60")]
		private Expression ReduceVariable()
		{
			return null;
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000162")]
		[Address(RVA = "0x4F225D0", Offset = "0x4F211D0", VA = "0x184F225D0")]
		private Expression ReduceMember()
		{
			return null;
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000163")]
		[Address(RVA = "0x4F21E20", Offset = "0x4F20A20", VA = "0x184F21E20")]
		private Expression ReduceIndex()
		{
			return null;
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000164 RID: 356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000036")]
		public LambdaExpression Conversion
		{
			[Token(Token = "0x6000164")]
			[Address(RVA = "0x78A370", Offset = "0x788F70", VA = "0x18078A370")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000165")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "11")]
		internal virtual LambdaExpression GetConversion()
		{
			return null;
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000166 RID: 358 RVA: 0x00002610 File Offset: 0x00000810
		[Token(Token = "0x17000037")]
		public bool IsLifted
		{
			[Token(Token = "0x6000166")]
			[Address(RVA = "0x4F23510", Offset = "0x4F22110", VA = "0x184F23510")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000167 RID: 359 RVA: 0x00002628 File Offset: 0x00000828
		[Token(Token = "0x17000038")]
		public bool IsLiftedToNull
		{
			[Token(Token = "0x6000167")]
			[Address(RVA = "0x4F23480", Offset = "0x4F22080", VA = "0x184F23480")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000168")]
		[Address(RVA = "0x4F21CA0", Offset = "0x4F208A0", VA = "0x184F21CA0", Slot = "9")]
		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return null;
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000169 RID: 361 RVA: 0x00002640 File Offset: 0x00000840
		[Token(Token = "0x17000039")]
		internal bool IsReferenceComparison
		{
			[Token(Token = "0x6000169")]
			[Address(RVA = "0x4F236E0", Offset = "0x4F222E0", VA = "0x184F236E0")]
			get
			{
				return default(bool);
			}
		}
	}
}
