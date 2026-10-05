using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004FD4 RID: 20436
	[Token(Token = "0x2004FD4")]
	public class EnemyDuelTopBarViewModel : IHotfixable
	{
		// Token: 0x0601E58D RID: 124301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E58D")]
		[Address(RVA = "0x18204D0", Offset = "0x181F0D0", VA = "0x1818204D0")]
		public void LoadData()
		{
		}

		// Token: 0x0601E58E RID: 124302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E58E")]
		[Address(RVA = "0x1820610", Offset = "0x181F210", VA = "0x181820610")]
		public EnemyDuelTopBarViewModel()
		{
		}

		// Token: 0x04028905 RID: 166149
		[Token(Token = "0x4028905")]
		[FieldOffset(Offset = "0x10")]
		public List<ActivityEnemyDuelConstData.PingCond> pingConds;

		// Token: 0x04028906 RID: 166150
		[Token(Token = "0x4028906")]
		[FieldOffset(Offset = "0x18")]
		public string roomName;

		// Token: 0x04028907 RID: 166151
		[Token(Token = "0x4028907")]
		[FieldOffset(Offset = "0x20")]
		public bool isEmoticonDisabled;

		// Token: 0x04028908 RID: 166152
		[Token(Token = "0x4028908")]
		[FieldOffset(Offset = "0x24")]
		public int loadSeqNum;

		// Token: 0x04028909 RID: 166153
		[Token(Token = "0x4028909")]
		[FieldOffset(Offset = "0x28")]
		public string defaultEmoticonGroupId;

		// Token: 0x0402890A RID: 166154
		[Token(Token = "0x402890A")]
		[FieldOffset(Offset = "0x30")]
		public string defaultEmoticonPicId;

		// Token: 0x0402890B RID: 166155
		[Token(Token = "0x402890B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402890C RID: 166156
		[Token(Token = "0x402890C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
