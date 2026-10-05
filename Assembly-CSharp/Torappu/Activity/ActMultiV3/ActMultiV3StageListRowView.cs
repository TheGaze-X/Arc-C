using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006FFE RID: 28670
	[Token(Token = "0x2006FFE")]
	public class ActMultiV3StageListRowView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06028B3D RID: 166717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B3D")]
		[Address(RVA = "0x24110E0", Offset = "0x240FCE0", VA = "0x1824110E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06028B3E RID: 166718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B3E")]
		[Address(RVA = "0x2410FE0", Offset = "0x240FBE0", VA = "0x182410FE0")]
		public void Render(ActMultiV3StageListView.VirtualView data)
		{
		}

		// Token: 0x06028B3F RID: 166719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B3F")]
		[Address(RVA = "0x24112B0", Offset = "0x240FEB0", VA = "0x1824112B0")]
		public ActMultiV3StageListRowView()
		{
		}

		// Token: 0x0403A03E RID: 237630
		[Token(Token = "0x403A03E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _titleLayout;

		// Token: 0x0403A03F RID: 237631
		[Token(Token = "0x403A03F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _pnlTitle;

		// Token: 0x0403A040 RID: 237632
		[Token(Token = "0x403A040")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _stageLayout;

		// Token: 0x0403A041 RID: 237633
		[Token(Token = "0x403A041")]
		[FieldOffset(Offset = "0x30")]
		private ActMultiV3StageListView.VirtualView m_cachedData;

		// Token: 0x0403A042 RID: 237634
		[Token(Token = "0x403A042")]
		[FieldOffset(Offset = "0x38")]
		private bool m_inited;

		// Token: 0x0403A043 RID: 237635
		[Token(Token = "0x403A043")]
		[FieldOffset(Offset = "0x40")]
		private ActMultiV3StageListRowView.Adapter m_titleAdapter;

		// Token: 0x0403A044 RID: 237636
		[Token(Token = "0x403A044")]
		[FieldOffset(Offset = "0x48")]
		private ActMultiV3StageListRowView.StageAdapter m_stageAdapter;

		// Token: 0x0403A045 RID: 237637
		[Token(Token = "0x403A045")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403A046 RID: 237638
		[Token(Token = "0x403A046")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403A047 RID: 237639
		[Token(Token = "0x403A047")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006FFF RID: 28671
		[Token(Token = "0x2006FFF")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x06028B40 RID: 166720 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028B40")]
			[Address(RVA = "0x2418CC0", Offset = "0x24178C0", VA = "0x182418CC0")]
			public Adapter(ActMultiV3StageListRowView closure)
			{
			}

			// Token: 0x1700601B RID: 24603
			// (get) Token: 0x06028B41 RID: 166721 RVA: 0x000D2B40 File Offset: 0x000D0D40
			[Token(Token = "0x1700601B")]
			public override int count
			{
				[Token(Token = "0x6028B41")]
				[Address(RVA = "0x2418D40", Offset = "0x2417940", VA = "0x182418D40", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06028B42 RID: 166722 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6028B42")]
			[Address(RVA = "0x2418540", Offset = "0x2417140", VA = "0x182418540", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403A048 RID: 237640
			[Token(Token = "0x403A048")]
			[FieldOffset(Offset = "0x20")]
			private ActMultiV3StageListRowView m_closure;

			// Token: 0x0403A049 RID: 237641
			[Token(Token = "0x403A049")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403A04A RID: 237642
			[Token(Token = "0x403A04A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403A04B RID: 237643
			[Token(Token = "0x403A04B")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x02007000 RID: 28672
		[Token(Token = "0x2007000")]
		private class StageAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06028B43 RID: 166723 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028B43")]
			[Address(RVA = "0x2419A80", Offset = "0x2418680", VA = "0x182419A80")]
			public StageAdapter(ActMultiV3StageListRowView closure)
			{
			}

			// Token: 0x1700601C RID: 24604
			// (get) Token: 0x06028B44 RID: 166724 RVA: 0x000D2B58 File Offset: 0x000D0D58
			[Token(Token = "0x1700601C")]
			public override int count
			{
				[Token(Token = "0x6028B44")]
				[Address(RVA = "0x2419B00", Offset = "0x2418700", VA = "0x182419B00", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06028B45 RID: 166725 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6028B45")]
			[Address(RVA = "0x2419890", Offset = "0x2418490", VA = "0x182419890", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403A04C RID: 237644
			[Token(Token = "0x403A04C")]
			[FieldOffset(Offset = "0x20")]
			private ActMultiV3StageListRowView m_closure;

			// Token: 0x0403A04D RID: 237645
			[Token(Token = "0x403A04D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403A04E RID: 237646
			[Token(Token = "0x403A04E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403A04F RID: 237647
			[Token(Token = "0x403A04F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
