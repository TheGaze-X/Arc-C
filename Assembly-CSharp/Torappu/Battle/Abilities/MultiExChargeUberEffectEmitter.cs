using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002BFE RID: 11262
	[Token(Token = "0x2002BFE")]
	[RequireComponent(typeof(ExChargeRangedAttack))]
	public class MultiExChargeUberEffectEmitter : MultiChargeUberEffectEmitter
	{
		// Token: 0x170029E3 RID: 10723
		// (get) Token: 0x06013054 RID: 77908 RVA: 0x000745E0 File Offset: 0x000727E0
		[Token(Token = "0x170029E3")]
		public bool isExEffectEmitter
		{
			[Token(Token = "0x6013054")]
			[Address(RVA = "0xAE7980", Offset = "0xAE6580", VA = "0x180AE7980")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06013055 RID: 77909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013055")]
		[Address(RVA = "0xAE7330", Offset = "0xAE5F30", VA = "0x180AE7330", Slot = "5")]
		public override void Init(AbilityStandard ability)
		{
		}

		// Token: 0x06013056 RID: 77910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013056")]
		[Address(RVA = "0xAE7540", Offset = "0xAE6140", VA = "0x180AE7540", Slot = "11")]
		public override void OnCastOnTarget(Entity target)
		{
		}

		// Token: 0x06013057 RID: 77911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013057")]
		[Address(RVA = "0xAE75E0", Offset = "0xAE61E0", VA = "0x180AE75E0", Slot = "10")]
		public override void OnEvent(AbilityStandard.Event ev)
		{
		}

		// Token: 0x06013058 RID: 77912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013058")]
		[Address(RVA = "0xAE7130", Offset = "0xAE5D30", VA = "0x180AE7130")]
		public void ConsumeChargeTimes(int times)
		{
		}

		// Token: 0x06013059 RID: 77913 RVA: 0x000745F8 File Offset: 0x000727F8
		[Token(Token = "0x6013059")]
		[Address(RVA = "0xAE72B0", Offset = "0xAE5EB0", VA = "0x180AE72B0", Slot = "18")]
		protected override int GetChargeIndex()
		{
			return 0;
		}

		// Token: 0x0601305A RID: 77914 RVA: 0x00074610 File Offset: 0x00072810
		[Token(Token = "0x601305A")]
		[Address(RVA = "0xAE7490", Offset = "0xAE6090", VA = "0x180AE7490", Slot = "19")]
		protected override bool IsInChargeAction()
		{
			return default(bool);
		}

		// Token: 0x0601305B RID: 77915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601305B")]
		[Address(RVA = "0xAE78D0", Offset = "0xAE64D0", VA = "0x180AE78D0")]
		public MultiExChargeUberEffectEmitter()
		{
		}

		// Token: 0x0601305C RID: 77916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601305C")]
		[Address(RVA = "0xAE7890", Offset = "0xAE6490", VA = "0x180AE7890")]
		private void <>xLuaBaseProxy_Init(AbilityStandard P0)
		{
		}

		// Token: 0x0601305D RID: 77917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601305D")]
		[Address(RVA = "0xAE78B0", Offset = "0xAE64B0", VA = "0x180AE78B0")]
		private void <>xLuaBaseProxy_OnCastOnTarget(Entity P0)
		{
		}

		// Token: 0x0601305E RID: 77918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601305E")]
		[Address(RVA = "0xAE78C0", Offset = "0xAE64C0", VA = "0x180AE78C0")]
		private void <>xLuaBaseProxy_OnEvent(AbilityStandard.Event P0)
		{
		}

		// Token: 0x0601305F RID: 77919 RVA: 0x00074628 File Offset: 0x00072828
		[Token(Token = "0x601305F")]
		[Address(RVA = "0xAE7880", Offset = "0xAE6480", VA = "0x180AE7880")]
		private int <>xLuaBaseProxy_GetChargeIndex()
		{
			return 0;
		}

		// Token: 0x06013060 RID: 77920 RVA: 0x00074640 File Offset: 0x00072840
		[Token(Token = "0x6013060")]
		[Address(RVA = "0xAE78A0", Offset = "0xAE64A0", VA = "0x180AE78A0")]
		private bool <>xLuaBaseProxy_IsInChargeAction()
		{
			return default(bool);
		}

		// Token: 0x040157C5 RID: 88005
		[Token(Token = "0x40157C5")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private bool _isExEffectEmitter;

		// Token: 0x040157C6 RID: 88006
		[Token(Token = "0x40157C6")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private AbilityStandard.Event _chargeEffectStartEvent;

		// Token: 0x040157C7 RID: 88007
		[Token(Token = "0x40157C7")]
		[FieldOffset(Offset = "0x80")]
		private ExChargeRangedAttack m_exChargeAbility;

		// Token: 0x040157C8 RID: 88008
		[Token(Token = "0x40157C8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isExEffectEmitter;

		// Token: 0x040157C9 RID: 88009
		[Token(Token = "0x40157C9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x040157CA RID: 88010
		[Token(Token = "0x40157CA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCastOnTarget;

		// Token: 0x040157CB RID: 88011
		[Token(Token = "0x40157CB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEvent;

		// Token: 0x040157CC RID: 88012
		[Token(Token = "0x40157CC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ConsumeChargeTimes;

		// Token: 0x040157CD RID: 88013
		[Token(Token = "0x40157CD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetChargeIndex;

		// Token: 0x040157CE RID: 88014
		[Token(Token = "0x40157CE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_IsInChargeAction;

		// Token: 0x040157CF RID: 88015
		[Token(Token = "0x40157CF")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
