using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000054 RID: 84
	[Token(Token = "0x2000054")]
	[UsedByNativeCode]
	[NativeHeader("Runtime/Shaders/Shader.h")]
	[RequireComponent(typeof(Transform))]
	[NativeHeader("Runtime/Graphics/RenderTexture.h")]
	[NativeHeader("Runtime/Camera/Camera.h")]
	[NativeHeader("Runtime/Camera/RenderManager.h")]
	[NativeHeader("Runtime/GfxDevice/GfxDeviceTypes.h")]
	[NativeHeader("Runtime/Misc/GameObjectUtility.h")]
	[NativeHeader("Runtime/Graphics/CommandBuffer/RenderingCommandBuffer.h")]
	public sealed class Camera : Behaviour
	{
		// Token: 0x060000F2 RID: 242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x59165F0", Offset = "0x59151F0", VA = "0x1859165F0")]
		public Camera()
		{
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000F3 RID: 243
		// (set) Token: 0x060000F4 RID: 244
		[Token(Token = "0x17000031")]
		[NativeProperty("Near")]
		public extern float nearClipPlane { [Token(Token = "0x60000F3")] [Address(RVA = "0x5922DF0", Offset = "0x59219F0", VA = "0x185922DF0")] [MethodImpl(4096)] get; [Token(Token = "0x60000F4")] [Address(RVA = "0x5923A50", Offset = "0x5922650", VA = "0x185923A50")] [MethodImpl(4096)] set; }

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000F5 RID: 245
		// (set) Token: 0x060000F6 RID: 246
		[Token(Token = "0x17000032")]
		[NativeProperty("Far")]
		public extern float farClipPlane { [Token(Token = "0x60000F5")] [Address(RVA = "0x5922D40", Offset = "0x5921940", VA = "0x185922D40")] [MethodImpl(4096)] get; [Token(Token = "0x60000F6")] [Address(RVA = "0x5923960", Offset = "0x5922560", VA = "0x185923960")] [MethodImpl(4096)] set; }

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000F7 RID: 247
		// (set) Token: 0x060000F8 RID: 248
		[Token(Token = "0x17000033")]
		[NativeProperty("VerticalFieldOfView")]
		public extern float fieldOfView { [Token(Token = "0x60000F7")] [Address(RVA = "0x5922D80", Offset = "0x5921980", VA = "0x185922D80")] [MethodImpl(4096)] get; [Token(Token = "0x60000F8")] [Address(RVA = "0x59239B0", Offset = "0x59225B0", VA = "0x1859239B0")] [MethodImpl(4096)] set; }

		// Token: 0x17000034 RID: 52
		// (set) Token: 0x060000F9 RID: 249
		[Token(Token = "0x17000034")]
		public extern RenderingPath renderingPath { [Token(Token = "0x60000F9")] [Address(RVA = "0x5923DC0", Offset = "0x59229C0", VA = "0x185923DC0")] [MethodImpl(4096)] set; }

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000FA RID: 250
		[Token(Token = "0x17000035")]
		public extern RenderingPath actualRenderingPath { [Token(Token = "0x60000FA")] [Address(RVA = "0x59229B0", Offset = "0x59215B0", VA = "0x1859229B0")] [NativeName("CalculateRenderingPath")] [MethodImpl(4096)] get; }

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000FB RID: 251
		// (set) Token: 0x060000FC RID: 252
		[Token(Token = "0x17000036")]
		public extern bool allowHDR { [Token(Token = "0x60000FB")] [Address(RVA = "0x5922A30", Offset = "0x5921630", VA = "0x185922A30")] [MethodImpl(4096)] get; [Token(Token = "0x60000FC")] [Address(RVA = "0x59235D0", Offset = "0x59221D0", VA = "0x1859235D0")] [MethodImpl(4096)] set; }

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000FD RID: 253
		// (set) Token: 0x060000FE RID: 254
		[Token(Token = "0x17000037")]
		public extern bool allowMSAA { [Token(Token = "0x60000FD")] [Address(RVA = "0x5922A70", Offset = "0x5921670", VA = "0x185922A70")] [MethodImpl(4096)] get; [Token(Token = "0x60000FE")] [Address(RVA = "0x5923620", Offset = "0x5922220", VA = "0x185923620")] [MethodImpl(4096)] set; }

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000FF RID: 255
		// (set) Token: 0x06000100 RID: 256
		[Token(Token = "0x17000038")]
		public extern bool scalableRT { [Token(Token = "0x60000FF")] [Address(RVA = "0x5923160", Offset = "0x5921D60", VA = "0x185923160")] [MethodImpl(4096)] get; [Token(Token = "0x6000100")] [Address(RVA = "0x5923E00", Offset = "0x5922A00", VA = "0x185923E00")] [MethodImpl(4096)] set; }

		// Token: 0x17000039 RID: 57
		// (set) Token: 0x06000101 RID: 257
		[Token(Token = "0x17000039")]
		public extern bool depthCopy { [Token(Token = "0x6000101")] [Address(RVA = "0x5923880", Offset = "0x5922480", VA = "0x185923880")] [MethodImpl(4096)] set; }

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000102 RID: 258
		[Token(Token = "0x1700003A")]
		public extern bool allowDynamicResolution { [Token(Token = "0x6000102")] [Address(RVA = "0x59229F0", Offset = "0x59215F0", VA = "0x1859229F0")] [MethodImpl(4096)] get; }

		// Token: 0x1700003B RID: 59
		// (set) Token: 0x06000103 RID: 259
		[Token(Token = "0x1700003B")]
		[NativeProperty("ForceIntoRT")]
		public extern bool forceIntoRenderTexture { [Token(Token = "0x6000103")] [Address(RVA = "0x5923A00", Offset = "0x5922600", VA = "0x185923A00")] [MethodImpl(4096)] set; }

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000104 RID: 260
		// (set) Token: 0x06000105 RID: 261
		[Token(Token = "0x1700003C")]
		public extern float orthographicSize { [Token(Token = "0x6000104")] [Address(RVA = "0x5922E70", Offset = "0x5921A70", VA = "0x185922E70")] [MethodImpl(4096)] get; [Token(Token = "0x6000105")] [Address(RVA = "0x5923B40", Offset = "0x5922740", VA = "0x185923B40")] [MethodImpl(4096)] set; }

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000106 RID: 262
		// (set) Token: 0x06000107 RID: 263
		[Token(Token = "0x1700003D")]
		public extern bool orthographic { [Token(Token = "0x6000106")] [Address(RVA = "0x5922EB0", Offset = "0x5921AB0", VA = "0x185922EB0")] [MethodImpl(4096)] get; [Token(Token = "0x6000107")] [Address(RVA = "0x5923B90", Offset = "0x5922790", VA = "0x185923B90")] [MethodImpl(4096)] set; }

		// Token: 0x1700003E RID: 62
		// (set) Token: 0x06000108 RID: 264
		[Token(Token = "0x1700003E")]
		public extern TransparencySortMode transparencySortMode { [Token(Token = "0x6000108")] [Address(RVA = "0x5923F30", Offset = "0x5922B30", VA = "0x185923F30")] [MethodImpl(4096)] set; }

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000109 RID: 265
		// (set) Token: 0x0600010A RID: 266
		[Token(Token = "0x1700003F")]
		public extern float depth { [Token(Token = "0x6000109")] [Address(RVA = "0x5922CC0", Offset = "0x59218C0", VA = "0x185922CC0")] [MethodImpl(4096)] get; [Token(Token = "0x600010A")] [Address(RVA = "0x5923910", Offset = "0x5922510", VA = "0x185923910")] [MethodImpl(4096)] set; }

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600010B RID: 267
		// (set) Token: 0x0600010C RID: 268
		[Token(Token = "0x17000040")]
		public extern float aspect { [Token(Token = "0x600010B")] [Address(RVA = "0x5922AB0", Offset = "0x59216B0", VA = "0x185922AB0")] [MethodImpl(4096)] get; [Token(Token = "0x600010C")] [Address(RVA = "0x5923670", Offset = "0x5922270", VA = "0x185923670")] [MethodImpl(4096)] set; }

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600010D RID: 269 RVA: 0x00002580 File Offset: 0x00000780
		[Token(Token = "0x17000041")]
		public Vector3 velocity
		{
			[Token(Token = "0x600010D")]
			[Address(RVA = "0x59234D0", Offset = "0x59220D0", VA = "0x1859234D0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600010E RID: 270
		// (set) Token: 0x0600010F RID: 271
		[Token(Token = "0x17000042")]
		public extern int cullingMask { [Token(Token = "0x600010E")] [Address(RVA = "0x5922C10", Offset = "0x5921810", VA = "0x185922C10")] [MethodImpl(4096)] get; [Token(Token = "0x600010F")] [Address(RVA = "0x59237A0", Offset = "0x59223A0", VA = "0x1859237A0")] [MethodImpl(4096)] set; }

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000110 RID: 272
		[Token(Token = "0x17000043")]
		public extern int eventMask { [Token(Token = "0x6000110")] [Address(RVA = "0x5922D00", Offset = "0x5921900", VA = "0x185922D00")] [MethodImpl(4096)] get; }

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000111 RID: 273
		[Token(Token = "0x17000044")]
		public extern CameraType cameraType { [Token(Token = "0x6000111")] [Address(RVA = "0x5922B90", Offset = "0x5921790", VA = "0x185922B90")] [MethodImpl(4096)] get; }

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000112 RID: 274
		// (set) Token: 0x06000113 RID: 275
		[Token(Token = "0x17000045")]
		public extern bool useOcclusionCulling { [Token(Token = "0x6000112")] [Address(RVA = "0x5923400", Offset = "0x5922000", VA = "0x185923400")] [MethodImpl(4096)] get; [Token(Token = "0x6000113")] [Address(RVA = "0x5923FC0", Offset = "0x5922BC0", VA = "0x185923FC0")] [MethodImpl(4096)] set; }

		// Token: 0x17000046 RID: 70
		// (set) Token: 0x06000114 RID: 276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000046")]
		public Matrix4x4 cullingMatrix
		{
			[Token(Token = "0x6000114")]
			[Address(RVA = "0x5923830", Offset = "0x5922430", VA = "0x185923830")]
			set
			{
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000115 RID: 277 RVA: 0x00002598 File Offset: 0x00000798
		// (set) Token: 0x06000116 RID: 278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000047")]
		public Color backgroundColor
		{
			[Token(Token = "0x6000115")]
			[Address(RVA = "0x5922B40", Offset = "0x5921740", VA = "0x185922B40")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000116")]
			[Address(RVA = "0x5923710", Offset = "0x5922310", VA = "0x185923710")]
			set
			{
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000117 RID: 279
		// (set) Token: 0x06000118 RID: 280
		[Token(Token = "0x17000048")]
		public extern CameraClearFlags clearFlags { [Token(Token = "0x6000117")] [Address(RVA = "0x5922BD0", Offset = "0x59217D0", VA = "0x185922BD0")] [MethodImpl(4096)] get; [Token(Token = "0x6000118")] [Address(RVA = "0x5923760", Offset = "0x5922360", VA = "0x185923760")] [MethodImpl(4096)] set; }

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000119 RID: 281
		// (set) Token: 0x0600011A RID: 282
		[Token(Token = "0x17000049")]
		public extern DepthTextureMode depthTextureMode { [Token(Token = "0x6000119")] [Address(RVA = "0x5922C80", Offset = "0x5921880", VA = "0x185922C80")] [MethodImpl(4096)] get; [Token(Token = "0x600011A")] [Address(RVA = "0x59238D0", Offset = "0x59224D0", VA = "0x1859238D0")] [MethodImpl(4096)] set; }

		// Token: 0x0600011B RID: 283
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x5922420", Offset = "0x5921020", VA = "0x185922420")]
		[MethodImpl(4096)]
		public extern void SetReplacementShader(Shader shader, string replacementTag);

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600011C RID: 284
		// (set) Token: 0x0600011D RID: 285
		[Token(Token = "0x1700004A")]
		public extern bool usePhysicalProperties { [Token(Token = "0x600011C")] [Address(RVA = "0x5923440", Offset = "0x5922040", VA = "0x185923440")] [MethodImpl(4096)] get; [Token(Token = "0x600011D")] [Address(RVA = "0x5924010", Offset = "0x5922C10", VA = "0x185924010")] [MethodImpl(4096)] set; }

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600011E RID: 286 RVA: 0x000025B0 File Offset: 0x000007B0
		// (set) Token: 0x0600011F RID: 287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004B")]
		[NativeProperty("NormalizedViewportRect")]
		public Rect rect
		{
			[Token(Token = "0x600011E")]
			[Address(RVA = "0x5923110", Offset = "0x5921D10", VA = "0x185923110")]
			get
			{
				return default(Rect);
			}
			[Token(Token = "0x600011F")]
			[Address(RVA = "0x5923D70", Offset = "0x5922970", VA = "0x185923D70")]
			set
			{
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000120 RID: 288 RVA: 0x000025C8 File Offset: 0x000007C8
		// (set) Token: 0x06000121 RID: 289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004C")]
		[NativeProperty("ScreenViewportRect")]
		public Rect pixelRect
		{
			[Token(Token = "0x6000120")]
			[Address(RVA = "0x5922F80", Offset = "0x5921B80", VA = "0x185922F80")]
			get
			{
				return default(Rect);
			}
			[Token(Token = "0x6000121")]
			[Address(RVA = "0x5923C30", Offset = "0x5922830", VA = "0x185923C30")]
			set
			{
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000122 RID: 290
		[Token(Token = "0x1700004D")]
		public extern int pixelWidth { [Token(Token = "0x6000122")] [Address(RVA = "0x5922FD0", Offset = "0x5921BD0", VA = "0x185922FD0")] [FreeFunction("CameraScripting::GetPixelWidth", HasExplicitThis = true)] [MethodImpl(4096)] get; }

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000123 RID: 291
		[Token(Token = "0x1700004E")]
		public extern int pixelHeight { [Token(Token = "0x6000123")] [Address(RVA = "0x5922EF0", Offset = "0x5921AF0", VA = "0x185922EF0")] [FreeFunction("CameraScripting::GetPixelHeight", HasExplicitThis = true)] [MethodImpl(4096)] get; }

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000124 RID: 292
		[Token(Token = "0x1700004F")]
		public extern int scaledPixelWidth { [Token(Token = "0x6000124")] [Address(RVA = "0x59231E0", Offset = "0x5921DE0", VA = "0x1859231E0")] [FreeFunction("CameraScripting::GetScaledPixelWidth", HasExplicitThis = true)] [MethodImpl(4096)] get; }

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000125 RID: 293
		[Token(Token = "0x17000050")]
		public extern int scaledPixelHeight { [Token(Token = "0x6000125")] [Address(RVA = "0x59231A0", Offset = "0x5921DA0", VA = "0x1859231A0")] [FreeFunction("CameraScripting::GetScaledPixelHeight", HasExplicitThis = true)] [MethodImpl(4096)] get; }

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000126 RID: 294
		// (set) Token: 0x06000127 RID: 295
		[Token(Token = "0x17000051")]
		public extern RenderTexture targetTexture { [Token(Token = "0x6000126")] [Address(RVA = "0x59233C0", Offset = "0x5921FC0", VA = "0x1859233C0")] [MethodImpl(4096)] get; [Token(Token = "0x6000127")] [Address(RVA = "0x5923EE0", Offset = "0x5922AE0", VA = "0x185923EE0")] [MethodImpl(4096)] set; }

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000128 RID: 296
		[Token(Token = "0x17000052")]
		public extern RenderTexture nonScalableTargetTexture { [Token(Token = "0x6000128")] [Address(RVA = "0x5922E30", Offset = "0x5921A30", VA = "0x185922E30")] [MethodImpl(4096)] get; }

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000129 RID: 297 RVA: 0x000025E0 File Offset: 0x000007E0
		// (set) Token: 0x0600012A RID: 298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000053")]
		public Vector2 targetResolusion
		{
			[Token(Token = "0x6000129")]
			[Address(RVA = "0x5923370", Offset = "0x5921F70", VA = "0x185923370")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600012A")]
			[Address(RVA = "0x5923EA0", Offset = "0x5922AA0", VA = "0x185923EA0")]
			set
			{
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600012B RID: 299
		[Token(Token = "0x17000054")]
		public extern int targetDisplay { [Token(Token = "0x600012B")] [Address(RVA = "0x59232E0", Offset = "0x5921EE0", VA = "0x1859232E0")] [MethodImpl(4096)] get; }

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600012C RID: 300 RVA: 0x000025F8 File Offset: 0x000007F8
		// (set) Token: 0x0600012D RID: 301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000055")]
		public Matrix4x4 worldToCameraMatrix
		{
			[Token(Token = "0x600012C")]
			[Address(RVA = "0x5923570", Offset = "0x5922170", VA = "0x185923570")]
			get
			{
				return default(Matrix4x4);
			}
			[Token(Token = "0x600012D")]
			[Address(RVA = "0x59240B0", Offset = "0x5922CB0", VA = "0x1859240B0")]
			set
			{
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600012E RID: 302 RVA: 0x00002610 File Offset: 0x00000810
		// (set) Token: 0x0600012F RID: 303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000056")]
		public Matrix4x4 projectionMatrix
		{
			[Token(Token = "0x600012E")]
			[Address(RVA = "0x5923060", Offset = "0x5921C60", VA = "0x185923060")]
			get
			{
				return default(Matrix4x4);
			}
			[Token(Token = "0x600012F")]
			[Address(RVA = "0x5923CD0", Offset = "0x59228D0", VA = "0x185923CD0")]
			set
			{
			}
		}

		// Token: 0x17000057 RID: 87
		// (set) Token: 0x06000130 RID: 304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000057")]
		public Matrix4x4 nonJitteredProjectionMatrix
		{
			[Token(Token = "0x6000130")]
			[Address(RVA = "0x5923AF0", Offset = "0x59226F0", VA = "0x185923AF0")]
			set
			{
			}
		}

		// Token: 0x17000058 RID: 88
		// (set) Token: 0x06000131 RID: 305
		[Token(Token = "0x17000058")]
		[NativeProperty("UseJitteredProjectionMatrixForTransparent")]
		public extern bool useJitteredProjectionMatrixForTransparentRendering { [Token(Token = "0x6000131")] [Address(RVA = "0x5923F70", Offset = "0x5922B70", VA = "0x185923F70")] [MethodImpl(4096)] set; }

		// Token: 0x06000132 RID: 306
		[Token(Token = "0x6000132")]
		[Address(RVA = "0x5921F30", Offset = "0x5920B30", VA = "0x185921F30")]
		[MethodImpl(4096)]
		public extern void ResetProjectionMatrix();

		// Token: 0x06000133 RID: 307 RVA: 0x00002628 File Offset: 0x00000828
		[Token(Token = "0x6000133")]
		[Address(RVA = "0x5921730", Offset = "0x5920330", VA = "0x185921730")]
		[FreeFunction("CameraScripting::CalculateObliqueMatrix", HasExplicitThis = true)]
		public Matrix4x4 CalculateObliqueMatrix(Vector4 clipPlane)
		{
			return default(Matrix4x4);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00002640 File Offset: 0x00000840
		[Token(Token = "0x6000134")]
		[Address(RVA = "0x59227D0", Offset = "0x59213D0", VA = "0x1859227D0")]
		public Vector3 WorldToScreenPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye)
		{
			return default(Vector3);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00002658 File Offset: 0x00000858
		[Token(Token = "0x6000135")]
		[Address(RVA = "0x5922940", Offset = "0x5921540", VA = "0x185922940")]
		public Vector3 WorldToViewportPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye)
		{
			return default(Vector3);
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00002670 File Offset: 0x00000870
		[Token(Token = "0x6000136")]
		[Address(RVA = "0x5922660", Offset = "0x5921260", VA = "0x185922660")]
		public Vector3 ViewportToWorldPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye)
		{
			return default(Vector3);
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00002688 File Offset: 0x00000888
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x5922320", Offset = "0x5920F20", VA = "0x185922320")]
		public Vector3 ScreenToWorldPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye)
		{
			return default(Vector3);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x000026A0 File Offset: 0x000008A0
		[Token(Token = "0x6000138")]
		[Address(RVA = "0x5922740", Offset = "0x5921340", VA = "0x185922740")]
		public Vector3 WorldToScreenPoint(Vector3 position)
		{
			return default(Vector3);
		}

		// Token: 0x06000139 RID: 313 RVA: 0x000026B8 File Offset: 0x000008B8
		[Token(Token = "0x6000139")]
		[Address(RVA = "0x59228B0", Offset = "0x59214B0", VA = "0x1859228B0")]
		public Vector3 WorldToViewportPoint(Vector3 position)
		{
			return default(Vector3);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x000026D0 File Offset: 0x000008D0
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x59225D0", Offset = "0x59211D0", VA = "0x1859225D0")]
		public Vector3 ViewportToWorldPoint(Vector3 position)
		{
			return default(Vector3);
		}

		// Token: 0x0600013B RID: 315 RVA: 0x000026E8 File Offset: 0x000008E8
		[Token(Token = "0x600013B")]
		[Address(RVA = "0x5922390", Offset = "0x5920F90", VA = "0x185922390")]
		public Vector3 ScreenToWorldPoint(Vector3 position)
		{
			return default(Vector3);
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00002700 File Offset: 0x00000900
		[Token(Token = "0x600013C")]
		[Address(RVA = "0x5922250", Offset = "0x5920E50", VA = "0x185922250")]
		public Vector3 ScreenToViewportPoint(Vector3 position)
		{
			return default(Vector3);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00002718 File Offset: 0x00000918
		[Token(Token = "0x600013D")]
		[Address(RVA = "0x5922180", Offset = "0x5920D80", VA = "0x185922180")]
		private Ray ScreenPointToRay(Vector2 pos, Camera.MonoOrStereoscopicEye eye)
		{
			return default(Ray);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00002730 File Offset: 0x00000930
		[Token(Token = "0x600013E")]
		[Address(RVA = "0x59220D0", Offset = "0x5920CD0", VA = "0x1859220D0")]
		public Ray ScreenPointToRay(Vector3 pos, Camera.MonoOrStereoscopicEye eye)
		{
			return default(Ray);
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00002748 File Offset: 0x00000948
		[Token(Token = "0x600013F")]
		[Address(RVA = "0x5922020", Offset = "0x5920C20", VA = "0x185922020")]
		public Ray ScreenPointToRay(Vector3 pos)
		{
			return default(Ray);
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000140")]
		[Address(RVA = "0x5921520", Offset = "0x5920120", VA = "0x185921520")]
		[FreeFunction("CameraScripting::CalculateViewportRayVectors", HasExplicitThis = true)]
		private void CalculateFrustumCornersInternal(Rect viewport, float z, Camera.MonoOrStereoscopicEye eye, [Out] Vector3[] outCorners)
		{
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000141")]
		[Address(RVA = "0x5921590", Offset = "0x5920190", VA = "0x185921590")]
		public void CalculateFrustumCorners(Rect viewport, float z, Camera.MonoOrStereoscopicEye eye, Vector3[] outCorners)
		{
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000142 RID: 322
		[Token(Token = "0x17000059")]
		public static extern Camera main { [Token(Token = "0x6000142")] [Address(RVA = "0x5922DC0", Offset = "0x59219C0", VA = "0x185922DC0")] [FreeFunction("FindMainCamera")] [MethodImpl(4096)] get; }

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000143 RID: 323
		[Token(Token = "0x1700005A")]
		public static extern Camera current { [Token(Token = "0x6000143")] [Address(RVA = "0x5922C50", Offset = "0x5921850", VA = "0x185922C50")] [FreeFunction("GetCurrentCameraPPtr")] [MethodImpl(4096)] get; }

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000144 RID: 324
		[Token(Token = "0x1700005B")]
		public extern bool stereoEnabled { [Token(Token = "0x6000144")] [Address(RVA = "0x5923260", Offset = "0x5921E60", VA = "0x185923260")] [NativeMethod("GetStereoEnabledForBuiltInOrSRP")] [MethodImpl(4096)] get; }

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000145 RID: 325
		[Token(Token = "0x1700005C")]
		public extern StereoTargetEyeMask stereoTargetEye { [Token(Token = "0x6000145")] [Address(RVA = "0x59232A0", Offset = "0x5921EA0", VA = "0x1859232A0")] [MethodImpl(4096)] get; }

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000146 RID: 326
		[Token(Token = "0x1700005D")]
		public extern Camera.MonoOrStereoscopicEye stereoActiveEye { [Token(Token = "0x6000146")] [Address(RVA = "0x5923220", Offset = "0x5921E20", VA = "0x185923220")] [FreeFunction("CameraScripting::GetStereoActiveEye", HasExplicitThis = true)] [MethodImpl(4096)] get; }

		// Token: 0x06000147 RID: 327 RVA: 0x00002760 File Offset: 0x00000960
		[Token(Token = "0x6000147")]
		[Address(RVA = "0x5921B00", Offset = "0x5920700", VA = "0x185921B00")]
		public Matrix4x4 GetStereoNonJitteredProjectionMatrix(Camera.StereoscopicEye eye)
		{
			return default(Matrix4x4);
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00002778 File Offset: 0x00000978
		[Token(Token = "0x6000148")]
		[Address(RVA = "0x5921C80", Offset = "0x5920880", VA = "0x185921C80")]
		[FreeFunction("CameraScripting::GetStereoViewMatrix", HasExplicitThis = true)]
		public Matrix4x4 GetStereoViewMatrix(Camera.StereoscopicEye eye)
		{
			return default(Matrix4x4);
		}

		// Token: 0x06000149 RID: 329
		[Token(Token = "0x6000149")]
		[Address(RVA = "0x59217F0", Offset = "0x59203F0", VA = "0x1859217F0")]
		[MethodImpl(4096)]
		public extern void CopyStereoDeviceProjectionMatrixToNonJittered(Camera.StereoscopicEye eye);

		// Token: 0x0600014A RID: 330 RVA: 0x00002790 File Offset: 0x00000990
		[Token(Token = "0x600014A")]
		[Address(RVA = "0x5921BC0", Offset = "0x59207C0", VA = "0x185921BC0")]
		[FreeFunction("CameraScripting::GetStereoProjectionMatrix", HasExplicitThis = true)]
		public Matrix4x4 GetStereoProjectionMatrix(Camera.StereoscopicEye eye)
		{
			return default(Matrix4x4);
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600014B")]
		[Address(RVA = "0x59224D0", Offset = "0x59210D0", VA = "0x1859224D0")]
		public void SetStereoProjectionMatrix(Camera.StereoscopicEye eye, Matrix4x4 matrix)
		{
		}

		// Token: 0x0600014C RID: 332
		[Token(Token = "0x600014C")]
		[Address(RVA = "0x5921F70", Offset = "0x5920B70", VA = "0x185921F70")]
		[MethodImpl(4096)]
		public extern void ResetStereoProjectionMatrices();

		// Token: 0x0600014D RID: 333
		[Token(Token = "0x600014D")]
		[Address(RVA = "0x5921950", Offset = "0x5920550", VA = "0x185921950")]
		[FreeFunction("CameraScripting::GetAllCamerasCount")]
		[MethodImpl(4096)]
		private static extern int GetAllCamerasCount();

		// Token: 0x0600014E RID: 334
		[Token(Token = "0x600014E")]
		[Address(RVA = "0x5921980", Offset = "0x5920580", VA = "0x185921980")]
		[FreeFunction("CameraScripting::GetAllCameras")]
		[MethodImpl(4096)]
		private static extern int GetAllCamerasImpl([NotNull("ArgumentNullException")] [Out] Camera[] cam);

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600014F RID: 335 RVA: 0x000027A8 File Offset: 0x000009A8
		[Token(Token = "0x1700005E")]
		public static int allCamerasCount
		{
			[Token(Token = "0x600014F")]
			[Address(RVA = "0x5921950", Offset = "0x5920550", VA = "0x185921950")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000150 RID: 336 RVA: 0x000027C0 File Offset: 0x000009C0
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x59219C0", Offset = "0x59205C0", VA = "0x1859219C0")]
		public static int GetAllCameras(Camera[] cameras)
		{
			return 0;
		}

		// Token: 0x06000151 RID: 337
		[Token(Token = "0x6000151")]
		[Address(RVA = "0x5921EF0", Offset = "0x5920AF0", VA = "0x185921EF0")]
		[FreeFunction("CameraScripting::Render", HasExplicitThis = true)]
		[MethodImpl(4096)]
		public extern void Render();

		// Token: 0x06000152 RID: 338
		[Token(Token = "0x6000152")]
		[Address(RVA = "0x5921E90", Offset = "0x5920A90", VA = "0x185921E90")]
		[FreeFunction("CameraScripting::RenderWithShader", HasExplicitThis = true)]
		[MethodImpl(4096)]
		public extern void RenderWithShader(Shader shader, string replacementTag);

		// Token: 0x06000153 RID: 339
		[Token(Token = "0x6000153")]
		[Address(RVA = "0x5922520", Offset = "0x5921120", VA = "0x185922520")]
		[FreeFunction("CameraScripting::SetupCurrent")]
		[MethodImpl(4096)]
		public static extern void SetupCurrent(Camera cur);

		// Token: 0x06000154 RID: 340
		[Token(Token = "0x6000154")]
		[Address(RVA = "0x59217A0", Offset = "0x59203A0", VA = "0x1859217A0")]
		[FreeFunction("CameraScripting::CopyFrom", HasExplicitThis = true)]
		[MethodImpl(4096)]
		public extern void CopyFrom(Camera other);

		// Token: 0x06000155 RID: 341
		[Token(Token = "0x6000155")]
		[Address(RVA = "0x5921310", Offset = "0x591FF10", VA = "0x185921310")]
		[NativeName("AddCommandBuffer")]
		[MethodImpl(4096)]
		private extern void AddCommandBufferImpl(CameraEvent evt, [NotNull("ArgumentNullException")] CommandBuffer buffer);

		// Token: 0x06000156 RID: 342
		[Token(Token = "0x6000156")]
		[Address(RVA = "0x5921CF0", Offset = "0x59208F0", VA = "0x185921CF0")]
		[NativeName("RemoveCommandBuffer")]
		[MethodImpl(4096)]
		private extern void RemoveCommandBufferImpl(CameraEvent evt, [NotNull("ArgumentNullException")] CommandBuffer buffer);

		// Token: 0x06000157 RID: 343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000157")]
		[Address(RVA = "0x5921360", Offset = "0x591FF60", VA = "0x185921360")]
		public void AddCommandBuffer(CameraEvent evt, CommandBuffer buffer)
		{
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000158")]
		[Address(RVA = "0x5921D40", Offset = "0x5920940", VA = "0x185921D40")]
		public void RemoveCommandBuffer(CameraEvent evt, CommandBuffer buffer)
		{
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000159")]
		[Address(RVA = "0x5921890", Offset = "0x5920490", VA = "0x185921890")]
		[RequiredByNativeCode]
		private static void FireOnPreCull(Camera cam)
		{
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015A")]
		[Address(RVA = "0x59218F0", Offset = "0x59204F0", VA = "0x1859218F0")]
		[RequiredByNativeCode]
		private static void FireOnPreRender(Camera cam)
		{
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015B")]
		[Address(RVA = "0x5921830", Offset = "0x5920430", VA = "0x185921830")]
		[RequiredByNativeCode]
		private static void FireOnPostRender(Camera cam)
		{
		}

		// Token: 0x0600015C RID: 348
		[Token(Token = "0x600015C")]
		[Address(RVA = "0x5923480", Offset = "0x5922080", VA = "0x185923480")]
		[MethodImpl(4096)]
		private extern void get_velocity_Injected(out Vector3 ret);

		// Token: 0x0600015D RID: 349
		[Token(Token = "0x600015D")]
		[Address(RVA = "0x59237E0", Offset = "0x59223E0", VA = "0x1859237E0")]
		[MethodImpl(4096)]
		private extern void set_cullingMatrix_Injected(ref Matrix4x4 value);

		// Token: 0x0600015E RID: 350
		[Token(Token = "0x600015E")]
		[Address(RVA = "0x5922AF0", Offset = "0x59216F0", VA = "0x185922AF0")]
		[MethodImpl(4096)]
		private extern void get_backgroundColor_Injected(out Color ret);

		// Token: 0x0600015F RID: 351
		[Token(Token = "0x600015F")]
		[Address(RVA = "0x59236C0", Offset = "0x59222C0", VA = "0x1859236C0")]
		[MethodImpl(4096)]
		private extern void set_backgroundColor_Injected(ref Color value);

		// Token: 0x06000160 RID: 352
		[Token(Token = "0x6000160")]
		[Address(RVA = "0x59230C0", Offset = "0x5921CC0", VA = "0x1859230C0")]
		[MethodImpl(4096)]
		private extern void get_rect_Injected(out Rect ret);

		// Token: 0x06000161 RID: 353
		[Token(Token = "0x6000161")]
		[Address(RVA = "0x5923D20", Offset = "0x5922920", VA = "0x185923D20")]
		[MethodImpl(4096)]
		private extern void set_rect_Injected(ref Rect value);

		// Token: 0x06000162 RID: 354
		[Token(Token = "0x6000162")]
		[Address(RVA = "0x5922F30", Offset = "0x5921B30", VA = "0x185922F30")]
		[MethodImpl(4096)]
		private extern void get_pixelRect_Injected(out Rect ret);

		// Token: 0x06000163 RID: 355
		[Token(Token = "0x6000163")]
		[Address(RVA = "0x5923BE0", Offset = "0x59227E0", VA = "0x185923BE0")]
		[MethodImpl(4096)]
		private extern void set_pixelRect_Injected(ref Rect value);

		// Token: 0x06000164 RID: 356
		[Token(Token = "0x6000164")]
		[Address(RVA = "0x5923320", Offset = "0x5921F20", VA = "0x185923320")]
		[MethodImpl(4096)]
		private extern void get_targetResolusion_Injected(out Vector2 ret);

		// Token: 0x06000165 RID: 357
		[Token(Token = "0x6000165")]
		[Address(RVA = "0x5923E50", Offset = "0x5922A50", VA = "0x185923E50")]
		[MethodImpl(4096)]
		private extern void set_targetResolusion_Injected(ref Vector2 value);

		// Token: 0x06000166 RID: 358
		[Token(Token = "0x6000166")]
		[Address(RVA = "0x5923520", Offset = "0x5922120", VA = "0x185923520")]
		[MethodImpl(4096)]
		private extern void get_worldToCameraMatrix_Injected(out Matrix4x4 ret);

		// Token: 0x06000167 RID: 359
		[Token(Token = "0x6000167")]
		[Address(RVA = "0x5924060", Offset = "0x5922C60", VA = "0x185924060")]
		[MethodImpl(4096)]
		private extern void set_worldToCameraMatrix_Injected(ref Matrix4x4 value);

		// Token: 0x06000168 RID: 360
		[Token(Token = "0x6000168")]
		[Address(RVA = "0x5923010", Offset = "0x5921C10", VA = "0x185923010")]
		[MethodImpl(4096)]
		private extern void get_projectionMatrix_Injected(out Matrix4x4 ret);

		// Token: 0x06000169 RID: 361
		[Token(Token = "0x6000169")]
		[Address(RVA = "0x5923C80", Offset = "0x5922880", VA = "0x185923C80")]
		[MethodImpl(4096)]
		private extern void set_projectionMatrix_Injected(ref Matrix4x4 value);

		// Token: 0x0600016A RID: 362
		[Token(Token = "0x600016A")]
		[Address(RVA = "0x5923AA0", Offset = "0x59226A0", VA = "0x185923AA0")]
		[MethodImpl(4096)]
		private extern void set_nonJitteredProjectionMatrix_Injected(ref Matrix4x4 value);

		// Token: 0x0600016B RID: 363
		[Token(Token = "0x600016B")]
		[Address(RVA = "0x59216D0", Offset = "0x59202D0", VA = "0x1859216D0")]
		[MethodImpl(4096)]
		private extern void CalculateObliqueMatrix_Injected(ref Vector4 clipPlane, out Matrix4x4 ret);

		// Token: 0x0600016C RID: 364
		[Token(Token = "0x600016C")]
		[Address(RVA = "0x59226D0", Offset = "0x59212D0", VA = "0x1859226D0")]
		[MethodImpl(4096)]
		private extern void WorldToScreenPoint_Injected(ref Vector3 position, Camera.MonoOrStereoscopicEye eye, out Vector3 ret);

		// Token: 0x0600016D RID: 365
		[Token(Token = "0x600016D")]
		[Address(RVA = "0x5922840", Offset = "0x5921440", VA = "0x185922840")]
		[MethodImpl(4096)]
		private extern void WorldToViewportPoint_Injected(ref Vector3 position, Camera.MonoOrStereoscopicEye eye, out Vector3 ret);

		// Token: 0x0600016E RID: 366
		[Token(Token = "0x600016E")]
		[Address(RVA = "0x5922560", Offset = "0x5921160", VA = "0x185922560")]
		[MethodImpl(4096)]
		private extern void ViewportToWorldPoint_Injected(ref Vector3 position, Camera.MonoOrStereoscopicEye eye, out Vector3 ret);

		// Token: 0x0600016F RID: 367
		[Token(Token = "0x600016F")]
		[Address(RVA = "0x59222B0", Offset = "0x5920EB0", VA = "0x1859222B0")]
		[MethodImpl(4096)]
		private extern void ScreenToWorldPoint_Injected(ref Vector3 position, Camera.MonoOrStereoscopicEye eye, out Vector3 ret);

		// Token: 0x06000170 RID: 368
		[Token(Token = "0x6000170")]
		[Address(RVA = "0x59221F0", Offset = "0x5920DF0", VA = "0x1859221F0")]
		[MethodImpl(4096)]
		private extern void ScreenToViewportPoint_Injected(ref Vector3 position, out Vector3 ret);

		// Token: 0x06000171 RID: 369
		[Token(Token = "0x6000171")]
		[Address(RVA = "0x5921FB0", Offset = "0x5920BB0", VA = "0x185921FB0")]
		[MethodImpl(4096)]
		private extern void ScreenPointToRay_Injected(ref Vector2 pos, Camera.MonoOrStereoscopicEye eye, out Ray ret);

		// Token: 0x06000172 RID: 370
		[Token(Token = "0x6000172")]
		[Address(RVA = "0x59214B0", Offset = "0x59200B0", VA = "0x1859214B0")]
		[MethodImpl(4096)]
		private extern void CalculateFrustumCornersInternal_Injected(ref Rect viewport, float z, Camera.MonoOrStereoscopicEye eye, [Out] Vector3[] outCorners);

		// Token: 0x06000173 RID: 371
		[Token(Token = "0x6000173")]
		[Address(RVA = "0x5921AB0", Offset = "0x59206B0", VA = "0x185921AB0")]
		[MethodImpl(4096)]
		private extern void GetStereoNonJitteredProjectionMatrix_Injected(Camera.StereoscopicEye eye, out Matrix4x4 ret);

		// Token: 0x06000174 RID: 372
		[Token(Token = "0x6000174")]
		[Address(RVA = "0x5921C30", Offset = "0x5920830", VA = "0x185921C30")]
		[MethodImpl(4096)]
		private extern void GetStereoViewMatrix_Injected(Camera.StereoscopicEye eye, out Matrix4x4 ret);

		// Token: 0x06000175 RID: 373
		[Token(Token = "0x6000175")]
		[Address(RVA = "0x5921B70", Offset = "0x5920770", VA = "0x185921B70")]
		[MethodImpl(4096)]
		private extern void GetStereoProjectionMatrix_Injected(Camera.StereoscopicEye eye, out Matrix4x4 ret);

		// Token: 0x06000176 RID: 374
		[Token(Token = "0x6000176")]
		[Address(RVA = "0x5922480", Offset = "0x5921080", VA = "0x185922480")]
		[MethodImpl(4096)]
		private extern void SetStereoProjectionMatrix_Injected(Camera.StereoscopicEye eye, ref Matrix4x4 matrix);

		// Token: 0x04000112 RID: 274
		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Camera.CameraCallback onPreCull;

		// Token: 0x04000113 RID: 275
		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Camera.CameraCallback onPreRender;

		// Token: 0x04000114 RID: 276
		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Camera.CameraCallback onPostRender;

		// Token: 0x02000055 RID: 85
		[Token(Token = "0x2000055")]
		public enum StereoscopicEye
		{
			// Token: 0x04000116 RID: 278
			[Token(Token = "0x4000116")]
			Left,
			// Token: 0x04000117 RID: 279
			[Token(Token = "0x4000117")]
			Right
		}

		// Token: 0x02000056 RID: 86
		[Token(Token = "0x2000056")]
		public enum MonoOrStereoscopicEye
		{
			// Token: 0x04000119 RID: 281
			[Token(Token = "0x4000119")]
			Left,
			// Token: 0x0400011A RID: 282
			[Token(Token = "0x400011A")]
			Right,
			// Token: 0x0400011B RID: 283
			[Token(Token = "0x400011B")]
			Mono
		}

		// Token: 0x02000057 RID: 87
		[Token(Token = "0x2000057")]
		public enum RenderRequestMode
		{
			// Token: 0x0400011D RID: 285
			[Token(Token = "0x400011D")]
			None,
			// Token: 0x0400011E RID: 286
			[Token(Token = "0x400011E")]
			ObjectId,
			// Token: 0x0400011F RID: 287
			[Token(Token = "0x400011F")]
			Depth,
			// Token: 0x04000120 RID: 288
			[Token(Token = "0x4000120")]
			VertexNormal,
			// Token: 0x04000121 RID: 289
			[Token(Token = "0x4000121")]
			WorldPosition,
			// Token: 0x04000122 RID: 290
			[Token(Token = "0x4000122")]
			EntityId,
			// Token: 0x04000123 RID: 291
			[Token(Token = "0x4000123")]
			BaseColor,
			// Token: 0x04000124 RID: 292
			[Token(Token = "0x4000124")]
			SpecularColor,
			// Token: 0x04000125 RID: 293
			[Token(Token = "0x4000125")]
			Metallic,
			// Token: 0x04000126 RID: 294
			[Token(Token = "0x4000126")]
			Emission,
			// Token: 0x04000127 RID: 295
			[Token(Token = "0x4000127")]
			Normal,
			// Token: 0x04000128 RID: 296
			[Token(Token = "0x4000128")]
			Smoothness,
			// Token: 0x04000129 RID: 297
			[Token(Token = "0x4000129")]
			Occlusion,
			// Token: 0x0400012A RID: 298
			[Token(Token = "0x400012A")]
			DiffuseColor
		}

		// Token: 0x02000058 RID: 88
		[Token(Token = "0x2000058")]
		public enum RenderRequestOutputSpace
		{
			// Token: 0x0400012C RID: 300
			[Token(Token = "0x400012C")]
			ScreenSpace = -1,
			// Token: 0x0400012D RID: 301
			[Token(Token = "0x400012D")]
			UV0,
			// Token: 0x0400012E RID: 302
			[Token(Token = "0x400012E")]
			UV1,
			// Token: 0x0400012F RID: 303
			[Token(Token = "0x400012F")]
			UV2,
			// Token: 0x04000130 RID: 304
			[Token(Token = "0x4000130")]
			UV3,
			// Token: 0x04000131 RID: 305
			[Token(Token = "0x4000131")]
			UV4,
			// Token: 0x04000132 RID: 306
			[Token(Token = "0x4000132")]
			UV5,
			// Token: 0x04000133 RID: 307
			[Token(Token = "0x4000133")]
			UV6,
			// Token: 0x04000134 RID: 308
			[Token(Token = "0x4000134")]
			UV7,
			// Token: 0x04000135 RID: 309
			[Token(Token = "0x4000135")]
			UV8
		}

		// Token: 0x02000059 RID: 89
		[Token(Token = "0x2000059")]
		public struct RenderRequest
		{
			// Token: 0x04000136 RID: 310
			[Token(Token = "0x4000136")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly Camera.RenderRequestMode m_CameraRenderMode;

			// Token: 0x04000137 RID: 311
			[Token(Token = "0x4000137")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private readonly RenderTexture m_ResultRT;

			// Token: 0x04000138 RID: 312
			[Token(Token = "0x4000138")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Camera.RenderRequestOutputSpace m_OutputSpace;
		}

		// Token: 0x0200005A RID: 90
		// (Invoke) Token: 0x06000178 RID: 376
		[Token(Token = "0x200005A")]
		public delegate void CameraCallback(Camera cam);
	}
}
