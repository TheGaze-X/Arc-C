using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CGGallery
{
	// Token: 0x02005FFF RID: 24575
	[Token(Token = "0x2005FFF")]
	public class CGGalleryCollectionDisplayHeadView : CGGalleryCollectionDisplayVirtualView<CGGalleryCollectionDisplayGroupView.DisplayHeadVirtualModel>
	{
		// Token: 0x06023851 RID: 145489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023851")]
		[Address(RVA = "0x1E29D50", Offset = "0x1E28950", VA = "0x181E29D50", Slot = "4")]
		public override string GetViewType()
		{
			return null;
		}

		// Token: 0x06023852 RID: 145490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023852")]
		[Address(RVA = "0x1E29DC0", Offset = "0x1E289C0", VA = "0x181E29DC0", Slot = "12")]
		protected override void RenderData(CGGalleryCollectionDisplayGroupView.DisplayHeadVirtualModel model, CGGalleryFilterMode filterMode)
		{
		}

		// Token: 0x06023853 RID: 145491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023853")]
		[Address(RVA = "0x1E29F80", Offset = "0x1E28B80", VA = "0x181E29F80")]
		public CGGalleryCollectionDisplayHeadView()
		{
		}

		// Token: 0x0403124C RID: 201292
		[Token(Token = "0x403124C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform _itemContainer;

		// Token: 0x0403124D RID: 201293
		[Token(Token = "0x403124D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CGGalleryCollectionDisplayItemView _itemPrefab;

		// Token: 0x0403124E RID: 201294
		[Token(Token = "0x403124E")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform _reflectionContainer;

		// Token: 0x0403124F RID: 201295
		[Token(Token = "0x403124F")]
		[FieldOffset(Offset = "0x68")]
		private CGGalleryCollectionDisplayItemView m_itemInstance;

		// Token: 0x04031250 RID: 201296
		[Token(Token = "0x4031250")]
		[FieldOffset(Offset = "0x70")]
		private CGGalleryCollectionDisplayItemView m_reflectionInstance;

		// Token: 0x04031251 RID: 201297
		[Token(Token = "0x4031251")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetViewType;

		// Token: 0x04031252 RID: 201298
		[Token(Token = "0x4031252")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderData;

		// Token: 0x04031253 RID: 201299
		[Token(Token = "0x4031253")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
