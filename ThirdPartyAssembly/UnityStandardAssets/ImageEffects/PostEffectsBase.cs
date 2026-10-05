using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x0200005A RID: 90
	[Token(Token = "0x200005A")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class PostEffectsBase : MonoBehaviour
	{
		// Token: 0x0600022E RID: 558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022E")]
		[Address(RVA = "0x52F9F50", Offset = "0x52F8B50", VA = "0x1852F9F50")]
		protected Material CheckShaderAndCreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022F")]
		[Address(RVA = "0x52FA870", Offset = "0x52F9470", VA = "0x1852FA870")]
		protected Material CreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000230")]
		[Address(RVA = "0x28679A0", Offset = "0x28665A0", VA = "0x1828679A0")]
		private void OnEnable()
		{
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000231")]
		[Address(RVA = "0x52FAE10", Offset = "0x52F9A10", VA = "0x1852FAE10")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000232")]
		[Address(RVA = "0x52FAE10", Offset = "0x52F9A10", VA = "0x1852FAE10")]
		private void RemoveCreatedMaterials()
		{
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00002868 File Offset: 0x00000A68
		[Token(Token = "0x6000233")]
		[Address(RVA = "0x52FA7F0", Offset = "0x52F93F0", VA = "0x1852FA7F0")]
		protected bool CheckSupport()
		{
			return default(bool);
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00002880 File Offset: 0x00000A80
		[Token(Token = "0x6000234")]
		[Address(RVA = "0x52F9E90", Offset = "0x52F8A90", VA = "0x1852F9E90", Slot = "4")]
		public virtual bool CheckResources()
		{
			return default(bool);
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000235")]
		[Address(RVA = "0x52FAFA0", Offset = "0x52F9BA0", VA = "0x1852FAFA0")]
		protected void Start()
		{
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00002898 File Offset: 0x00000A98
		[Token(Token = "0x6000236")]
		[Address(RVA = "0x52FA6B0", Offset = "0x52F92B0", VA = "0x1852FA6B0")]
		protected bool CheckSupport(bool needDepth)
		{
			return default(bool);
		}

		// Token: 0x06000237 RID: 567 RVA: 0x000028B0 File Offset: 0x00000AB0
		[Token(Token = "0x6000237")]
		[Address(RVA = "0x52FA790", Offset = "0x52F9390", VA = "0x1852FA790")]
		protected bool CheckSupport(bool needDepth, bool needHdr)
		{
			return default(bool);
		}

		// Token: 0x06000238 RID: 568 RVA: 0x000028C8 File Offset: 0x00000AC8
		[Token(Token = "0x6000238")]
		[Address(RVA = "0x54A770", Offset = "0x549370", VA = "0x18054A770")]
		public bool Dx11Support()
		{
			return default(bool);
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000239")]
		[Address(RVA = "0x52FAEF0", Offset = "0x52F9AF0", VA = "0x1852FAEF0")]
		protected void ReportAutoDisable()
		{
		}

		// Token: 0x0600023A RID: 570 RVA: 0x000028E0 File Offset: 0x00000AE0
		[Token(Token = "0x600023A")]
		[Address(RVA = "0x52FA3D0", Offset = "0x52F8FD0", VA = "0x1852FA3D0")]
		private bool CheckShader(Shader s)
		{
			return default(bool);
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600023B")]
		[Address(RVA = "0x52FADF0", Offset = "0x52F99F0", VA = "0x1852FADF0")]
		protected void NotSupported()
		{
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600023C")]
		[Address(RVA = "0x52FAA70", Offset = "0x52F9670", VA = "0x1852FAA70")]
		protected void DrawBorder(RenderTexture dest, Material material)
		{
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600023D")]
		[Address(RVA = "0x52FAFE0", Offset = "0x52F9BE0", VA = "0x1852FAFE0")]
		public PostEffectsBase()
		{
		}

		// Token: 0x04000268 RID: 616
		[Token(Token = "0x4000268")]
		[FieldOffset(Offset = "0x18")]
		protected bool supportHDRTextures;

		// Token: 0x04000269 RID: 617
		[Token(Token = "0x4000269")]
		[FieldOffset(Offset = "0x19")]
		protected bool supportDX11;

		// Token: 0x0400026A RID: 618
		[Token(Token = "0x400026A")]
		[FieldOffset(Offset = "0x1A")]
		protected bool isSupported;

		// Token: 0x0400026B RID: 619
		[Token(Token = "0x400026B")]
		[FieldOffset(Offset = "0x20")]
		private List<Material> createdMaterials;
	}
}
