using System;
using Il2CppDummyDll;
using Torappu.Battle.AutoChess;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x020064BA RID: 25786
	[Token(Token = "0x20064BA")]
	public class AutoChessBattleSpPreparePlayerModel : IHotfixable
	{
		// Token: 0x06025110 RID: 151824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025110")]
		[Address(RVA = "0x1FE1B70", Offset = "0x1FE0770", VA = "0x181FE1B70")]
		public AutoChessBattleSpPreparePlayerModel(PlayerCard playerCard, bool isSelf)
		{
		}

		// Token: 0x04033E6F RID: 212591
		[Token(Token = "0x4033E6F")]
		[FieldOffset(Offset = "0x10")]
		public PlayerAvatarQuery avatarQuery;

		// Token: 0x04033E70 RID: 212592
		[Token(Token = "0x4033E70")]
		[FieldOffset(Offset = "0x28")]
		public bool isSelf;

		// Token: 0x04033E71 RID: 212593
		[Token(Token = "0x4033E71")]
		[FieldOffset(Offset = "0x30")]
		public long lastSelectTime;

		// Token: 0x04033E72 RID: 212594
		[Token(Token = "0x4033E72")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
