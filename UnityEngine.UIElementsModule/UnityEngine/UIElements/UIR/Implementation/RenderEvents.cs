using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.UIR.Implementation
{
	// Token: 0x020002DB RID: 731
	[Token(Token = "0x20002DB")]
	internal static class RenderEvents
	{
		// Token: 0x060013BD RID: 5053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013BD")]
		[Address(RVA = "0x5A6D880", Offset = "0x5A6C480", VA = "0x185A6D880")]
		internal static void ProcessOnClippingChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, ref ChainBuilderStats stats)
		{
		}

		// Token: 0x060013BE RID: 5054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013BE")]
		[Address(RVA = "0x5A6DB60", Offset = "0x5A6C760", VA = "0x185A6DB60")]
		internal static void ProcessOnOpacityChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, ref ChainBuilderStats stats)
		{
		}

		// Token: 0x060013BF RID: 5055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013BF")]
		[Address(RVA = "0x5A6D9A0", Offset = "0x5A6C5A0", VA = "0x185A6D9A0")]
		internal static void ProcessOnColorChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, ref ChainBuilderStats stats)
		{
		}

		// Token: 0x060013C0 RID: 5056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013C0")]
		[Address(RVA = "0x5A6DC70", Offset = "0x5A6C870", VA = "0x185A6DC70")]
		internal static void ProcessOnTransformOrSizeChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, ref ChainBuilderStats stats)
		{
		}

		// Token: 0x060013C1 RID: 5057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013C1")]
		[Address(RVA = "0x5A6DD50", Offset = "0x5A6C950", VA = "0x185A6DD50")]
		internal static void ProcessOnVisualsChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, ref ChainBuilderStats stats)
		{
		}

		// Token: 0x060013C2 RID: 5058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013C2")]
		[Address(RVA = "0x5A6DEA0", Offset = "0x5A6CAA0", VA = "0x185A6DEA0")]
		internal static void ProcessRegenText(RenderChain renderChain, VisualElement ve, UIRTextUpdatePainter painter, UIRenderDevice device, ref ChainBuilderStats stats)
		{
		}

		// Token: 0x060013C3 RID: 5059 RVA: 0x0000A458 File Offset: 0x00008658
		[Token(Token = "0x60013C3")]
		[Address(RVA = "0x5A6D010", Offset = "0x5A6BC10", VA = "0x185A6D010")]
		private static Matrix4x4 GetTransformIDTransformInfo(VisualElement ve)
		{
			return default(Matrix4x4);
		}

		// Token: 0x060013C4 RID: 5060 RVA: 0x0000A470 File Offset: 0x00008670
		[Token(Token = "0x60013C4")]
		[Address(RVA = "0x5A6CD40", Offset = "0x5A6B940", VA = "0x185A6CD40")]
		private static Vector4 GetClipRectIDClipInfo(VisualElement ve)
		{
			return default(Vector4);
		}

		// Token: 0x060013C5 RID: 5061 RVA: 0x0000A488 File Offset: 0x00008688
		[Token(Token = "0x60013C5")]
		[Address(RVA = "0x5A6A9A0", Offset = "0x5A695A0", VA = "0x185A6A9A0")]
		internal static uint DepthFirstOnChildAdded(RenderChain renderChain, VisualElement parent, VisualElement ve, int index, bool resetState)
		{
			return 0U;
		}

		// Token: 0x060013C6 RID: 5062 RVA: 0x0000A4A0 File Offset: 0x000086A0
		[Token(Token = "0x60013C6")]
		[Address(RVA = "0x5A6B140", Offset = "0x5A69D40", VA = "0x185A6B140")]
		internal static uint DepthFirstOnChildRemoving(RenderChain renderChain, VisualElement ve)
		{
			return 0U;
		}

		// Token: 0x060013C7 RID: 5063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013C7")]
		[Address(RVA = "0x5A6B7B0", Offset = "0x5A6A3B0", VA = "0x185A6B7B0")]
		private static void DepthFirstOnClippingChanged(RenderChain renderChain, VisualElement parent, VisualElement ve, uint dirtyID, bool hierarchical, bool isRootOfChange, bool isPendingHierarchicalRepaint, bool inheritedClipRectIDChanged, bool inheritedMaskingChanged, UIRenderDevice device, ref ChainBuilderStats stats)
		{
		}

		// Token: 0x060013C8 RID: 5064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013C8")]
		[Address(RVA = "0x5A6BE40", Offset = "0x5A6AA40", VA = "0x185A6BE40")]
		private static void DepthFirstOnOpacityChanged(RenderChain renderChain, float parentCompositeOpacity, VisualElement ve, uint dirtyID, bool hierarchical, ref ChainBuilderStats stats, bool isDoingFullVertexRegeneration = false)
		{
		}

		// Token: 0x060013C9 RID: 5065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013C9")]
		[Address(RVA = "0x5A6D6F0", Offset = "0x5A6C2F0", VA = "0x185A6D6F0")]
		private static void OnColorChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, ref ChainBuilderStats stats)
		{
		}

		// Token: 0x060013CA RID: 5066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013CA")]
		[Address(RVA = "0x5A6C270", Offset = "0x5A6AE70", VA = "0x185A6C270")]
		private static void DepthFirstOnTransformOrSizeChanged(RenderChain renderChain, VisualElement parent, VisualElement ve, uint dirtyID, UIRenderDevice device, bool isAncestorOfChangeSkinned, bool transformChanged, ref ChainBuilderStats stats)
		{
		}

		// Token: 0x060013CB RID: 5067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013CB")]
		[Address(RVA = "0x5A6C7D0", Offset = "0x5A6B3D0", VA = "0x185A6C7D0")]
		private static void DepthFirstOnVisualsChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, bool parentHierarchyHidden, bool hierarchical, ref ChainBuilderStats stats)
		{
		}

		// Token: 0x060013CC RID: 5068 RVA: 0x0000A4B8 File Offset: 0x000086B8
		[Token(Token = "0x60013CC")]
		[Address(RVA = "0x5A6E4D0", Offset = "0x5A6D0D0", VA = "0x185A6E4D0")]
		private static bool UpdateTextCoreSettings(RenderChain renderChain, VisualElement ve)
		{
			return default(bool);
		}

		// Token: 0x060013CD RID: 5069 RVA: 0x0000A4D0 File Offset: 0x000086D0
		[Token(Token = "0x60013CD")]
		[Address(RVA = "0x5A6D630", Offset = "0x5A6C230", VA = "0x185A6D630")]
		private static bool IsElementHierarchyHidden(VisualElement ve)
		{
			return default(bool);
		}

		// Token: 0x060013CE RID: 5070 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60013CE")]
		[Address(RVA = "0x5A6CF90", Offset = "0x5A6BB90", VA = "0x185A6CF90")]
		private static VisualElement GetLastDeepestChild(VisualElement ve)
		{
			return null;
		}

		// Token: 0x060013CF RID: 5071 RVA: 0x0000A4E8 File Offset: 0x000086E8
		[Token(Token = "0x60013CF")]
		[Address(RVA = "0x5A6CC20", Offset = "0x5A6B820", VA = "0x185A6CC20")]
		private static ClipMethod DetermineSelfClipMethod(RenderChain renderChain, VisualElement ve)
		{
			return ClipMethod.Undetermined;
		}

		// Token: 0x060013D0 RID: 5072 RVA: 0x0000A500 File Offset: 0x00008700
		[Token(Token = "0x60013D0")]
		[Address(RVA = "0x5A6E3E0", Offset = "0x5A6CFE0", VA = "0x185A6E3E0")]
		private static bool UpdateLocalFlipsWinding(VisualElement ve)
		{
			return default(bool);
		}

		// Token: 0x060013D1 RID: 5073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013D1")]
		[Address(RVA = "0x5A6E950", Offset = "0x5A6D550", VA = "0x185A6E950")]
		private static void UpdateWorldFlipsWinding(VisualElement ve)
		{
		}

		// Token: 0x060013D2 RID: 5074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013D2")]
		[Address(RVA = "0x5A6E9C0", Offset = "0x5A6D5C0", VA = "0x185A6E9C0")]
		private static void UpdateZeroScaling(VisualElement ve)
		{
		}

		// Token: 0x060013D3 RID: 5075 RVA: 0x0000A518 File Offset: 0x00008718
		[Token(Token = "0x60013D3")]
		[Address(RVA = "0x5A6D6B0", Offset = "0x5A6C2B0", VA = "0x185A6D6B0")]
		private static bool NeedsTransformID(VisualElement ve)
		{
			return default(bool);
		}

		// Token: 0x060013D4 RID: 5076 RVA: 0x0000A530 File Offset: 0x00008730
		[Token(Token = "0x60013D4")]
		[Address(RVA = "0x5A6D690", Offset = "0x5A6C290", VA = "0x185A6D690")]
		internal static bool NeedsColorID(VisualElement ve)
		{
			return default(bool);
		}

		// Token: 0x060013D5 RID: 5077 RVA: 0x0000A548 File Offset: 0x00008748
		[Token(Token = "0x60013D5")]
		[Address(RVA = "0x5A6D1B0", Offset = "0x5A6BDB0", VA = "0x185A6D1B0")]
		private static bool InitColorIDs(RenderChain renderChain, VisualElement ve)
		{
			return default(bool);
		}

		// Token: 0x060013D6 RID: 5078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013D6")]
		[Address(RVA = "0x5A6DF80", Offset = "0x5A6CB80", VA = "0x185A6DF80")]
		private static void SetColorValues(RenderChain renderChain, VisualElement ve)
		{
		}

		// Token: 0x04000B7E RID: 2942
		[Token(Token = "0x4000B7E")]
		[FieldOffset(Offset = "0x0")]
		private static readonly float VisibilityTreshold;
	}
}
