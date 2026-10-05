using System;
using Il2CppDummyDll;

namespace System.Linq.Expressions
{
	// Token: 0x02000033 RID: 51
	[Token(Token = "0x2000033")]
	internal sealed class CoalesceConversionBinaryExpression : BinaryExpression
	{
		// Token: 0x06000170 RID: 368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000170")]
		[Address(RVA = "0x4F246C0", Offset = "0x4F232C0", VA = "0x184F246C0")]
		internal CoalesceConversionBinaryExpression(Expression left, Expression right, LambdaExpression conversion)
		{
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000171")]
		[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "11")]
		internal override LambdaExpression GetConversion()
		{
			return null;
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000172 RID: 370 RVA: 0x00002688 File Offset: 0x00000888
		[Token(Token = "0x1700003E")]
		public sealed override ExpressionType NodeType
		{
			[Token(Token = "0x6000172")]
			[Address(RVA = "0x54AC30", Offset = "0x549830", VA = "0x18054AC30", Slot = "4")]
			get
			{
				return ExpressionType.Add;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000173 RID: 371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003F")]
		public sealed override Type Type
		{
			[Token(Token = "0x6000173")]
			[Address(RVA = "0x4F24700", Offset = "0x4F23300", VA = "0x184F24700", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x040000CC RID: 204
		[Token(Token = "0x40000CC")]
		[FieldOffset(Offset = "0x20")]
		private readonly LambdaExpression _conversion;
	}
}
