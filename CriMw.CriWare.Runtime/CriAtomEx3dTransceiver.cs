using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace CriWare
{
	// Token: 0x02000061 RID: 97
	[Token(Token = "0x2000061")]
	public class CriAtomEx3dTransceiver : CriDisposable
	{
		// Token: 0x060002F6 RID: 758 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x36B8910", Offset = "0x36B7510", VA = "0x1836B8910")]
		public CriAtomEx3dTransceiver()
		{
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x36B7D80", Offset = "0x36B6980", VA = "0x1836B7D80", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x36B7C30", Offset = "0x36B6830", VA = "0x1836B7C30")]
		private void Dispose(bool disposing)
		{
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060002F9 RID: 761 RVA: 0x00002C54 File Offset: 0x00000E54
		[Token(Token = "0x17000046")]
		public IntPtr nativeHandle
		{
			[Token(Token = "0x60002F9")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x36B8890", Offset = "0x36B7490", VA = "0x1836B8890")]
		public void Update()
		{
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x36B80E0", Offset = "0x36B6CE0", VA = "0x1836B80E0")]
		public void SetInputPosition(Vector3 position)
		{
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x36B8630", Offset = "0x36B7230", VA = "0x1836B8630")]
		public void SetOutputPosition(Vector3 position)
		{
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x36B7FF0", Offset = "0x36B6BF0", VA = "0x1836B7FF0")]
		public void SetInputOrientation(Vector3 front, Vector3 top)
		{
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x36B8540", Offset = "0x36B7140", VA = "0x1836B8540")]
		public void SetOutputOrientation(Vector3 front, Vector3 top)
		{
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x36B8340", Offset = "0x36B6F40", VA = "0x1836B8340")]
		public void SetOutputConeParameter(float insideAngle, float outsideAngle, float outsideVolume)
		{
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000300")]
		[Address(RVA = "0x36B84A0", Offset = "0x36B70A0", VA = "0x1836B84A0")]
		public void SetOutputMinMaxDistance(float minDistance, float maxDistance)
		{
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000301")]
		[Address(RVA = "0x36B8400", Offset = "0x36B7000", VA = "0x1836B8400")]
		public void SetOutputInteriorPanField(float radius, float interiorDistance)
		{
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000302")]
		[Address(RVA = "0x36B7F50", Offset = "0x36B6B50", VA = "0x1836B7F50")]
		public void SetInputCrossFadeField(float directAudioRadius, float crossfadeDistance)
		{
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000303")]
		[Address(RVA = "0x36B86E0", Offset = "0x36B72E0", VA = "0x1836B86E0")]
		public void SetOutputVolume(float volume)
		{
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000304")]
		[Address(RVA = "0x36B7AF0", Offset = "0x36B66F0", VA = "0x1836B7AF0")]
		public void AttachAisac(string globalAisacName)
		{
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000305")]
		[Address(RVA = "0x36B7B90", Offset = "0x36B6790", VA = "0x1836B7B90")]
		public void DetachAisac(string globalAisacName)
		{
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000306")]
		[Address(RVA = "0x36B82B0", Offset = "0x36B6EB0", VA = "0x1836B82B0")]
		public void SetMaxAngleAisacDelta(float maxDelta)
		{
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000307")]
		[Address(RVA = "0x36B7EC0", Offset = "0x36B6AC0", VA = "0x1836B7EC0")]
		public void SetDistanceAisacControlId(ushort aisacControlId)
		{
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000308")]
		[Address(RVA = "0x36B8190", Offset = "0x36B6D90", VA = "0x1836B8190")]
		public void SetListenerBasedAzimuthAngleAisacControlId(ushort aisacControlId)
		{
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000309")]
		[Address(RVA = "0x36B8220", Offset = "0x36B6E20", VA = "0x1836B8220")]
		public void SetListenerBasedElevationAngleAisacControlId(ushort aisacControlId)
		{
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600030A")]
		[Address(RVA = "0x36B8770", Offset = "0x36B7370", VA = "0x1836B8770")]
		public void SetTransceiverOutputBasedAzimuthAngleAisacControlId(ushort aisacControlId)
		{
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600030B")]
		[Address(RVA = "0x36B8800", Offset = "0x36B7400", VA = "0x1836B8800")]
		public void SetTransceiverOutputBasedElevationAngleAisacControlId(ushort aisacControlId)
		{
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600030C")]
		[Address(RVA = "0x36B7DF0", Offset = "0x36B69F0", VA = "0x1836B7DF0")]
		public void Set3dRegion(CriAtomEx3dRegion region3d)
		{
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600030D")]
		[Address(RVA = "0x36B7D90", Offset = "0x36B6990", VA = "0x1836B7D90", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x040001F1 RID: 497
		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private IntPtr handle;

		// Token: 0x02000062 RID: 98
		[Token(Token = "0x2000062")]
		public struct Config
		{
			// Token: 0x040001F2 RID: 498
			[Token(Token = "0x40001F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int reserved;
		}

		// Token: 0x02000063 RID: 99
		[Token(Token = "0x2000063")]
		private static class UnsafeNativeMethods
		{
			// Token: 0x0600030E RID: 782
			[Token(Token = "0x600030E")]
			[Address(RVA = "0x36DD3E0", Offset = "0x36DBFE0", VA = "0x1836DD3E0")]
			[PreserveSig]
			internal static extern IntPtr criAtomEx3dTransceiver_Create(ref CriAtomEx3dTransceiver.Config config, IntPtr work, int work_size);

			// Token: 0x0600030F RID: 783
			[Token(Token = "0x600030F")]
			[Address(RVA = "0x36DD480", Offset = "0x36DC080", VA = "0x1836DD480")]
			[PreserveSig]
			internal static extern void criAtomEx3dTransceiver_Destroy(IntPtr ex_3d_transceiver);

			// Token: 0x06000310 RID: 784
			[Token(Token = "0x6000310")]
			[Address(RVA = "0x36DDF20", Offset = "0x36DCB20", VA = "0x1836DDF20")]
			[PreserveSig]
			internal static extern void criAtomEx3dTransceiver_Update(IntPtr ex_3d_transceiver);

			// Token: 0x06000311 RID: 785
			[Token(Token = "0x6000311")]
			[Address(RVA = "0x36DD800", Offset = "0x36DC400", VA = "0x1836DD800")]
			[PreserveSig]
			internal static extern void criAtomEx3dTransceiver_SetInputPosition(IntPtr ex_3d_transceiver, ref CriAtomEx.NativeVector position);

			// Token: 0x06000312 RID: 786
			[Token(Token = "0x6000312")]
			[Address(RVA = "0x36DDCE0", Offset = "0x36DC8E0", VA = "0x1836DDCE0")]
			[PreserveSig]
			internal static extern void criAtomEx3dTransceiver_SetOutputPosition(IntPtr ex_3d_transceiver, ref CriAtomEx.NativeVector position);

			// Token: 0x06000313 RID: 787
			[Token(Token = "0x6000313")]
			[Address(RVA = "0x36DD760", Offset = "0x36DC360", VA = "0x1836DD760")]
			[PreserveSig]
			internal static extern void criAtomEx3dTransceiver_SetInputOrientation(IntPtr ex_3d_transceiver, ref CriAtomEx.NativeVector front, ref CriAtomEx.NativeVector top);

			// Token: 0x06000314 RID: 788
			[Token(Token = "0x6000314")]
			[Address(RVA = "0x36DDC40", Offset = "0x36DC840", VA = "0x1836DDC40")]
			[PreserveSig]
			internal static extern void criAtomEx3dTransceiver_SetOutputOrientation(IntPtr ex_3d_transceiver, ref CriAtomEx.NativeVector front, ref CriAtomEx.NativeVector top);

			// Token: 0x06000315 RID: 789
			[Token(Token = "0x6000315")]
			[Address(RVA = "0x36DDA40", Offset = "0x36DC640", VA = "0x1836DDA40")]
			[PreserveSig]
			internal static extern void criAtomEx3dTransceiver_SetOutputConeParameter(IntPtr ex_3d_transceiver, float inside_angle, float outside_angle, float outside_volume);

			// Token: 0x06000316 RID: 790
			[Token(Token = "0x6000316")]
			[Address(RVA = "0x36DDBA0", Offset = "0x36DC7A0", VA = "0x1836DDBA0")]
			[PreserveSig]
			internal static extern void criAtomEx3dTransceiver_SetOutputMinMaxAttenuationDistance(IntPtr ex_3d_transceiver, float min_attenuation_distance, float max_attenuation_distance);

			// Token: 0x06000317 RID: 791
			[Token(Token = "0x6000317")]
			[Address(RVA = "0x36DDB00", Offset = "0x36DC700", VA = "0x1836DDB00")]
			[PreserveSig]
			internal static extern void criAtomEx3dTransceiver_SetOutputInteriorPanField(IntPtr ex_3d_transceiver, float transceiver_radius, float interior_distance);

			// Token: 0x06000318 RID: 792
			[Token(Token = "0x6000318")]
			[Address(RVA = "0x36DD6C0", Offset = "0x36DC2C0", VA = "0x1836DD6C0")]
			[PreserveSig]
			internal static extern void criAtomEx3dTransceiver_SetInputCrossFadeField(IntPtr ex_3d_transceiver, float direct_audio_radius, float crossfade_distance);

			// Token: 0x06000319 RID: 793
			[Token(Token = "0x6000319")]
			[Address(RVA = "0x36DDD70", Offset = "0x36DC970", VA = "0x1836DDD70")]
			[PreserveSig]
			internal static extern void criAtomEx3dTransceiver_SetOutputVolume(IntPtr ex_3d_transceiver, float volume);

			// Token: 0x0600031A RID: 794
			[Token(Token = "0x600031A")]
			[Address(RVA = "0x36DD340", Offset = "0x36DBF40", VA = "0x1836DD340")]
			[PreserveSig]
			internal static extern void criAtomEx3dTransceiver_AttachAisac(IntPtr ex_3d_transceiver, string global_aisac_name);

			// Token: 0x0600031B RID: 795
			[Token(Token = "0x600031B")]
			[Address(RVA = "0x36DD500", Offset = "0x36DC100", VA = "0x1836DD500")]
			[PreserveSig]
			internal static extern void criAtomEx3dTransceiver_DetachAisac(IntPtr ex_3d_transceiver, string global_aisac_name);

			// Token: 0x0600031C RID: 796
			[Token(Token = "0x600031C")]
			[Address(RVA = "0x36DD9B0", Offset = "0x36DC5B0", VA = "0x1836DD9B0")]
			[PreserveSig]
			internal static extern void criAtomEx3dTransceiver_SetMaxAngleAisacDelta(IntPtr ex_3d_transceiver, float max_delta);

			// Token: 0x0600031D RID: 797
			[Token(Token = "0x600031D")]
			[Address(RVA = "0x36DD630", Offset = "0x36DC230", VA = "0x1836DD630")]
			[PreserveSig]
			internal static extern void criAtomEx3dTransceiver_SetDistanceAisacControlId(IntPtr ex_3d_transceiver, ushort aisac_control_id);

			// Token: 0x0600031E RID: 798
			[Token(Token = "0x600031E")]
			[Address(RVA = "0x36DD890", Offset = "0x36DC490", VA = "0x1836DD890")]
			[PreserveSig]
			internal static extern void criAtomEx3dTransceiver_SetListenerBasedAzimuthAngleAisacControlId(IntPtr ex_3d_transceiver, ushort aisac_control_id);

			// Token: 0x0600031F RID: 799
			[Token(Token = "0x600031F")]
			[Address(RVA = "0x36DD920", Offset = "0x36DC520", VA = "0x1836DD920")]
			[PreserveSig]
			internal static extern void criAtomEx3dTransceiver_SetListenerBasedElevationAngleAisacControlId(IntPtr ex_3d_transceiver, ushort aisac_control_id);

			// Token: 0x06000320 RID: 800
			[Token(Token = "0x6000320")]
			[Address(RVA = "0x36DDE00", Offset = "0x36DCA00", VA = "0x1836DDE00")]
			[PreserveSig]
			internal static extern void criAtomEx3dTransceiver_SetTransceiverOutputBasedAzimuthAngleAisacControlId(IntPtr ex_3d_transceiver, ushort aisac_control_id);

			// Token: 0x06000321 RID: 801
			[Token(Token = "0x6000321")]
			[Address(RVA = "0x36DDE90", Offset = "0x36DCA90", VA = "0x1836DDE90")]
			[PreserveSig]
			internal static extern void criAtomEx3dTransceiver_SetTransceiverOutputBasedElevationAngleAisacControlId(IntPtr ex_3d_transceiver, ushort aisac_control_id);

			// Token: 0x06000322 RID: 802
			[Token(Token = "0x6000322")]
			[Address(RVA = "0x36DD5A0", Offset = "0x36DC1A0", VA = "0x1836DD5A0")]
			[PreserveSig]
			internal static extern void criAtomEx3dTransceiver_Set3dRegionHn(IntPtr ex_3d_transceiver, IntPtr ex_3d_region);
		}
	}
}
