using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000188 RID: 392
	[Token(Token = "0x2000188")]
	[AttributeUsage(AttributeTargets.Struct, AllowMultiple = false)]
	internal class CallbackIdentityAttribute : Attribute
	{
		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060008EE RID: 2286 RVA: 0x00007DFC File Offset: 0x00005FFC
		// (set) Token: 0x060008EF RID: 2287 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x17000025")]
		public int Identity
		{
			[Token(Token = "0x60008EE")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60008EF")]
			[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60008F0")]
		[Address(RVA = "0x1FF21E0", Offset = "0x1FF0DE0", VA = "0x181FF21E0")]
		public CallbackIdentityAttribute(int callbackNum)
		{
		}
	}
}
