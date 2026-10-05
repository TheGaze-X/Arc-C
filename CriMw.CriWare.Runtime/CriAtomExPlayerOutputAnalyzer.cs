using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace CriWare
{
	// Token: 0x02000091 RID: 145
	[Token(Token = "0x2000091")]
	[Obsolete("Use CriWare.CriAtomExOutputAnalyzer")]
	public class CriAtomExPlayerOutputAnalyzer : CriAtomExOutputAnalyzer
	{
		// Token: 0x06000581 RID: 1409 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000581")]
		[Address(RVA = "0x36E45C0", Offset = "0x36E31C0", VA = "0x1836E45C0")]
		public CriAtomExPlayerOutputAnalyzer(CriAtomExPlayerOutputAnalyzer.Type[] types, [Optional] CriAtomExPlayerOutputAnalyzer.Config[] configs)
		{
		}

		// Token: 0x02000092 RID: 146
		[Token(Token = "0x2000092")]
		public enum Type
		{
			// Token: 0x040002F1 RID: 753
			[Token(Token = "0x40002F1")]
			LevelMeter,
			// Token: 0x040002F2 RID: 754
			[Token(Token = "0x40002F2")]
			SpectrumAnalyzer,
			// Token: 0x040002F3 RID: 755
			[Token(Token = "0x40002F3")]
			PcmCapture
		}

		// Token: 0x02000093 RID: 147
		[Token(Token = "0x2000093")]
		public new struct Config
		{
			// Token: 0x06000582 RID: 1410 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000582")]
			[Address(RVA = "0x4F1E60", Offset = "0x4F0A60", VA = "0x1804F1E60")]
			public Config(int num_spectrum_analyzer_bands = 8, int num_stored_output_data = 4096)
			{
			}

			// Token: 0x040002F4 RID: 756
			[Token(Token = "0x40002F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int num_spectrum_analyzer_bands;

			// Token: 0x040002F5 RID: 757
			[Token(Token = "0x40002F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int num_stored_output_data;
		}
	}
}
