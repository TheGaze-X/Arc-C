using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002AB4 RID: 10932
	[Token(Token = "0x2002AB4")]
	public class MultiFunnelRemoteAttack : RangedAttack
	{
		// Token: 0x060122FD RID: 74493 RVA: 0x0006F750 File Offset: 0x0006D950
		[Token(Token = "0x60122FD")]
		[Address(RVA = "0xA401E0", Offset = "0xA3EDE0", VA = "0x180A401E0", Slot = "85")]
		protected override bool DoCastOnTargets(IList<ActionNode> actions, IList<BuffData> buffs, IList<IAbilityAttachment> attachments)
		{
			return default(bool);
		}

		// Token: 0x060122FE RID: 74494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60122FE")]
		[Address(RVA = "0xA3FE30", Offset = "0xA3EA30", VA = "0x180A3FE30", Slot = "29")]
		protected override void DoAttach(Entity owner)
		{
		}

		// Token: 0x060122FF RID: 74495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60122FF")]
		[Address(RVA = "0xA403F0", Offset = "0xA3EFF0", VA = "0x180A403F0", Slot = "30")]
		protected override void DoDetach()
		{
		}

		// Token: 0x06012300 RID: 74496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012300")]
		[Address(RVA = "0xA40540", Offset = "0xA3F140", VA = "0x180A40540", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x06012301 RID: 74497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012301")]
		[Address(RVA = "0xA406C0", Offset = "0xA3F2C0", VA = "0x180A406C0", Slot = "54")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06012302 RID: 74498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012302")]
		[Address(RVA = "0xA40890", Offset = "0xA3F490", VA = "0x180A40890")]
		public void UpdateActiveCntIfAdded()
		{
		}

		// Token: 0x06012303 RID: 74499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012303")]
		[Address(RVA = "0xA40A90", Offset = "0xA3F690", VA = "0x180A40A90")]
		public MultiFunnelRemoteAttack()
		{
		}

		// Token: 0x06012304 RID: 74500 RVA: 0x0006F768 File Offset: 0x0006D968
		[Token(Token = "0x6012304")]
		[Address(RVA = "0xA39D20", Offset = "0xA38920", VA = "0x180A39D20")]
		private bool <>xLuaBaseProxy_DoCastOnTargets(IList<ActionNode> P0, IList<BuffData> P1, IList<IAbilityAttachment> P2)
		{
			return default(bool);
		}

		// Token: 0x06012305 RID: 74501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012305")]
		[Address(RVA = "0xA27580", Offset = "0xA26180", VA = "0x180A27580")]
		private void <>xLuaBaseProxy_DoAttach(Entity P0)
		{
		}

		// Token: 0x06012306 RID: 74502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012306")]
		[Address(RVA = "0xA3C270", Offset = "0xA3AE70", VA = "0x180A3C270")]
		private void <>xLuaBaseProxy_DoDetach()
		{
		}

		// Token: 0x06012307 RID: 74503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012307")]
		[Address(RVA = "0xA25D00", Offset = "0xA24900", VA = "0x180A25D00")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x06012308 RID: 74504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012308")]
		[Address(RVA = "0xA38EF0", Offset = "0xA37AF0", VA = "0x180A38EF0")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x04014925 RID: 84261
		[Token(Token = "0x4014925")]
		[FieldOffset(Offset = "0x268")]
		[SerializeField]
		[Group("ExtraFunnelConfig")]
		private bool _alwaysUseFunnelSelector;

		// Token: 0x04014926 RID: 84262
		[Token(Token = "0x4014926")]
		[FieldOffset(Offset = "0x269")]
		[SerializeField]
		[Group("ExtraFunnelConfig")]
		private bool _useExtraActiveCntAbility;

		// Token: 0x04014927 RID: 84263
		[Token(Token = "0x4014927")]
		[FieldOffset(Offset = "0x270")]
		[SerializeField]
		private Ability[] _funnelActions;

		// Token: 0x04014928 RID: 84264
		[Token(Token = "0x4014928")]
		[FieldOffset(Offset = "0x278")]
		private int m_activeCnt;

		// Token: 0x04014929 RID: 84265
		[Token(Token = "0x4014929")]
		[FieldOffset(Offset = "0x280")]
		private MultiFunnelTrait m_trait;

		// Token: 0x0401492A RID: 84266
		[Token(Token = "0x401492A")]
		[FieldOffset(Offset = "0x288")]
		private MultiFunnelExtraActiveCntAbility m_extraActiveCntStorage;

		// Token: 0x0401492B RID: 84267
		[Token(Token = "0x401492B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoCastOnTargets;

		// Token: 0x0401492C RID: 84268
		[Token(Token = "0x401492C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x0401492D RID: 84269
		[Token(Token = "0x401492D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x0401492E RID: 84270
		[Token(Token = "0x401492E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x0401492F RID: 84271
		[Token(Token = "0x401492F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04014930 RID: 84272
		[Token(Token = "0x4014930")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_UpdateActiveCntIfAdded;

		// Token: 0x04014931 RID: 84273
		[Token(Token = "0x4014931")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
