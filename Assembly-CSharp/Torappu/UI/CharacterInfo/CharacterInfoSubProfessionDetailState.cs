using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005EE7 RID: 24295
	[Token(Token = "0x2005EE7")]
	public class CharacterInfoSubProfessionDetailState : PopupFloatState
	{
		// Token: 0x06023323 RID: 144163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023323")]
		[Address(RVA = "0x1DB27A0", Offset = "0x1DB13A0", VA = "0x181DB27A0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06023324 RID: 144164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023324")]
		[Address(RVA = "0x1DB2800", Offset = "0x1DB1400", VA = "0x181DB2800", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06023325 RID: 144165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023325")]
		[Address(RVA = "0x1DB2D50", Offset = "0x1DB1950", VA = "0x181DB2D50")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06023326 RID: 144166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023326")]
		[Address(RVA = "0x1DB29A0", Offset = "0x1DB15A0", VA = "0x181DB29A0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06023327 RID: 144167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023327")]
		[Address(RVA = "0x1DB2C50", Offset = "0x1DB1850", VA = "0x181DB2C50")]
		public void OpenPage()
		{
		}

		// Token: 0x06023328 RID: 144168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023328")]
		[Address(RVA = "0x1DB2E80", Offset = "0x1DB1A80", VA = "0x181DB2E80")]
		public CharacterInfoSubProfessionDetailState()
		{
		}

		// Token: 0x06023329 RID: 144169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023329")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0602332A RID: 144170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602332A")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x040307FB RID: 198651
		[Token(Token = "0x40307FB")]
		[FieldOffset(Offset = "0x70")]
		private CharacterInfoSubProfessionDetailStateBean m_stateBean;

		// Token: 0x040307FC RID: 198652
		[Token(Token = "0x40307FC")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private CharacterInfoDetailSubProfessionView _view;

		// Token: 0x040307FD RID: 198653
		[Token(Token = "0x40307FD")]
		[FieldOffset(Offset = "0x80")]
		private bool m_hasInited;

		// Token: 0x040307FE RID: 198654
		[Token(Token = "0x40307FE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040307FF RID: 198655
		[Token(Token = "0x40307FF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04030800 RID: 198656
		[Token(Token = "0x4030800")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04030801 RID: 198657
		[Token(Token = "0x4030801")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04030802 RID: 198658
		[Token(Token = "0x4030802")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OpenPage;

		// Token: 0x04030803 RID: 198659
		[Token(Token = "0x4030803")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
