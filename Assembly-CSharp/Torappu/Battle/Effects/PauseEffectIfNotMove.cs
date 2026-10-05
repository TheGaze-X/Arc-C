using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x02003245 RID: 12869
	[Token(Token = "0x2003245")]
	public class PauseEffectIfNotMove : Effect.Behaviour, IHotfixable
	{
		// Token: 0x0601469B RID: 83611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601469B")]
		[Address(RVA = "0xCA8000", Offset = "0xCA6C00", VA = "0x180CA8000")]
		private void Update()
		{
		}

		// Token: 0x0601469C RID: 83612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601469C")]
		[Address(RVA = "0xCA8170", Offset = "0xCA6D70", VA = "0x180CA8170")]
		public PauseEffectIfNotMove()
		{
		}

		// Token: 0x040181B8 RID: 98744
		[Token(Token = "0x40181B8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x040181B9 RID: 98745
		[Token(Token = "0x40181B9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
