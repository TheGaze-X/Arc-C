using System;
using Il2CppDummyDll;

namespace Mono
{
	// Token: 0x02000039 RID: 57
	[Token(Token = "0x2000039")]
	internal static class RuntimeStructs
	{
		// Token: 0x0200003A RID: 58
		[Token(Token = "0x200003A")]
		internal struct RemoteClass
		{
			// Token: 0x04000118 RID: 280
			[Token(Token = "0x4000118")]
			[FieldOffset(Offset = "0x0")]
			internal System.IntPtr default_vtable;

			// Token: 0x04000119 RID: 281
			[Token(Token = "0x4000119")]
			[FieldOffset(Offset = "0x8")]
			internal System.IntPtr xdomain_vtable;

			// Token: 0x0400011A RID: 282
			[Token(Token = "0x400011A")]
			[FieldOffset(Offset = "0x10")]
			internal unsafe RuntimeStructs.MonoClass* proxy_class;

			// Token: 0x0400011B RID: 283
			[Token(Token = "0x400011B")]
			[FieldOffset(Offset = "0x18")]
			internal System.IntPtr proxy_class_name;

			// Token: 0x0400011C RID: 284
			[Token(Token = "0x400011C")]
			[FieldOffset(Offset = "0x20")]
			internal uint interface_count;
		}

		// Token: 0x0200003B RID: 59
		[Token(Token = "0x200003B")]
		internal struct MonoClass
		{
		}

		// Token: 0x0200003C RID: 60
		[Token(Token = "0x200003C")]
		internal struct GenericParamInfo
		{
			// Token: 0x0400011D RID: 285
			[Token(Token = "0x400011D")]
			[FieldOffset(Offset = "0x0")]
			internal unsafe RuntimeStructs.MonoClass* pklass;

			// Token: 0x0400011E RID: 286
			[Token(Token = "0x400011E")]
			[FieldOffset(Offset = "0x8")]
			internal System.IntPtr name;

			// Token: 0x0400011F RID: 287
			[Token(Token = "0x400011F")]
			[FieldOffset(Offset = "0x10")]
			internal ushort flags;

			// Token: 0x04000120 RID: 288
			[Token(Token = "0x4000120")]
			[FieldOffset(Offset = "0x14")]
			internal uint token;

			// Token: 0x04000121 RID: 289
			[Token(Token = "0x4000121")]
			[FieldOffset(Offset = "0x18")]
			internal unsafe RuntimeStructs.MonoClass** constraints;
		}

		// Token: 0x0200003D RID: 61
		[Token(Token = "0x200003D")]
		internal struct GPtrArray
		{
			// Token: 0x04000122 RID: 290
			[Token(Token = "0x4000122")]
			[FieldOffset(Offset = "0x0")]
			internal unsafe System.IntPtr* data;

			// Token: 0x04000123 RID: 291
			[Token(Token = "0x4000123")]
			[FieldOffset(Offset = "0x8")]
			internal int len;
		}
	}
}
