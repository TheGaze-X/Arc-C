using System;
using Il2CppDummyDll;

namespace Mono
{
	// Token: 0x0200002E RID: 46
	[Token(Token = "0x200002E")]
	internal static class DependencyInjector
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000051 RID: 81 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000003")]
		internal static ISystemDependencyProvider SystemProvider
		{
			[Token(Token = "0x6000051")]
			[Address(RVA = "0x4AAAC10", Offset = "0x4AA9810", VA = "0x184AAAC10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x4AAAA00", Offset = "0x4AA9600", VA = "0x184AAAA00")]
		internal static void Register(ISystemDependencyProvider provider)
		{
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x4AAA8C0", Offset = "0x4AA94C0", VA = "0x184AAA8C0")]
		private static ISystemDependencyProvider ReflectionLoad()
		{
			return null;
		}

		// Token: 0x0400010F RID: 271
		[Token(Token = "0x400010F")]
		[FieldOffset(Offset = "0x0")]
		private static object locker;

		// Token: 0x04000110 RID: 272
		[Token(Token = "0x4000110")]
		[FieldOffset(Offset = "0x8")]
		private static ISystemDependencyProvider systemDependency;
	}
}
