using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	internal abstract class AtlasBase
	{
		// Token: 0x06000005 RID: 5 RVA: 0x00002084 File Offset: 0x00000284
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x5A23B40", Offset = "0x5A22740", VA = "0x185A23B40", Slot = "4")]
		public virtual bool TryGetAtlas(VisualElement ctx, Texture2D src, out TextureId atlas, out RectInt atlasRect)
		{
			return default(bool);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
		public virtual void ReturnAtlas(VisualElement ctx, Texture2D src, TextureId atlas)
		{
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
		public virtual void Reset()
		{
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "7")]
		protected virtual void OnAssignedToPanel(IPanel panel)
		{
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "8")]
		protected virtual void OnRemovedFromPanel(IPanel panel)
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "9")]
		protected virtual void OnUpdateDynamicTextures(IPanel panel)
		{
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x5A23990", Offset = "0x5A22590", VA = "0x185A23990")]
		internal void InvokeAssignedToPanel(IPanel panel)
		{
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x4FA87F0", Offset = "0x4FA73F0", VA = "0x184FA87F0")]
		internal void InvokeRemovedFromPanel(IPanel panel)
		{
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x55F6D40", Offset = "0x55F5940", VA = "0x1855F6D40")]
		internal void InvokeUpdateDynamicTextures(IPanel panel)
		{
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x5A239E0", Offset = "0x5A225E0", VA = "0x185A239E0")]
		protected static void RepaintTexturedElements(IPanel panel)
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x5A23B20", Offset = "0x5A22720", VA = "0x185A23B20")]
		protected void SetDynamicTexture(TextureId id, Texture texture)
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x5A23BB0", Offset = "0x5A227B0", VA = "0x185A23BB0")]
		protected AtlasBase()
		{
		}

		// Token: 0x04000001 RID: 1
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x10")]
		internal TextureRegistry textureRegistry;
	}
}
