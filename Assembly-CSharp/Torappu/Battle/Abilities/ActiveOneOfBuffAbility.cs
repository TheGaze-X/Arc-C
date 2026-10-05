using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002AD1 RID: 10961
	[Token(Token = "0x2002AD1")]
	public class ActiveOneOfBuffAbility : ActiveBuffAbility
	{
		// Token: 0x06012441 RID: 74817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012441")]
		[Address(RVA = "0xA4DAB0", Offset = "0xA4C6B0", VA = "0x180A4DAB0", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x06012442 RID: 74818 RVA: 0x0006FEA0 File Offset: 0x0006E0A0
		[Token(Token = "0x6012442")]
		[Address(RVA = "0xA4DB70", Offset = "0xA4C770", VA = "0x180A4DB70", Slot = "78")]
		protected override bool OnSpellStart()
		{
			return default(bool);
		}

		// Token: 0x06012443 RID: 74819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012443")]
		[Address(RVA = "0xA4DCE0", Offset = "0xA4C8E0", VA = "0x180A4DCE0", Slot = "40")]
		protected override void Reset()
		{
		}

		// Token: 0x06012444 RID: 74820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012444")]
		[Address(RVA = "0xA4DDA0", Offset = "0xA4C9A0", VA = "0x180A4DDA0")]
		public ActiveOneOfBuffAbility()
		{
		}

		// Token: 0x06012445 RID: 74821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012445")]
		[Address(RVA = "0xA4DD50", Offset = "0xA4C950", VA = "0x180A4DD50")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x06012446 RID: 74822 RVA: 0x0006FEB8 File Offset: 0x0006E0B8
		[Token(Token = "0x6012446")]
		[Address(RVA = "0xA4DD80", Offset = "0xA4C980", VA = "0x180A4DD80")]
		private bool <>xLuaBaseProxy_OnSpellStart()
		{
			return default(bool);
		}

		// Token: 0x06012447 RID: 74823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012447")]
		[Address(RVA = "0xA4DD90", Offset = "0xA4C990", VA = "0x180A4DD90")]
		private void <>xLuaBaseProxy_Reset()
		{
		}

		// Token: 0x04014A7B RID: 84603
		[Token(Token = "0x4014A7B")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		private List<ActiveOneOfBuffAbility.BuffDataList> _extraBuffs;

		// Token: 0x04014A7C RID: 84604
		[Token(Token = "0x4014A7C")]
		[FieldOffset(Offset = "0x170")]
		private int m_spellCnt;

		// Token: 0x04014A7D RID: 84605
		[Token(Token = "0x4014A7D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x04014A7E RID: 84606
		[Token(Token = "0x4014A7E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnSpellStart;

		// Token: 0x04014A7F RID: 84607
		[Token(Token = "0x4014A7F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04014A80 RID: 84608
		[Token(Token = "0x4014A80")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002AD2 RID: 10962
		[Token(Token = "0x2002AD2")]
		[Serializable]
		public class BuffDataList
		{
			// Token: 0x06012448 RID: 74824 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6012448")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public BuffDataList()
			{
			}

			// Token: 0x04014A81 RID: 84609
			[Token(Token = "0x4014A81")]
			[FieldOffset(Offset = "0x10")]
			public BuffData[] buffDatas;
		}
	}
}
