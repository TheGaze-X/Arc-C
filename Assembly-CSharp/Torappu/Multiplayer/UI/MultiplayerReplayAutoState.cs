using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Multiplayer.UI
{
	// Token: 0x02001564 RID: 5476
	[Token(Token = "0x2001564")]
	internal class MultiplayerReplayAutoState : UIPopupState
	{
		// Token: 0x06007D35 RID: 32053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D35")]
		[Address(RVA = "0x2849320", Offset = "0x2847F20", VA = "0x182849320")]
		private void _Play(string[] videoUrls)
		{
		}

		// Token: 0x06007D36 RID: 32054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D36")]
		[Address(RVA = "0x2848A30", Offset = "0x2847630", VA = "0x182848A30")]
		public void EventOnPlay()
		{
		}

		// Token: 0x06007D37 RID: 32055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D37")]
		[Address(RVA = "0x28490C0", Offset = "0x2847CC0", VA = "0x1828490C0")]
		private void _ParseListFile(string url, string lscontent)
		{
		}

		// Token: 0x06007D38 RID: 32056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007D38")]
		[Address(RVA = "0x2848E90", Offset = "0x2847A90", VA = "0x182848E90", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x06007D39 RID: 32057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007D39")]
		[Address(RVA = "0x2848C60", Offset = "0x2847860", VA = "0x182848C60", Slot = "24")]
		protected override IEnumerator HideCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x06007D3A RID: 32058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D3A")]
		[Address(RVA = "0x2848FD0", Offset = "0x2847BD0", VA = "0x182848FD0", Slot = "25")]
		protected override void ShowImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x06007D3B RID: 32059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D3B")]
		[Address(RVA = "0x2848DA0", Offset = "0x28479A0", VA = "0x182848DA0", Slot = "26")]
		protected override void HideImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x06007D3C RID: 32060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007D3C")]
		[Address(RVA = "0x2848C00", Offset = "0x2847800", VA = "0x182848C00", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06007D3D RID: 32061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D3D")]
		[Address(RVA = "0x2849390", Offset = "0x2847F90", VA = "0x182849390")]
		public MultiplayerReplayAutoState()
		{
		}

		// Token: 0x04007DFB RID: 32251
		[Token(Token = "0x4007DFB")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private InputField _urlInput;

		// Token: 0x04007DFC RID: 32252
		[Token(Token = "0x4007DFC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__Play;

		// Token: 0x04007DFD RID: 32253
		[Token(Token = "0x4007DFD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnPlay;

		// Token: 0x04007DFE RID: 32254
		[Token(Token = "0x4007DFE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ParseListFile;

		// Token: 0x04007DFF RID: 32255
		[Token(Token = "0x4007DFF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x04007E00 RID: 32256
		[Token(Token = "0x4007E00")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x04007E01 RID: 32257
		[Token(Token = "0x4007E01")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ShowImmediately;

		// Token: 0x04007E02 RID: 32258
		[Token(Token = "0x4007E02")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_HideImmediately;

		// Token: 0x04007E03 RID: 32259
		[Token(Token = "0x4007E03")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04007E04 RID: 32260
		[Token(Token = "0x4007E04")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001565 RID: 5477
		[Token(Token = "0x2001565")]
		private class VideoList
		{
			// Token: 0x06007D3E RID: 32062 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D3E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public VideoList()
			{
			}

			// Token: 0x04007E05 RID: 32261
			[Token(Token = "0x4007E05")]
			[FieldOffset(Offset = "0x10")]
			public string[] files;
		}
	}
}
