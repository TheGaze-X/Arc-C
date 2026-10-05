using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020069DD RID: 27101
	[Token(Token = "0x20069DD")]
	public class ZoneRecordDetailState : PopupFloatState
	{
		// Token: 0x06026C46 RID: 158790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026C46")]
		[Address(RVA = "0x21DDE50", Offset = "0x21DCA50", VA = "0x1821DDE50", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06026C47 RID: 158791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C47")]
		[Address(RVA = "0x21DDEB0", Offset = "0x21DCAB0", VA = "0x1821DDEB0")]
		public void OnBack()
		{
		}

		// Token: 0x06026C48 RID: 158792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C48")]
		[Address(RVA = "0x21DDF30", Offset = "0x21DCB30", VA = "0x1821DDF30", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06026C49 RID: 158793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C49")]
		[Address(RVA = "0x21DDFF0", Offset = "0x21DCBF0", VA = "0x1821DDFF0")]
		public ZoneRecordDetailState()
		{
		}

		// Token: 0x06026C4A RID: 158794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C4A")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x04036C23 RID: 224291
		[Token(Token = "0x4036C23")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ZoneRecordNoteDetailView _view;

		// Token: 0x04036C24 RID: 224292
		[Token(Token = "0x4036C24")]
		[FieldOffset(Offset = "0x78")]
		private ZoneRecordDetailStateBean m_stateBean;

		// Token: 0x04036C25 RID: 224293
		[Token(Token = "0x4036C25")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04036C26 RID: 224294
		[Token(Token = "0x4036C26")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnBack;

		// Token: 0x04036C27 RID: 224295
		[Token(Token = "0x4036C27")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04036C28 RID: 224296
		[Token(Token = "0x4036C28")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
