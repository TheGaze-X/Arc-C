using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200427D RID: 17021
	[Token(Token = "0x200427D")]
	public class SandboxV2DungeonLayerContainer : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601A390 RID: 107408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A390")]
		public AsyncDataViewHandler<TObject, TData> AsyncAttachObjectToLayer<TObject, TData>(SandboxV2DungeonLayerType layer, TObject objPrefab, int index, uint singleCost) where TObject : Component, IAsyncDataView<TData>
		{
			return null;
		}

		// Token: 0x0601A391 RID: 107409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A391")]
		[Address(RVA = "0x1317FF0", Offset = "0x1316BF0", VA = "0x181317FF0")]
		public GameObject AttachObjectToLayer(SandboxV2DungeonLayerType layer, GameObject objPrefab)
		{
			return null;
		}

		// Token: 0x0601A392 RID: 107410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A392")]
		public TObject AttachObjectToLayer<TObject>(SandboxV2DungeonLayerType layer, TObject objPrefab) where TObject : Component
		{
			return null;
		}

		// Token: 0x0601A393 RID: 107411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A393")]
		public TObject AttachObjectToLayer<TObject>(SandboxV2DungeonLayerType layer, TObject objPrefab, Vector2 pos) where TObject : Component
		{
			return null;
		}

		// Token: 0x0601A394 RID: 107412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A394")]
		[Address(RVA = "0x1318160", Offset = "0x1316D60", VA = "0x181318160")]
		public SandboxV2DungeonLayerContainer()
		{
		}

		// Token: 0x04021338 RID: 135992
		[Token(Token = "0x4021338")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<RectTransform> _layerContainers;

		// Token: 0x04021339 RID: 135993
		[Token(Token = "0x4021339")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SandboxV2DungeonController _controller;

		// Token: 0x0402133A RID: 135994
		[Token(Token = "0x402133A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_AsyncAttachObjectToLayer;

		// Token: 0x0402133B RID: 135995
		[Token(Token = "0x402133B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_AttachObjectToLayer;

		// Token: 0x0402133C RID: 135996
		[Token(Token = "0x402133C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix1_AttachObjectToLayer;

		// Token: 0x0402133D RID: 135997
		[Token(Token = "0x402133D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix2_AttachObjectToLayer;

		// Token: 0x0402133E RID: 135998
		[Token(Token = "0x402133E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
