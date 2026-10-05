using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B40 RID: 11072
	[Token(Token = "0x2002B40")]
	public class BlockAffectedPassiveBuffAbility : PassiveBuffAbility
	{
		// Token: 0x06012931 RID: 76081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012931")]
		[Address(RVA = "0xA7C0B0", Offset = "0xA7ACB0", VA = "0x180A7C0B0", Slot = "52")]
		protected override void OnAttached()
		{
		}

		// Token: 0x06012932 RID: 76082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012932")]
		[Address(RVA = "0xA7C210", Offset = "0xA7AE10", VA = "0x180A7C210", Slot = "53")]
		protected override void OnDetached()
		{
		}

		// Token: 0x06012933 RID: 76083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012933")]
		[Address(RVA = "0xA7BFD0", Offset = "0xA7ABD0", VA = "0x180A7BFD0", Slot = "49")]
		public override void GatherBuffs(List<BuffData> results)
		{
		}

		// Token: 0x06012934 RID: 76084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012934")]
		[Address(RVA = "0xA7C3F0", Offset = "0xA7AFF0", VA = "0x180A7C3F0")]
		private void _HandleBlockAffectedBuffs(object arg)
		{
		}

		// Token: 0x06012935 RID: 76085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012935")]
		[Address(RVA = "0xA7CC00", Offset = "0xA7B800", VA = "0x180A7CC00")]
		public BlockAffectedPassiveBuffAbility()
		{
		}

		// Token: 0x06012937 RID: 76087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012937")]
		[Address(RVA = "0xA225F0", Offset = "0xA211F0", VA = "0x180A225F0")]
		private void <>xLuaBaseProxy_OnAttached()
		{
		}

		// Token: 0x06012938 RID: 76088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012938")]
		[Address(RVA = "0xA22600", Offset = "0xA21200", VA = "0x180A22600")]
		private void <>xLuaBaseProxy_OnDetached()
		{
		}

		// Token: 0x06012939 RID: 76089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012939")]
		[Address(RVA = "0xA56960", Offset = "0xA55560", VA = "0x180A56960")]
		private void <>xLuaBaseProxy_GatherBuffs(List<BuffData> P0)
		{
		}

		// Token: 0x04014FC2 RID: 85954
		[Token(Token = "0x4014FC2")]
		[FieldOffset(Offset = "0x0")]
		private static List<ObjectPtr<Buff>> s_tmpBuffList;

		// Token: 0x04014FC3 RID: 85955
		[Token(Token = "0x4014FC3")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private BuffData[] _blockAffectedBuffs;

		// Token: 0x04014FC4 RID: 85956
		[Token(Token = "0x4014FC4")]
		[FieldOffset(Offset = "0x120")]
		private ListDict<ObjectPtr<Entity>, ObjectPtr<Buff>[]> m_blockBuffMap;

		// Token: 0x04014FC5 RID: 85957
		[Token(Token = "0x4014FC5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnAttached;

		// Token: 0x04014FC6 RID: 85958
		[Token(Token = "0x4014FC6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnDetached;

		// Token: 0x04014FC7 RID: 85959
		[Token(Token = "0x4014FC7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x04014FC8 RID: 85960
		[Token(Token = "0x4014FC8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__HandleBlockAffectedBuffs;

		// Token: 0x04014FC9 RID: 85961
		[Token(Token = "0x4014FC9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
