using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Linq.Expressions
{
	// Token: 0x02000063 RID: 99
	[Token(Token = "0x2000063")]
	[DebuggerTypeProxy(typeof(Expression.ParameterExpressionProxy))]
	public class ParameterExpression : Expression
	{
		// Token: 0x060002FF RID: 767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x4F42CD0", Offset = "0x4F418D0", VA = "0x184F42CD0")]
		internal ParameterExpression(string name)
		{
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000300")]
		[Address(RVA = "0x4F42470", Offset = "0x4F41070", VA = "0x184F42470")]
		internal static ParameterExpression Make(Type type, string name, bool isByRef)
		{
			return null;
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000301 RID: 769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000079")]
		public override Type Type
		{
			[Token(Token = "0x6000301")]
			[Address(RVA = "0x4F42D40", Offset = "0x4F41940", VA = "0x184F42D40", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000302 RID: 770 RVA: 0x00002A48 File Offset: 0x00000C48
		[Token(Token = "0x1700007A")]
		public sealed override ExpressionType NodeType
		{
			[Token(Token = "0x6000302")]
			[Address(RVA = "0x2111F40", Offset = "0x2110B40", VA = "0x182111F40", Slot = "4")]
			get
			{
				return ExpressionType.Add;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000303 RID: 771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007B")]
		public string Name
		{
			[Token(Token = "0x6000303")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000304 RID: 772 RVA: 0x00002A60 File Offset: 0x00000C60
		[Token(Token = "0x1700007C")]
		public bool IsByRef
		{
			[Token(Token = "0x6000304")]
			[Address(RVA = "0x4F23820", Offset = "0x4F22420", VA = "0x184F23820")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00002A78 File Offset: 0x00000C78
		[Token(Token = "0x6000305")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "10")]
		internal virtual bool GetIsByRef()
		{
			return default(bool);
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000306")]
		[Address(RVA = "0x4F42420", Offset = "0x4F41020", VA = "0x184F42420", Slot = "9")]
		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return null;
		}
	}
}
