using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage.Extern;
using XLua;

namespace Torappu.Activity.Act3D0
{
	// Token: 0x02007428 RID: 29736
	[Token(Token = "0x2007428")]
	public struct Act3D0ZoneDescModel : IHotfixable
	{
		// Token: 0x06029F91 RID: 171921 RVA: 0x000D7190 File Offset: 0x000D5390
		[Token(Token = "0x6029F91")]
		[Address(RVA = "0x2591C70", Offset = "0x2590870", VA = "0x182591C70")]
		public static Act3D0ZoneDescModel Create(ActivityZoneViewModel targetModel, Act3D0Data.ZoneDescInfo zoneDescModel, ZoneValidInfo validInfo, long curTs)
		{
			return default(Act3D0ZoneDescModel);
		}

		// Token: 0x06029F92 RID: 171922 RVA: 0x000D71A8 File Offset: 0x000D53A8
		[Token(Token = "0x6029F92")]
		[Address(RVA = "0x2591F80", Offset = "0x2590B80", VA = "0x182591F80")]
		private static bool _HasNewStages(ActivityZoneViewModel targetModel)
		{
			return default(bool);
		}

		// Token: 0x06029F93 RID: 171923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029F93")]
		[Address(RVA = "0x25920B0", Offset = "0x2590CB0", VA = "0x1825920B0")]
		private static string _ParseTimeLockedInfo(long curTs, ITimeValidInfo validInfo)
		{
			return null;
		}

		// Token: 0x0403C2DC RID: 246492
		[Token(Token = "0x403C2DC")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Act3D0ZoneDescModel EMPTY;

		// Token: 0x0403C2DD RID: 246493
		[Token(Token = "0x403C2DD")]
		[FieldOffset(Offset = "0x0")]
		public string zoneId;

		// Token: 0x0403C2DE RID: 246494
		[Token(Token = "0x403C2DE")]
		[FieldOffset(Offset = "0x8")]
		public bool isUnlocked;

		// Token: 0x0403C2DF RID: 246495
		[Token(Token = "0x403C2DF")]
		[FieldOffset(Offset = "0x10")]
		public string lockedText;

		// Token: 0x0403C2E0 RID: 246496
		[Token(Token = "0x403C2E0")]
		[FieldOffset(Offset = "0x18")]
		public bool hasNewStages;

		// Token: 0x0403C2E1 RID: 246497
		[Token(Token = "0x403C2E1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Create;

		// Token: 0x0403C2E2 RID: 246498
		[Token(Token = "0x403C2E2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__HasNewStages;

		// Token: 0x0403C2E3 RID: 246499
		[Token(Token = "0x403C2E3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ParseTimeLockedInfo;
	}
}
