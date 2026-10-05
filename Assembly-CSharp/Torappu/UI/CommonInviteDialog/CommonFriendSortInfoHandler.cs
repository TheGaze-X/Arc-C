using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CommonInviteDialog
{
	// Token: 0x02005BB2 RID: 23474
	[Token(Token = "0x2005BB2")]
	public class CommonFriendSortInfoHandler : CommonInviteDialog.SortInfoHandler<GetSortListInfoRequest, GetSortListInfoResponse>
	{
		// Token: 0x17004FB5 RID: 20405
		// (get) Token: 0x060220D6 RID: 139478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004FB5")]
		public override string serviceCode
		{
			[Token(Token = "0x60220D6")]
			[Address(RVA = "0x1C8FA70", Offset = "0x1C8E670", VA = "0x181C8FA70", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x060220D7 RID: 139479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60220D7")]
		[Address(RVA = "0x1C8F820", Offset = "0x1C8E420", VA = "0x181C8F820", Slot = "13")]
		protected override GetSortListInfoRequest GetSortInfoRequest()
		{
			return null;
		}

		// Token: 0x060220D8 RID: 139480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60220D8")]
		[Address(RVA = "0x1C8F430", Offset = "0x1C8E030", VA = "0x181C8F430", Slot = "14")]
		protected override List<CommonInviteSortInfo> GenerateFriendIdList(GetSortListInfoResponse response)
		{
			return null;
		}

		// Token: 0x060220D9 RID: 139481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60220D9")]
		[Address(RVA = "0x1C8FA00", Offset = "0x1C8E600", VA = "0x181C8FA00")]
		public CommonFriendSortInfoHandler()
		{
		}

		// Token: 0x0402EB13 RID: 191251
		[Token(Token = "0x402EB13")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_serviceCode;

		// Token: 0x0402EB14 RID: 191252
		[Token(Token = "0x402EB14")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetSortInfoRequest;

		// Token: 0x0402EB15 RID: 191253
		[Token(Token = "0x402EB15")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GenerateFriendIdList;

		// Token: 0x0402EB16 RID: 191254
		[Token(Token = "0x402EB16")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
