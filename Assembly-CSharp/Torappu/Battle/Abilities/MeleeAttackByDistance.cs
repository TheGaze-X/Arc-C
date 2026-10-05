using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002A9E RID: 10910
	[Token(Token = "0x2002A9E")]
	public class MeleeAttackByDistance : MeleeAttack
	{
		// Token: 0x060121E5 RID: 74213 RVA: 0x0006F060 File Offset: 0x0006D260
		[Token(Token = "0x60121E5")]
		[Address(RVA = "0xA249A0", Offset = "0xA235A0", VA = "0x180A249A0", Slot = "84")]
		protected override bool CheckActiveBuffs(Entity target, IList<BuffData> buffs)
		{
			return default(bool);
		}

		// Token: 0x060121E6 RID: 74214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60121E6")]
		[Address(RVA = "0xA24C40", Offset = "0xA23840", VA = "0x180A24C40")]
		public MeleeAttackByDistance()
		{
		}

		// Token: 0x060121E7 RID: 74215 RVA: 0x0006F078 File Offset: 0x0006D278
		[Token(Token = "0x60121E7")]
		[Address(RVA = "0xA24C30", Offset = "0xA23830", VA = "0x180A24C30")]
		private bool <>xLuaBaseProxy_CheckActiveBuffs(Entity P0, IList<BuffData> P1)
		{
			return default(bool);
		}

		// Token: 0x04014808 RID: 83976
		[Token(Token = "0x4014808")]
		[FieldOffset(Offset = "0x218")]
		[SerializeField]
		private MeleeAttackByDistance.AtkScaleByDistConfig[] _atkScaleByDistance;

		// Token: 0x04014809 RID: 83977
		[Token(Token = "0x4014809")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckActiveBuffs;

		// Token: 0x0401480A RID: 83978
		[Token(Token = "0x401480A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002A9F RID: 10911
		[Token(Token = "0x2002A9F")]
		[Serializable]
		public struct AtkScaleByDistConfig
		{
			// Token: 0x0401480B RID: 83979
			[Token(Token = "0x401480B")]
			[FieldOffset(Offset = "0x0")]
			public float atkScale;

			// Token: 0x0401480C RID: 83980
			[Token(Token = "0x401480C")]
			[FieldOffset(Offset = "0x4")]
			public bool applyExternalAtkScale;
		}
	}
}
