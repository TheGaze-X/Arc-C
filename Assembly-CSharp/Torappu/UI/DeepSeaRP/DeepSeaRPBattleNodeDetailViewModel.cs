using System;
using Il2CppDummyDll;
using Torappu.UI.Stage;
using XLua;

namespace Torappu.UI.DeepSeaRP
{
	// Token: 0x0200518C RID: 20876
	[Token(Token = "0x200518C")]
	public class DeepSeaRPBattleNodeDetailViewModel : IHotfixable
	{
		// Token: 0x170047E6 RID: 18406
		// (get) Token: 0x0601EDA0 RID: 126368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170047E6")]
		public StageViewModel currSelectStage
		{
			[Token(Token = "0x601EDA0")]
			[Address(RVA = "0x1897520", Offset = "0x1896120", VA = "0x181897520")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601EDA1 RID: 126369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EDA1")]
		[Address(RVA = "0x1897440", Offset = "0x1896040", VA = "0x181897440")]
		public string GetPreviewStageId()
		{
			return null;
		}

		// Token: 0x0601EDA2 RID: 126370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EDA2")]
		[Address(RVA = "0x18974C0", Offset = "0x18960C0", VA = "0x1818974C0")]
		public DeepSeaRPBattleNodeDetailViewModel()
		{
		}

		// Token: 0x0402961F RID: 169503
		[Token(Token = "0x402961F")]
		[FieldOffset(Offset = "0x10")]
		public DeepSeaRPBattleNodeModel nodeModel;

		// Token: 0x04029620 RID: 169504
		[Token(Token = "0x4029620")]
		[FieldOffset(Offset = "0x18")]
		public bool isSelectedHard;

		// Token: 0x04029621 RID: 169505
		[Token(Token = "0x4029621")]
		[FieldOffset(Offset = "0x19")]
		public bool isShowDetail;

		// Token: 0x04029622 RID: 169506
		[Token(Token = "0x4029622")]
		[FieldOffset(Offset = "0x1A")]
		public bool isSelectedStory;

		// Token: 0x04029623 RID: 169507
		[Token(Token = "0x4029623")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_currSelectStage;

		// Token: 0x04029624 RID: 169508
		[Token(Token = "0x4029624")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetPreviewStageId;

		// Token: 0x04029625 RID: 169509
		[Token(Token = "0x4029625")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
