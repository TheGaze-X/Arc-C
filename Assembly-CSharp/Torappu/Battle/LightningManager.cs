using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200232E RID: 9006
	[Token(Token = "0x200232E")]
	public class LightningManager : GlobalEnvSystem.EnvManager
	{
		// Token: 0x0600E388 RID: 58248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E388")]
		[Address(RVA = "0x57F980", Offset = "0x57E580", VA = "0x18057F980", Slot = "7")]
		public override void Init(GlobalEnvSystem system)
		{
		}

		// Token: 0x0600E389 RID: 58249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E389")]
		[Address(RVA = "0x57FE10", Offset = "0x57EA10", VA = "0x18057FE10", Slot = "12")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600E38A RID: 58250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E38A")]
		[Address(RVA = "0x57FF10", Offset = "0x57EB10", VA = "0x18057FF10")]
		private void TryTriggerLightning()
		{
		}

		// Token: 0x0600E38B RID: 58251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E38B")]
		[Address(RVA = "0x5800F0", Offset = "0x57ECF0", VA = "0x1805800F0")]
		private List<Tile> _GetPrioritizedTargets()
		{
			return null;
		}

		// Token: 0x0600E38C RID: 58252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E38C")]
		[Address(RVA = "0x57F780", Offset = "0x57E380", VA = "0x18057F780")]
		private void EmitEvnet(string value)
		{
		}

		// Token: 0x0600E38D RID: 58253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E38D")]
		[Address(RVA = "0x57F810", Offset = "0x57E410", VA = "0x18057F810", Slot = "9")]
		public override void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x0600E38E RID: 58254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E38E")]
		[Address(RVA = "0x580460", Offset = "0x57F060", VA = "0x180580460")]
		public LightningManager()
		{
		}

		// Token: 0x0600E390 RID: 58256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E390")]
		[Address(RVA = "0x550BE0", Offset = "0x54F7E0", VA = "0x180550BE0")]
		private void <>xLuaBaseProxy_Init(GlobalEnvSystem P0)
		{
		}

		// Token: 0x0600E391 RID: 58257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E391")]
		[Address(RVA = "0x550C00", Offset = "0x54F800", VA = "0x180550C00")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0600E392 RID: 58258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E392")]
		[Address(RVA = "0x550BD0", Offset = "0x54F7D0", VA = "0x180550BD0")]
		private void <>xLuaBaseProxy_GatherEffects(List<string> P0)
		{
		}

		// Token: 0x0400FA02 RID: 64002
		[Token(Token = "0x400FA02")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _readyToLightningStatus;

		// Token: 0x0400FA03 RID: 64003
		[Token(Token = "0x400FA03")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _lightningStatus;

		// Token: 0x0400FA04 RID: 64004
		[Token(Token = "0x400FA04")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<LightningManager.DirectionEffectSetting> _effectSettings;

		// Token: 0x0400FA05 RID: 64005
		[Token(Token = "0x400FA05")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<string> _prioritizedTargetId;

		// Token: 0x0400FA06 RID: 64006
		[Token(Token = "0x400FA06")]
		[FieldOffset(Offset = "0x48")]
		private PeriodicTimer m_intervalTicker;

		// Token: 0x0400FA07 RID: 64007
		[Token(Token = "0x400FA07")]
		[FieldOffset(Offset = "0x50")]
		private List<Tile> m_tiles;

		// Token: 0x0400FA08 RID: 64008
		[Token(Token = "0x400FA08")]
		[FieldOffset(Offset = "0x58")]
		private List<Tile> m_targeTiles;

		// Token: 0x0400FA09 RID: 64009
		[Token(Token = "0x400FA09")]
		[FieldOffset(Offset = "0x60")]
		private int m_tileCount;

		// Token: 0x0400FA0A RID: 64010
		[Token(Token = "0x400FA0A")]
		[FieldOffset(Offset = "0x68")]
		private FP m_interval;

		// Token: 0x0400FA0B RID: 64011
		[Token(Token = "0x400FA0B")]
		[FieldOffset(Offset = "0x70")]
		private FP m_delayToDamage;

		// Token: 0x0400FA0C RID: 64012
		[Token(Token = "0x400FA0C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400FA0D RID: 64013
		[Token(Token = "0x400FA0D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0400FA0E RID: 64014
		[Token(Token = "0x400FA0E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_TryTriggerLightning;

		// Token: 0x0400FA0F RID: 64015
		[Token(Token = "0x400FA0F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetPrioritizedTargets;

		// Token: 0x0400FA10 RID: 64016
		[Token(Token = "0x400FA10")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EmitEvnet;

		// Token: 0x0400FA11 RID: 64017
		[Token(Token = "0x400FA11")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x0400FA12 RID: 64018
		[Token(Token = "0x400FA12")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200232F RID: 9007
		[Token(Token = "0x200232F")]
		[Serializable]
		private struct DirectionEffectSetting
		{
			// Token: 0x0400FA13 RID: 64019
			[Token(Token = "0x400FA13")]
			[FieldOffset(Offset = "0x0")]
			public int effectLevel;

			// Token: 0x0400FA14 RID: 64020
			[Token(Token = "0x400FA14")]
			[FieldOffset(Offset = "0x8")]
			public string effectKey;
		}
	}
}
