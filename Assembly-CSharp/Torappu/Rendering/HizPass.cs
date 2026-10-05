using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Torappu.Rendering
{
	// Token: 0x02002045 RID: 8261
	[Token(Token = "0x2002045")]
	[RequireComponent(typeof(Camera))]
	[ExecuteAlways]
	public class HizPass : MonoBehaviour
	{
		// Token: 0x0600CB8F RID: 52111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB8F")]
		[Address(RVA = "0x34C6590", Offset = "0x34C5190", VA = "0x1834C6590")]
		private void OnEnable()
		{
		}

		// Token: 0x0600CB90 RID: 52112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB90")]
		[Address(RVA = "0x34C6780", Offset = "0x34C5380", VA = "0x1834C6780")]
		private void RecreateRT()
		{
		}

		// Token: 0x0600CB91 RID: 52113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB91")]
		[Address(RVA = "0x34C64B0", Offset = "0x34C50B0", VA = "0x1834C64B0")]
		private void OnDisable()
		{
		}

		// Token: 0x0600CB92 RID: 52114 RVA: 0x00049980 File Offset: 0x00047B80
		[Token(Token = "0x600CB92")]
		[Address(RVA = "0x34C62A0", Offset = "0x34C4EA0", VA = "0x1834C62A0")]
		private Vector2Int GetBestFitRes(int width, int height)
		{
			return default(Vector2Int);
		}

		// Token: 0x0600CB93 RID: 52115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB93")]
		[Address(RVA = "0x34C6AD0", Offset = "0x34C56D0", VA = "0x1834C6AD0")]
		private void UpdateCommandBuffer()
		{
		}

		// Token: 0x0600CB94 RID: 52116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB94")]
		[Address(RVA = "0x34C6300", Offset = "0x34C4F00", VA = "0x1834C6300")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600CB95 RID: 52117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB95")]
		[Address(RVA = "0x34C6710", Offset = "0x34C5310", VA = "0x1834C6710")]
		private void OnPreRender()
		{
		}

		// Token: 0x0600CB96 RID: 52118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB96")]
		[Address(RVA = "0x34C6FA0", Offset = "0x34C5BA0", VA = "0x1834C6FA0")]
		public HizPass()
		{
		}

		// Token: 0x0400D5CC RID: 54732
		[Token(Token = "0x400D5CC")]
		[FieldOffset(Offset = "0x18")]
		public Shader effectShader;

		// Token: 0x0400D5CD RID: 54733
		[Token(Token = "0x400D5CD")]
		[FieldOffset(Offset = "0x20")]
		private Material effectMaterial;

		// Token: 0x0400D5CE RID: 54734
		[Token(Token = "0x400D5CE")]
		[FieldOffset(Offset = "0x28")]
		private CommandBuffer commandBuffer;

		// Token: 0x0400D5CF RID: 54735
		[Token(Token = "0x400D5CF")]
		[FieldOffset(Offset = "0x30")]
		private Camera mCamera;

		// Token: 0x0400D5D0 RID: 54736
		[Token(Token = "0x400D5D0")]
		[FieldOffset(Offset = "0x38")]
		private RenderTexture mHizBuffer;

		// Token: 0x0400D5D1 RID: 54737
		[Token(Token = "0x400D5D1")]
		[FieldOffset(Offset = "0x40")]
		private RenderTexture mTmpBuffer;

		// Token: 0x0400D5D2 RID: 54738
		[Token(Token = "0x400D5D2")]
		[FieldOffset(Offset = "0x48")]
		private Vector2Int mHizBufferSize;

		// Token: 0x0400D5D3 RID: 54739
		[Token(Token = "0x400D5D3")]
		[FieldOffset(Offset = "0x50")]
		private Vector2Int mPrevCameraPixelSize;
	}
}
