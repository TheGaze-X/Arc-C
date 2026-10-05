using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x02003276 RID: 12918
	[Token(Token = "0x2003276")]
	public class SwitchableWhenContainsEquipment : Effect.Behaviour, IEffectSource
	{
		// Token: 0x17003060 RID: 12384
		// (get) Token: 0x060147BC RID: 83900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003060")]
		public List<EquipmentEffectHookSchema> equipmentEffectHookSchemas
		{
			[Token(Token = "0x60147BC")]
			[Address(RVA = "0xCBF710", Offset = "0xCBE310", VA = "0x180CBF710")]
			get
			{
				return null;
			}
		}

		// Token: 0x060147BD RID: 83901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147BD")]
		[Address(RVA = "0xCBEE70", Offset = "0xCBDA70", VA = "0x180CBEE70", Slot = "5")]
		public override void OnPlay()
		{
		}

		// Token: 0x060147BE RID: 83902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147BE")]
		[Address(RVA = "0xCBED40", Offset = "0xCBD940", VA = "0x180CBED40", Slot = "6")]
		public override void OnFinish()
		{
		}

		// Token: 0x060147BF RID: 83903 RVA: 0x00086E80 File Offset: 0x00085080
		[Token(Token = "0x60147BF")]
		[Address(RVA = "0xCBE870", Offset = "0xCBD470", VA = "0x180CBE870")]
		public bool ContainsEquipmentPair(CharacterData.UniqueEquipPair uniqueEquipPair)
		{
			return default(bool);
		}

		// Token: 0x060147C0 RID: 83904 RVA: 0x00086E98 File Offset: 0x00085098
		[Token(Token = "0x60147C0")]
		[Address(RVA = "0xCBEEE0", Offset = "0xCBDAE0", VA = "0x180CBEEE0")]
		public bool TryGetEquipmentEffectHookSchema(CharacterData.UniqueEquipPair uniqueEquipPair, ref EquipmentEffectHookSchema outEquipmentEffectHookSchema)
		{
			return default(bool);
		}

		// Token: 0x060147C1 RID: 83905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147C1")]
		[Address(RVA = "0xCBF1B0", Offset = "0xCBDDB0", VA = "0x180CBF1B0")]
		private void _TrySpawnHookEffect()
		{
		}

		// Token: 0x060147C2 RID: 83906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147C2")]
		[Address(RVA = "0xCBF0D0", Offset = "0xCBDCD0", VA = "0x180CBF0D0")]
		private void _DestroySpawnedHookEffect()
		{
		}

		// Token: 0x060147C3 RID: 83907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147C3")]
		[Address(RVA = "0xCBEA30", Offset = "0xCBD630", VA = "0x180CBEA30", Slot = "10")]
		public void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x060147C4 RID: 83908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147C4")]
		[Address(RVA = "0xCBF660", Offset = "0xCBE260", VA = "0x180CBF660")]
		public SwitchableWhenContainsEquipment()
		{
		}

		// Token: 0x060147C5 RID: 83909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147C5")]
		[Address(RVA = "0xC99160", Offset = "0xC97D60", VA = "0x180C99160")]
		private void <>xLuaBaseProxy_OnPlay()
		{
		}

		// Token: 0x060147C6 RID: 83910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147C6")]
		[Address(RVA = "0xC99150", Offset = "0xC97D50", VA = "0x180C99150")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x04018369 RID: 99177
		[Token(Token = "0x4018369")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _pauseWhenSwitch;

		// Token: 0x0401836A RID: 99178
		[Token(Token = "0x401836A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<EquipmentEffectHookSchema> _equipmentEffectHookSchemas;

		// Token: 0x0401836B RID: 99179
		[Token(Token = "0x401836B")]
		[FieldOffset(Offset = "0x30")]
		private ObjectPtr<Effect> m_spawnedHookEffect;

		// Token: 0x0401836C RID: 99180
		[Token(Token = "0x401836C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_equipmentEffectHookSchemas;

		// Token: 0x0401836D RID: 99181
		[Token(Token = "0x401836D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnPlay;

		// Token: 0x0401836E RID: 99182
		[Token(Token = "0x401836E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x0401836F RID: 99183
		[Token(Token = "0x401836F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ContainsEquipmentPair;

		// Token: 0x04018370 RID: 99184
		[Token(Token = "0x4018370")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_TryGetEquipmentEffectHookSchema;

		// Token: 0x04018371 RID: 99185
		[Token(Token = "0x4018371")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__TrySpawnHookEffect;

		// Token: 0x04018372 RID: 99186
		[Token(Token = "0x4018372")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__DestroySpawnedHookEffect;

		// Token: 0x04018373 RID: 99187
		[Token(Token = "0x4018373")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x04018374 RID: 99188
		[Token(Token = "0x4018374")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
