using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003CF3 RID: 15603
	[Token(Token = "0x2003CF3")]
	public class TuningProductBagLoopAdapter : LoopScrollAdapter<TuningProductBagLoopAdapter.ViewHolder, TuningProductBagFormModel>
	{
		// Token: 0x0601854E RID: 99662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601854E")]
		[Address(RVA = "0x10DA830", Offset = "0x10D9430", VA = "0x1810DA830", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x0601854F RID: 99663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601854F")]
		[Address(RVA = "0x10DA8E0", Offset = "0x10D94E0", VA = "0x1810DA8E0", Slot = "13")]
		public override void UpdateView(int position, GameObject view, TuningProductBagLoopAdapter.ViewHolder holder, TuningProductBagFormModel data)
		{
		}

		// Token: 0x06018550 RID: 99664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018550")]
		[Address(RVA = "0x10DAA50", Offset = "0x10D9650", VA = "0x1810DAA50")]
		public TuningProductBagLoopAdapter()
		{
		}

		// Token: 0x0401DBBD RID: 121789
		[Token(Token = "0x401DBBD")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _groupItemView;

		// Token: 0x0401DBBE RID: 121790
		[Token(Token = "0x401DBBE")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		public Action<string> onSelectCard;

		// Token: 0x0401DBBF RID: 121791
		[Token(Token = "0x401DBBF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x0401DBC0 RID: 121792
		[Token(Token = "0x401DBC0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0401DBC1 RID: 121793
		[Token(Token = "0x401DBC1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003CF4 RID: 15604
		[Token(Token = "0x2003CF4")]
		public class ViewHolder
		{
			// Token: 0x06018551 RID: 99665 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018551")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewHolder()
			{
			}

			// Token: 0x0401DBC2 RID: 121794
			[Token(Token = "0x401DBC2")]
			[FieldOffset(Offset = "0x10")]
			public TuningBagCardGroupItemView view;
		}
	}
}
