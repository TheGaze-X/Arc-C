using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using XLua;

namespace Torappu.GraphicEffect.Reflection
{
	// Token: 0x0200162E RID: 5678
	[Token(Token = "0x200162E")]
	public class ReflectCamera : MonoBehaviour, IHotfixable
	{
		// Token: 0x17000F3D RID: 3901
		// (get) Token: 0x060080C6 RID: 32966 RVA: 0x00038430 File Offset: 0x00036630
		[Token(Token = "0x17000F3D")]
		private bool ready
		{
			[Token(Token = "0x60080C6")]
			[Address(RVA = "0x289F5D0", Offset = "0x289E1D0", VA = "0x18289F5D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000F3E RID: 3902
		// (get) Token: 0x060080C7 RID: 32967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F3E")]
		public ReflectCameraHolder holder
		{
			[Token(Token = "0x60080C7")]
			[Address(RVA = "0x289F560", Offset = "0x289E160", VA = "0x18289F560")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F3F RID: 3903
		// (get) Token: 0x060080C8 RID: 32968 RVA: 0x00038448 File Offset: 0x00036648
		[Token(Token = "0x17000F3F")]
		public bool CropSuccess
		{
			[Token(Token = "0x60080C8")]
			[Address(RVA = "0x289F3B0", Offset = "0x289DFB0", VA = "0x18289F3B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000F40 RID: 3904
		// (get) Token: 0x060080C9 RID: 32969 RVA: 0x00038460 File Offset: 0x00036660
		[Token(Token = "0x17000F40")]
		private bool UseCrop
		{
			[Token(Token = "0x60080C9")]
			[Address(RVA = "0x289F440", Offset = "0x289E040", VA = "0x18289F440")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060080CA RID: 32970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080CA")]
		[Address(RVA = "0x289BB00", Offset = "0x289A700", VA = "0x18289BB00")]
		public void Initialize(HGReflectionShaderProfile shaderProfile)
		{
		}

		// Token: 0x060080CB RID: 32971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080CB")]
		[Address(RVA = "0x289E340", Offset = "0x289CF40", VA = "0x18289E340")]
		public void SetHolder(ReflectCameraHolder holder)
		{
		}

		// Token: 0x060080CC RID: 32972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080CC")]
		[Address(RVA = "0x289B0B0", Offset = "0x2899CB0", VA = "0x18289B0B0")]
		public void CreateRenderTarget(int width = 256, int height = 256)
		{
		}

		// Token: 0x060080CD RID: 32973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080CD")]
		[Address(RVA = "0x289E170", Offset = "0x289CD70", VA = "0x18289E170")]
		public void SetBounds(MeshRenderer bounds)
		{
		}

		// Token: 0x060080CE RID: 32974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080CE")]
		[Address(RVA = "0x289DAB0", Offset = "0x289C6B0", VA = "0x18289DAB0")]
		public void RegisterReflectIdx()
		{
		}

		// Token: 0x060080CF RID: 32975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080CF")]
		[Address(RVA = "0x289E3D0", Offset = "0x289CFD0", VA = "0x18289E3D0")]
		public void SetPlane(Vector3 upDir, MeshRenderer planeRenderer)
		{
		}

		// Token: 0x060080D0 RID: 32976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080D0")]
		[Address(RVA = "0x289E210", Offset = "0x289CE10", VA = "0x18289E210")]
		public void SetCamera(Camera camera)
		{
		}

		// Token: 0x060080D1 RID: 32977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080D1")]
		[Address(RVA = "0x289E6B0", Offset = "0x289D2B0", VA = "0x18289E6B0")]
		public void SetReflectFadeHeight(float reflectFadeHeight)
		{
		}

		// Token: 0x060080D2 RID: 32978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080D2")]
		[Address(RVA = "0x289A6A0", Offset = "0x28992A0", VA = "0x18289A6A0")]
		private void BuildShaderMapping(HGReflectionShaderProfile shaderProfile)
		{
		}

		// Token: 0x060080D3 RID: 32979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080D3")]
		[Address(RVA = "0x289DE80", Offset = "0x289CA80", VA = "0x18289DE80")]
		private void ReleaseShaderMapping()
		{
		}

		// Token: 0x060080D4 RID: 32980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080D4")]
		[Address(RVA = "0x289A350", Offset = "0x2898F50", VA = "0x18289A350")]
		private void ApplyReflectRT()
		{
		}

		// Token: 0x060080D5 RID: 32981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60080D5")]
		[Address(RVA = "0x289B7E0", Offset = "0x289A3E0", VA = "0x18289B7E0")]
		public Camera GetCamera()
		{
			return null;
		}

		// Token: 0x060080D6 RID: 32982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080D6")]
		[Address(RVA = "0x289DBA0", Offset = "0x289C7A0", VA = "0x18289DBA0")]
		public void RegisterReflectObject(MeshRenderer renderer)
		{
		}

		// Token: 0x060080D7 RID: 32983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080D7")]
		[Address(RVA = "0x289E740", Offset = "0x289D340", VA = "0x18289E740")]
		public void UnregisterReflectObject(MeshRenderer renderer)
		{
		}

		// Token: 0x060080D8 RID: 32984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080D8")]
		[Address(RVA = "0x289AD30", Offset = "0x2899930", VA = "0x18289AD30")]
		public void CleanupReflectObject()
		{
		}

		// Token: 0x060080D9 RID: 32985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080D9")]
		[Address(RVA = "0x289A940", Offset = "0x2899540", VA = "0x18289A940")]
		private void CalculateCachedParams()
		{
		}

		// Token: 0x060080DA RID: 32986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080DA")]
		[Address(RVA = "0x289D1E0", Offset = "0x289BDE0", VA = "0x18289D1E0")]
		private void RefreshOpaqueCommandBuffer()
		{
		}

		// Token: 0x060080DB RID: 32987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080DB")]
		[Address(RVA = "0x289D660", Offset = "0x289C260", VA = "0x18289D660")]
		private void RefreshTransparentCommandBuffer()
		{
		}

		// Token: 0x060080DC RID: 32988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080DC")]
		[Address(RVA = "0x289AF50", Offset = "0x2899B50", VA = "0x18289AF50")]
		private void CreateCommandBuffer()
		{
		}

		// Token: 0x060080DD RID: 32989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080DD")]
		[Address(RVA = "0x289E010", Offset = "0x289CC10", VA = "0x18289E010")]
		private void RemoveCommandBuffer()
		{
		}

		// Token: 0x060080DE RID: 32990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080DE")]
		[Address(RVA = "0x289B200", Offset = "0x2899E00", VA = "0x18289B200")]
		public void DisableReflection()
		{
		}

		// Token: 0x060080DF RID: 32991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080DF")]
		[Address(RVA = "0x289B6E0", Offset = "0x289A2E0", VA = "0x18289B6E0")]
		public void EnableReflection()
		{
		}

		// Token: 0x060080E0 RID: 32992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080E0")]
		[Address(RVA = "0x289A230", Offset = "0x2898E30", VA = "0x18289A230")]
		public void AddCommandBufferSoft()
		{
		}

		// Token: 0x060080E1 RID: 32993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080E1")]
		[Address(RVA = "0x289DF50", Offset = "0x289CB50", VA = "0x18289DF50")]
		public void RemoveCommandBufferSoft()
		{
		}

		// Token: 0x060080E2 RID: 32994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080E2")]
		[Address(RVA = "0x289A4B0", Offset = "0x28990B0", VA = "0x18289A4B0")]
		private void Awake()
		{
		}

		// Token: 0x060080E3 RID: 32995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080E3")]
		[Address(RVA = "0x289B300", Offset = "0x2899F00", VA = "0x18289B300")]
		public void EnableCamera(bool forceActive)
		{
		}

		// Token: 0x060080E4 RID: 32996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080E4")]
		[Address(RVA = "0x289EC90", Offset = "0x289D890", VA = "0x18289EC90")]
		private void _ReleaseActiveCamera()
		{
		}

		// Token: 0x060080E5 RID: 32997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080E5")]
		[Address(RVA = "0x289EA40", Offset = "0x289D640", VA = "0x18289EA40")]
		private void _EnableCandidateCamera()
		{
		}

		// Token: 0x060080E6 RID: 32998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080E6")]
		[Address(RVA = "0x289D160", Offset = "0x289BD60", VA = "0x18289D160")]
		public void RefreshCamera()
		{
		}

		// Token: 0x060080E7 RID: 32999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080E7")]
		[Address(RVA = "0x289D0D0", Offset = "0x289BCD0", VA = "0x18289D0D0")]
		private void OnEnable()
		{
		}

		// Token: 0x060080E8 RID: 33000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080E8")]
		[Address(RVA = "0x289CF90", Offset = "0x289BB90", VA = "0x18289CF90")]
		private void OnDisable()
		{
		}

		// Token: 0x060080E9 RID: 33001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080E9")]
		[Address(RVA = "0x289AC50", Offset = "0x2899850", VA = "0x18289AC50")]
		public void CleanUp()
		{
		}

		// Token: 0x060080EA RID: 33002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080EA")]
		[Address(RVA = "0x289BB90", Offset = "0x289A790", VA = "0x18289BB90")]
		private void LateUpdate()
		{
		}

		// Token: 0x060080EB RID: 33003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080EB")]
		[Address(RVA = "0x289CD80", Offset = "0x289B980", VA = "0x18289CD80")]
		private void OnDestroy()
		{
		}

		// Token: 0x060080EC RID: 33004 RVA: 0x00038478 File Offset: 0x00036678
		[Token(Token = "0x60080EC")]
		[Address(RVA = "0x289B860", Offset = "0x289A460", VA = "0x18289B860")]
		private static Matrix4x4 GetReflectMat(Vector3 normDir, float distance)
		{
			return default(Matrix4x4);
		}

		// Token: 0x060080ED RID: 33005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080ED")]
		[Address(RVA = "0x289F1A0", Offset = "0x289DDA0", VA = "0x18289F1A0")]
		public ReflectCamera()
		{
		}

		// Token: 0x04008229 RID: 33321
		[Token(Token = "0x4008229")]
		[FieldOffset(Offset = "0x18")]
		public Camera temp_mainCamera;

		// Token: 0x0400822A RID: 33322
		[Token(Token = "0x400822A")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 temp_normal;

		// Token: 0x0400822B RID: 33323
		[Token(Token = "0x400822B")]
		[FieldOffset(Offset = "0x30")]
		public MeshRenderer temp_boundObj;

		// Token: 0x0400822C RID: 33324
		[Token(Token = "0x400822C")]
		[FieldOffset(Offset = "0x38")]
		public MeshRenderer temp_plane;

		// Token: 0x0400822D RID: 33325
		[Token(Token = "0x400822D")]
		[FieldOffset(Offset = "0x40")]
		public RenderTexture temp_rt;

		// Token: 0x0400822E RID: 33326
		[Token(Token = "0x400822E")]
		[FieldOffset(Offset = "0x48")]
		public List<MeshRenderer> temp_reflectObjs;

		// Token: 0x0400822F RID: 33327
		[Token(Token = "0x400822F")]
		[FieldOffset(Offset = "0x50")]
		public ReflectCamera.ReflectIdx temp_reflectIdx;

		// Token: 0x04008230 RID: 33328
		[Token(Token = "0x4008230")]
		[FieldOffset(Offset = "0x54")]
		public float temp_reflectFadeHeight;

		// Token: 0x04008231 RID: 33329
		[Token(Token = "0x4008231")]
		[FieldOffset(Offset = "0x58")]
		private HGReflectionShaderProfile m_shaderProfile;

		// Token: 0x04008232 RID: 33330
		[Token(Token = "0x4008232")]
		[FieldOffset(Offset = "0x60")]
		private ReflectCameraHolder m_holder;

		// Token: 0x04008233 RID: 33331
		[Token(Token = "0x4008233")]
		[FieldOffset(Offset = "0x68")]
		public ReflectCamera.CropMode _cropMode;

		// Token: 0x04008234 RID: 33332
		[Token(Token = "0x4008234")]
		[FieldOffset(Offset = "0x70")]
		private CommandBuffer m_opaqueCB;

		// Token: 0x04008235 RID: 33333
		[Token(Token = "0x4008235")]
		[FieldOffset(Offset = "0x78")]
		private CommandBuffer m_transparentCB;

		// Token: 0x04008236 RID: 33334
		[Token(Token = "0x4008236")]
		[FieldOffset(Offset = "0x80")]
		private MeshRenderer m_boundObj;

		// Token: 0x04008237 RID: 33335
		[Token(Token = "0x4008237")]
		[FieldOffset(Offset = "0x88")]
		private MeshRenderer m_planeRenderer;

		// Token: 0x04008238 RID: 33336
		[Token(Token = "0x4008238")]
		[FieldOffset(Offset = "0x90")]
		private float m_planeParamDistance;

		// Token: 0x04008239 RID: 33337
		[Token(Token = "0x4008239")]
		[FieldOffset(Offset = "0x94")]
		private Vector3 m_planeParamNormal;

		// Token: 0x0400823A RID: 33338
		[Token(Token = "0x400823A")]
		[FieldOffset(Offset = "0xA0")]
		private Vector4 m_shaderPlaneVector;

		// Token: 0x0400823B RID: 33339
		[Token(Token = "0x400823B")]
		[FieldOffset(Offset = "0xB0")]
		private Vector3 m_reflectBoundsCenter;

		// Token: 0x0400823C RID: 33340
		[Token(Token = "0x400823C")]
		[FieldOffset(Offset = "0xBC")]
		private float m_reflectFadeHeight;

		// Token: 0x0400823D RID: 33341
		[Token(Token = "0x400823D")]
		[FieldOffset(Offset = "0xC0")]
		private Material m_planeMat;

		// Token: 0x0400823E RID: 33342
		[Token(Token = "0x400823E")]
		[FieldOffset(Offset = "0xC8")]
		private Material m_planeReflectMat;

		// Token: 0x0400823F RID: 33343
		[Token(Token = "0x400823F")]
		[FieldOffset(Offset = "0xD0")]
		private RenderTexture m_reflectionRT;

		// Token: 0x04008240 RID: 33344
		[Token(Token = "0x4008240")]
		[FieldOffset(Offset = "0xD8")]
		private int m_reflectionRTWdith;

		// Token: 0x04008241 RID: 33345
		[Token(Token = "0x4008241")]
		[FieldOffset(Offset = "0xDC")]
		private int m_reflectionRTHeight;

		// Token: 0x04008242 RID: 33346
		[Token(Token = "0x4008242")]
		[FieldOffset(Offset = "0xE0")]
		private Camera m_mainCamera;

		// Token: 0x04008243 RID: 33347
		[Token(Token = "0x4008243")]
		[FieldOffset(Offset = "0xE8")]
		private List<MeshRenderer> m_OpaqueRenderers;

		// Token: 0x04008244 RID: 33348
		[Token(Token = "0x4008244")]
		[FieldOffset(Offset = "0xF0")]
		private List<MeshRenderer> m_transparentRenderers;

		// Token: 0x04008245 RID: 33349
		[Token(Token = "0x4008245")]
		[FieldOffset(Offset = "0xF8")]
		private ReflectCamera.CachedReflectMaterial m_cachedReflectMat;

		// Token: 0x04008246 RID: 33350
		[Token(Token = "0x4008246")]
		[FieldOffset(Offset = "0x0")]
		private static bool s_initializeShaderMapping;

		// Token: 0x04008247 RID: 33351
		[Token(Token = "0x4008247")]
		[FieldOffset(Offset = "0x4")]
		private static int s_resRefCount;

		// Token: 0x04008248 RID: 33352
		[Token(Token = "0x4008248")]
		[FieldOffset(Offset = "0x8")]
		private static Dictionary<string, Shader> s_renderReplaceMapping;

		// Token: 0x04008249 RID: 33353
		[Token(Token = "0x4008249")]
		[FieldOffset(Offset = "0x10")]
		private static ReflectCamera.ReflectIdx s_reflectUVCropState;

		// Token: 0x0400824A RID: 33354
		[Token(Token = "0x400824A")]
		[FieldOffset(Offset = "0x18")]
		private static ListDict<ReflectCamera.ReflectIdx, ReflectCamera> s_activeCameras;

		// Token: 0x0400824B RID: 33355
		[Token(Token = "0x400824B")]
		[FieldOffset(Offset = "0x20")]
		private static HashSet<ReflectCamera> s_candidateCameras;

		// Token: 0x0400824C RID: 33356
		[Token(Token = "0x400824C")]
		[FieldOffset(Offset = "0x100")]
		private ReflectCamera.ReflectCropManager m_reflectCropManager;

		// Token: 0x0400824D RID: 33357
		[Token(Token = "0x400824D")]
		[FieldOffset(Offset = "0x28")]
		private static readonly float BOUNDS_PROTECT_MARGIN;

		// Token: 0x0400824E RID: 33358
		[Token(Token = "0x400824E")]
		[FieldOffset(Offset = "0x2C")]
		private static readonly float UV_MARGIN_LOW;

		// Token: 0x0400824F RID: 33359
		[Token(Token = "0x400824F")]
		[FieldOffset(Offset = "0x30")]
		private static readonly float UV_MARGIN_HIGH;

		// Token: 0x04008250 RID: 33360
		[Token(Token = "0x4008250")]
		[FieldOffset(Offset = "0x34")]
		private static readonly float UV_LENGTH;

		// Token: 0x04008251 RID: 33361
		[Token(Token = "0x4008251")]
		[FieldOffset(Offset = "0x38")]
		private static readonly Vector2 DEFAULT_RT_SIZE;

		// Token: 0x04008252 RID: 33362
		[Token(Token = "0x4008252")]
		[FieldOffset(Offset = "0x40")]
		private static readonly int PROP_HG_PLANE_PARAM;

		// Token: 0x04008253 RID: 33363
		[Token(Token = "0x4008253")]
		[FieldOffset(Offset = "0x44")]
		private static readonly int PROP_HG_CROP_UV;

		// Token: 0x04008254 RID: 33364
		[Token(Token = "0x4008254")]
		[FieldOffset(Offset = "0x48")]
		private static readonly int PROP_HG_MAIN_CAMERA_VP;

		// Token: 0x04008255 RID: 33365
		[Token(Token = "0x4008255")]
		[FieldOffset(Offset = "0x4C")]
		private static readonly int PROP_HG_FADE_HEIGHT;

		// Token: 0x04008256 RID: 33366
		[Token(Token = "0x4008256")]
		[FieldOffset(Offset = "0x50")]
		private static readonly int PROP_HG_REFLECT_TEX;

		// Token: 0x04008257 RID: 33367
		[Token(Token = "0x4008257")]
		[FieldOffset(Offset = "0x58")]
		private static readonly string KEYWORD_HG_CROPUV_SURFACE;

		// Token: 0x04008258 RID: 33368
		[Token(Token = "0x4008258")]
		[FieldOffset(Offset = "0x108")]
		private bool m_commandBufferInUse;

		// Token: 0x04008259 RID: 33369
		[Token(Token = "0x4008259")]
		[FieldOffset(Offset = "0x109")]
		private bool m_needRefresh;

		// Token: 0x0400825A RID: 33370
		[Token(Token = "0x400825A")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_ready;

		// Token: 0x0400825B RID: 33371
		[Token(Token = "0x400825B")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_holder;

		// Token: 0x0400825C RID: 33372
		[Token(Token = "0x400825C")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_CropSuccess;

		// Token: 0x0400825D RID: 33373
		[Token(Token = "0x400825D")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_UseCrop;

		// Token: 0x0400825E RID: 33374
		[Token(Token = "0x400825E")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_Initialize;

		// Token: 0x0400825F RID: 33375
		[Token(Token = "0x400825F")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_SetHolder;

		// Token: 0x04008260 RID: 33376
		[Token(Token = "0x4008260")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_CreateRenderTarget;

		// Token: 0x04008261 RID: 33377
		[Token(Token = "0x4008261")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_SetBounds;

		// Token: 0x04008262 RID: 33378
		[Token(Token = "0x4008262")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_RegisterReflectIdx;

		// Token: 0x04008263 RID: 33379
		[Token(Token = "0x4008263")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_SetPlane;

		// Token: 0x04008264 RID: 33380
		[Token(Token = "0x4008264")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_SetCamera;

		// Token: 0x04008265 RID: 33381
		[Token(Token = "0x4008265")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_SetReflectFadeHeight;

		// Token: 0x04008266 RID: 33382
		[Token(Token = "0x4008266")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_BuildShaderMapping;

		// Token: 0x04008267 RID: 33383
		[Token(Token = "0x4008267")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_ReleaseShaderMapping;

		// Token: 0x04008268 RID: 33384
		[Token(Token = "0x4008268")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_ApplyReflectRT;

		// Token: 0x04008269 RID: 33385
		[Token(Token = "0x4008269")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_GetCamera;

		// Token: 0x0400826A RID: 33386
		[Token(Token = "0x400826A")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_RegisterReflectObject;

		// Token: 0x0400826B RID: 33387
		[Token(Token = "0x400826B")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_UnregisterReflectObject;

		// Token: 0x0400826C RID: 33388
		[Token(Token = "0x400826C")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_CleanupReflectObject;

		// Token: 0x0400826D RID: 33389
		[Token(Token = "0x400826D")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_CalculateCachedParams;

		// Token: 0x0400826E RID: 33390
		[Token(Token = "0x400826E")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_RefreshOpaqueCommandBuffer;

		// Token: 0x0400826F RID: 33391
		[Token(Token = "0x400826F")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_RefreshTransparentCommandBuffer;

		// Token: 0x04008270 RID: 33392
		[Token(Token = "0x4008270")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_CreateCommandBuffer;

		// Token: 0x04008271 RID: 33393
		[Token(Token = "0x4008271")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_RemoveCommandBuffer;

		// Token: 0x04008272 RID: 33394
		[Token(Token = "0x4008272")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_DisableReflection;

		// Token: 0x04008273 RID: 33395
		[Token(Token = "0x4008273")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_EnableReflection;

		// Token: 0x04008274 RID: 33396
		[Token(Token = "0x4008274")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_AddCommandBufferSoft;

		// Token: 0x04008275 RID: 33397
		[Token(Token = "0x4008275")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_RemoveCommandBufferSoft;

		// Token: 0x04008276 RID: 33398
		[Token(Token = "0x4008276")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x04008277 RID: 33399
		[Token(Token = "0x4008277")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_EnableCamera;

		// Token: 0x04008278 RID: 33400
		[Token(Token = "0x4008278")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0__ReleaseActiveCamera;

		// Token: 0x04008279 RID: 33401
		[Token(Token = "0x4008279")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0__EnableCandidateCamera;

		// Token: 0x0400827A RID: 33402
		[Token(Token = "0x400827A")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_RefreshCamera;

		// Token: 0x0400827B RID: 33403
		[Token(Token = "0x400827B")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0400827C RID: 33404
		[Token(Token = "0x400827C")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0400827D RID: 33405
		[Token(Token = "0x400827D")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0_CleanUp;

		// Token: 0x0400827E RID: 33406
		[Token(Token = "0x400827E")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0_LateUpdate;

		// Token: 0x0400827F RID: 33407
		[Token(Token = "0x400827F")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04008280 RID: 33408
		[Token(Token = "0x4008280")]
		[FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0_GetReflectMat;

		// Token: 0x04008281 RID: 33409
		[Token(Token = "0x4008281")]
		[FieldOffset(Offset = "0x198")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200162F RID: 5679
		[Token(Token = "0x200162F")]
		public enum ReflectIdx
		{
			// Token: 0x04008283 RID: 33411
			[Token(Token = "0x4008283")]
			REFLECTIDX_NONE = 1,
			// Token: 0x04008284 RID: 33412
			[Token(Token = "0x4008284")]
			REFLECTIDX_0,
			// Token: 0x04008285 RID: 33413
			[Token(Token = "0x4008285")]
			REFLECTIDX_1 = 4,
			// Token: 0x04008286 RID: 33414
			[Token(Token = "0x4008286")]
			REFLECTIDX_2 = 8,
			// Token: 0x04008287 RID: 33415
			[Token(Token = "0x4008287")]
			REFLECTIDX_3 = 16
		}

		// Token: 0x02001630 RID: 5680
		[Token(Token = "0x2001630")]
		public enum CropMode
		{
			// Token: 0x04008289 RID: 33417
			[Token(Token = "0x4008289")]
			CROP_SPHERE,
			// Token: 0x0400828A RID: 33418
			[Token(Token = "0x400828A")]
			CROP_CAPSULE
		}

		// Token: 0x02001631 RID: 5681
		[Token(Token = "0x2001631")]
		[Serializable]
		public class ShaderReplaceMapping
		{
			// Token: 0x060080EF RID: 33007 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60080EF")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ShaderReplaceMapping()
			{
			}

			// Token: 0x0400828B RID: 33419
			[Token(Token = "0x400828B")]
			[FieldOffset(Offset = "0x10")]
			public Shader from;

			// Token: 0x0400828C RID: 33420
			[Token(Token = "0x400828C")]
			[FieldOffset(Offset = "0x18")]
			public Shader to;
		}

		// Token: 0x02001632 RID: 5682
		[Token(Token = "0x2001632")]
		public class CachedReflectMaterial
		{
			// Token: 0x060080F0 RID: 33008 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60080F0")]
			[Address(RVA = "0x2AF91D0", Offset = "0x2AF7DD0", VA = "0x182AF91D0")]
			public void Clear()
			{
			}

			// Token: 0x060080F1 RID: 33009 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60080F1")]
			[Address(RVA = "0x2AF93B0", Offset = "0x2AF7FB0", VA = "0x182AF93B0")]
			public void Register(Material mat)
			{
			}

			// Token: 0x060080F2 RID: 33010 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60080F2")]
			[Address(RVA = "0x2AF9620", Offset = "0x2AF8220", VA = "0x182AF9620")]
			public void UnRegister(Material mat)
			{
			}

			// Token: 0x060080F3 RID: 33011 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60080F3")]
			[Address(RVA = "0x2AF92F0", Offset = "0x2AF7EF0", VA = "0x182AF92F0")]
			public Material GetReflMat(Material mat)
			{
				return null;
			}

			// Token: 0x060080F4 RID: 33012 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60080F4")]
			[Address(RVA = "0x2AF97F0", Offset = "0x2AF83F0", VA = "0x182AF97F0")]
			public CachedReflectMaterial()
			{
			}

			// Token: 0x0400828D RID: 33421
			[Token(Token = "0x400828D")]
			[FieldOffset(Offset = "0x10")]
			private List<Material> m_cachedMaterial;

			// Token: 0x0400828E RID: 33422
			[Token(Token = "0x400828E")]
			[FieldOffset(Offset = "0x18")]
			private Dictionary<Material, int> m_cachedReflectMaterialCount;

			// Token: 0x0400828F RID: 33423
			[Token(Token = "0x400828F")]
			[FieldOffset(Offset = "0x20")]
			private Dictionary<Material, Material> m_cacheMatDic;
		}

		// Token: 0x02001633 RID: 5683
		[Token(Token = "0x2001633")]
		private class ReflectCropManager
		{
			// Token: 0x17000F41 RID: 3905
			// (get) Token: 0x060080F5 RID: 33013 RVA: 0x00038490 File Offset: 0x00036690
			[Token(Token = "0x17000F41")]
			public bool CropSuccess
			{
				[Token(Token = "0x60080F5")]
				[Address(RVA = "0x2B0C420", Offset = "0x2B0B020", VA = "0x182B0C420")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000F42 RID: 3906
			// (get) Token: 0x060080F6 RID: 33014 RVA: 0x000384A8 File Offset: 0x000366A8
			[Token(Token = "0x17000F42")]
			public ReflectCamera.ReflectIdx AssignedID
			{
				[Token(Token = "0x60080F6")]
				[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
				get
				{
					return (ReflectCamera.ReflectIdx)0;
				}
			}

			// Token: 0x17000F43 RID: 3907
			// (get) Token: 0x060080F7 RID: 33015 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000F43")]
			public string OpaqueCBName
			{
				[Token(Token = "0x60080F7")]
				[Address(RVA = "0x2B0C430", Offset = "0x2B0B030", VA = "0x182B0C430")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000F44 RID: 3908
			// (get) Token: 0x060080F8 RID: 33016 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000F44")]
			public string TransparentCBName
			{
				[Token(Token = "0x60080F8")]
				[Address(RVA = "0x2B0C4A0", Offset = "0x2B0B0A0", VA = "0x182B0C4A0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000F45 RID: 3909
			// (get) Token: 0x060080F9 RID: 33017 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000F45")]
			public string CropKeyword
			{
				[Token(Token = "0x60080F9")]
				[Address(RVA = "0x2B0C2C0", Offset = "0x2B0AEC0", VA = "0x182B0C2C0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000F46 RID: 3910
			// (get) Token: 0x060080FA RID: 33018 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000F46")]
			public string CropProp
			{
				[Token(Token = "0x60080FA")]
				[Address(RVA = "0x2B0C370", Offset = "0x2B0AF70", VA = "0x182B0C370")]
				get
				{
					return null;
				}
			}

			// Token: 0x060080FB RID: 33019 RVA: 0x000384C0 File Offset: 0x000366C0
			[Token(Token = "0x60080FB")]
			[Address(RVA = "0x2B0BFF0", Offset = "0x2B0ABF0", VA = "0x182B0BFF0")]
			public bool ApplyReflectID(ReflectCamera camera)
			{
				return default(bool);
			}

			// Token: 0x060080FC RID: 33020 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60080FC")]
			[Address(RVA = "0x2B0C220", Offset = "0x2B0AE20", VA = "0x182B0C220")]
			public void ReleaseReflectID()
			{
			}

			// Token: 0x060080FD RID: 33021 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60080FD")]
			[Address(RVA = "0x161CFD0", Offset = "0x161BBD0", VA = "0x18161CFD0")]
			public ReflectCropManager()
			{
			}

			// Token: 0x04008290 RID: 33424
			[Token(Token = "0x4008290")]
			[FieldOffset(Offset = "0x10")]
			private ReflectCamera.ReflectIdx assignedID;
		}
	}
}
