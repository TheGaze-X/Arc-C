using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001E22 RID: 7714
	[Token(Token = "0x2001E22")]
	[Serializable]
	public class AVGCanvasLayerHolder : IHotfixable
	{
		// Token: 0x0600BE9B RID: 48795 RVA: 0x00046698 File Offset: 0x00044898
		[Token(Token = "0x600BE9B")]
		[Address(RVA = "0x33B2E20", Offset = "0x33B1A20", VA = "0x1833B2E20")]
		private AVGCanvasLayerHolder.SceneCanvasLayerConfig _FindCanvasOrderLayerConfigInternal(AVGControllerSceneCanvas canvasName)
		{
			return default(AVGCanvasLayerHolder.SceneCanvasLayerConfig);
		}

		// Token: 0x0600BE9C RID: 48796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE9C")]
		[Address(RVA = "0x33B2980", Offset = "0x33B1580", VA = "0x1833B2980")]
		public void ShrinkSortingOrders(IList<Renderer> targets, AVGControllerSceneCanvas canvas, int inCanvasLayer = 1)
		{
		}

		// Token: 0x0600BE9D RID: 48797 RVA: 0x000466B0 File Offset: 0x000448B0
		[Token(Token = "0x600BE9D")]
		[Address(RVA = "0x33B25B0", Offset = "0x33B11B0", VA = "0x1833B25B0")]
		public int CalculateOrderOffset(AVGControllerSceneCanvas canvas, int inCanvasLayer = 1)
		{
			return 0;
		}

		// Token: 0x0600BE9E RID: 48798 RVA: 0x000466C8 File Offset: 0x000448C8
		[Token(Token = "0x600BE9E")]
		[Address(RVA = "0x33B2CD0", Offset = "0x33B18D0", VA = "0x1833B2CD0")]
		private int _CalculateNewLayer(AVGCanvasLayerHolder.SceneCanvasLayerConfig config, int inCanvasLayer)
		{
			return 0;
		}

		// Token: 0x0600BE9F RID: 48799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE9F")]
		[Address(RVA = "0x33B2D90", Offset = "0x33B1990", VA = "0x1833B2D90")]
		private void _CheckOrderLimit(AVGCanvasLayerHolder.SceneCanvasLayerConfig config, int newLayer)
		{
		}

		// Token: 0x0600BEA0 RID: 48800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEA0")]
		[Address(RVA = "0x33B2760", Offset = "0x33B1360", VA = "0x1833B2760")]
		[Inspect]
		[Group("Refresh Canvas Config")]
		public void RefreshCanvasConfig()
		{
		}

		// Token: 0x0600BEA1 RID: 48801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEA1")]
		[Address(RVA = "0x33B2F60", Offset = "0x33B1B60", VA = "0x1833B2F60")]
		public AVGCanvasLayerHolder()
		{
		}

		// Token: 0x0400BF8A RID: 49034
		[Token(Token = "0x400BF8A")]
		public const int SCENE_CANVAS_ORDERLAYER_GAP = 10;

		// Token: 0x0400BF8B RID: 49035
		[Token(Token = "0x400BF8B")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private AVGCanvasLayerHolder.SceneCanvasLayerConfig[] _configs;

		// Token: 0x0400BF8C RID: 49036
		[Token(Token = "0x400BF8C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__FindCanvasOrderLayerConfigInternal;

		// Token: 0x0400BF8D RID: 49037
		[Token(Token = "0x400BF8D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ShrinkSortingOrders;

		// Token: 0x0400BF8E RID: 49038
		[Token(Token = "0x400BF8E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CalculateOrderOffset;

		// Token: 0x0400BF8F RID: 49039
		[Token(Token = "0x400BF8F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CalculateNewLayer;

		// Token: 0x0400BF90 RID: 49040
		[Token(Token = "0x400BF90")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CheckOrderLimit;

		// Token: 0x0400BF91 RID: 49041
		[Token(Token = "0x400BF91")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RefreshCanvasConfig;

		// Token: 0x0400BF92 RID: 49042
		[Token(Token = "0x400BF92")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001E23 RID: 7715
		[Token(Token = "0x2001E23")]
		[Serializable]
		public struct SceneCanvasLayerConfig
		{
			// Token: 0x0600BEA2 RID: 48802 RVA: 0x000466E0 File Offset: 0x000448E0
			[Token(Token = "0x600BEA2")]
			[Address(RVA = "0x2114460", Offset = "0x2113060", VA = "0x182114460")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x0400BF93 RID: 49043
			[Token(Token = "0x400BF93")]
			[FieldOffset(Offset = "0x0")]
			public AVGControllerSceneCanvas name;

			// Token: 0x0400BF94 RID: 49044
			[Token(Token = "0x400BF94")]
			[FieldOffset(Offset = "0x8")]
			public Canvas canvas;

			// Token: 0x0400BF95 RID: 49045
			[Token(Token = "0x400BF95")]
			[FieldOffset(Offset = "0x10")]
			public int layerCount;

			// Token: 0x0400BF96 RID: 49046
			[Token(Token = "0x400BF96")]
			[FieldOffset(Offset = "0x14")]
			public int orderLimit;
		}
	}
}
