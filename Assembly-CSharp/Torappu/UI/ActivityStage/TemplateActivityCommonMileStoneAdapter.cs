using System;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006CC1 RID: 27841
	[Token(Token = "0x2006CC1")]
	public class TemplateActivityCommonMileStoneAdapter : RecycleLoopScrollAdapter<TemplateActivityCommonMileStoneAdapter.ViewHolder, TemplateActivityMileStoneItemModel>
	{
		// Token: 0x06027B95 RID: 162709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027B95")]
		[Address(RVA = "0x22D8570", Offset = "0x22D7170", VA = "0x1822D8570", Slot = "14")]
		protected override GameObject ViewConstructor(GameObjectPool objectPool)
		{
			return null;
		}

		// Token: 0x06027B96 RID: 162710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B96")]
		[Address(RVA = "0x22D8420", Offset = "0x22D7020", VA = "0x1822D8420", Slot = "13")]
		public override void UpdateView(int position, GameObject view, TemplateActivityCommonMileStoneAdapter.ViewHolder holder, TemplateActivityMileStoneItemModel data)
		{
		}

		// Token: 0x06027B97 RID: 162711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B97")]
		[Address(RVA = "0x22D8630", Offset = "0x22D7230", VA = "0x1822D8630")]
		public TemplateActivityCommonMileStoneAdapter()
		{
		}

		// Token: 0x04038531 RID: 230705
		[Token(Token = "0x4038531")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private TemplateActivityCommonMileStoneItemView _mileStoneItem;

		// Token: 0x04038532 RID: 230706
		[Token(Token = "0x4038532")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ViewConstructor;

		// Token: 0x04038533 RID: 230707
		[Token(Token = "0x4038533")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x04038534 RID: 230708
		[Token(Token = "0x4038534")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006CC2 RID: 27842
		[Token(Token = "0x2006CC2")]
		public class ViewHolder
		{
			// Token: 0x06027B98 RID: 162712 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027B98")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewHolder()
			{
			}

			// Token: 0x04038535 RID: 230709
			[Token(Token = "0x4038535")]
			[FieldOffset(Offset = "0x10")]
			public TemplateActivityCommonMileStoneItemView viewComp;
		}
	}
}
