using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x0200628C RID: 25228
	[Token(Token = "0x200628C")]
	public class AutoChessBandChooseBandListAdapter : LoopScrollAdapter<AutoChessBandChooseBandListAdapter.ViewHolder, AutoChessBandChooseBandItemModel>, IHotfixable
	{
		// Token: 0x170055B5 RID: 21941
		// (get) Token: 0x0602460F RID: 149007 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06024610 RID: 149008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170055B5")]
		public string cachedSelectedBandId
		{
			[Token(Token = "0x602460F")]
			[Address(RVA = "0x1F23B30", Offset = "0x1F22730", VA = "0x181F23B30")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6024610")]
			[Address(RVA = "0x1F23B90", Offset = "0x1F22790", VA = "0x181F23B90")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06024611 RID: 149009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024611")]
		[Address(RVA = "0x1F23850", Offset = "0x1F22450", VA = "0x181F23850", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x06024612 RID: 149010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024612")]
		[Address(RVA = "0x1F23940", Offset = "0x1F22540", VA = "0x181F23940", Slot = "13")]
		public override void UpdateView(int position, GameObject view, AutoChessBandChooseBandListAdapter.ViewHolder holder, AutoChessBandChooseBandItemModel data)
		{
		}

		// Token: 0x06024613 RID: 149011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024613")]
		[Address(RVA = "0x1F23AC0", Offset = "0x1F226C0", VA = "0x181F23AC0")]
		public AutoChessBandChooseBandListAdapter()
		{
		}

		// Token: 0x0403299F RID: 207263
		[Token(Token = "0x403299F")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _prefab;

		// Token: 0x040329A1 RID: 207265
		[Token(Token = "0x40329A1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_cachedSelectedBandId;

		// Token: 0x040329A2 RID: 207266
		[Token(Token = "0x40329A2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_cachedSelectedBandId;

		// Token: 0x040329A3 RID: 207267
		[Token(Token = "0x40329A3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x040329A4 RID: 207268
		[Token(Token = "0x40329A4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x040329A5 RID: 207269
		[Token(Token = "0x40329A5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200628D RID: 25229
		[Token(Token = "0x200628D")]
		public class ViewHolder
		{
			// Token: 0x06024614 RID: 149012 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024614")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewHolder()
			{
			}

			// Token: 0x040329A6 RID: 207270
			[Token(Token = "0x40329A6")]
			[FieldOffset(Offset = "0x10")]
			public AutoChessBandChooseBandItemView view;
		}
	}
}
