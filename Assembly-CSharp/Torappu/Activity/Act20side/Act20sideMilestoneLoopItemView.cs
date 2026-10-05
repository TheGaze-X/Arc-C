using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x02007689 RID: 30345
	[Token(Token = "0x2007689")]
	public class Act20sideMilestoneLoopItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602AAE6 RID: 174822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AAE6")]
		[Address(RVA = "0x2676FF0", Offset = "0x2675BF0", VA = "0x182676FF0")]
		public void Render(Act20sideMilestoneLoopItemViewModel data)
		{
		}

		// Token: 0x0602AAE7 RID: 174823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AAE7")]
		[Address(RVA = "0x26771B0", Offset = "0x2675DB0", VA = "0x1826771B0")]
		public Act20sideMilestoneLoopItemView()
		{
		}

		// Token: 0x0403D7DF RID: 251871
		[Token(Token = "0x403D7DF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<GameObject> _itemBg;

		// Token: 0x0403D7E0 RID: 251872
		[Token(Token = "0x403D7E0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<Image> _itemImg;

		// Token: 0x0403D7E1 RID: 251873
		[Token(Token = "0x403D7E1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403D7E2 RID: 251874
		[Token(Token = "0x403D7E2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200768A RID: 30346
		[Token(Token = "0x200768A")]
		public class IVirtualView : UIRecycleLayoutAdapter.VirtualView<Act20sideMilestoneLoopItemView>
		{
			// Token: 0x0602AAE8 RID: 174824 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602AAE8")]
			[Address(RVA = "0x267CBF0", Offset = "0x267B7F0", VA = "0x18267CBF0", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x0602AAE9 RID: 174825 RVA: 0x000D9608 File Offset: 0x000D7808
			[Token(Token = "0x602AAE9")]
			[Address(RVA = "0x267CC60", Offset = "0x267B860", VA = "0x18267CC60", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x0602AAEA RID: 174826 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AAEA")]
			[Address(RVA = "0x267CEF0", Offset = "0x267BAF0", VA = "0x18267CEF0", Slot = "11")]
			protected override void OnViewDetached()
			{
			}

			// Token: 0x0602AAEB RID: 174827 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AAEB")]
			[Address(RVA = "0x267CCC0", Offset = "0x267B8C0", VA = "0x18267CCC0", Slot = "10")]
			protected override void OnViewAttached()
			{
			}

			// Token: 0x0602AAEC RID: 174828 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AAEC")]
			[Address(RVA = "0x267CF50", Offset = "0x267BB50", VA = "0x18267CF50")]
			public IVirtualView()
			{
			}

			// Token: 0x0403D7E3 RID: 251875
			[Token(Token = "0x403D7E3")]
			[FieldOffset(Offset = "0x20")]
			public Act20sideMilestoneLoopItemViewModel viewModel;

			// Token: 0x0403D7E4 RID: 251876
			[Token(Token = "0x403D7E4")]
			[FieldOffset(Offset = "0x28")]
			public Act20sideMilestoneLoopItemView prefab;

			// Token: 0x0403D7E5 RID: 251877
			[Token(Token = "0x403D7E5")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x0403D7E6 RID: 251878
			[Token(Token = "0x403D7E6")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetPreferSize;

			// Token: 0x0403D7E7 RID: 251879
			[Token(Token = "0x403D7E7")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OnViewDetached;

			// Token: 0x0403D7E8 RID: 251880
			[Token(Token = "0x403D7E8")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnViewAttached;

			// Token: 0x0403D7E9 RID: 251881
			[Token(Token = "0x403D7E9")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
