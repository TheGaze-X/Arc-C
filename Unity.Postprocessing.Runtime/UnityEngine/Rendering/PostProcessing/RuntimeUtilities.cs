using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000090 RID: 144
	[Token(Token = "0x2000090")]
	public static class RuntimeUtilities
	{
		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000217 RID: 535 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x17000038")]
		public static Texture2D whiteTexture
		{
			[Token(Token = "0x6000217")]
			[Address(RVA = "0x5849D10", Offset = "0x5848910", VA = "0x185849D10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000218 RID: 536 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x17000039")]
		public static Texture3D whiteTexture3D
		{
			[Token(Token = "0x6000218")]
			[Address(RVA = "0x5849B20", Offset = "0x5848720", VA = "0x185849B20")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000219 RID: 537 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x1700003A")]
		public static Texture2D blackTexture
		{
			[Token(Token = "0x6000219")]
			[Address(RVA = "0x5848520", Offset = "0x5847120", VA = "0x185848520")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600021A RID: 538 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x1700003B")]
		public static Texture3D blackTexture3D
		{
			[Token(Token = "0x600021A")]
			[Address(RVA = "0x5848330", Offset = "0x5846F30", VA = "0x185848330")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600021B RID: 539 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x1700003C")]
		public static Texture2D transparentTexture
		{
			[Token(Token = "0x600021B")]
			[Address(RVA = "0x5849960", Offset = "0x5848560", VA = "0x185849960")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600021C RID: 540 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x1700003D")]
		public static Texture3D transparentTexture3D
		{
			[Token(Token = "0x600021C")]
			[Address(RVA = "0x5849780", Offset = "0x5848380", VA = "0x185849780")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600021D RID: 541 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600021D")]
		[Address(RVA = "0x5847AE0", Offset = "0x58466E0", VA = "0x185847AE0")]
		public static Texture2D GetLutStrip(int size)
		{
			return null;
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600021E RID: 542 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x1700003E")]
		public static Mesh fullscreenTriangle
		{
			[Token(Token = "0x600021E")]
			[Address(RVA = "0x5849140", Offset = "0x5847D40", VA = "0x185849140")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600021F RID: 543 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x1700003F")]
		public static Material copyStdMaterial
		{
			[Token(Token = "0x600021F")]
			[Address(RVA = "0x5848F90", Offset = "0x5847B90", VA = "0x185848F90")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000220 RID: 544 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x17000040")]
		public static Material copyStdFromDoubleWideMaterial
		{
			[Token(Token = "0x6000220")]
			[Address(RVA = "0x5848DE0", Offset = "0x58479E0", VA = "0x185848DE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000221 RID: 545 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x17000041")]
		public static Material copyMaterial
		{
			[Token(Token = "0x6000221")]
			[Address(RVA = "0x5848B20", Offset = "0x5847720", VA = "0x185848B20")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000222 RID: 546 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x17000042")]
		public static Material copyFromTexArrayMaterial
		{
			[Token(Token = "0x6000222")]
			[Address(RVA = "0x58486E0", Offset = "0x58472E0", VA = "0x1858486E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000223 RID: 547 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x17000043")]
		public static PropertySheet copySheet
		{
			[Token(Token = "0x6000223")]
			[Address(RVA = "0x5848CD0", Offset = "0x58478D0", VA = "0x185848CD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000224 RID: 548 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x17000044")]
		public static PropertySheet copyFromTexArraySheet
		{
			[Token(Token = "0x6000224")]
			[Address(RVA = "0x5848890", Offset = "0x5847490", VA = "0x185848890")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000225 RID: 549 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000225")]
		[Address(RVA = "0x58480B0", Offset = "0x5846CB0", VA = "0x1858480B0")]
		internal static void UpdateResources(PostProcessResources resources)
		{
		}

		// Token: 0x06000226 RID: 550 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000226")]
		[Address(RVA = "0x5848060", Offset = "0x5846C60", VA = "0x185848060")]
		public static void SetRenderTargetWithLoadStoreAction(this CommandBuffer cmd, RenderTargetIdentifier rt, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction)
		{
		}

		// Token: 0x06000227 RID: 551 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000227")]
		[Address(RVA = "0x5847FD0", Offset = "0x5846BD0", VA = "0x185847FD0")]
		public static void SetRenderTargetWithLoadStoreAction(this CommandBuffer cmd, RenderTargetIdentifier color, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depth, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction)
		{
		}

		// Token: 0x06000228 RID: 552 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000228")]
		[Address(RVA = "0x5846230", Offset = "0x5844E30", VA = "0x185846230")]
		public static void BlitFullscreenTriangle(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, bool clear = false, [Optional] Rect? viewport)
		{
		}

		// Token: 0x06000229 RID: 553 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000229")]
		[Address(RVA = "0x5846790", Offset = "0x5845390", VA = "0x185846790")]
		public static void BlitFullscreenTriangle(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, RenderBufferLoadAction loadAction, [Optional] Rect? viewport)
		{
		}

		// Token: 0x0600022A RID: 554 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600022A")]
		[Address(RVA = "0x58464C0", Offset = "0x58450C0", VA = "0x1858464C0")]
		public static void BlitFullscreenTriangle(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, bool clear = false, [Optional] Rect? viewport)
		{
		}

		// Token: 0x0600022B RID: 555 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600022B")]
		[Address(RVA = "0x5845760", Offset = "0x5844360", VA = "0x185845760")]
		public static void BlitFullscreenTriangleFromDoubleWide(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material, int pass, int eye)
		{
		}

		// Token: 0x0600022C RID: 556 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600022C")]
		[Address(RVA = "0x5845B40", Offset = "0x5844740", VA = "0x185845B40")]
		public static void BlitFullscreenTriangleToDoubleWide(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, int eye)
		{
		}

		// Token: 0x0600022D RID: 557 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600022D")]
		[Address(RVA = "0x5845930", Offset = "0x5844530", VA = "0x185845930")]
		public static void BlitFullscreenTriangleFromTexArray(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, bool clear = false, int depthSlice = -1)
		{
		}

		// Token: 0x0600022E RID: 558 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600022E")]
		[Address(RVA = "0x5845D30", Offset = "0x5844930", VA = "0x185845D30")]
		public static void BlitFullscreenTriangleToTexArray(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, bool clear = false, int depthSlice = -1)
		{
		}

		// Token: 0x0600022F RID: 559 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600022F")]
		[Address(RVA = "0x5845F40", Offset = "0x5844B40", VA = "0x185845F40")]
		public static void BlitFullscreenTriangle(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, RenderTargetIdentifier depth, PropertySheet propertySheet, int pass, bool clear = false, [Optional] Rect? viewport)
		{
		}

		// Token: 0x06000230 RID: 560 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000230")]
		[Address(RVA = "0x5846A00", Offset = "0x5845600", VA = "0x185846A00")]
		public static void BlitFullscreenTriangle(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier[] destinations, RenderTargetIdentifier depth, PropertySheet propertySheet, int pass, bool clear = false, [Optional] Rect? viewport)
		{
		}

		// Token: 0x06000231 RID: 561 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000231")]
		[Address(RVA = "0x5846D20", Offset = "0x5845920", VA = "0x185846D20")]
		public static void BuiltinBlit(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination)
		{
		}

		// Token: 0x06000232 RID: 562 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000232")]
		[Address(RVA = "0x5846C30", Offset = "0x5845830", VA = "0x185846C30")]
		public static void BuiltinBlit(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material mat, int pass = 0)
		{
		}

		// Token: 0x06000233 RID: 563 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000233")]
		[Address(RVA = "0x5846E60", Offset = "0x5845A60", VA = "0x185846E60")]
		public static void CopyTexture(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination)
		{
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000234 RID: 564 RVA: 0x00002DA4 File Offset: 0x00000FA4
		[Token(Token = "0x17000045")]
		public static bool scriptableRenderPipelineActive
		{
			[Token(Token = "0x6000234")]
			[Address(RVA = "0x58495E0", Offset = "0x58481E0", VA = "0x1858495E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000235 RID: 565 RVA: 0x00002DBC File Offset: 0x00000FBC
		[Token(Token = "0x17000046")]
		public static bool supportsDeferredShading
		{
			[Token(Token = "0x6000235")]
			[Address(RVA = "0x5849640", Offset = "0x5848240", VA = "0x185849640")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000236 RID: 566 RVA: 0x00002DD4 File Offset: 0x00000FD4
		[Token(Token = "0x17000047")]
		public static bool supportsDepthNormals
		{
			[Token(Token = "0x6000236")]
			[Address(RVA = "0x58496E0", Offset = "0x58482E0", VA = "0x1858496E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000237 RID: 567 RVA: 0x00002DEC File Offset: 0x00000FEC
		[Token(Token = "0x17000048")]
		public static bool isSinglePassStereoEnabled
		{
			[Token(Token = "0x6000237")]
			[Address(RVA = "0x58495A0", Offset = "0x58481A0", VA = "0x1858495A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000238 RID: 568 RVA: 0x00002E04 File Offset: 0x00001004
		[Token(Token = "0x17000049")]
		public static bool isVREnabled
		{
			[Token(Token = "0x6000238")]
			[Address(RVA = "0x58495D0", Offset = "0x58481D0", VA = "0x1858495D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000239 RID: 569 RVA: 0x00002E1C File Offset: 0x0000101C
		[Token(Token = "0x1700004A")]
		public static bool isAndroidOpenGL
		{
			[Token(Token = "0x6000239")]
			[Address(RVA = "0x5849570", Offset = "0x5848170", VA = "0x185849570")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600023A RID: 570 RVA: 0x00002E34 File Offset: 0x00001034
		[Token(Token = "0x1700004B")]
		public static RenderTextureFormat defaultHDRRenderTextureFormat
		{
			[Token(Token = "0x600023A")]
			[Address(RVA = "0x54AFD0", Offset = "0x549BD0", VA = "0x18054AFD0")]
			get
			{
				return RenderTextureFormat.ARGB32;
			}
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00002E4C File Offset: 0x0000104C
		[Token(Token = "0x600023B")]
		[Address(RVA = "0x5849ED0", Offset = "0x5848AD0", VA = "0x185849ED0")]
		public static bool isFloatingPointFormat(RenderTextureFormat format)
		{
			return default(bool);
		}

		// Token: 0x0600023C RID: 572 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600023C")]
		[Address(RVA = "0x58472E0", Offset = "0x5845EE0", VA = "0x1858472E0")]
		public static void Destroy(Object obj)
		{
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600023D RID: 573 RVA: 0x00002E64 File Offset: 0x00001064
		[Token(Token = "0x1700004C")]
		public static bool isLinearColorSpace
		{
			[Token(Token = "0x600023D")]
			[Address(RVA = "0x2879A50", Offset = "0x2878650", VA = "0x182879A50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00002E7C File Offset: 0x0000107C
		[Token(Token = "0x600023E")]
		[Address(RVA = "0x5847EA0", Offset = "0x5846AA0", VA = "0x185847EA0")]
		public static bool IsResolvedDepthAvailable(Camera camera)
		{
			return default(bool);
		}

		// Token: 0x0600023F RID: 575 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600023F")]
		[Address(RVA = "0x5846FC0", Offset = "0x5845BC0", VA = "0x185846FC0")]
		public static void DestroyProfile(PostProcessProfile profile, bool destroyEffects)
		{
		}

		// Token: 0x06000240 RID: 576 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000240")]
		[Address(RVA = "0x5847200", Offset = "0x5845E00", VA = "0x185847200")]
		public static void DestroyVolume(PostProcessVolume volume, bool destroyProfile, bool destroyGameObject = false)
		{
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00002E94 File Offset: 0x00001094
		[Token(Token = "0x6000241")]
		[Address(RVA = "0x5847E30", Offset = "0x5846A30", VA = "0x185847E30")]
		public static bool IsPostProcessingActive(PostProcessLayer layer)
		{
			return default(bool);
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00002EAC File Offset: 0x000010AC
		[Token(Token = "0x6000242")]
		[Address(RVA = "0x5847F10", Offset = "0x5846B10", VA = "0x185847F10")]
		public static bool IsTemporalAntialiasingActive(PostProcessLayer layer)
		{
			return default(bool);
		}

		// Token: 0x06000243 RID: 579 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000243")]
		public static IEnumerable<T> GetAllSceneObjects<T>() where T : Component
		{
			return null;
		}

		// Token: 0x06000244 RID: 580 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000244")]
		public static void CreateIfNull<T>(ref T obj) where T : class, new()
		{
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00002EC4 File Offset: 0x000010C4
		[Token(Token = "0x6000245")]
		[Address(RVA = "0x5847360", Offset = "0x5845F60", VA = "0x185847360")]
		public static float Exp2(float x)
		{
			return 0f;
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00002EDC File Offset: 0x000010DC
		[Token(Token = "0x6000246")]
		[Address(RVA = "0x5847940", Offset = "0x5846540", VA = "0x185847940")]
		public static Matrix4x4 GetJitteredPerspectiveProjectionMatrix(Camera camera, Vector2 offset)
		{
			return default(Matrix4x4);
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00002EF4 File Offset: 0x000010F4
		[Token(Token = "0x6000247")]
		[Address(RVA = "0x58477D0", Offset = "0x58463D0", VA = "0x1858477D0")]
		public static Matrix4x4 GetJitteredOrthographicProjectionMatrix(Camera camera, Vector2 offset)
		{
			return default(Matrix4x4);
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00002F0C File Offset: 0x0000110C
		[Token(Token = "0x6000248")]
		[Address(RVA = "0x5847370", Offset = "0x5845F70", VA = "0x185847370")]
		public static Matrix4x4 GenerateJitteredProjectionMatrixFromOriginal(PostProcessRenderContext context, Matrix4x4 origProj, Vector2 jitter)
		{
			return default(Matrix4x4);
		}

		// Token: 0x06000249 RID: 585 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000249")]
		[Address(RVA = "0x58475E0", Offset = "0x58461E0", VA = "0x1858475E0")]
		public static IEnumerable<Type> GetAllAssemblyTypes()
		{
			return null;
		}

		// Token: 0x0600024A RID: 586 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600024A")]
		public static IEnumerable<Type> GetAllTypesDerivedFrom<T>()
		{
			return null;
		}

		// Token: 0x0600024B RID: 587 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600024B")]
		public static T GetAttribute<T>(this Type type) where T : Attribute
		{
			return null;
		}

		// Token: 0x0600024C RID: 588 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600024C")]
		public static Attribute[] GetMemberAttributes<TType, TValue>(Expression<Func<TType, TValue>> expr)
		{
			return null;
		}

		// Token: 0x0600024D RID: 589 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600024D")]
		public static string GetFieldPath<TType, TValue>(Expression<Func<TType, TValue>> expr)
		{
			return null;
		}

		// Token: 0x0600024E RID: 590 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600024E")]
		[Address(RVA = "0x5846DF0", Offset = "0x58459F0", VA = "0x185846DF0")]
		public static void ClearResource()
		{
		}

		// Token: 0x040002C2 RID: 706
		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Texture2D m_WhiteTexture;

		// Token: 0x040002C3 RID: 707
		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Texture3D m_WhiteTexture3D;

		// Token: 0x040002C4 RID: 708
		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Texture2D m_BlackTexture;

		// Token: 0x040002C5 RID: 709
		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static Texture3D m_BlackTexture3D;

		// Token: 0x040002C6 RID: 710
		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static Texture2D m_TransparentTexture;

		// Token: 0x040002C7 RID: 711
		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static Texture3D m_TransparentTexture3D;

		// Token: 0x040002C8 RID: 712
		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static Dictionary<int, Texture2D> m_LutStrips;

		// Token: 0x040002C9 RID: 713
		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static PostProcessResources s_Resources;

		// Token: 0x040002CA RID: 714
		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static Mesh s_FullscreenTriangle;

		// Token: 0x040002CB RID: 715
		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static Material s_CopyStdMaterial;

		// Token: 0x040002CC RID: 716
		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static Material s_CopyStdFromDoubleWideMaterial;

		// Token: 0x040002CD RID: 717
		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static Material s_CopyMaterial;

		// Token: 0x040002CE RID: 718
		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static Material s_CopyFromTexArrayMaterial;

		// Token: 0x040002CF RID: 719
		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static PropertySheet s_CopySheet;

		// Token: 0x040002D0 RID: 720
		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static PropertySheet s_CopyFromTexArraySheet;

		// Token: 0x040002D1 RID: 721
		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static IEnumerable<Type> m_AssemblyTypes;
	}
}
