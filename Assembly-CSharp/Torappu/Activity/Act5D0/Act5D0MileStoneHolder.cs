using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act5D0
{
	// Token: 0x020071F9 RID: 29177
	[Token(Token = "0x20071F9")]
	public class Act5D0MileStoneHolder : MileStoneHolder
	{
		// Token: 0x0602961C RID: 169500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602961C")]
		[Address(RVA = "0x24C0E60", Offset = "0x24BFA60", VA = "0x1824C0E60", Slot = "4")]
		protected override void OnRefreshHolderInfo(List<MileStoneViewModel> viewModelList, int count, string spReward)
		{
		}

		// Token: 0x0602961D RID: 169501 RVA: 0x000D5828 File Offset: 0x000D3A28
		[Token(Token = "0x602961D")]
		[Address(RVA = "0x24C0D10", Offset = "0x24BF910", VA = "0x1824C0D10", Slot = "5")]
		protected override float GetScrollToTargetIndex(int firstAbleGet)
		{
			return 0f;
		}

		// Token: 0x0602961E RID: 169502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602961E")]
		[Address(RVA = "0x24C10E0", Offset = "0x24BFCE0", VA = "0x1824C10E0")]
		public Act5D0MileStoneHolder()
		{
		}

		// Token: 0x0403B1B8 RID: 242104
		[Token(Token = "0x403B1B8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _curMilestoneToken;

		// Token: 0x0403B1B9 RID: 242105
		[Token(Token = "0x403B1B9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _curBonusCond;

		// Token: 0x0403B1BA RID: 242106
		[Token(Token = "0x403B1BA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _curBonusName;

		// Token: 0x0403B1BB RID: 242107
		[Token(Token = "0x403B1BB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRefreshHolderInfo;

		// Token: 0x0403B1BC RID: 242108
		[Token(Token = "0x403B1BC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetScrollToTargetIndex;

		// Token: 0x0403B1BD RID: 242109
		[Token(Token = "0x403B1BD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
