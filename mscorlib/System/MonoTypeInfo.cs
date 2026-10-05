using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x0200019A RID: 410
	[Token(Token = "0x200019A")]
	[StructLayout(0)]
	internal class MonoTypeInfo
	{
		// Token: 0x06000F83 RID: 3971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F83")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public MonoTypeInfo()
		{
		}

		// Token: 0x0400071B RID: 1819
		[Token(Token = "0x400071B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string full_name;

		// Token: 0x0400071C RID: 1820
		[Token(Token = "0x400071C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RuntimeConstructorInfo default_ctor;
	}
}
