using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02005053 RID: 20563
	[Token(Token = "0x2005053")]
	public class EnemyDuelPrepareSelectModeSelectionViewModel
	{
		// Token: 0x17004726 RID: 18214
		// (get) Token: 0x0601E7B6 RID: 124854 RVA: 0x000AE900 File Offset: 0x000ACB00
		[Token(Token = "0x17004726")]
		public int cardCount
		{
			[Token(Token = "0x601E7B6")]
			[Address(RVA = "0x182C130", Offset = "0x182AD30", VA = "0x18182C130")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17004727 RID: 18215
		// (get) Token: 0x0601E7B7 RID: 124855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004727")]
		public EnemyDuelPrepareSelectModeCardViewModel selectedViewModel
		{
			[Token(Token = "0x601E7B7")]
			[Address(RVA = "0x182C170", Offset = "0x182AD70", VA = "0x18182C170")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601E7B8 RID: 124856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E7B8")]
		[Address(RVA = "0x182BDC0", Offset = "0x182A9C0", VA = "0x18182BDC0")]
		public void LoadData(EnemyDuelPrepareSelectModeViewModel mainViewModel, string selectedModeId)
		{
		}

		// Token: 0x0601E7B9 RID: 124857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E7B9")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public EnemyDuelPrepareSelectModeSelectionViewModel()
		{
		}

		// Token: 0x04028D46 RID: 167238
		[Token(Token = "0x4028D46")]
		[FieldOffset(Offset = "0x10")]
		public int seqNum;

		// Token: 0x04028D47 RID: 167239
		[Token(Token = "0x4028D47")]
		[FieldOffset(Offset = "0x14")]
		public int cardSelectIdx;

		// Token: 0x04028D48 RID: 167240
		[Token(Token = "0x4028D48")]
		[FieldOffset(Offset = "0x18")]
		public List<EnemyDuelPrepareSelectModeCardViewModel> cardViewModels;
	}
}
