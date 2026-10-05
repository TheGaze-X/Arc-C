using System;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000D8 RID: 216
	[Token(Token = "0x20000D8")]
	[Serializable]
	public class ScreenSpaceReflectionModel : PostProcessingModel
	{
		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060003A3 RID: 931 RVA: 0x00003588 File Offset: 0x00001788
		// (set) Token: 0x060003A4 RID: 932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000071")]
		public ScreenSpaceReflectionModel.Settings settings
		{
			[Token(Token = "0x60003A3")]
			[Address(RVA = "0x54320C0", Offset = "0x5430CC0", VA = "0x1854320C0")]
			get
			{
				return default(ScreenSpaceReflectionModel.Settings);
			}
			[Token(Token = "0x60003A4")]
			[Address(RVA = "0x54320F0", Offset = "0x5430CF0", VA = "0x1854320F0")]
			set
			{
			}
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x5431F70", Offset = "0x5430B70", VA = "0x185431F70", Slot = "4")]
		public override void Reset()
		{
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x5432010", Offset = "0x5430C10", VA = "0x185432010")]
		public ScreenSpaceReflectionModel()
		{
		}

		// Token: 0x040004E5 RID: 1253
		[Token(Token = "0x40004E5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ScreenSpaceReflectionModel.Settings m_Settings;

		// Token: 0x020000D9 RID: 217
		[Token(Token = "0x20000D9")]
		public enum SSRResolution
		{
			// Token: 0x040004E7 RID: 1255
			[Token(Token = "0x40004E7")]
			High,
			// Token: 0x040004E8 RID: 1256
			[Token(Token = "0x40004E8")]
			Low = 2
		}

		// Token: 0x020000DA RID: 218
		[Token(Token = "0x20000DA")]
		public enum SSRReflectionBlendType
		{
			// Token: 0x040004EA RID: 1258
			[Token(Token = "0x40004EA")]
			PhysicallyBased,
			// Token: 0x040004EB RID: 1259
			[Token(Token = "0x40004EB")]
			Additive
		}

		// Token: 0x020000DB RID: 219
		[Token(Token = "0x20000DB")]
		[Serializable]
		public struct IntensitySettings
		{
			// Token: 0x040004EC RID: 1260
			[Token(Token = "0x40004EC")]
			[FieldOffset(Offset = "0x0")]
			[Tooltip("Nonphysical multiplier for the SSR reflections. 1.0 is physically based.")]
			[Range(0f, 2f)]
			public float reflectionMultiplier;

			// Token: 0x040004ED RID: 1261
			[Token(Token = "0x40004ED")]
			[FieldOffset(Offset = "0x4")]
			[Tooltip("How far away from the maxDistance to begin fading SSR.")]
			[Range(0f, 1000f)]
			public float fadeDistance;

			// Token: 0x040004EE RID: 1262
			[Token(Token = "0x40004EE")]
			[FieldOffset(Offset = "0x8")]
			[Tooltip("Amplify Fresnel fade out. Increase if floor reflections look good close to the surface and bad farther 'under' the floor.")]
			[Range(0f, 1f)]
			public float fresnelFade;

			// Token: 0x040004EF RID: 1263
			[Token(Token = "0x40004EF")]
			[FieldOffset(Offset = "0xC")]
			[Range(0.1f, 10f)]
			[Tooltip("Higher values correspond to a faster Fresnel fade as the reflection changes from the grazing angle.")]
			public float fresnelFadePower;
		}

		// Token: 0x020000DC RID: 220
		[Token(Token = "0x20000DC")]
		[Serializable]
		public struct ReflectionSettings
		{
			// Token: 0x040004F0 RID: 1264
			[Token(Token = "0x40004F0")]
			[FieldOffset(Offset = "0x0")]
			[Tooltip("How the reflections are blended into the render.")]
			public ScreenSpaceReflectionModel.SSRReflectionBlendType blendType;

			// Token: 0x040004F1 RID: 1265
			[Token(Token = "0x40004F1")]
			[FieldOffset(Offset = "0x4")]
			[Tooltip("Half resolution SSRR is much faster, but less accurate.")]
			public ScreenSpaceReflectionModel.SSRResolution reflectionQuality;

			// Token: 0x040004F2 RID: 1266
			[Token(Token = "0x40004F2")]
			[FieldOffset(Offset = "0x8")]
			[Range(0.1f, 300f)]
			[Tooltip("Maximum reflection distance in world units.")]
			public float maxDistance;

			// Token: 0x040004F3 RID: 1267
			[Token(Token = "0x40004F3")]
			[FieldOffset(Offset = "0xC")]
			[Range(16f, 1024f)]
			[Tooltip("Max raytracing length.")]
			public int iterationCount;

			// Token: 0x040004F4 RID: 1268
			[Token(Token = "0x40004F4")]
			[FieldOffset(Offset = "0x10")]
			[Tooltip("Log base 2 of ray tracing coarse step size. Higher traces farther, lower gives better quality silhouettes.")]
			[Range(1f, 16f)]
			public int stepSize;

			// Token: 0x040004F5 RID: 1269
			[Token(Token = "0x40004F5")]
			[FieldOffset(Offset = "0x14")]
			[Range(0.01f, 10f)]
			[Tooltip("Typical thickness of columns, walls, furniture, and other objects that reflection rays might pass behind.")]
			public float widthModifier;

			// Token: 0x040004F6 RID: 1270
			[Token(Token = "0x40004F6")]
			[FieldOffset(Offset = "0x18")]
			[Tooltip("Blurriness of reflections.")]
			[Range(0.1f, 8f)]
			public float reflectionBlur;

			// Token: 0x040004F7 RID: 1271
			[Token(Token = "0x40004F7")]
			[FieldOffset(Offset = "0x1C")]
			[Tooltip("Enable for a performance gain in scenes where most glossy objects are horizontal, like floors, water, and tables. Leave on for scenes with glossy vertical objects.")]
			public bool reflectBackfaces;
		}

		// Token: 0x020000DD RID: 221
		[Token(Token = "0x20000DD")]
		[Serializable]
		public struct ScreenEdgeMask
		{
			// Token: 0x040004F8 RID: 1272
			[Token(Token = "0x40004F8")]
			[FieldOffset(Offset = "0x0")]
			[Range(0f, 1f)]
			[Tooltip("Higher = fade out SSRR near the edge of the screen so that reflections don't pop under camera motion.")]
			public float intensity;
		}

		// Token: 0x020000DE RID: 222
		[Token(Token = "0x20000DE")]
		[Serializable]
		public struct Settings
		{
			// Token: 0x17000072 RID: 114
			// (get) Token: 0x060003A7 RID: 935 RVA: 0x000035A0 File Offset: 0x000017A0
			[Token(Token = "0x17000072")]
			public static ScreenSpaceReflectionModel.Settings defaultSettings
			{
				[Token(Token = "0x60003A7")]
				[Address(RVA = "0x5432250", Offset = "0x5430E50", VA = "0x185432250")]
				get
				{
					return default(ScreenSpaceReflectionModel.Settings);
				}
			}

			// Token: 0x040004F9 RID: 1273
			[Token(Token = "0x40004F9")]
			[FieldOffset(Offset = "0x0")]
			public ScreenSpaceReflectionModel.ReflectionSettings reflection;

			// Token: 0x040004FA RID: 1274
			[Token(Token = "0x40004FA")]
			[FieldOffset(Offset = "0x20")]
			public ScreenSpaceReflectionModel.IntensitySettings intensity;

			// Token: 0x040004FB RID: 1275
			[Token(Token = "0x40004FB")]
			[FieldOffset(Offset = "0x30")]
			public ScreenSpaceReflectionModel.ScreenEdgeMask screenEdgeMask;
		}
	}
}
