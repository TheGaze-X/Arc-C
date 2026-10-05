using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B7C RID: 11132
	[Token(Token = "0x2002B7C")]
	public class ActiveTraceTileAbility : BaseTraceTargetAbility
	{
		// Token: 0x17002930 RID: 10544
		// (get) Token: 0x06012B50 RID: 76624 RVA: 0x000729D8 File Offset: 0x00070BD8
		[Token(Token = "0x17002930")]
		public override Ability.Category category
		{
			[Token(Token = "0x6012B50")]
			[Address(RVA = "0xAAB3B0", Offset = "0xAA9FB0", VA = "0x180AAB3B0", Slot = "13")]
			get
			{
				return Ability.Category.NONE;
			}
		}

		// Token: 0x17002931 RID: 10545
		// (get) Token: 0x06012B51 RID: 76625 RVA: 0x000729F0 File Offset: 0x00070BF0
		[Token(Token = "0x17002931")]
		public override bool isAffecting
		{
			[Token(Token = "0x6012B51")]
			[Address(RVA = "0xAAB410", Offset = "0xAAA010", VA = "0x180AAB410", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002932 RID: 10546
		// (get) Token: 0x06012B52 RID: 76626 RVA: 0x00072A08 File Offset: 0x00070C08
		[Token(Token = "0x17002932")]
		public override bool isReady
		{
			[Token(Token = "0x6012B52")]
			[Address(RVA = "0xAAB490", Offset = "0xAAA090", VA = "0x180AAB490", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06012B53 RID: 76627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B53")]
		[Address(RVA = "0xAAA6B0", Offset = "0xAA92B0", VA = "0x180AAA6B0", Slot = "31")]
		public override void OnOwnerLocated()
		{
		}

		// Token: 0x06012B54 RID: 76628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B54")]
		[Address(RVA = "0xAAA5C0", Offset = "0xAA91C0", VA = "0x180AAA5C0", Slot = "52")]
		protected override void OnAttached()
		{
		}

		// Token: 0x06012B55 RID: 76629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B55")]
		[Address(RVA = "0xAAA630", Offset = "0xAA9230", VA = "0x180AAA630", Slot = "53")]
		protected override void OnDetached()
		{
		}

		// Token: 0x06012B56 RID: 76630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B56")]
		[Address(RVA = "0xAAA930", Offset = "0xAA9530", VA = "0x180AAA930", Slot = "40")]
		protected override void Reset()
		{
		}

		// Token: 0x06012B57 RID: 76631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B57")]
		[Address(RVA = "0xAAAA10", Offset = "0xAA9610", VA = "0x180AAAA10", Slot = "105")]
		public override void SetEnableTrace(bool enable)
		{
		}

		// Token: 0x06012B58 RID: 76632 RVA: 0x00072A20 File Offset: 0x00070C20
		[Token(Token = "0x6012B58")]
		[Address(RVA = "0xAAA220", Offset = "0xAA8E20", VA = "0x180AAA220", Slot = "33")]
		public override bool CastDirectly([Optional] Ability.FinishCallbackDelegate finishCb, bool firstAttack = true)
		{
			return default(bool);
		}

		// Token: 0x06012B59 RID: 76633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B59")]
		[Address(RVA = "0xAAA820", Offset = "0xAA9420", VA = "0x180AAA820", Slot = "54")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06012B5A RID: 76634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B5A")]
		[Address(RVA = "0xAAADE0", Offset = "0xAA99E0", VA = "0x180AAADE0")]
		private void _CheckReached()
		{
		}

		// Token: 0x06012B5B RID: 76635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B5B")]
		[Address(RVA = "0xAAAA90", Offset = "0xAA9690", VA = "0x180AAAA90", Slot = "39")]
		public override void StopAffect()
		{
		}

		// Token: 0x06012B5C RID: 76636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B5C")]
		[Address(RVA = "0xAAB000", Offset = "0xAA9C00", VA = "0x180AAB000")]
		private void _CleanTraceTile()
		{
		}

		// Token: 0x06012B5D RID: 76637 RVA: 0x00072A38 File Offset: 0x00070C38
		[Token(Token = "0x6012B5D")]
		[Address(RVA = "0xAAABB0", Offset = "0xAA97B0", VA = "0x180AAABB0")]
		public bool TryGetTraceTilesBySelector(Entity target, ref List<Tile> tiles)
		{
			return default(bool);
		}

		// Token: 0x06012B5E RID: 76638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B5E")]
		[Address(RVA = "0xAAB120", Offset = "0xAA9D20", VA = "0x180AAB120")]
		private void _CreateReachedBuff()
		{
		}

		// Token: 0x06012B5F RID: 76639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B5F")]
		[Address(RVA = "0xAAA510", Offset = "0xAA9110", VA = "0x180AAA510", Slot = "49")]
		public override void GatherBuffs(List<BuffData> buffs)
		{
		}

		// Token: 0x06012B60 RID: 76640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B60")]
		[Address(RVA = "0xAAB280", Offset = "0xAA9E80", VA = "0x180AAB280")]
		public ActiveTraceTileAbility()
		{
		}

		// Token: 0x06012B61 RID: 76641 RVA: 0x00072A50 File Offset: 0x00070C50
		[Token(Token = "0x6012B61")]
		[Address(RVA = "0xAAAD80", Offset = "0xAA9980", VA = "0x180AAAD80")]
		private Ability.Category <>xLuaBaseProxy_get_category()
		{
			return Ability.Category.NONE;
		}

		// Token: 0x06012B62 RID: 76642 RVA: 0x00072A68 File Offset: 0x00070C68
		[Token(Token = "0x6012B62")]
		[Address(RVA = "0xA4D200", Offset = "0xA4BE00", VA = "0x180A4D200")]
		private bool <>xLuaBaseProxy_get_isAffecting()
		{
			return default(bool);
		}

		// Token: 0x06012B63 RID: 76643 RVA: 0x00072A80 File Offset: 0x00070C80
		[Token(Token = "0x6012B63")]
		[Address(RVA = "0xA38720", Offset = "0xA37320", VA = "0x180A38720")]
		private bool <>xLuaBaseProxy_get_isReady()
		{
			return default(bool);
		}

		// Token: 0x06012B64 RID: 76644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B64")]
		[Address(RVA = "0xA82F00", Offset = "0xA81B00", VA = "0x180A82F00")]
		private void <>xLuaBaseProxy_OnOwnerLocated()
		{
		}

		// Token: 0x06012B65 RID: 76645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B65")]
		[Address(RVA = "0xAAACF0", Offset = "0xAA98F0", VA = "0x180AAACF0")]
		private void <>xLuaBaseProxy_OnAttached()
		{
		}

		// Token: 0x06012B66 RID: 76646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B66")]
		[Address(RVA = "0xAAAD00", Offset = "0xAA9900", VA = "0x180AAAD00")]
		private void <>xLuaBaseProxy_OnDetached()
		{
		}

		// Token: 0x06012B67 RID: 76647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B67")]
		[Address(RVA = "0xA4B0B0", Offset = "0xA49CB0", VA = "0x180A4B0B0")]
		private void <>xLuaBaseProxy_Reset()
		{
		}

		// Token: 0x06012B68 RID: 76648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B68")]
		[Address(RVA = "0xAAAD10", Offset = "0xAA9910", VA = "0x180AAAD10")]
		private void <>xLuaBaseProxy_SetEnableTrace(bool P0)
		{
		}

		// Token: 0x06012B69 RID: 76649 RVA: 0x00072A98 File Offset: 0x00070C98
		[Token(Token = "0x6012B69")]
		[Address(RVA = "0xA225E0", Offset = "0xA211E0", VA = "0x180A225E0")]
		private bool <>xLuaBaseProxy_CastDirectly(Ability.FinishCallbackDelegate P0, bool P1)
		{
			return default(bool);
		}

		// Token: 0x06012B6A RID: 76650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B6A")]
		[Address(RVA = "0xA38EF0", Offset = "0xA37AF0", VA = "0x180A38EF0")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x06012B6B RID: 76651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B6B")]
		[Address(RVA = "0xA4D1E0", Offset = "0xA4BDE0", VA = "0x180A4D1E0")]
		private void <>xLuaBaseProxy_StopAffect()
		{
		}

		// Token: 0x06012B6C RID: 76652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B6C")]
		[Address(RVA = "0xA56960", Offset = "0xA55560", VA = "0x180A56960")]
		private void <>xLuaBaseProxy_GatherBuffs(List<BuffData> P0)
		{
		}

		// Token: 0x0401523C RID: 86588
		[Token(Token = "0x401523C")]
		private const float FIND_TRACE_TARGET_INTERVAL = 1f;

		// Token: 0x0401523D RID: 86589
		[Token(Token = "0x401523D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		[SerializeField]
		private TileSelector _traceTileSelector;

		// Token: 0x0401523E RID: 86590
		[Token(Token = "0x401523E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		[SerializeField]
		private BuffData[] _buffsWhenReached;

		// Token: 0x0401523F RID: 86591
		[Token(Token = "0x401523F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private List<Tile> s_candidateTiles;

		// Token: 0x04015240 RID: 86592
		[Token(Token = "0x4015240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private PeriodicTimer m_checkReachedTimer;

		// Token: 0x04015241 RID: 86593
		[Token(Token = "0x4015241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_category;

		// Token: 0x04015242 RID: 86594
		[Token(Token = "0x4015242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isAffecting;

		// Token: 0x04015243 RID: 86595
		[Token(Token = "0x4015243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isReady;

		// Token: 0x04015244 RID: 86596
		[Token(Token = "0x4015244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnOwnerLocated;

		// Token: 0x04015245 RID: 86597
		[Token(Token = "0x4015245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnAttached;

		// Token: 0x04015246 RID: 86598
		[Token(Token = "0x4015246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnDetached;

		// Token: 0x04015247 RID: 86599
		[Token(Token = "0x4015247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04015248 RID: 86600
		[Token(Token = "0x4015248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_SetEnableTrace;

		// Token: 0x04015249 RID: 86601
		[Token(Token = "0x4015249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CastDirectly;

		// Token: 0x0401524A RID: 86602
		[Token(Token = "0x401524A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0401524B RID: 86603
		[Token(Token = "0x401524B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__CheckReached;

		// Token: 0x0401524C RID: 86604
		[Token(Token = "0x401524C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_StopAffect;

		// Token: 0x0401524D RID: 86605
		[Token(Token = "0x401524D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__CleanTraceTile;

		// Token: 0x0401524E RID: 86606
		[Token(Token = "0x401524E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_TryGetTraceTilesBySelector;

		// Token: 0x0401524F RID: 86607
		[Token(Token = "0x401524F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__CreateReachedBuff;

		// Token: 0x04015250 RID: 86608
		[Token(Token = "0x4015250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x04015251 RID: 86609
		[Token(Token = "0x4015251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
