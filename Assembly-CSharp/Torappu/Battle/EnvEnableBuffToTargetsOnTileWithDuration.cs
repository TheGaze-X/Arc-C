using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200228B RID: 8843
	[Token(Token = "0x200228B")]
	public class EnvEnableBuffToTargetsOnTileWithDuration : EnvEnableBuffToTargetsOnTile
	{
		// Token: 0x0600DE81 RID: 56961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE81")]
		[Address(RVA = "0x36505C0", Offset = "0x364F1C0", VA = "0x1836505C0", Slot = "7")]
		public override void Init(GlobalEnvSystem system)
		{
		}

		// Token: 0x0600DE82 RID: 56962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE82")]
		[Address(RVA = "0x3650AB0", Offset = "0x364F6B0", VA = "0x183650AB0", Slot = "20")]
		protected override void _OnAttachStatus(Tile tile)
		{
		}

		// Token: 0x0600DE83 RID: 56963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE83")]
		[Address(RVA = "0x3650800", Offset = "0x364F400", VA = "0x183650800", Slot = "12")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600DE84 RID: 56964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE84")]
		[Address(RVA = "0x3650C00", Offset = "0x364F800", VA = "0x183650C00")]
		public EnvEnableBuffToTargetsOnTileWithDuration()
		{
		}

		// Token: 0x0600DE85 RID: 56965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE85")]
		[Address(RVA = "0x3650A80", Offset = "0x364F680", VA = "0x183650A80")]
		private void <>xLuaBaseProxy_Init(GlobalEnvSystem P0)
		{
		}

		// Token: 0x0600DE86 RID: 56966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE86")]
		[Address(RVA = "0x3650AA0", Offset = "0x364F6A0", VA = "0x183650AA0")]
		private void <>xLuaBaseProxy__OnAttachStatus(Tile P0)
		{
		}

		// Token: 0x0600DE87 RID: 56967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE87")]
		[Address(RVA = "0x3650A90", Offset = "0x364F690", VA = "0x183650A90")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0400F168 RID: 61800
		[Token(Token = "0x400F168")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private float _listenerDuration;

		// Token: 0x0400F169 RID: 61801
		[Token(Token = "0x400F169")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private string _listenerDurationKey;

		// Token: 0x0400F16A RID: 61802
		[Token(Token = "0x400F16A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400F16B RID: 61803
		[Token(Token = "0x400F16B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnAttachStatus;

		// Token: 0x0400F16C RID: 61804
		[Token(Token = "0x400F16C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0400F16D RID: 61805
		[Token(Token = "0x400F16D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200228C RID: 8844
		[Token(Token = "0x200228C")]
		private class TargetOnTileListenerWithDuration : EnvEnableBuffToTargetsOnTile.TargetOnTileListener
		{
			// Token: 0x17001BF2 RID: 7154
			// (get) Token: 0x0600DE88 RID: 56968 RVA: 0x00051060 File Offset: 0x0004F260
			[Token(Token = "0x17001BF2")]
			public bool overTime
			{
				[Token(Token = "0x600DE88")]
				[Address(RVA = "0x365B640", Offset = "0x365A240", VA = "0x18365B640")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600DE89 RID: 56969 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600DE89")]
			[Address(RVA = "0x365B0A0", Offset = "0x3659CA0", VA = "0x18365B0A0")]
			public new static EnvEnableBuffToTargetsOnTileWithDuration.TargetOnTileListenerWithDuration CreateListener()
			{
				return null;
			}

			// Token: 0x0600DE8A RID: 56970 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DE8A")]
			[Address(RVA = "0x365B2A0", Offset = "0x3659EA0", VA = "0x18365B2A0", Slot = "10")]
			public override void Reset(Tile tile, EnvEnableBuffToTargetsOnTile executer)
			{
			}

			// Token: 0x0600DE8B RID: 56971 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DE8B")]
			[Address(RVA = "0x365B400", Offset = "0x365A000", VA = "0x18365B400", Slot = "13")]
			public override void SetEnabled(bool enabled)
			{
			}

			// Token: 0x0600DE8C RID: 56972 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DE8C")]
			[Address(RVA = "0x365B1C0", Offset = "0x3659DC0", VA = "0x18365B1C0", Slot = "11")]
			public override void OnLocatedCharacterUpdate(Character character)
			{
			}

			// Token: 0x0600DE8D RID: 56973 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DE8D")]
			[Address(RVA = "0x365B220", Offset = "0x3659E20", VA = "0x18365B220")]
			public void ResetDuration()
			{
			}

			// Token: 0x0600DE8E RID: 56974 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DE8E")]
			[Address(RVA = "0x365B5A0", Offset = "0x365A1A0", VA = "0x18365B5A0")]
			public TargetOnTileListenerWithDuration()
			{
			}

			// Token: 0x0600DE8F RID: 56975 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DE8F")]
			[Address(RVA = "0x365B580", Offset = "0x365A180", VA = "0x18365B580")]
			private void <>xLuaBaseProxy_Reset(Tile P0, EnvEnableBuffToTargetsOnTile P1)
			{
			}

			// Token: 0x0600DE90 RID: 56976 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DE90")]
			[Address(RVA = "0x365B590", Offset = "0x365A190", VA = "0x18365B590")]
			private void <>xLuaBaseProxy_SetEnabled(bool P0)
			{
			}

			// Token: 0x0600DE91 RID: 56977 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DE91")]
			[Address(RVA = "0x365B490", Offset = "0x365A090", VA = "0x18365B490")]
			private void <>xLuaBaseProxy_OnLocatedCharacterUpdate(Character P0)
			{
			}

			// Token: 0x0400F16E RID: 61806
			[Token(Token = "0x400F16E")]
			[FieldOffset(Offset = "0x38")]
			private FP m_duration;

			// Token: 0x0400F16F RID: 61807
			[Token(Token = "0x400F16F")]
			[FieldOffset(Offset = "0x40")]
			private FP m_startTime;

			// Token: 0x0400F170 RID: 61808
			[Token(Token = "0x400F170")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_overTime;

			// Token: 0x0400F171 RID: 61809
			[Token(Token = "0x400F171")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_CreateListener;

			// Token: 0x0400F172 RID: 61810
			[Token(Token = "0x400F172")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_Reset;

			// Token: 0x0400F173 RID: 61811
			[Token(Token = "0x400F173")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_SetEnabled;

			// Token: 0x0400F174 RID: 61812
			[Token(Token = "0x400F174")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_OnLocatedCharacterUpdate;

			// Token: 0x0400F175 RID: 61813
			[Token(Token = "0x400F175")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_ResetDuration;

			// Token: 0x0400F176 RID: 61814
			[Token(Token = "0x400F176")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
