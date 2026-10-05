using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x0200013E RID: 318
	[Token(Token = "0x200013E")]
	[NativeHeader("Runtime/Camera/RenderLoops/MotionVectorRenderLoop.h")]
	[NativeHeader("Runtime/Misc/SystemInfo.h")]
	[NativeHeader("Runtime/Shaders/GraphicsCapsScriptBindings.h")]
	[NativeHeader("Runtime/Graphics/GraphicsFormatUtility.bindings.h")]
	[NativeHeader("Runtime/Graphics/Mesh/MeshScriptBindings.h")]
	[NativeHeader("Runtime/Input/GetInput.h")]
	public sealed class SystemInfo
	{
		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06000AA0 RID: 2720 RVA: 0x00005FB8 File Offset: 0x000041B8
		[Token(Token = "0x1700020F")]
		[NativeProperty]
		public static float batteryLevel
		{
			[Token(Token = "0x6000AA0")]
			[Address(RVA = "0x5970080", Offset = "0x596EC80", VA = "0x185970080")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000AA1 RID: 2721 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000210")]
		public static string operatingSystem
		{
			[Token(Token = "0x6000AA1")]
			[Address(RVA = "0x59703A0", Offset = "0x596EFA0", VA = "0x1859703A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000AA2 RID: 2722 RVA: 0x00005FD0 File Offset: 0x000041D0
		[Token(Token = "0x17000211")]
		public static OperatingSystemFamily operatingSystemFamily
		{
			[Token(Token = "0x6000AA2")]
			[Address(RVA = "0x5970370", Offset = "0x596EF70", VA = "0x185970370")]
			get
			{
				return OperatingSystemFamily.Other;
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000AA3 RID: 2723 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000212")]
		public static string processorType
		{
			[Token(Token = "0x6000AA3")]
			[Address(RVA = "0x5970460", Offset = "0x596F060", VA = "0x185970460")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000AA4 RID: 2724 RVA: 0x00005FE8 File Offset: 0x000041E8
		[Token(Token = "0x17000213")]
		public static int processorFrequency
		{
			[Token(Token = "0x6000AA4")]
			[Address(RVA = "0x5970430", Offset = "0x596F030", VA = "0x185970430")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000AA5 RID: 2725 RVA: 0x00006000 File Offset: 0x00004200
		[Token(Token = "0x17000214")]
		public static int processorCount
		{
			[Token(Token = "0x6000AA5")]
			[Address(RVA = "0x5970400", Offset = "0x596F000", VA = "0x185970400")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000AA6 RID: 2726 RVA: 0x00006018 File Offset: 0x00004218
		[Token(Token = "0x17000215")]
		public static int systemMemorySize
		{
			[Token(Token = "0x6000AA6")]
			[Address(RVA = "0x59703D0", Offset = "0x596EFD0", VA = "0x1859703D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000AA7 RID: 2727 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000216")]
		public static string deviceUniqueIdentifier
		{
			[Token(Token = "0x6000AA7")]
			[Address(RVA = "0x59701B0", Offset = "0x596EDB0", VA = "0x1859701B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000AA8 RID: 2728 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000217")]
		public static string deviceName
		{
			[Token(Token = "0x6000AA8")]
			[Address(RVA = "0x5970150", Offset = "0x596ED50", VA = "0x185970150")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000AA9 RID: 2729 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000218")]
		public static string deviceModel
		{
			[Token(Token = "0x6000AA9")]
			[Address(RVA = "0x5970120", Offset = "0x596ED20", VA = "0x185970120")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000AAA RID: 2730 RVA: 0x00006030 File Offset: 0x00004230
		[Token(Token = "0x17000219")]
		public static bool supportsGyroscope
		{
			[Token(Token = "0x6000AAA")]
			[Address(RVA = "0x5970540", Offset = "0x596F140", VA = "0x185970540")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000AAB RID: 2731 RVA: 0x00006048 File Offset: 0x00004248
		[Token(Token = "0x1700021A")]
		public static DeviceType deviceType
		{
			[Token(Token = "0x6000AAB")]
			[Address(RVA = "0x5970180", Offset = "0x596ED80", VA = "0x185970180")]
			get
			{
				return DeviceType.Unknown;
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000AAC RID: 2732 RVA: 0x00006060 File Offset: 0x00004260
		[Token(Token = "0x1700021B")]
		public static int graphicsMemorySize
		{
			[Token(Token = "0x6000AAC")]
			[Address(RVA = "0x5970280", Offset = "0x596EE80", VA = "0x185970280")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000AAD RID: 2733 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700021C")]
		public static string graphicsDeviceName
		{
			[Token(Token = "0x6000AAD")]
			[Address(RVA = "0x59701E0", Offset = "0x596EDE0", VA = "0x1859701E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000AAE RID: 2734 RVA: 0x00006078 File Offset: 0x00004278
		[Token(Token = "0x1700021D")]
		public static GraphicsDeviceType graphicsDeviceType
		{
			[Token(Token = "0x6000AAE")]
			[Address(RVA = "0x5970210", Offset = "0x596EE10", VA = "0x185970210")]
			get
			{
				return GraphicsDeviceType.OpenGL2;
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000AAF RID: 2735 RVA: 0x00006090 File Offset: 0x00004290
		[Token(Token = "0x1700021E")]
		public static bool graphicsUVStartsAtTop
		{
			[Token(Token = "0x6000AAF")]
			[Address(RVA = "0x59702E0", Offset = "0x596EEE0", VA = "0x1859702E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000AB0 RID: 2736 RVA: 0x000060A8 File Offset: 0x000042A8
		[Token(Token = "0x1700021F")]
		public static int graphicsShaderLevel
		{
			[Token(Token = "0x6000AB0")]
			[Address(RVA = "0x59702B0", Offset = "0x596EEB0", VA = "0x1859702B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000AB1 RID: 2737 RVA: 0x000060C0 File Offset: 0x000042C0
		[Token(Token = "0x17000220")]
		public static RenderingThreadingMode renderingThreadingMode
		{
			[Token(Token = "0x6000AB1")]
			[Address(RVA = "0x5970490", Offset = "0x596F090", VA = "0x185970490")]
			get
			{
				return RenderingThreadingMode.Direct;
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000AB2 RID: 2738 RVA: 0x000060D8 File Offset: 0x000042D8
		[Token(Token = "0x17000221")]
		public static bool supportsMotionVectors
		{
			[Token(Token = "0x6000AB2")]
			[Address(RVA = "0x5970710", Offset = "0x596F310", VA = "0x185970710")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x06000AB3 RID: 2739 RVA: 0x000060F0 File Offset: 0x000042F0
		[Token(Token = "0x17000222")]
		[Obsolete("supportsImageEffects always returns true, no need to call it")]
		public static bool supportsImageEffects
		{
			[Token(Token = "0x6000AB3")]
			[Address(RVA = "0x3E67470", Offset = "0x3E66070", VA = "0x183E67470")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06000AB4 RID: 2740 RVA: 0x00006108 File Offset: 0x00004308
		[Token(Token = "0x17000223")]
		public static bool supports3DTextures
		{
			[Token(Token = "0x6000AB4")]
			[Address(RVA = "0x59706B0", Offset = "0x596F2B0", VA = "0x1859706B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000AB5 RID: 2741 RVA: 0x00006120 File Offset: 0x00004320
		[Token(Token = "0x17000224")]
		public static bool supports3DRenderTextures
		{
			[Token(Token = "0x6000AB5")]
			[Address(RVA = "0x5970680", Offset = "0x596F280", VA = "0x185970680")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000AB6 RID: 2742 RVA: 0x00006138 File Offset: 0x00004338
		[Token(Token = "0x17000225")]
		public static CopyTextureSupport copyTextureSupport
		{
			[Token(Token = "0x6000AB6")]
			[Address(RVA = "0x59700F0", Offset = "0x596ECF0", VA = "0x1859700F0")]
			get
			{
				return CopyTextureSupport.None;
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000AB7 RID: 2743 RVA: 0x00006150 File Offset: 0x00004350
		[Token(Token = "0x17000226")]
		public static bool supportsComputeShaders
		{
			[Token(Token = "0x6000AB7")]
			[Address(RVA = "0x59706E0", Offset = "0x596F2E0", VA = "0x1859706E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000AB8 RID: 2744 RVA: 0x00006168 File Offset: 0x00004368
		[Token(Token = "0x17000227")]
		public static int supportedRenderTargetCount
		{
			[Token(Token = "0x6000AB8")]
			[Address(RVA = "0x5970650", Offset = "0x596F250", VA = "0x185970650")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000AB9 RID: 2745 RVA: 0x00006180 File Offset: 0x00004380
		[Token(Token = "0x17000228")]
		public static int supportedRandomWriteTargetCount
		{
			[Token(Token = "0x6000AB9")]
			[Address(RVA = "0x5970620", Offset = "0x596F220", VA = "0x185970620")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000ABA RID: 2746 RVA: 0x00006198 File Offset: 0x00004398
		[Token(Token = "0x17000229")]
		public static bool usesReversedZBuffer
		{
			[Token(Token = "0x6000ABA")]
			[Address(RVA = "0x5970A10", Offset = "0x596F610", VA = "0x185970A10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000ABB RID: 2747 RVA: 0x000061B0 File Offset: 0x000043B0
		[Token(Token = "0x6000ABB")]
		[Address(RVA = "0x5970570", Offset = "0x596F170", VA = "0x185970570")]
		private static bool IsValidEnumValue(Enum value)
		{
			return default(bool);
		}

		// Token: 0x06000ABC RID: 2748 RVA: 0x000061C8 File Offset: 0x000043C8
		[Token(Token = "0x6000ABC")]
		[Address(RVA = "0x5970740", Offset = "0x596F340", VA = "0x185970740")]
		public static bool SupportsRenderTextureFormat(RenderTextureFormat format)
		{
			return default(bool);
		}

		// Token: 0x06000ABD RID: 2749 RVA: 0x000061E0 File Offset: 0x000043E0
		[Token(Token = "0x6000ABD")]
		[Address(RVA = "0x59708B0", Offset = "0x596F4B0", VA = "0x1859708B0")]
		public static bool SupportsTextureFormat(TextureFormat format)
		{
			return default(bool);
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000ABE RID: 2750 RVA: 0x000061F8 File Offset: 0x000043F8
		[Token(Token = "0x1700022A")]
		public static int maxTextureSize
		{
			[Token(Token = "0x6000ABE")]
			[Address(RVA = "0x5970340", Offset = "0x596EF40", VA = "0x185970340")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000ABF RID: 2751 RVA: 0x00006210 File Offset: 0x00004410
		[Token(Token = "0x1700022B")]
		internal static int maxRenderTextureSize
		{
			[Token(Token = "0x6000ABF")]
			[Address(RVA = "0x5970310", Offset = "0x596EF10", VA = "0x185970310")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000AC0 RID: 2752 RVA: 0x00006228 File Offset: 0x00004428
		[Token(Token = "0x1700022C")]
		public static long maxGraphicsBufferSize
		{
			[Token(Token = "0x6000AC0")]
			[Address(RVA = "0x59705F0", Offset = "0x596F1F0", VA = "0x1859705F0")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000AC1 RID: 2753 RVA: 0x00006240 File Offset: 0x00004440
		[Token(Token = "0x1700022D")]
		public static bool usesLoadStoreActions
		{
			[Token(Token = "0x6000AC1")]
			[Address(RVA = "0x59709E0", Offset = "0x596F5E0", VA = "0x1859709E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000AC2 RID: 2754
		[Token(Token = "0x6000AC2")]
		[Address(RVA = "0x5970080", Offset = "0x596EC80", VA = "0x185970080")]
		[FreeFunction("systeminfo::GetBatteryLevel")]
		[MethodImpl(4096)]
		private static extern float GetBatteryLevel();

		// Token: 0x06000AC3 RID: 2755
		[Token(Token = "0x6000AC3")]
		[Address(RVA = "0x59703A0", Offset = "0x596EFA0", VA = "0x1859703A0")]
		[FreeFunction("systeminfo::GetOperatingSystem")]
		[MethodImpl(4096)]
		private static extern string GetOperatingSystem();

		// Token: 0x06000AC4 RID: 2756
		[Token(Token = "0x6000AC4")]
		[Address(RVA = "0x5970370", Offset = "0x596EF70", VA = "0x185970370")]
		[FreeFunction("systeminfo::GetOperatingSystemFamily")]
		[MethodImpl(4096)]
		private static extern OperatingSystemFamily GetOperatingSystemFamily();

		// Token: 0x06000AC5 RID: 2757
		[Token(Token = "0x6000AC5")]
		[Address(RVA = "0x5970460", Offset = "0x596F060", VA = "0x185970460")]
		[FreeFunction("systeminfo::GetProcessorType")]
		[MethodImpl(4096)]
		private static extern string GetProcessorType();

		// Token: 0x06000AC6 RID: 2758
		[Token(Token = "0x6000AC6")]
		[Address(RVA = "0x5970430", Offset = "0x596F030", VA = "0x185970430")]
		[FreeFunction("systeminfo::GetProcessorFrequencyMHz")]
		[MethodImpl(4096)]
		private static extern int GetProcessorFrequencyMHz();

		// Token: 0x06000AC7 RID: 2759
		[Token(Token = "0x6000AC7")]
		[Address(RVA = "0x5970400", Offset = "0x596F000", VA = "0x185970400")]
		[FreeFunction("systeminfo::GetProcessorCount")]
		[MethodImpl(4096)]
		private static extern int GetProcessorCount();

		// Token: 0x06000AC8 RID: 2760
		[Token(Token = "0x6000AC8")]
		[Address(RVA = "0x59703D0", Offset = "0x596EFD0", VA = "0x1859703D0")]
		[FreeFunction("systeminfo::GetPhysicalMemoryMB")]
		[MethodImpl(4096)]
		private static extern int GetPhysicalMemoryMB();

		// Token: 0x06000AC9 RID: 2761
		[Token(Token = "0x6000AC9")]
		[Address(RVA = "0x59701B0", Offset = "0x596EDB0", VA = "0x1859701B0")]
		[FreeFunction("systeminfo::GetDeviceUniqueIdentifier")]
		[MethodImpl(4096)]
		private static extern string GetDeviceUniqueIdentifier();

		// Token: 0x06000ACA RID: 2762
		[Token(Token = "0x6000ACA")]
		[Address(RVA = "0x5970150", Offset = "0x596ED50", VA = "0x185970150")]
		[FreeFunction("systeminfo::GetDeviceName")]
		[MethodImpl(4096)]
		private static extern string GetDeviceName();

		// Token: 0x06000ACB RID: 2763
		[Token(Token = "0x6000ACB")]
		[Address(RVA = "0x5970120", Offset = "0x596ED20", VA = "0x185970120")]
		[FreeFunction("systeminfo::GetDeviceModel")]
		[MethodImpl(4096)]
		private static extern string GetDeviceModel();

		// Token: 0x06000ACC RID: 2764
		[Token(Token = "0x6000ACC")]
		[Address(RVA = "0x5970540", Offset = "0x596F140", VA = "0x185970540")]
		[FreeFunction]
		[MethodImpl(4096)]
		private static extern bool IsGyroAvailable();

		// Token: 0x06000ACD RID: 2765
		[Token(Token = "0x6000ACD")]
		[Address(RVA = "0x5970180", Offset = "0x596ED80", VA = "0x185970180")]
		[FreeFunction("systeminfo::GetDeviceType")]
		[MethodImpl(4096)]
		private static extern DeviceType GetDeviceType();

		// Token: 0x06000ACE RID: 2766
		[Token(Token = "0x6000ACE")]
		[Address(RVA = "0x5970280", Offset = "0x596EE80", VA = "0x185970280")]
		[FreeFunction("ScriptingGraphicsCaps::GetGraphicsMemorySize")]
		[MethodImpl(4096)]
		private static extern int GetGraphicsMemorySize();

		// Token: 0x06000ACF RID: 2767
		[Token(Token = "0x6000ACF")]
		[Address(RVA = "0x59701E0", Offset = "0x596EDE0", VA = "0x1859701E0")]
		[FreeFunction("ScriptingGraphicsCaps::GetGraphicsDeviceName")]
		[MethodImpl(4096)]
		private static extern string GetGraphicsDeviceName();

		// Token: 0x06000AD0 RID: 2768
		[Token(Token = "0x6000AD0")]
		[Address(RVA = "0x5970210", Offset = "0x596EE10", VA = "0x185970210")]
		[FreeFunction("ScriptingGraphicsCaps::GetGraphicsDeviceType")]
		[MethodImpl(4096)]
		private static extern GraphicsDeviceType GetGraphicsDeviceType();

		// Token: 0x06000AD1 RID: 2769
		[Token(Token = "0x6000AD1")]
		[Address(RVA = "0x59702E0", Offset = "0x596EEE0", VA = "0x1859702E0")]
		[FreeFunction("ScriptingGraphicsCaps::GetGraphicsUVStartsAtTop")]
		[MethodImpl(4096)]
		private static extern bool GetGraphicsUVStartsAtTop();

		// Token: 0x06000AD2 RID: 2770
		[Token(Token = "0x6000AD2")]
		[Address(RVA = "0x59702B0", Offset = "0x596EEB0", VA = "0x1859702B0")]
		[FreeFunction("ScriptingGraphicsCaps::GetGraphicsShaderLevel")]
		[MethodImpl(4096)]
		private static extern int GetGraphicsShaderLevel();

		// Token: 0x06000AD3 RID: 2771
		[Token(Token = "0x6000AD3")]
		[Address(RVA = "0x5970490", Offset = "0x596F090", VA = "0x185970490")]
		[FreeFunction("ScriptingGraphicsCaps::GetRenderingThreadingMode")]
		[MethodImpl(4096)]
		private static extern RenderingThreadingMode GetRenderingThreadingMode();

		// Token: 0x06000AD4 RID: 2772
		[Token(Token = "0x6000AD4")]
		[Address(RVA = "0x5970710", Offset = "0x596F310", VA = "0x185970710")]
		[FreeFunction("SupportsMotionVectors")]
		[MethodImpl(4096)]
		private static extern bool SupportsMotionVectors();

		// Token: 0x06000AD5 RID: 2773
		[Token(Token = "0x6000AD5")]
		[Address(RVA = "0x59706B0", Offset = "0x596F2B0", VA = "0x1859706B0")]
		[FreeFunction("ScriptingGraphicsCaps::Supports3DTextures")]
		[MethodImpl(4096)]
		private static extern bool Supports3DTextures();

		// Token: 0x06000AD6 RID: 2774
		[Token(Token = "0x6000AD6")]
		[Address(RVA = "0x5970680", Offset = "0x596F280", VA = "0x185970680")]
		[FreeFunction("ScriptingGraphicsCaps::Supports3DRenderTextures")]
		[MethodImpl(4096)]
		private static extern bool Supports3DRenderTextures();

		// Token: 0x06000AD7 RID: 2775
		[Token(Token = "0x6000AD7")]
		[Address(RVA = "0x59700F0", Offset = "0x596ECF0", VA = "0x1859700F0")]
		[FreeFunction("ScriptingGraphicsCaps::GetCopyTextureSupport")]
		[MethodImpl(4096)]
		private static extern CopyTextureSupport GetCopyTextureSupport();

		// Token: 0x06000AD8 RID: 2776
		[Token(Token = "0x6000AD8")]
		[Address(RVA = "0x59706E0", Offset = "0x596F2E0", VA = "0x1859706E0")]
		[FreeFunction("ScriptingGraphicsCaps::SupportsComputeShaders")]
		[MethodImpl(4096)]
		private static extern bool SupportsComputeShaders();

		// Token: 0x06000AD9 RID: 2777
		[Token(Token = "0x6000AD9")]
		[Address(RVA = "0x5970650", Offset = "0x596F250", VA = "0x185970650")]
		[FreeFunction("ScriptingGraphicsCaps::SupportedRenderTargetCount")]
		[MethodImpl(4096)]
		private static extern int SupportedRenderTargetCount();

		// Token: 0x06000ADA RID: 2778
		[Token(Token = "0x6000ADA")]
		[Address(RVA = "0x5970620", Offset = "0x596F220", VA = "0x185970620")]
		[FreeFunction("ScriptingGraphicsCaps::SupportedRandomWriteTargetCount")]
		[MethodImpl(4096)]
		private static extern int SupportedRandomWriteTargetCount();

		// Token: 0x06000ADB RID: 2779
		[Token(Token = "0x6000ADB")]
		[Address(RVA = "0x5970A10", Offset = "0x596F610", VA = "0x185970A10")]
		[FreeFunction("ScriptingGraphicsCaps::UsesReversedZBuffer")]
		[MethodImpl(4096)]
		private static extern bool UsesReversedZBuffer();

		// Token: 0x06000ADC RID: 2780
		[Token(Token = "0x6000ADC")]
		[Address(RVA = "0x59704C0", Offset = "0x596F0C0", VA = "0x1859704C0")]
		[FreeFunction("ScriptingGraphicsCaps::HasRenderTexture")]
		[MethodImpl(4096)]
		private static extern bool HasRenderTextureNative(RenderTextureFormat format);

		// Token: 0x06000ADD RID: 2781
		[Token(Token = "0x6000ADD")]
		[Address(RVA = "0x5970870", Offset = "0x596F470", VA = "0x185970870")]
		[FreeFunction("ScriptingGraphicsCaps::SupportsTextureFormat")]
		[MethodImpl(4096)]
		private static extern bool SupportsTextureFormatNative(TextureFormat format);

		// Token: 0x06000ADE RID: 2782
		[Token(Token = "0x6000ADE")]
		[Address(RVA = "0x5970340", Offset = "0x596EF40", VA = "0x185970340")]
		[FreeFunction("ScriptingGraphicsCaps::GetMaxTextureSize")]
		[MethodImpl(4096)]
		private static extern int GetMaxTextureSize();

		// Token: 0x06000ADF RID: 2783
		[Token(Token = "0x6000ADF")]
		[Address(RVA = "0x5970310", Offset = "0x596EF10", VA = "0x185970310")]
		[FreeFunction("ScriptingGraphicsCaps::GetMaxRenderTextureSize")]
		[MethodImpl(4096)]
		private static extern int GetMaxRenderTextureSize();

		// Token: 0x06000AE0 RID: 2784
		[Token(Token = "0x6000AE0")]
		[Address(RVA = "0x59705F0", Offset = "0x596F1F0", VA = "0x1859705F0")]
		[FreeFunction("ScriptingGraphicsCaps::MaxGraphicsBufferSize")]
		[MethodImpl(4096)]
		private static extern long MaxGraphicsBufferSize();

		// Token: 0x06000AE1 RID: 2785
		[Token(Token = "0x6000AE1")]
		[Address(RVA = "0x5970500", Offset = "0x596F100", VA = "0x185970500")]
		[FreeFunction("ScriptingGraphicsCaps::IsFormatSupported")]
		[MethodImpl(4096)]
		public static extern bool IsFormatSupported(GraphicsFormat format, FormatUsage usage);

		// Token: 0x06000AE2 RID: 2786
		[Token(Token = "0x6000AE2")]
		[Address(RVA = "0x59700B0", Offset = "0x596ECB0", VA = "0x1859700B0")]
		[FreeFunction("ScriptingGraphicsCaps::GetCompatibleFormat")]
		[MethodImpl(4096)]
		public static extern GraphicsFormat GetCompatibleFormat(GraphicsFormat format, FormatUsage usage);

		// Token: 0x06000AE3 RID: 2787
		[Token(Token = "0x6000AE3")]
		[Address(RVA = "0x5970240", Offset = "0x596EE40", VA = "0x185970240")]
		[FreeFunction("ScriptingGraphicsCaps::GetGraphicsFormat")]
		[MethodImpl(4096)]
		public static extern GraphicsFormat GetGraphicsFormat(DefaultFormat format);

		// Token: 0x06000AE4 RID: 2788
		[Token(Token = "0x6000AE4")]
		[Address(RVA = "0x59709E0", Offset = "0x596F5E0", VA = "0x1859709E0")]
		[FreeFunction("ScriptingGraphicsCaps::UsesLoadStoreActions")]
		[MethodImpl(4096)]
		private static extern bool UsesLoadStoreActions();
	}
}
