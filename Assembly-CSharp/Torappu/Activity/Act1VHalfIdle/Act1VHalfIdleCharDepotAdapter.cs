using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x0200773E RID: 30526
	[Token(Token = "0x200773E")]
	public class Act1VHalfIdleCharDepotAdapter : LoopScrollAdapter<Act1VHalfIdleCharDepotAdapter.ViewHolder, Act1VHalfIdleCharSelectCardViewModel>
	{
		// Token: 0x17006490 RID: 25744
		// (get) Token: 0x0602AE25 RID: 175653 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602AE26 RID: 175654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006490")]
		public string actId
		{
			[Token(Token = "0x602AE25")]
			[Address(RVA = "0x26AAD00", Offset = "0x26A9900", VA = "0x1826AAD00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602AE26")]
			[Address(RVA = "0x26AAE20", Offset = "0x26A9A20", VA = "0x1826AAE20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17006491 RID: 25745
		// (get) Token: 0x0602AE27 RID: 175655 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602AE28 RID: 175656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006491")]
		public Action<Act1VHalfIdleCharDepotCard.Options> onItemClick
		{
			[Token(Token = "0x602AE27")]
			[Address(RVA = "0x26AAD60", Offset = "0x26A9960", VA = "0x1826AAD60")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602AE28")]
			[Address(RVA = "0x26AAEA0", Offset = "0x26A9AA0", VA = "0x1826AAEA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17006492 RID: 25746
		// (get) Token: 0x0602AE29 RID: 175657 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602AE2A RID: 175658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006492")]
		public SpriteHub professionHub
		{
			[Token(Token = "0x602AE29")]
			[Address(RVA = "0x26AADC0", Offset = "0x26A99C0", VA = "0x1826AADC0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602AE2A")]
			[Address(RVA = "0x26AAF20", Offset = "0x26A9B20", VA = "0x1826AAF20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602AE2B RID: 175659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AE2B")]
		[Address(RVA = "0x26AA660", Offset = "0x26A9260", VA = "0x1826AA660", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x0602AE2C RID: 175660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE2C")]
		[Address(RVA = "0x26AA790", Offset = "0x26A9390", VA = "0x1826AA790", Slot = "13")]
		public override void UpdateView(int position, GameObject view, Act1VHalfIdleCharDepotAdapter.ViewHolder holder, Act1VHalfIdleCharSelectCardViewModel data)
		{
		}

		// Token: 0x0602AE2D RID: 175661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE2D")]
		[Address(RVA = "0x26AAB50", Offset = "0x26A9750", VA = "0x1826AAB50")]
		private void _RegisterTutorialGO(Act1VHalfIdleCharDepotCard cardView)
		{
		}

		// Token: 0x0602AE2E RID: 175662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE2E")]
		[Address(RVA = "0x26AAC90", Offset = "0x26A9890", VA = "0x1826AAC90")]
		public Act1VHalfIdleCharDepotAdapter()
		{
		}

		// Token: 0x0403DD48 RID: 253256
		[Token(Token = "0x403DD48")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Act1VHalfIdleCharDepotCard _prefab;

		// Token: 0x0403DD4C RID: 253260
		[Token(Token = "0x403DD4C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_actId;

		// Token: 0x0403DD4D RID: 253261
		[Token(Token = "0x403DD4D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_actId;

		// Token: 0x0403DD4E RID: 253262
		[Token(Token = "0x403DD4E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onItemClick;

		// Token: 0x0403DD4F RID: 253263
		[Token(Token = "0x403DD4F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onItemClick;

		// Token: 0x0403DD50 RID: 253264
		[Token(Token = "0x403DD50")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_professionHub;

		// Token: 0x0403DD51 RID: 253265
		[Token(Token = "0x403DD51")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_professionHub;

		// Token: 0x0403DD52 RID: 253266
		[Token(Token = "0x403DD52")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x0403DD53 RID: 253267
		[Token(Token = "0x403DD53")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0403DD54 RID: 253268
		[Token(Token = "0x403DD54")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RegisterTutorialGO;

		// Token: 0x0403DD55 RID: 253269
		[Token(Token = "0x403DD55")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200773F RID: 30527
		[Token(Token = "0x200773F")]
		public class ViewHolder
		{
			// Token: 0x0602AE2F RID: 175663 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AE2F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewHolder()
			{
			}

			// Token: 0x0403DD56 RID: 253270
			[Token(Token = "0x403DD56")]
			[FieldOffset(Offset = "0x10")]
			public Act1VHalfIdleCharDepotCard holder;
		}
	}
}
