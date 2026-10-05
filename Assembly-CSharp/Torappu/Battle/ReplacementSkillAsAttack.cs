using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020020E0 RID: 8416
	[Token(Token = "0x20020E0")]
	public class ReplacementSkillAsAttack : ReplacementSkillFixed
	{
		// Token: 0x17001856 RID: 6230
		// (get) Token: 0x0600CDE7 RID: 52711 RVA: 0x0004A4C0 File Offset: 0x000486C0
		[Token(Token = "0x17001856")]
		public override Ability.FamilyGroup familyGroup
		{
			[Token(Token = "0x600CDE7")]
			[Address(RVA = "0x35048D0", Offset = "0x35034D0", VA = "0x1835048D0", Slot = "35")]
			get
			{
				return Ability.FamilyGroup.ATTACK;
			}
		}

		// Token: 0x0600CDE8 RID: 52712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CDE8")]
		[Address(RVA = "0x3504870", Offset = "0x3503470", VA = "0x183504870")]
		public ReplacementSkillAsAttack()
		{
		}

		// Token: 0x0600CDE9 RID: 52713 RVA: 0x0004A4D8 File Offset: 0x000486D8
		[Token(Token = "0x600CDE9")]
		[Address(RVA = "0x3504860", Offset = "0x3503460", VA = "0x183504860")]
		private Ability.FamilyGroup <>xLuaBaseProxy_get_familyGroup()
		{
			return Ability.FamilyGroup.ATTACK;
		}

		// Token: 0x0400DB4E RID: 56142
		[Token(Token = "0x400DB4E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_familyGroup;

		// Token: 0x0400DB4F RID: 56143
		[Token(Token = "0x400DB4F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
