using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle;
using UnityEngine;
using UnityEngine.Rendering;
using XLua;

namespace Torappu.Rendering
{
	// Token: 0x02002074 RID: 8308
	[Token(Token = "0x2002074")]
	[ExecuteInEditMode]
	public class WaterRippleEffect : BaseSceneEffect
	{
		// Token: 0x0600CCBA RID: 52410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCBA")]
		[Address(RVA = "0x34EC0C0", Offset = "0x34EACC0", VA = "0x1834EC0C0", Slot = "5")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600CCBB RID: 52411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCBB")]
		[Address(RVA = "0x34EBD30", Offset = "0x34EA930", VA = "0x1834EBD30", Slot = "4")]
		public override void OnCameraChanged(Camera old, Camera current)
		{
		}

		// Token: 0x0600CCBC RID: 52412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCBC")]
		[Address(RVA = "0x34ED480", Offset = "0x34EC080", VA = "0x1834ED480")]
		private void _ClearCurrentCamera()
		{
		}

		// Token: 0x0600CCBD RID: 52413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCBD")]
		[Address(RVA = "0x34EB470", Offset = "0x34EA070", VA = "0x1834EB470")]
		private new void Init()
		{
		}

		// Token: 0x0600CCBE RID: 52414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCBE")]
		[Address(RVA = "0x34EBF10", Offset = "0x34EAB10", VA = "0x1834EBF10", Slot = "7")]
		protected override void OnFinish()
		{
		}

		// Token: 0x0600CCBF RID: 52415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCBF")]
		[Address(RVA = "0x34EC460", Offset = "0x34EB060", VA = "0x1834EC460")]
		private void Update()
		{
		}

		// Token: 0x0600CCC0 RID: 52416 RVA: 0x00049DD0 File Offset: 0x00047FD0
		[Token(Token = "0x600CCC0")]
		[Address(RVA = "0x34EAF70", Offset = "0x34E9B70", VA = "0x1834EAF70")]
		public bool AddMaskObj(GameObject obj)
		{
			return default(bool);
		}

		// Token: 0x0600CCC1 RID: 52417 RVA: 0x00049DE8 File Offset: 0x00047FE8
		[Token(Token = "0x600CCC1")]
		[Address(RVA = "0x34EC280", Offset = "0x34EAE80", VA = "0x1834EC280")]
		public bool RemoveMaskObj(GameObject obj)
		{
			return default(bool);
		}

		// Token: 0x0600CCC2 RID: 52418 RVA: 0x00049E00 File Offset: 0x00048000
		[Token(Token = "0x600CCC2")]
		[Address(RVA = "0x34EB0C0", Offset = "0x34E9CC0", VA = "0x1834EB0C0")]
		public bool AddWaterRippleMask(Tile obj)
		{
			return default(bool);
		}

		// Token: 0x0600CCC3 RID: 52419 RVA: 0x00049E18 File Offset: 0x00048018
		[Token(Token = "0x600CCC3")]
		[Address(RVA = "0x34EC3C0", Offset = "0x34EAFC0", VA = "0x1834EC3C0")]
		public bool RemoveWaterRippleMask(Tile obj)
		{
			return default(bool);
		}

		// Token: 0x0600CCC4 RID: 52420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCC4")]
		[Address(RVA = "0x34EBA00", Offset = "0x34EA600", VA = "0x1834EBA00", Slot = "8")]
		public override void Merge(BaseSceneEffect another)
		{
		}

		// Token: 0x0600CCC5 RID: 52421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CCC5")]
		[Address(RVA = "0x34EB160", Offset = "0x34E9D60", VA = "0x1834EB160")]
		public static Mesh CreateQuad(float width = 1f, float height = 1f)
		{
			return null;
		}

		// Token: 0x0600CCC6 RID: 52422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCC6")]
		[Address(RVA = "0x34ED530", Offset = "0x34EC130", VA = "0x1834ED530")]
		public WaterRippleEffect()
		{
		}

		// Token: 0x0600CCC7 RID: 52423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCC7")]
		[Address(RVA = "0x34D08D0", Offset = "0x34CF4D0", VA = "0x1834D08D0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0600CCC8 RID: 52424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCC8")]
		[Address(RVA = "0x50E130", Offset = "0x50CD30", VA = "0x18050E130")]
		private void <>xLuaBaseProxy_OnCameraChanged(Camera P0, Camera P1)
		{
		}

		// Token: 0x0600CCC9 RID: 52425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCC9")]
		[Address(RVA = "0x50E140", Offset = "0x50CD40", VA = "0x18050E140")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x0600CCCA RID: 52426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCCA")]
		[Address(RVA = "0x34D2340", Offset = "0x34D0F40", VA = "0x1834D2340")]
		private void <>xLuaBaseProxy_Merge(BaseSceneEffect P0)
		{
		}

		// Token: 0x0400D7D8 RID: 55256
		[Token(Token = "0x400D7D8")]
		[FieldOffset(Offset = "0x20")]
		public Camera maskCam;

		// Token: 0x0400D7D9 RID: 55257
		[Token(Token = "0x400D7D9")]
		[FieldOffset(Offset = "0x28")]
		private Camera m_camera;

		// Token: 0x0400D7DA RID: 55258
		[Token(Token = "0x400D7DA")]
		[FieldOffset(Offset = "0x30")]
		private RenderTexture maskRT;

		// Token: 0x0400D7DB RID: 55259
		[Token(Token = "0x400D7DB")]
		[FieldOffset(Offset = "0x38")]
		private RenderTexture maskBlurRT;

		// Token: 0x0400D7DC RID: 55260
		[Token(Token = "0x400D7DC")]
		[FieldOffset(Offset = "0x40")]
		private Material waterMat;

		// Token: 0x0400D7DD RID: 55261
		[Token(Token = "0x400D7DD")]
		[FieldOffset(Offset = "0x48")]
		public GameObject waterPlane;

		// Token: 0x0400D7DE RID: 55262
		[Token(Token = "0x400D7DE")]
		[FieldOffset(Offset = "0x50")]
		public Shader rippleShader;

		// Token: 0x0400D7DF RID: 55263
		[Token(Token = "0x400D7DF")]
		[FieldOffset(Offset = "0x58")]
		public Shader dilationShader;

		// Token: 0x0400D7E0 RID: 55264
		[Token(Token = "0x400D7E0")]
		[FieldOffset(Offset = "0x60")]
		public Shader blurShader;

		// Token: 0x0400D7E1 RID: 55265
		[Token(Token = "0x400D7E1")]
		[FieldOffset(Offset = "0x68")]
		[Range(5f, 20f)]
		public float cameraSize;

		// Token: 0x0400D7E2 RID: 55266
		[Token(Token = "0x400D7E2")]
		[FieldOffset(Offset = "0x6C")]
		public Vector2 rippleDir;

		// Token: 0x0400D7E3 RID: 55267
		[Token(Token = "0x400D7E3")]
		[FieldOffset(Offset = "0x74")]
		[Range(-1f, 1f)]
		public float rippleSpeed;

		// Token: 0x0400D7E4 RID: 55268
		[Token(Token = "0x400D7E4")]
		[FieldOffset(Offset = "0x78")]
		[Range(0f, 4f)]
		public float rippleScale;

		// Token: 0x0400D7E5 RID: 55269
		[Token(Token = "0x400D7E5")]
		[FieldOffset(Offset = "0x7C")]
		public Vector2 flowDir;

		// Token: 0x0400D7E6 RID: 55270
		[Token(Token = "0x400D7E6")]
		[FieldOffset(Offset = "0x84")]
		[Range(-2f, 2f)]
		public float flowSpeed;

		// Token: 0x0400D7E7 RID: 55271
		[Token(Token = "0x400D7E7")]
		[FieldOffset(Offset = "0x88")]
		private Vector4 flowUV;

		// Token: 0x0400D7E8 RID: 55272
		[Token(Token = "0x400D7E8")]
		[FieldOffset(Offset = "0x98")]
		private Material dilationMat;

		// Token: 0x0400D7E9 RID: 55273
		[Token(Token = "0x400D7E9")]
		[FieldOffset(Offset = "0xA0")]
		private Material blurMat;

		// Token: 0x0400D7EA RID: 55274
		[Token(Token = "0x400D7EA")]
		[FieldOffset(Offset = "0xA8")]
		private Vector2 rippleUV_1;

		// Token: 0x0400D7EB RID: 55275
		[Token(Token = "0x400D7EB")]
		[FieldOffset(Offset = "0xB0")]
		private Vector2 rippleUV_2;

		// Token: 0x0400D7EC RID: 55276
		[Token(Token = "0x400D7EC")]
		[FieldOffset(Offset = "0xB8")]
		private Vector2 rippleUV_3;

		// Token: 0x0400D7ED RID: 55277
		[Token(Token = "0x400D7ED")]
		[FieldOffset(Offset = "0xC0")]
		private MaterialPropertyBlock property_block;

		// Token: 0x0400D7EE RID: 55278
		[Token(Token = "0x400D7EE")]
		[FieldOffset(Offset = "0xC8")]
		private Renderer waterRenderer;

		// Token: 0x0400D7EF RID: 55279
		[Token(Token = "0x400D7EF")]
		[FieldOffset(Offset = "0xD0")]
		private RenderTextureFormat format;

		// Token: 0x0400D7F0 RID: 55280
		[Token(Token = "0x400D7F0")]
		[FieldOffset(Offset = "0xD8")]
		private CommandBuffer rippleMaskCmd;

		// Token: 0x0400D7F1 RID: 55281
		[Token(Token = "0x400D7F1")]
		[FieldOffset(Offset = "0xE0")]
		private Dictionary<GameObject, MeshRenderer> maskDic;

		// Token: 0x0400D7F2 RID: 55282
		[Token(Token = "0x400D7F2")]
		[FieldOffset(Offset = "0xE8")]
		private HashSet<GameObject> maskHash;

		// Token: 0x0400D7F3 RID: 55283
		[Token(Token = "0x400D7F3")]
		[FieldOffset(Offset = "0xF0")]
		public List<GameObject> rootMask;

		// Token: 0x0400D7F4 RID: 55284
		[Token(Token = "0x400D7F4")]
		[FieldOffset(Offset = "0xF8")]
		private Matrix4x4 maskCamVP;

		// Token: 0x0400D7F5 RID: 55285
		[Token(Token = "0x400D7F5")]
		[FieldOffset(Offset = "0x138")]
		private Material maskMat;

		// Token: 0x0400D7F6 RID: 55286
		[Token(Token = "0x400D7F6")]
		[FieldOffset(Offset = "0x140")]
		private HashSet<Tile> dynamicMaskHash;

		// Token: 0x0400D7F7 RID: 55287
		[Token(Token = "0x400D7F7")]
		[FieldOffset(Offset = "0x148")]
		private Mesh maskMesh;

		// Token: 0x0400D7F8 RID: 55288
		[Token(Token = "0x400D7F8")]
		[FieldOffset(Offset = "0x150")]
		private bool isInit;

		// Token: 0x0400D7F9 RID: 55289
		[Token(Token = "0x400D7F9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400D7FA RID: 55290
		[Token(Token = "0x400D7FA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCameraChanged;

		// Token: 0x0400D7FB RID: 55291
		[Token(Token = "0x400D7FB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ClearCurrentCamera;

		// Token: 0x0400D7FC RID: 55292
		[Token(Token = "0x400D7FC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400D7FD RID: 55293
		[Token(Token = "0x400D7FD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x0400D7FE RID: 55294
		[Token(Token = "0x400D7FE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0400D7FF RID: 55295
		[Token(Token = "0x400D7FF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_AddMaskObj;

		// Token: 0x0400D800 RID: 55296
		[Token(Token = "0x400D800")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_RemoveMaskObj;

		// Token: 0x0400D801 RID: 55297
		[Token(Token = "0x400D801")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_AddWaterRippleMask;

		// Token: 0x0400D802 RID: 55298
		[Token(Token = "0x400D802")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_RemoveWaterRippleMask;

		// Token: 0x0400D803 RID: 55299
		[Token(Token = "0x400D803")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_Merge;

		// Token: 0x0400D804 RID: 55300
		[Token(Token = "0x400D804")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_CreateQuad;

		// Token: 0x0400D805 RID: 55301
		[Token(Token = "0x400D805")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
