using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004D90 RID: 19856
	[Token(Token = "0x2004D90")]
	public class NameCardV2MedalModuleModel : NameCardV2RemovableModuleBaseModel
	{
		// Token: 0x170045A3 RID: 17827
		// (get) Token: 0x0601DB4F RID: 121679 RVA: 0x000AC518 File Offset: 0x000AA718
		[Token(Token = "0x170045A3")]
		public override NameCardV2ModuleSubType moduleSubType
		{
			[Token(Token = "0x601DB4F")]
			[Address(RVA = "0x1749D20", Offset = "0x1748920", VA = "0x181749D20", Slot = "10")]
			get
			{
				return NameCardV2ModuleSubType.NONE;
			}
		}

		// Token: 0x0601DB50 RID: 121680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB50")]
		[Address(RVA = "0x17494C0", Offset = "0x17480C0", VA = "0x1817494C0", Slot = "9")]
		protected override void OnLoadFriendData(FriendDataWithNameCard data)
		{
		}

		// Token: 0x0601DB51 RID: 121681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB51")]
		[Address(RVA = "0x1749550", Offset = "0x1748150", VA = "0x181749550", Slot = "7")]
		protected override void OnLoadSelfData()
		{
		}

		// Token: 0x0601DB52 RID: 121682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB52")]
		[Address(RVA = "0x17495B0", Offset = "0x17481B0", VA = "0x1817495B0", Slot = "8")]
		protected override void OnRefreshSelfData()
		{
		}

		// Token: 0x0601DB53 RID: 121683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB53")]
		[Address(RVA = "0x1749CC0", Offset = "0x17488C0", VA = "0x181749CC0")]
		public NameCardV2MedalModuleModel()
		{
		}

		// Token: 0x0402742D RID: 160813
		[Token(Token = "0x402742D")]
		[FieldOffset(Offset = "0x50")]
		public FriendMedalBoard medalBoard;

		// Token: 0x0402742E RID: 160814
		[Token(Token = "0x402742E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_moduleSubType;

		// Token: 0x0402742F RID: 160815
		[Token(Token = "0x402742F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnLoadFriendData;

		// Token: 0x04027430 RID: 160816
		[Token(Token = "0x4027430")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnLoadSelfData;

		// Token: 0x04027431 RID: 160817
		[Token(Token = "0x4027431")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnRefreshSelfData;

		// Token: 0x04027432 RID: 160818
		[Token(Token = "0x4027432")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
