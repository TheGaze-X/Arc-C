using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Collections;

namespace UnityEngine.UIElements.UIR.Implementation
{
	// Token: 0x020002E0 RID: 736
	[Token(Token = "0x20002E0")]
	internal class UIRTextUpdatePainter : IStylePainter, IDisposable
	{
		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06001405 RID: 5125 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x170004CB")]
		public MeshGenerationContext meshGenerationContext
		{
			[Token(Token = "0x6001405")]
			[Address(RVA = "0x51C280", Offset = "0x51AE80", VA = "0x18051C280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06001406 RID: 5126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001406")]
		[Address(RVA = "0x5A79620", Offset = "0x5A78220", VA = "0x185A79620")]
		public UIRTextUpdatePainter()
		{
		}

		// Token: 0x06001407 RID: 5127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001407")]
		[Address(RVA = "0x5A78D40", Offset = "0x5A77940", VA = "0x185A78D40")]
		public void Begin(VisualElement ve, UIRenderDevice device)
		{
		}

		// Token: 0x06001408 RID: 5128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001408")]
		[Address(RVA = "0x5A79580", Offset = "0x5A78180", VA = "0x185A79580")]
		public void End()
		{
		}

		// Token: 0x06001409 RID: 5129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001409")]
		[Address(RVA = "0x5A78FF0", Offset = "0x5A77BF0", VA = "0x185A78FF0", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x0600140A RID: 5130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600140A")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
		public void DrawRectangle(MeshGenerationContextUtils.RectangleParams rectParams)
		{
		}

		// Token: 0x0600140B RID: 5131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600140B")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
		public void DrawImmediate(Action callback, bool cullingEnabled)
		{
		}

		// Token: 0x0600140C RID: 5132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600140C")]
		[Address(RVA = "0x5A79080", Offset = "0x5A77C80", VA = "0x185A79080", Slot = "4")]
		public void DrawText(MeshGenerationContextUtils.TextParams textParams, ITextHandle handle, float pixelsPerPoint)
		{
		}

		// Token: 0x04000BB2 RID: 2994
		[Token(Token = "0x4000BB2")]
		[FieldOffset(Offset = "0x10")]
		private VisualElement m_CurrentElement;

		// Token: 0x04000BB3 RID: 2995
		[Token(Token = "0x4000BB3")]
		[FieldOffset(Offset = "0x18")]
		private int m_TextEntryIndex;

		// Token: 0x04000BB4 RID: 2996
		[Token(Token = "0x4000BB4")]
		[FieldOffset(Offset = "0x20")]
		private NativeArray<Vertex> m_DudVerts;

		// Token: 0x04000BB5 RID: 2997
		[Token(Token = "0x4000BB5")]
		[FieldOffset(Offset = "0x30")]
		private NativeArray<ushort> m_DudIndices;

		// Token: 0x04000BB6 RID: 2998
		[Token(Token = "0x4000BB6")]
		[FieldOffset(Offset = "0x40")]
		private NativeSlice<Vertex> m_MeshDataVerts;

		// Token: 0x04000BB7 RID: 2999
		[Token(Token = "0x4000BB7")]
		[FieldOffset(Offset = "0x50")]
		private Color32 m_XFormClipPages;

		// Token: 0x04000BB8 RID: 3000
		[Token(Token = "0x4000BB8")]
		[FieldOffset(Offset = "0x54")]
		private Color32 m_IDs;

		// Token: 0x04000BB9 RID: 3001
		[Token(Token = "0x4000BB9")]
		[FieldOffset(Offset = "0x58")]
		private Color32 m_Flags;

		// Token: 0x04000BBA RID: 3002
		[Token(Token = "0x4000BBA")]
		[FieldOffset(Offset = "0x5C")]
		private Color32 m_OpacityColorPages;
	}
}
