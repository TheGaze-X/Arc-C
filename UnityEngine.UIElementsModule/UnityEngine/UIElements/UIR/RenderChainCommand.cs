using System;
using Il2CppDummyDll;
using Unity.Profiling;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x020002D8 RID: 728
	[Token(Token = "0x20002D8")]
	internal class RenderChainCommand : LinkedPoolItem<RenderChainCommand>
	{
		// Token: 0x060013A0 RID: 5024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013A0")]
		[Address(RVA = "0x5A5A2B0", Offset = "0x5A58EB0", VA = "0x185A5A2B0")]
		internal void Reset()
		{
		}

		// Token: 0x060013A1 RID: 5025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013A1")]
		[Address(RVA = "0x5A592F0", Offset = "0x5A57EF0", VA = "0x185A592F0")]
		internal void ExecuteNonDrawMesh(DrawParams drawParams, float pixelsPerPoint, ref Exception immediateException)
		{
		}

		// Token: 0x060013A2 RID: 5026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013A2")]
		[Address(RVA = "0x5A58FC0", Offset = "0x5A57BC0", VA = "0x185A58FC0")]
		private void Blit(Texture source, RenderTexture destination, float depth)
		{
		}

		// Token: 0x060013A3 RID: 5027 RVA: 0x0000A3E0 File Offset: 0x000085E0
		[Token(Token = "0x60013A3")]
		[Address(RVA = "0x5A59130", Offset = "0x5A57D30", VA = "0x185A59130")]
		private static Rect CombineScissorRects(Rect r0, Rect r1)
		{
			return default(Rect);
		}

		// Token: 0x060013A4 RID: 5028 RVA: 0x0000A3F8 File Offset: 0x000085F8
		[Token(Token = "0x60013A4")]
		[Address(RVA = "0x5A5A150", Offset = "0x5A58D50", VA = "0x185A5A150")]
		private static RectInt RectPointsToPixelsAndFlipYAxis(Rect rect, float pixelsPerPoint)
		{
			return default(RectInt);
		}

		// Token: 0x060013A5 RID: 5029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013A5")]
		[Address(RVA = "0x5A5A3C0", Offset = "0x5A58FC0", VA = "0x185A5A3C0")]
		public RenderChainCommand()
		{
		}

		// Token: 0x04000B65 RID: 2917
		[Token(Token = "0x4000B65")]
		[FieldOffset(Offset = "0x18")]
		internal VisualElement owner;

		// Token: 0x04000B66 RID: 2918
		[Token(Token = "0x4000B66")]
		[FieldOffset(Offset = "0x20")]
		internal RenderChainCommand prev;

		// Token: 0x04000B67 RID: 2919
		[Token(Token = "0x4000B67")]
		[FieldOffset(Offset = "0x28")]
		internal RenderChainCommand next;

		// Token: 0x04000B68 RID: 2920
		[Token(Token = "0x4000B68")]
		[FieldOffset(Offset = "0x30")]
		internal bool closing;

		// Token: 0x04000B69 RID: 2921
		[Token(Token = "0x4000B69")]
		[FieldOffset(Offset = "0x34")]
		internal CommandType type;

		// Token: 0x04000B6A RID: 2922
		[Token(Token = "0x4000B6A")]
		[FieldOffset(Offset = "0x38")]
		internal State state;

		// Token: 0x04000B6B RID: 2923
		[Token(Token = "0x4000B6B")]
		[FieldOffset(Offset = "0x58")]
		internal MeshHandle mesh;

		// Token: 0x04000B6C RID: 2924
		[Token(Token = "0x4000B6C")]
		[FieldOffset(Offset = "0x60")]
		internal int indexOffset;

		// Token: 0x04000B6D RID: 2925
		[Token(Token = "0x4000B6D")]
		[FieldOffset(Offset = "0x64")]
		internal int indexCount;

		// Token: 0x04000B6E RID: 2926
		[Token(Token = "0x4000B6E")]
		[FieldOffset(Offset = "0x68")]
		internal Action callback;

		// Token: 0x04000B6F RID: 2927
		[Token(Token = "0x4000B6F")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int k_ID_MainTex;

		// Token: 0x04000B70 RID: 2928
		[Token(Token = "0x4000B70")]
		[FieldOffset(Offset = "0x8")]
		private static ProfilerMarker s_ImmediateOverheadMarker;
	}
}
