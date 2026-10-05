using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Skills
{
	// Token: 0x020028B6 RID: 10422
	[Token(Token = "0x20028B6")]
	public class ModifySpDataAfterSkillCast : BasicSkill.Behaviour
	{
		// Token: 0x17002651 RID: 9809
		// (get) Token: 0x0601154B RID: 70987 RVA: 0x0006AB18 File Offset: 0x00068D18
		[Token(Token = "0x17002651")]
		private bool modifySpType
		{
			[Token(Token = "0x601154B")]
			[Address(RVA = "0x921FA0", Offset = "0x920BA0", VA = "0x180921FA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601154C RID: 70988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601154C")]
		[Address(RVA = "0x921B50", Offset = "0x920750", VA = "0x180921B50", Slot = "5")]
		public override void AssignData(Blackboard blackboard)
		{
		}

		// Token: 0x0601154D RID: 70989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601154D")]
		[Address(RVA = "0x921C00", Offset = "0x920800", VA = "0x180921C00", Slot = "6")]
		public override void OnCastSucceed()
		{
		}

		// Token: 0x0601154E RID: 70990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601154E")]
		[Address(RVA = "0x921D10", Offset = "0x920910", VA = "0x180921D10", Slot = "10")]
		public override void OnSkillEnd()
		{
		}

		// Token: 0x0601154F RID: 70991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601154F")]
		[Address(RVA = "0x921C90", Offset = "0x920890", VA = "0x180921C90", Slot = "12")]
		public override void OnOwnerFinish()
		{
		}

		// Token: 0x06011550 RID: 70992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011550")]
		[Address(RVA = "0x921DA0", Offset = "0x9209A0", VA = "0x180921DA0")]
		private void _ModifySpData(int spCost)
		{
		}

		// Token: 0x06011551 RID: 70993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011551")]
		[Address(RVA = "0x921F30", Offset = "0x920B30", VA = "0x180921F30")]
		public ModifySpDataAfterSkillCast()
		{
		}

		// Token: 0x06011552 RID: 70994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011552")]
		[Address(RVA = "0x91F590", Offset = "0x91E190", VA = "0x18091F590")]
		private void <>xLuaBaseProxy_AssignData(Blackboard P0)
		{
		}

		// Token: 0x06011553 RID: 70995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011553")]
		[Address(RVA = "0x91F5A0", Offset = "0x91E1A0", VA = "0x18091F5A0")]
		private void <>xLuaBaseProxy_OnCastSucceed()
		{
		}

		// Token: 0x06011554 RID: 70996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011554")]
		[Address(RVA = "0x91D770", Offset = "0x91C370", VA = "0x18091D770")]
		private void <>xLuaBaseProxy_OnSkillEnd()
		{
		}

		// Token: 0x06011555 RID: 70997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011555")]
		[Address(RVA = "0x921D90", Offset = "0x920990", VA = "0x180921D90")]
		private void <>xLuaBaseProxy_OnOwnerFinish()
		{
		}

		// Token: 0x040135F0 RID: 79344
		[Token(Token = "0x40135F0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int _spCost;

		// Token: 0x040135F1 RID: 79345
		[Token(Token = "0x40135F1")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool _modifySpType;

		// Token: 0x040135F2 RID: 79346
		[Token(Token = "0x40135F2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SpType _spType;

		// Token: 0x040135F3 RID: 79347
		[Token(Token = "0x40135F3")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private bool _resetWhenSkillEnd;

		// Token: 0x040135F4 RID: 79348
		[Token(Token = "0x40135F4")]
		[FieldOffset(Offset = "0x30")]
		private int m_originSpCost;

		// Token: 0x040135F5 RID: 79349
		[Token(Token = "0x40135F5")]
		[FieldOffset(Offset = "0x34")]
		private int m_spCost;

		// Token: 0x040135F6 RID: 79350
		[Token(Token = "0x40135F6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_modifySpType;

		// Token: 0x040135F7 RID: 79351
		[Token(Token = "0x40135F7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_AssignData;

		// Token: 0x040135F8 RID: 79352
		[Token(Token = "0x40135F8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCastSucceed;

		// Token: 0x040135F9 RID: 79353
		[Token(Token = "0x40135F9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnSkillEnd;

		// Token: 0x040135FA RID: 79354
		[Token(Token = "0x40135FA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnOwnerFinish;

		// Token: 0x040135FB RID: 79355
		[Token(Token = "0x40135FB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ModifySpData;

		// Token: 0x040135FC RID: 79356
		[Token(Token = "0x40135FC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
