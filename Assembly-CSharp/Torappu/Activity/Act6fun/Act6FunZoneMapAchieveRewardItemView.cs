using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act6fun
{
	// Token: 0x020071C2 RID: 29122
	[Token(Token = "0x20071C2")]
	public class Act6FunZoneMapAchieveRewardItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170061DD RID: 25053
		// (get) Token: 0x0602953D RID: 169277 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602953E RID: 169278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170061DD")]
		public Action<string> onClaimReward
		{
			[Token(Token = "0x602953D")]
			[Address(RVA = "0x24B2820", Offset = "0x24B1420", VA = "0x1824B2820")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602953E")]
			[Address(RVA = "0x24B2880", Offset = "0x24B1480", VA = "0x1824B2880")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602953F RID: 169279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602953F")]
		[Address(RVA = "0x24B2240", Offset = "0x24B0E40", VA = "0x1824B2240")]
		public void Render(Act6FunZoneMapAchieveRewardItemViewModel itemViewModel)
		{
		}

		// Token: 0x06029540 RID: 169280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029540")]
		[Address(RVA = "0x24B24C0", Offset = "0x24B10C0", VA = "0x1824B24C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06029541 RID: 169281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029541")]
		[Address(RVA = "0x24B26A0", Offset = "0x24B12A0", VA = "0x1824B26A0")]
		private void _OnClickItemShowDetailInfo(int index)
		{
		}

		// Token: 0x06029542 RID: 169282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029542")]
		[Address(RVA = "0x24B2170", Offset = "0x24B0D70", VA = "0x1824B2170")]
		public void OnClaimRewardClick()
		{
		}

		// Token: 0x06029543 RID: 169283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029543")]
		[Address(RVA = "0x24B2750", Offset = "0x24B1350", VA = "0x1824B2750")]
		public Act6FunZoneMapAchieveRewardItemView()
		{
		}

		// Token: 0x0403B04B RID: 241739
		[Token(Token = "0x403B04B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _itemContainer;

		// Token: 0x0403B04C RID: 241740
		[Token(Token = "0x403B04C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _itemScale;

		// Token: 0x0403B04D RID: 241741
		[Token(Token = "0x403B04D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _objCanClaimDesc;

		// Token: 0x0403B04E RID: 241742
		[Token(Token = "0x403B04E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _objCanClaimTxtMask;

		// Token: 0x0403B04F RID: 241743
		[Token(Token = "0x403B04F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _objClaimedDesc;

		// Token: 0x0403B050 RID: 241744
		[Token(Token = "0x403B050")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _txtAchieveNeedCount;

		// Token: 0x0403B051 RID: 241745
		[Token(Token = "0x403B051")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _claimedCol;

		// Token: 0x0403B053 RID: 241747
		[Token(Token = "0x403B053")]
		[FieldOffset(Offset = "0x60")]
		private bool m_hasInited;

		// Token: 0x0403B054 RID: 241748
		[Token(Token = "0x403B054")]
		[FieldOffset(Offset = "0x68")]
		private UIItemCard m_itemCard;

		// Token: 0x0403B055 RID: 241749
		[Token(Token = "0x403B055")]
		[FieldOffset(Offset = "0x70")]
		private UIItemViewModel m_itemModel;

		// Token: 0x0403B056 RID: 241750
		[Token(Token = "0x403B056")]
		[FieldOffset(Offset = "0x78")]
		private string m_cachedRewardId;

		// Token: 0x0403B057 RID: 241751
		[Token(Token = "0x403B057")]
		[FieldOffset(Offset = "0x80")]
		private Act6FunAchieveRewardItemState m_cachedRewardItemState;

		// Token: 0x0403B058 RID: 241752
		[Token(Token = "0x403B058")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onClaimReward;

		// Token: 0x0403B059 RID: 241753
		[Token(Token = "0x403B059")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onClaimReward;

		// Token: 0x0403B05A RID: 241754
		[Token(Token = "0x403B05A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403B05B RID: 241755
		[Token(Token = "0x403B05B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403B05C RID: 241756
		[Token(Token = "0x403B05C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnClickItemShowDetailInfo;

		// Token: 0x0403B05D RID: 241757
		[Token(Token = "0x403B05D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnClaimRewardClick;

		// Token: 0x0403B05E RID: 241758
		[Token(Token = "0x403B05E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
