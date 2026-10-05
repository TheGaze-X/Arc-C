using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002AB5 RID: 10933
	[Token(Token = "0x2002AB5")]
	public class MultiFunnelsNormalAttack : RangedAttack
	{
		// Token: 0x06012309 RID: 74505 RVA: 0x0006F780 File Offset: 0x0006D980
		[Token(Token = "0x6012309")]
		[Address(RVA = "0xA40E20", Offset = "0xA3FA20", VA = "0x180A40E20", Slot = "85")]
		protected override bool DoCastOnTargets(IList<ActionNode> actions, IList<BuffData> buffs, IList<IAbilityAttachment> attachments)
		{
			return default(bool);
		}

		// Token: 0x0601230A RID: 74506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601230A")]
		[Address(RVA = "0xA40B00", Offset = "0xA3F700", VA = "0x180A40B00", Slot = "29")]
		protected override void DoAttach(Entity owner)
		{
		}

		// Token: 0x0601230B RID: 74507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601230B")]
		[Address(RVA = "0xA40FD0", Offset = "0xA3FBD0", VA = "0x180A40FD0", Slot = "30")]
		protected override void DoDetach()
		{
		}

		// Token: 0x0601230C RID: 74508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601230C")]
		[Address(RVA = "0xA41120", Offset = "0xA3FD20", VA = "0x180A41120", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x0601230D RID: 74509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601230D")]
		[Address(RVA = "0xA41310", Offset = "0xA3FF10", VA = "0x180A41310")]
		public void RuntimeAddActiveCnt(int cnt)
		{
		}

		// Token: 0x0601230E RID: 74510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601230E")]
		[Address(RVA = "0xA413F0", Offset = "0xA3FFF0", VA = "0x180A413F0")]
		public void UpdateActiveCntIfAdded()
		{
		}

		// Token: 0x0601230F RID: 74511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601230F")]
		[Address(RVA = "0xA415F0", Offset = "0xA401F0", VA = "0x180A415F0")]
		public MultiFunnelsNormalAttack()
		{
		}

		// Token: 0x06012310 RID: 74512 RVA: 0x0006F798 File Offset: 0x0006D998
		[Token(Token = "0x6012310")]
		[Address(RVA = "0xA39D20", Offset = "0xA38920", VA = "0x180A39D20")]
		private bool <>xLuaBaseProxy_DoCastOnTargets(IList<ActionNode> P0, IList<BuffData> P1, IList<IAbilityAttachment> P2)
		{
			return default(bool);
		}

		// Token: 0x06012311 RID: 74513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012311")]
		[Address(RVA = "0xA27580", Offset = "0xA26180", VA = "0x180A27580")]
		private void <>xLuaBaseProxy_DoAttach(Entity P0)
		{
		}

		// Token: 0x06012312 RID: 74514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012312")]
		[Address(RVA = "0xA3C270", Offset = "0xA3AE70", VA = "0x180A3C270")]
		private void <>xLuaBaseProxy_DoDetach()
		{
		}

		// Token: 0x06012313 RID: 74515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012313")]
		[Address(RVA = "0xA25D00", Offset = "0xA24900", VA = "0x180A25D00")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x04014932 RID: 84274
		[Token(Token = "0x4014932")]
		[FieldOffset(Offset = "0x268")]
		[SerializeField]
		[Group("ExtraFunnelConfig")]
		private bool _useExtraActiveCntAbility;

		// Token: 0x04014933 RID: 84275
		[Token(Token = "0x4014933")]
		[FieldOffset(Offset = "0x270")]
		[SerializeField]
		private Ability[] _funnelActions;

		// Token: 0x04014934 RID: 84276
		[Token(Token = "0x4014934")]
		[FieldOffset(Offset = "0x278")]
		private int m_activeCnt;

		// Token: 0x04014935 RID: 84277
		[Token(Token = "0x4014935")]
		[FieldOffset(Offset = "0x280")]
		private MultiFunnelExtraActiveCntAbility m_extraActiveCntStorage;

		// Token: 0x04014936 RID: 84278
		[Token(Token = "0x4014936")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoCastOnTargets;

		// Token: 0x04014937 RID: 84279
		[Token(Token = "0x4014937")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04014938 RID: 84280
		[Token(Token = "0x4014938")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x04014939 RID: 84281
		[Token(Token = "0x4014939")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x0401493A RID: 84282
		[Token(Token = "0x401493A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RuntimeAddActiveCnt;

		// Token: 0x0401493B RID: 84283
		[Token(Token = "0x401493B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_UpdateActiveCntIfAdded;

		// Token: 0x0401493C RID: 84284
		[Token(Token = "0x401493C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
