using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x0200007F RID: 127
	[Token(Token = "0x200007F")]
	public sealed class PostProcessRenderContext
	{
		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600019B RID: 411 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x0600019C RID: 412 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000013")]
		public Camera camera
		{
			[Token(Token = "0x600019B")]
			[Address(RVA = "0x5842CA0", Offset = "0x58418A0", VA = "0x185842CA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600019C")]
			[Address(RVA = "0x58435E0", Offset = "0x58421E0", VA = "0x1858435E0")]
			set
			{
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600019D RID: 413 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x0600019E RID: 414 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000014")]
		public CommandBuffer command
		{
			[Token(Token = "0x600019D")]
			[Address(RVA = "0x5842D00", Offset = "0x5841900", VA = "0x185842D00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600019E")]
			[Address(RVA = "0x58439A0", Offset = "0x58425A0", VA = "0x1858439A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600019F RID: 415 RVA: 0x00002984 File Offset: 0x00000B84
		// (set) Token: 0x060001A0 RID: 416 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000015")]
		public RenderTargetIdentifier source
		{
			[Token(Token = "0x600019F")]
			[Address(RVA = "0x5843220", Offset = "0x5841E20", VA = "0x185843220")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetIdentifier);
			}
			[Token(Token = "0x60001A0")]
			[Address(RVA = "0x5843FA0", Offset = "0x5842BA0", VA = "0x185843FA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x0000299C File Offset: 0x00000B9C
		// (set) Token: 0x060001A2 RID: 418 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000016")]
		public RenderTargetIdentifier destination
		{
			[Token(Token = "0x60001A1")]
			[Address(RVA = "0x5842DD0", Offset = "0x58419D0", VA = "0x185842DD0")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetIdentifier);
			}
			[Token(Token = "0x60001A2")]
			[Address(RVA = "0x5843AA0", Offset = "0x58426A0", VA = "0x185843AA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x000029B4 File Offset: 0x00000BB4
		// (set) Token: 0x060001A4 RID: 420 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000017")]
		public RenderTextureFormat sourceFormat
		{
			[Token(Token = "0x60001A3")]
			[Address(RVA = "0x58431C0", Offset = "0x5841DC0", VA = "0x1858431C0")]
			[CompilerGenerated]
			get
			{
				return RenderTextureFormat.ARGB32;
			}
			[Token(Token = "0x60001A4")]
			[Address(RVA = "0x5843F30", Offset = "0x5842B30", VA = "0x185843F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x000029CC File Offset: 0x00000BCC
		// (set) Token: 0x060001A6 RID: 422 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000018")]
		public bool flip
		{
			[Token(Token = "0x60001A5")]
			[Address(RVA = "0x5842E70", Offset = "0x5841A70", VA = "0x185842E70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001A6")]
			[Address(RVA = "0x5843B40", Offset = "0x5842740", VA = "0x185843B40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x060001A8 RID: 424 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000019")]
		public PostProcessResources resources
		{
			[Token(Token = "0x60001A7")]
			[Address(RVA = "0x5843080", Offset = "0x5841C80", VA = "0x185843080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001A8")]
			[Address(RVA = "0x5843DB0", Offset = "0x58429B0", VA = "0x185843DB0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x060001AA RID: 426 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700001A")]
		public PropertySheetFactory propertySheets
		{
			[Token(Token = "0x60001A9")]
			[Address(RVA = "0x5843020", Offset = "0x5841C20", VA = "0x185843020")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001AA")]
			[Address(RVA = "0x5843D30", Offset = "0x5842930", VA = "0x185843D30")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060001AB RID: 427 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x060001AC RID: 428 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700001B")]
		public Dictionary<string, object> userData
		{
			[Token(Token = "0x60001AB")]
			[Address(RVA = "0x5843410", Offset = "0x5842010", VA = "0x185843410")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001AC")]
			[Address(RVA = "0x58441C0", Offset = "0x5842DC0", VA = "0x1858441C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060001AD RID: 429 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x060001AE RID: 430 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700001C")]
		public PostProcessDebugLayer debugLayer
		{
			[Token(Token = "0x60001AD")]
			[Address(RVA = "0x5842D60", Offset = "0x5841960", VA = "0x185842D60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001AE")]
			[Address(RVA = "0x5843A20", Offset = "0x5842620", VA = "0x185843A20")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060001AF RID: 431 RVA: 0x000029E4 File Offset: 0x00000BE4
		// (set) Token: 0x060001B0 RID: 432 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700001D")]
		public int width
		{
			[Token(Token = "0x60001AF")]
			[Address(RVA = "0x5843480", Offset = "0x5842080", VA = "0x185843480")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60001B0")]
			[Address(RVA = "0x5844240", Offset = "0x5842E40", VA = "0x185844240")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x000029FC File Offset: 0x00000BFC
		// (set) Token: 0x060001B2 RID: 434 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700001E")]
		public int height
		{
			[Token(Token = "0x60001B1")]
			[Address(RVA = "0x5842ED0", Offset = "0x5841AD0", VA = "0x185842ED0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60001B2")]
			[Address(RVA = "0x5843BB0", Offset = "0x58427B0", VA = "0x185843BB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x00002A14 File Offset: 0x00000C14
		// (set) Token: 0x060001B4 RID: 436 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700001F")]
		public bool stereoActive
		{
			[Token(Token = "0x60001B3")]
			[Address(RVA = "0x58432C0", Offset = "0x5841EC0", VA = "0x1858432C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0x5844040", Offset = "0x5842C40", VA = "0x185844040")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x00002A2C File Offset: 0x00000C2C
		// (set) Token: 0x060001B6 RID: 438 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000020")]
		public int xrActiveEye
		{
			[Token(Token = "0x60001B5")]
			[Address(RVA = "0x58434F0", Offset = "0x58420F0", VA = "0x1858434F0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60001B6")]
			[Address(RVA = "0x58442C0", Offset = "0x5842EC0", VA = "0x1858442C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x00002A44 File Offset: 0x00000C44
		// (set) Token: 0x060001B8 RID: 440 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000021")]
		public int numberOfEyes
		{
			[Token(Token = "0x60001B7")]
			[Address(RVA = "0x5842FB0", Offset = "0x5841BB0", VA = "0x185842FB0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0x5843CB0", Offset = "0x58428B0", VA = "0x185843CB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x00002A5C File Offset: 0x00000C5C
		// (set) Token: 0x060001BA RID: 442 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000022")]
		public PostProcessRenderContext.StereoRenderingMode stereoRenderingMode
		{
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0x5843330", Offset = "0x5841F30", VA = "0x185843330")]
			[CompilerGenerated]
			get
			{
				return PostProcessRenderContext.StereoRenderingMode.MultiPass;
			}
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0x58440C0", Offset = "0x5842CC0", VA = "0x1858440C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060001BB RID: 443 RVA: 0x00002A74 File Offset: 0x00000C74
		// (set) Token: 0x060001BC RID: 444 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000023")]
		public int screenWidth
		{
			[Token(Token = "0x60001BB")]
			[Address(RVA = "0x5843150", Offset = "0x5841D50", VA = "0x185843150")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0x5843EB0", Offset = "0x5842AB0", VA = "0x185843EB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060001BD RID: 445 RVA: 0x00002A8C File Offset: 0x00000C8C
		// (set) Token: 0x060001BE RID: 446 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000024")]
		public int screenHeight
		{
			[Token(Token = "0x60001BD")]
			[Address(RVA = "0x58430E0", Offset = "0x5841CE0", VA = "0x1858430E0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x5843E30", Offset = "0x5842A30", VA = "0x185843E30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060001BF RID: 447 RVA: 0x00002AA4 File Offset: 0x00000CA4
		// (set) Token: 0x060001C0 RID: 448 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000025")]
		public bool isSceneView
		{
			[Token(Token = "0x60001BF")]
			[Address(RVA = "0x5842F40", Offset = "0x5841B40", VA = "0x185842F40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001C0")]
			[Address(RVA = "0x5843C30", Offset = "0x5842830", VA = "0x185843C30")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x00002ABC File Offset: 0x00000CBC
		// (set) Token: 0x060001C2 RID: 450 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000026")]
		public PostProcessLayer.Antialiasing antialiasing
		{
			[Token(Token = "0x60001C1")]
			[Address(RVA = "0x5842C30", Offset = "0x5841830", VA = "0x185842C30")]
			[CompilerGenerated]
			get
			{
				return PostProcessLayer.Antialiasing.None;
			}
			[Token(Token = "0x60001C2")]
			[Address(RVA = "0x5843560", Offset = "0x5842160", VA = "0x185843560")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060001C3 RID: 451 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x060001C4 RID: 452 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000027")]
		public TemporalAntialiasing temporalAntialiasing
		{
			[Token(Token = "0x60001C3")]
			[Address(RVA = "0x58433A0", Offset = "0x5841FA0", VA = "0x1858433A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001C4")]
			[Address(RVA = "0x5844140", Offset = "0x5842D40", VA = "0x185844140")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x5842680", Offset = "0x5841280", VA = "0x185842680")]
		public void Reset()
		{
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00002AD4 File Offset: 0x00000CD4
		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x58423F0", Offset = "0x5840FF0", VA = "0x1858423F0")]
		public bool IsTemporalAntialiasingActive()
		{
			return default(bool);
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00002AEC File Offset: 0x00000CEC
		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x5842320", Offset = "0x5840F20", VA = "0x185842320")]
		public bool IsDebugOverlayEnabled(DebugOverlay overlay)
		{
			return default(bool);
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x5842520", Offset = "0x5841120", VA = "0x185842520")]
		public void PushDebugOverlay(CommandBuffer cmd, RenderTargetIdentifier source, PropertySheet sheet, int pass)
		{
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00002B04 File Offset: 0x00000D04
		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x5841D80", Offset = "0x5840980", VA = "0x185841D80")]
		internal RenderTextureDescriptor GetDescriptor(int depthBufferBits = 0, RenderTextureFormat colorFormat = RenderTextureFormat.Default, RenderTextureReadWrite readWrite = RenderTextureReadWrite.Default)
		{
			return default(RenderTextureDescriptor);
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x5841FE0", Offset = "0x5840BE0", VA = "0x185841FE0")]
		public void GetScreenSpaceTemporaryRT(CommandBuffer cmd, int nameID, int depthBufferBits = 0, RenderTextureFormat colorFormat = RenderTextureFormat.Default, RenderTextureReadWrite readWrite = RenderTextureReadWrite.Default, FilterMode filter = FilterMode.Bilinear, int widthOverride = 0, int heightOverride = 0)
		{
		}

		// Token: 0x060001CB RID: 459 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x5842200", Offset = "0x5840E00", VA = "0x185842200")]
		public RenderTexture GetScreenSpaceTemporaryRT(int depthBufferBits = 0, RenderTextureFormat colorFormat = RenderTextureFormat.Default, RenderTextureReadWrite readWrite = RenderTextureReadWrite.Default, int widthOverride = 0, int heightOverride = 0)
		{
			return null;
		}

		// Token: 0x060001CC RID: 460 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x5842BC0", Offset = "0x58417C0", VA = "0x185842BC0")]
		public PostProcessRenderContext()
		{
		}

		// Token: 0x04000213 RID: 531
		[Token(Token = "0x4000213")]
		[FieldOffset(Offset = "0x10")]
		private Camera m_Camera;

		// Token: 0x04000228 RID: 552
		[Token(Token = "0x4000228")]
		[FieldOffset(Offset = "0xC8")]
		internal PropertySheet uberSheet;

		// Token: 0x04000229 RID: 553
		[Token(Token = "0x4000229")]
		[FieldOffset(Offset = "0xD0")]
		internal Texture autoExposureTexture;

		// Token: 0x0400022A RID: 554
		[Token(Token = "0x400022A")]
		[FieldOffset(Offset = "0xD8")]
		internal LogHistogram logHistogram;

		// Token: 0x0400022B RID: 555
		[Token(Token = "0x400022B")]
		[FieldOffset(Offset = "0xE0")]
		internal Texture logLut;

		// Token: 0x0400022C RID: 556
		[Token(Token = "0x400022C")]
		[FieldOffset(Offset = "0xE8")]
		internal AutoExposure autoExposure;

		// Token: 0x0400022D RID: 557
		[Token(Token = "0x400022D")]
		[FieldOffset(Offset = "0xF0")]
		internal int bloomBufferNameID;

		// Token: 0x0400022E RID: 558
		[Token(Token = "0x400022E")]
		[FieldOffset(Offset = "0xF4")]
		internal int blurBufferNameID;

		// Token: 0x0400022F RID: 559
		[Token(Token = "0x400022F")]
		[FieldOffset(Offset = "0xF8")]
		internal bool physicalCamera;

		// Token: 0x04000230 RID: 560
		[Token(Token = "0x4000230")]
		[FieldOffset(Offset = "0xFC")]
		private RenderTextureDescriptor m_sourceDescriptor;

		// Token: 0x04000231 RID: 561
		[Token(Token = "0x4000231")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate21 __Hotfix0_get_camera;

		// Token: 0x04000232 RID: 562
		[Token(Token = "0x4000232")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate2 __Hotfix0_set_camera;

		// Token: 0x04000233 RID: 563
		[Token(Token = "0x4000233")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate22 __Hotfix0_get_command;

		// Token: 0x04000234 RID: 564
		[Token(Token = "0x4000234")]
		[FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate2 __Hotfix0_set_command;

		// Token: 0x04000235 RID: 565
		[Token(Token = "0x4000235")]
		[FieldOffset(Offset = "0x20")]
		private static __XLua_Gen_Delegate23 __Hotfix0_get_source;

		// Token: 0x04000236 RID: 566
		[Token(Token = "0x4000236")]
		[FieldOffset(Offset = "0x28")]
		private static __XLua_Gen_Delegate24 __Hotfix0_set_source;

		// Token: 0x04000237 RID: 567
		[Token(Token = "0x4000237")]
		[FieldOffset(Offset = "0x30")]
		private static __XLua_Gen_Delegate23 __Hotfix0_get_destination;

		// Token: 0x04000238 RID: 568
		[Token(Token = "0x4000238")]
		[FieldOffset(Offset = "0x38")]
		private static __XLua_Gen_Delegate24 __Hotfix0_set_destination;

		// Token: 0x04000239 RID: 569
		[Token(Token = "0x4000239")]
		[FieldOffset(Offset = "0x40")]
		private static __XLua_Gen_Delegate25 __Hotfix0_get_sourceFormat;

		// Token: 0x0400023A RID: 570
		[Token(Token = "0x400023A")]
		[FieldOffset(Offset = "0x48")]
		private static __XLua_Gen_Delegate26 __Hotfix0_set_sourceFormat;

		// Token: 0x0400023B RID: 571
		[Token(Token = "0x400023B")]
		[FieldOffset(Offset = "0x50")]
		private static __XLua_Gen_Delegate0 __Hotfix0_get_flip;

		// Token: 0x0400023C RID: 572
		[Token(Token = "0x400023C")]
		[FieldOffset(Offset = "0x58")]
		private static __XLua_Gen_Delegate5 __Hotfix0_set_flip;

		// Token: 0x0400023D RID: 573
		[Token(Token = "0x400023D")]
		[FieldOffset(Offset = "0x60")]
		private static __XLua_Gen_Delegate27 __Hotfix0_get_resources;

		// Token: 0x0400023E RID: 574
		[Token(Token = "0x400023E")]
		[FieldOffset(Offset = "0x68")]
		private static __XLua_Gen_Delegate2 __Hotfix0_set_resources;

		// Token: 0x0400023F RID: 575
		[Token(Token = "0x400023F")]
		[FieldOffset(Offset = "0x70")]
		private static __XLua_Gen_Delegate28 __Hotfix0_get_propertySheets;

		// Token: 0x04000240 RID: 576
		[Token(Token = "0x4000240")]
		[FieldOffset(Offset = "0x78")]
		private static __XLua_Gen_Delegate2 __Hotfix0_set_propertySheets;

		// Token: 0x04000241 RID: 577
		[Token(Token = "0x4000241")]
		[FieldOffset(Offset = "0x80")]
		private static __XLua_Gen_Delegate29 __Hotfix0_get_userData;

		// Token: 0x04000242 RID: 578
		[Token(Token = "0x4000242")]
		[FieldOffset(Offset = "0x88")]
		private static __XLua_Gen_Delegate2 __Hotfix0_set_userData;

		// Token: 0x04000243 RID: 579
		[Token(Token = "0x4000243")]
		[FieldOffset(Offset = "0x90")]
		private static __XLua_Gen_Delegate30 __Hotfix0_get_debugLayer;

		// Token: 0x04000244 RID: 580
		[Token(Token = "0x4000244")]
		[FieldOffset(Offset = "0x98")]
		private static __XLua_Gen_Delegate2 __Hotfix0_set_debugLayer;

		// Token: 0x04000245 RID: 581
		[Token(Token = "0x4000245")]
		[FieldOffset(Offset = "0xA0")]
		private static __XLua_Gen_Delegate31 __Hotfix0_get_width;

		// Token: 0x04000246 RID: 582
		[Token(Token = "0x4000246")]
		[FieldOffset(Offset = "0xA8")]
		private static __XLua_Gen_Delegate32 __Hotfix0_set_width;

		// Token: 0x04000247 RID: 583
		[Token(Token = "0x4000247")]
		[FieldOffset(Offset = "0xB0")]
		private static __XLua_Gen_Delegate31 __Hotfix0_get_height;

		// Token: 0x04000248 RID: 584
		[Token(Token = "0x4000248")]
		[FieldOffset(Offset = "0xB8")]
		private static __XLua_Gen_Delegate32 __Hotfix0_set_height;

		// Token: 0x04000249 RID: 585
		[Token(Token = "0x4000249")]
		[FieldOffset(Offset = "0xC0")]
		private static __XLua_Gen_Delegate0 __Hotfix0_get_stereoActive;

		// Token: 0x0400024A RID: 586
		[Token(Token = "0x400024A")]
		[FieldOffset(Offset = "0xC8")]
		private static __XLua_Gen_Delegate5 __Hotfix0_set_stereoActive;

		// Token: 0x0400024B RID: 587
		[Token(Token = "0x400024B")]
		[FieldOffset(Offset = "0xD0")]
		private static __XLua_Gen_Delegate31 __Hotfix0_get_xrActiveEye;

		// Token: 0x0400024C RID: 588
		[Token(Token = "0x400024C")]
		[FieldOffset(Offset = "0xD8")]
		private static __XLua_Gen_Delegate32 __Hotfix0_set_xrActiveEye;

		// Token: 0x0400024D RID: 589
		[Token(Token = "0x400024D")]
		[FieldOffset(Offset = "0xE0")]
		private static __XLua_Gen_Delegate31 __Hotfix0_get_numberOfEyes;

		// Token: 0x0400024E RID: 590
		[Token(Token = "0x400024E")]
		[FieldOffset(Offset = "0xE8")]
		private static __XLua_Gen_Delegate32 __Hotfix0_set_numberOfEyes;

		// Token: 0x0400024F RID: 591
		[Token(Token = "0x400024F")]
		[FieldOffset(Offset = "0xF0")]
		private static __XLua_Gen_Delegate33 __Hotfix0_get_stereoRenderingMode;

		// Token: 0x04000250 RID: 592
		[Token(Token = "0x4000250")]
		[FieldOffset(Offset = "0xF8")]
		private static __XLua_Gen_Delegate34 __Hotfix0_set_stereoRenderingMode;

		// Token: 0x04000251 RID: 593
		[Token(Token = "0x4000251")]
		[FieldOffset(Offset = "0x100")]
		private static __XLua_Gen_Delegate31 __Hotfix0_get_screenWidth;

		// Token: 0x04000252 RID: 594
		[Token(Token = "0x4000252")]
		[FieldOffset(Offset = "0x108")]
		private static __XLua_Gen_Delegate32 __Hotfix0_set_screenWidth;

		// Token: 0x04000253 RID: 595
		[Token(Token = "0x4000253")]
		[FieldOffset(Offset = "0x110")]
		private static __XLua_Gen_Delegate31 __Hotfix0_get_screenHeight;

		// Token: 0x04000254 RID: 596
		[Token(Token = "0x4000254")]
		[FieldOffset(Offset = "0x118")]
		private static __XLua_Gen_Delegate32 __Hotfix0_set_screenHeight;

		// Token: 0x04000255 RID: 597
		[Token(Token = "0x4000255")]
		[FieldOffset(Offset = "0x120")]
		private static __XLua_Gen_Delegate0 __Hotfix0_get_isSceneView;

		// Token: 0x04000256 RID: 598
		[Token(Token = "0x4000256")]
		[FieldOffset(Offset = "0x128")]
		private static __XLua_Gen_Delegate5 __Hotfix0_set_isSceneView;

		// Token: 0x04000257 RID: 599
		[Token(Token = "0x4000257")]
		[FieldOffset(Offset = "0x130")]
		private static __XLua_Gen_Delegate35 __Hotfix0_get_antialiasing;

		// Token: 0x04000258 RID: 600
		[Token(Token = "0x4000258")]
		[FieldOffset(Offset = "0x138")]
		private static __XLua_Gen_Delegate36 __Hotfix0_set_antialiasing;

		// Token: 0x04000259 RID: 601
		[Token(Token = "0x4000259")]
		[FieldOffset(Offset = "0x140")]
		private static __XLua_Gen_Delegate37 __Hotfix0_get_temporalAntialiasing;

		// Token: 0x0400025A RID: 602
		[Token(Token = "0x400025A")]
		[FieldOffset(Offset = "0x148")]
		private static __XLua_Gen_Delegate2 __Hotfix0_set_temporalAntialiasing;

		// Token: 0x0400025B RID: 603
		[Token(Token = "0x400025B")]
		[FieldOffset(Offset = "0x150")]
		private static __XLua_Gen_Delegate6 __Hotfix0_Reset;

		// Token: 0x0400025C RID: 604
		[Token(Token = "0x400025C")]
		[FieldOffset(Offset = "0x158")]
		private static __XLua_Gen_Delegate0 __Hotfix0_IsTemporalAntialiasingActive;

		// Token: 0x0400025D RID: 605
		[Token(Token = "0x400025D")]
		[FieldOffset(Offset = "0x160")]
		private static __XLua_Gen_Delegate38 __Hotfix0_IsDebugOverlayEnabled;

		// Token: 0x0400025E RID: 606
		[Token(Token = "0x400025E")]
		[FieldOffset(Offset = "0x168")]
		private static __XLua_Gen_Delegate39 __Hotfix0_PushDebugOverlay;

		// Token: 0x0400025F RID: 607
		[Token(Token = "0x400025F")]
		[FieldOffset(Offset = "0x170")]
		private static __XLua_Gen_Delegate40 __Hotfix0_GetDescriptor;

		// Token: 0x04000260 RID: 608
		[Token(Token = "0x4000260")]
		[FieldOffset(Offset = "0x178")]
		private static __XLua_Gen_Delegate41 __Hotfix0_GetScreenSpaceTemporaryRT;

		// Token: 0x04000261 RID: 609
		[Token(Token = "0x4000261")]
		[FieldOffset(Offset = "0x180")]
		private static __XLua_Gen_Delegate42 __Hotfix1_GetScreenSpaceTemporaryRT;

		// Token: 0x04000262 RID: 610
		[Token(Token = "0x4000262")]
		[FieldOffset(Offset = "0x188")]
		private static __XLua_Gen_Delegate6 _c__Hotfix0_ctor;

		// Token: 0x02000080 RID: 128
		[Token(Token = "0x2000080")]
		public enum StereoRenderingMode
		{
			// Token: 0x04000264 RID: 612
			[Token(Token = "0x4000264")]
			MultiPass,
			// Token: 0x04000265 RID: 613
			[Token(Token = "0x4000265")]
			SinglePass,
			// Token: 0x04000266 RID: 614
			[Token(Token = "0x4000266")]
			SinglePassInstanced,
			// Token: 0x04000267 RID: 615
			[Token(Token = "0x4000267")]
			SinglePassMultiview
		}
	}
}
