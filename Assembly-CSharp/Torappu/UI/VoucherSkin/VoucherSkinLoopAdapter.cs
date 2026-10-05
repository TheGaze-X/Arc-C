using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.VoucherSkin
{
	// Token: 0x02003B90 RID: 15248
	[Token(Token = "0x2003B90")]
	public class VoucherSkinLoopAdapter : LoopScrollAdapter<VoucherSkinItemViewHolder, VoucherSkinItemViewModel>
	{
		// Token: 0x06017E4F RID: 97871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017E4F")]
		[Address(RVA = "0x1026F60", Offset = "0x1025B60", VA = "0x181026F60", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x06017E50 RID: 97872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E50")]
		[Address(RVA = "0x1027010", Offset = "0x1025C10", VA = "0x181027010", Slot = "13")]
		public override void UpdateView(int position, GameObject view, VoucherSkinItemViewHolder holder, VoucherSkinItemViewModel data)
		{
		}

		// Token: 0x06017E51 RID: 97873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E51")]
		[Address(RVA = "0x1027130", Offset = "0x1025D30", VA = "0x181027130")]
		public VoucherSkinLoopAdapter()
		{
		}

		// Token: 0x0401CE3D RID: 118333
		[Token(Token = "0x401CE3D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _skinItemPrefab;

		// Token: 0x0401CE3E RID: 118334
		[Token(Token = "0x401CE3E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x0401CE3F RID: 118335
		[Token(Token = "0x401CE3F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0401CE40 RID: 118336
		[Token(Token = "0x401CE40")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
