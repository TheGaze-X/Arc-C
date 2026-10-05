using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Cooperate
{
	// Token: 0x020026EB RID: 9963
	[Token(Token = "0x20026EB")]
	[Serializable]
	public class CooperateEndTileInfo : IHotfixable
	{
		// Token: 0x06010319 RID: 66329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010319")]
		[Address(RVA = "0x7E4DF0", Offset = "0x7E39F0", VA = "0x1807E4DF0")]
		public CooperateEndTileInfo()
		{
		}

		// Token: 0x040121A0 RID: 74144
		[Token(Token = "0x40121A0")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x040121A1 RID: 74145
		[Token(Token = "0x40121A1")]
		[FieldOffset(Offset = "0x18")]
		public string description;

		// Token: 0x040121A2 RID: 74146
		[Token(Token = "0x40121A2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
