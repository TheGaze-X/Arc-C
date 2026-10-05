using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200227B RID: 8827
	[Token(Token = "0x200227B")]
	public class SharedRandomTileGlobalBuff : RandomTileGlobalBuff
	{
		// Token: 0x17001BEC RID: 7148
		// (get) Token: 0x0600DE04 RID: 56836 RVA: 0x00050F28 File Offset: 0x0004F128
		[Token(Token = "0x17001BEC")]
		private bool tickForEnemy
		{
			[Token(Token = "0x600DE04")]
			[Address(RVA = "0x3640F90", Offset = "0x363FB90", VA = "0x183640F90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600DE05 RID: 56837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE05")]
		[Address(RVA = "0x363FCE0", Offset = "0x363E8E0", VA = "0x18363FCE0")]
		public static void ClearStaticVariables()
		{
		}

		// Token: 0x0600DE06 RID: 56838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE06")]
		[Address(RVA = "0x363FD80", Offset = "0x363E980", VA = "0x18363FD80", Slot = "11")]
		public override void OnInit(LevelData.GlobalBuffData data)
		{
		}

		// Token: 0x0600DE07 RID: 56839 RVA: 0x00050F40 File Offset: 0x0004F140
		[Token(Token = "0x600DE07")]
		[Address(RVA = "0x3640470", Offset = "0x363F070", VA = "0x183640470", Slot = "19")]
		public override bool TryAddBindingTiles(List<Tile> tiles)
		{
			return default(bool);
		}

		// Token: 0x0600DE08 RID: 56840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE08")]
		[Address(RVA = "0x3640080", Offset = "0x363EC80", VA = "0x183640080", Slot = "9")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600DE09 RID: 56841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE09")]
		[Address(RVA = "0x363FF70", Offset = "0x363EB70", VA = "0x18363FF70", Slot = "14")]
		public override void OnRemoved()
		{
		}

		// Token: 0x0600DE0A RID: 56842 RVA: 0x00050F58 File Offset: 0x0004F158
		[Token(Token = "0x600DE0A")]
		[Address(RVA = "0x3640840", Offset = "0x363F440", VA = "0x183640840", Slot = "18")]
		protected override bool VerifyUnitTile(Unit unit, bool isInit = true)
		{
			return default(bool);
		}

		// Token: 0x0600DE0B RID: 56843 RVA: 0x00050F70 File Offset: 0x0004F170
		[Token(Token = "0x600DE0B")]
		[Address(RVA = "0x363EF90", Offset = "0x363DB90", VA = "0x18363EF90", Slot = "20")]
		protected override bool FilterTile(Tile tile)
		{
			return default(bool);
		}

		// Token: 0x0600DE0C RID: 56844 RVA: 0x00050F88 File Offset: 0x0004F188
		[Token(Token = "0x600DE0C")]
		[Address(RVA = "0x3640AF0", Offset = "0x363F6F0", VA = "0x183640AF0")]
		private bool _CheckEnemyContainsAnyBuff(Enemy enemy)
		{
			return default(bool);
		}

		// Token: 0x0600DE0D RID: 56845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE0D")]
		[Address(RVA = "0x3640C80", Offset = "0x363F880", VA = "0x183640C80")]
		private void _FinishBuffForEnemy(Enemy enemy)
		{
		}

		// Token: 0x0600DE0E RID: 56846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE0E")]
		[Address(RVA = "0x3640E80", Offset = "0x363FA80", VA = "0x183640E80")]
		public SharedRandomTileGlobalBuff()
		{
		}

		// Token: 0x0600DE10 RID: 56848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE10")]
		[Address(RVA = "0x362D9B0", Offset = "0x362C5B0", VA = "0x18362D9B0")]
		private void <>xLuaBaseProxy_OnInit(LevelData.GlobalBuffData P0)
		{
		}

		// Token: 0x0600DE11 RID: 56849 RVA: 0x00050FA0 File Offset: 0x0004F1A0
		[Token(Token = "0x600DE11")]
		[Address(RVA = "0x3640830", Offset = "0x363F430", VA = "0x183640830")]
		private bool <>xLuaBaseProxy_TryAddBindingTiles(List<Tile> P0)
		{
			return default(bool);
		}

		// Token: 0x0600DE12 RID: 56850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE12")]
		[Address(RVA = "0x362C380", Offset = "0x362AF80", VA = "0x18362C380")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0600DE13 RID: 56851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE13")]
		[Address(RVA = "0x3640820", Offset = "0x363F420", VA = "0x183640820")]
		private void <>xLuaBaseProxy_OnRemoved()
		{
		}

		// Token: 0x0600DE14 RID: 56852 RVA: 0x00050FB8 File Offset: 0x0004F1B8
		[Token(Token = "0x600DE14")]
		[Address(RVA = "0x363CC00", Offset = "0x363B800", VA = "0x18363CC00")]
		private bool <>xLuaBaseProxy_FilterTile(Tile P0)
		{
			return default(bool);
		}

		// Token: 0x0400F0C4 RID: 61636
		[Token(Token = "0x400F0C4")]
		[FieldOffset(Offset = "0x0")]
		protected static List<GridPosition> s_targetTiles;

		// Token: 0x0400F0C5 RID: 61637
		[Token(Token = "0x400F0C5")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		private bool _tickForEnemy;

		// Token: 0x0400F0C6 RID: 61638
		[Token(Token = "0x400F0C6")]
		[FieldOffset(Offset = "0x174")]
		[SerializeField]
		[Inspect("tickForEnemy")]
		private float _tickInterval;

		// Token: 0x0400F0C7 RID: 61639
		[Token(Token = "0x400F0C7")]
		[FieldOffset(Offset = "0x178")]
		private PeriodicTimer m_timer;

		// Token: 0x0400F0C8 RID: 61640
		[Token(Token = "0x400F0C8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_tickForEnemy;

		// Token: 0x0400F0C9 RID: 61641
		[Token(Token = "0x400F0C9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ClearStaticVariables;

		// Token: 0x0400F0CA RID: 61642
		[Token(Token = "0x400F0CA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400F0CB RID: 61643
		[Token(Token = "0x400F0CB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_TryAddBindingTiles;

		// Token: 0x0400F0CC RID: 61644
		[Token(Token = "0x400F0CC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0400F0CD RID: 61645
		[Token(Token = "0x400F0CD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnRemoved;

		// Token: 0x0400F0CE RID: 61646
		[Token(Token = "0x400F0CE")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_VerifyUnitTile;

		// Token: 0x0400F0CF RID: 61647
		[Token(Token = "0x400F0CF")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_FilterTile;

		// Token: 0x0400F0D0 RID: 61648
		[Token(Token = "0x400F0D0")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__CheckEnemyContainsAnyBuff;

		// Token: 0x0400F0D1 RID: 61649
		[Token(Token = "0x400F0D1")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__FinishBuffForEnemy;

		// Token: 0x0400F0D2 RID: 61650
		[Token(Token = "0x400F0D2")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
