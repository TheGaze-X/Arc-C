using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.PostEffect
{
	// Token: 0x02001456 RID: 5206
	[Token(Token = "0x2001456")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public abstract class PostEffectBase : MonoBehaviour, IHotfixable
	{
		// Token: 0x17000E67 RID: 3687
		// (set) Token: 0x0600789F RID: 30879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000E67")]
		public int depthBuffer
		{
			[Token(Token = "0x600789F")]
			[Address(RVA = "0x2643EA0", Offset = "0x2642AA0", VA = "0x182643EA0")]
			set
			{
			}
		}

		// Token: 0x17000E68 RID: 3688
		// (get) Token: 0x060078A0 RID: 30880
		[Token(Token = "0x17000E68")]
		protected abstract string shaderName { [Token(Token = "0x60078A0")] get; }

		// Token: 0x060078A1 RID: 30881
		[Token(Token = "0x60078A1")]
		protected abstract void OnInit();

		// Token: 0x060078A2 RID: 30882
		[Token(Token = "0x60078A2")]
		protected abstract void OnPostEffect(RenderTexture source, RenderTexture destination);

		// Token: 0x060078A3 RID: 30883 RVA: 0x00036528 File Offset: 0x00034728
		[Token(Token = "0x60078A3")]
		[Address(RVA = "0x2643230", Offset = "0x2641E30", VA = "0x182643230", Slot = "7")]
		protected virtual bool CheckSupport()
		{
			return default(bool);
		}

		// Token: 0x060078A4 RID: 30884 RVA: 0x00036540 File Offset: 0x00034740
		[Token(Token = "0x60078A4")]
		[Address(RVA = "0x2643740", Offset = "0x2642340", VA = "0x182643740")]
		protected bool _CheckResources()
		{
			return default(bool);
		}

		// Token: 0x060078A5 RID: 30885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078A5")]
		[Address(RVA = "0x2643DE0", Offset = "0x26429E0", VA = "0x182643DE0")]
		private void _NotSupported()
		{
		}

		// Token: 0x060078A6 RID: 30886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60078A6")]
		[Address(RVA = "0x2643920", Offset = "0x2642520", VA = "0x182643920")]
		private Material _CheckShaderAndCreateMaterial(Shader shader, Material m2Create)
		{
			return null;
		}

		// Token: 0x060078A7 RID: 30887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078A7")]
		[Address(RVA = "0x2643650", Offset = "0x2642250", VA = "0x182643650")]
		private void Start()
		{
		}

		// Token: 0x060078A8 RID: 30888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078A8")]
		[Address(RVA = "0x2643450", Offset = "0x2642050", VA = "0x182643450")]
		private void OnEnable()
		{
		}

		// Token: 0x060078A9 RID: 30889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078A9")]
		[Address(RVA = "0x2643360", Offset = "0x2641F60", VA = "0x182643360")]
		private void OnDisable()
		{
		}

		// Token: 0x060078AA RID: 30890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078AA")]
		[Address(RVA = "0x2643290", Offset = "0x2641E90", VA = "0x182643290")]
		private void OnDestroy()
		{
		}

		// Token: 0x060078AB RID: 30891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078AB")]
		[Address(RVA = "0x26434B0", Offset = "0x26420B0", VA = "0x1826434B0", Slot = "8")]
		protected virtual void OnPreRender()
		{
		}

		// Token: 0x060078AC RID: 30892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078AC")]
		[Address(RVA = "0x2643070", Offset = "0x2641C70", VA = "0x182643070", Slot = "9")]
		protected virtual void OnPostRender()
		{
		}

		// Token: 0x060078AD RID: 30893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078AD")]
		[Address(RVA = "0x2643E40", Offset = "0x2642A40", VA = "0x182643E40")]
		protected PostEffectBase()
		{
		}

		// Token: 0x0400768A RID: 30346
		[Token(Token = "0x400768A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public Shader _shader;

		// Token: 0x0400768B RID: 30347
		[Token(Token = "0x400768B")]
		[FieldOffset(Offset = "0x20")]
		private bool? m_allowMSAA;

		// Token: 0x0400768C RID: 30348
		[Token(Token = "0x400768C")]
		[FieldOffset(Offset = "0x22")]
		private bool m_isSupported;

		// Token: 0x0400768D RID: 30349
		[Token(Token = "0x400768D")]
		[FieldOffset(Offset = "0x28")]
		private RenderTexture m_sourceRT;

		// Token: 0x0400768E RID: 30350
		[Token(Token = "0x400768E")]
		[FieldOffset(Offset = "0x30")]
		private RenderTexture m_rawRenderTarget;

		// Token: 0x0400768F RID: 30351
		[Token(Token = "0x400768F")]
		[FieldOffset(Offset = "0x38")]
		private int m_depthBufferSize;

		// Token: 0x04007690 RID: 30352
		[Token(Token = "0x4007690")]
		[FieldOffset(Offset = "0x40")]
		protected Material m_material;

		// Token: 0x04007691 RID: 30353
		[Token(Token = "0x4007691")]
		[FieldOffset(Offset = "0x48")]
		protected Camera m_camera;

		// Token: 0x04007692 RID: 30354
		[Token(Token = "0x4007692")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_depthBuffer;

		// Token: 0x04007693 RID: 30355
		[Token(Token = "0x4007693")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CheckSupport;

		// Token: 0x04007694 RID: 30356
		[Token(Token = "0x4007694")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CheckResources;

		// Token: 0x04007695 RID: 30357
		[Token(Token = "0x4007695")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__NotSupported;

		// Token: 0x04007696 RID: 30358
		[Token(Token = "0x4007696")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CheckShaderAndCreateMaterial;

		// Token: 0x04007697 RID: 30359
		[Token(Token = "0x4007697")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x04007698 RID: 30360
		[Token(Token = "0x4007698")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x04007699 RID: 30361
		[Token(Token = "0x4007699")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0400769A RID: 30362
		[Token(Token = "0x400769A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0400769B RID: 30363
		[Token(Token = "0x400769B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnPreRender;

		// Token: 0x0400769C RID: 30364
		[Token(Token = "0x400769C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnPostRender;

		// Token: 0x0400769D RID: 30365
		[Token(Token = "0x400769D")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
