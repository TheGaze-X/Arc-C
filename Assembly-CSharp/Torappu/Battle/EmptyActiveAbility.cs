using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020020DE RID: 8414
	[Token(Token = "0x20020DE")]
	public class EmptyActiveAbility : EmptyAbility
	{
		// Token: 0x17001855 RID: 6229
		// (get) Token: 0x0600CDE1 RID: 52705 RVA: 0x0004A490 File Offset: 0x00048690
		[Token(Token = "0x17001855")]
		public override Ability.Category category
		{
			[Token(Token = "0x600CDE1")]
			[Address(RVA = "0x34FE550", Offset = "0x34FD150", VA = "0x1834FE550", Slot = "13")]
			get
			{
				return Ability.Category.NONE;
			}
		}

		// Token: 0x0600CDE2 RID: 52706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CDE2")]
		[Address(RVA = "0x34FE4F0", Offset = "0x34FD0F0", VA = "0x1834FE4F0")]
		public EmptyActiveAbility()
		{
		}

		// Token: 0x0600CDE3 RID: 52707 RVA: 0x0004A4A8 File Offset: 0x000486A8
		[Token(Token = "0x600CDE3")]
		[Address(RVA = "0x34FE350", Offset = "0x34FCF50", VA = "0x1834FE350")]
		private Ability.Category <>xLuaBaseProxy_get_category()
		{
			return Ability.Category.NONE;
		}

		// Token: 0x0400DB4A RID: 56138
		[Token(Token = "0x400DB4A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_category;

		// Token: 0x0400DB4B RID: 56139
		[Token(Token = "0x400DB4B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
