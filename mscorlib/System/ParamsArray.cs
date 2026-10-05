using System;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x02000120 RID: 288
	[Token(Token = "0x2000120")]
	internal readonly struct ParamsArray
	{
		// Token: 0x06000995 RID: 2453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000995")]
		[Address(RVA = "0x4CECAA0", Offset = "0x4CEB6A0", VA = "0x184CECAA0")]
		public ParamsArray(object arg0)
		{
		}

		// Token: 0x06000996 RID: 2454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000996")]
		[Address(RVA = "0x4CECC00", Offset = "0x4CEB800", VA = "0x184CECC00")]
		public ParamsArray(object arg0, object arg1)
		{
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000997")]
		[Address(RVA = "0x4CECB40", Offset = "0x4CEB740", VA = "0x184CECB40")]
		public ParamsArray(object arg0, object arg1, object arg2)
		{
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000998")]
		[Address(RVA = "0x4CEC9E0", Offset = "0x4CEB5E0", VA = "0x184CEC9E0")]
		public ParamsArray(object[] args)
		{
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000999 RID: 2457 RVA: 0x00009528 File Offset: 0x00007728
		[Token(Token = "0x170000A7")]
		public int Length
		{
			[Token(Token = "0x6000999")]
			[Address(RVA = "0x4BA9410", Offset = "0x4BA8010", VA = "0x184BA9410")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000A8 RID: 168
		[Token(Token = "0x170000A8")]
		public object this[int index]
		{
			[Token(Token = "0x600099A")]
			[Address(RVA = "0x4CECCB0", Offset = "0x4CEB8B0", VA = "0x184CECCB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600099B")]
		[Address(RVA = "0x4CEC8A0", Offset = "0x4CEB4A0", VA = "0x184CEC8A0")]
		private object GetAtSlow(int index)
		{
			return null;
		}

		// Token: 0x04000473 RID: 1139
		[Token(Token = "0x4000473")]
		[FieldOffset(Offset = "0x0")]
		private static readonly object[] s_oneArgArray;

		// Token: 0x04000474 RID: 1140
		[Token(Token = "0x4000474")]
		[FieldOffset(Offset = "0x8")]
		private static readonly object[] s_twoArgArray;

		// Token: 0x04000475 RID: 1141
		[Token(Token = "0x4000475")]
		[FieldOffset(Offset = "0x10")]
		private static readonly object[] s_threeArgArray;

		// Token: 0x04000476 RID: 1142
		[Token(Token = "0x4000476")]
		[FieldOffset(Offset = "0x0")]
		private readonly object _arg0;

		// Token: 0x04000477 RID: 1143
		[Token(Token = "0x4000477")]
		[FieldOffset(Offset = "0x8")]
		private readonly object _arg1;

		// Token: 0x04000478 RID: 1144
		[Token(Token = "0x4000478")]
		[FieldOffset(Offset = "0x10")]
		private readonly object _arg2;

		// Token: 0x04000479 RID: 1145
		[Token(Token = "0x4000479")]
		[FieldOffset(Offset = "0x18")]
		private readonly object[] _args;
	}
}
