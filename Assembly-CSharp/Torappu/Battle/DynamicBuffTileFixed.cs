using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200239A RID: 9114
	[Token(Token = "0x200239A")]
	public class DynamicBuffTileFixed : DynamicBuffTile
	{
		// Token: 0x0600E72A RID: 59178 RVA: 0x00054318 File Offset: 0x00052518
		[Token(Token = "0x600E72A")]
		[Address(RVA = "0x5CFC20", Offset = "0x5CE820", VA = "0x1805CFC20", Slot = "49")]
		public override bool SwitchMode(int modeIndex)
		{
			return default(bool);
		}

		// Token: 0x0600E72B RID: 59179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E72B")]
		[Address(RVA = "0x5CFF80", Offset = "0x5CEB80", VA = "0x1805CFF80")]
		public DynamicBuffTileFixed()
		{
		}

		// Token: 0x0600E72C RID: 59180 RVA: 0x00054330 File Offset: 0x00052530
		[Token(Token = "0x600E72C")]
		[Address(RVA = "0x5CFF70", Offset = "0x5CEB70", VA = "0x1805CFF70")]
		private bool <>xLuaBaseProxy_SwitchMode(int P0)
		{
			return default(bool);
		}

		// Token: 0x0400FE9B RID: 65179
		[Token(Token = "0x400FE9B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SwitchMode;

		// Token: 0x0400FE9C RID: 65180
		[Token(Token = "0x400FE9C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
