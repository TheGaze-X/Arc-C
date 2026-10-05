using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B90 RID: 11152
	[Token(Token = "0x2002B90")]
	public class BurstAttackGroup : AbilitySelectableGroup
	{
		// Token: 0x17002964 RID: 10596
		// (get) Token: 0x06012C47 RID: 76871 RVA: 0x00072F00 File Offset: 0x00071100
		[Token(Token = "0x17002964")]
		public bool isDuringBurstAttack
		{
			[Token(Token = "0x6012C47")]
			[Address(RVA = "0xAB4740", Offset = "0xAB3340", VA = "0x180AB4740")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06012C48 RID: 76872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C48")]
		[Address(RVA = "0xAB3EC0", Offset = "0xAB2AC0", VA = "0x180AB3EC0", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x06012C49 RID: 76873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C49")]
		[Address(RVA = "0xAB4330", Offset = "0xAB2F30", VA = "0x180AB4330", Slot = "37")]
		public override void ResetCooldown(bool waitFirstPeriod)
		{
		}

		// Token: 0x06012C4A RID: 76874 RVA: 0x00072F18 File Offset: 0x00071118
		[Token(Token = "0x6012C4A")]
		[Address(RVA = "0xAB3970", Offset = "0xAB2570", VA = "0x180AB3970", Slot = "33")]
		public override bool CastDirectly([Optional] Ability.FinishCallbackDelegate finishCb, bool firstAttack = true)
		{
			return default(bool);
		}

		// Token: 0x06012C4B RID: 76875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C4B")]
		[Address(RVA = "0xAB4600", Offset = "0xAB3200", VA = "0x180AB4600")]
		protected void _OnBurstAbilityFinished(Ability ability, Ability.FinishReason reason, bool resetCd)
		{
		}

		// Token: 0x06012C4C RID: 76876 RVA: 0x00072F30 File Offset: 0x00071130
		[Token(Token = "0x6012C4C")]
		[Address(RVA = "0xAB3B90", Offset = "0xAB2790", VA = "0x180AB3B90", Slot = "32")]
		public override bool CastToTarget(Entity target, [Optional] Ability.FinishCallbackDelegate finishCb, bool firstAttack = true)
		{
			return default(bool);
		}

		// Token: 0x06012C4D RID: 76877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C4D")]
		[Address(RVA = "0xAB40C0", Offset = "0xAB2CC0", VA = "0x180AB40C0", Slot = "51")]
		protected override void OnCastEnd(Ability.FinishReason reason)
		{
		}

		// Token: 0x06012C4E RID: 76878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C4E")]
		[Address(RVA = "0xAB41C0", Offset = "0xAB2DC0", VA = "0x180AB41C0", Slot = "58")]
		public override void PreloadSpecialAudioSignals(string abilityId, string tmplId, Action<string, string> preloader)
		{
		}

		// Token: 0x06012C4F RID: 76879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C4F")]
		[Address(RVA = "0xAB3D70", Offset = "0xAB2970", VA = "0x180AB3D70", Slot = "29")]
		protected override void DoAttach(Entity owner)
		{
		}

		// Token: 0x06012C50 RID: 76880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C50")]
		[Address(RVA = "0xAB3E20", Offset = "0xAB2A20", VA = "0x180AB3E20", Slot = "30")]
		protected override void DoDetach()
		{
		}

		// Token: 0x06012C51 RID: 76881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C51")]
		[Address(RVA = "0xAB4000", Offset = "0xAB2C00", VA = "0x180AB4000")]
		public void OnBeforeBurstAttack([Optional] Ability.FinishCallbackDelegate finishCb)
		{
		}

		// Token: 0x06012C52 RID: 76882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C52")]
		[Address(RVA = "0xAB44F0", Offset = "0xAB30F0", VA = "0x180AB44F0")]
		private void _AddBeforeBurstAttackBuffToSelf()
		{
		}

		// Token: 0x06012C53 RID: 76883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C53")]
		[Address(RVA = "0xAB46B0", Offset = "0xAB32B0", VA = "0x180AB46B0")]
		public BurstAttackGroup()
		{
		}

		// Token: 0x06012C54 RID: 76884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C54")]
		[Address(RVA = "0xAB4490", Offset = "0xAB3090", VA = "0x180AB4490")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x06012C55 RID: 76885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C55")]
		[Address(RVA = "0xAB44E0", Offset = "0xAB30E0", VA = "0x180AB44E0")]
		private void <>xLuaBaseProxy_ResetCooldown(bool P0)
		{
		}

		// Token: 0x06012C56 RID: 76886 RVA: 0x00072F48 File Offset: 0x00071148
		[Token(Token = "0x6012C56")]
		[Address(RVA = "0xAB4450", Offset = "0xAB3050", VA = "0x180AB4450")]
		private bool <>xLuaBaseProxy_CastDirectly(Ability.FinishCallbackDelegate P0, bool P1)
		{
			return default(bool);
		}

		// Token: 0x06012C57 RID: 76887 RVA: 0x00072F60 File Offset: 0x00071160
		[Token(Token = "0x6012C57")]
		[Address(RVA = "0xAB4460", Offset = "0xAB3060", VA = "0x180AB4460")]
		private bool <>xLuaBaseProxy_CastToTarget(Entity P0, Ability.FinishCallbackDelegate P1, bool P2)
		{
			return default(bool);
		}

		// Token: 0x06012C58 RID: 76888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C58")]
		[Address(RVA = "0xAB44C0", Offset = "0xAB30C0", VA = "0x180AB44C0")]
		private void <>xLuaBaseProxy_OnCastEnd(Ability.FinishReason P0)
		{
		}

		// Token: 0x06012C59 RID: 76889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C59")]
		[Address(RVA = "0xAB44D0", Offset = "0xAB30D0", VA = "0x180AB44D0")]
		private void <>xLuaBaseProxy_PreloadSpecialAudioSignals(string P0, string P1, Action<string, string> P2)
		{
		}

		// Token: 0x06012C5A RID: 76890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C5A")]
		[Address(RVA = "0xAB4470", Offset = "0xAB3070", VA = "0x180AB4470")]
		private void <>xLuaBaseProxy_DoAttach(Entity P0)
		{
		}

		// Token: 0x06012C5B RID: 76891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C5B")]
		[Address(RVA = "0xAB4480", Offset = "0xAB3080", VA = "0x180AB4480")]
		private void <>xLuaBaseProxy_DoDetach()
		{
		}

		// Token: 0x04015335 RID: 86837
		[Token(Token = "0x4015335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Ability.FinishCallbackDelegate m_onBurstAttackCasted;

		// Token: 0x04015336 RID: 86838
		[Token(Token = "0x4015336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		[SerializeField]
		private AbilitySelectableGroup.AbilityConfigs _burstAttack;

		// Token: 0x04015337 RID: 86839
		[Token(Token = "0x4015337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		[SerializeField]
		private BuffData[] _buffBeforeBurstAttackToOwner;

		// Token: 0x04015338 RID: 86840
		[Token(Token = "0x4015338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isDuringBurstAttack;

		// Token: 0x04015339 RID: 86841
		[Token(Token = "0x4015339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x0401533A RID: 86842
		[Token(Token = "0x401533A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ResetCooldown;

		// Token: 0x0401533B RID: 86843
		[Token(Token = "0x401533B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CastDirectly;

		// Token: 0x0401533C RID: 86844
		[Token(Token = "0x401533C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnBurstAbilityFinished;

		// Token: 0x0401533D RID: 86845
		[Token(Token = "0x401533D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CastToTarget;

		// Token: 0x0401533E RID: 86846
		[Token(Token = "0x401533E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnCastEnd;

		// Token: 0x0401533F RID: 86847
		[Token(Token = "0x401533F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_PreloadSpecialAudioSignals;

		// Token: 0x04015340 RID: 86848
		[Token(Token = "0x4015340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04015341 RID: 86849
		[Token(Token = "0x4015341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x04015342 RID: 86850
		[Token(Token = "0x4015342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnBeforeBurstAttack;

		// Token: 0x04015343 RID: 86851
		[Token(Token = "0x4015343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__AddBeforeBurstAttackBuffToSelf;

		// Token: 0x04015344 RID: 86852
		[Token(Token = "0x4015344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
