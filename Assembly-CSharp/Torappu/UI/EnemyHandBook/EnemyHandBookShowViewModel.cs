using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.EnemyHandBook
{
	// Token: 0x02004F40 RID: 20288
	[Token(Token = "0x2004F40")]
	public class EnemyHandBookShowViewModel : IHotfixable
	{
		// Token: 0x0601E367 RID: 123751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E367")]
		[Address(RVA = "0x17EB100", Offset = "0x17E9D00", VA = "0x1817EB100")]
		public void CheckLink()
		{
		}

		// Token: 0x170046DA RID: 18138
		// (set) Token: 0x0601E368 RID: 123752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170046DA")]
		public int selectIndex
		{
			[Token(Token = "0x601E368")]
			[Address(RVA = "0x17EBB90", Offset = "0x17EA790", VA = "0x1817EBB90")]
			set
			{
			}
		}

		// Token: 0x0601E369 RID: 123753 RVA: 0x000ADE98 File Offset: 0x000AC098
		[Token(Token = "0x601E369")]
		[Address(RVA = "0x17EB940", Offset = "0x17EA540", VA = "0x1817EB940")]
		public bool TryGetSelectEnemy(out EnemyHandBookEverViewModel viewModel)
		{
			return default(bool);
		}

		// Token: 0x0601E36A RID: 123754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E36A")]
		[Address(RVA = "0x17EB500", Offset = "0x17EA100", VA = "0x1817EB500")]
		public List<EnemyHandBookEverViewModel> GetList()
		{
			return null;
		}

		// Token: 0x0601E36B RID: 123755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E36B")]
		[Address(RVA = "0x17EB700", Offset = "0x17EA300", VA = "0x1817EB700")]
		public EnemyHandBookEverViewModel GetSelectEnemyHandbook(out int index)
		{
			return null;
		}

		// Token: 0x0601E36C RID: 123756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E36C")]
		[Address(RVA = "0x17EB840", Offset = "0x17EA440", VA = "0x1817EB840")]
		public void ShuffleHideEnemyIfNeed()
		{
		}

		// Token: 0x0601E36D RID: 123757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E36D")]
		[Address(RVA = "0x17EBA90", Offset = "0x17EA690", VA = "0x1817EBA90")]
		public EnemyHandBookShowViewModel()
		{
		}

		// Token: 0x04028455 RID: 164949
		[Token(Token = "0x4028455")]
		[FieldOffset(Offset = "0x10")]
		public List<EnemyHandBookEverViewModel> enemyList;

		// Token: 0x04028456 RID: 164950
		[Token(Token = "0x4028456")]
		[FieldOffset(Offset = "0x18")]
		public bool needShuffleHide;

		// Token: 0x04028457 RID: 164951
		[Token(Token = "0x4028457")]
		[FieldOffset(Offset = "0x20")]
		public string selectedEnemyId;

		// Token: 0x04028458 RID: 164952
		[Token(Token = "0x4028458")]
		[FieldOffset(Offset = "0x28")]
		public bool disableNewFlag;

		// Token: 0x04028459 RID: 164953
		[Token(Token = "0x4028459")]
		[FieldOffset(Offset = "0x30")]
		public EnemyHandbookShuffleViewModel shuffleViewModel;

		// Token: 0x0402845A RID: 164954
		[Token(Token = "0x402845A")]
		[FieldOffset(Offset = "0x38")]
		private List<EnemyHandBookEverViewModel> m_resultList;

		// Token: 0x0402845B RID: 164955
		[Token(Token = "0x402845B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckLink;

		// Token: 0x0402845C RID: 164956
		[Token(Token = "0x402845C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_selectIndex;

		// Token: 0x0402845D RID: 164957
		[Token(Token = "0x402845D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_TryGetSelectEnemy;

		// Token: 0x0402845E RID: 164958
		[Token(Token = "0x402845E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetList;

		// Token: 0x0402845F RID: 164959
		[Token(Token = "0x402845F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetSelectEnemyHandbook;

		// Token: 0x04028460 RID: 164960
		[Token(Token = "0x4028460")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ShuffleHideEnemyIfNeed;

		// Token: 0x04028461 RID: 164961
		[Token(Token = "0x4028461")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
