using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Mono
{
	// Token: 0x0200003E RID: 62
	[Token(Token = "0x200003E")]
	internal struct MonoAssemblyName
	{
		// Token: 0x04000124 RID: 292
		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0x0")]
		internal System.IntPtr name;

		// Token: 0x04000125 RID: 293
		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0x8")]
		internal System.IntPtr culture;

		// Token: 0x04000126 RID: 294
		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0x10")]
		internal System.IntPtr hash_value;

		// Token: 0x04000127 RID: 295
		[Token(Token = "0x4000127")]
		[FieldOffset(Offset = "0x18")]
		internal System.IntPtr public_key;

		// Token: 0x04000128 RID: 296
		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x20")]
		[System.Runtime.CompilerServices.FixedBuffer(typeof(byte), 17)]
		internal MonoAssemblyName.<public_key_token>e__FixedBuffer public_key_token;

		// Token: 0x04000129 RID: 297
		[Token(Token = "0x4000129")]
		[FieldOffset(Offset = "0x34")]
		internal uint hash_alg;

		// Token: 0x0400012A RID: 298
		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0x38")]
		internal uint hash_len;

		// Token: 0x0400012B RID: 299
		[Token(Token = "0x400012B")]
		[FieldOffset(Offset = "0x3C")]
		internal uint flags;

		// Token: 0x0400012C RID: 300
		[Token(Token = "0x400012C")]
		[FieldOffset(Offset = "0x40")]
		internal ushort major;

		// Token: 0x0400012D RID: 301
		[Token(Token = "0x400012D")]
		[FieldOffset(Offset = "0x42")]
		internal ushort minor;

		// Token: 0x0400012E RID: 302
		[Token(Token = "0x400012E")]
		[FieldOffset(Offset = "0x44")]
		internal ushort build;

		// Token: 0x0400012F RID: 303
		[Token(Token = "0x400012F")]
		[FieldOffset(Offset = "0x46")]
		internal ushort revision;

		// Token: 0x04000130 RID: 304
		[Token(Token = "0x4000130")]
		[FieldOffset(Offset = "0x48")]
		internal ushort arch;

		// Token: 0x0200003F RID: 63
		[Token(Token = "0x200003F")]
		[System.Runtime.CompilerServices.UnsafeValueType]
		[System.Runtime.CompilerServices.CompilerGenerated]
		public struct <public_key_token>e__FixedBuffer
		{
			// Token: 0x04000131 RID: 305
			[Token(Token = "0x4000131")]
			[FieldOffset(Offset = "0x0")]
			public byte FixedElementField;
		}
	}
}
