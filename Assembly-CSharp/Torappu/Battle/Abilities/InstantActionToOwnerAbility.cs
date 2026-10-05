using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002A97 RID: 10903
	[Token(Token = "0x2002A97")]
	public class InstantActionToOwnerAbility : EmptyAbility, IActionNodeSource
	{
		// Token: 0x170027B7 RID: 10167
		// (get) Token: 0x0601218E RID: 74126 RVA: 0x0006EC70 File Offset: 0x0006CE70
		[Token(Token = "0x170027B7")]
		public override Ability.Category category
		{
			[Token(Token = "0x601218E")]
			[Address(RVA = "0xA23EC0", Offset = "0xA22AC0", VA = "0x180A23EC0", Slot = "13")]
			get
			{
				return Ability.Category.NONE;
			}
		}

		// Token: 0x170027B8 RID: 10168
		// (get) Token: 0x0601218F RID: 74127 RVA: 0x0006EC88 File Offset: 0x0006CE88
		[Token(Token = "0x170027B8")]
		public override AbilityStandard.SelectTargetSource selectTargetSource
		{
			[Token(Token = "0x601218F")]
			[Address(RVA = "0xA23F20", Offset = "0xA22B20", VA = "0x180A23F20", Slot = "65")]
			get
			{
				return AbilityStandard.SelectTargetSource.NONE;
			}
		}

		// Token: 0x170027B9 RID: 10169
		// (get) Token: 0x06012190 RID: 74128 RVA: 0x0006ECA0 File Offset: 0x0006CEA0
		[Token(Token = "0x170027B9")]
		protected override bool alwaysIncludeTarget
		{
			[Token(Token = "0x6012190")]
			[Address(RVA = "0xA23E60", Offset = "0xA22A60", VA = "0x180A23E60", Slot = "67")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170027BA RID: 10170
		// (get) Token: 0x06012191 RID: 74129 RVA: 0x0006ECB8 File Offset: 0x0006CEB8
		[Token(Token = "0x170027BA")]
		public override bool allowNoTarget
		{
			[Token(Token = "0x6012191")]
			[Address(RVA = "0xA23E00", Offset = "0xA22A00", VA = "0x180A23E00", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06012192 RID: 74130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012192")]
		[Address(RVA = "0xA23A10", Offset = "0xA22610", VA = "0x180A23A10", Slot = "48")]
		public override void GatherActionNodes(List<ActionNode> results)
		{
		}

		// Token: 0x06012193 RID: 74131 RVA: 0x0006ECD0 File Offset: 0x0006CED0
		[Token(Token = "0x6012193")]
		[Address(RVA = "0xA23AB0", Offset = "0xA226B0", VA = "0x180A23AB0", Slot = "78")]
		protected override bool OnSpellStart()
		{
			return default(bool);
		}

		// Token: 0x06012194 RID: 74132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012194")]
		[Address(RVA = "0xA23D50", Offset = "0xA22950", VA = "0x180A23D50")]
		public InstantActionToOwnerAbility()
		{
		}

		// Token: 0x06012195 RID: 74133 RVA: 0x0006ECE8 File Offset: 0x0006CEE8
		[Token(Token = "0x6012195")]
		[Address(RVA = "0xA23D30", Offset = "0xA22930", VA = "0x180A23D30")]
		private Ability.Category <>xLuaBaseProxy_get_category()
		{
			return Ability.Category.NONE;
		}

		// Token: 0x06012196 RID: 74134 RVA: 0x0006ED00 File Offset: 0x0006CF00
		[Token(Token = "0x6012196")]
		[Address(RVA = "0xA23D40", Offset = "0xA22940", VA = "0x180A23D40")]
		private AbilityStandard.SelectTargetSource <>xLuaBaseProxy_get_selectTargetSource()
		{
			return AbilityStandard.SelectTargetSource.NONE;
		}

		// Token: 0x06012197 RID: 74135 RVA: 0x0006ED18 File Offset: 0x0006CF18
		[Token(Token = "0x6012197")]
		[Address(RVA = "0xA23D20", Offset = "0xA22920", VA = "0x180A23D20")]
		private bool <>xLuaBaseProxy_get_alwaysIncludeTarget()
		{
			return default(bool);
		}

		// Token: 0x06012198 RID: 74136 RVA: 0x0006ED30 File Offset: 0x0006CF30
		[Token(Token = "0x6012198")]
		[Address(RVA = "0xA23D10", Offset = "0xA22910", VA = "0x180A23D10")]
		private bool <>xLuaBaseProxy_get_allowNoTarget()
		{
			return default(bool);
		}

		// Token: 0x06012199 RID: 74137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012199")]
		[Address(RVA = "0xA1EDE0", Offset = "0xA1D9E0", VA = "0x180A1EDE0")]
		private void <>xLuaBaseProxy_GatherActionNodes(List<ActionNode> P0)
		{
		}

		// Token: 0x0601219A RID: 74138 RVA: 0x0006ED48 File Offset: 0x0006CF48
		[Token(Token = "0x601219A")]
		[Address(RVA = "0xA1EDF0", Offset = "0xA1D9F0", VA = "0x180A1EDF0")]
		private bool <>xLuaBaseProxy_OnSpellStart()
		{
			return default(bool);
		}

		// Token: 0x040147BC RID: 83900
		[Token(Token = "0x40147BC")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private ActionArray _actions;

		// Token: 0x040147BD RID: 83901
		[Token(Token = "0x40147BD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_category;

		// Token: 0x040147BE RID: 83902
		[Token(Token = "0x40147BE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_selectTargetSource;

		// Token: 0x040147BF RID: 83903
		[Token(Token = "0x40147BF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_alwaysIncludeTarget;

		// Token: 0x040147C0 RID: 83904
		[Token(Token = "0x40147C0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_allowNoTarget;

		// Token: 0x040147C1 RID: 83905
		[Token(Token = "0x40147C1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GatherActionNodes;

		// Token: 0x040147C2 RID: 83906
		[Token(Token = "0x40147C2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnSpellStart;

		// Token: 0x040147C3 RID: 83907
		[Token(Token = "0x40147C3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
