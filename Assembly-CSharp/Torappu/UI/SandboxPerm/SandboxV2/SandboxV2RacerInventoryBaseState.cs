using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200435C RID: 17244
	[Token(Token = "0x200435C")]
	public abstract class SandboxV2RacerInventoryBaseState : PopupFadeState, IValueMsgReceiver, IHotfixable
	{
		// Token: 0x0601A771 RID: 108401
		[Token(Token = "0x601A771")]
		public abstract void OnMessage(int key, ValueBundle msg);

		// Token: 0x0601A772 RID: 108402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A772")]
		[Address(RVA = "0x138DC00", Offset = "0x138C800", VA = "0x18138DC00")]
		protected SandboxV2RacerInventoryBaseState()
		{
		}

		// Token: 0x04021ABB RID: 137915
		[Token(Token = "0x4021ABB")]
		[NonSerialized]
		public const int MSG_ON_BACK_BTN_CLICKED = 0;

		// Token: 0x04021ABC RID: 137916
		[Token(Token = "0x4021ABC")]
		[NonSerialized]
		public const int MSG_ON_CARD_CLICKED = 1;

		// Token: 0x04021ABD RID: 137917
		[Token(Token = "0x4021ABD")]
		[NonSerialized]
		public const int MSG_ON_RACER_MARK_CLICKED = 2;

		// Token: 0x04021ABE RID: 137918
		[Token(Token = "0x4021ABE")]
		[NonSerialized]
		public const int MSG_ON_REFRESH_TALENT_CLICKED = 3;

		// Token: 0x04021ABF RID: 137919
		[Token(Token = "0x4021ABF")]
		[NonSerialized]
		public const int MSG_ON_RELEASE_CLICKED = 4;

		// Token: 0x04021AC0 RID: 137920
		[Token(Token = "0x4021AC0")]
		[NonSerialized]
		public const int MSG_ON_START_BATTLE_CLICKED = 5;

		// Token: 0x04021AC1 RID: 137921
		[Token(Token = "0x4021AC1")]
		[NonSerialized]
		public const int MSG_ON_OPEN_TEMP_BAG_CLICKED = 6;

		// Token: 0x04021AC2 RID: 137922
		[Token(Token = "0x4021AC2")]
		[NonSerialized]
		public const int MSG_ON_REGISTER_CLICKED = 7;

		// Token: 0x04021AC3 RID: 137923
		[Token(Token = "0x4021AC3")]
		[NonSerialized]
		public const int MSG_ON_RELEASE_ALL_CLICKED = 8;

		// Token: 0x04021AC4 RID: 137924
		[Token(Token = "0x4021AC4")]
		[NonSerialized]
		public const int MSG_ON_MEDAL_GROUP_CLICKED = 9;

		// Token: 0x04021AC5 RID: 137925
		[Token(Token = "0x4021AC5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
