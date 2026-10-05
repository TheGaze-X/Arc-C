using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Collections;

namespace UnityEngine.UIElements.UIR.Implementation
{
	// Token: 0x020002DC RID: 732
	[Token(Token = "0x20002DC")]
	internal class UIRStylePainter : IStylePainter, IDisposable
	{
		// Token: 0x060013D8 RID: 5080 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60013D8")]
		[Address(RVA = "0x5A77F00", Offset = "0x5A76B00", VA = "0x185A77F00")]
		private MeshWriteData GetPooledMeshWriteData()
		{
			return null;
		}

		// Token: 0x060013D9 RID: 5081 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60013D9")]
		[Address(RVA = "0x5A72110", Offset = "0x5A70D10", VA = "0x185A72110")]
		private MeshWriteData AllocRawVertsIndices(uint vertexCount, uint indexCount, ref MeshBuilder.AllocMeshData allocatorData)
		{
			return null;
		}

		// Token: 0x060013DA RID: 5082 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60013DA")]
		[Address(RVA = "0x5A72220", Offset = "0x5A70E20", VA = "0x185A72220")]
		private MeshWriteData AllocThroughDrawMesh(uint vertexCount, uint indexCount, ref MeshBuilder.AllocMeshData allocatorData)
		{
			return null;
		}

		// Token: 0x060013DB RID: 5083 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60013DB")]
		[Address(RVA = "0x5A721F0", Offset = "0x5A70DF0", VA = "0x185A721F0")]
		private MeshWriteData AllocThroughDrawGradients(uint vertexCount, uint indexCount, ref MeshBuilder.AllocMeshData allocatorData)
		{
			return null;
		}

		// Token: 0x060013DC RID: 5084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013DC")]
		[Address(RVA = "0x5A78840", Offset = "0x5A77440", VA = "0x185A78840")]
		public UIRStylePainter(RenderChain renderChain)
		{
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x060013DD RID: 5085 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x170004C3")]
		public MeshGenerationContext meshGenerationContext
		{
			[Token(Token = "0x60013DD")]
			[Address(RVA = "0x4FA1A60", Offset = "0x4FA0660", VA = "0x184FA1A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x060013DE RID: 5086 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x060013DF RID: 5087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004C4")]
		public VisualElement currentElement
		{
			[Token(Token = "0x60013DE")]
			[Address(RVA = "0x5A78CD0", Offset = "0x5A778D0", VA = "0x185A78CD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60013DF")]
			[Address(RVA = "0x5A78D00", Offset = "0x5A77900", VA = "0x185A78D00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x060013E0 RID: 5088 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x170004C5")]
		public List<UIRStylePainter.Entry> entries
		{
			[Token(Token = "0x60013E0")]
			[Address(RVA = "0x4893C50", Offset = "0x4892850", VA = "0x184893C50")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x060013E1 RID: 5089 RVA: 0x0000A560 File Offset: 0x00008760
		[Token(Token = "0x170004C6")]
		public UIRStylePainter.ClosingInfo closingInfo
		{
			[Token(Token = "0x60013E1")]
			[Address(RVA = "0x5A78C90", Offset = "0x5A77890", VA = "0x185A78C90")]
			get
			{
				return default(UIRStylePainter.ClosingInfo);
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x060013E2 RID: 5090 RVA: 0x0000A578 File Offset: 0x00008778
		// (set) Token: 0x060013E3 RID: 5091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004C7")]
		public int totalVertices
		{
			[Token(Token = "0x60013E2")]
			[Address(RVA = "0x5A220B0", Offset = "0x5A20CB0", VA = "0x185A220B0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60013E3")]
			[Address(RVA = "0x5A78D30", Offset = "0x5A77930", VA = "0x185A78D30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x060013E4 RID: 5092 RVA: 0x0000A590 File Offset: 0x00008790
		// (set) Token: 0x060013E5 RID: 5093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004C8")]
		public int totalIndices
		{
			[Token(Token = "0x60013E4")]
			[Address(RVA = "0x5A78CE0", Offset = "0x5A778E0", VA = "0x185A78CE0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60013E5")]
			[Address(RVA = "0x5A78D20", Offset = "0x5A77920", VA = "0x185A78D20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x060013E6 RID: 5094 RVA: 0x0000A5A8 File Offset: 0x000087A8
		// (set) Token: 0x060013E7 RID: 5095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004C9")]
		private protected bool disposed
		{
			[Token(Token = "0x60013E6")]
			[Address(RVA = "0x58BE4A0", Offset = "0x58BD0A0", VA = "0x1858BE4A0")]
			[CompilerGenerated]
			protected get
			{
				return default(bool);
			}
			[Token(Token = "0x60013E7")]
			[Address(RVA = "0x5A78D10", Offset = "0x5A77910", VA = "0x185A78D10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060013E8 RID: 5096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013E8")]
		[Address(RVA = "0x5A72CC0", Offset = "0x5A718C0", VA = "0x185A72CC0", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x060013E9 RID: 5097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013E9")]
		[Address(RVA = "0x5A72D70", Offset = "0x5A71970", VA = "0x185A72D70")]
		protected void Dispose(bool disposing)
		{
		}

		// Token: 0x060013EA RID: 5098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013EA")]
		[Address(RVA = "0x5A72800", Offset = "0x5A71400", VA = "0x185A72800")]
		public void Begin(VisualElement ve)
		{
		}

		// Token: 0x060013EB RID: 5099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013EB")]
		[Address(RVA = "0x5A78080", Offset = "0x5A76C80", VA = "0x185A78080")]
		public void LandClipUnregisterMeshDrawCommand(RenderChainCommand cmd)
		{
		}

		// Token: 0x060013EC RID: 5100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013EC")]
		[Address(RVA = "0x5A77FE0", Offset = "0x5A76BE0", VA = "0x185A77FE0")]
		public void LandClipRegisterMesh(NativeSlice<Vertex> vertices, NativeSlice<ushort> indices, int indexOffset)
		{
		}

		// Token: 0x060013ED RID: 5101 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60013ED")]
		[Address(RVA = "0x5A71930", Offset = "0x5A70530", VA = "0x185A71930")]
		public MeshWriteData AddGradientsEntry(int vertexCount, int indexCount, TextureId texture, Material material, MeshGenerationContext.MeshFlags flags)
		{
			return null;
		}

		// Token: 0x060013EE RID: 5102 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60013EE")]
		[Address(RVA = "0x5A73160", Offset = "0x5A71D60", VA = "0x185A73160", Slot = "8")]
		public MeshWriteData DrawMesh(int vertexCount, int indexCount, Texture texture, Material material, MeshGenerationContext.MeshFlags flags)
		{
			return null;
		}

		// Token: 0x060013EF RID: 5103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013EF")]
		[Address(RVA = "0x5A75470", Offset = "0x5A74070", VA = "0x185A75470", Slot = "4")]
		public void DrawText(MeshGenerationContextUtils.TextParams textParams, ITextHandle handle, float pixelsPerPoint)
		{
		}

		// Token: 0x060013F0 RID: 5104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013F0")]
		[Address(RVA = "0x5A74ED0", Offset = "0x5A73AD0", VA = "0x185A74ED0")]
		internal void DrawTextNative(MeshGenerationContextUtils.TextParams textParams, ITextHandle handle, float pixelsPerPoint)
		{
		}

		// Token: 0x060013F1 RID: 5105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013F1")]
		[Address(RVA = "0x5A74750", Offset = "0x5A73350", VA = "0x185A74750")]
		internal void DrawTextCore(MeshGenerationContextUtils.TextParams textParams, ITextHandle handle, float pixelsPerPoint)
		{
		}

		// Token: 0x060013F2 RID: 5106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013F2")]
		[Address(RVA = "0x5A736B0", Offset = "0x5A722B0", VA = "0x185A736B0", Slot = "5")]
		public void DrawRectangle(MeshGenerationContextUtils.RectangleParams rectParams)
		{
		}

		// Token: 0x060013F3 RID: 5107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013F3")]
		[Address(RVA = "0x5A72DF0", Offset = "0x5A719F0", VA = "0x185A72DF0", Slot = "9")]
		public void DrawBorder(MeshGenerationContextUtils.BorderParams borderParams)
		{
		}

		// Token: 0x060013F4 RID: 5108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013F4")]
		[Address(RVA = "0x5A73000", Offset = "0x5A71C00", VA = "0x185A73000", Slot = "6")]
		public void DrawImmediate(Action callback, bool cullingEnabled)
		{
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x060013F5 RID: 5109 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x170004CA")]
		public VisualElement visualElement
		{
			[Token(Token = "0x60013F5")]
			[Address(RVA = "0x5A78CF0", Offset = "0x5A778F0", VA = "0x185A78CF0", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x060013F6 RID: 5110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013F6")]
		[Address(RVA = "0x5A75C70", Offset = "0x5A74870", VA = "0x185A75C70")]
		public void DrawVisualElementBackground()
		{
		}

		// Token: 0x060013F7 RID: 5111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013F7")]
		[Address(RVA = "0x5A76A50", Offset = "0x5A75650", VA = "0x185A76A50")]
		public void DrawVisualElementBorder()
		{
		}

		// Token: 0x060013F8 RID: 5112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013F8")]
		[Address(RVA = "0x5A725C0", Offset = "0x5A711C0", VA = "0x185A725C0")]
		public void ApplyVisualElementClipping()
		{
		}

		// Token: 0x060013F9 RID: 5113 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60013F9")]
		[Address(RVA = "0x5A71CA0", Offset = "0x5A708A0", VA = "0x185A71CA0")]
		private ushort[] AdjustSpriteWinding(Vector2[] vertices, ushort[] indices)
		{
			return null;
		}

		// Token: 0x060013FA RID: 5114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013FA")]
		[Address(RVA = "0x5A74000", Offset = "0x5A72C00", VA = "0x185A74000")]
		public void DrawSprite(MeshGenerationContextUtils.RectangleParams rectParams)
		{
		}

		// Token: 0x060013FB RID: 5115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013FB")]
		[Address(RVA = "0x5A72250", Offset = "0x5A70E50", VA = "0x185A72250")]
		private void ApplyInset(ref MeshGenerationContextUtils.RectangleParams rectParams, Texture tex)
		{
		}

		// Token: 0x060013FC RID: 5116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013FC")]
		[Address(RVA = "0x5A75690", Offset = "0x5A74290", VA = "0x185A75690")]
		public void DrawVectorImage(MeshGenerationContextUtils.RectangleParams rectParams)
		{
		}

		// Token: 0x060013FD RID: 5117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013FD")]
		[Address(RVA = "0x5A78100", Offset = "0x5A76D00", VA = "0x185A78100")]
		internal void Reset()
		{
		}

		// Token: 0x060013FE RID: 5118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013FE")]
		[Address(RVA = "0x5A78210", Offset = "0x5A76E10", VA = "0x185A78210")]
		private void ValidateMeshWriteData()
		{
		}

		// Token: 0x060013FF RID: 5119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013FF")]
		[Address(RVA = "0x5A77260", Offset = "0x5A75E60", VA = "0x185A77260")]
		private void GenerateStencilClipEntryForRoundedRectBackground()
		{
		}

		// Token: 0x06001400 RID: 5120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001400")]
		[Address(RVA = "0x5A77BC0", Offset = "0x5A767C0", VA = "0x185A77BC0")]
		private void GenerateStencilClipEntryForSVGBackground()
		{
		}

		// Token: 0x04000B7F RID: 2943
		[Token(Token = "0x4000B7F")]
		[FieldOffset(Offset = "0x10")]
		private RenderChain m_Owner;

		// Token: 0x04000B80 RID: 2944
		[Token(Token = "0x4000B80")]
		[FieldOffset(Offset = "0x18")]
		private List<UIRStylePainter.Entry> m_Entries;

		// Token: 0x04000B81 RID: 2945
		[Token(Token = "0x4000B81")]
		[FieldOffset(Offset = "0x20")]
		private AtlasBase m_Atlas;

		// Token: 0x04000B82 RID: 2946
		[Token(Token = "0x4000B82")]
		[FieldOffset(Offset = "0x28")]
		private VectorImageManager m_VectorImageManager;

		// Token: 0x04000B83 RID: 2947
		[Token(Token = "0x4000B83")]
		[FieldOffset(Offset = "0x30")]
		private UIRStylePainter.Entry m_CurrentEntry;

		// Token: 0x04000B84 RID: 2948
		[Token(Token = "0x4000B84")]
		[FieldOffset(Offset = "0x90")]
		private UIRStylePainter.ClosingInfo m_ClosingInfo;

		// Token: 0x04000B85 RID: 2949
		[Token(Token = "0x4000B85")]
		[FieldOffset(Offset = "0xC8")]
		private int m_MaskDepth;

		// Token: 0x04000B86 RID: 2950
		[Token(Token = "0x4000B86")]
		[FieldOffset(Offset = "0xCC")]
		private int m_StencilRef;

		// Token: 0x04000B87 RID: 2951
		[Token(Token = "0x4000B87")]
		[FieldOffset(Offset = "0xD0")]
		private BMPAlloc m_ClipRectID;

		// Token: 0x04000B88 RID: 2952
		[Token(Token = "0x4000B88")]
		[FieldOffset(Offset = "0xD8")]
		private int m_SVGBackgroundEntryIndex;

		// Token: 0x04000B89 RID: 2953
		[Token(Token = "0x4000B89")]
		[FieldOffset(Offset = "0xE0")]
		private UIRStylePainter.TempDataAlloc<Vertex> m_VertsPool;

		// Token: 0x04000B8A RID: 2954
		[Token(Token = "0x4000B8A")]
		[FieldOffset(Offset = "0x108")]
		private UIRStylePainter.TempDataAlloc<ushort> m_IndicesPool;

		// Token: 0x04000B8B RID: 2955
		[Token(Token = "0x4000B8B")]
		[FieldOffset(Offset = "0x130")]
		private List<MeshWriteData> m_MeshWriteDataPool;

		// Token: 0x04000B8C RID: 2956
		[Token(Token = "0x4000B8C")]
		[FieldOffset(Offset = "0x138")]
		private int m_NextMeshWriteDataPoolItem;

		// Token: 0x04000B8D RID: 2957
		[Token(Token = "0x4000B8D")]
		[FieldOffset(Offset = "0x140")]
		private MeshBuilder.AllocMeshData.Allocator m_AllocRawVertsIndicesDelegate;

		// Token: 0x04000B8E RID: 2958
		[Token(Token = "0x4000B8E")]
		[FieldOffset(Offset = "0x148")]
		private MeshBuilder.AllocMeshData.Allocator m_AllocThroughDrawMeshDelegate;

		// Token: 0x04000B8F RID: 2959
		[Token(Token = "0x4000B8F")]
		[FieldOffset(Offset = "0x150")]
		private MeshBuilder.AllocMeshData.Allocator m_AllocThroughDrawGradientsDelegate;

		// Token: 0x020002DD RID: 733
		[Token(Token = "0x20002DD")]
		internal struct Entry
		{
			// Token: 0x04000B95 RID: 2965
			[Token(Token = "0x4000B95")]
			[FieldOffset(Offset = "0x0")]
			public NativeSlice<Vertex> vertices;

			// Token: 0x04000B96 RID: 2966
			[Token(Token = "0x4000B96")]
			[FieldOffset(Offset = "0x10")]
			public NativeSlice<ushort> indices;

			// Token: 0x04000B97 RID: 2967
			[Token(Token = "0x4000B97")]
			[FieldOffset(Offset = "0x20")]
			public Material material;

			// Token: 0x04000B98 RID: 2968
			[Token(Token = "0x4000B98")]
			[FieldOffset(Offset = "0x28")]
			public Texture custom;

			// Token: 0x04000B99 RID: 2969
			[Token(Token = "0x4000B99")]
			[FieldOffset(Offset = "0x30")]
			public Texture font;

			// Token: 0x04000B9A RID: 2970
			[Token(Token = "0x4000B9A")]
			[FieldOffset(Offset = "0x38")]
			public float fontTexSDFScale;

			// Token: 0x04000B9B RID: 2971
			[Token(Token = "0x4000B9B")]
			[FieldOffset(Offset = "0x3C")]
			public TextureId texture;

			// Token: 0x04000B9C RID: 2972
			[Token(Token = "0x4000B9C")]
			[FieldOffset(Offset = "0x40")]
			public RenderChainCommand customCommand;

			// Token: 0x04000B9D RID: 2973
			[Token(Token = "0x4000B9D")]
			[FieldOffset(Offset = "0x48")]
			public BMPAlloc clipRectID;

			// Token: 0x04000B9E RID: 2974
			[Token(Token = "0x4000B9E")]
			[FieldOffset(Offset = "0x50")]
			public VertexFlags addFlags;

			// Token: 0x04000B9F RID: 2975
			[Token(Token = "0x4000B9F")]
			[FieldOffset(Offset = "0x54")]
			public bool uvIsDisplacement;

			// Token: 0x04000BA0 RID: 2976
			[Token(Token = "0x4000BA0")]
			[FieldOffset(Offset = "0x55")]
			public bool isTextEntry;

			// Token: 0x04000BA1 RID: 2977
			[Token(Token = "0x4000BA1")]
			[FieldOffset(Offset = "0x56")]
			public bool isClipRegisterEntry;

			// Token: 0x04000BA2 RID: 2978
			[Token(Token = "0x4000BA2")]
			[FieldOffset(Offset = "0x58")]
			public int stencilRef;

			// Token: 0x04000BA3 RID: 2979
			[Token(Token = "0x4000BA3")]
			[FieldOffset(Offset = "0x5C")]
			public int maskDepth;
		}

		// Token: 0x020002DE RID: 734
		[Token(Token = "0x20002DE")]
		internal struct ClosingInfo
		{
			// Token: 0x04000BA4 RID: 2980
			[Token(Token = "0x4000BA4")]
			[FieldOffset(Offset = "0x0")]
			public bool needsClosing;

			// Token: 0x04000BA5 RID: 2981
			[Token(Token = "0x4000BA5")]
			[FieldOffset(Offset = "0x1")]
			public bool popViewMatrix;

			// Token: 0x04000BA6 RID: 2982
			[Token(Token = "0x4000BA6")]
			[FieldOffset(Offset = "0x2")]
			public bool popScissorClip;

			// Token: 0x04000BA7 RID: 2983
			[Token(Token = "0x4000BA7")]
			[FieldOffset(Offset = "0x3")]
			public bool blitAndPopRenderTexture;

			// Token: 0x04000BA8 RID: 2984
			[Token(Token = "0x4000BA8")]
			[FieldOffset(Offset = "0x4")]
			public bool PopDefaultMaterial;

			// Token: 0x04000BA9 RID: 2985
			[Token(Token = "0x4000BA9")]
			[FieldOffset(Offset = "0x8")]
			public RenderChainCommand clipUnregisterDrawCommand;

			// Token: 0x04000BAA RID: 2986
			[Token(Token = "0x4000BAA")]
			[FieldOffset(Offset = "0x10")]
			public NativeSlice<Vertex> clipperRegisterVertices;

			// Token: 0x04000BAB RID: 2987
			[Token(Token = "0x4000BAB")]
			[FieldOffset(Offset = "0x20")]
			public NativeSlice<ushort> clipperRegisterIndices;

			// Token: 0x04000BAC RID: 2988
			[Token(Token = "0x4000BAC")]
			[FieldOffset(Offset = "0x30")]
			public int clipperRegisterIndexOffset;

			// Token: 0x04000BAD RID: 2989
			[Token(Token = "0x4000BAD")]
			[FieldOffset(Offset = "0x34")]
			public int maskStencilRef;
		}

		// Token: 0x020002DF RID: 735
		[Token(Token = "0x20002DF")]
		internal struct TempDataAlloc<T> : IDisposable where T : struct
		{
			// Token: 0x06001401 RID: 5121 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001401")]
			public TempDataAlloc(int maxPoolElems)
			{
			}

			// Token: 0x06001402 RID: 5122 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001402")]
			public void Dispose()
			{
			}

			// Token: 0x06001403 RID: 5123 RVA: 0x0000A5C0 File Offset: 0x000087C0
			[Token(Token = "0x6001403")]
			internal NativeSlice<T> Alloc(uint count)
			{
				return default(NativeSlice<T>);
			}

			// Token: 0x06001404 RID: 5124 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001404")]
			internal void SessionDone()
			{
			}

			// Token: 0x04000BAE RID: 2990
			[Token(Token = "0x4000BAE")]
			[FieldOffset(Offset = "0x0")]
			private int maxPoolElemCount;

			// Token: 0x04000BAF RID: 2991
			[Token(Token = "0x4000BAF")]
			[FieldOffset(Offset = "0x0")]
			private NativeArray<T> pool;

			// Token: 0x04000BB0 RID: 2992
			[Token(Token = "0x4000BB0")]
			[FieldOffset(Offset = "0x0")]
			private List<NativeArray<T>> excess;

			// Token: 0x04000BB1 RID: 2993
			[Token(Token = "0x4000BB1")]
			[FieldOffset(Offset = "0x0")]
			private uint takenFromPool;
		}
	}
}
