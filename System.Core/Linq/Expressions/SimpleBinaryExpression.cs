using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Linq.Expressions
{
	// Token: 0x02000035 RID: 53
	[Token(Token = "0x2000035")]
	internal class SimpleBinaryExpression : BinaryExpression
	{
		// Token: 0x06000176 RID: 374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000176")]
		[Address(RVA = "0x4F3D670", Offset = "0x4F3C270", VA = "0x184F3D670")]
		internal SimpleBinaryExpression(ExpressionType nodeType, Expression left, Expression right, Type type)
		{
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000177 RID: 375 RVA: 0x000026A0 File Offset: 0x000008A0
		[Token(Token = "0x17000040")]
		public sealed override ExpressionType NodeType
		{
			[Token(Token = "0x6000177")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return ExpressionType.Add;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000178 RID: 376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000041")]
		public sealed override Type Type
		{
			[Token(Token = "0x6000178")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}
	}
}
