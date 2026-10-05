using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004D8D RID: 19853
	[Token(Token = "0x2004D8D")]
	public class NameCardV2SignModuleModel : NameCardV2RemovableModuleBaseModel
	{
		// Token: 0x170045A1 RID: 17825
		// (get) Token: 0x0601DB44 RID: 121668 RVA: 0x000AC4E8 File Offset: 0x000AA6E8
		[Token(Token = "0x170045A1")]
		public override NameCardV2ModuleSubType moduleSubType
		{
			[Token(Token = "0x601DB44")]
			[Address(RVA = "0x174AEE0", Offset = "0x1749AE0", VA = "0x18174AEE0", Slot = "10")]
			get
			{
				return NameCardV2ModuleSubType.NONE;
			}
		}

		// Token: 0x0601DB45 RID: 121669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB45")]
		[Address(RVA = "0x174AC30", Offset = "0x1749830", VA = "0x18174AC30", Slot = "9")]
		protected override void OnLoadFriendData(FriendDataWithNameCard data)
		{
		}

		// Token: 0x0601DB46 RID: 121670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB46")]
		[Address(RVA = "0x174AD10", Offset = "0x1749910", VA = "0x18174AD10", Slot = "7")]
		protected override void OnLoadSelfData()
		{
		}

		// Token: 0x0601DB47 RID: 121671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB47")]
		[Address(RVA = "0x174AD70", Offset = "0x1749970", VA = "0x18174AD70", Slot = "8")]
		protected override void OnRefreshSelfData()
		{
		}

		// Token: 0x0601DB48 RID: 121672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB48")]
		[Address(RVA = "0x174AE80", Offset = "0x1749A80", VA = "0x18174AE80")]
		public NameCardV2SignModuleModel()
		{
		}

		// Token: 0x0402741A RID: 160794
		[Token(Token = "0x402741A")]
		[FieldOffset(Offset = "0x50")]
		public string resume;

		// Token: 0x0402741B RID: 160795
		[Token(Token = "0x402741B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_moduleSubType;

		// Token: 0x0402741C RID: 160796
		[Token(Token = "0x402741C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnLoadFriendData;

		// Token: 0x0402741D RID: 160797
		[Token(Token = "0x402741D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnLoadSelfData;

		// Token: 0x0402741E RID: 160798
		[Token(Token = "0x402741E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnRefreshSelfData;

		// Token: 0x0402741F RID: 160799
		[Token(Token = "0x402741F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
