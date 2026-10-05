using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.DeepSeaRP
{
	// Token: 0x02005186 RID: 20870
	[Token(Token = "0x2005186")]
	public class DeepSeaRPTechTreeViewModel : IHotfixable
	{
		// Token: 0x0601ED95 RID: 126357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601ED95")]
		[Address(RVA = "0x189CD80", Offset = "0x189B980", VA = "0x18189CD80")]
		private static List<DeepSeaRPTechTreeNodeModel> _LoadDataList(Act17sideData actData)
		{
			return null;
		}

		// Token: 0x0601ED96 RID: 126358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601ED96")]
		[Address(RVA = "0x189CC30", Offset = "0x189B830", VA = "0x18189CC30")]
		public static List<DeepSeaRPTechTreeNodeModel> LoadDataList(bool isRetro, string groupId)
		{
			return null;
		}

		// Token: 0x0601ED97 RID: 126359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ED97")]
		[Address(RVA = "0x189D340", Offset = "0x189BF40", VA = "0x18189D340")]
		public DeepSeaRPTechTreeViewModel()
		{
		}

		// Token: 0x04029609 RID: 169481
		[Token(Token = "0x4029609")]
		[FieldOffset(Offset = "0x10")]
		public bool isRetro;

		// Token: 0x0402960A RID: 169482
		[Token(Token = "0x402960A")]
		[FieldOffset(Offset = "0x18")]
		public string groupId;

		// Token: 0x0402960B RID: 169483
		[Token(Token = "0x402960B")]
		[FieldOffset(Offset = "0x20")]
		public List<DeepSeaRPTechTreeNodeModel> nodeViewModelList;

		// Token: 0x0402960C RID: 169484
		[Token(Token = "0x402960C")]
		[FieldOffset(Offset = "0x28")]
		public DeepSeaRPTechTreeViewModel.SETTING_STATE settingState;

		// Token: 0x0402960D RID: 169485
		[Token(Token = "0x402960D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__LoadDataList;

		// Token: 0x0402960E RID: 169486
		[Token(Token = "0x402960E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadDataList;

		// Token: 0x0402960F RID: 169487
		[Token(Token = "0x402960F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005187 RID: 20871
		[Token(Token = "0x2005187")]
		public enum SETTING_STATE
		{
			// Token: 0x04029611 RID: 169489
			[Token(Token = "0x4029611")]
			NONE,
			// Token: 0x04029612 RID: 169490
			[Token(Token = "0x4029612")]
			CHANGE_HAPPENED,
			// Token: 0x04029613 RID: 169491
			[Token(Token = "0x4029613")]
			SAVED
		}
	}
}
