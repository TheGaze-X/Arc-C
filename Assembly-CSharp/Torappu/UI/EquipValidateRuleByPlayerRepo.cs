using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200359E RID: 13726
	[Token(Token = "0x200359E")]
	public struct EquipValidateRuleByPlayerRepo : ISingleInfoValidateRule, IHotfixable
	{
		// Token: 0x1700342A RID: 13354
		// (get) Token: 0x06015D4B RID: 89419 RVA: 0x0008E230 File Offset: 0x0008C430
		// (set) Token: 0x06015D4C RID: 89420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700342A")]
		public CharQuery charQuery
		{
			[Token(Token = "0x6015D4B")]
			[Address(RVA = "0xE71F40", Offset = "0xE70B40", VA = "0x180E71F40")]
			[CompilerGenerated]
			readonly get
			{
				return default(CharQuery);
			}
			[Token(Token = "0x6015D4C")]
			[Address(RVA = "0xE71FD0", Offset = "0xE70BD0", VA = "0x180E71FD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06015D4D RID: 89421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015D4D")]
		[Address(RVA = "0xE71E30", Offset = "0xE70A30", VA = "0x180E71E30")]
		public EquipValidateRuleByPlayerRepo(CharQuery charQuery)
		{
		}

		// Token: 0x06015D4E RID: 89422 RVA: 0x0008E248 File Offset: 0x0008C448
		[Token(Token = "0x6015D4E")]
		[Address(RVA = "0xE71C20", Offset = "0xE70820", VA = "0x180E71C20")]
		public bool CheckIfValidate(UniEquipData equipData)
		{
			return default(bool);
		}

		// Token: 0x0401A430 RID: 107568
		[Token(Token = "0x401A430")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_charQuery;

		// Token: 0x0401A431 RID: 107569
		[Token(Token = "0x401A431")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_charQuery;

		// Token: 0x0401A432 RID: 107570
		[Token(Token = "0x401A432")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401A433 RID: 107571
		[Token(Token = "0x401A433")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CheckIfValidate;
	}
}
