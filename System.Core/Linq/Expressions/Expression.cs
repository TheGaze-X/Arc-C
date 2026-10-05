using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic.Utils;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Linq.Expressions
{
	// Token: 0x02000037 RID: 55
	[Token(Token = "0x2000037")]
	public abstract class Expression
	{
		// Token: 0x0600017B RID: 379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600017B")]
		[Address(RVA = "0x4F2A080", Offset = "0x4F28C80", VA = "0x184F2A080")]
		public static BinaryExpression Assign(Expression left, Expression right)
		{
			return null;
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600017C")]
		[Address(RVA = "0x4F2F250", Offset = "0x4F2DE50", VA = "0x184F2F250")]
		private static BinaryExpression GetUserDefinedBinaryOperator(ExpressionType binaryType, string name, Expression left, Expression right, bool liftToNull)
		{
			return null;
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600017D")]
		[Address(RVA = "0x4F2D6D0", Offset = "0x4F2C2D0", VA = "0x184F2D6D0")]
		private static BinaryExpression GetMethodBasedBinaryOperator(ExpressionType binaryType, Expression left, Expression right, MethodInfo method, bool liftToNull)
		{
			return null;
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600017E")]
		[Address(RVA = "0x4F2D380", Offset = "0x4F2BF80", VA = "0x184F2D380")]
		private static BinaryExpression GetMethodBasedAssignOperator(ExpressionType binaryType, Expression left, Expression right, MethodInfo method, LambdaExpression conversion, bool liftToNull)
		{
			return null;
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600017F")]
		[Address(RVA = "0x4F2EF90", Offset = "0x4F2DB90", VA = "0x184F2EF90")]
		private static BinaryExpression GetUserDefinedBinaryOperatorOrThrow(ExpressionType binaryType, string name, Expression left, Expression right, bool liftToNull)
		{
			return null;
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000180")]
		[Address(RVA = "0x4F2EC40", Offset = "0x4F2D840", VA = "0x184F2EC40")]
		private static BinaryExpression GetUserDefinedAssignOperatorOrThrow(ExpressionType binaryType, string name, Expression left, Expression right, LambdaExpression conversion, bool liftToNull)
		{
			return null;
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000181")]
		[Address(RVA = "0x4F2F6A0", Offset = "0x4F2E2A0", VA = "0x184F2F6A0")]
		private static MethodInfo GetUserDefinedBinaryOperator(ExpressionType binaryType, Type leftType, Type rightType, string name)
		{
			return null;
		}

		// Token: 0x06000182 RID: 386 RVA: 0x000026B8 File Offset: 0x000008B8
		[Token(Token = "0x6000182")]
		[Address(RVA = "0x4F308B0", Offset = "0x4F2F4B0", VA = "0x184F308B0")]
		private static bool IsLiftingConditionalLogicalOperator(Type left, Type right, MethodInfo method, ExpressionType binaryType)
		{
			return default(bool);
		}

		// Token: 0x06000183 RID: 387 RVA: 0x000026D0 File Offset: 0x000008D0
		[Token(Token = "0x6000183")]
		[Address(RVA = "0x4F36B60", Offset = "0x4F35760", VA = "0x184F36B60")]
		internal static bool ParameterIsAssignable(ParameterInfo pi, Type argType)
		{
			return default(bool);
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000184")]
		[Address(RVA = "0x4F3B8E0", Offset = "0x4F3A4E0", VA = "0x184F3B8E0")]
		private static void ValidateParamswithOperandsOrThrow(Type paramType, Type operandType, ExpressionType exprType, string name)
		{
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000185")]
		[Address(RVA = "0x4F3B700", Offset = "0x4F3A300", VA = "0x184F3B700")]
		private static void ValidateOperator(MethodInfo method)
		{
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000186")]
		[Address(RVA = "0x4F3B2F0", Offset = "0x4F39EF0", VA = "0x184F3B2F0")]
		private static void ValidateMethodInfo(MethodInfo method, string paramName)
		{
		}

		// Token: 0x06000187 RID: 391 RVA: 0x000026E8 File Offset: 0x000008E8
		[Token(Token = "0x6000187")]
		[Address(RVA = "0x4F30970", Offset = "0x4F2F570", VA = "0x184F30970")]
		private static bool IsNullComparison(Expression left, Expression right)
		{
			return default(bool);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00002700 File Offset: 0x00000900
		[Token(Token = "0x6000188")]
		[Address(RVA = "0x4F30BF0", Offset = "0x4F2F7F0", VA = "0x184F30BF0")]
		private static bool IsNullConstant(Expression e)
		{
			return default(bool);
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000189")]
		[Address(RVA = "0x4F3B9C0", Offset = "0x4F3A5C0", VA = "0x184F3B9C0")]
		private static void ValidateUserDefinedConditionalLogicOperator(ExpressionType nodeType, Type left, Type right, MethodInfo method)
		{
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600018A")]
		[Address(RVA = "0x4F3C5A0", Offset = "0x4F3B1A0", VA = "0x184F3C5A0")]
		private static void VerifyOpTrueFalse(ExpressionType nodeType, Type left, MethodInfo opTrue, string paramName)
		{
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00002718 File Offset: 0x00000918
		[Token(Token = "0x600018B")]
		[Address(RVA = "0x4F30F20", Offset = "0x4F2FB20", VA = "0x184F30F20")]
		private static bool IsValidLiftedConditionalLogicalOperator(Type left, Type right, ParameterInfo[] pms)
		{
			return default(bool);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018C")]
		[Address(RVA = "0x4F32730", Offset = "0x4F31330", VA = "0x184F32730")]
		public static BinaryExpression MakeBinary(ExpressionType binaryType, Expression left, Expression right, bool liftToNull, MethodInfo method)
		{
			return null;
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018D")]
		[Address(RVA = "0x4F317D0", Offset = "0x4F303D0", VA = "0x184F317D0")]
		public static BinaryExpression MakeBinary(ExpressionType binaryType, Expression left, Expression right, bool liftToNull, MethodInfo method, LambdaExpression conversion)
		{
			return null;
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018E")]
		[Address(RVA = "0x4F2C0C0", Offset = "0x4F2ACC0", VA = "0x184F2C0C0")]
		public static BinaryExpression Equal(Expression left, Expression right, bool liftToNull, MethodInfo method)
		{
			return null;
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018F")]
		[Address(RVA = "0x4F37C80", Offset = "0x4F36880", VA = "0x184F37C80")]
		public static BinaryExpression ReferenceEqual(Expression left, Expression right)
		{
			return null;
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000190")]
		[Address(RVA = "0x4F359C0", Offset = "0x4F345C0", VA = "0x184F359C0")]
		public static BinaryExpression NotEqual(Expression left, Expression right, bool liftToNull, MethodInfo method)
		{
			return null;
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000191")]
		[Address(RVA = "0x4F37E30", Offset = "0x4F36A30", VA = "0x184F37E30")]
		public static BinaryExpression ReferenceNotEqual(Expression left, Expression right)
		{
			return null;
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000192")]
		[Address(RVA = "0x4F2CC00", Offset = "0x4F2B800", VA = "0x184F2CC00")]
		private static BinaryExpression GetEqualityComparisonOperator(ExpressionType binaryType, string opName, Expression left, Expression right, bool liftToNull)
		{
			return null;
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000193")]
		[Address(RVA = "0x4F30270", Offset = "0x4F2EE70", VA = "0x184F30270")]
		public static BinaryExpression GreaterThan(Expression left, Expression right, bool liftToNull, MethodInfo method)
		{
			return null;
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000194")]
		[Address(RVA = "0x4F316B0", Offset = "0x4F302B0", VA = "0x184F316B0")]
		public static BinaryExpression LessThan(Expression left, Expression right, bool liftToNull, MethodInfo method)
		{
			return null;
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000195")]
		[Address(RVA = "0x4F30150", Offset = "0x4F2ED50", VA = "0x184F30150")]
		public static BinaryExpression GreaterThanOrEqual(Expression left, Expression right, bool liftToNull, MethodInfo method)
		{
			return null;
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000196")]
		[Address(RVA = "0x4F31590", Offset = "0x4F30190", VA = "0x184F31590")]
		public static BinaryExpression LessThanOrEqual(Expression left, Expression right, bool liftToNull, MethodInfo method)
		{
			return null;
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000197")]
		[Address(RVA = "0x4F2C960", Offset = "0x4F2B560", VA = "0x184F2C960")]
		private static BinaryExpression GetComparisonOperator(ExpressionType binaryType, string opName, Expression left, Expression right, bool liftToNull)
		{
			return null;
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000198")]
		[Address(RVA = "0x4F28AC0", Offset = "0x4F276C0", VA = "0x184F28AC0")]
		public static BinaryExpression AndAlso(Expression left, Expression right, MethodInfo method)
		{
			return null;
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000199")]
		[Address(RVA = "0x4F36180", Offset = "0x4F34D80", VA = "0x184F36180")]
		public static BinaryExpression OrElse(Expression left, Expression right, MethodInfo method)
		{
			return null;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019A")]
		[Address(RVA = "0x4F2A830", Offset = "0x4F29430", VA = "0x184F2A830")]
		public static BinaryExpression Coalesce(Expression left, Expression right, LambdaExpression conversion)
		{
			return null;
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019B")]
		[Address(RVA = "0x4F3A390", Offset = "0x4F38F90", VA = "0x184F3A390")]
		private static Type ValidateCoalesceArgTypes(Type left, Type right)
		{
			return null;
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019C")]
		[Address(RVA = "0x4F28840", Offset = "0x4F27440", VA = "0x184F28840")]
		public static BinaryExpression Add(Expression left, Expression right, MethodInfo method)
		{
			return null;
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019D")]
		[Address(RVA = "0x4F282E0", Offset = "0x4F26EE0", VA = "0x184F282E0")]
		public static BinaryExpression AddAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
		{
			return null;
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600019E")]
		[Address(RVA = "0x4F3B3D0", Offset = "0x4F39FD0", VA = "0x184F3B3D0")]
		private static void ValidateOpAssignConversionLambda(LambdaExpression conversion, Expression left, MethodInfo method, ExpressionType nodeType)
		{
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019F")]
		[Address(RVA = "0x4F28000", Offset = "0x4F26C00", VA = "0x184F28000")]
		public static BinaryExpression AddAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
		{
			return null;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x4F285C0", Offset = "0x4F271C0", VA = "0x184F285C0")]
		public static BinaryExpression AddChecked(Expression left, Expression right, MethodInfo method)
		{
			return null;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x4F391B0", Offset = "0x4F37DB0", VA = "0x184F391B0")]
		public static BinaryExpression Subtract(Expression left, Expression right, MethodInfo method)
		{
			return null;
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x4F38C50", Offset = "0x4F37850", VA = "0x184F38C50")]
		public static BinaryExpression SubtractAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
		{
			return null;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x4F38970", Offset = "0x4F37570", VA = "0x184F38970")]
		public static BinaryExpression SubtractAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
		{
			return null;
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x4F38F30", Offset = "0x4F37B30", VA = "0x184F38F30")]
		public static BinaryExpression SubtractChecked(Expression left, Expression right, MethodInfo method)
		{
			return null;
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x4F2BE40", Offset = "0x4F2AA40", VA = "0x184F2BE40")]
		public static BinaryExpression Divide(Expression left, Expression right, MethodInfo method)
		{
			return null;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x4F2BB60", Offset = "0x4F2A760", VA = "0x184F2BB60")]
		public static BinaryExpression DivideAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
		{
			return null;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x4F348A0", Offset = "0x4F334A0", VA = "0x184F348A0")]
		public static BinaryExpression Modulo(Expression left, Expression right, MethodInfo method)
		{
			return null;
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x4F345C0", Offset = "0x4F331C0", VA = "0x184F345C0")]
		public static BinaryExpression ModuloAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
		{
			return null;
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x4F35360", Offset = "0x4F33F60", VA = "0x184F35360")]
		public static BinaryExpression Multiply(Expression left, Expression right, MethodInfo method)
		{
			return null;
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x4F34E00", Offset = "0x4F33A00", VA = "0x184F34E00")]
		public static BinaryExpression MultiplyAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
		{
			return null;
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x4F34B20", Offset = "0x4F33720", VA = "0x184F34B20")]
		public static BinaryExpression MultiplyAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
		{
			return null;
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x4F350E0", Offset = "0x4F33CE0", VA = "0x184F350E0")]
		public static BinaryExpression MultiplyChecked(Expression left, Expression right, MethodInfo method)
		{
			return null;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00002730 File Offset: 0x00000930
		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x4F30C80", Offset = "0x4F2F880", VA = "0x184F30C80")]
		private static bool IsSimpleShift(Type left, Type right)
		{
			return default(bool);
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x4F2EAC0", Offset = "0x4F2D6C0", VA = "0x184F2EAC0")]
		private static Type GetResultTypeOfShift(Type left, Type right)
		{
			return null;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x4F31300", Offset = "0x4F2FF00", VA = "0x184F31300")]
		public static BinaryExpression LeftShift(Expression left, Expression right, MethodInfo method)
		{
			return null;
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x4F31050", Offset = "0x4F2FC50", VA = "0x184F31050")]
		public static BinaryExpression LeftShiftAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
		{
			return null;
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x4F386E0", Offset = "0x4F372E0", VA = "0x184F386E0")]
		public static BinaryExpression RightShift(Expression left, Expression right, MethodInfo method)
		{
			return null;
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x4F38430", Offset = "0x4F37030", VA = "0x184F38430")]
		public static BinaryExpression RightShiftAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
		{
			return null;
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x4F294D0", Offset = "0x4F280D0", VA = "0x184F294D0")]
		public static BinaryExpression And(Expression left, Expression right, MethodInfo method)
		{
			return null;
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x4F291F0", Offset = "0x4F27DF0", VA = "0x184F291F0")]
		public static BinaryExpression AndAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
		{
			return null;
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x4F368E0", Offset = "0x4F354E0", VA = "0x184F368E0")]
		public static BinaryExpression Or(Expression left, Expression right, MethodInfo method)
		{
			return null;
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x4F35EA0", Offset = "0x4F34AA0", VA = "0x184F35EA0")]
		public static BinaryExpression OrAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
		{
			return null;
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x4F2C4C0", Offset = "0x4F2B0C0", VA = "0x184F2C4C0")]
		public static BinaryExpression ExclusiveOr(Expression left, Expression right, MethodInfo method)
		{
			return null;
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x4F2C1E0", Offset = "0x4F2ADE0", VA = "0x184F2C1E0")]
		public static BinaryExpression ExclusiveOrAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
		{
			return null;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x4F36F50", Offset = "0x4F35B50", VA = "0x184F36F50")]
		public static BinaryExpression Power(Expression left, Expression right, MethodInfo method)
		{
			return null;
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x4F36DB0", Offset = "0x4F359B0", VA = "0x184F36DB0")]
		public static BinaryExpression PowerAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
		{
			return null;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x4F29B90", Offset = "0x4F28790", VA = "0x184F29B90")]
		public static BinaryExpression ArrayIndex(Expression array, Expression index)
		{
			return null;
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x4F2A6C0", Offset = "0x4F292C0", VA = "0x184F2A6C0")]
		public static BlockExpression Block(IEnumerable<ParameterExpression> variables, IEnumerable<Expression> expressions)
		{
			return null;
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x4F2A2D0", Offset = "0x4F28ED0", VA = "0x184F2A2D0")]
		private static BlockExpression BlockCore(Type type, ReadOnlyCollection<ParameterExpression> variables, ReadOnlyCollection<Expression> expressions)
		{
			return null;
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x4F3C270", Offset = "0x4F3AE70", VA = "0x184F3C270")]
		internal static void ValidateVariables(ReadOnlyCollection<ParameterExpression> varList, string collectionName)
		{
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x4F2E5C0", Offset = "0x4F2D1C0", VA = "0x184F2E5C0")]
		private static BlockExpression GetOptimizedBlockExpression(IReadOnlyList<Expression> expressions)
		{
			return null;
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected Expression()
		{
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x00002748 File Offset: 0x00000948
		[Token(Token = "0x17000042")]
		public virtual ExpressionType NodeType
		{
			[Token(Token = "0x60001C1")]
			[Address(RVA = "0x4F3CA00", Offset = "0x4F3B600", VA = "0x184F3CA00", Slot = "4")]
			get
			{
				return ExpressionType.Add;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000043")]
		public virtual Type Type
		{
			[Token(Token = "0x60001C2")]
			[Address(RVA = "0x4F3CAF0", Offset = "0x4F3B6F0", VA = "0x184F3CAF0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060001C3 RID: 451 RVA: 0x00002760 File Offset: 0x00000960
		[Token(Token = "0x17000044")]
		public virtual bool CanReduce
		{
			[Token(Token = "0x60001C3")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x4F37C20", Offset = "0x4F36820", VA = "0x184F37C20", Slot = "7")]
		public virtual Expression Reduce()
		{
			return null;
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x4F3C770", Offset = "0x4F3B370", VA = "0x184F3C770", Slot = "8")]
		protected internal virtual Expression VisitChildren(ExpressionVisitor visitor)
		{
			return null;
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x4F27FB0", Offset = "0x4F26BB0", VA = "0x184F27FB0", Slot = "9")]
		protected internal virtual Expression Accept(ExpressionVisitor visitor)
		{
			return null;
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x4F37AC0", Offset = "0x4F366C0", VA = "0x184F37AC0")]
		public Expression ReduceAndCheck()
		{
			return null;
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x4F39590", Offset = "0x4F38190", VA = "0x184F39590", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x4F37FE0", Offset = "0x4F36BE0", VA = "0x184F37FE0")]
		private static void RequiresCanRead(IReadOnlyList<Expression> items, string paramName)
		{
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x4F38120", Offset = "0x4F36D20", VA = "0x184F38120")]
		private static void RequiresCanWrite(Expression expression, string paramName)
		{
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x4F32890", Offset = "0x4F31490", VA = "0x184F32890")]
		public static IndexExpression MakeIndex(Expression instance, PropertyInfo indexer, IEnumerable<Expression> arguments)
		{
			return null;
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x4F29750", Offset = "0x4F28350", VA = "0x184F29750")]
		public static IndexExpression ArrayAccess(Expression array, IEnumerable<Expression> indexes)
		{
			return null;
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x4F37820", Offset = "0x4F36420", VA = "0x184F37820")]
		public static IndexExpression Property(Expression instance, PropertyInfo indexer, IEnumerable<Expression> arguments)
		{
			return null;
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x4F327C0", Offset = "0x4F313C0", VA = "0x184F327C0")]
		private static IndexExpression MakeIndexProperty(Expression instance, PropertyInfo indexer, string paramName, ReadOnlyCollection<Expression> argList)
		{
			return null;
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x4F3A540", Offset = "0x4F39140", VA = "0x184F3A540")]
		private static void ValidateIndexedProperty(Expression instance, PropertyInfo indexer, string paramName, ref ReadOnlyCollection<Expression> argList)
		{
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x4F39FE0", Offset = "0x4F38BE0", VA = "0x184F39FE0")]
		private static void ValidateAccessor(Expression instance, MethodInfo method, ParameterInfo[] indexes, ref ReadOnlyCollection<Expression> arguments, string paramName)
		{
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x4F39B10", Offset = "0x4F38710", VA = "0x184F39B10")]
		private static void ValidateAccessorArgumentTypes(MethodInfo method, ParameterInfo[] indexes, ref ReadOnlyCollection<Expression> arguments, string paramName)
		{
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x4F30550", Offset = "0x4F2F150", VA = "0x184F30550")]
		internal static InvocationExpression Invoke(Expression expression, Expression arg0)
		{
			return null;
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x4F2D110", Offset = "0x4F2BD10", VA = "0x184F2D110")]
		internal static MethodInfo GetInvokeMethod(Expression expression)
		{
			return null;
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x4F2B3E0", Offset = "0x4F29FE0", VA = "0x184F2B3E0")]
		internal static LambdaExpression CreateLambda(Type delegateType, Expression body, string name, bool tailCall, ReadOnlyCollection<ParameterExpression> parameters)
		{
			return null;
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D5")]
		public static Expression<TDelegate> Lambda<TDelegate>(Expression body, params ParameterExpression[] parameters)
		{
			return null;
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D6")]
		public static Expression<TDelegate> Lambda<TDelegate>(Expression body, bool tailCall, IEnumerable<ParameterExpression> parameters)
		{
			return null;
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D7")]
		public static Expression<TDelegate> Lambda<TDelegate>(Expression body, string name, bool tailCall, IEnumerable<ParameterExpression> parameters)
		{
			return null;
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x4F3ABF0", Offset = "0x4F397F0", VA = "0x184F3ABF0")]
		private static void ValidateLambdaArgs(Type delegateType, ref Expression body, ReadOnlyCollection<ParameterExpression> parameters, string paramName)
		{
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x4F2C740", Offset = "0x4F2B340", VA = "0x184F2C740")]
		public static MemberExpression Field(Expression expression, FieldInfo field)
		{
			return null;
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x4F374A0", Offset = "0x4F360A0", VA = "0x184F374A0")]
		public static MemberExpression Property(Expression expression, PropertyInfo property)
		{
			return null;
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x4F32A30", Offset = "0x4F31630", VA = "0x184F32A30")]
		public static MemberExpression MakeMemberAccess(Expression expression, MemberInfo member)
		{
			return null;
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x4F3A2F0", Offset = "0x4F38EF0", VA = "0x184F3A2F0")]
		private static void ValidateCallInstanceType(Type instanceType, MethodInfo method)
		{
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x4F2EAB0", Offset = "0x4F2D6B0", VA = "0x184F2EAB0")]
		private static ParameterInfo[] GetParametersForValidation(MethodBase method, ExpressionType nodeKind)
		{
			return null;
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x4F3A2E0", Offset = "0x4F38EE0", VA = "0x184F3A2E0")]
		private static void ValidateArgumentCount(MethodBase method, ExpressionType nodeKind, int count, ParameterInfo[] pis)
		{
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x4F3B390", Offset = "0x4F39F90", VA = "0x184F3B390")]
		private static Expression ValidateOneArgument(MethodBase method, ExpressionType nodeKind, Expression arg, ParameterInfo pi, string methodParamName, string argumentParamName)
		{
			return null;
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00002778 File Offset: 0x00000978
		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x4F395A0", Offset = "0x4F381A0", VA = "0x184F395A0")]
		private static bool TryQuote(Type parameterType, ref Expression argument)
		{
			return default(bool);
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x4F36C30", Offset = "0x4F35830", VA = "0x184F36C30")]
		public static ParameterExpression Parameter(Type type, string name)
		{
			return null;
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x4F3C530", Offset = "0x4F3B130", VA = "0x184F3C530")]
		public static ParameterExpression Variable(Type type, string name)
		{
			return null;
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x4F3C420", Offset = "0x4F3B020", VA = "0x184F3C420")]
		private static void Validate(Type type, bool allowByRef)
		{
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x4F33420", Offset = "0x4F32020", VA = "0x184F33420")]
		public static UnaryExpression MakeUnary(ExpressionType unaryType, Expression operand, Type type, MethodInfo method)
		{
			return null;
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x4F2FBF0", Offset = "0x4F2E7F0", VA = "0x184F2FBF0")]
		private static UnaryExpression GetUserDefinedUnaryOperatorOrThrow(ExpressionType unaryType, string name, Expression operand)
		{
			return null;
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x4F2FDC0", Offset = "0x4F2E9C0", VA = "0x184F2FDC0")]
		private static UnaryExpression GetUserDefinedUnaryOperator(ExpressionType unaryType, string name, Expression operand)
		{
			return null;
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x4F2E150", Offset = "0x4F2CD50", VA = "0x184F2E150")]
		private static UnaryExpression GetMethodBasedUnaryOperator(ExpressionType unaryType, Expression operand, MethodInfo method)
		{
			return null;
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x4F2F960", Offset = "0x4F2E560", VA = "0x184F2F960")]
		private static UnaryExpression GetUserDefinedCoercionOrThrow(ExpressionType coercionType, Expression expression, Type convertToType)
		{
			return null;
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x4F2FAE0", Offset = "0x4F2E6E0", VA = "0x184F2FAE0")]
		private static UnaryExpression GetUserDefinedCoercion(ExpressionType coercionType, Expression expression, Type convertToType)
		{
			return null;
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x4F2DD40", Offset = "0x4F2C940", VA = "0x184F2DD40")]
		private static UnaryExpression GetMethodBasedCoercionOperator(ExpressionType unaryType, Expression operand, Type convertToType, MethodInfo method)
		{
			return null;
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x4F357D0", Offset = "0x4F343D0", VA = "0x184F357D0")]
		public static UnaryExpression Negate(Expression expression, MethodInfo method)
		{
			return null;
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x4F39710", Offset = "0x4F38310", VA = "0x184F39710")]
		public static UnaryExpression UnaryPlus(Expression expression, MethodInfo method)
		{
			return null;
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x4F355E0", Offset = "0x4F341E0", VA = "0x184F355E0")]
		public static UnaryExpression NegateChecked(Expression expression, MethodInfo method)
		{
			return null;
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x4F35AE0", Offset = "0x4F346E0", VA = "0x184F35AE0")]
		public static UnaryExpression Not(Expression expression, MethodInfo method)
		{
			return null;
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x4F306F0", Offset = "0x4F2F2F0", VA = "0x184F306F0")]
		public static UnaryExpression IsFalse(Expression expression, MethodInfo method)
		{
			return null;
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x4F30D60", Offset = "0x4F2F960", VA = "0x184F30D60")]
		public static UnaryExpression IsTrue(Expression expression, MethodInfo method)
		{
			return null;
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x4F35CE0", Offset = "0x4F348E0", VA = "0x184F35CE0")]
		public static UnaryExpression OnesComplement(Expression expression, MethodInfo method)
		{
			return null;
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x4F395B0", Offset = "0x4F381B0", VA = "0x184F395B0")]
		public static UnaryExpression TypeAs(Expression expression, Type type)
		{
			return null;
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x4F398D0", Offset = "0x4F384D0", VA = "0x184F398D0")]
		public static UnaryExpression Unbox(Expression expression, Type type)
		{
			return null;
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x4F2B1B0", Offset = "0x4F29DB0", VA = "0x184F2B1B0")]
		public static UnaryExpression Convert(Expression expression, Type type, MethodInfo method)
		{
			return null;
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x4F2AF50", Offset = "0x4F29B50", VA = "0x184F2AF50")]
		public static UnaryExpression ConvertChecked(Expression expression, Type type, MethodInfo method)
		{
			return null;
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x4F29DF0", Offset = "0x4F289F0", VA = "0x184F29DF0")]
		public static UnaryExpression ArrayLength(Expression array)
		{
			return null;
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x4F37950", Offset = "0x4F36550", VA = "0x184F37950")]
		public static UnaryExpression Quote(Expression expression)
		{
			return null;
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x4F39430", Offset = "0x4F38030", VA = "0x184F39430")]
		public static UnaryExpression Throw(Expression value, Type type)
		{
			return null;
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x4F30390", Offset = "0x4F2EF90", VA = "0x184F30390")]
		public static UnaryExpression Increment(Expression expression, MethodInfo method)
		{
			return null;
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x4F2B9A0", Offset = "0x4F2A5A0", VA = "0x184F2B9A0")]
		public static UnaryExpression Decrement(Expression expression, MethodInfo method)
		{
			return null;
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x4F37440", Offset = "0x4F36040", VA = "0x184F37440")]
		public static UnaryExpression PreIncrementAssign(Expression expression, MethodInfo method)
		{
			return null;
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x4F373E0", Offset = "0x4F35FE0", VA = "0x184F373E0")]
		public static UnaryExpression PreDecrementAssign(Expression expression, MethodInfo method)
		{
			return null;
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x4F36D50", Offset = "0x4F35950", VA = "0x184F36D50")]
		public static UnaryExpression PostIncrementAssign(Expression expression, MethodInfo method)
		{
			return null;
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x4F36CF0", Offset = "0x4F358F0", VA = "0x184F36CF0")]
		public static UnaryExpression PostDecrementAssign(Expression expression, MethodInfo method)
		{
			return null;
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x4F33130", Offset = "0x4F31D30", VA = "0x184F33130")]
		private static UnaryExpression MakeOpAssignUnary(ExpressionType kind, Expression expression, MethodInfo method)
		{
			return null;
		}

		// Token: 0x040000D1 RID: 209
		[Token(Token = "0x40000D1")]
		[FieldOffset(Offset = "0x0")]
		private static readonly CacheDict<Type, MethodInfo> s_lambdaDelegateCache;

		// Token: 0x040000D2 RID: 210
		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0x8")]
		private static CacheDict<Type, Func<Expression, string, bool, ReadOnlyCollection<ParameterExpression>, LambdaExpression>> s_lambdaFactories;

		// Token: 0x040000D3 RID: 211
		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0x10")]
		private static ConditionalWeakTable<Expression, Expression.ExtensionInfo> s_legacyCtorSupportTable;

		// Token: 0x02000038 RID: 56
		[Token(Token = "0x2000038")]
		internal class BinaryExpressionProxy
		{
		}

		// Token: 0x02000039 RID: 57
		[Token(Token = "0x2000039")]
		internal class BlockExpressionProxy
		{
		}

		// Token: 0x0200003A RID: 58
		[Token(Token = "0x200003A")]
		internal class ConstantExpressionProxy
		{
		}

		// Token: 0x0200003B RID: 59
		[Token(Token = "0x200003B")]
		internal class IndexExpressionProxy
		{
		}

		// Token: 0x0200003C RID: 60
		[Token(Token = "0x200003C")]
		internal class InvocationExpressionProxy
		{
		}

		// Token: 0x0200003D RID: 61
		[Token(Token = "0x200003D")]
		internal class LambdaExpressionProxy
		{
		}

		// Token: 0x0200003E RID: 62
		[Token(Token = "0x200003E")]
		internal class MemberExpressionProxy
		{
		}

		// Token: 0x0200003F RID: 63
		[Token(Token = "0x200003F")]
		internal class ParameterExpressionProxy
		{
		}

		// Token: 0x02000040 RID: 64
		[Token(Token = "0x2000040")]
		internal class UnaryExpressionProxy
		{
		}

		// Token: 0x02000041 RID: 65
		[Token(Token = "0x2000041")]
		private class ExtensionInfo
		{
			// Token: 0x040000D4 RID: 212
			[Token(Token = "0x40000D4")]
			[FieldOffset(Offset = "0x10")]
			internal readonly ExpressionType NodeType;

			// Token: 0x040000D5 RID: 213
			[Token(Token = "0x40000D5")]
			[FieldOffset(Offset = "0x18")]
			internal readonly Type Type;
		}
	}
}
