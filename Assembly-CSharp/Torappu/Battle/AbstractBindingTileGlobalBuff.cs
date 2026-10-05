using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002264 RID: 8804
	[Token(Token = "0x2002264")]
	public abstract class AbstractBindingTileGlobalBuff : GlobalBuff
	{
		// Token: 0x17001BE2 RID: 7138
		// (get) Token: 0x0600DD5A RID: 56666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001BE2")]
		protected List<GridPosition> targetTiles
		{
			[Token(Token = "0x600DD5A")]
			[Address(RVA = "0x362AE20", Offset = "0x3629A20", VA = "0x18362AE20")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001BE3 RID: 7139
		// (get) Token: 0x0600DD5B RID: 56667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001BE3")]
		protected string tileEffect
		{
			[Token(Token = "0x600DD5B")]
			[Address(RVA = "0x362AE80", Offset = "0x3629A80", VA = "0x18362AE80")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600DD5C RID: 56668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD5C")]
		[Address(RVA = "0x362A520", Offset = "0x3629120", VA = "0x18362A520", Slot = "11")]
		public override void OnInit(LevelData.GlobalBuffData data)
		{
		}

		// Token: 0x0600DD5D RID: 56669
		[Token(Token = "0x600DD5D")]
		protected abstract List<GridPosition> SelectTiles(bool excludeBorderTiles = false);

		// Token: 0x0600DD5E RID: 56670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD5E")]
		[Address(RVA = "0x362AA20", Offset = "0x3629620", VA = "0x18362AA20", Slot = "12")]
		public override void TryAddBuff(Unit unit, bool isInit = true)
		{
		}

		// Token: 0x0600DD5F RID: 56671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD5F")]
		[Address(RVA = "0x362A460", Offset = "0x3629060", VA = "0x18362A460", Slot = "10")]
		public override void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x0600DD60 RID: 56672 RVA: 0x00050CB8 File Offset: 0x0004EEB8
		[Token(Token = "0x600DD60")]
		[Address(RVA = "0x362AB80", Offset = "0x3629780", VA = "0x18362AB80", Slot = "18")]
		protected virtual bool VerifyUnitTile(Unit unit, bool isInit)
		{
			return default(bool);
		}

		// Token: 0x0600DD61 RID: 56673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD61")]
		[Address(RVA = "0x362A840", Offset = "0x3629440", VA = "0x18362A840", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600DD62 RID: 56674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD62")]
		[Address(RVA = "0x362AD10", Offset = "0x3629910", VA = "0x18362AD10")]
		protected AbstractBindingTileGlobalBuff()
		{
		}

		// Token: 0x0600DD63 RID: 56675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD63")]
		[Address(RVA = "0x362AB00", Offset = "0x3629700", VA = "0x18362AB00")]
		private void <>xLuaBaseProxy_OnInit(LevelData.GlobalBuffData P0)
		{
		}

		// Token: 0x0600DD64 RID: 56676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD64")]
		[Address(RVA = "0x362AB70", Offset = "0x3629770", VA = "0x18362AB70")]
		private void <>xLuaBaseProxy_TryAddBuff(Unit P0, bool P1)
		{
		}

		// Token: 0x0600DD65 RID: 56677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD65")]
		[Address(RVA = "0x362AAF0", Offset = "0x36296F0", VA = "0x18362AAF0")]
		private void <>xLuaBaseProxy_GatherEffects(List<string> P0)
		{
		}

		// Token: 0x0600DD66 RID: 56678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD66")]
		[Address(RVA = "0x362AB10", Offset = "0x3629710", VA = "0x18362AB10")]
		private void <>xLuaBaseProxy_OnReset()
		{
		}

		// Token: 0x0400EFCC RID: 61388
		[Token(Token = "0x400EFCC")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		[Group("BindingTile")]
		private string _tileEffect;

		// Token: 0x0400EFCD RID: 61389
		[Token(Token = "0x400EFCD")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		[Group("BindingTile")]
		protected bool _excludeBorderTiles;

		// Token: 0x0400EFCE RID: 61390
		[Token(Token = "0x400EFCE")]
		[FieldOffset(Offset = "0x158")]
		private List<GridPosition> m_targetTiles;

		// Token: 0x0400EFCF RID: 61391
		[Token(Token = "0x400EFCF")]
		[FieldOffset(Offset = "0x160")]
		private List<ObjectPtr<Effect>> m_tileEffects;

		// Token: 0x0400EFD0 RID: 61392
		[Token(Token = "0x400EFD0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_targetTiles;

		// Token: 0x0400EFD1 RID: 61393
		[Token(Token = "0x400EFD1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_tileEffect;

		// Token: 0x0400EFD2 RID: 61394
		[Token(Token = "0x400EFD2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400EFD3 RID: 61395
		[Token(Token = "0x400EFD3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_TryAddBuff;

		// Token: 0x0400EFD4 RID: 61396
		[Token(Token = "0x400EFD4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x0400EFD5 RID: 61397
		[Token(Token = "0x400EFD5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_VerifyUnitTile;

		// Token: 0x0400EFD6 RID: 61398
		[Token(Token = "0x400EFD6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x0400EFD7 RID: 61399
		[Token(Token = "0x400EFD7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
