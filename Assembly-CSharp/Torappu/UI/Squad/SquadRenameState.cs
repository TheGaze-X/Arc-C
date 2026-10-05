using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Squad
{
	// Token: 0x02003DE1 RID: 15841
	[Token(Token = "0x2003DE1")]
	public class SquadRenameState : PopupFloatState
	{
		// Token: 0x06018A55 RID: 100949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018A55")]
		[Address(RVA = "0x11327C0", Offset = "0x11313C0", VA = "0x1811327C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018A56 RID: 100950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018A56")]
		[Address(RVA = "0x11323C0", Offset = "0x1130FC0", VA = "0x1811323C0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06018A57 RID: 100951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018A57")]
		[Address(RVA = "0x1132420", Offset = "0x1131020", VA = "0x181132420", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06018A58 RID: 100952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018A58")]
		[Address(RVA = "0x1132340", Offset = "0x1130F40", VA = "0x181132340")]
		public void BackToState()
		{
		}

		// Token: 0x06018A59 RID: 100953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018A59")]
		[Address(RVA = "0x11326D0", Offset = "0x11312D0", VA = "0x1811326D0")]
		public void SaveSquadName()
		{
		}

		// Token: 0x06018A5A RID: 100954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018A5A")]
		[Address(RVA = "0x11328E0", Offset = "0x11314E0", VA = "0x1811328E0")]
		private void _SaveSquadName()
		{
		}

		// Token: 0x06018A5B RID: 100955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018A5B")]
		[Address(RVA = "0x1132B90", Offset = "0x1131790", VA = "0x181132B90")]
		public SquadRenameState()
		{
		}

		// Token: 0x06018A5E RID: 100958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018A5E")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0401E346 RID: 123718
		[Token(Token = "0x401E346")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SquadHomeStateBean _statebean;

		// Token: 0x0401E347 RID: 123719
		[Token(Token = "0x401E347")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private InputField _inputName;

		// Token: 0x0401E348 RID: 123720
		[Token(Token = "0x401E348")]
		[FieldOffset(Offset = "0x80")]
		private bool m_isInited;

		// Token: 0x0401E349 RID: 123721
		[Token(Token = "0x401E349")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401E34A RID: 123722
		[Token(Token = "0x401E34A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0401E34B RID: 123723
		[Token(Token = "0x401E34B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0401E34C RID: 123724
		[Token(Token = "0x401E34C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_BackToState;

		// Token: 0x0401E34D RID: 123725
		[Token(Token = "0x401E34D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SaveSquadName;

		// Token: 0x0401E34E RID: 123726
		[Token(Token = "0x401E34E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SaveSquadName;

		// Token: 0x0401E34F RID: 123727
		[Token(Token = "0x401E34F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
