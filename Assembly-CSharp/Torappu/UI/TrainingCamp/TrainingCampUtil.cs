using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.TrainingCamp
{
	// Token: 0x02003D27 RID: 15655
	[Token(Token = "0x2003D27")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class TrainingCampUtil
	{
		// Token: 0x06018680 RID: 99968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018680")]
		[Address(RVA = "0x10D78B0", Offset = "0x10D64B0", VA = "0x1810D78B0")]
		public static DataBundle GenDataBundleToTrainingCamp(TrainingCampUtil.JumpParam param)
		{
			return null;
		}

		// Token: 0x06018681 RID: 99969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018681")]
		[Address(RVA = "0x10D7970", Offset = "0x10D6570", VA = "0x1810D7970")]
		public static UIPageControllerParam GenSceneParamToTrainingCamp(DataBundle dataBundle)
		{
			return null;
		}

		// Token: 0x0401DDAE RID: 122286
		[Token(Token = "0x401DDAE")]
		public const string STAGE_ID_PARAM = "STAGE_ID";

		// Token: 0x0401DDAF RID: 122287
		[Token(Token = "0x401DDAF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GenDataBundleToTrainingCamp;

		// Token: 0x0401DDB0 RID: 122288
		[Token(Token = "0x401DDB0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GenSceneParamToTrainingCamp;

		// Token: 0x02003D28 RID: 15656
		[Token(Token = "0x2003D28")]
		public class JumpParam
		{
			// Token: 0x06018682 RID: 99970 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018682")]
			[Address(RVA = "0x10D1550", Offset = "0x10D0150", VA = "0x1810D1550")]
			public void LoadFromDataBundle(DataBundle dataBundle)
			{
			}

			// Token: 0x06018683 RID: 99971 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018683")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public JumpParam()
			{
			}

			// Token: 0x0401DDB1 RID: 122289
			[Token(Token = "0x401DDB1")]
			[FieldOffset(Offset = "0x10")]
			public string stageId;
		}
	}
}
