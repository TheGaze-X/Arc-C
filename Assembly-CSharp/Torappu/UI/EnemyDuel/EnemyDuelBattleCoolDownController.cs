using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004FE5 RID: 20453
	[Token(Token = "0x2004FE5")]
	public class EnemyDuelBattleCoolDownController : PageSingleComponent
	{
		// Token: 0x0601E5D3 RID: 124371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E5D3")]
		[Address(RVA = "0x180F710", Offset = "0x180E310", VA = "0x18180F710")]
		public void Trigger(EnemyDuelBattleCoolDownController.CoolDownType coolDownType, float cooldown)
		{
		}

		// Token: 0x0601E5D4 RID: 124372 RVA: 0x000AE498 File Offset: 0x000AC698
		[Token(Token = "0x601E5D4")]
		[Address(RVA = "0x180F520", Offset = "0x180E120", VA = "0x18180F520")]
		public float GetCooldown(EnemyDuelBattleCoolDownController.CoolDownType coolDownType)
		{
			return 0f;
		}

		// Token: 0x0601E5D5 RID: 124373 RVA: 0x000AE4B0 File Offset: 0x000AC6B0
		[Token(Token = "0x601E5D5")]
		[Address(RVA = "0x180F620", Offset = "0x180E220", VA = "0x18180F620")]
		public bool IsCooldownEnd(EnemyDuelBattleCoolDownController.CoolDownType coolDownType)
		{
			return default(bool);
		}

		// Token: 0x0601E5D6 RID: 124374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E5D6")]
		[Address(RVA = "0x180F880", Offset = "0x180E480", VA = "0x18180F880")]
		public EnemyDuelBattleCoolDownController()
		{
		}

		// Token: 0x040289AB RID: 166315
		[Token(Token = "0x40289AB")]
		[FieldOffset(Offset = "0x20")]
		private CountDownStopWatch[] m_timestampInfo;

		// Token: 0x040289AC RID: 166316
		[Token(Token = "0x40289AC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Trigger;

		// Token: 0x040289AD RID: 166317
		[Token(Token = "0x40289AD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCooldown;

		// Token: 0x040289AE RID: 166318
		[Token(Token = "0x40289AE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_IsCooldownEnd;

		// Token: 0x040289AF RID: 166319
		[Token(Token = "0x40289AF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004FE6 RID: 20454
		[Token(Token = "0x2004FE6")]
		public enum CoolDownType
		{
			// Token: 0x040289B1 RID: 166321
			[Token(Token = "0x40289B1")]
			TYPE_BET,
			// Token: 0x040289B2 RID: 166322
			[Token(Token = "0x40289B2")]
			TYPE_EMOTICON,
			// Token: 0x040289B3 RID: 166323
			[Token(Token = "0x40289B3")]
			E_NUM
		}
	}
}
