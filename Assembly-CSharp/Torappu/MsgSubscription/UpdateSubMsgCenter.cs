using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.MsgSubscription
{
	// Token: 0x020015DC RID: 5596
	[Token(Token = "0x20015DC")]
	public class UpdateSubMsgCenter : SubscriptionMsgCenter<UpdateSubMsg>
	{
		// Token: 0x06007EEB RID: 32491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EEB")]
		[Address(RVA = "0x28A2670", Offset = "0x28A1270", VA = "0x1828A2670", Slot = "14")]
		protected override void OnStop()
		{
		}

		// Token: 0x17000F17 RID: 3863
		// (get) Token: 0x06007EEC RID: 32492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F17")]
		protected override string msgType
		{
			[Token(Token = "0x6007EEC")]
			[Address(RVA = "0x28A2740", Offset = "0x28A1340", VA = "0x1828A2740", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007EED RID: 32493 RVA: 0x00037F20 File Offset: 0x00036120
		[Token(Token = "0x6007EED")]
		[Address(RVA = "0x28A25E0", Offset = "0x28A11E0", VA = "0x1828A25E0", Slot = "15")]
		protected override bool CheckMsgValid(UpdateSubMsg msg)
		{
			return default(bool);
		}

		// Token: 0x06007EEE RID: 32494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EEE")]
		[Address(RVA = "0x28A26D0", Offset = "0x28A12D0", VA = "0x1828A26D0")]
		public UpdateSubMsgCenter()
		{
		}

		// Token: 0x040080A4 RID: 32932
		[Token(Token = "0x40080A4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnStop;

		// Token: 0x040080A5 RID: 32933
		[Token(Token = "0x40080A5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_msgType;

		// Token: 0x040080A6 RID: 32934
		[Token(Token = "0x40080A6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckMsgValid;

		// Token: 0x040080A7 RID: 32935
		[Token(Token = "0x40080A7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
