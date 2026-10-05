using System;
using Il2CppDummyDll;

namespace CriWare
{
	// Token: 0x0200005A RID: 90
	[Token(Token = "0x200005A")]
	[Obsolete("This feature is obsoleted. Estimation will not occur if SonicSYNC is enabled.")]
	public static class CriAtomExLatencyEstimator
	{
		// Token: 0x0600029F RID: 671 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600029F")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public static void InitializeModule()
		{
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public static void FinalizeModule()
		{
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00002BAC File Offset: 0x00000DAC
		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x36C7210", Offset = "0x36C5E10", VA = "0x1836C7210")]
		public static CriAtomExLatencyEstimator.EstimatorInfo GetCurrentInfo()
		{
			return default(CriAtomExLatencyEstimator.EstimatorInfo);
		}

		// Token: 0x0200005B RID: 91
		[Token(Token = "0x200005B")]
		public enum Status
		{
			// Token: 0x040001E5 RID: 485
			[Token(Token = "0x40001E5")]
			Stop,
			// Token: 0x040001E6 RID: 486
			[Token(Token = "0x40001E6")]
			Processing,
			// Token: 0x040001E7 RID: 487
			[Token(Token = "0x40001E7")]
			Done,
			// Token: 0x040001E8 RID: 488
			[Token(Token = "0x40001E8")]
			Error
		}

		// Token: 0x0200005C RID: 92
		[Token(Token = "0x200005C")]
		public struct EstimatorInfo
		{
			// Token: 0x040001E9 RID: 489
			[Token(Token = "0x40001E9")]
			[FieldOffset(Offset = "0x0")]
			public CriAtomExLatencyEstimator.Status status;

			// Token: 0x040001EA RID: 490
			[Token(Token = "0x40001EA")]
			[FieldOffset(Offset = "0x4")]
			public uint estimated_latency;
		}
	}
}
