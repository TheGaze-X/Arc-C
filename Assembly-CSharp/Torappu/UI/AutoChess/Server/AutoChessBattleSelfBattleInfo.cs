using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataStream;
using XLua;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x02006430 RID: 25648
	[Token(Token = "0x2006430")]
	public class AutoChessBattleSelfBattleInfo : IStreamDeserialize, IHotfixable
	{
		// Token: 0x06024EBF RID: 151231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024EBF")]
		[Address(RVA = "0x1FB3DF0", Offset = "0x1FB29F0", VA = "0x181FB3DF0", Slot = "4")]
		public void Read(IStreamReader from)
		{
		}

		// Token: 0x06024EC0 RID: 151232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024EC0")]
		[Address(RVA = "0x1FB3E90", Offset = "0x1FB2A90", VA = "0x181FB3E90")]
		public AutoChessBattleSelfBattleInfo()
		{
		}

		// Token: 0x04033A45 RID: 211525
		[Token(Token = "0x4033A45")]
		[FieldOffset(Offset = "0x10")]
		public List<AutoChessSelfBattleEnemyInfo> enemyInfos;

		// Token: 0x04033A46 RID: 211526
		[Token(Token = "0x4033A46")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Read;

		// Token: 0x04033A47 RID: 211527
		[Token(Token = "0x4033A47")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
