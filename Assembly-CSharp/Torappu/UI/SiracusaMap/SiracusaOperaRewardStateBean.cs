using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F3D RID: 16189
	[Token(Token = "0x2003F3D")]
	public class SiracusaOperaRewardStateBean : IStateBean, IHotfixable
	{
		// Token: 0x06019249 RID: 102985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019249")]
		[Address(RVA = "0x11DCD70", Offset = "0x11DB970", VA = "0x1811DCD70")]
		public SiracusaOperaRewardStateBean()
		{
		}

		// Token: 0x0401F258 RID: 127576
		[Token(Token = "0x401F258")]
		[FieldOffset(Offset = "0x10")]
		public string charId;

		// Token: 0x0401F259 RID: 127577
		[Token(Token = "0x401F259")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
