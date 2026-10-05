using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CriWare.CriMana;
using Il2CppDummyDll;
using UnityEngine.Rendering;

namespace CriWare
{
	// Token: 0x020000D1 RID: 209
	[Token(Token = "0x20000D1")]
	public class CriManaPlugin
	{
		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060006DA RID: 1754 RVA: 0x00003CD4 File Offset: 0x00001ED4
		[Token(Token = "0x1700007F")]
		public static bool isInitialized
		{
			[Token(Token = "0x60006DA")]
			[Address(RVA = "0x3703160", Offset = "0x3701D60", VA = "0x183703160")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060006DB RID: 1755 RVA: 0x00003CEC File Offset: 0x00001EEC
		[Token(Token = "0x17000080")]
		public static bool isMultithreadedRenderingEnabled
		{
			[Token(Token = "0x60006DB")]
			[Address(RVA = "0x37031C0", Offset = "0x3701DC0", VA = "0x1837031C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x060006DC RID: 1756 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x060006DD RID: 1757 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000013")]
		public static event Action OnBeforeInitialize
		{
			[Token(Token = "0x60006DC")]
			[Address(RVA = "0x3702C80", Offset = "0x3701880", VA = "0x183702C80")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60006DD")]
			[Address(RVA = "0x3703310", Offset = "0x3701F10", VA = "0x183703310")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x060006DE RID: 1758 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x060006DF RID: 1759 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000014")]
		public static event Action OnInitialized
		{
			[Token(Token = "0x60006DE")]
			[Address(RVA = "0x3702E80", Offset = "0x3701A80", VA = "0x183702E80")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60006DF")]
			[Address(RVA = "0x3703510", Offset = "0x3702110", VA = "0x183703510")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x060006E0 RID: 1760 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x060006E1 RID: 1761 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000015")]
		public static event Action OnBeforeFinalize
		{
			[Token(Token = "0x60006E0")]
			[Address(RVA = "0x3702B80", Offset = "0x3701780", VA = "0x183702B80")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60006E1")]
			[Address(RVA = "0x3703210", Offset = "0x3701E10", VA = "0x183703210")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x060006E2 RID: 1762 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x060006E3 RID: 1763 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000016")]
		public static event Action OnFinalized
		{
			[Token(Token = "0x60006E2")]
			[Address(RVA = "0x3702D80", Offset = "0x3701980", VA = "0x183702D80")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60006E3")]
			[Address(RVA = "0x3703410", Offset = "0x3702010", VA = "0x183703410")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x37023F0", Offset = "0x3700FF0", VA = "0x1837023F0")]
		public static void SetConfigParameters(bool graphicsMultiThreaded, int num_decoders, int max_num_of_entries)
		{
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x37026F0", Offset = "0x37012F0", VA = "0x1837026F0")]
		private static void SetupVp9()
		{
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x3702580", Offset = "0x3701180", VA = "0x183702580")]
		private static void SetupAV1()
		{
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		[Obsolete("Use CriWareVITA.EnableH264Playback and CriWareVITA.SetH264DecoderMaxSize instead.")]
		public static void SetConfigAdditonalParameters_VITA(bool use_h264_playback, int width, int height)
		{
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x3702340", Offset = "0x3700F40", VA = "0x183702340")]
		public static void SetConfigAdditonalParameters_PC(bool use_h264_playback)
		{
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x3702900", Offset = "0x3701500", VA = "0x183702900")]
		public static void UseLegacyDecoder_PC(bool useLegacyDecoder)
		{
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x00003D04 File Offset: 0x00001F04
		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x3701F70", Offset = "0x3700B70", VA = "0x183701F70")]
		public static bool IsLegacyDecoderUsed_PC()
		{
			return default(bool);
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public static void SetConfigAdditonalParameters_ANDROID(bool enable_buffer_output_for_h264, bool enable_buffer_output_for_vp9)
		{
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public static void SetConfigAdditonalParameters_WEBGL(string webworkerPath, uint heapSize)
		{
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x3701A50", Offset = "0x3700650", VA = "0x183701A50")]
		public static void InitializeLibrary()
		{
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x00003D1C File Offset: 0x00001F1C
		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x3702010", Offset = "0x3700C10", VA = "0x183702010")]
		public static bool IsLibraryInitialized()
		{
			return default(bool);
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x3701540", Offset = "0x3700140", VA = "0x183701540")]
		public static void FinalizeLibrary()
		{
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x00003D34 File Offset: 0x00001F34
		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x3701E30", Offset = "0x3700A30", VA = "0x183701E30")]
		public static bool IsCodecSupported(CodecType codecType)
		{
			return default(bool);
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x3701970", Offset = "0x3700570", VA = "0x183701970")]
		private static Type GetVp9ExpansionClass()
		{
			return null;
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x37017F0", Offset = "0x37003F0", VA = "0x1837017F0")]
		private static Type GetAV1ExpansionClass()
		{
			return null;
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x00003D4C File Offset: 0x00001F4C
		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x3701CE0", Offset = "0x37008E0", VA = "0x183701CE0")]
		private static bool IsAV1CodecSupported()
		{
			return default(bool);
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x00003D64 File Offset: 0x00001F64
		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x3702150", Offset = "0x3700D50", VA = "0x183702150")]
		private static bool IsVp9CodecSupported()
		{
			return default(bool);
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x00003D7C File Offset: 0x00001F7C
		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70")]
		private static bool IsH264CodecSupported()
		{
			return default(bool);
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public static void SetDecodeThreadPriorityAndroidExperimental(int prio)
		{
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x00003D94 File Offset: 0x00001F94
		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40")]
		public static bool ShouldSampleRed(GraphicsDeviceType type, IntPtr tex_ptr)
		{
			return default(bool);
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x37029B0", Offset = "0x37015B0", VA = "0x1837029B0")]
		public static void UseStreamerManager(bool flag)
		{
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x00003DAC File Offset: 0x00001FAC
		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x37020B0", Offset = "0x3700CB0", VA = "0x1837020B0")]
		public static bool IsStreamerManagerUsed()
		{
			return default(bool);
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x37022A0", Offset = "0x3700EA0", VA = "0x1837022A0")]
		public static void Lock()
		{
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x3702860", Offset = "0x3701460", VA = "0x183702860")]
		public static void Unlock()
		{
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x00003DC4 File Offset: 0x00001FC4
		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x37018D0", Offset = "0x37004D0", VA = "0x1837018D0")]
		public static uint GetPrimeBufferAlignmentSize()
		{
			return 0U;
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x00003DDC File Offset: 0x00001FDC
		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x3700E40", Offset = "0x36FFA40", VA = "0x183700E40")]
		public static bool AnalyzeMovieHeader(IntPtr data, out MovieInfo movieInfo)
		{
			return default(bool);
		}

		// Token: 0x060006FE RID: 1790
		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x3701180", Offset = "0x36FFD80", VA = "0x183701180")]
		[PreserveSig]
		private static extern void CRIWARE8D1D64BA(int graphics_api, bool graphics_multi_threaded, int num_decoders, int num_of_max_entries);

		// Token: 0x060006FF RID: 1791
		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x3701370", Offset = "0x36FFF70", VA = "0x183701370")]
		[PreserveSig]
		private static extern void CRIWARED28A46EF();

		// Token: 0x06000700 RID: 1792
		[Token(Token = "0x6000700")]
		[Address(RVA = "0x3701220", Offset = "0x36FFE20", VA = "0x183701220")]
		[PreserveSig]
		public static extern bool CRIWARE95583339();

		// Token: 0x06000701 RID: 1793
		[Token(Token = "0x6000701")]
		[Address(RVA = "0x3701300", Offset = "0x36FFF00", VA = "0x183701300")]
		[PreserveSig]
		private static extern void CRIWAREB8B70514();

		// Token: 0x06000702 RID: 1794
		[Token(Token = "0x6000702")]
		[Address(RVA = "0x3701100", Offset = "0x36FFD00", VA = "0x183701100")]
		[PreserveSig]
		public static extern void CRIWARE8A7CBF13(bool flag);

		// Token: 0x06000703 RID: 1795
		[Token(Token = "0x6000703")]
		[Address(RVA = "0x3700FA0", Offset = "0x36FFBA0", VA = "0x183700FA0")]
		[PreserveSig]
		public static extern void CRIWARE0A412D8D();

		// Token: 0x06000704 RID: 1796
		[Token(Token = "0x6000704")]
		[Address(RVA = "0x3701010", Offset = "0x36FFC10", VA = "0x183701010")]
		[PreserveSig]
		public static extern void CRIWARE0ADE1674();

		// Token: 0x06000705 RID: 1797
		[Token(Token = "0x6000705")]
		[Address(RVA = "0x3701290", Offset = "0x36FFE90", VA = "0x183701290")]
		[PreserveSig]
		private static extern uint CRIWARE9855F0DD();

		// Token: 0x06000706 RID: 1798
		[Token(Token = "0x6000706")]
		[Address(RVA = "0x37030E0", Offset = "0x3701CE0", VA = "0x1837030E0")]
		[PreserveSig]
		public static extern void criMana_UseStreamerManager(bool flag);

		// Token: 0x06000707 RID: 1799
		[Token(Token = "0x6000707")]
		[Address(RVA = "0x3703070", Offset = "0x3701C70", VA = "0x183703070")]
		[PreserveSig]
		public static extern bool criMana_IsStreamerManagerUsed();

		// Token: 0x06000708 RID: 1800
		[Token(Token = "0x6000708")]
		[Address(RVA = "0x3701450", Offset = "0x3700050", VA = "0x183701450")]
		[PreserveSig]
		public static extern bool CRIWAREF7BE40E3(IntPtr movie_header_ptr, [Out] MovieInfo mvinf);

		// Token: 0x06000709 RID: 1801
		[Token(Token = "0x6000709")]
		[Address(RVA = "0x37013E0", Offset = "0x36FFFE0", VA = "0x1837013E0")]
		[PreserveSig]
		public static extern uint CRIWAREDEE99E0C();

		// Token: 0x0600070A RID: 1802
		[Token(Token = "0x600070A")]
		[Address(RVA = "0x3702FF0", Offset = "0x3701BF0", VA = "0x183702FF0")]
		[PreserveSig]
		public static extern void criManaUnity_UseLegacyDecoder_PC(bool enable);

		// Token: 0x0600070B RID: 1803
		[Token(Token = "0x600070B")]
		[Address(RVA = "0x3702F80", Offset = "0x3701B80", VA = "0x183702F80")]
		[PreserveSig]
		public static extern bool criManaUnity_IsLegacyDecoderUsed_PC();

		// Token: 0x0600070C RID: 1804
		[Token(Token = "0x600070C")]
		[Address(RVA = "0x3701080", Offset = "0x36FFC80", VA = "0x183701080")]
		[PreserveSig]
		public static extern void CRIWARE490C288F(bool enable);

		// Token: 0x0600070D RID: 1805 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600070D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CriManaPlugin()
		{
		}

		// Token: 0x040003BF RID: 959
		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int initializationCount;

		// Token: 0x040003C0 RID: 960
		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static bool isConfigured;

		// Token: 0x040003C1 RID: 961
		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
		private static bool enabledMultithreadedRendering;

		// Token: 0x040003C2 RID: 962
		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static int renderingEventOffset;
	}
}
