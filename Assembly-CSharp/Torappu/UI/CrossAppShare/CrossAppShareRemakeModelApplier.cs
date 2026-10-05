using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CrossAppShare
{
	// Token: 0x020058F3 RID: 22771
	[Token(Token = "0x20058F3")]
	public abstract class CrossAppShareRemakeModelApplier : MonoBehaviour, IHotfixable
	{
		// Token: 0x06021328 RID: 135976
		[Token(Token = "0x6021328")]
		public abstract void ApplyComponentModels(ICrossAppShareModelCollector modelCollector, ILoadAsset iLoadAsset);

		// Token: 0x06021329 RID: 135977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021329")]
		[Address(RVA = "0x1B781A0", Offset = "0x1B76DA0", VA = "0x181B781A0")]
		protected void _ApplyObjectActive(CrossAppShareObjectActiveModel objectActiveModel, GameObject objectActive)
		{
		}

		// Token: 0x0602132A RID: 135978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602132A")]
		[Address(RVA = "0x1B77F40", Offset = "0x1B76B40", VA = "0x181B77F40")]
		protected void _ApplyImage(CrossAppShareImageModel imageModel, Image image)
		{
		}

		// Token: 0x0602132B RID: 135979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602132B")]
		[Address(RVA = "0x1B784B0", Offset = "0x1B770B0", VA = "0x181B784B0")]
		protected void _ApplyUIAtlasImage(CrossAppShareUIAtlasImageModel uiAtlasImageModel, UIAtlasImage uiAtlasImage)
		{
		}

		// Token: 0x0602132C RID: 135980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602132C")]
		[Address(RVA = "0x1B78370", Offset = "0x1B76F70", VA = "0x181B78370")]
		protected void _ApplyText(CrossAppShareTextModel textModel, Text text)
		{
		}

		// Token: 0x0602132D RID: 135981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602132D")]
		[Address(RVA = "0x1B78270", Offset = "0x1B76E70", VA = "0x181B78270")]
		protected void _ApplyScrollRect(CrossAppShareScrollRectModel scrollRectModel, ScrollRect scrollRect)
		{
		}

		// Token: 0x0602132E RID: 135982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602132E")]
		[Address(RVA = "0x1B780A0", Offset = "0x1B76CA0", VA = "0x181B780A0")]
		protected void _ApplyLayoutContent(CrossAppShareLayoutContentModel layoutContentModel, CrossAppShareRemakeLayoutContent layoutContent, ILoadAsset iLoadAsset)
		{
		}

		// Token: 0x0602132F RID: 135983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602132F")]
		[Address(RVA = "0x1B77E40", Offset = "0x1B76A40", VA = "0x181B77E40")]
		protected void _ApplyDynAsset(CrossAppShareDynAssetBaseModel dynAssetModel, CrossAppShareRemakeDynAssetContent dynAssetContent, ILoadAsset iLoadAsset)
		{
		}

		// Token: 0x06021330 RID: 135984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021330")]
		[Address(RVA = "0x1B78610", Offset = "0x1B77210", VA = "0x181B78610")]
		protected CrossAppShareRemakeModelApplier()
		{
		}

		// Token: 0x0402D384 RID: 185220
		[Token(Token = "0x402D384")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__ApplyObjectActive;

		// Token: 0x0402D385 RID: 185221
		[Token(Token = "0x402D385")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__ApplyImage;

		// Token: 0x0402D386 RID: 185222
		[Token(Token = "0x402D386")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ApplyUIAtlasImage;

		// Token: 0x0402D387 RID: 185223
		[Token(Token = "0x402D387")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ApplyText;

		// Token: 0x0402D388 RID: 185224
		[Token(Token = "0x402D388")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ApplyScrollRect;

		// Token: 0x0402D389 RID: 185225
		[Token(Token = "0x402D389")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ApplyLayoutContent;

		// Token: 0x0402D38A RID: 185226
		[Token(Token = "0x402D38A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ApplyDynAsset;

		// Token: 0x0402D38B RID: 185227
		[Token(Token = "0x402D38B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
