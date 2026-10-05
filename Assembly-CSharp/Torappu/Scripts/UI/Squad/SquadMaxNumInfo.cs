using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Scripts.UI.Squad
{
	// Token: 0x0200179E RID: 6046
	[Token(Token = "0x200179E")]
	public struct SquadMaxNumInfo : IHotfixable
	{
		// Token: 0x1700106E RID: 4206
		// (get) Token: 0x060098D8 RID: 39128 RVA: 0x0003B7A8 File Offset: 0x000399A8
		[Token(Token = "0x1700106E")]
		public int squadMaxMemberCount
		{
			[Token(Token = "0x60098D8")]
			[Address(RVA = "0x3149510", Offset = "0x3148110", VA = "0x183149510")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700106F RID: 4207
		// (get) Token: 0x060098D9 RID: 39129 RVA: 0x0003B7C0 File Offset: 0x000399C0
		[Token(Token = "0x1700106F")]
		public int squadMaxAssistCount
		{
			[Token(Token = "0x60098D9")]
			[Address(RVA = "0x31494A0", Offset = "0x31480A0", VA = "0x1831494A0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001070 RID: 4208
		// (get) Token: 0x060098DA RID: 39130 RVA: 0x0003B7D8 File Offset: 0x000399D8
		[Token(Token = "0x17001070")]
		public int maxSquadCharRawCount
		{
			[Token(Token = "0x60098DA")]
			[Address(RVA = "0x3149400", Offset = "0x3148000", VA = "0x183149400")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060098DB RID: 39131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098DB")]
		[Address(RVA = "0x3149370", Offset = "0x3147F70", VA = "0x183149370")]
		public SquadMaxNumInfo(int maxMemberCount, int maxAssistCount)
		{
		}

		// Token: 0x060098DC RID: 39132 RVA: 0x0003B7F0 File Offset: 0x000399F0
		[Token(Token = "0x60098DC")]
		[Address(RVA = "0x3149210", Offset = "0x3147E10", VA = "0x183149210")]
		public bool IsMaxMemCountValid()
		{
			return default(bool);
		}

		// Token: 0x04008ED9 RID: 36569
		[Token(Token = "0x4008ED9")]
		[FieldOffset(Offset = "0x0")]
		private readonly int m_quadMaxMemberCount;

		// Token: 0x04008EDA RID: 36570
		[Token(Token = "0x4008EDA")]
		[FieldOffset(Offset = "0x4")]
		private readonly int m_squadMaxAssistCount;

		// Token: 0x04008EDB RID: 36571
		[Token(Token = "0x4008EDB")]
		[FieldOffset(Offset = "0x0")]
		public static SquadMaxNumInfo EMPTY;

		// Token: 0x04008EDC RID: 36572
		[Token(Token = "0x4008EDC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_squadMaxMemberCount;

		// Token: 0x04008EDD RID: 36573
		[Token(Token = "0x4008EDD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_squadMaxAssistCount;

		// Token: 0x04008EDE RID: 36574
		[Token(Token = "0x4008EDE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_maxSquadCharRawCount;

		// Token: 0x04008EDF RID: 36575
		[Token(Token = "0x4008EDF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04008EE0 RID: 36576
		[Token(Token = "0x4008EE0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_IsMaxMemCountValid;
	}
}
