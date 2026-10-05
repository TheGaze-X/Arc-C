using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B93 RID: 11155
	[Token(Token = "0x2002B93")]
	public class CooperateSwitchableAbility : PassiveBuffAbility
	{
		// Token: 0x06012C75 RID: 76917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C75")]
		[Address(RVA = "0xAB6250", Offset = "0xAB4E50", VA = "0x180AB6250", Slot = "29")]
		protected override void DoAttach(Entity owner)
		{
		}

		// Token: 0x06012C76 RID: 76918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C76")]
		[Address(RVA = "0xAB63B0", Offset = "0xAB4FB0", VA = "0x180AB63B0", Slot = "30")]
		protected override void DoDetach()
		{
		}

		// Token: 0x06012C77 RID: 76919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C77")]
		[Address(RVA = "0xAB6530", Offset = "0xAB5130", VA = "0x180AB6530", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x06012C78 RID: 76920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C78")]
		[Address(RVA = "0xAB6710", Offset = "0xAB5310", VA = "0x180AB6710")]
		private void _OnCooperateBuffLevelChanged(object arg)
		{
		}

		// Token: 0x06012C79 RID: 76921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C79")]
		[Address(RVA = "0xAB69D0", Offset = "0xAB55D0", VA = "0x180AB69D0")]
		public CooperateSwitchableAbility()
		{
		}

		// Token: 0x06012C7A RID: 76922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C7A")]
		[Address(RVA = "0xA64260", Offset = "0xA62E60", VA = "0x180A64260")]
		private void <>xLuaBaseProxy_DoAttach(Entity P0)
		{
		}

		// Token: 0x06012C7B RID: 76923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C7B")]
		[Address(RVA = "0xA3C270", Offset = "0xA3AE70", VA = "0x180A3C270")]
		private void <>xLuaBaseProxy_DoDetach()
		{
		}

		// Token: 0x06012C7C RID: 76924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C7C")]
		[Address(RVA = "0xA1E4E0", Offset = "0xA1D0E0", VA = "0x180A1E4E0")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x0401536C RID: 86892
		[Token(Token = "0x401536C")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		protected Ability[] _abilities;

		// Token: 0x0401536D RID: 86893
		[Token(Token = "0x401536D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x0401536E RID: 86894
		[Token(Token = "0x401536E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x0401536F RID: 86895
		[Token(Token = "0x401536F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x04015370 RID: 86896
		[Token(Token = "0x4015370")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnCooperateBuffLevelChanged;

		// Token: 0x04015371 RID: 86897
		[Token(Token = "0x4015371")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
