using System;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace UnityEngine.Assertions
{
	// Token: 0x020002BC RID: 700
	[Token(Token = "0x20002BC")]
	[DebuggerStepThrough]
	public static class Assert
	{
		// Token: 0x06000FBE RID: 4030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FBE")]
		[Address(RVA = "0x5979860", Offset = "0x5978460", VA = "0x185979860")]
		private static void Fail(string message, string userMessage)
		{
		}

		// Token: 0x06000FBF RID: 4031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FBF")]
		[Address(RVA = "0x5979CA0", Offset = "0x59788A0", VA = "0x185979CA0")]
		[Conditional("UNITY_ASSERTIONS")]
		public static void IsTrue(bool condition)
		{
		}

		// Token: 0x06000FC0 RID: 4032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FC0")]
		[Address(RVA = "0x5979BB0", Offset = "0x59787B0", VA = "0x185979BB0")]
		[Conditional("UNITY_ASSERTIONS")]
		public static void IsTrue(bool condition, string message)
		{
		}

		// Token: 0x06000FC1 RID: 4033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FC1")]
		[Address(RVA = "0x5979980", Offset = "0x5978580", VA = "0x185979980")]
		[Conditional("UNITY_ASSERTIONS")]
		public static void IsFalse(bool condition, string message)
		{
		}

		// Token: 0x06000FC2 RID: 4034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FC2")]
		[Conditional("UNITY_ASSERTIONS")]
		public static void AreEqual<T>(T expected, T actual)
		{
		}

		// Token: 0x06000FC3 RID: 4035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FC3")]
		[Conditional("UNITY_ASSERTIONS")]
		public static void AreEqual<T>(T expected, T actual, string message)
		{
		}

		// Token: 0x06000FC4 RID: 4036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FC4")]
		[Conditional("UNITY_ASSERTIONS")]
		public static void AreEqual<T>(T expected, T actual, string message, IEqualityComparer<T> comparer)
		{
		}

		// Token: 0x06000FC5 RID: 4037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FC5")]
		[Address(RVA = "0x5979700", Offset = "0x5978300", VA = "0x185979700")]
		[Conditional("UNITY_ASSERTIONS")]
		public static void AreEqual(Object expected, Object actual, string message)
		{
		}

		// Token: 0x06000FC6 RID: 4038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FC6")]
		[Conditional("UNITY_ASSERTIONS")]
		public static void AreNotEqual<T>(T expected, T actual)
		{
		}

		// Token: 0x06000FC7 RID: 4039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FC7")]
		[Conditional("UNITY_ASSERTIONS")]
		public static void AreNotEqual<T>(T expected, T actual, string message)
		{
		}

		// Token: 0x06000FC8 RID: 4040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FC8")]
		[Conditional("UNITY_ASSERTIONS")]
		public static void AreNotEqual<T>(T expected, T actual, string message, IEqualityComparer<T> comparer)
		{
		}

		// Token: 0x06000FC9 RID: 4041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FC9")]
		[Address(RVA = "0x59797B0", Offset = "0x59783B0", VA = "0x1859797B0")]
		[Conditional("UNITY_ASSERTIONS")]
		public static void AreNotEqual(Object expected, Object actual, string message)
		{
		}

		// Token: 0x06000FCA RID: 4042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FCA")]
		[Conditional("UNITY_ASSERTIONS")]
		public static void IsNull<T>(T value) where T : class
		{
		}

		// Token: 0x06000FCB RID: 4043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FCB")]
		[Conditional("UNITY_ASSERTIONS")]
		public static void IsNull<T>(T value, string message) where T : class
		{
		}

		// Token: 0x06000FCC RID: 4044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FCC")]
		[Address(RVA = "0x5979B10", Offset = "0x5978710", VA = "0x185979B10")]
		[Conditional("UNITY_ASSERTIONS")]
		public static void IsNull(Object value, string message)
		{
		}

		// Token: 0x06000FCD RID: 4045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FCD")]
		[Conditional("UNITY_ASSERTIONS")]
		public static void IsNotNull<T>(T value) where T : class
		{
		}

		// Token: 0x06000FCE RID: 4046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FCE")]
		[Conditional("UNITY_ASSERTIONS")]
		public static void IsNotNull<T>(T value, string message) where T : class
		{
		}

		// Token: 0x06000FCF RID: 4047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FCF")]
		[Address(RVA = "0x5979A70", Offset = "0x5978670", VA = "0x185979A70")]
		[Conditional("UNITY_ASSERTIONS")]
		public static void IsNotNull(Object value, string message)
		{
		}

		// Token: 0x06000FD0 RID: 4048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FD0")]
		[Address(RVA = "0x5979690", Offset = "0x5978290", VA = "0x185979690")]
		[Conditional("UNITY_ASSERTIONS")]
		public static void AreEqual(int expected, int actual)
		{
		}

		// Token: 0x0400093D RID: 2365
		[Token(Token = "0x400093D")]
		[FieldOffset(Offset = "0x0")]
		[Obsolete("Future versions of Unity are expected to always throw exceptions and not have this field.")]
		public static bool raiseExceptions;
	}
}
