using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Scripting;
using XLua;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000073 RID: 115
	[Token(Token = "0x2000073")]
	[AddComponentMenu("Rendering/Post-process Layer", 1000)]
	[ImageEffectAllowedInSceneView]
	[RequireComponent(typeof(Camera))]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	public class PostProcessLayer : MonoBehaviour
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000138 RID: 312 RVA: 0x000026CC File Offset: 0x000008CC
		[Token(Token = "0x1700000C")]
		public virtual bool hgDither
		{
			[Token(Token = "0x6000138")]
			[Address(RVA = "0x583EBD0", Offset = "0x583D7D0", VA = "0x18583EBD0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000139 RID: 313 RVA: 0x000026E4 File Offset: 0x000008E4
		[Token(Token = "0x1700000D")]
		public virtual bool hgVignette
		{
			[Token(Token = "0x6000139")]
			[Address(RVA = "0x583EC30", Offset = "0x583D830", VA = "0x18583EC30", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600013A RID: 314 RVA: 0x000026FC File Offset: 0x000008FC
		[Token(Token = "0x1700000E")]
		public virtual bool hgBloom
		{
			[Token(Token = "0x600013A")]
			[Address(RVA = "0x583EAF0", Offset = "0x583D6F0", VA = "0x18583EAF0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600013B RID: 315 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x0600013C RID: 316 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700000F")]
		public Dictionary<PostProcessEvent, List<PostProcessLayer.SerializedBundleRef>> sortedBundles
		{
			[Token(Token = "0x600013B")]
			[Address(RVA = "0x583ECD0", Offset = "0x583D8D0", VA = "0x18583ECD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600013C")]
			[Address(RVA = "0x583EE20", Offset = "0x583DA20", VA = "0x18583EE20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600013D RID: 317 RVA: 0x00002714 File Offset: 0x00000914
		// (set) Token: 0x0600013E RID: 318 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000010")]
		public DepthTextureMode cameraDepthFlags
		{
			[Token(Token = "0x600013D")]
			[Address(RVA = "0x583EA30", Offset = "0x583D630", VA = "0x18583EA30")]
			[CompilerGenerated]
			get
			{
				return DepthTextureMode.None;
			}
			[Token(Token = "0x600013E")]
			[Address(RVA = "0x583ED30", Offset = "0x583D930", VA = "0x18583ED30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600013F RID: 319 RVA: 0x0000272C File Offset: 0x0000092C
		// (set) Token: 0x06000140 RID: 320 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000011")]
		public bool haveBundlesBeenInited
		{
			[Token(Token = "0x600013F")]
			[Address(RVA = "0x583EA90", Offset = "0x583D690", VA = "0x18583EA90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000140")]
			[Address(RVA = "0x583EDA0", Offset = "0x583D9A0", VA = "0x18583EDA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000141 RID: 321 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000141")]
		[Address(RVA = "0x5838840", Offset = "0x5837440", VA = "0x185838840")]
		private void OnEnable()
		{
		}

		// Token: 0x06000142 RID: 322 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000142")]
		[Address(RVA = "0x5837F10", Offset = "0x5836B10", VA = "0x185837F10")]
		private void InitLegacy()
		{
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00002744 File Offset: 0x00000944
		[Token(Token = "0x6000143")]
		[Address(RVA = "0x5835DF0", Offset = "0x58349F0", VA = "0x185835DF0")]
		private bool DynamicResolutionAllowsFinalBlitToCameraTarget()
		{
			return default(bool);
		}

		// Token: 0x06000144 RID: 324 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000144")]
		[Address(RVA = "0x5838240", Offset = "0x5836E40", VA = "0x185838240")]
		public void Init(PostProcessResources resources)
		{
		}

		// Token: 0x06000145 RID: 325 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000145")]
		[Address(RVA = "0x5837940", Offset = "0x5836540", VA = "0x185837940")]
		public void InitBundles()
		{
		}

		// Token: 0x06000146 RID: 326 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000146")]
		[Address(RVA = "0x583DCD0", Offset = "0x583C8D0", VA = "0x18583DCD0")]
		private void UpdateBundleSortList(List<PostProcessLayer.SerializedBundleRef> sortedList, PostProcessEvent evt)
		{
		}

		// Token: 0x06000147 RID: 327 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000147")]
		[Address(RVA = "0x5838410", Offset = "0x5837010", VA = "0x185838410")]
		private void OnDisable()
		{
		}

		// Token: 0x06000148 RID: 328 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000148")]
		[Address(RVA = "0x583D2C0", Offset = "0x583BEC0", VA = "0x18583D2C0")]
		private void Reset()
		{
		}

		// Token: 0x06000149 RID: 329 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000149")]
		[Address(RVA = "0x5838CA0", Offset = "0x58378A0", VA = "0x185838CA0")]
		private void OnPreCull()
		{
		}

		// Token: 0x0600014A RID: 330 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600014A")]
		[Address(RVA = "0x5839050", Offset = "0x5837C50", VA = "0x185839050")]
		private void OnPreRender()
		{
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0000275C File Offset: 0x0000095C
		[Token(Token = "0x600014B")]
		[Address(RVA = "0x583D080", Offset = "0x583BC80", VA = "0x18583D080")]
		private static bool RequiresInitialBlit(Camera camera, PostProcessRenderContext context)
		{
			return default(bool);
		}

		// Token: 0x0600014C RID: 332 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600014C")]
		[Address(RVA = "0x583E3A0", Offset = "0x583CFA0", VA = "0x18583E3A0")]
		private void UpdateSrcDstForOpaqueOnly(ref int src, ref int dst, PostProcessRenderContext context, RenderTargetIdentifier cameraTarget, int opaqueOnlyEffectsRemaining)
		{
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600014D")]
		[Address(RVA = "0x5834E70", Offset = "0x5833A70", VA = "0x185834E70")]
		private void BuildCommandBuffers()
		{
		}

		// Token: 0x0600014E RID: 334 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600014E")]
		[Address(RVA = "0x5838AD0", Offset = "0x58376D0", VA = "0x185838AD0")]
		private void OnPostRender()
		{
		}

		// Token: 0x0600014F RID: 335 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600014F")]
		public PostProcessBundle GetBundle<T>() where T : PostProcessEffectSettings
		{
			return null;
		}

		// Token: 0x06000150 RID: 336 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x5835EA0", Offset = "0x5834AA0", VA = "0x185835EA0")]
		public PostProcessBundle GetBundle(Type settingsType)
		{
			return null;
		}

		// Token: 0x06000151 RID: 337 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000151")]
		public T GetSettings<T>() where T : PostProcessEffectSettings
		{
			return null;
		}

		// Token: 0x06000152 RID: 338 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000152")]
		[Address(RVA = "0x5834C50", Offset = "0x5833850", VA = "0x185834C50")]
		public void BakeMSVOMap(CommandBuffer cmd, Camera camera, RenderTargetIdentifier destination, RenderTargetIdentifier? depthMap, bool invert, bool isMSAA = false)
		{
		}

		// Token: 0x06000153 RID: 339 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000153")]
		[Address(RVA = "0x5839150", Offset = "0x5837D50", VA = "0x185839150")]
		internal void OverrideSettings(List<PostProcessEffectSettings> baseSettings, float interpFactor)
		{
		}

		// Token: 0x06000154 RID: 340 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000154")]
		[Address(RVA = "0x583D340", Offset = "0x583BF40", VA = "0x18583D340")]
		private void SetLegacyCameraFlags(PostProcessRenderContext context)
		{
		}

		// Token: 0x06000155 RID: 341 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000155")]
		[Address(RVA = "0x583D100", Offset = "0x583BD00", VA = "0x18583D100")]
		public void ResetHistory()
		{
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00002774 File Offset: 0x00000974
		[Token(Token = "0x6000156")]
		[Address(RVA = "0x58378C0", Offset = "0x58364C0", VA = "0x1858378C0")]
		public bool HasOpaqueOnlyEffects(PostProcessRenderContext context)
		{
			return default(bool);
		}

		// Token: 0x06000157 RID: 343 RVA: 0x0000278C File Offset: 0x0000098C
		[Token(Token = "0x6000157")]
		[Address(RVA = "0x58375D0", Offset = "0x58361D0", VA = "0x1858375D0")]
		public bool HasActiveEffects(PostProcessEvent evt, PostProcessRenderContext context)
		{
			return default(bool);
		}

		// Token: 0x06000158 RID: 344 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000158")]
		[Address(RVA = "0x583D6E0", Offset = "0x583C2E0", VA = "0x18583D6E0")]
		private void SetupContext(PostProcessRenderContext context)
		{
		}

		// Token: 0x06000159 RID: 345 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000159")]
		[Address(RVA = "0x583E780", Offset = "0x583D380", VA = "0x18583E780")]
		public void UpdateVolumeSystem(Camera cam, CommandBuffer cmd)
		{
		}

		// Token: 0x0600015A RID: 346 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600015A")]
		[Address(RVA = "0x583BE50", Offset = "0x583AA50", VA = "0x18583BE50")]
		public void RenderOpaqueOnly(PostProcessRenderContext context)
		{
		}

		// Token: 0x0600015B RID: 347 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600015B")]
		[Address(RVA = "0x583C0C0", Offset = "0x583ACC0", VA = "0x18583C0C0")]
		public void Render(PostProcessRenderContext context)
		{
		}

		// Token: 0x0600015C RID: 348 RVA: 0x000027A4 File Offset: 0x000009A4
		[Token(Token = "0x600015C")]
		[Address(RVA = "0x583B0E0", Offset = "0x5839CE0", VA = "0x18583B0E0")]
		private int RenderInjectionPoint(PostProcessEvent evt, PostProcessRenderContext context, string marker, int releaseTargetAfterUse = -1)
		{
			return 0;
		}

		// Token: 0x0600015D RID: 349 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600015D")]
		[Address(RVA = "0x583B5C0", Offset = "0x583A1C0", VA = "0x18583B5C0")]
		private void RenderList(List<PostProcessLayer.SerializedBundleRef> list, PostProcessRenderContext context, string marker)
		{
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600015E")]
		[Address(RVA = "0x5834AD0", Offset = "0x58336D0", VA = "0x185834AD0")]
		private void ApplyFlip(PostProcessRenderContext context, MaterialPropertyBlock properties)
		{
		}

		// Token: 0x0600015F RID: 351 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600015F")]
		[Address(RVA = "0x58349E0", Offset = "0x58335E0", VA = "0x1858349E0")]
		private void ApplyDefaultFlip(MaterialPropertyBlock properties)
		{
		}

		// Token: 0x06000160 RID: 352 RVA: 0x000027BC File Offset: 0x000009BC
		[Token(Token = "0x6000160")]
		[Address(RVA = "0x58393F0", Offset = "0x5837FF0", VA = "0x1858393F0")]
		private int RenderBuiltins(PostProcessRenderContext context, bool isFinalPass, int releaseTargetAfterUse = -1, int eye = -1)
		{
			return 0;
		}

		// Token: 0x06000161 RID: 353 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000161")]
		[Address(RVA = "0x583A460", Offset = "0x5839060", VA = "0x18583A460")]
		private void RenderFinalPass(PostProcessRenderContext context, int releaseTargetAfterUse = -1, int eye = -1)
		{
		}

		// Token: 0x06000162 RID: 354 RVA: 0x000027D4 File Offset: 0x000009D4
		[Token(Token = "0x6000162")]
		private int RenderEffect<T>(PostProcessRenderContext context, bool useTempTarget = false) where T : PostProcessEffectSettings
		{
			return 0;
		}

		// Token: 0x06000163 RID: 355 RVA: 0x000027EC File Offset: 0x000009EC
		[Token(Token = "0x6000163")]
		[Address(RVA = "0x583DBD0", Offset = "0x583C7D0", VA = "0x18583DBD0")]
		private bool ShouldGenerateLogHistogram(PostProcessRenderContext context)
		{
			return default(bool);
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00002804 File Offset: 0x00000A04
		[Token(Token = "0x6000164")]
		[Address(RVA = "0x5837550", Offset = "0x5836150", VA = "0x185837550")]
		private bool HG_ModifyRenderFinalPass(PostProcessRenderContext context)
		{
			return default(bool);
		}

		// Token: 0x06000165 RID: 357 RVA: 0x0000281C File Offset: 0x00000A1C
		[Token(Token = "0x6000165")]
		[Address(RVA = "0x5835F40", Offset = "0x5834B40", VA = "0x185835F40")]
		private bool HG_ModifyAntialiasing(PostProcessRenderContext context)
		{
			return default(bool);
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00002834 File Offset: 0x00000A34
		[Token(Token = "0x6000166")]
		[Address(RVA = "0x5836C30", Offset = "0x5835830", VA = "0x185836C30")]
		private bool HG_ModifyRenderBuiltins(PostProcessRenderContext context, CommandBuffer cmd, PropertySheet uberSheet)
		{
			return default(bool);
		}

		// Token: 0x06000167 RID: 359 RVA: 0x0000284C File Offset: 0x00000A4C
		[Token(Token = "0x6000167")]
		[Address(RVA = "0x5836250", Offset = "0x5834E50", VA = "0x185836250")]
		private bool HG_ModifyRenderBuiltins_LWRP(PostProcessRenderContext context, CommandBuffer cmd, PropertySheet uberSheet)
		{
			return default(bool);
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00002864 File Offset: 0x00000A64
		[Token(Token = "0x6000168")]
		[Address(RVA = "0x58360D0", Offset = "0x5834CD0", VA = "0x1858360D0")]
		private bool HG_ModifyBuildCommandBuffers(PostProcessRenderContext context, RenderTargetIdentifier cameraTarget)
		{
			return default(bool);
		}

		// Token: 0x06000169 RID: 361 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000169")]
		[Address(RVA = "0x583E910", Offset = "0x583D510", VA = "0x18583E910")]
		public PostProcessLayer()
		{
		}

		// Token: 0x040001A3 RID: 419
		[Token(Token = "0x40001A3")]
		[FieldOffset(Offset = "0x18")]
		public Transform volumeTrigger;

		// Token: 0x040001A4 RID: 420
		[Token(Token = "0x40001A4")]
		[FieldOffset(Offset = "0x20")]
		public LayerMask volumeLayer;

		// Token: 0x040001A5 RID: 421
		[Token(Token = "0x40001A5")]
		[FieldOffset(Offset = "0x24")]
		public bool stopNaNPropagation;

		// Token: 0x040001A6 RID: 422
		[Token(Token = "0x40001A6")]
		[FieldOffset(Offset = "0x25")]
		public bool finalBlitToCameraTarget;

		// Token: 0x040001A7 RID: 423
		[Token(Token = "0x40001A7")]
		[FieldOffset(Offset = "0x28")]
		public PostProcessLayer.Antialiasing antialiasingMode;

		// Token: 0x040001A8 RID: 424
		[Token(Token = "0x40001A8")]
		[FieldOffset(Offset = "0x30")]
		public TemporalAntialiasing temporalAntialiasing;

		// Token: 0x040001A9 RID: 425
		[Token(Token = "0x40001A9")]
		[FieldOffset(Offset = "0x38")]
		public SubpixelMorphologicalAntialiasing subpixelMorphologicalAntialiasing;

		// Token: 0x040001AA RID: 426
		[Token(Token = "0x40001AA")]
		[FieldOffset(Offset = "0x40")]
		public FastApproximateAntialiasing fastApproximateAntialiasing;

		// Token: 0x040001AB RID: 427
		[Token(Token = "0x40001AB")]
		[FieldOffset(Offset = "0x48")]
		public Fog fog;

		// Token: 0x040001AC RID: 428
		[Token(Token = "0x40001AC")]
		[FieldOffset(Offset = "0x50")]
		private Dithering dithering;

		// Token: 0x040001AD RID: 429
		[Token(Token = "0x40001AD")]
		[FieldOffset(Offset = "0x58")]
		public PostProcessDebugLayer debugLayer;

		// Token: 0x040001AE RID: 430
		[Token(Token = "0x40001AE")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private PostProcessResources m_Resources;

		// Token: 0x040001AF RID: 431
		[Token(Token = "0x40001AF")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		private PostProcessResources m_OldResources;

		// Token: 0x040001B0 RID: 432
		[Token(Token = "0x40001B0")]
		[FieldOffset(Offset = "0x70")]
		[Preserve]
		[SerializeField]
		private bool m_ShowToolkit;

		// Token: 0x040001B1 RID: 433
		[Token(Token = "0x40001B1")]
		[FieldOffset(Offset = "0x71")]
		[Preserve]
		[SerializeField]
		private bool m_ShowCustomSorter;

		// Token: 0x040001B2 RID: 434
		[Token(Token = "0x40001B2")]
		[FieldOffset(Offset = "0x72")]
		public bool breakBeforeColorGrading;

		// Token: 0x040001B3 RID: 435
		[Token(Token = "0x40001B3")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private List<PostProcessLayer.SerializedBundleRef> m_BeforeTransparentBundles;

		// Token: 0x040001B4 RID: 436
		[Token(Token = "0x40001B4")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private List<PostProcessLayer.SerializedBundleRef> m_BeforeStackBundles;

		// Token: 0x040001B5 RID: 437
		[Token(Token = "0x40001B5")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private List<PostProcessLayer.SerializedBundleRef> m_AfterStackBundles;

		// Token: 0x040001B9 RID: 441
		[Token(Token = "0x40001B9")]
		[FieldOffset(Offset = "0xA0")]
		private Dictionary<Type, PostProcessBundle> m_Bundles;

		// Token: 0x040001BA RID: 442
		[Token(Token = "0x40001BA")]
		[FieldOffset(Offset = "0xA8")]
		private PropertySheetFactory m_PropertySheetFactory;

		// Token: 0x040001BB RID: 443
		[Token(Token = "0x40001BB")]
		[FieldOffset(Offset = "0xB0")]
		private CommandBuffer m_LegacyCmdBufferBeforeReflections;

		// Token: 0x040001BC RID: 444
		[Token(Token = "0x40001BC")]
		[FieldOffset(Offset = "0xB8")]
		private CommandBuffer m_LegacyCmdBufferBeforeLighting;

		// Token: 0x040001BD RID: 445
		[Token(Token = "0x40001BD")]
		[FieldOffset(Offset = "0xC0")]
		private CommandBuffer m_LegacyCmdBufferOpaque;

		// Token: 0x040001BE RID: 446
		[Token(Token = "0x40001BE")]
		[FieldOffset(Offset = "0xC8")]
		private CommandBuffer m_LegacyCmdBuffer;

		// Token: 0x040001BF RID: 447
		[Token(Token = "0x40001BF")]
		[FieldOffset(Offset = "0xD0")]
		private Camera m_Camera;

		// Token: 0x040001C0 RID: 448
		[Token(Token = "0x40001C0")]
		[FieldOffset(Offset = "0xD8")]
		private PostProcessRenderContext m_CurrentContext;

		// Token: 0x040001C1 RID: 449
		[Token(Token = "0x40001C1")]
		[FieldOffset(Offset = "0xE0")]
		private LogHistogram m_LogHistogram;

		// Token: 0x040001C2 RID: 450
		[Token(Token = "0x40001C2")]
		[FieldOffset(Offset = "0xE8")]
		private bool m_SettingsUpdateNeeded;

		// Token: 0x040001C3 RID: 451
		[Token(Token = "0x40001C3")]
		[FieldOffset(Offset = "0xE9")]
		private bool m_IsRenderingInSceneView;

		// Token: 0x040001C4 RID: 452
		[Token(Token = "0x40001C4")]
		[FieldOffset(Offset = "0xF0")]
		private TargetPool m_TargetPool;

		// Token: 0x040001C5 RID: 453
		[Token(Token = "0x40001C5")]
		[FieldOffset(Offset = "0xF8")]
		private bool m_NaNKilled;

		// Token: 0x040001C6 RID: 454
		[Token(Token = "0x40001C6")]
		[FieldOffset(Offset = "0x100")]
		private readonly List<PostProcessEffectRenderer> m_ActiveEffects;

		// Token: 0x040001C7 RID: 455
		[Token(Token = "0x40001C7")]
		[FieldOffset(Offset = "0x108")]
		private readonly List<RenderTargetIdentifier> m_Targets;

		// Token: 0x040001C8 RID: 456
		[Token(Token = "0x40001C8")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate0 __Hotfix0_get_hgDither;

		// Token: 0x040001C9 RID: 457
		[Token(Token = "0x40001C9")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate0 __Hotfix0_get_hgVignette;

		// Token: 0x040001CA RID: 458
		[Token(Token = "0x40001CA")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate0 __Hotfix0_get_hgBloom;

		// Token: 0x040001CB RID: 459
		[Token(Token = "0x40001CB")]
		[FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate1 __Hotfix0_get_sortedBundles;

		// Token: 0x040001CC RID: 460
		[Token(Token = "0x40001CC")]
		[FieldOffset(Offset = "0x20")]
		private static __XLua_Gen_Delegate2 __Hotfix0_set_sortedBundles;

		// Token: 0x040001CD RID: 461
		[Token(Token = "0x40001CD")]
		[FieldOffset(Offset = "0x28")]
		private static __XLua_Gen_Delegate3 __Hotfix0_get_cameraDepthFlags;

		// Token: 0x040001CE RID: 462
		[Token(Token = "0x40001CE")]
		[FieldOffset(Offset = "0x30")]
		private static __XLua_Gen_Delegate4 __Hotfix0_set_cameraDepthFlags;

		// Token: 0x040001CF RID: 463
		[Token(Token = "0x40001CF")]
		[FieldOffset(Offset = "0x38")]
		private static __XLua_Gen_Delegate0 __Hotfix0_get_haveBundlesBeenInited;

		// Token: 0x040001D0 RID: 464
		[Token(Token = "0x40001D0")]
		[FieldOffset(Offset = "0x40")]
		private static __XLua_Gen_Delegate5 __Hotfix0_set_haveBundlesBeenInited;

		// Token: 0x040001D1 RID: 465
		[Token(Token = "0x40001D1")]
		[FieldOffset(Offset = "0x48")]
		private static __XLua_Gen_Delegate6 __Hotfix0_OnEnable;

		// Token: 0x040001D2 RID: 466
		[Token(Token = "0x40001D2")]
		[FieldOffset(Offset = "0x50")]
		private static __XLua_Gen_Delegate6 __Hotfix0_InitLegacy;

		// Token: 0x040001D3 RID: 467
		[Token(Token = "0x40001D3")]
		[FieldOffset(Offset = "0x58")]
		private static __XLua_Gen_Delegate0 __Hotfix0_DynamicResolutionAllowsFinalBlitToCameraTarget;

		// Token: 0x040001D4 RID: 468
		[Token(Token = "0x40001D4")]
		[FieldOffset(Offset = "0x60")]
		private static __XLua_Gen_Delegate2 __Hotfix0_Init;

		// Token: 0x040001D5 RID: 469
		[Token(Token = "0x40001D5")]
		[FieldOffset(Offset = "0x68")]
		private static __XLua_Gen_Delegate6 __Hotfix0_InitBundles;

		// Token: 0x040001D6 RID: 470
		[Token(Token = "0x40001D6")]
		[FieldOffset(Offset = "0x70")]
		private static __XLua_Gen_Delegate7 __Hotfix0_UpdateBundleSortList;

		// Token: 0x040001D7 RID: 471
		[Token(Token = "0x40001D7")]
		[FieldOffset(Offset = "0x78")]
		private static __XLua_Gen_Delegate6 __Hotfix0_OnDisable;

		// Token: 0x040001D8 RID: 472
		[Token(Token = "0x40001D8")]
		[FieldOffset(Offset = "0x80")]
		private static __XLua_Gen_Delegate6 __Hotfix0_Reset;

		// Token: 0x040001D9 RID: 473
		[Token(Token = "0x40001D9")]
		[FieldOffset(Offset = "0x88")]
		private static __XLua_Gen_Delegate6 __Hotfix0_OnPreCull;

		// Token: 0x040001DA RID: 474
		[Token(Token = "0x40001DA")]
		[FieldOffset(Offset = "0x90")]
		private static __XLua_Gen_Delegate6 __Hotfix0_OnPreRender;

		// Token: 0x040001DB RID: 475
		[Token(Token = "0x40001DB")]
		[FieldOffset(Offset = "0x98")]
		private static __XLua_Gen_Delegate8 __Hotfix0_RequiresInitialBlit;

		// Token: 0x040001DC RID: 476
		[Token(Token = "0x40001DC")]
		[FieldOffset(Offset = "0xA0")]
		private static __XLua_Gen_Delegate9 __Hotfix0_UpdateSrcDstForOpaqueOnly;

		// Token: 0x040001DD RID: 477
		[Token(Token = "0x40001DD")]
		[FieldOffset(Offset = "0xA8")]
		private static __XLua_Gen_Delegate6 __Hotfix0_BuildCommandBuffers;

		// Token: 0x040001DE RID: 478
		[Token(Token = "0x40001DE")]
		[FieldOffset(Offset = "0xB0")]
		private static __XLua_Gen_Delegate6 __Hotfix0_OnPostRender;

		// Token: 0x040001DF RID: 479
		[Token(Token = "0x40001DF")]
		[FieldOffset(Offset = "0xB8")]
		private static __XLua_Gen_Delegate10 __Hotfix0_GetBundle;

		// Token: 0x040001E0 RID: 480
		[Token(Token = "0x40001E0")]
		[FieldOffset(Offset = "0xC0")]
		private static __XLua_Gen_Delegate11 __Hotfix0_BakeMSVOMap;

		// Token: 0x040001E1 RID: 481
		[Token(Token = "0x40001E1")]
		[FieldOffset(Offset = "0xC8")]
		private static __XLua_Gen_Delegate12 __Hotfix0_OverrideSettings;

		// Token: 0x040001E2 RID: 482
		[Token(Token = "0x40001E2")]
		[FieldOffset(Offset = "0xD0")]
		private static __XLua_Gen_Delegate2 __Hotfix0_SetLegacyCameraFlags;

		// Token: 0x040001E3 RID: 483
		[Token(Token = "0x40001E3")]
		[FieldOffset(Offset = "0xD8")]
		private static __XLua_Gen_Delegate6 __Hotfix0_ResetHistory;

		// Token: 0x040001E4 RID: 484
		[Token(Token = "0x40001E4")]
		[FieldOffset(Offset = "0xE0")]
		private static __XLua_Gen_Delegate8 __Hotfix0_HasOpaqueOnlyEffects;

		// Token: 0x040001E5 RID: 485
		[Token(Token = "0x40001E5")]
		[FieldOffset(Offset = "0xE8")]
		private static __XLua_Gen_Delegate13 __Hotfix0_HasActiveEffects;

		// Token: 0x040001E6 RID: 486
		[Token(Token = "0x40001E6")]
		[FieldOffset(Offset = "0xF0")]
		private static __XLua_Gen_Delegate2 __Hotfix0_SetupContext;

		// Token: 0x040001E7 RID: 487
		[Token(Token = "0x40001E7")]
		[FieldOffset(Offset = "0xF8")]
		private static __XLua_Gen_Delegate14 __Hotfix0_UpdateVolumeSystem;

		// Token: 0x040001E8 RID: 488
		[Token(Token = "0x40001E8")]
		[FieldOffset(Offset = "0x100")]
		private static __XLua_Gen_Delegate2 __Hotfix0_RenderOpaqueOnly;

		// Token: 0x040001E9 RID: 489
		[Token(Token = "0x40001E9")]
		[FieldOffset(Offset = "0x108")]
		private static __XLua_Gen_Delegate2 __Hotfix0_Render;

		// Token: 0x040001EA RID: 490
		[Token(Token = "0x40001EA")]
		[FieldOffset(Offset = "0x110")]
		private static __XLua_Gen_Delegate15 __Hotfix0_RenderInjectionPoint;

		// Token: 0x040001EB RID: 491
		[Token(Token = "0x40001EB")]
		[FieldOffset(Offset = "0x118")]
		private static __XLua_Gen_Delegate16 __Hotfix0_RenderList;

		// Token: 0x040001EC RID: 492
		[Token(Token = "0x40001EC")]
		[FieldOffset(Offset = "0x120")]
		private static __XLua_Gen_Delegate14 __Hotfix0_ApplyFlip;

		// Token: 0x040001ED RID: 493
		[Token(Token = "0x40001ED")]
		[FieldOffset(Offset = "0x128")]
		private static __XLua_Gen_Delegate2 __Hotfix0_ApplyDefaultFlip;

		// Token: 0x040001EE RID: 494
		[Token(Token = "0x40001EE")]
		[FieldOffset(Offset = "0x130")]
		private static __XLua_Gen_Delegate17 __Hotfix0_RenderBuiltins;

		// Token: 0x040001EF RID: 495
		[Token(Token = "0x40001EF")]
		[FieldOffset(Offset = "0x138")]
		private static __XLua_Gen_Delegate18 __Hotfix0_RenderFinalPass;

		// Token: 0x040001F0 RID: 496
		[Token(Token = "0x40001F0")]
		[FieldOffset(Offset = "0x140")]
		private static __XLua_Gen_Delegate8 __Hotfix0_ShouldGenerateLogHistogram;

		// Token: 0x040001F1 RID: 497
		[Token(Token = "0x40001F1")]
		[FieldOffset(Offset = "0x148")]
		private static __XLua_Gen_Delegate8 __Hotfix0_HG_ModifyRenderFinalPass;

		// Token: 0x040001F2 RID: 498
		[Token(Token = "0x40001F2")]
		[FieldOffset(Offset = "0x150")]
		private static __XLua_Gen_Delegate8 __Hotfix0_HG_ModifyAntialiasing;

		// Token: 0x040001F3 RID: 499
		[Token(Token = "0x40001F3")]
		[FieldOffset(Offset = "0x158")]
		private static __XLua_Gen_Delegate19 __Hotfix0_HG_ModifyRenderBuiltins;

		// Token: 0x040001F4 RID: 500
		[Token(Token = "0x40001F4")]
		[FieldOffset(Offset = "0x160")]
		private static __XLua_Gen_Delegate19 __Hotfix0_HG_ModifyRenderBuiltins_LWRP;

		// Token: 0x040001F5 RID: 501
		[Token(Token = "0x40001F5")]
		[FieldOffset(Offset = "0x168")]
		private static __XLua_Gen_Delegate20 __Hotfix0_HG_ModifyBuildCommandBuffers;

		// Token: 0x040001F6 RID: 502
		[Token(Token = "0x40001F6")]
		[FieldOffset(Offset = "0x170")]
		private static __XLua_Gen_Delegate6 _c__Hotfix0_ctor;

		// Token: 0x02000074 RID: 116
		[Token(Token = "0x2000074")]
		public enum Antialiasing
		{
			// Token: 0x040001F8 RID: 504
			[Token(Token = "0x40001F8")]
			None,
			// Token: 0x040001F9 RID: 505
			[Token(Token = "0x40001F9")]
			FastApproximateAntialiasing,
			// Token: 0x040001FA RID: 506
			[Token(Token = "0x40001FA")]
			SubpixelMorphologicalAntialiasing,
			// Token: 0x040001FB RID: 507
			[Token(Token = "0x40001FB")]
			TemporalAntialiasing
		}

		// Token: 0x02000075 RID: 117
		[Token(Token = "0x2000075")]
		[Serializable]
		public sealed class SerializedBundleRef
		{
			// Token: 0x0600016A RID: 362 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x600016A")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SerializedBundleRef()
			{
			}

			// Token: 0x040001FC RID: 508
			[Token(Token = "0x40001FC")]
			[FieldOffset(Offset = "0x10")]
			public string assemblyQualifiedName;

			// Token: 0x040001FD RID: 509
			[Token(Token = "0x40001FD")]
			[FieldOffset(Offset = "0x18")]
			public PostProcessBundle bundle;
		}
	}
}
