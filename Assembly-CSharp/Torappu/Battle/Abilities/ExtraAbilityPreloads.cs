using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002C1A RID: 11290
	[Token(Token = "0x2002C1A")]
	public class ExtraAbilityPreloads : AbilityStandard.Behaviour, IEffectSource, IProjectileSource
	{
		// Token: 0x06013109 RID: 78089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013109")]
		[Address(RVA = "0xB1B390", Offset = "0xB19F90", VA = "0x180B1B390", Slot = "16")]
		public void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x0601310A RID: 78090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601310A")]
		[Address(RVA = "0xB1B490", Offset = "0xB1A090", VA = "0x180B1B490", Slot = "17")]
		public void GatherProjectiles(List<string> projectiles)
		{
		}

		// Token: 0x0601310B RID: 78091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601310B")]
		[Address(RVA = "0xB1B590", Offset = "0xB1A190", VA = "0x180B1B590")]
		public ExtraAbilityPreloads()
		{
		}

		// Token: 0x04015872 RID: 88178
		[Token(Token = "0x4015872")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string[] _effects;

		// Token: 0x04015873 RID: 88179
		[Token(Token = "0x4015873")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string[] _projectileKeys;

		// Token: 0x04015874 RID: 88180
		[Token(Token = "0x4015874")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x04015875 RID: 88181
		[Token(Token = "0x4015875")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GatherProjectiles;

		// Token: 0x04015876 RID: 88182
		[Token(Token = "0x4015876")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
