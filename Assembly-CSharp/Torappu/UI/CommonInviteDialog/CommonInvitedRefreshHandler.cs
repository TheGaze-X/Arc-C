using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CommonInviteDialog
{
	// Token: 0x02005BB3 RID: 23475
	[Token(Token = "0x2005BB3")]
	public class CommonInvitedRefreshHandler : CommonInviteDialog.SortInfoHandler<InvitedRefreshRequest, PlayerEmptyDeltaResponse>
	{
		// Token: 0x17004FB6 RID: 20406
		// (get) Token: 0x060220DA RID: 139482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004FB6")]
		public override string serviceCode
		{
			[Token(Token = "0x60220DA")]
			[Address(RVA = "0x1C96460", Offset = "0x1C95060", VA = "0x181C96460", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x060220DB RID: 139483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60220DB")]
		[Address(RVA = "0x1C96310", Offset = "0x1C94F10", VA = "0x181C96310", Slot = "13")]
		protected override InvitedRefreshRequest GetSortInfoRequest()
		{
			return null;
		}

		// Token: 0x060220DC RID: 139484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60220DC")]
		[Address(RVA = "0x1C95E70", Offset = "0x1C94A70", VA = "0x181C95E70", Slot = "14")]
		protected override List<CommonInviteSortInfo> GenerateFriendIdList(PlayerEmptyDeltaResponse response)
		{
			return null;
		}

		// Token: 0x060220DD RID: 139485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60220DD")]
		[Address(RVA = "0x1C963F0", Offset = "0x1C94FF0", VA = "0x181C963F0")]
		public CommonInvitedRefreshHandler()
		{
		}

		// Token: 0x0402EB17 RID: 191255
		[Token(Token = "0x402EB17")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_serviceCode;

		// Token: 0x0402EB18 RID: 191256
		[Token(Token = "0x402EB18")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetSortInfoRequest;

		// Token: 0x0402EB19 RID: 191257
		[Token(Token = "0x402EB19")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GenerateFriendIdList;

		// Token: 0x0402EB1A RID: 191258
		[Token(Token = "0x402EB1A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
