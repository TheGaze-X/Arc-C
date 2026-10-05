using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act1Lock.BattleFinish
{
	// Token: 0x020078F3 RID: 30963
	[Token(Token = "0x20078F3")]
	public class FinalStageEnemyKillPointModel : IHotfixable
	{
		// Token: 0x0602B6B7 RID: 177847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B6B7")]
		[Address(RVA = "0x275AD80", Offset = "0x2759980", VA = "0x18275AD80")]
		public FinalStageEnemyKillPointModel()
		{
		}

		// Token: 0x0403EC94 RID: 257172
		[Token(Token = "0x403EC94")]
		[FieldOffset(Offset = "0x10")]
		public bool isSuc;

		// Token: 0x0403EC95 RID: 257173
		[Token(Token = "0x403EC95")]
		[FieldOffset(Offset = "0x11")]
		public bool isFail;

		// Token: 0x0403EC96 RID: 257174
		[Token(Token = "0x403EC96")]
		[FieldOffset(Offset = "0x12")]
		public bool isNoInfo;

		// Token: 0x0403EC97 RID: 257175
		[Token(Token = "0x403EC97")]
		[FieldOffset(Offset = "0x14")]
		public int point;

		// Token: 0x0403EC98 RID: 257176
		[Token(Token = "0x403EC98")]
		[FieldOffset(Offset = "0x18")]
		public string enemyKey;

		// Token: 0x0403EC99 RID: 257177
		[Token(Token = "0x403EC99")]
		[FieldOffset(Offset = "0x20")]
		public string enemyName;

		// Token: 0x0403EC9A RID: 257178
		[Token(Token = "0x403EC9A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
