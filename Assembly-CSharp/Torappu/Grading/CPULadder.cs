using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Grading
{
	// Token: 0x02001636 RID: 5686
	[Token(Token = "0x2001636")]
	public class CPULadder : ScriptableObject, IHotfixable
	{
		// Token: 0x17000F49 RID: 3913
		// (get) Token: 0x0600810F RID: 33039 RVA: 0x00038550 File Offset: 0x00036750
		[Token(Token = "0x17000F49")]
		public int MiddleThresholdSocScore
		{
			[Token(Token = "0x600810F")]
			[Address(RVA = "0x2AF9050", Offset = "0x2AF7C50", VA = "0x182AF9050")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000F4A RID: 3914
		// (get) Token: 0x06008110 RID: 33040 RVA: 0x00038568 File Offset: 0x00036768
		[Token(Token = "0x17000F4A")]
		public int LowThresholdSocScore
		{
			[Token(Token = "0x6008110")]
			[Address(RVA = "0x2AF8FF0", Offset = "0x2AF7BF0", VA = "0x182AF8FF0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000F4B RID: 3915
		// (get) Token: 0x06008111 RID: 33041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F4B")]
		public List<CPULadder.CPUData> androidCPULadder
		{
			[Token(Token = "0x6008111")]
			[Address(RVA = "0x2AF90B0", Offset = "0x2AF7CB0", VA = "0x182AF90B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F4C RID: 3916
		// (get) Token: 0x06008112 RID: 33042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F4C")]
		public List<CPULadder.GPUData> androidGPULadder
		{
			[Token(Token = "0x6008112")]
			[Address(RVA = "0x2AF9110", Offset = "0x2AF7D10", VA = "0x182AF9110")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F4D RID: 3917
		// (get) Token: 0x06008113 RID: 33043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F4D")]
		public List<CPULadder.IOSGenerationData> iOSGenerationLadder
		{
			[Token(Token = "0x6008113")]
			[Address(RVA = "0x2AF9170", Offset = "0x2AF7D70", VA = "0x182AF9170")]
			get
			{
				return null;
			}
		}

		// Token: 0x06008114 RID: 33044 RVA: 0x00038580 File Offset: 0x00036780
		[Token(Token = "0x6008114")]
		[Address(RVA = "0x2AF8B10", Offset = "0x2AF7710", VA = "0x182AF8B10")]
		public bool TryFindAndroidCPUDataByLadder(List<string> cpuCandidates, out string cpu, out CPULadder.CPUData data)
		{
			return default(bool);
		}

		// Token: 0x06008115 RID: 33045 RVA: 0x00038598 File Offset: 0x00036798
		[Token(Token = "0x6008115")]
		[Address(RVA = "0x2AF8800", Offset = "0x2AF7400", VA = "0x182AF8800")]
		public GradingController.GradingLevel FindAndroidGradingLevelByGPU(string gpu)
		{
			return GradingController.GradingLevel.NODEFINE;
		}

		// Token: 0x06008116 RID: 33046 RVA: 0x000385B0 File Offset: 0x000367B0
		[Token(Token = "0x6008116")]
		[Address(RVA = "0x2AF89A0", Offset = "0x2AF75A0", VA = "0x182AF89A0")]
		public GradingController.GradingLevel FindIOSGradingLevelByGeneration(int generation)
		{
			return GradingController.GradingLevel.NODEFINE;
		}

		// Token: 0x06008117 RID: 33047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008117")]
		[Address(RVA = "0x2AF8600", Offset = "0x2AF7200", VA = "0x182AF8600")]
		public List<CPULadder.CPUData> FindAllMatchedCPUDataByLadder(string cpu)
		{
			return null;
		}

		// Token: 0x06008118 RID: 33048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008118")]
		[Address(RVA = "0x2AF8E90", Offset = "0x2AF7A90", VA = "0x182AF8E90")]
		public CPULadder()
		{
		}

		// Token: 0x040082A9 RID: 33449
		[Token(Token = "0x40082A9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int _middleThresholdSOCScore;

		// Token: 0x040082AA RID: 33450
		[Token(Token = "0x40082AA")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private int _lowThresholdSOCScore;

		// Token: 0x040082AB RID: 33451
		[Token(Token = "0x40082AB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<CPULadder.CPUData> _androidCPULadder;

		// Token: 0x040082AC RID: 33452
		[Token(Token = "0x40082AC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<CPULadder.GPUData> _androidGPULadder;

		// Token: 0x040082AD RID: 33453
		[Token(Token = "0x40082AD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<CPULadder.IOSGenerationData> _iOSGenerationLadder;

		// Token: 0x040082AE RID: 33454
		[Token(Token = "0x40082AE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_MiddleThresholdSocScore;

		// Token: 0x040082AF RID: 33455
		[Token(Token = "0x40082AF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_LowThresholdSocScore;

		// Token: 0x040082B0 RID: 33456
		[Token(Token = "0x40082B0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_androidCPULadder;

		// Token: 0x040082B1 RID: 33457
		[Token(Token = "0x40082B1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_androidGPULadder;

		// Token: 0x040082B2 RID: 33458
		[Token(Token = "0x40082B2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_iOSGenerationLadder;

		// Token: 0x040082B3 RID: 33459
		[Token(Token = "0x40082B3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_TryFindAndroidCPUDataByLadder;

		// Token: 0x040082B4 RID: 33460
		[Token(Token = "0x40082B4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_FindAndroidGradingLevelByGPU;

		// Token: 0x040082B5 RID: 33461
		[Token(Token = "0x40082B5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_FindIOSGradingLevelByGeneration;

		// Token: 0x040082B6 RID: 33462
		[Token(Token = "0x40082B6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_FindAllMatchedCPUDataByLadder;

		// Token: 0x040082B7 RID: 33463
		[Token(Token = "0x40082B7")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001637 RID: 5687
		[Token(Token = "0x2001637")]
		[Serializable]
		public class CPUData
		{
			// Token: 0x06008119 RID: 33049 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008119")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CPUData()
			{
			}

			// Token: 0x040082B8 RID: 33464
			[Token(Token = "0x40082B8")]
			[FieldOffset(Offset = "0x10")]
			public string cpu;

			// Token: 0x040082B9 RID: 33465
			[Token(Token = "0x40082B9")]
			[FieldOffset(Offset = "0x18")]
			public string mainKeyword;

			// Token: 0x040082BA RID: 33466
			[Token(Token = "0x40082BA")]
			[FieldOffset(Offset = "0x20")]
			public float score;
		}

		// Token: 0x02001638 RID: 5688
		[Token(Token = "0x2001638")]
		[Serializable]
		public class GPUData
		{
			// Token: 0x0600811A RID: 33050 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600811A")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public GPUData()
			{
			}

			// Token: 0x040082BB RID: 33467
			[Token(Token = "0x40082BB")]
			[FieldOffset(Offset = "0x10")]
			public string gpu;

			// Token: 0x040082BC RID: 33468
			[Token(Token = "0x40082BC")]
			[FieldOffset(Offset = "0x18")]
			public GradingController.GradingLevel gradingLevel;
		}

		// Token: 0x02001639 RID: 5689
		[Token(Token = "0x2001639")]
		[Serializable]
		public class IOSGenerationData
		{
			// Token: 0x0600811B RID: 33051 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600811B")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public IOSGenerationData()
			{
			}

			// Token: 0x040082BD RID: 33469
			[Token(Token = "0x40082BD")]
			[FieldOffset(Offset = "0x10")]
			public int iOSGeneration;

			// Token: 0x040082BE RID: 33470
			[Token(Token = "0x40082BE")]
			[FieldOffset(Offset = "0x14")]
			public GradingController.GradingLevel gradingLevel;
		}
	}
}
