using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200359D RID: 13725
	[Token(Token = "0x200359D")]
	public struct EquipValidateRuleByTmplMatch : ISingleInfoValidateRule, IHotfixable
	{
		// Token: 0x17003429 RID: 13353
		// (get) Token: 0x06015D47 RID: 89415 RVA: 0x0008E200 File Offset: 0x0008C400
		// (set) Token: 0x06015D48 RID: 89416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003429")]
		public CharQuery charQuery
		{
			[Token(Token = "0x6015D47")]
			[Address(RVA = "0xE722F0", Offset = "0xE70EF0", VA = "0x180E722F0")]
			[CompilerGenerated]
			readonly get
			{
				return default(CharQuery);
			}
			[Token(Token = "0x6015D48")]
			[Address(RVA = "0xE72380", Offset = "0xE70F80", VA = "0x180E72380")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06015D49 RID: 89417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015D49")]
		[Address(RVA = "0xE721E0", Offset = "0xE70DE0", VA = "0x180E721E0")]
		public EquipValidateRuleByTmplMatch(CharQuery charQuery)
		{
		}

		// Token: 0x06015D4A RID: 89418 RVA: 0x0008E218 File Offset: 0x0008C418
		[Token(Token = "0x6015D4A")]
		[Address(RVA = "0xE72080", Offset = "0xE70C80", VA = "0x180E72080")]
		public bool CheckIfValidate(UniEquipData equipData)
		{
			return default(bool);
		}

		// Token: 0x0401A42B RID: 107563
		[Token(Token = "0x401A42B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_charQuery;

		// Token: 0x0401A42C RID: 107564
		[Token(Token = "0x401A42C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_charQuery;

		// Token: 0x0401A42D RID: 107565
		[Token(Token = "0x401A42D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401A42E RID: 107566
		[Token(Token = "0x401A42E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CheckIfValidate;
	}
}
