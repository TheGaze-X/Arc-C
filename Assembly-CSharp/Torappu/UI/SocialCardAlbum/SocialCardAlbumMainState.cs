using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SocialCardAlbum
{
	// Token: 0x02003EB0 RID: 16048
	[Token(Token = "0x2003EB0")]
	public class SocialCardAlbumMainState : State
	{
		// Token: 0x06018E91 RID: 102033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018E91")]
		[Address(RVA = "0x11A4F20", Offset = "0x11A3B20", VA = "0x1811A4F20", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06018E92 RID: 102034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E92")]
		[Address(RVA = "0x11A5030", Offset = "0x11A3C30", VA = "0x1811A5030", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06018E93 RID: 102035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E93")]
		[Address(RVA = "0x11A5310", Offset = "0x11A3F10", VA = "0x1811A5310", Slot = "16")]
		protected override void OnPreResume(bool isFromStack)
		{
		}

		// Token: 0x06018E94 RID: 102036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E94")]
		[Address(RVA = "0x11A51F0", Offset = "0x11A3DF0", VA = "0x1811A51F0", Slot = "17")]
		protected override void OnPause()
		{
		}

		// Token: 0x06018E95 RID: 102037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E95")]
		[Address(RVA = "0x11A5140", Offset = "0x11A3D40", VA = "0x1811A5140")]
		public void OnOpenNameCard()
		{
		}

		// Token: 0x06018E96 RID: 102038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E96")]
		[Address(RVA = "0x11A4F80", Offset = "0x11A3B80", VA = "0x1811A4F80")]
		public void OnBackClick()
		{
		}

		// Token: 0x06018E97 RID: 102039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E97")]
		[Address(RVA = "0x11A5510", Offset = "0x11A4110", VA = "0x1811A5510")]
		public SocialCardAlbumMainState()
		{
		}

		// Token: 0x06018E98 RID: 102040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E98")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06018E99 RID: 102041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E99")]
		[Address(RVA = "0x1061490", Offset = "0x1060090", VA = "0x181061490")]
		private void <>xLuaBaseProxy_OnPreResume(bool P0)
		{
		}

		// Token: 0x06018E9A RID: 102042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E9A")]
		[Address(RVA = "0xF807D0", Offset = "0xF7F3D0", VA = "0x180F807D0")]
		private void <>xLuaBaseProxy_OnPause()
		{
		}

		// Token: 0x0401EBCD RID: 125901
		[Token(Token = "0x401EBCD")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _backRect;

		// Token: 0x0401EBCE RID: 125902
		[Token(Token = "0x401EBCE")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SocialCardAlbumMainView _view;

		// Token: 0x0401EBCF RID: 125903
		[Token(Token = "0x401EBCF")]
		[FieldOffset(Offset = "0x60")]
		private SocialCardAlbumPage m_page;

		// Token: 0x0401EBD0 RID: 125904
		[Token(Token = "0x401EBD0")]
		[FieldOffset(Offset = "0x68")]
		private bool m_exposureTrackerBinded;

		// Token: 0x0401EBD1 RID: 125905
		[Token(Token = "0x401EBD1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0401EBD2 RID: 125906
		[Token(Token = "0x401EBD2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0401EBD3 RID: 125907
		[Token(Token = "0x401EBD3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnPreResume;

		// Token: 0x0401EBD4 RID: 125908
		[Token(Token = "0x401EBD4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnPause;

		// Token: 0x0401EBD5 RID: 125909
		[Token(Token = "0x401EBD5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnOpenNameCard;

		// Token: 0x0401EBD6 RID: 125910
		[Token(Token = "0x401EBD6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnBackClick;

		// Token: 0x0401EBD7 RID: 125911
		[Token(Token = "0x401EBD7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
