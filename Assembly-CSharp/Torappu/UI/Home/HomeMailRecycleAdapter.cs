using System;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004C33 RID: 19507
	[Token(Token = "0x2004C33")]
	public class HomeMailRecycleAdapter : RecycleLoopScrollAdapter<HomeMailItemViewHolder, MailItemViewModel>
	{
		// Token: 0x0601D4AB RID: 119979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4AB")]
		[Address(RVA = "0x16D3E90", Offset = "0x16D2A90", VA = "0x1816D3E90", Slot = "13")]
		public override void UpdateView(int position, GameObject view, HomeMailItemViewHolder holder, MailItemViewModel data)
		{
		}

		// Token: 0x0601D4AC RID: 119980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4AC")]
		[Address(RVA = "0x16D3E30", Offset = "0x16D2A30", VA = "0x1816D3E30", Slot = "12")]
		protected override void OnDataSourceChanged()
		{
		}

		// Token: 0x0601D4AD RID: 119981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4AD")]
		[Address(RVA = "0x16D4160", Offset = "0x16D2D60", VA = "0x1816D4160")]
		private void _OnMailClick(HomeMailIndex index)
		{
		}

		// Token: 0x0601D4AE RID: 119982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4AE")]
		[Address(RVA = "0x16D4220", Offset = "0x16D2E20", VA = "0x1816D4220")]
		private void _OnMailDetailClick(HomeMailIndex index)
		{
		}

		// Token: 0x0601D4AF RID: 119983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D4AF")]
		[Address(RVA = "0x16D4050", Offset = "0x16D2C50", VA = "0x1816D4050", Slot = "14")]
		protected override GameObject ViewConstructor(GameObjectPool objectPool)
		{
			return null;
		}

		// Token: 0x0601D4B0 RID: 119984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4B0")]
		[Address(RVA = "0x16D42E0", Offset = "0x16D2EE0", VA = "0x1816D42E0")]
		public HomeMailRecycleAdapter()
		{
		}

		// Token: 0x0402687F RID: 157823
		[Token(Token = "0x402687F")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		public Action<MailItemViewModel> DealAction;

		// Token: 0x04026880 RID: 157824
		[Token(Token = "0x4026880")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _mailItem;

		// Token: 0x04026881 RID: 157825
		[Token(Token = "0x4026881")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIMailIndexEvent _mailClickEvent;

		// Token: 0x04026882 RID: 157826
		[Token(Token = "0x4026882")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIMailIndexEvent _mailDetailEvent;

		// Token: 0x04026883 RID: 157827
		[Token(Token = "0x4026883")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x04026884 RID: 157828
		[Token(Token = "0x4026884")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDataSourceChanged;

		// Token: 0x04026885 RID: 157829
		[Token(Token = "0x4026885")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnMailClick;

		// Token: 0x04026886 RID: 157830
		[Token(Token = "0x4026886")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnMailDetailClick;

		// Token: 0x04026887 RID: 157831
		[Token(Token = "0x4026887")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ViewConstructor;

		// Token: 0x04026888 RID: 157832
		[Token(Token = "0x4026888")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
