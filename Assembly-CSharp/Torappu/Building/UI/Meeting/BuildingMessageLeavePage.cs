using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.Meeting
{
	// Token: 0x02001D12 RID: 7442
	[Token(Token = "0x2001D12")]
	public class BuildingMessageLeavePage : BuildingCommonPage
	{
		// Token: 0x1700162D RID: 5677
		// (get) Token: 0x0600B7C4 RID: 47044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700162D")]
		public UICompDialogMgr dlgMgr
		{
			[Token(Token = "0x600B7C4")]
			[Address(RVA = "0x333E030", Offset = "0x333CC30", VA = "0x18333E030")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600B7C5 RID: 47045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B7C5")]
		[Address(RVA = "0x333DEB0", Offset = "0x333CAB0", VA = "0x18333DEB0", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x0600B7C6 RID: 47046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B7C6")]
		[Address(RVA = "0x333DFD0", Offset = "0x333CBD0", VA = "0x18333DFD0")]
		public BuildingMessageLeavePage()
		{
		}

		// Token: 0x0600B7C7 RID: 47047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B7C7")]
		[Address(RVA = "0x327F490", Offset = "0x327E090", VA = "0x18327F490")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x0400B59F RID: 46495
		[Token(Token = "0x400B59F")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private RectTransform _dlgContainer;

		// Token: 0x0400B5A0 RID: 46496
		[Token(Token = "0x400B5A0")]
		[FieldOffset(Offset = "0x120")]
		private UICompDialogMgr m_dlgMgr;

		// Token: 0x0400B5A1 RID: 46497
		[Token(Token = "0x400B5A1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_dlgMgr;

		// Token: 0x0400B5A2 RID: 46498
		[Token(Token = "0x400B5A2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0400B5A3 RID: 46499
		[Token(Token = "0x400B5A3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001D13 RID: 7443
		[Token(Token = "0x2001D13")]
		public enum MessageBoardType
		{
			// Token: 0x0400B5A5 RID: 46501
			[Token(Token = "0x400B5A5")]
			None,
			// Token: 0x0400B5A6 RID: 46502
			[Token(Token = "0x400B5A6")]
			Player,
			// Token: 0x0400B5A7 RID: 46503
			[Token(Token = "0x400B5A7")]
			Visit
		}

		// Token: 0x02001D14 RID: 7444
		[Token(Token = "0x2001D14")]
		public class MessageLeaveBoardArg
		{
			// Token: 0x0600B7C8 RID: 47048 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B7C8")]
			[Address(RVA = "0x334C790", Offset = "0x334B390", VA = "0x18334C790")]
			public MessageLeaveBoardArg(BuildingPayloadGetMessageBoardContentResponse playerBoardResponse)
			{
			}

			// Token: 0x0600B7C9 RID: 47049 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B7C9")]
			[Address(RVA = "0x334C7D0", Offset = "0x334B3D0", VA = "0x18334C7D0")]
			public MessageLeaveBoardArg(BuildingPayloadGetOthersMessageBoardContentResponse visitorBoardResponse)
			{
			}

			// Token: 0x0400B5A8 RID: 46504
			[Token(Token = "0x400B5A8")]
			[FieldOffset(Offset = "0x10")]
			public readonly BuildingMessageLeavePage.MessageBoardType messageLeaveBoardType;

			// Token: 0x0400B5A9 RID: 46505
			[Token(Token = "0x400B5A9")]
			[FieldOffset(Offset = "0x18")]
			public readonly BuildingPayloadGetMessageBoardContentResponse playerBoardContentResponse;

			// Token: 0x0400B5AA RID: 46506
			[Token(Token = "0x400B5AA")]
			[FieldOffset(Offset = "0x20")]
			public readonly BuildingPayloadGetOthersMessageBoardContentResponse visitorBoardContentResponse;
		}

		// Token: 0x02001D15 RID: 7445
		[Token(Token = "0x2001D15")]
		public class Argument
		{
			// Token: 0x0600B7CA RID: 47050 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B7CA")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Argument()
			{
			}

			// Token: 0x0400B5AB RID: 46507
			[Token(Token = "0x400B5AB")]
			[FieldOffset(Offset = "0x10")]
			public BuildingMessageLeavePage.MessageLeaveBoardArg messageLeaveBoardData;
		}
	}
}
