using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataStream;
using XLua;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x02006431 RID: 25649
	[Token(Token = "0x2006431")]
	public class AutoChessSelfBattleEnemyInfo : IStreamDeserialize, IHotfixable
	{
		// Token: 0x06024EC1 RID: 151233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024EC1")]
		[Address(RVA = "0x1FD6660", Offset = "0x1FD5260", VA = "0x181FD6660", Slot = "4")]
		public void Read(IStreamReader from)
		{
		}

		// Token: 0x06024EC2 RID: 151234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024EC2")]
		[Address(RVA = "0x1FD6740", Offset = "0x1FD5340", VA = "0x181FD6740")]
		public AutoChessSelfBattleEnemyInfo()
		{
		}

		// Token: 0x04033A48 RID: 211528
		[Token(Token = "0x4033A48")]
		[FieldOffset(Offset = "0x10")]
		public string enemyId;

		// Token: 0x04033A49 RID: 211529
		[Token(Token = "0x4033A49")]
		[FieldOffset(Offset = "0x18")]
		public int actionIndex;

		// Token: 0x04033A4A RID: 211530
		[Token(Token = "0x4033A4A")]
		[FieldOffset(Offset = "0x20")]
		public List<int> instIdList;

		// Token: 0x04033A4B RID: 211531
		[Token(Token = "0x4033A4B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Read;

		// Token: 0x04033A4C RID: 211532
		[Token(Token = "0x4033A4C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
