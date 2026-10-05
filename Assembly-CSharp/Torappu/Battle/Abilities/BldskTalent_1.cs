using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B86 RID: 11142
	[Token(Token = "0x2002B86")]
	public class BldskTalent_1 : PassiveBuffAbility
	{
		// Token: 0x06012BD3 RID: 76755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012BD3")]
		[Address(RVA = "0xAAF310", Offset = "0xAADF10", VA = "0x180AAF310", Slot = "29")]
		protected override void DoAttach(Entity owner)
		{
		}

		// Token: 0x06012BD4 RID: 76756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012BD4")]
		[Address(RVA = "0xAAF450", Offset = "0xAAE050", VA = "0x180AAF450", Slot = "52")]
		protected override void OnAttached()
		{
		}

		// Token: 0x06012BD5 RID: 76757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012BD5")]
		[Address(RVA = "0xAAF560", Offset = "0xAAE160", VA = "0x180AAF560", Slot = "53")]
		protected override void OnDetached()
		{
		}

		// Token: 0x06012BD6 RID: 76758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012BD6")]
		[Address(RVA = "0xAAF670", Offset = "0xAAE270", VA = "0x180AAF670")]
		private void _OnTrigger(Unit unit)
		{
		}

		// Token: 0x06012BD7 RID: 76759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012BD7")]
		[Address(RVA = "0xAAFBA0", Offset = "0xAAE7A0", VA = "0x180AAFBA0")]
		private void _OnUnitFinish(object arg)
		{
		}

		// Token: 0x06012BD8 RID: 76760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012BD8")]
		[Address(RVA = "0xAAF3B0", Offset = "0xAADFB0", VA = "0x180AAF3B0", Slot = "48")]
		public override void GatherActionNodes(List<ActionNode> results)
		{
		}

		// Token: 0x06012BD9 RID: 76761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012BD9")]
		[Address(RVA = "0xAAFDA0", Offset = "0xAAE9A0", VA = "0x180AAFDA0")]
		public BldskTalent_1()
		{
		}

		// Token: 0x06012BDA RID: 76762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012BDA")]
		[Address(RVA = "0xA64260", Offset = "0xA62E60", VA = "0x180A64260")]
		private void <>xLuaBaseProxy_DoAttach(Entity P0)
		{
		}

		// Token: 0x06012BDB RID: 76763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012BDB")]
		[Address(RVA = "0xA225F0", Offset = "0xA211F0", VA = "0x180A225F0")]
		private void <>xLuaBaseProxy_OnAttached()
		{
		}

		// Token: 0x06012BDC RID: 76764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012BDC")]
		[Address(RVA = "0xA22600", Offset = "0xA21200", VA = "0x180A22600")]
		private void <>xLuaBaseProxy_OnDetached()
		{
		}

		// Token: 0x06012BDD RID: 76765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012BDD")]
		[Address(RVA = "0xA1EDE0", Offset = "0xA1D9E0", VA = "0x180A1EDE0")]
		private void <>xLuaBaseProxy_GatherActionNodes(List<ActionNode> P0)
		{
		}

		// Token: 0x040152C6 RID: 86726
		[Token(Token = "0x40152C6")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private TargetOptions _targetOptions;

		// Token: 0x040152C7 RID: 86727
		[Token(Token = "0x40152C7")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		private BuffData _selfBuff;

		// Token: 0x040152C8 RID: 86728
		[Token(Token = "0x40152C8")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		private BuffData _randomBuff;

		// Token: 0x040152C9 RID: 86729
		[Token(Token = "0x40152C9")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		private ActionArray _actions;

		// Token: 0x040152CA RID: 86730
		[Token(Token = "0x40152CA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x040152CB RID: 86731
		[Token(Token = "0x40152CB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnAttached;

		// Token: 0x040152CC RID: 86732
		[Token(Token = "0x40152CC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnDetached;

		// Token: 0x040152CD RID: 86733
		[Token(Token = "0x40152CD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnTrigger;

		// Token: 0x040152CE RID: 86734
		[Token(Token = "0x40152CE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnUnitFinish;

		// Token: 0x040152CF RID: 86735
		[Token(Token = "0x40152CF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GatherActionNodes;

		// Token: 0x040152D0 RID: 86736
		[Token(Token = "0x40152D0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
