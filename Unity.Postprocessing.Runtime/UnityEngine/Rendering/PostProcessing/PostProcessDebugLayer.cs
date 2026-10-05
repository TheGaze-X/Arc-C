using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x0200006B RID: 107
	[Token(Token = "0x200006B")]
	[Serializable]
	public sealed class PostProcessDebugLayer
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600010D RID: 269 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x0600010E RID: 270 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000008")]
		public RenderTexture debugOverlayTarget
		{
			[Token(Token = "0x600010D")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600010E")]
			[Address(RVA = "0x54AEC0", Offset = "0x549AC0", VA = "0x18054AEC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600010F RID: 271 RVA: 0x000025DC File Offset: 0x000007DC
		// (set) Token: 0x06000110 RID: 272 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000009")]
		public bool debugOverlayActive
		{
			[Token(Token = "0x600010F")]
			[Address(RVA = "0x16647A0", Offset = "0x16633A0", VA = "0x1816647A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000110")]
			[Address(RVA = "0x16647B0", Offset = "0x16633B0", VA = "0x1816647B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000111 RID: 273 RVA: 0x000025F4 File Offset: 0x000007F4
		// (set) Token: 0x06000112 RID: 274 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700000A")]
		public DebugOverlay debugOverlay
		{
			[Token(Token = "0x6000111")]
			[Address(RVA = "0x150B0C0", Offset = "0x1509CC0", VA = "0x18150B0C0")]
			[CompilerGenerated]
			get
			{
				return DebugOverlay.None;
			}
			[Token(Token = "0x6000112")]
			[Address(RVA = "0x150B100", Offset = "0x1509D00", VA = "0x18150B100")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000113 RID: 275 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000113")]
		[Address(RVA = "0x5832210", Offset = "0x5830E10", VA = "0x185832210")]
		internal void OnEnable()
		{
		}

		// Token: 0x06000114 RID: 276 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000114")]
		[Address(RVA = "0x5831FF0", Offset = "0x5830BF0", VA = "0x185831FF0")]
		internal void OnDisable()
		{
		}

		// Token: 0x06000115 RID: 277 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x5831D40", Offset = "0x5830940", VA = "0x185831D40")]
		private void DestroyDebugOverlayTarget()
		{
		}

		// Token: 0x06000116 RID: 278 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x5833500", Offset = "0x5832100", VA = "0x185833500")]
		public void RequestMonitorPass(MonitorType monitor)
		{
		}

		// Token: 0x06000117 RID: 279 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000117")]
		[Address(RVA = "0x150B100", Offset = "0x1509D00", VA = "0x18150B100")]
		public void RequestDebugOverlay(DebugOverlay mode)
		{
		}

		// Token: 0x06000118 RID: 280 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000118")]
		[Address(RVA = "0x5833560", Offset = "0x5832160", VA = "0x185833560")]
		internal void SetFrameSize(int width, int height)
		{
		}

		// Token: 0x06000119 RID: 281 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000119")]
		[Address(RVA = "0x58324F0", Offset = "0x58310F0", VA = "0x1858324F0")]
		public void PushDebugOverlay(CommandBuffer cmd, RenderTargetIdentifier source, PropertySheet sheet, int pass)
		{
		}

		// Token: 0x0600011A RID: 282 RVA: 0x0000260C File Offset: 0x0000080C
		[Token(Token = "0x600011A")]
		[Address(RVA = "0x5831FC0", Offset = "0x5830BC0", VA = "0x185831FC0")]
		internal DepthTextureMode GetCameraFlags()
		{
			return DepthTextureMode.None;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x58327E0", Offset = "0x58313E0", VA = "0x1858327E0")]
		internal void RenderMonitors(PostProcessRenderContext context)
		{
		}

		// Token: 0x0600011C RID: 284 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x5832EA0", Offset = "0x5831AA0", VA = "0x185832EA0")]
		internal void RenderSpecialOverlays(PostProcessRenderContext context)
		{
		}

		// Token: 0x0600011D RID: 285 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600011D")]
		[Address(RVA = "0x5831DB0", Offset = "0x58309B0", VA = "0x185831DB0")]
		internal void EndFrame()
		{
		}

		// Token: 0x0600011E RID: 286 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600011E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PostProcessDebugLayer()
		{
		}

		// Token: 0x04000187 RID: 391
		[Token(Token = "0x4000187")]
		[FieldOffset(Offset = "0x10")]
		public LightMeterMonitor lightMeter;

		// Token: 0x04000188 RID: 392
		[Token(Token = "0x4000188")]
		[FieldOffset(Offset = "0x18")]
		public HistogramMonitor histogram;

		// Token: 0x04000189 RID: 393
		[Token(Token = "0x4000189")]
		[FieldOffset(Offset = "0x20")]
		public WaveformMonitor waveform;

		// Token: 0x0400018A RID: 394
		[Token(Token = "0x400018A")]
		[FieldOffset(Offset = "0x28")]
		public VectorscopeMonitor vectorscope;

		// Token: 0x0400018B RID: 395
		[Token(Token = "0x400018B")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<MonitorType, Monitor> m_Monitors;

		// Token: 0x0400018C RID: 396
		[Token(Token = "0x400018C")]
		[FieldOffset(Offset = "0x38")]
		private int frameWidth;

		// Token: 0x0400018D RID: 397
		[Token(Token = "0x400018D")]
		[FieldOffset(Offset = "0x3C")]
		private int frameHeight;

		// Token: 0x04000191 RID: 401
		[Token(Token = "0x4000191")]
		[FieldOffset(Offset = "0x50")]
		public PostProcessDebugLayer.OverlaySettings overlaySettings;

		// Token: 0x0200006C RID: 108
		[Token(Token = "0x200006C")]
		[Serializable]
		public class OverlaySettings
		{
			// Token: 0x0600011F RID: 287 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x600011F")]
			[Address(RVA = "0x58319D0", Offset = "0x58305D0", VA = "0x1858319D0")]
			public OverlaySettings()
			{
			}

			// Token: 0x04000192 RID: 402
			[Token(Token = "0x4000192")]
			[FieldOffset(Offset = "0x10")]
			public bool linearDepth;

			// Token: 0x04000193 RID: 403
			[Token(Token = "0x4000193")]
			[FieldOffset(Offset = "0x14")]
			[Range(0f, 16f)]
			public float motionColorIntensity;

			// Token: 0x04000194 RID: 404
			[Token(Token = "0x4000194")]
			[FieldOffset(Offset = "0x18")]
			[Range(4f, 128f)]
			public int motionGridSize;

			// Token: 0x04000195 RID: 405
			[Token(Token = "0x4000195")]
			[FieldOffset(Offset = "0x1C")]
			public ColorBlindnessType colorBlindnessType;

			// Token: 0x04000196 RID: 406
			[Token(Token = "0x4000196")]
			[FieldOffset(Offset = "0x20")]
			[Range(0f, 1f)]
			public float colorBlindnessStrength;
		}
	}
}
