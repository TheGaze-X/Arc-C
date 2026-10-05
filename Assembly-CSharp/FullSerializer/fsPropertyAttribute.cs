using System;
using Il2CppDummyDll;

namespace FullSerializer
{
	// Token: 0x02007B7A RID: 31610
	[Token(Token = "0x2007B7A")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public sealed class fsPropertyAttribute : Attribute
	{
		// Token: 0x0602C3DB RID: 181211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C3DB")]
		[Address(RVA = "0x2835080", Offset = "0x2833C80", VA = "0x182835080")]
		public fsPropertyAttribute()
		{
		}

		// Token: 0x0602C3DC RID: 181212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C3DC")]
		[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
		public fsPropertyAttribute(string name)
		{
		}

		// Token: 0x040401B3 RID: 262579
		[Token(Token = "0x40401B3")]
		[FieldOffset(Offset = "0x10")]
		public string Name;

		// Token: 0x040401B4 RID: 262580
		[Token(Token = "0x40401B4")]
		[FieldOffset(Offset = "0x18")]
		public Type Converter;
	}
}
