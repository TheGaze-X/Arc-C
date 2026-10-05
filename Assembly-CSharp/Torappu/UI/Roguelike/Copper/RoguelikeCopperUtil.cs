using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.Copper
{
	// Token: 0x0200589B RID: 22683
	[Token(Token = "0x200589B")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class RoguelikeCopperUtil
	{
		// Token: 0x060211BE RID: 135614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60211BE")]
		[Address(RVA = "0x1B7D750", Offset = "0x1B7C350", VA = "0x181B7D750")]
		public static RoguelikeCopperModuleData GetGameCopperModuleData(string topicId)
		{
			return null;
		}

		// Token: 0x060211BF RID: 135615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60211BF")]
		[Address(RVA = "0x1B7DBF0", Offset = "0x1B7C7F0", VA = "0x181B7DBF0")]
		public static PlayerRoguelikeV2.CurrentData.Module.Copper GetPlayerCopperModuleData()
		{
			return null;
		}

		// Token: 0x060211C0 RID: 135616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60211C0")]
		[Address(RVA = "0x1B7D660", Offset = "0x1B7C260", VA = "0x181B7D660")]
		public static string GetCopperDescWithLayer(string layerDesc, string desc, int layer)
		{
			return null;
		}

		// Token: 0x060211C1 RID: 135617 RVA: 0x000B8908 File Offset: 0x000B6B08
		[Token(Token = "0x60211C1")]
		[Address(RVA = "0x1B7D850", Offset = "0x1B7C450", VA = "0x181B7D850")]
		public static RoguelikeCopperLuckyLevel GetLuckyLevelByCopperId(string topicId, string copperId)
		{
			return RoguelikeCopperLuckyLevel.NONE;
		}

		// Token: 0x060211C2 RID: 135618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60211C2")]
		[Address(RVA = "0x1B7DFD0", Offset = "0x1B7CBD0", VA = "0x181B7DFD0")]
		public static RoguelikeCopperResHolder LoadRlCopperResHolder(ILoadAsset iLoadAsset, string topicId)
		{
			return null;
		}

		// Token: 0x060211C3 RID: 135619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60211C3")]
		[Address(RVA = "0x1B7D920", Offset = "0x1B7C520", VA = "0x181B7D920")]
		public static RoguelikePlayerCopperItemViewModel GetPlayerCanRefreshNodeCopper(string topicId, RoguelikeCopperBuffType buffType)
		{
			return null;
		}

		// Token: 0x060211C4 RID: 135620 RVA: 0x000B8920 File Offset: 0x000B6B20
		[Token(Token = "0x60211C4")]
		[Address(RVA = "0x1B7DCB0", Offset = "0x1B7C8B0", VA = "0x181B7DCB0")]
		public static bool IsCopperDrawnAndLeftUseTime(string topicId, RoguelikeCopperBuffType buffType, out int countDown)
		{
			return default(bool);
		}

		// Token: 0x0402D148 RID: 184648
		[Token(Token = "0x402D148")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetGameCopperModuleData;

		// Token: 0x0402D149 RID: 184649
		[Token(Token = "0x402D149")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetPlayerCopperModuleData;

		// Token: 0x0402D14A RID: 184650
		[Token(Token = "0x402D14A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetCopperDescWithLayer;

		// Token: 0x0402D14B RID: 184651
		[Token(Token = "0x402D14B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetLuckyLevelByCopperId;

		// Token: 0x0402D14C RID: 184652
		[Token(Token = "0x402D14C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadRlCopperResHolder;

		// Token: 0x0402D14D RID: 184653
		[Token(Token = "0x402D14D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetPlayerCanRefreshNodeCopper;

		// Token: 0x0402D14E RID: 184654
		[Token(Token = "0x402D14E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_IsCopperDrawnAndLeftUseTime;
	}
}
