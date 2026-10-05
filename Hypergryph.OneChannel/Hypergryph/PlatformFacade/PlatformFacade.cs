using System;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Hypergryph.PlatformFacade
{
	// Token: 0x0200009D RID: 157
	[Token(Token = "0x200009D")]
	public class PlatformFacade
	{
		// Token: 0x060002E6 RID: 742 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public static void SetupPlatformFont(IPlatformFont iFont)
		{
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x4A2BAD0", Offset = "0x4A2A6D0", VA = "0x184A2BAD0")]
		public static Task<PSNAuthInfo> GetPSNAuthInfo()
		{
			return null;
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlatformFacade()
		{
		}
	}
}
