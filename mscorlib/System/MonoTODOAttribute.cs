using System;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x02000170 RID: 368
	[Token(Token = "0x2000170")]
	[System.AttributeUsage(System.AttributeTargets.All, AllowMultiple = true)]
	internal class MonoTODOAttribute : System.Attribute
	{
		// Token: 0x06000D8B RID: 3467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D8B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public MonoTODOAttribute()
		{
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D8C")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		public MonoTODOAttribute(string comment)
		{
		}

		// Token: 0x040005D2 RID: 1490
		[Token(Token = "0x40005D2")]
		[FieldOffset(Offset = "0x10")]
		private string comment;
	}
}
