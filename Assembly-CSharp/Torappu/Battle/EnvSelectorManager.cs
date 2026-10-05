using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200231F RID: 8991
	[Token(Token = "0x200231F")]
	public class EnvSelectorManager : GlobalEnvSystem.EnvManager
	{
		// Token: 0x17001C80 RID: 7296
		// (get) Token: 0x0600E328 RID: 58152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001C80")]
		public override IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> eventGroups
		{
			[Token(Token = "0x600E328")]
			[Address(RVA = "0x570830", Offset = "0x56F430", VA = "0x180570830", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600E329 RID: 58153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E329")]
		[Address(RVA = "0x56FBB0", Offset = "0x56E7B0", VA = "0x18056FBB0", Slot = "7")]
		public override void Init(GlobalEnvSystem system)
		{
		}

		// Token: 0x0600E32A RID: 58154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E32A")]
		[Address(RVA = "0x56FE10", Offset = "0x56EA10", VA = "0x18056FE10")]
		public void OnGameReady(object arg)
		{
		}

		// Token: 0x0600E32B RID: 58155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E32B")]
		[Address(RVA = "0x5700A0", Offset = "0x56ECA0", VA = "0x1805700A0", Slot = "12")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600E32C RID: 58156 RVA: 0x000524D0 File Offset: 0x000506D0
		[Token(Token = "0x600E32C")]
		[Address(RVA = "0x56FCE0", Offset = "0x56E8E0", VA = "0x18056FCE0")]
		private bool IsCharacter(Unit unit)
		{
			return default(bool);
		}

		// Token: 0x0600E32D RID: 58157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E32D")]
		[Address(RVA = "0x570230", Offset = "0x56EE30", VA = "0x180570230", Slot = "16")]
		protected virtual void SelectTargets(List<Entity> candidates)
		{
		}

		// Token: 0x0600E32E RID: 58158 RVA: 0x000524E8 File Offset: 0x000506E8
		[Token(Token = "0x600E32E")]
		[Address(RVA = "0x5704D0", Offset = "0x56F0D0", VA = "0x1805704D0", Slot = "17")]
		protected virtual bool VerifyTarget(Entity entity)
		{
			return default(bool);
		}

		// Token: 0x0600E32F RID: 58159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E32F")]
		[Address(RVA = "0x56FFF0", Offset = "0x56EBF0", VA = "0x18056FFF0", Slot = "18")]
		protected virtual void OnPostFilter(List<Entity> candidates)
		{
		}

		// Token: 0x0600E330 RID: 58160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E330")]
		[Address(RVA = "0x570720", Offset = "0x56F320", VA = "0x180570720")]
		public EnvSelectorManager()
		{
		}

		// Token: 0x0600E331 RID: 58161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E331")]
		[Address(RVA = "0x550C20", Offset = "0x54F820", VA = "0x180550C20")]
		private IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> <>xLuaBaseProxy_get_eventGroups()
		{
			return null;
		}

		// Token: 0x0600E332 RID: 58162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E332")]
		[Address(RVA = "0x550BE0", Offset = "0x54F7E0", VA = "0x180550BE0")]
		private void <>xLuaBaseProxy_Init(GlobalEnvSystem P0)
		{
		}

		// Token: 0x0600E333 RID: 58163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E333")]
		[Address(RVA = "0x550C00", Offset = "0x54F800", VA = "0x180550C00")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0400F965 RID: 63845
		[Token(Token = "0x400F965")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int _maxTargetNum;

		// Token: 0x0400F966 RID: 63846
		[Token(Token = "0x400F966")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private FilterUtil.FilterType _postFilter;

		// Token: 0x0400F967 RID: 63847
		[Token(Token = "0x400F967")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _entityToStatus;

		// Token: 0x0400F968 RID: 63848
		[Token(Token = "0x400F968")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TargetOptions _targetOptions;

		// Token: 0x0400F969 RID: 63849
		[Token(Token = "0x400F969")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private EnvSelectorManager.EffectSetting[] _cameraEffect;

		// Token: 0x0400F96A RID: 63850
		[Token(Token = "0x400F96A")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private string _intervalKey;

		// Token: 0x0400F96B RID: 63851
		[Token(Token = "0x400F96B")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private float _interval;

		// Token: 0x0400F96C RID: 63852
		[Token(Token = "0x400F96C")]
		[FieldOffset(Offset = "0xAC")]
		[SerializeField]
		private bool _characterWithProfessionOnly;

		// Token: 0x0400F96D RID: 63853
		[Token(Token = "0x400F96D")]
		[FieldOffset(Offset = "0xB0")]
		private PeriodicTimer m_intervalTicker;

		// Token: 0x0400F96E RID: 63854
		[Token(Token = "0x400F96E")]
		[FieldOffset(Offset = "0xB8")]
		private FP m_interval;

		// Token: 0x0400F96F RID: 63855
		[Token(Token = "0x400F96F")]
		[FieldOffset(Offset = "0xC0")]
		private List<Entity> m_candidates;

		// Token: 0x0400F970 RID: 63856
		[Token(Token = "0x400F970")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_eventGroups;

		// Token: 0x0400F971 RID: 63857
		[Token(Token = "0x400F971")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400F972 RID: 63858
		[Token(Token = "0x400F972")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnGameReady;

		// Token: 0x0400F973 RID: 63859
		[Token(Token = "0x400F973")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0400F974 RID: 63860
		[Token(Token = "0x400F974")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_IsCharacter;

		// Token: 0x0400F975 RID: 63861
		[Token(Token = "0x400F975")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SelectTargets;

		// Token: 0x0400F976 RID: 63862
		[Token(Token = "0x400F976")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_VerifyTarget;

		// Token: 0x0400F977 RID: 63863
		[Token(Token = "0x400F977")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnPostFilter;

		// Token: 0x0400F978 RID: 63864
		[Token(Token = "0x400F978")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002320 RID: 8992
		[Token(Token = "0x2002320")]
		[Serializable]
		private struct EffectSetting
		{
			// Token: 0x0400F979 RID: 63865
			[Token(Token = "0x400F979")]
			[FieldOffset(Offset = "0x0")]
			public int level;

			// Token: 0x0400F97A RID: 63866
			[Token(Token = "0x400F97A")]
			[FieldOffset(Offset = "0x8")]
			public string[] effects;
		}
	}
}
