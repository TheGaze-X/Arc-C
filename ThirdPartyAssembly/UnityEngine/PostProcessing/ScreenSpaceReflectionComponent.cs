using System;
using Il2CppDummyDll;
using UnityEngine.Rendering;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000A0 RID: 160
	[Token(Token = "0x20000A0")]
	public sealed class ScreenSpaceReflectionComponent : PostProcessingComponentCommandBuffer<ScreenSpaceReflectionModel>
	{
		// Token: 0x06000332 RID: 818 RVA: 0x000030A8 File Offset: 0x000012A8
		[Token(Token = "0x6000332")]
		[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40", Slot = "4")]
		public override DepthTextureMode GetCameraFlags()
		{
			return DepthTextureMode.None;
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000333 RID: 819 RVA: 0x000030C0 File Offset: 0x000012C0
		[Token(Token = "0x17000044")]
		public override bool active
		{
			[Token(Token = "0x6000333")]
			[Address(RVA = "0x5431EF0", Offset = "0x5430AF0", VA = "0x185431EF0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000334")]
		[Address(RVA = "0x5430980", Offset = "0x542F580", VA = "0x185430980", Slot = "6")]
		public override void OnEnable()
		{
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000335")]
		[Address(RVA = "0x5430950", Offset = "0x542F550", VA = "0x185430950", Slot = "11")]
		public override string GetName()
		{
			return null;
		}

		// Token: 0x06000336 RID: 822 RVA: 0x000030D8 File Offset: 0x000012D8
		[Token(Token = "0x6000336")]
		[Address(RVA = "0x54AFD0", Offset = "0x549BD0", VA = "0x18054AFD0", Slot = "10")]
		public override CameraEvent GetCameraEvent()
		{
			return CameraEvent.BeforeDepthTexture;
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000337")]
		[Address(RVA = "0x5430AA0", Offset = "0x542F6A0", VA = "0x185430AA0", Slot = "12")]
		public override void PopulateCommandBuffer(CommandBuffer cb)
		{
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000338")]
		[Address(RVA = "0x5431E80", Offset = "0x5430A80", VA = "0x185431E80")]
		public ScreenSpaceReflectionComponent()
		{
		}

		// Token: 0x040003FA RID: 1018
		[Token(Token = "0x40003FA")]
		[FieldOffset(Offset = "0x20")]
		private bool k_HighlightSuppression;

		// Token: 0x040003FB RID: 1019
		[Token(Token = "0x40003FB")]
		[FieldOffset(Offset = "0x21")]
		private bool k_TraceBehindObjects;

		// Token: 0x040003FC RID: 1020
		[Token(Token = "0x40003FC")]
		[FieldOffset(Offset = "0x22")]
		private bool k_TreatBackfaceHitAsMiss;

		// Token: 0x040003FD RID: 1021
		[Token(Token = "0x40003FD")]
		[FieldOffset(Offset = "0x23")]
		private bool k_BilateralUpsample;

		// Token: 0x040003FE RID: 1022
		[Token(Token = "0x40003FE")]
		[FieldOffset(Offset = "0x28")]
		private readonly int[] m_ReflectionTextures;

		// Token: 0x020000A1 RID: 161
		[Token(Token = "0x20000A1")]
		private static class Uniforms
		{
			// Token: 0x040003FF RID: 1023
			[Token(Token = "0x40003FF")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly int _RayStepSize;

			// Token: 0x04000400 RID: 1024
			[Token(Token = "0x4000400")]
			[FieldOffset(Offset = "0x4")]
			internal static readonly int _AdditiveReflection;

			// Token: 0x04000401 RID: 1025
			[Token(Token = "0x4000401")]
			[FieldOffset(Offset = "0x8")]
			internal static readonly int _BilateralUpsampling;

			// Token: 0x04000402 RID: 1026
			[Token(Token = "0x4000402")]
			[FieldOffset(Offset = "0xC")]
			internal static readonly int _TreatBackfaceHitAsMiss;

			// Token: 0x04000403 RID: 1027
			[Token(Token = "0x4000403")]
			[FieldOffset(Offset = "0x10")]
			internal static readonly int _AllowBackwardsRays;

			// Token: 0x04000404 RID: 1028
			[Token(Token = "0x4000404")]
			[FieldOffset(Offset = "0x14")]
			internal static readonly int _TraceBehindObjects;

			// Token: 0x04000405 RID: 1029
			[Token(Token = "0x4000405")]
			[FieldOffset(Offset = "0x18")]
			internal static readonly int _MaxSteps;

			// Token: 0x04000406 RID: 1030
			[Token(Token = "0x4000406")]
			[FieldOffset(Offset = "0x1C")]
			internal static readonly int _FullResolutionFiltering;

			// Token: 0x04000407 RID: 1031
			[Token(Token = "0x4000407")]
			[FieldOffset(Offset = "0x20")]
			internal static readonly int _HalfResolution;

			// Token: 0x04000408 RID: 1032
			[Token(Token = "0x4000408")]
			[FieldOffset(Offset = "0x24")]
			internal static readonly int _HighlightSuppression;

			// Token: 0x04000409 RID: 1033
			[Token(Token = "0x4000409")]
			[FieldOffset(Offset = "0x28")]
			internal static readonly int _PixelsPerMeterAtOneMeter;

			// Token: 0x0400040A RID: 1034
			[Token(Token = "0x400040A")]
			[FieldOffset(Offset = "0x2C")]
			internal static readonly int _ScreenEdgeFading;

			// Token: 0x0400040B RID: 1035
			[Token(Token = "0x400040B")]
			[FieldOffset(Offset = "0x30")]
			internal static readonly int _ReflectionBlur;

			// Token: 0x0400040C RID: 1036
			[Token(Token = "0x400040C")]
			[FieldOffset(Offset = "0x34")]
			internal static readonly int _MaxRayTraceDistance;

			// Token: 0x0400040D RID: 1037
			[Token(Token = "0x400040D")]
			[FieldOffset(Offset = "0x38")]
			internal static readonly int _FadeDistance;

			// Token: 0x0400040E RID: 1038
			[Token(Token = "0x400040E")]
			[FieldOffset(Offset = "0x3C")]
			internal static readonly int _LayerThickness;

			// Token: 0x0400040F RID: 1039
			[Token(Token = "0x400040F")]
			[FieldOffset(Offset = "0x40")]
			internal static readonly int _SSRMultiplier;

			// Token: 0x04000410 RID: 1040
			[Token(Token = "0x4000410")]
			[FieldOffset(Offset = "0x44")]
			internal static readonly int _FresnelFade;

			// Token: 0x04000411 RID: 1041
			[Token(Token = "0x4000411")]
			[FieldOffset(Offset = "0x48")]
			internal static readonly int _FresnelFadePower;

			// Token: 0x04000412 RID: 1042
			[Token(Token = "0x4000412")]
			[FieldOffset(Offset = "0x4C")]
			internal static readonly int _ReflectionBufferSize;

			// Token: 0x04000413 RID: 1043
			[Token(Token = "0x4000413")]
			[FieldOffset(Offset = "0x50")]
			internal static readonly int _ScreenSize;

			// Token: 0x04000414 RID: 1044
			[Token(Token = "0x4000414")]
			[FieldOffset(Offset = "0x54")]
			internal static readonly int _InvScreenSize;

			// Token: 0x04000415 RID: 1045
			[Token(Token = "0x4000415")]
			[FieldOffset(Offset = "0x58")]
			internal static readonly int _ProjInfo;

			// Token: 0x04000416 RID: 1046
			[Token(Token = "0x4000416")]
			[FieldOffset(Offset = "0x5C")]
			internal static readonly int _CameraClipInfo;

			// Token: 0x04000417 RID: 1047
			[Token(Token = "0x4000417")]
			[FieldOffset(Offset = "0x60")]
			internal static readonly int _ProjectToPixelMatrix;

			// Token: 0x04000418 RID: 1048
			[Token(Token = "0x4000418")]
			[FieldOffset(Offset = "0x64")]
			internal static readonly int _WorldToCameraMatrix;

			// Token: 0x04000419 RID: 1049
			[Token(Token = "0x4000419")]
			[FieldOffset(Offset = "0x68")]
			internal static readonly int _CameraToWorldMatrix;

			// Token: 0x0400041A RID: 1050
			[Token(Token = "0x400041A")]
			[FieldOffset(Offset = "0x6C")]
			internal static readonly int _Axis;

			// Token: 0x0400041B RID: 1051
			[Token(Token = "0x400041B")]
			[FieldOffset(Offset = "0x70")]
			internal static readonly int _CurrentMipLevel;

			// Token: 0x0400041C RID: 1052
			[Token(Token = "0x400041C")]
			[FieldOffset(Offset = "0x74")]
			internal static readonly int _NormalAndRoughnessTexture;

			// Token: 0x0400041D RID: 1053
			[Token(Token = "0x400041D")]
			[FieldOffset(Offset = "0x78")]
			internal static readonly int _HitPointTexture;

			// Token: 0x0400041E RID: 1054
			[Token(Token = "0x400041E")]
			[FieldOffset(Offset = "0x7C")]
			internal static readonly int _BlurTexture;

			// Token: 0x0400041F RID: 1055
			[Token(Token = "0x400041F")]
			[FieldOffset(Offset = "0x80")]
			internal static readonly int _FilteredReflections;

			// Token: 0x04000420 RID: 1056
			[Token(Token = "0x4000420")]
			[FieldOffset(Offset = "0x84")]
			internal static readonly int _FinalReflectionTexture;

			// Token: 0x04000421 RID: 1057
			[Token(Token = "0x4000421")]
			[FieldOffset(Offset = "0x88")]
			internal static readonly int _TempTexture;
		}

		// Token: 0x020000A2 RID: 162
		[Token(Token = "0x20000A2")]
		private enum PassIndex
		{
			// Token: 0x04000423 RID: 1059
			[Token(Token = "0x4000423")]
			RayTraceStep,
			// Token: 0x04000424 RID: 1060
			[Token(Token = "0x4000424")]
			CompositeFinal,
			// Token: 0x04000425 RID: 1061
			[Token(Token = "0x4000425")]
			Blur,
			// Token: 0x04000426 RID: 1062
			[Token(Token = "0x4000426")]
			CompositeSSR,
			// Token: 0x04000427 RID: 1063
			[Token(Token = "0x4000427")]
			MinMipGeneration,
			// Token: 0x04000428 RID: 1064
			[Token(Token = "0x4000428")]
			HitPointToReflections,
			// Token: 0x04000429 RID: 1065
			[Token(Token = "0x4000429")]
			BilateralKeyPack,
			// Token: 0x0400042A RID: 1066
			[Token(Token = "0x400042A")]
			BlitDepthAsCSZ,
			// Token: 0x0400042B RID: 1067
			[Token(Token = "0x400042B")]
			PoissonBlur
		}
	}
}
