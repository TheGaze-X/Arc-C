using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002A9B RID: 10907
	[Token(Token = "0x2002A9B")]
	public class ChannelingMeleeAttack : MeleeAttack
	{
		// Token: 0x170027C5 RID: 10181
		// (get) Token: 0x060121C1 RID: 74177 RVA: 0x0006EEC8 File Offset: 0x0006D0C8
		[Token(Token = "0x170027C5")]
		public override FP cooldown
		{
			[Token(Token = "0x60121C1")]
			[Address(RVA = "0xA1FEF0", Offset = "0xA1EAF0", VA = "0x180A1FEF0", Slot = "16")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x170027C6 RID: 10182
		// (get) Token: 0x060121C2 RID: 74178 RVA: 0x0006EEE0 File Offset: 0x0006D0E0
		[Token(Token = "0x170027C6")]
		protected override bool onlyTrigAudioSignalForFirstSpell
		{
			[Token(Token = "0x60121C2")]
			[Address(RVA = "0xA1FF50", Offset = "0xA1EB50", VA = "0x180A1FF50", Slot = "68")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060121C3 RID: 74179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60121C3")]
		[Address(RVA = "0xA1F9A0", Offset = "0xA1E5A0", VA = "0x180A1F9A0", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x060121C4 RID: 74180 RVA: 0x0006EEF8 File Offset: 0x0006D0F8
		[Token(Token = "0x60121C4")]
		[Address(RVA = "0xA1F870", Offset = "0xA1E470", VA = "0x180A1F870", Slot = "87")]
		protected override bool CheckAnotherSpell(int spellCnt)
		{
			return default(bool);
		}

		// Token: 0x060121C5 RID: 74181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60121C5")]
		[Address(RVA = "0xA1FC50", Offset = "0xA1E850", VA = "0x180A1FC50", Slot = "77")]
		protected override IEnumerator OnWaitForTriggerDelta()
		{
			return null;
		}

		// Token: 0x060121C6 RID: 74182 RVA: 0x0006EF10 File Offset: 0x0006D110
		[Token(Token = "0x60121C6")]
		[Address(RVA = "0xA1FB60", Offset = "0xA1E760", VA = "0x180A1FB60", Slot = "98")]
		protected override FP GetDuration()
		{
			return default(FP);
		}

		// Token: 0x060121C7 RID: 74183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60121C7")]
		[Address(RVA = "0xA1FBC0", Offset = "0xA1E7C0", VA = "0x180A1FBC0", Slot = "50")]
		protected override void OnCastStart()
		{
		}

		// Token: 0x060121C8 RID: 74184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60121C8")]
		[Address(RVA = "0xA1FDA0", Offset = "0xA1E9A0", VA = "0x180A1FDA0", Slot = "38")]
		public override void UpdateCooldown(FP newPeriod, bool waitFirstPeriod, bool keepPassedTime = false)
		{
		}

		// Token: 0x060121C9 RID: 74185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60121C9")]
		[Address(RVA = "0xA1FE90", Offset = "0xA1EA90", VA = "0x180A1FE90")]
		public ChannelingMeleeAttack()
		{
		}

		// Token: 0x060121CA RID: 74186 RVA: 0x0006EF28 File Offset: 0x0006D128
		[Token(Token = "0x60121CA")]
		[Address(RVA = "0xA1FD80", Offset = "0xA1E980", VA = "0x180A1FD80")]
		private FP <>xLuaBaseProxy_get_cooldown()
		{
			return default(FP);
		}

		// Token: 0x060121CB RID: 74187 RVA: 0x0006EF40 File Offset: 0x0006D140
		[Token(Token = "0x60121CB")]
		[Address(RVA = "0xA1FD90", Offset = "0xA1E990", VA = "0x180A1FD90")]
		private bool <>xLuaBaseProxy_get_onlyTrigAudioSignalForFirstSpell()
		{
			return default(bool);
		}

		// Token: 0x060121CC RID: 74188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60121CC")]
		[Address(RVA = "0xA1FD10", Offset = "0xA1E910", VA = "0x180A1FD10")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x060121CD RID: 74189 RVA: 0x0006EF58 File Offset: 0x0006D158
		[Token(Token = "0x60121CD")]
		[Address(RVA = "0xA1FD00", Offset = "0xA1E900", VA = "0x180A1FD00")]
		private bool <>xLuaBaseProxy_CheckAnotherSpell(int P0)
		{
			return default(bool);
		}

		// Token: 0x060121CE RID: 74190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60121CE")]
		[Address(RVA = "0xA1FD60", Offset = "0xA1E960", VA = "0x180A1FD60")]
		private IEnumerator <>xLuaBaseProxy_OnWaitForTriggerDelta()
		{
			return null;
		}

		// Token: 0x060121CF RID: 74191 RVA: 0x0006EF70 File Offset: 0x0006D170
		[Token(Token = "0x60121CF")]
		[Address(RVA = "0xA1FD40", Offset = "0xA1E940", VA = "0x180A1FD40")]
		private FP <>xLuaBaseProxy_GetDuration()
		{
			return default(FP);
		}

		// Token: 0x060121D0 RID: 74192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60121D0")]
		[Address(RVA = "0xA1FD50", Offset = "0xA1E950", VA = "0x180A1FD50")]
		private void <>xLuaBaseProxy_OnCastStart()
		{
		}

		// Token: 0x060121D1 RID: 74193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60121D1")]
		[Address(RVA = "0xA1FD70", Offset = "0xA1E970", VA = "0x180A1FD70")]
		private void <>xLuaBaseProxy_UpdateCooldown(FP P0, bool P1, bool P2)
		{
		}

		// Token: 0x040147E8 RID: 83944
		[Token(Token = "0x40147E8")]
		[FieldOffset(Offset = "0x218")]
		[SerializeField]
		private float _triggerDelta;

		// Token: 0x040147E9 RID: 83945
		[Token(Token = "0x40147E9")]
		[FieldOffset(Offset = "0x21C")]
		[SerializeField]
		private float _postDelayChecker;

		// Token: 0x040147EA RID: 83946
		[Token(Token = "0x40147EA")]
		[FieldOffset(Offset = "0x220")]
		[SerializeField]
		private bool _onlyTrigAudioSignalForFirstSpell;

		// Token: 0x040147EB RID: 83947
		[Token(Token = "0x40147EB")]
		[FieldOffset(Offset = "0x221")]
		[SerializeField]
		private bool _enableUpdateCooldown;

		// Token: 0x040147EC RID: 83948
		[Token(Token = "0x40147EC")]
		[FieldOffset(Offset = "0x228")]
		private FP m_duration;

		// Token: 0x040147ED RID: 83949
		[Token(Token = "0x40147ED")]
		[FieldOffset(Offset = "0x230")]
		private FP m_triggerDelta;

		// Token: 0x040147EE RID: 83950
		[Token(Token = "0x40147EE")]
		[FieldOffset(Offset = "0x238")]
		private FP m_castTime;

		// Token: 0x040147EF RID: 83951
		[Token(Token = "0x40147EF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_cooldown;

		// Token: 0x040147F0 RID: 83952
		[Token(Token = "0x40147F0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_onlyTrigAudioSignalForFirstSpell;

		// Token: 0x040147F1 RID: 83953
		[Token(Token = "0x40147F1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x040147F2 RID: 83954
		[Token(Token = "0x40147F2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CheckAnotherSpell;

		// Token: 0x040147F3 RID: 83955
		[Token(Token = "0x40147F3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnWaitForTriggerDelta;

		// Token: 0x040147F4 RID: 83956
		[Token(Token = "0x40147F4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetDuration;

		// Token: 0x040147F5 RID: 83957
		[Token(Token = "0x40147F5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnCastStart;

		// Token: 0x040147F6 RID: 83958
		[Token(Token = "0x40147F6")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_UpdateCooldown;

		// Token: 0x040147F7 RID: 83959
		[Token(Token = "0x40147F7")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
