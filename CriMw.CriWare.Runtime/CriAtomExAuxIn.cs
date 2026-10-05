using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace CriWare
{
	// Token: 0x0200007B RID: 123
	[Token(Token = "0x200007B")]
	public class CriAtomExAuxIn : CriDisposable
	{
		// Token: 0x060003C7 RID: 967 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x36C4740", Offset = "0x36C3340", VA = "0x1836C4740")]
		public CriAtomExAuxIn([Optional] CriAtomExAuxIn.Config? config)
		{
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x36C1240", Offset = "0x36BFE40", VA = "0x1836C1240", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x36C40F0", Offset = "0x36C2CF0", VA = "0x1836C40F0", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x060003CA RID: 970 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x36C4600", Offset = "0x36C3200", VA = "0x1836C4600")]
		public void Start()
		{
		}

		// Token: 0x060003CB RID: 971 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x36C4680", Offset = "0x36C3280", VA = "0x1836C4680")]
		public void Stop()
		{
		}

		// Token: 0x060003CC RID: 972 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x36C4380", Offset = "0x36C2F80", VA = "0x1836C4380")]
		public void SetFormat(int numChannels, int samplingRate)
		{
		}

		// Token: 0x060003CD RID: 973 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x36C4230", Offset = "0x36C2E30", VA = "0x1836C4230")]
		public void GetFormat(out int numChannels, out int samplingRate)
		{
		}

		// Token: 0x060003CE RID: 974 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x36C4570", Offset = "0x36C3170", VA = "0x1836C4570")]
		public void SetVolume(float volume)
		{
		}

		// Token: 0x060003CF RID: 975 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x36C4420", Offset = "0x36C3020", VA = "0x1836C4420")]
		public void SetFrequencyRatio(float frequencyRatio)
		{
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x36C42D0", Offset = "0x36C2ED0", VA = "0x1836C42D0")]
		public void SetBusSendLevel(string busName, float level)
		{
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x36C44B0", Offset = "0x36C30B0", VA = "0x1836C44B0")]
		public void SetInputReadStream(CriAudioReadStream stream)
		{
		}

		// Token: 0x060003D2 RID: 978
		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x36C48B0", Offset = "0x36C34B0", VA = "0x1836C48B0")]
		[PreserveSig]
		private static extern IntPtr criAtomAuxIn_Create([In] ref CriAtomExAuxIn.Config config, IntPtr work, int work_size);

		// Token: 0x060003D3 RID: 979
		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x36C4950", Offset = "0x36C3550", VA = "0x1836C4950")]
		[PreserveSig]
		private static extern void criAtomAuxIn_Destroy(IntPtr aux_in);

		// Token: 0x060003D4 RID: 980
		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x36C4D80", Offset = "0x36C3980", VA = "0x1836C4D80")]
		[PreserveSig]
		private static extern void criAtomAuxIn_Start(IntPtr aux_in);

		// Token: 0x060003D5 RID: 981
		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x36C4E00", Offset = "0x36C3A00", VA = "0x1836C4E00")]
		[PreserveSig]
		private static extern void criAtomAuxIn_Stop(IntPtr aux_in);

		// Token: 0x060003D6 RID: 982
		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x36C4CF0", Offset = "0x36C38F0", VA = "0x1836C4CF0")]
		[PreserveSig]
		private static extern void criAtomAuxIn_SetVolume(IntPtr aux_in, float volume);

		// Token: 0x060003D7 RID: 983
		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x36C4BC0", Offset = "0x36C37C0", VA = "0x1836C4BC0")]
		[PreserveSig]
		private static extern void criAtomAuxIn_SetFrequencyRatio(IntPtr aux_in, float ratio);

		// Token: 0x060003D8 RID: 984
		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x36C4A70", Offset = "0x36C3670", VA = "0x1836C4A70")]
		[PreserveSig]
		private static extern void criAtomAuxIn_SetBusSendLevelByName(IntPtr aux_in, string bus_name, float level);

		// Token: 0x060003D9 RID: 985
		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x36C4B20", Offset = "0x36C3720", VA = "0x1836C4B20")]
		[PreserveSig]
		private static extern void criAtomAuxIn_SetFormat(IntPtr aux_in, int num_channels, int sampling_rate);

		// Token: 0x060003DA RID: 986
		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x36C49D0", Offset = "0x36C35D0", VA = "0x1836C49D0")]
		[PreserveSig]
		private static extern void criAtomAuxIn_GetFormat(IntPtr aux_in, out int num_channels, out int sampling_rate);

		// Token: 0x060003DB RID: 987
		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x36C4C50", Offset = "0x36C3850", VA = "0x1836C4C50")]
		[PreserveSig]
		private static extern void criAtomAuxIn_SetInputReadStream(IntPtr aux_in, IntPtr stream_cbfunc, IntPtr stream_ptr);

		// Token: 0x0400028C RID: 652
		[Token(Token = "0x400028C")]
		private const string errorInvalidHandle = "[CRIWARE] Invalid native handle of CriAtomExAuxIn.";

		// Token: 0x0400028D RID: 653
		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private IntPtr handle;

		// Token: 0x0400028E RID: 654
		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CriAudioReadStream inputReadStream;

		// Token: 0x0200007C RID: 124
		[Token(Token = "0x200007C")]
		public struct Config
		{
			// Token: 0x1700004B RID: 75
			// (get) Token: 0x060003DC RID: 988 RVA: 0x000030EC File Offset: 0x000012EC
			[Token(Token = "0x1700004B")]
			public static CriAtomExAuxIn.Config Default
			{
				[Token(Token = "0x60003DC")]
				[Address(RVA = "0x36B3EE0", Offset = "0x36B2AE0", VA = "0x1836B3EE0")]
				get
				{
					return default(CriAtomExAuxIn.Config);
				}
			}

			// Token: 0x0400028F RID: 655
			[Token(Token = "0x400028F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int maxChannels;

			// Token: 0x04000290 RID: 656
			[Token(Token = "0x4000290")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int maxSamplingRate;

			// Token: 0x04000291 RID: 657
			[Token(Token = "0x4000291")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public CriAtomEx.SoundRendererType soundRendererType;
		}
	}
}
