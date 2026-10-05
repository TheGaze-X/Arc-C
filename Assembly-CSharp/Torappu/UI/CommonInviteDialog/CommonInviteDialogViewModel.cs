using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CommonInviteDialog
{
	// Token: 0x02005BBA RID: 23482
	[Token(Token = "0x2005BBA")]
	public class CommonInviteDialogViewModel : IHotfixable
	{
		// Token: 0x060220EB RID: 139499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60220EB")]
		[Address(RVA = "0x1C91A90", Offset = "0x1C90690", VA = "0x181C91A90")]
		public void LoadData(CommonInviteDialog.Input input, int defaultInviteCd)
		{
		}

		// Token: 0x060220EC RID: 139500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60220EC")]
		[Address(RVA = "0x1C91BA0", Offset = "0x1C907A0", VA = "0x181C91BA0")]
		public void SetRefreshProtectTs()
		{
		}

		// Token: 0x060220ED RID: 139501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60220ED")]
		[Address(RVA = "0x1C91C30", Offset = "0x1C90830", VA = "0x181C91C30")]
		public CommonInviteDialogViewModel()
		{
		}

		// Token: 0x0402EB4F RID: 191311
		[Token(Token = "0x402EB4F")]
		private const int REFRESH_COOLDOWN = 6;

		// Token: 0x0402EB50 RID: 191312
		[Token(Token = "0x402EB50")]
		[FieldOffset(Offset = "0x10")]
		public string inviteId;

		// Token: 0x0402EB51 RID: 191313
		[Token(Token = "0x402EB51")]
		[FieldOffset(Offset = "0x18")]
		public int inviteSendCd;

		// Token: 0x0402EB52 RID: 191314
		[Token(Token = "0x402EB52")]
		[FieldOffset(Offset = "0x1C")]
		public PlayerInviteType inviteType;

		// Token: 0x0402EB53 RID: 191315
		[Token(Token = "0x402EB53")]
		[FieldOffset(Offset = "0x20")]
		public CommonInviteShowType inviteShowType;

		// Token: 0x0402EB54 RID: 191316
		[Token(Token = "0x402EB54")]
		[FieldOffset(Offset = "0x24")]
		public SeqNumSource resetSeq;

		// Token: 0x0402EB55 RID: 191317
		[Token(Token = "0x402EB55")]
		[FieldOffset(Offset = "0x30")]
		public SeqNumSource listChangeSeq;

		// Token: 0x0402EB56 RID: 191318
		[Token(Token = "0x402EB56")]
		[FieldOffset(Offset = "0x40")]
		public List<CommonInviteItemDataGroup> data;

		// Token: 0x0402EB57 RID: 191319
		[Token(Token = "0x402EB57")]
		[FieldOffset(Offset = "0x48")]
		public int lasGeneratedIndexFrom;

		// Token: 0x0402EB58 RID: 191320
		[Token(Token = "0x402EB58")]
		[FieldOffset(Offset = "0x4C")]
		public int lasGeneratedIndexCount;

		// Token: 0x0402EB59 RID: 191321
		[Token(Token = "0x402EB59")]
		[FieldOffset(Offset = "0x50")]
		public ListDict<string, CommonInviteSortInfo> friendList;

		// Token: 0x0402EB5A RID: 191322
		[Token(Token = "0x402EB5A")]
		[FieldOffset(Offset = "0x58")]
		public Dictionary<string, long> invitedCache;

		// Token: 0x0402EB5B RID: 191323
		[Token(Token = "0x402EB5B")]
		[FieldOffset(Offset = "0x60")]
		public long refreshProtectTs;

		// Token: 0x0402EB5C RID: 191324
		[Token(Token = "0x402EB5C")]
		[FieldOffset(Offset = "0x68")]
		public CommonInviteDialog.TextConfig textConfig;

		// Token: 0x0402EB5D RID: 191325
		[Token(Token = "0x402EB5D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402EB5E RID: 191326
		[Token(Token = "0x402EB5E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetRefreshProtectTs;

		// Token: 0x0402EB5F RID: 191327
		[Token(Token = "0x402EB5F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
