using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.UIElements.UIR.Implementation;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x020002A8 RID: 680
	[Token(Token = "0x20002A8")]
	internal struct RenderChainVEData
	{
		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x060012AF RID: 4783 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x170004A5")]
		internal RenderChainCommand lastClosingOrLastCommand
		{
			[Token(Token = "0x60012AF")]
			[Address(RVA = "0x5B3D530", Offset = "0x5B3C130", VA = "0x185B3D530")]
			get
			{
				return null;
			}
		}

		// Token: 0x060012B0 RID: 4784 RVA: 0x00009E10 File Offset: 0x00008010
		[Token(Token = "0x60012B0")]
		[Address(RVA = "0x5B3D470", Offset = "0x5B3C070", VA = "0x185B3D470")]
		internal static bool AllocatesID(BMPAlloc alloc)
		{
			return default(bool);
		}

		// Token: 0x060012B1 RID: 4785 RVA: 0x00009E28 File Offset: 0x00008028
		[Token(Token = "0x60012B1")]
		[Address(RVA = "0x5B3D4D0", Offset = "0x5B3C0D0", VA = "0x185B3D4D0")]
		internal static bool InheritsID(BMPAlloc alloc)
		{
			return default(bool);
		}

		// Token: 0x04000A1B RID: 2587
		[Token(Token = "0x4000A1B")]
		[FieldOffset(Offset = "0x0")]
		internal VisualElement prev;

		// Token: 0x04000A1C RID: 2588
		[Token(Token = "0x4000A1C")]
		[FieldOffset(Offset = "0x8")]
		internal VisualElement next;

		// Token: 0x04000A1D RID: 2589
		[Token(Token = "0x4000A1D")]
		[FieldOffset(Offset = "0x10")]
		internal VisualElement groupTransformAncestor;

		// Token: 0x04000A1E RID: 2590
		[Token(Token = "0x4000A1E")]
		[FieldOffset(Offset = "0x18")]
		internal VisualElement boneTransformAncestor;

		// Token: 0x04000A1F RID: 2591
		[Token(Token = "0x4000A1F")]
		[FieldOffset(Offset = "0x20")]
		internal VisualElement prevDirty;

		// Token: 0x04000A20 RID: 2592
		[Token(Token = "0x4000A20")]
		[FieldOffset(Offset = "0x28")]
		internal VisualElement nextDirty;

		// Token: 0x04000A21 RID: 2593
		[Token(Token = "0x4000A21")]
		[FieldOffset(Offset = "0x30")]
		internal int hierarchyDepth;

		// Token: 0x04000A22 RID: 2594
		[Token(Token = "0x4000A22")]
		[FieldOffset(Offset = "0x34")]
		internal RenderDataDirtyTypes dirtiedValues;

		// Token: 0x04000A23 RID: 2595
		[Token(Token = "0x4000A23")]
		[FieldOffset(Offset = "0x38")]
		internal uint dirtyID;

		// Token: 0x04000A24 RID: 2596
		[Token(Token = "0x4000A24")]
		[FieldOffset(Offset = "0x40")]
		internal RenderChainCommand firstCommand;

		// Token: 0x04000A25 RID: 2597
		[Token(Token = "0x4000A25")]
		[FieldOffset(Offset = "0x48")]
		internal RenderChainCommand lastCommand;

		// Token: 0x04000A26 RID: 2598
		[Token(Token = "0x4000A26")]
		[FieldOffset(Offset = "0x50")]
		internal RenderChainCommand firstClosingCommand;

		// Token: 0x04000A27 RID: 2599
		[Token(Token = "0x4000A27")]
		[FieldOffset(Offset = "0x58")]
		internal RenderChainCommand lastClosingCommand;

		// Token: 0x04000A28 RID: 2600
		[Token(Token = "0x4000A28")]
		[FieldOffset(Offset = "0x60")]
		internal bool isInChain;

		// Token: 0x04000A29 RID: 2601
		[Token(Token = "0x4000A29")]
		[FieldOffset(Offset = "0x61")]
		internal bool isHierarchyHidden;

		// Token: 0x04000A2A RID: 2602
		[Token(Token = "0x4000A2A")]
		[FieldOffset(Offset = "0x62")]
		internal bool localFlipsWinding;

		// Token: 0x04000A2B RID: 2603
		[Token(Token = "0x4000A2B")]
		[FieldOffset(Offset = "0x63")]
		internal bool localTransformScaleZero;

		// Token: 0x04000A2C RID: 2604
		[Token(Token = "0x4000A2C")]
		[FieldOffset(Offset = "0x64")]
		internal bool worldFlipsWinding;

		// Token: 0x04000A2D RID: 2605
		[Token(Token = "0x4000A2D")]
		[FieldOffset(Offset = "0x68")]
		internal ClipMethod clipMethod;

		// Token: 0x04000A2E RID: 2606
		[Token(Token = "0x4000A2E")]
		[FieldOffset(Offset = "0x6C")]
		internal int childrenStencilRef;

		// Token: 0x04000A2F RID: 2607
		[Token(Token = "0x4000A2F")]
		[FieldOffset(Offset = "0x70")]
		internal int childrenMaskDepth;

		// Token: 0x04000A30 RID: 2608
		[Token(Token = "0x4000A30")]
		[FieldOffset(Offset = "0x74")]
		internal bool disableNudging;

		// Token: 0x04000A31 RID: 2609
		[Token(Token = "0x4000A31")]
		[FieldOffset(Offset = "0x75")]
		internal bool usesLegacyText;

		// Token: 0x04000A32 RID: 2610
		[Token(Token = "0x4000A32")]
		[FieldOffset(Offset = "0x78")]
		internal MeshHandle data;

		// Token: 0x04000A33 RID: 2611
		[Token(Token = "0x4000A33")]
		[FieldOffset(Offset = "0x80")]
		internal MeshHandle closingData;

		// Token: 0x04000A34 RID: 2612
		[Token(Token = "0x4000A34")]
		[FieldOffset(Offset = "0x88")]
		internal Matrix4x4 verticesSpace;

		// Token: 0x04000A35 RID: 2613
		[Token(Token = "0x4000A35")]
		[FieldOffset(Offset = "0xC8")]
		internal int displacementUVStart;

		// Token: 0x04000A36 RID: 2614
		[Token(Token = "0x4000A36")]
		[FieldOffset(Offset = "0xCC")]
		internal int displacementUVEnd;

		// Token: 0x04000A37 RID: 2615
		[Token(Token = "0x4000A37")]
		[FieldOffset(Offset = "0xD0")]
		internal BMPAlloc transformID;

		// Token: 0x04000A38 RID: 2616
		[Token(Token = "0x4000A38")]
		[FieldOffset(Offset = "0xD8")]
		internal BMPAlloc clipRectID;

		// Token: 0x04000A39 RID: 2617
		[Token(Token = "0x4000A39")]
		[FieldOffset(Offset = "0xE0")]
		internal BMPAlloc opacityID;

		// Token: 0x04000A3A RID: 2618
		[Token(Token = "0x4000A3A")]
		[FieldOffset(Offset = "0xE8")]
		internal BMPAlloc textCoreSettingsID;

		// Token: 0x04000A3B RID: 2619
		[Token(Token = "0x4000A3B")]
		[FieldOffset(Offset = "0xF0")]
		internal BMPAlloc backgroundColorID;

		// Token: 0x04000A3C RID: 2620
		[Token(Token = "0x4000A3C")]
		[FieldOffset(Offset = "0xF8")]
		internal BMPAlloc borderLeftColorID;

		// Token: 0x04000A3D RID: 2621
		[Token(Token = "0x4000A3D")]
		[FieldOffset(Offset = "0x100")]
		internal BMPAlloc borderTopColorID;

		// Token: 0x04000A3E RID: 2622
		[Token(Token = "0x4000A3E")]
		[FieldOffset(Offset = "0x108")]
		internal BMPAlloc borderRightColorID;

		// Token: 0x04000A3F RID: 2623
		[Token(Token = "0x4000A3F")]
		[FieldOffset(Offset = "0x110")]
		internal BMPAlloc borderBottomColorID;

		// Token: 0x04000A40 RID: 2624
		[Token(Token = "0x4000A40")]
		[FieldOffset(Offset = "0x118")]
		internal BMPAlloc tintColorID;

		// Token: 0x04000A41 RID: 2625
		[Token(Token = "0x4000A41")]
		[FieldOffset(Offset = "0x120")]
		internal float compositeOpacity;

		// Token: 0x04000A42 RID: 2626
		[Token(Token = "0x4000A42")]
		[FieldOffset(Offset = "0x124")]
		internal Color backgroundColor;

		// Token: 0x04000A43 RID: 2627
		[Token(Token = "0x4000A43")]
		[FieldOffset(Offset = "0x138")]
		internal VisualElement prevText;

		// Token: 0x04000A44 RID: 2628
		[Token(Token = "0x4000A44")]
		[FieldOffset(Offset = "0x140")]
		internal VisualElement nextText;

		// Token: 0x04000A45 RID: 2629
		[Token(Token = "0x4000A45")]
		[FieldOffset(Offset = "0x148")]
		internal List<RenderChainTextEntry> textEntries;

		// Token: 0x04000A46 RID: 2630
		[Token(Token = "0x4000A46")]
		[FieldOffset(Offset = "0x150")]
		internal BasicNode<TextureEntry> textures;
	}
}
