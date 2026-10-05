using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Firework.FireworkPuzzle
{
	// Token: 0x02004E60 RID: 20064
	[Token(Token = "0x2004E60")]
	public class FireworkPuzzleMapStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0601DF15 RID: 122645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF15")]
		[Address(RVA = "0x17A9A00", Offset = "0x17A8600", VA = "0x1817A9A00")]
		public FireworkPuzzleMapStateBean()
		{
		}

		// Token: 0x04027C0A RID: 162826
		[Token(Token = "0x4027C0A")]
		[FieldOffset(Offset = "0x10")]
		public FireworkPuzzleMapProperty mapProperty;

		// Token: 0x04027C0B RID: 162827
		[Token(Token = "0x4027C0B")]
		[FieldOffset(Offset = "0x18")]
		public string toDetailStatePuzzleId;

		// Token: 0x04027C0C RID: 162828
		[Token(Token = "0x4027C0C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
