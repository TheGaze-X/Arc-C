using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RecalRune
{
	// Token: 0x020047A8 RID: 18344
	[Token(Token = "0x20047A8")]
	public class RecalRuneSeasonEntryRewardView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601BC75 RID: 113781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BC75")]
		[Address(RVA = "0x152CE60", Offset = "0x152BA60", VA = "0x18152CE60")]
		public void RenderItem(UIItemViewModel itemModel)
		{
		}

		// Token: 0x0601BC76 RID: 113782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BC76")]
		[Address(RVA = "0x152CF70", Offset = "0x152BB70", VA = "0x18152CF70")]
		public void UpdateRewardStatus(RecalRuneSeasonEntryViewModel.RewardStatus status)
		{
		}

		// Token: 0x0601BC77 RID: 113783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BC77")]
		[Address(RVA = "0x152D100", Offset = "0x152BD00", VA = "0x18152D100")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601BC78 RID: 113784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BC78")]
		[Address(RVA = "0x152D310", Offset = "0x152BF10", VA = "0x18152D310")]
		private void _OnItemClick(int index)
		{
		}

		// Token: 0x0601BC79 RID: 113785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BC79")]
		[Address(RVA = "0x152D440", Offset = "0x152C040", VA = "0x18152D440")]
		public RecalRuneSeasonEntryRewardView()
		{
		}

		// Token: 0x040241D0 RID: 147920
		[Token(Token = "0x40241D0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ThreeStateToggle _toggle;

		// Token: 0x040241D1 RID: 147921
		[Token(Token = "0x40241D1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _canClaimBg;

		// Token: 0x040241D2 RID: 147922
		[Token(Token = "0x40241D2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _itemHolder;

		// Token: 0x040241D3 RID: 147923
		[Token(Token = "0x40241D3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _rewardScale;

		// Token: 0x040241D4 RID: 147924
		[Token(Token = "0x40241D4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _itemName;

		// Token: 0x040241D5 RID: 147925
		[Token(Token = "0x40241D5")]
		[FieldOffset(Offset = "0x40")]
		private UIItemCard m_itemCard;

		// Token: 0x040241D6 RID: 147926
		[Token(Token = "0x40241D6")]
		[FieldOffset(Offset = "0x48")]
		private UIItemViewModel m_itemModel;

		// Token: 0x040241D7 RID: 147927
		[Token(Token = "0x40241D7")]
		[FieldOffset(Offset = "0x50")]
		private bool m_hasInited;

		// Token: 0x040241D8 RID: 147928
		[Token(Token = "0x40241D8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderItem;

		// Token: 0x040241D9 RID: 147929
		[Token(Token = "0x40241D9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateRewardStatus;

		// Token: 0x040241DA RID: 147930
		[Token(Token = "0x40241DA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040241DB RID: 147931
		[Token(Token = "0x40241DB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnItemClick;

		// Token: 0x040241DC RID: 147932
		[Token(Token = "0x40241DC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
