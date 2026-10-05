using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	// Token: 0x0200027A RID: 634
	[Token(Token = "0x200027A")]
	public class SupportedRenderingFeatures
	{
		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000E4E RID: 3662 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000E4F RID: 3663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002D8")]
		public static SupportedRenderingFeatures active
		{
			[Token(Token = "0x6000E4E")]
			[Address(RVA = "0x5988BC0", Offset = "0x59877C0", VA = "0x185988BC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000E4F")]
			[Address(RVA = "0x5988CB0", Offset = "0x59878B0", VA = "0x185988CB0")]
			set
			{
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06000E50 RID: 3664 RVA: 0x00007080 File Offset: 0x00005280
		[Token(Token = "0x170002D9")]
		public SupportedRenderingFeatures.LightmapMixedBakeModes defaultMixedLightingModes
		{
			[Token(Token = "0x6000E50")]
			[Address(RVA = "0x4EEB30", Offset = "0x4ED730", VA = "0x1804EEB30")]
			[CompilerGenerated]
			get
			{
				return SupportedRenderingFeatures.LightmapMixedBakeModes.None;
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000E51 RID: 3665 RVA: 0x00007098 File Offset: 0x00005298
		[Token(Token = "0x170002DA")]
		public SupportedRenderingFeatures.LightmapMixedBakeModes mixedLightingModes
		{
			[Token(Token = "0x6000E51")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			[CompilerGenerated]
			get
			{
				return SupportedRenderingFeatures.LightmapMixedBakeModes.None;
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000E52 RID: 3666 RVA: 0x000070B0 File Offset: 0x000052B0
		[Token(Token = "0x170002DB")]
		public LightmapBakeType lightmapBakeTypes
		{
			[Token(Token = "0x6000E52")]
			[Address(RVA = "0x4EA880", Offset = "0x4E9480", VA = "0x1804EA880")]
			[CompilerGenerated]
			get
			{
				return (LightmapBakeType)0;
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000E53 RID: 3667 RVA: 0x000070C8 File Offset: 0x000052C8
		[Token(Token = "0x170002DC")]
		public LightmapsMode lightmapsModes
		{
			[Token(Token = "0x6000E53")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890")]
			[CompilerGenerated]
			get
			{
				return LightmapsMode.NonDirectional;
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06000E54 RID: 3668 RVA: 0x000070E0 File Offset: 0x000052E0
		[Token(Token = "0x170002DD")]
		public bool enlightenLightmapper
		{
			[Token(Token = "0x6000E54")]
			[Address(RVA = "0x4EA840", Offset = "0x4E9440", VA = "0x1804EA840")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000E55 RID: 3669 RVA: 0x000070F8 File Offset: 0x000052F8
		[Token(Token = "0x170002DE")]
		public bool enlighten
		{
			[Token(Token = "0x6000E55")]
			[Address(RVA = "0x4EA870", Offset = "0x4E9470", VA = "0x1804EA870")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000E56 RID: 3670 RVA: 0x00007110 File Offset: 0x00005310
		[Token(Token = "0x170002DF")]
		public bool rendersUIOverlay
		{
			[Token(Token = "0x6000E56")]
			[Address(RVA = "0x4EF600", Offset = "0x4EE200", VA = "0x1804EF600")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000E57 RID: 3671 RVA: 0x00007128 File Offset: 0x00005328
		[Token(Token = "0x170002E0")]
		public bool autoAmbientProbeBaking
		{
			[Token(Token = "0x6000E57")]
			[Address(RVA = "0x4E4E430", Offset = "0x4E4D030", VA = "0x184E4E430")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06000E58 RID: 3672 RVA: 0x00007140 File Offset: 0x00005340
		[Token(Token = "0x170002E1")]
		public bool autoDefaultReflectionProbeBaking
		{
			[Token(Token = "0x6000E58")]
			[Address(RVA = "0x5988CA0", Offset = "0x59878A0", VA = "0x185988CA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000E59 RID: 3673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E59")]
		[Address(RVA = "0x5988110", Offset = "0x5986D10", VA = "0x185988110")]
		[RequiredByNativeCode]
		internal static void FallbackMixedLightingModeByRef(IntPtr fallbackModePtr)
		{
		}

		// Token: 0x06000E5A RID: 3674 RVA: 0x00007158 File Offset: 0x00005358
		[Token(Token = "0x6000E5A")]
		[Address(RVA = "0x59888F0", Offset = "0x59874F0", VA = "0x1859888F0")]
		internal static bool IsMixedLightingModeSupported(MixedLightingMode mixedMode)
		{
			return default(bool);
		}

		// Token: 0x06000E5B RID: 3675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E5B")]
		[Address(RVA = "0x5988790", Offset = "0x5987390", VA = "0x185988790")]
		[RequiredByNativeCode]
		internal static void IsMixedLightingModeSupportedByRef(MixedLightingMode mixedMode, IntPtr isSupportedPtr)
		{
		}

		// Token: 0x06000E5C RID: 3676 RVA: 0x00007170 File Offset: 0x00005370
		[Token(Token = "0x6000E5C")]
		[Address(RVA = "0x5988540", Offset = "0x5987140", VA = "0x185988540")]
		internal static bool IsLightmapBakeTypeSupported(LightmapBakeType bakeType)
		{
			return default(bool);
		}

		// Token: 0x06000E5D RID: 3677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E5D")]
		[Address(RVA = "0x5988440", Offset = "0x5987040", VA = "0x185988440")]
		[RequiredByNativeCode]
		internal static void IsLightmapBakeTypeSupportedByRef(LightmapBakeType bakeType, IntPtr isSupportedPtr)
		{
		}

		// Token: 0x06000E5E RID: 3678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E5E")]
		[Address(RVA = "0x5988710", Offset = "0x5987310", VA = "0x185988710")]
		[RequiredByNativeCode]
		internal static void IsLightmapsModeSupportedByRef(LightmapsMode mode, IntPtr isSupportedPtr)
		{
		}

		// Token: 0x06000E5F RID: 3679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E5F")]
		[Address(RVA = "0x5988680", Offset = "0x5987280", VA = "0x185988680")]
		[RequiredByNativeCode]
		internal static void IsLightmapperSupportedByRef(int lightmapper, IntPtr isSupportedPtr)
		{
		}

		// Token: 0x06000E60 RID: 3680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E60")]
		[Address(RVA = "0x5988A40", Offset = "0x5987640", VA = "0x185988A40")]
		[RequiredByNativeCode]
		internal static void IsUIOverlayRenderedBySRP(IntPtr isSupportedPtr)
		{
		}

		// Token: 0x06000E61 RID: 3681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E61")]
		[Address(RVA = "0x5988360", Offset = "0x5986F60", VA = "0x185988360")]
		[RequiredByNativeCode]
		internal static void IsAutoAmbientProbeBakingSupported(IntPtr isSupportedPtr)
		{
		}

		// Token: 0x06000E62 RID: 3682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E62")]
		[Address(RVA = "0x59883D0", Offset = "0x5986FD0", VA = "0x1859883D0")]
		[RequiredByNativeCode]
		internal static void IsAutoDefaultReflectionProbeBakingSupported(IntPtr isSupportedPtr)
		{
		}

		// Token: 0x06000E63 RID: 3683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E63")]
		[Address(RVA = "0x59880F0", Offset = "0x5986CF0", VA = "0x1859880F0")]
		[RequiredByNativeCode]
		internal static void FallbackLightmapperByRef(IntPtr lightmapperPtr)
		{
		}

		// Token: 0x06000E64 RID: 3684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E64")]
		[Address(RVA = "0x5988B30", Offset = "0x5987730", VA = "0x185988B30")]
		public SupportedRenderingFeatures()
		{
		}

		// Token: 0x0400079E RID: 1950
		[Token(Token = "0x400079E")]
		[FieldOffset(Offset = "0x0")]
		private static SupportedRenderingFeatures s_Active;

		// Token: 0x0200027B RID: 635
		[Token(Token = "0x200027B")]
		[Flags]
		public enum ReflectionProbeModes
		{
			// Token: 0x040007BB RID: 1979
			[Token(Token = "0x40007BB")]
			None = 0,
			// Token: 0x040007BC RID: 1980
			[Token(Token = "0x40007BC")]
			Rotation = 1
		}

		// Token: 0x0200027C RID: 636
		[Token(Token = "0x200027C")]
		[Flags]
		public enum LightmapMixedBakeModes
		{
			// Token: 0x040007BE RID: 1982
			[Token(Token = "0x40007BE")]
			None = 0,
			// Token: 0x040007BF RID: 1983
			[Token(Token = "0x40007BF")]
			IndirectOnly = 1,
			// Token: 0x040007C0 RID: 1984
			[Token(Token = "0x40007C0")]
			Subtractive = 2,
			// Token: 0x040007C1 RID: 1985
			[Token(Token = "0x40007C1")]
			Shadowmask = 4
		}
	}
}
