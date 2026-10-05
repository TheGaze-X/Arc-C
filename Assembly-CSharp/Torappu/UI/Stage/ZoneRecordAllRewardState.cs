using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020069DA RID: 27098
	[Token(Token = "0x20069DA")]
	public class ZoneRecordAllRewardState : PopupFloatState
	{
		// Token: 0x06026C35 RID: 158773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026C35")]
		[Address(RVA = "0x21DC160", Offset = "0x21DAD60", VA = "0x1821DC160", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06026C36 RID: 158774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C36")]
		[Address(RVA = "0x21DC1C0", Offset = "0x21DADC0", VA = "0x1821DC1C0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06026C37 RID: 158775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C37")]
		[Address(RVA = "0x21DC580", Offset = "0x21DB180", VA = "0x1821DC580")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06026C38 RID: 158776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C38")]
		[Address(RVA = "0x21DC700", Offset = "0x21DB300", VA = "0x1821DC700")]
		public ZoneRecordAllRewardState()
		{
		}

		// Token: 0x06026C3B RID: 158779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C3B")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x04036C0A RID: 224266
		[Token(Token = "0x4036C0A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private TopMenuDynamicPrefabInstHolder _topMenuHolder;

		// Token: 0x04036C0B RID: 224267
		[Token(Token = "0x4036C0B")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ZoneRecordAllRewardsView _view;

		// Token: 0x04036C0C RID: 224268
		[Token(Token = "0x4036C0C")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _backPressRt;

		// Token: 0x04036C0D RID: 224269
		[Token(Token = "0x4036C0D")]
		[FieldOffset(Offset = "0x88")]
		private ZoneRecordStateBean m_stateBean;

		// Token: 0x04036C0E RID: 224270
		[Token(Token = "0x4036C0E")]
		[FieldOffset(Offset = "0x90")]
		private bool m_isInit;

		// Token: 0x04036C0F RID: 224271
		[Token(Token = "0x4036C0F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04036C10 RID: 224272
		[Token(Token = "0x4036C10")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04036C11 RID: 224273
		[Token(Token = "0x4036C11")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04036C12 RID: 224274
		[Token(Token = "0x4036C12")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
