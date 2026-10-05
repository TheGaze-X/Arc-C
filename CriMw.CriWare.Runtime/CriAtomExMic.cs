using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace CriWare
{
	// Token: 0x0200007D RID: 125
	[Token(Token = "0x200007D")]
	public class CriAtomExMic : CriDisposable
	{
		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060003DD RID: 989 RVA: 0x00003104 File Offset: 0x00001304
		// (set) Token: 0x060003DE RID: 990 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700004C")]
		public static bool isInitialized
		{
			[Token(Token = "0x60003DD")]
			[Address(RVA = "0x36CA250", Offset = "0x36C8E50", VA = "0x1836CA250")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003DE")]
			[Address(RVA = "0x36CA290", Offset = "0x36C8E90", VA = "0x1836CA290")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x36C8380", Offset = "0x36C6F80", VA = "0x1836C8380")]
		public static void InitializeModule()
		{
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x36C7A90", Offset = "0x36C6690", VA = "0x1836C7A90")]
		public static void FinalizeModule()
		{
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public static void SetupOutputCategoryForMic_IOS(bool enable)
		{
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x36C7E20", Offset = "0x36C6A20", VA = "0x1836C7E20")]
		public static CriAtomExMic.DeviceInfo[] GetDevices()
		{
			return null;
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x0000311C File Offset: 0x0000131C
		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x36C8210", Offset = "0x36C6E10", VA = "0x1836C8210")]
		public static int GetNumDevices()
		{
			return 0;
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00003134 File Offset: 0x00001334
		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x36C7C20", Offset = "0x36C6820", VA = "0x1836C7C20")]
		public static CriAtomExMic.DeviceInfo? GetDefaultDevice()
		{
			return null;
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x0000314C File Offset: 0x0000134C
		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x36C8730", Offset = "0x36C7330", VA = "0x1836C8730")]
		public static bool IsFormatSupported(CriAtomExMic.Config config)
		{
			return default(bool);
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x36C7410", Offset = "0x36C6010", VA = "0x1836C7410")]
		public static CriAtomExMic Create([Optional] CriAtomExMic.Config? config)
		{
			return null;
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x36C92B0", Offset = "0x36C7EB0", VA = "0x1836C92B0")]
		private CriAtomExMic(IntPtr handle)
		{
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x36C1240", Offset = "0x36BFE40", VA = "0x1836C1240", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x36C7940", Offset = "0x36C6540", VA = "0x1836C7940", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x36C7830", Offset = "0x36C6430", VA = "0x1836C7830")]
		private void Dispose(bool disposing)
		{
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x36C9110", Offset = "0x36C7D10", VA = "0x1836C9110")]
		public void Start()
		{
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x36C9190", Offset = "0x36C7D90", VA = "0x1836C9190")]
		public void Stop()
		{
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00003164 File Offset: 0x00001364
		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x36C8190", Offset = "0x36C6D90", VA = "0x1836C8190")]
		public int GetNumChannels()
		{
			return 0;
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x0000317C File Offset: 0x0000137C
		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x36C8300", Offset = "0x36C6F00", VA = "0x1836C8300")]
		public int GetSamplingRate()
		{
			return 0;
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00003194 File Offset: 0x00001394
		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x36C8110", Offset = "0x36C6D10", VA = "0x1836C8110")]
		public uint GetNumBufferedSamples()
		{
			return 0U;
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x000031AC File Offset: 0x000013AC
		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x36C8110", Offset = "0x36C6D10", VA = "0x1836C8110")]
		[Obsolete("Use CriWare.CriAtomExMic.GetNumBufferedSamples")]
		public uint GetNumBufferredSamples()
		{
			return 0U;
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x000031C4 File Offset: 0x000013C4
		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x36C8660", Offset = "0x36C7260", VA = "0x1836C8660")]
		public bool IsAvailable()
		{
			return default(bool);
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x000031DC File Offset: 0x000013DC
		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x36C89E0", Offset = "0x36C75E0", VA = "0x1836C89E0")]
		public uint ReadData(float[] bufferMono)
		{
			return 0U;
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x000031F4 File Offset: 0x000013F4
		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x36C8CD0", Offset = "0x36C78D0", VA = "0x1836C8CD0")]
		public uint ReadData(float[] bufferMono, uint numToRead)
		{
			return 0U;
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x0000320C File Offset: 0x0000140C
		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x36C87E0", Offset = "0x36C73E0", VA = "0x1836C87E0")]
		public uint ReadData(float[] bufferL, float[] bufferR)
		{
			return 0U;
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x00003224 File Offset: 0x00001424
		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x36C8A90", Offset = "0x36C7690", VA = "0x1836C8A90")]
		public uint ReadData(float[] bufferL, float[] bufferR, uint numToRead)
		{
			return 0U;
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x0000323C File Offset: 0x0000143C
		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x36C8810", Offset = "0x36C7410", VA = "0x1836C8810")]
		public uint ReadData(float[][] buffers)
		{
			return 0U;
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00003254 File Offset: 0x00001454
		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x36C8D70", Offset = "0x36C7970", VA = "0x1836C8D70")]
		public uint ReadData(float[][] buffers, uint numToRead)
		{
			return 0U;
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x36C9090", Offset = "0x36C7C90", VA = "0x1836C9090")]
		public void SetOutputWriteStream(CriAudioWriteStream stream)
		{
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x36C8220", Offset = "0x36C6E20", VA = "0x1836C8220")]
		public CriAudioReadStream GetOutputReadStream()
		{
			return null;
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x36C7220", Offset = "0x36C5E20", VA = "0x1836C7220")]
		public CriAtomExMic.Effect AttachEffect(IntPtr afxInterface, float[] configParameters)
		{
			return null;
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x36C7790", Offset = "0x36C6390", VA = "0x1836C7790")]
		public void DetachEffect(CriAtomExMic.Effect effect)
		{
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x36C8FD0", Offset = "0x36C7BD0", VA = "0x1836C8FD0")]
		public void SetEffectParameter(CriAtomExMic.Effect effect, int parameterIndex, float parameterValue)
		{
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x0000326C File Offset: 0x0000146C
		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x36C8060", Offset = "0x36C6C60", VA = "0x1836C8060")]
		public float GetEffectParameter(CriAtomExMic.Effect effect, int parameterIndex)
		{
			return 0f;
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x36C8F20", Offset = "0x36C7B20", VA = "0x1836C8F20")]
		public void SetEffectBypass(CriAtomExMic.Effect effect, bool bypass)
		{
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x36C9210", Offset = "0x36C7E10", VA = "0x1836C9210")]
		public void UpdateEffectParameters(CriAtomExMic.Effect effect)
		{
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x00003284 File Offset: 0x00001484
		[Token(Token = "0x6000400")]
		[Address(RVA = "0x36C85C0", Offset = "0x36C71C0", VA = "0x1836C85C0")]
		private uint InternalReadDataFromBufferPointers(uint numToRead)
		{
			return 0U;
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000401")]
		[Address(RVA = "0x36C84E0", Offset = "0x36C70E0", VA = "0x1836C84E0")]
		private void InternalClearBuffers()
		{
		}

		// Token: 0x06000402 RID: 1026
		[Token(Token = "0x6000402")]
		[Address(RVA = "0x36C9470", Offset = "0x36C8070", VA = "0x1836C9470")]
		[PreserveSig]
		private static extern void criAtomMicUnity_Initialize();

		// Token: 0x06000403 RID: 1027
		[Token(Token = "0x6000403")]
		[Address(RVA = "0x36C9400", Offset = "0x36C8000", VA = "0x1836C9400")]
		[PreserveSig]
		private static extern void criAtomMicUnity_Finalize();

		// Token: 0x06000404 RID: 1028
		[Token(Token = "0x6000404")]
		[Address(RVA = "0x36C9C50", Offset = "0x36C8850", VA = "0x1836C9C50")]
		[PreserveSig]
		private static extern int criAtomMic_GetNumDevices();

		// Token: 0x06000405 RID: 1029
		[Token(Token = "0x6000405")]
		[Address(RVA = "0x36C9920", Offset = "0x36C8520", VA = "0x1836C9920")]
		[PreserveSig]
		private static extern bool criAtomMic_GetDevice(int index, out CriAtomExMic.DeviceInfo info);

		// Token: 0x06000406 RID: 1030
		[Token(Token = "0x6000406")]
		[Address(RVA = "0x36C9830", Offset = "0x36C8430", VA = "0x1836C9830")]
		[PreserveSig]
		private static extern bool criAtomMic_GetDefaultDevice(out CriAtomExMic.DeviceInfo info);

		// Token: 0x06000407 RID: 1031
		[Token(Token = "0x6000407")]
		[Address(RVA = "0x36C8730", Offset = "0x36C7330", VA = "0x1836C8730")]
		[PreserveSig]
		private static extern bool criAtomMic_IsFormatSupported([In] ref CriAtomExMic.Config config);

		// Token: 0x06000408 RID: 1032
		[Token(Token = "0x6000408")]
		[Address(RVA = "0x36C9660", Offset = "0x36C8260", VA = "0x1836C9660")]
		[PreserveSig]
		private static extern IntPtr criAtomMic_Create([In] ref CriAtomExMic.Config config, IntPtr work, int work_size);

		// Token: 0x06000409 RID: 1033
		[Token(Token = "0x6000409")]
		[Address(RVA = "0x36C9720", Offset = "0x36C8320", VA = "0x1836C9720")]
		[PreserveSig]
		private static extern void criAtomMic_Destroy(IntPtr mic);

		// Token: 0x0600040A RID: 1034
		[Token(Token = "0x600040A")]
		[Address(RVA = "0x36CA0C0", Offset = "0x36C8CC0", VA = "0x1836CA0C0")]
		[PreserveSig]
		private static extern void criAtomMic_Start(IntPtr mic);

		// Token: 0x0600040B RID: 1035
		[Token(Token = "0x600040B")]
		[Address(RVA = "0x36CA140", Offset = "0x36C8D40", VA = "0x1836CA140")]
		[PreserveSig]
		private static extern void criAtomMic_Stop(IntPtr mic);

		// Token: 0x0600040C RID: 1036
		[Token(Token = "0x600040C")]
		[Address(RVA = "0x36C9BD0", Offset = "0x36C87D0", VA = "0x1836C9BD0")]
		[PreserveSig]
		private static extern int criAtomMic_GetNumChannels(IntPtr mic);

		// Token: 0x0600040D RID: 1037
		[Token(Token = "0x600040D")]
		[Address(RVA = "0x36C9D30", Offset = "0x36C8930", VA = "0x1836C9D30")]
		[PreserveSig]
		private static extern int criAtomMic_GetSamplingRate(IntPtr mic);

		// Token: 0x0600040E RID: 1038
		[Token(Token = "0x600040E")]
		[Address(RVA = "0x36C9B50", Offset = "0x36C8750", VA = "0x1836C9B50")]
		[PreserveSig]
		private static extern uint criAtomMic_GetNumBufferedSamples(IntPtr mic);

		// Token: 0x0600040F RID: 1039
		[Token(Token = "0x600040F")]
		[Address(RVA = "0x36C9DB0", Offset = "0x36C89B0", VA = "0x1836C9DB0")]
		[PreserveSig]
		private static extern bool criAtomMic_IsAvailable(IntPtr mic);

		// Token: 0x06000410 RID: 1040
		[Token(Token = "0x6000410")]
		[Address(RVA = "0x36C9E30", Offset = "0x36C8A30", VA = "0x1836C9E30")]
		[PreserveSig]
		private static extern uint criAtomMic_ReadData(IntPtr mic, IntPtr[] data, uint num_samples);

		// Token: 0x06000411 RID: 1041
		[Token(Token = "0x6000411")]
		[Address(RVA = "0x36CA020", Offset = "0x36C8C20", VA = "0x1836CA020")]
		[PreserveSig]
		private static extern void criAtomMic_SetOutputWriteStream(IntPtr mic, IntPtr stream_cbfunc, IntPtr stream_ptr);

		// Token: 0x06000412 RID: 1042
		[Token(Token = "0x6000412")]
		[Address(RVA = "0x36C9CC0", Offset = "0x36C88C0", VA = "0x1836C9CC0")]
		[PreserveSig]
		private static extern IntPtr criAtomMic_GetOutputReadStream();

		// Token: 0x06000413 RID: 1043
		[Token(Token = "0x6000413")]
		[Address(RVA = "0x36C95B0", Offset = "0x36C81B0", VA = "0x1836C95B0")]
		[PreserveSig]
		private static extern int criAtomMic_CalculateWorkSizeForEffect(IntPtr mic, IntPtr afx_interface, float[] config_parameters, uint num_config_parameters);

		// Token: 0x06000414 RID: 1044
		[Token(Token = "0x6000414")]
		[Address(RVA = "0x36C94E0", Offset = "0x36C80E0", VA = "0x1836C94E0")]
		[PreserveSig]
		private static extern IntPtr criAtomMic_AttachEffect(IntPtr mic, IntPtr afx_interface, float[] config_parameters, uint num_config_parameters, IntPtr work, int work_size);

		// Token: 0x06000415 RID: 1045
		[Token(Token = "0x6000415")]
		[Address(RVA = "0x36C97A0", Offset = "0x36C83A0", VA = "0x1836C97A0")]
		[PreserveSig]
		private static extern void criAtomMic_DetachEffect(IntPtr mic, IntPtr effect);

		// Token: 0x06000416 RID: 1046
		[Token(Token = "0x6000416")]
		[Address(RVA = "0x36C9A20", Offset = "0x36C8620", VA = "0x1836C9A20")]
		[PreserveSig]
		private static extern IntPtr criAtomMic_GetEffectInstance(IntPtr mic, IntPtr effect);

		// Token: 0x06000417 RID: 1047
		[Token(Token = "0x6000417")]
		[Address(RVA = "0x36C9ED0", Offset = "0x36C8AD0", VA = "0x1836C9ED0")]
		[PreserveSig]
		private static extern void criAtomMic_SetEffectBypass(IntPtr mic, IntPtr effect, bool bypass);

		// Token: 0x06000418 RID: 1048
		[Token(Token = "0x6000418")]
		[Address(RVA = "0x36C9F70", Offset = "0x36C8B70", VA = "0x1836C9F70")]
		[PreserveSig]
		private static extern void criAtomMic_SetEffectParameter(IntPtr mic, IntPtr effect, uint parameter_index, float parameter_value);

		// Token: 0x06000419 RID: 1049
		[Token(Token = "0x6000419")]
		[Address(RVA = "0x36C9AB0", Offset = "0x36C86B0", VA = "0x1836C9AB0")]
		[PreserveSig]
		private static extern float criAtomMic_GetEffectParameter(IntPtr mic, IntPtr effect, uint parameter_index);

		// Token: 0x0600041A RID: 1050
		[Token(Token = "0x600041A")]
		[Address(RVA = "0x36CA1C0", Offset = "0x36C8DC0", VA = "0x1836CA1C0")]
		[PreserveSig]
		private static extern void criAtomMic_UpdateEffectParameters(IntPtr mic, IntPtr effect);

		// Token: 0x04000292 RID: 658
		[Token(Token = "0x4000292")]
		private const string errorInvalidHandle = "[CRIWARE] Invalid native handle of CriAtomMic.";

		// Token: 0x04000293 RID: 659
		[Token(Token = "0x4000293")]
		private const string errorInvalidBufferLength = "[CRIWARE] Invalid buffer length for CriAtomMic.ReadData.";

		// Token: 0x04000294 RID: 660
		[Token(Token = "0x4000294")]
		private const string errorInvalidNumBuffers = "[CRIWARE] Number of buffers are not same with channels of CriAtomMic.";

		// Token: 0x04000295 RID: 661
		[Token(Token = "0x4000295")]
		private const string errorAlreadyInitialized = "[CRIWARE] CriAtomMic module is already initialized.";

		// Token: 0x04000296 RID: 662
		[Token(Token = "0x4000296")]
		private const string errorNotInitialized = "[CRIWARE] CriAtomMic module is not initialized.";

		// Token: 0x04000298 RID: 664
		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private IntPtr handle;

		// Token: 0x04000299 RID: 665
		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IntPtr[] bufferPointers;

		// Token: 0x0400029A RID: 666
		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private GCHandle[] gcHandles;

		// Token: 0x0400029B RID: 667
		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private CriAudioWriteStream outputWriteStream;

		// Token: 0x0400029C RID: 668
		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static int _initializationCount;

		// Token: 0x0200007E RID: 126
		[Token(Token = "0x200007E")]
		public struct DeviceInfo
		{
			// Token: 0x0400029D RID: 669
			[Token(Token = "0x400029D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string deviceId;

			// Token: 0x0400029E RID: 670
			[Token(Token = "0x400029E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string deviceName;

			// Token: 0x0400029F RID: 671
			[Token(Token = "0x400029F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public uint deviceFlags;

			// Token: 0x040002A0 RID: 672
			[Token(Token = "0x40002A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int maxChannels;

			// Token: 0x040002A1 RID: 673
			[Token(Token = "0x40002A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int maxSamplingRate;
		}

		// Token: 0x0200007F RID: 127
		[Token(Token = "0x200007F")]
		public struct Config
		{
			// Token: 0x1700004D RID: 77
			// (get) Token: 0x0600041B RID: 1051 RVA: 0x0000329C File Offset: 0x0000149C
			[Token(Token = "0x1700004D")]
			public static CriAtomExMic.Config Default
			{
				[Token(Token = "0x600041B")]
				[Address(RVA = "0x36DEDC0", Offset = "0x36DD9C0", VA = "0x1836DEDC0")]
				get
				{
					return default(CriAtomExMic.Config);
				}
			}

			// Token: 0x040002A2 RID: 674
			[Token(Token = "0x40002A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string deviceId;

			// Token: 0x040002A3 RID: 675
			[Token(Token = "0x40002A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public uint flags;

			// Token: 0x040002A4 RID: 676
			[Token(Token = "0x40002A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int numChannels;

			// Token: 0x040002A5 RID: 677
			[Token(Token = "0x40002A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int samplingRate;

			// Token: 0x040002A6 RID: 678
			[Token(Token = "0x40002A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public uint frameSize;

			// Token: 0x040002A7 RID: 679
			[Token(Token = "0x40002A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public uint bufferingTime;

			// Token: 0x040002A8 RID: 680
			[Token(Token = "0x40002A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public IntPtr context;
		}

		// Token: 0x02000080 RID: 128
		[Token(Token = "0x2000080")]
		public class Effect
		{
			// Token: 0x1700004E RID: 78
			// (get) Token: 0x0600041C RID: 1052 RVA: 0x000032B4 File Offset: 0x000014B4
			// (set) Token: 0x0600041D RID: 1053 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x1700004E")]
			public IntPtr handle
			{
				[Token(Token = "0x600041C")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x600041D")]
				[Address(RVA = "0xD980D0", Offset = "0xD96CD0", VA = "0x180D980D0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700004F RID: 79
			// (get) Token: 0x0600041E RID: 1054 RVA: 0x000032CC File Offset: 0x000014CC
			// (set) Token: 0x0600041F RID: 1055 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x1700004F")]
			public IntPtr afxInstance
			{
				[Token(Token = "0x600041E")]
				[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x600041F")]
				[Address(RVA = "0x3244A50", Offset = "0x3243650", VA = "0x183244A50")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06000420 RID: 1056 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000420")]
			[Address(RVA = "0x3707440", Offset = "0x3706040", VA = "0x183707440")]
			public Effect(IntPtr handle, IntPtr afxInstance)
			{
			}
		}
	}
}
