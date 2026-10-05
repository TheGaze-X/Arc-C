using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002BE7 RID: 11239
	[Token(Token = "0x2002BE7")]
	public class BuffTriggerEventCounter : AbilityEventCounter, IBuffSource
	{
		// Token: 0x06012FB6 RID: 77750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FB6")]
		[Address(RVA = "0xADE280", Offset = "0xADCE80", VA = "0x180ADE280")]
		private void _ClearBuffs()
		{
		}

		// Token: 0x06012FB7 RID: 77751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FB7")]
		[Address(RVA = "0xADDFB0", Offset = "0xADCBB0", VA = "0x180ADDFB0", Slot = "16")]
		protected override void OnCountEvent(AbilityStandard.Event ev, int triggerTimeCount, bool notCount)
		{
		}

		// Token: 0x06012FB8 RID: 77752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FB8")]
		[Address(RVA = "0xADE1E0", Offset = "0xADCDE0", VA = "0x180ADE1E0", Slot = "17")]
		protected override void OnCountReset()
		{
		}

		// Token: 0x06012FB9 RID: 77753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FB9")]
		[Address(RVA = "0xADDE50", Offset = "0xADCA50", VA = "0x180ADDE50", Slot = "19")]
		public void GatherBuffs(List<BuffData> results)
		{
		}

		// Token: 0x06012FBA RID: 77754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FBA")]
		[Address(RVA = "0xADE370", Offset = "0xADCF70", VA = "0x180ADE370")]
		public BuffTriggerEventCounter()
		{
		}

		// Token: 0x06012FBB RID: 77755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FBB")]
		[Address(RVA = "0xAD9BB0", Offset = "0xAD87B0", VA = "0x180AD9BB0")]
		private void <>xLuaBaseProxy_OnCountEvent(AbilityStandard.Event P0, int P1, bool P2)
		{
		}

		// Token: 0x06012FBC RID: 77756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FBC")]
		[Address(RVA = "0xAD9C40", Offset = "0xAD8840", VA = "0x180AD9C40")]
		private void <>xLuaBaseProxy_OnCountReset()
		{
		}

		// Token: 0x040156FC RID: 87804
		[Token(Token = "0x40156FC")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private List<BuffData> _buffs;

		// Token: 0x040156FD RID: 87805
		[Token(Token = "0x40156FD")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private bool _notTriggerWhenNotCount;

		// Token: 0x040156FE RID: 87806
		[Token(Token = "0x40156FE")]
		[FieldOffset(Offset = "0x80")]
		private List<uint> m_buffUid;

		// Token: 0x040156FF RID: 87807
		[Token(Token = "0x40156FF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__ClearBuffs;

		// Token: 0x04015700 RID: 87808
		[Token(Token = "0x4015700")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCountEvent;

		// Token: 0x04015701 RID: 87809
		[Token(Token = "0x4015701")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCountReset;

		// Token: 0x04015702 RID: 87810
		[Token(Token = "0x4015702")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x04015703 RID: 87811
		[Token(Token = "0x4015703")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
