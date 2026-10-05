using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Roguelike.Copper;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x020055DD RID: 21981
	[Token(Token = "0x20055DD")]
	public class RL05MenuCopperListViewModel : RoguelikeMenuCompViewModel
	{
		// Token: 0x0602043B RID: 132155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602043B")]
		[Address(RVA = "0x1A62450", Offset = "0x1A61050", VA = "0x181A62450", Slot = "4")]
		public override void LoadData(string topicId)
		{
		}

		// Token: 0x0602043C RID: 132156 RVA: 0x000B5200 File Offset: 0x000B3400
		[Token(Token = "0x602043C")]
		[Address(RVA = "0x1A62370", Offset = "0x1A60F70", VA = "0x181A62370")]
		public int GetDrawnCopperItemsCount()
		{
			return 0;
		}

		// Token: 0x0602043D RID: 132157 RVA: 0x000B5218 File Offset: 0x000B3418
		[Token(Token = "0x602043D")]
		[Address(RVA = "0x1A62160", Offset = "0x1A60D60", VA = "0x181A62160")]
		public int GetAllCopperItemsCount()
		{
			return 0;
		}

		// Token: 0x0602043E RID: 132158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602043E")]
		[Address(RVA = "0x1A62260", Offset = "0x1A60E60", VA = "0x181A62260")]
		public List<RoguelikePlayerCopperItemViewModel> GetDrawnCopperItemViewModels()
		{
			return null;
		}

		// Token: 0x0602043F RID: 132159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602043F")]
		[Address(RVA = "0x1A621D0", Offset = "0x1A60DD0", VA = "0x181A621D0")]
		public RoguelikePlayerCopperItemViewModel GetCopperItemViewModel(int index)
		{
			return null;
		}

		// Token: 0x06020440 RID: 132160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020440")]
		[Address(RVA = "0x1A629B0", Offset = "0x1A615B0", VA = "0x181A629B0")]
		public RL05MenuCopperListViewModel()
		{
		}

		// Token: 0x06020441 RID: 132161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020441")]
		[Address(RVA = "0x1A629A0", Offset = "0x1A615A0", VA = "0x181A629A0")]
		private void <>xLuaBaseProxy_LoadData(string P0)
		{
		}

		// Token: 0x0402BA5F RID: 178783
		[Token(Token = "0x402BA5F")]
		[FieldOffset(Offset = "0x18")]
		public bool initProcessing;

		// Token: 0x0402BA60 RID: 178784
		[Token(Token = "0x402BA60")]
		[FieldOffset(Offset = "0x19")]
		public bool copperMenuBtnHide;

		// Token: 0x0402BA61 RID: 178785
		[Token(Token = "0x402BA61")]
		[FieldOffset(Offset = "0x20")]
		private string m_topicId;

		// Token: 0x0402BA62 RID: 178786
		[Token(Token = "0x402BA62")]
		[FieldOffset(Offset = "0x28")]
		private List<RoguelikePlayerCopperItemViewModel> m_allCopperItemViewModels;

		// Token: 0x0402BA63 RID: 178787
		[Token(Token = "0x402BA63")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402BA64 RID: 178788
		[Token(Token = "0x402BA64")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetDrawnCopperItemsCount;

		// Token: 0x0402BA65 RID: 178789
		[Token(Token = "0x402BA65")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetAllCopperItemsCount;

		// Token: 0x0402BA66 RID: 178790
		[Token(Token = "0x402BA66")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetDrawnCopperItemViewModels;

		// Token: 0x0402BA67 RID: 178791
		[Token(Token = "0x402BA67")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetCopperItemViewModel;

		// Token: 0x0402BA68 RID: 178792
		[Token(Token = "0x402BA68")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
