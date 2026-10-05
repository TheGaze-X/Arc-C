using System;
using Il2CppDummyDll;
using Torappu.UI.Stage;
using XLua;

namespace Torappu.UI.DeepSeaRP
{
	// Token: 0x0200518E RID: 20878
	[Token(Token = "0x200518E")]
	public class DeepSeaRPBattlePreviewStateBean : IStateBean, IHotfixable
	{
		// Token: 0x170047E7 RID: 18407
		// (get) Token: 0x0601EDA4 RID: 126372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170047E7")]
		public StageViewModel selectedStageModel
		{
			[Token(Token = "0x601EDA4")]
			[Address(RVA = "0x1897890", Offset = "0x1896490", VA = "0x181897890")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601EDA5 RID: 126373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EDA5")]
		[Address(RVA = "0x18975A0", Offset = "0x18961A0", VA = "0x1818975A0")]
		public void LoadData(DeepSeaRPBattleNodeModel battleModel)
		{
		}

		// Token: 0x0601EDA6 RID: 126374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EDA6")]
		[Address(RVA = "0x1897720", Offset = "0x1896320", VA = "0x181897720")]
		public DeepSeaRPBattlePreviewStateBean()
		{
		}

		// Token: 0x04029626 RID: 169510
		[Token(Token = "0x4029626")]
		[FieldOffset(Offset = "0x10")]
		public DeepSeaRPBattleNodeDetailProperty nodeDetailProperty;

		// Token: 0x04029627 RID: 169511
		[Token(Token = "0x4029627")]
		[FieldOffset(Offset = "0x18")]
		public DeepSeaRPBattleNodeConfigProperty nodeConfigProperty;

		// Token: 0x04029628 RID: 169512
		[Token(Token = "0x4029628")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selectedStageModel;

		// Token: 0x04029629 RID: 169513
		[Token(Token = "0x4029629")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402962A RID: 169514
		[Token(Token = "0x402962A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
