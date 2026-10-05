using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Runtime.Serialization
{
	// Token: 0x0200040D RID: 1037
	[Token(Token = "0x200040D")]
	[System.AttributeUsage(System.AttributeTargets.Field, Inherited = false)]
	[System.Runtime.InteropServices.ComVisible(true)]
	public sealed class OptionalFieldAttribute : System.Attribute
	{
		// Token: 0x0600203C RID: 8252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600203C")]
		[Address(RVA = "0x4BA8C20", Offset = "0x4BA7820", VA = "0x184BA8C20")]
		public OptionalFieldAttribute()
		{
		}

		// Token: 0x17000446 RID: 1094
		// (set) Token: 0x0600203D RID: 8253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000446")]
		public int VersionAdded
		{
			[Token(Token = "0x600203D")]
			[Address(RVA = "0x4BA8C30", Offset = "0x4BA7830", VA = "0x184BA8C30")]
			set
			{
			}
		}

		// Token: 0x040010EF RID: 4335
		[Token(Token = "0x40010EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int versionAdded;
	}
}
