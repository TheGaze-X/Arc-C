using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle;

namespace Torappu
{
	// Token: 0x02000703 RID: 1795
	[Token(Token = "0x2000703")]
	public abstract class CommonFinishBattleRequest
	{
		// Token: 0x0600635B RID: 25435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600635B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected CommonFinishBattleRequest()
		{
		}

		// Token: 0x04002F28 RID: 12072
		[Token(Token = "0x4002F28")]
		[FieldOffset(Offset = "0x10")]
		public string data;

		// Token: 0x04002F29 RID: 12073
		[Token(Token = "0x4002F29")]
		[FieldOffset(Offset = "0x18")]
		public CommonFinishBattleRequest.BattleDataInRequest battleData;

		// Token: 0x02000704 RID: 1796
		[Token(Token = "0x2000704")]
		public class BattleDataInternal
		{
			// Token: 0x0600635C RID: 25436 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600635C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public BattleDataInternal()
			{
			}

			// Token: 0x04002F2A RID: 12074
			[Token(Token = "0x4002F2A")]
			[FieldOffset(Offset = "0x10")]
			public string isCheat;

			// Token: 0x04002F2B RID: 12075
			[Token(Token = "0x4002F2B")]
			[FieldOffset(Offset = "0x18")]
			public long completeTime;
		}

		// Token: 0x02000705 RID: 1797
		[Token(Token = "0x2000705")]
		public class BattleDataInRequest : CommonFinishBattleRequest.BattleDataInternal
		{
			// Token: 0x0600635D RID: 25437 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600635D")]
			[Address(RVA = "0x1EE6F70", Offset = "0x1EE5B70", VA = "0x181EE6F70")]
			public BattleDataInRequest()
			{
			}

			// Token: 0x04002F2C RID: 12076
			[Token(Token = "0x4002F2C")]
			[FieldOffset(Offset = "0x20")]
			public Dictionary<string, string> stats;
		}

		// Token: 0x02000706 RID: 1798
		[Token(Token = "0x2000706")]
		public class BattleData : CommonFinishBattleRequest.BattleDataInternal
		{
			// Token: 0x0600635E RID: 25438 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600635E")]
			[Address(RVA = "0x1EE7000", Offset = "0x1EE5C00", VA = "0x181EE7000")]
			public static IEnumerator TouchForCacheType()
			{
				return null;
			}

			// Token: 0x0600635F RID: 25439 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600635F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public BattleData()
			{
			}

			// Token: 0x04002F2D RID: 12077
			[Token(Token = "0x4002F2D")]
			[FieldOffset(Offset = "0x20")]
			public BattleLogger.BattleStats stats;
		}
	}
}
