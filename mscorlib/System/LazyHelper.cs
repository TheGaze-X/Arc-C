using System;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Threading;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x02000104 RID: 260
	[Token(Token = "0x2000104")]
	internal class LazyHelper
	{
		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000882 RID: 2178 RVA: 0x00008928 File Offset: 0x00006B28
		[Token(Token = "0x17000098")]
		internal LazyState State
		{
			[Token(Token = "0x6000882")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			[System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return LazyState.NoneViaConstructor;
			}
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000883")]
		[Address(RVA = "0x50EDE0", Offset = "0x50D9E0", VA = "0x18050EDE0")]
		internal LazyHelper(LazyState state)
		{
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000884")]
		[Address(RVA = "0x4CDB480", Offset = "0x4CDA080", VA = "0x184CDB480")]
		internal LazyHelper(System.Threading.LazyThreadSafetyMode mode, System.Exception exception)
		{
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000885")]
		[Address(RVA = "0x4CDB290", Offset = "0x4CD9E90", VA = "0x184CDB290")]
		internal void ThrowException()
		{
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000886")]
		[Address(RVA = "0x4CDB0D0", Offset = "0x4CD9CD0", VA = "0x184CDB0D0")]
		internal static LazyHelper Create(System.Threading.LazyThreadSafetyMode mode, bool useDefaultConstructor)
		{
			return null;
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000887")]
		[Address(RVA = "0x4CDB060", Offset = "0x4CD9C60", VA = "0x184CDB060")]
		internal static object CreateViaDefaultConstructor(System.Type type)
		{
			return null;
		}

		// Token: 0x04000448 RID: 1096
		[Token(Token = "0x4000448")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly LazyHelper NoneViaConstructor;

		// Token: 0x04000449 RID: 1097
		[Token(Token = "0x4000449")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly LazyHelper NoneViaFactory;

		// Token: 0x0400044A RID: 1098
		[Token(Token = "0x400044A")]
		[FieldOffset(Offset = "0x10")]
		internal static readonly LazyHelper PublicationOnlyViaConstructor;

		// Token: 0x0400044B RID: 1099
		[Token(Token = "0x400044B")]
		[FieldOffset(Offset = "0x18")]
		internal static readonly LazyHelper PublicationOnlyViaFactory;

		// Token: 0x0400044C RID: 1100
		[Token(Token = "0x400044C")]
		[FieldOffset(Offset = "0x20")]
		internal static readonly LazyHelper PublicationOnlyWaitForOtherThreadToPublish;

		// Token: 0x0400044E RID: 1102
		[Token(Token = "0x400044E")]
		[FieldOffset(Offset = "0x18")]
		private readonly System.Runtime.ExceptionServices.ExceptionDispatchInfo _exceptionDispatch;
	}
}
