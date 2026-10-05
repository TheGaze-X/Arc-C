using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004D8E RID: 19854
	[Token(Token = "0x2004D8E")]
	public class NameCardV2AssistModuleModel : NameCardV2RemovableModuleBaseModel
	{
		// Token: 0x170045A2 RID: 17826
		// (get) Token: 0x0601DB49 RID: 121673 RVA: 0x000AC500 File Offset: 0x000AA700
		[Token(Token = "0x170045A2")]
		public override NameCardV2ModuleSubType moduleSubType
		{
			[Token(Token = "0x601DB49")]
			[Address(RVA = "0x1745990", Offset = "0x1744590", VA = "0x181745990", Slot = "10")]
			get
			{
				return NameCardV2ModuleSubType.NONE;
			}
		}

		// Token: 0x0601DB4A RID: 121674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB4A")]
		[Address(RVA = "0x1745710", Offset = "0x1744310", VA = "0x181745710", Slot = "9")]
		protected override void OnLoadFriendData(FriendDataWithNameCard data)
		{
		}

		// Token: 0x0601DB4B RID: 121675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB4B")]
		[Address(RVA = "0x17457A0", Offset = "0x17443A0", VA = "0x1817457A0", Slot = "7")]
		protected override void OnLoadSelfData()
		{
		}

		// Token: 0x0601DB4C RID: 121676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB4C")]
		[Address(RVA = "0x1745800", Offset = "0x1744400", VA = "0x181745800", Slot = "8")]
		protected override void OnRefreshSelfData()
		{
		}

		// Token: 0x0601DB4D RID: 121677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB4D")]
		[Address(RVA = "0x17458B0", Offset = "0x17444B0", VA = "0x1817458B0")]
		public void SwitchStyle()
		{
		}

		// Token: 0x0601DB4E RID: 121678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB4E")]
		[Address(RVA = "0x1745930", Offset = "0x1744530", VA = "0x181745930")]
		public NameCardV2AssistModuleModel()
		{
		}

		// Token: 0x04027420 RID: 160800
		[Token(Token = "0x4027420")]
		[FieldOffset(Offset = "0x50")]
		public bool isSelf;

		// Token: 0x04027421 RID: 160801
		[Token(Token = "0x4027421")]
		[FieldOffset(Offset = "0x58")]
		public List<PlayerFriendAssist> sharedCharDataSelf;

		// Token: 0x04027422 RID: 160802
		[Token(Token = "0x4027422")]
		[FieldOffset(Offset = "0x60")]
		public List<SharedCharData> sharedCharDataFriend;

		// Token: 0x04027423 RID: 160803
		[Token(Token = "0x4027423")]
		[FieldOffset(Offset = "0x68")]
		public NameCardV2AssistModuleModel.Style style;

		// Token: 0x04027424 RID: 160804
		[Token(Token = "0x4027424")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_moduleSubType;

		// Token: 0x04027425 RID: 160805
		[Token(Token = "0x4027425")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnLoadFriendData;

		// Token: 0x04027426 RID: 160806
		[Token(Token = "0x4027426")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnLoadSelfData;

		// Token: 0x04027427 RID: 160807
		[Token(Token = "0x4027427")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnRefreshSelfData;

		// Token: 0x04027428 RID: 160808
		[Token(Token = "0x4027428")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SwitchStyle;

		// Token: 0x04027429 RID: 160809
		[Token(Token = "0x4027429")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004D8F RID: 19855
		[Token(Token = "0x2004D8F")]
		public enum Style
		{
			// Token: 0x0402742B RID: 160811
			[Token(Token = "0x402742B")]
			HEAD_ICON,
			// Token: 0x0402742C RID: 160812
			[Token(Token = "0x402742C")]
			PORTRAIT
		}
	}
}
