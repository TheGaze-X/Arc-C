using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020077C0 RID: 30656
	[Token(Token = "0x20077C0")]
	public class Act1VHalfIdleDirectGachaSelectCharItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602B080 RID: 176256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B080")]
		[Address(RVA = "0x26D8490", Offset = "0x26D7090", VA = "0x1826D8490")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602B081 RID: 176257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B081")]
		[Address(RVA = "0x26D85B0", Offset = "0x26D71B0", VA = "0x1826D85B0")]
		private void _Render(Act1VHalfIdleDirectGachaSelectCharItemView.VirtualView virtualView)
		{
		}

		// Token: 0x0602B082 RID: 176258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B082")]
		[Address(RVA = "0x26D83E0", Offset = "0x26D6FE0", VA = "0x1826D83E0")]
		public void TryUpdateSelectStatus(Act1VHalfIdleDirectGachaSelectDialog.GachaSelectViewModel gachaSelectViewModel)
		{
		}

		// Token: 0x0602B083 RID: 176259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B083")]
		[Address(RVA = "0x26D87A0", Offset = "0x26D73A0", VA = "0x1826D87A0")]
		public Act1VHalfIdleDirectGachaSelectCharItemView()
		{
		}

		// Token: 0x0403E23C RID: 254524
		[Token(Token = "0x403E23C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int _height;

		// Token: 0x0403E23D RID: 254525
		[Token(Token = "0x403E23D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _charList;

		// Token: 0x0403E23E RID: 254526
		[Token(Token = "0x403E23E")]
		[FieldOffset(Offset = "0x28")]
		private bool m_inited;

		// Token: 0x0403E23F RID: 254527
		[Token(Token = "0x403E23F")]
		[FieldOffset(Offset = "0x30")]
		private Act1VHalfIdleDirectGachaSelectCharItemView.Adapter m_adapter;

		// Token: 0x0403E240 RID: 254528
		[Token(Token = "0x403E240")]
		[FieldOffset(Offset = "0x38")]
		private Act1VHalfIdleDirectGachaSelectCharItemView.VirtualView m_cachedData;

		// Token: 0x0403E241 RID: 254529
		[Token(Token = "0x403E241")]
		[FieldOffset(Offset = "0x40")]
		private string m_cachedSelectedCharId;

		// Token: 0x0403E242 RID: 254530
		[Token(Token = "0x403E242")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403E243 RID: 254531
		[Token(Token = "0x403E243")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0403E244 RID: 254532
		[Token(Token = "0x403E244")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_TryUpdateSelectStatus;

		// Token: 0x0403E245 RID: 254533
		[Token(Token = "0x403E245")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020077C1 RID: 30657
		[Token(Token = "0x20077C1")]
		public class VirtualView : UIRecycleLayoutAdapter.VirtualView<Act1VHalfIdleDirectGachaSelectCharItemView>
		{
			// Token: 0x0602B084 RID: 176260 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B084")]
			[Address(RVA = "0x26EDF00", Offset = "0x26ECB00", VA = "0x1826EDF00", Slot = "10")]
			protected override void OnViewAttached()
			{
			}

			// Token: 0x0602B085 RID: 176261 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B085")]
			[Address(RVA = "0x26EE050", Offset = "0x26ECC50", VA = "0x1826EE050", Slot = "11")]
			protected override void OnViewDetached()
			{
			}

			// Token: 0x0602B086 RID: 176262 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602B086")]
			[Address(RVA = "0x26ED820", Offset = "0x26EC420", VA = "0x1826ED820", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x0602B087 RID: 176263 RVA: 0x000DAA60 File Offset: 0x000D8C60
			[Token(Token = "0x602B087")]
			[Address(RVA = "0x26ED970", Offset = "0x26EC570", VA = "0x1826ED970", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x0602B088 RID: 176264 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B088")]
			[Address(RVA = "0x26EE110", Offset = "0x26ECD10", VA = "0x1826EE110")]
			public void TryUpdateSelectStatus(Act1VHalfIdleDirectGachaSelectDialog.GachaSelectViewModel gachaSelectViewModel)
			{
			}

			// Token: 0x0602B089 RID: 176265 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B089")]
			[Address(RVA = "0x26EE290", Offset = "0x26ECE90", VA = "0x1826EE290")]
			public VirtualView()
			{
			}

			// Token: 0x0403E246 RID: 254534
			[Token(Token = "0x403E246")]
			[FieldOffset(Offset = "0x20")]
			public ListDict<string, Act1VHalfIdleDirectGachaSelectDialog.GachaSelectCharViewModel> charViewModels;

			// Token: 0x0403E247 RID: 254535
			[Token(Token = "0x403E247")]
			[FieldOffset(Offset = "0x28")]
			public int startIndex;

			// Token: 0x0403E248 RID: 254536
			[Token(Token = "0x403E248")]
			[FieldOffset(Offset = "0x2C")]
			public int endIndex;

			// Token: 0x0403E249 RID: 254537
			[Token(Token = "0x403E249")]
			[FieldOffset(Offset = "0x30")]
			public Act1VHalfIdleDirectGachaSelectCharItemView prefab;

			// Token: 0x0403E24A RID: 254538
			[Token(Token = "0x403E24A")]
			[FieldOffset(Offset = "0x38")]
			public Act1VHalfIdleDirectGachaSelectDialog.GachaSelectViewModel gachaSelectViewModel;

			// Token: 0x0403E24B RID: 254539
			[Token(Token = "0x403E24B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_OnViewAttached;

			// Token: 0x0403E24C RID: 254540
			[Token(Token = "0x403E24C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnViewDetached;

			// Token: 0x0403E24D RID: 254541
			[Token(Token = "0x403E24D")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x0403E24E RID: 254542
			[Token(Token = "0x403E24E")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetPreferSize;

			// Token: 0x0403E24F RID: 254543
			[Token(Token = "0x403E24F")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_TryUpdateSelectStatus;

			// Token: 0x0403E250 RID: 254544
			[Token(Token = "0x403E250")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020077C2 RID: 30658
		[Token(Token = "0x20077C2")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x0602B08A RID: 176266 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B08A")]
			[Address(RVA = "0x26E9B30", Offset = "0x26E8730", VA = "0x1826E9B30")]
			public Adapter(Act1VHalfIdleDirectGachaSelectCharItemView closure)
			{
			}

			// Token: 0x170064C8 RID: 25800
			// (get) Token: 0x0602B08B RID: 176267 RVA: 0x000DAA78 File Offset: 0x000D8C78
			[Token(Token = "0x170064C8")]
			public override int count
			{
				[Token(Token = "0x602B08B")]
				[Address(RVA = "0x26EA0D0", Offset = "0x26E8CD0", VA = "0x1826EA0D0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602B08C RID: 176268 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602B08C")]
			[Address(RVA = "0x26E8A10", Offset = "0x26E7610", VA = "0x1826E8A10", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403E251 RID: 254545
			[Token(Token = "0x403E251")]
			[FieldOffset(Offset = "0x20")]
			private Act1VHalfIdleDirectGachaSelectCharItemView m_closure;

			// Token: 0x0403E252 RID: 254546
			[Token(Token = "0x403E252")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403E253 RID: 254547
			[Token(Token = "0x403E253")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403E254 RID: 254548
			[Token(Token = "0x403E254")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
