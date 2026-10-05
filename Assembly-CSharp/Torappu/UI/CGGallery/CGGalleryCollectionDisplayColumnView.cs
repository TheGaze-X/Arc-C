using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CGGallery
{
	// Token: 0x02005FF4 RID: 24564
	[Token(Token = "0x2005FF4")]
	public class CGGalleryCollectionDisplayColumnView : CGGalleryCollectionDisplayVirtualView<CGGalleryCollectionDisplayGroupView.DisplayColumnVirtualModel>
	{
		// Token: 0x0602381C RID: 145436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602381C")]
		[Address(RVA = "0x1E143A0", Offset = "0x1E12FA0", VA = "0x181E143A0", Slot = "4")]
		public override string GetViewType()
		{
			return null;
		}

		// Token: 0x0602381D RID: 145437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602381D")]
		[Address(RVA = "0x1E14410", Offset = "0x1E13010", VA = "0x181E14410", Slot = "12")]
		protected override void RenderData(CGGalleryCollectionDisplayGroupView.DisplayColumnVirtualModel model, CGGalleryFilterMode filterMode)
		{
		}

		// Token: 0x0602381E RID: 145438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602381E")]
		[Address(RVA = "0x1E14780", Offset = "0x1E13380", VA = "0x181E14780")]
		private CGGalleryCollectionDisplayColumnView.ItemAdapter _EnsureAdapter()
		{
			return null;
		}

		// Token: 0x0602381F RID: 145439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602381F")]
		[Address(RVA = "0x1E148C0", Offset = "0x1E134C0", VA = "0x181E148C0")]
		private CGGalleryCollectionDisplayColumnView.ItemAdapter _EnsureReflectionAdapter()
		{
			return null;
		}

		// Token: 0x06023820 RID: 145440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023820")]
		[Address(RVA = "0x1E14A00", Offset = "0x1E13600", VA = "0x181E14A00")]
		public CGGalleryCollectionDisplayColumnView()
		{
		}

		// Token: 0x040311EA RID: 201194
		[Token(Token = "0x40311EA")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SimpleLayoutContent _itemContent;

		// Token: 0x040311EB RID: 201195
		[Token(Token = "0x40311EB")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Vector2 _itemSize;

		// Token: 0x040311EC RID: 201196
		[Token(Token = "0x40311EC")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private SimpleLayoutContent _reflectionContent;

		// Token: 0x040311ED RID: 201197
		[Token(Token = "0x40311ED")]
		[FieldOffset(Offset = "0x68")]
		private CGGalleryCollectionDisplayColumnView.ItemAdapter m_adapter;

		// Token: 0x040311EE RID: 201198
		[Token(Token = "0x40311EE")]
		[FieldOffset(Offset = "0x70")]
		private CGGalleryCollectionDisplayColumnView.ItemAdapter m_reflectionAdapter;

		// Token: 0x040311EF RID: 201199
		[Token(Token = "0x40311EF")]
		[FieldOffset(Offset = "0x78")]
		private CGGalleryCollectionDisplayItemView m_reflectionInstance;

		// Token: 0x040311F0 RID: 201200
		[Token(Token = "0x40311F0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetViewType;

		// Token: 0x040311F1 RID: 201201
		[Token(Token = "0x40311F1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderData;

		// Token: 0x040311F2 RID: 201202
		[Token(Token = "0x40311F2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__EnsureAdapter;

		// Token: 0x040311F3 RID: 201203
		[Token(Token = "0x40311F3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__EnsureReflectionAdapter;

		// Token: 0x040311F4 RID: 201204
		[Token(Token = "0x40311F4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005FF5 RID: 24565
		[Token(Token = "0x2005FF5")]
		private class ItemAdapter : SimpleLayoutAdapter
		{
			// Token: 0x170053E3 RID: 21475
			// (get) Token: 0x06023821 RID: 145441 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06023822 RID: 145442 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170053E3")]
			public List<CGGalleryDisplayViewModel> displays
			{
				[Token(Token = "0x6023821")]
				[Address(RVA = "0x1E257B0", Offset = "0x1E243B0", VA = "0x181E257B0")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x6023822")]
				[Address(RVA = "0x1E258E0", Offset = "0x1E244E0", VA = "0x181E258E0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x170053E4 RID: 21476
			// (get) Token: 0x06023823 RID: 145443 RVA: 0x000C1200 File Offset: 0x000BF400
			// (set) Token: 0x06023824 RID: 145444 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170053E4")]
			public CGGalleryFilterMode filterMode
			{
				[Token(Token = "0x6023823")]
				[Address(RVA = "0x1E25810", Offset = "0x1E24410", VA = "0x181E25810")]
				[CompilerGenerated]
				private get
				{
					return CGGalleryFilterMode.NONE;
				}
				[Token(Token = "0x6023824")]
				[Address(RVA = "0x1E25960", Offset = "0x1E24560", VA = "0x181E25960")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x170053E5 RID: 21477
			// (get) Token: 0x06023825 RID: 145445 RVA: 0x000C1218 File Offset: 0x000BF418
			// (set) Token: 0x06023826 RID: 145446 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170053E5")]
			public Vector2 itemSize
			{
				[Token(Token = "0x6023825")]
				[Address(RVA = "0x1E25870", Offset = "0x1E24470", VA = "0x181E25870")]
				[CompilerGenerated]
				private get
				{
					return default(Vector2);
				}
				[Token(Token = "0x6023826")]
				[Address(RVA = "0x1E259D0", Offset = "0x1E245D0", VA = "0x181E259D0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x170053E6 RID: 21478
			// (get) Token: 0x06023827 RID: 145447 RVA: 0x000C1230 File Offset: 0x000BF430
			[Token(Token = "0x170053E6")]
			public override int count
			{
				[Token(Token = "0x6023827")]
				[Address(RVA = "0x1E25700", Offset = "0x1E24300", VA = "0x181E25700", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06023828 RID: 145448 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6023828")]
			[Address(RVA = "0x1E253C0", Offset = "0x1E23FC0", VA = "0x181E253C0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06023829 RID: 145449 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023829")]
			[Address(RVA = "0x1E256A0", Offset = "0x1E242A0", VA = "0x181E256A0")]
			public ItemAdapter()
			{
			}

			// Token: 0x040311F8 RID: 201208
			[Token(Token = "0x40311F8")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_displays;

			// Token: 0x040311F9 RID: 201209
			[Token(Token = "0x40311F9")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_displays;

			// Token: 0x040311FA RID: 201210
			[Token(Token = "0x40311FA")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_filterMode;

			// Token: 0x040311FB RID: 201211
			[Token(Token = "0x40311FB")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_filterMode;

			// Token: 0x040311FC RID: 201212
			[Token(Token = "0x40311FC")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_itemSize;

			// Token: 0x040311FD RID: 201213
			[Token(Token = "0x40311FD")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_set_itemSize;

			// Token: 0x040311FE RID: 201214
			[Token(Token = "0x40311FE")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040311FF RID: 201215
			[Token(Token = "0x40311FF")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04031200 RID: 201216
			[Token(Token = "0x4031200")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
