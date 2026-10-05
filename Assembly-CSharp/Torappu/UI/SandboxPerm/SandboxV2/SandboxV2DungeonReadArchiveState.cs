using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020041B2 RID: 16818
	[Token(Token = "0x20041B2")]
	public class SandboxV2DungeonReadArchiveState : PopupFadeState, IValueMsgReceiver
	{
		// Token: 0x06019EF6 RID: 106230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019EF6")]
		[Address(RVA = "0x12E1AA0", Offset = "0x12E06A0", VA = "0x1812E1AA0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06019EF7 RID: 106231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019EF7")]
		[Address(RVA = "0x12E1D20", Offset = "0x12E0920", VA = "0x1812E1D20", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06019EF8 RID: 106232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019EF8")]
		[Address(RVA = "0x12E20E0", Offset = "0x12E0CE0", VA = "0x1812E20E0", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06019EF9 RID: 106233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019EF9")]
		[Address(RVA = "0x12E24B0", Offset = "0x12E10B0", VA = "0x1812E24B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019EFA RID: 106234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019EFA")]
		[Address(RVA = "0x12E29A0", Offset = "0x12E15A0", VA = "0x1812E29A0")]
		private void _OnBgClicked()
		{
		}

		// Token: 0x06019EFB RID: 106235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019EFB")]
		[Address(RVA = "0x12E2640", Offset = "0x12E1240", VA = "0x1812E2640")]
		private void _OnArchiveItemClick(int day)
		{
		}

		// Token: 0x06019EFC RID: 106236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019EFC")]
		[Address(RVA = "0x12E21B0", Offset = "0x12E0DB0", VA = "0x1812E21B0")]
		private void _ConfirmArchiveSelect()
		{
		}

		// Token: 0x06019EFD RID: 106237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019EFD")]
		[Address(RVA = "0x12E2C20", Offset = "0x12E1820", VA = "0x1812E2C20")]
		private void _OnReadArchiveConfirmResponse(SandboxV2ReadArchiveResponse response)
		{
		}

		// Token: 0x06019EFE RID: 106238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019EFE")]
		[Address(RVA = "0x12E1B00", Offset = "0x12E0700", VA = "0x1812E1B00")]
		public void OnBackClicked()
		{
		}

		// Token: 0x06019EFF RID: 106239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019EFF")]
		[Address(RVA = "0x12E3010", Offset = "0x12E1C10", VA = "0x1812E3010")]
		public SandboxV2DungeonReadArchiveState()
		{
		}

		// Token: 0x06019F00 RID: 106240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019F00")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x04020A6F RID: 133743
		[Token(Token = "0x4020A6F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _backTransform;

		// Token: 0x04020A70 RID: 133744
		[Token(Token = "0x4020A70")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private SandboxV2DungeonReadArchiveView _view;

		// Token: 0x04020A71 RID: 133745
		[Token(Token = "0x4020A71")]
		[FieldOffset(Offset = "0x80")]
		private bool m_isInited;

		// Token: 0x04020A72 RID: 133746
		[Token(Token = "0x4020A72")]
		[FieldOffset(Offset = "0x88")]
		private SandboxV2DungeonReadArchiveStateBean m_stateBean;

		// Token: 0x04020A73 RID: 133747
		[Token(Token = "0x4020A73")]
		[NonSerialized]
		public const int MSG_BG_CLICK = 1;

		// Token: 0x04020A74 RID: 133748
		[Token(Token = "0x4020A74")]
		[NonSerialized]
		public const int MSG_ARCHIVE_ITEM_CLICK = 2;

		// Token: 0x04020A75 RID: 133749
		[Token(Token = "0x4020A75")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04020A76 RID: 133750
		[Token(Token = "0x4020A76")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04020A77 RID: 133751
		[Token(Token = "0x4020A77")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04020A78 RID: 133752
		[Token(Token = "0x4020A78")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04020A79 RID: 133753
		[Token(Token = "0x4020A79")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnBgClicked;

		// Token: 0x04020A7A RID: 133754
		[Token(Token = "0x4020A7A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnArchiveItemClick;

		// Token: 0x04020A7B RID: 133755
		[Token(Token = "0x4020A7B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ConfirmArchiveSelect;

		// Token: 0x04020A7C RID: 133756
		[Token(Token = "0x4020A7C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnReadArchiveConfirmResponse;

		// Token: 0x04020A7D RID: 133757
		[Token(Token = "0x4020A7D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnBackClicked;

		// Token: 0x04020A7E RID: 133758
		[Token(Token = "0x4020A7E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
