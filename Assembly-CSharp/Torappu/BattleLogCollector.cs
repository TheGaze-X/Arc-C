using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x02000486 RID: 1158
	[Token(Token = "0x2000486")]
	public class BattleLogCollector : Singleton<BattleLogCollector>, IRuneDataHolder
	{
		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06004C9F RID: 19615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001E8")]
		public List<RuneData> crisisV2Runes
		{
			[Token(Token = "0x6004C9F")]
			[Address(RVA = "0x1786800", Offset = "0x1785400", VA = "0x181786800")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004CA0 RID: 19616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CA0")]
		[Address(RVA = "0x1786730", Offset = "0x1785330", VA = "0x181786730")]
		private BattleLogCollector()
		{
		}

		// Token: 0x06004CA1 RID: 19617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CA1")]
		[Address(RVA = "0x17865E0", Offset = "0x17851E0", VA = "0x1817865E0", Slot = "5")]
		public void ForeachPackedRuneData(Action<RuneTable.PackedRuneData> visitor)
		{
		}

		// Token: 0x06004CA2 RID: 19618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CA2")]
		[Address(RVA = "0x1786640", Offset = "0x1785240", VA = "0x181786640", Slot = "4")]
		public void ForeachRuneData(Action<RuneData> visitor)
		{
		}

		// Token: 0x06004CA3 RID: 19619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CA3")]
		[Address(RVA = "0x17862C0", Offset = "0x1784EC0", VA = "0x1817862C0")]
		public void Collect(string levelId)
		{
		}

		// Token: 0x0400107E RID: 4222
		[Token(Token = "0x400107E")]
		[FieldOffset(Offset = "0x10")]
		private List<RuneData> m_crisisV2Runes;

		// Token: 0x0400107F RID: 4223
		[Token(Token = "0x400107F")]
		private const string CRISIS_V2_KEY = "env_009_crisisV2";

		// Token: 0x04001080 RID: 4224
		[Token(Token = "0x4001080")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_crisisV2Runes;

		// Token: 0x04001081 RID: 4225
		[Token(Token = "0x4001081")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04001082 RID: 4226
		[Token(Token = "0x4001082")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ForeachPackedRuneData;

		// Token: 0x04001083 RID: 4227
		[Token(Token = "0x4001083")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ForeachRuneData;

		// Token: 0x04001084 RID: 4228
		[Token(Token = "0x4001084")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Collect;
	}
}
