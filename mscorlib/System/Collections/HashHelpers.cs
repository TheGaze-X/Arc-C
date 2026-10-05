using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Collections
{
	// Token: 0x020005B8 RID: 1464
	[Token(Token = "0x20005B8")]
	internal static class HashHelpers
	{
		// Token: 0x06002B8A RID: 11146 RVA: 0x00018060 File Offset: 0x00016260
		[Token(Token = "0x6002B8A")]
		[Address(RVA = "0x4C615D0", Offset = "0x4C601D0", VA = "0x184C615D0")]
		public static bool IsPrime(int candidate)
		{
			return default(bool);
		}

		// Token: 0x06002B8B RID: 11147 RVA: 0x00018078 File Offset: 0x00016278
		[Token(Token = "0x6002B8B")]
		[Address(RVA = "0x4C613B0", Offset = "0x4C5FFB0", VA = "0x184C613B0")]
		public static int GetPrime(int min)
		{
			return 0;
		}

		// Token: 0x06002B8C RID: 11148 RVA: 0x00018090 File Offset: 0x00016290
		[Token(Token = "0x6002B8C")]
		[Address(RVA = "0x4C61330", Offset = "0x4C5FF30", VA = "0x184C61330")]
		public static int ExpandPrime(int oldSize)
		{
			return 0;
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x06002B8D RID: 11149 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170006B4")]
		internal static System.Runtime.CompilerServices.ConditionalWeakTable<object, System.Runtime.Serialization.SerializationInfo> SerializationInfoTable
		{
			[Token(Token = "0x6002B8D")]
			[Address(RVA = "0x4C61710", Offset = "0x4C60310", VA = "0x184C61710")]
			get
			{
				return null;
			}
		}

		// Token: 0x04001977 RID: 6519
		[Token(Token = "0x4001977")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int[] primes;

		// Token: 0x04001978 RID: 6520
		[Token(Token = "0x4001978")]
		[FieldOffset(Offset = "0x8")]
		private static System.Runtime.CompilerServices.ConditionalWeakTable<object, System.Runtime.Serialization.SerializationInfo> s_serializationInfoTable;
	}
}
