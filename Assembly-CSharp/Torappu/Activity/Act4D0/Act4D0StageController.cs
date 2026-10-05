using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using Torappu.UI.ActivityStage.Extern;
using XLua;

namespace Torappu.Activity.Act4D0
{
	// Token: 0x02007269 RID: 29289
	[Token(Token = "0x2007269")]
	public class Act4D0StageController : ActivityStageController
	{
		// Token: 0x17006237 RID: 25143
		// (get) Token: 0x060297F4 RID: 169972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006237")]
		public static string staticActivityId
		{
			[Token(Token = "0x60297F4")]
			[Address(RVA = "0x24E0830", Offset = "0x24DF430", VA = "0x1824E0830")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006238 RID: 25144
		// (get) Token: 0x060297F5 RID: 169973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006238")]
		public Act4D0InitMeta initMetaObj
		{
			[Token(Token = "0x60297F5")]
			[Address(RVA = "0x24E0780", Offset = "0x24DF380", VA = "0x1824E0780")]
			get
			{
				return null;
			}
		}

		// Token: 0x060297F6 RID: 169974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60297F6")]
		[Address(RVA = "0x24E03F0", Offset = "0x24DEFF0", VA = "0x1824E03F0", Slot = "5")]
		protected override ActivityStageBridge CreateBridge()
		{
			return null;
		}

		// Token: 0x060297F7 RID: 169975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60297F7")]
		[Address(RVA = "0x24E0490", Offset = "0x24DF090", VA = "0x1824E0490")]
		public static string CreateInitMeta4StoryState()
		{
			return null;
		}

		// Token: 0x060297F8 RID: 169976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60297F8")]
		[Address(RVA = "0x24E05E0", Offset = "0x24DF1E0", VA = "0x1824E05E0")]
		public static PlayerActivity.PlayerAct4D0Activity GetAct4D0PlayerInfo(string actId)
		{
			return null;
		}

		// Token: 0x060297F9 RID: 169977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60297F9")]
		[Address(RVA = "0x24E0520", Offset = "0x24DF120", VA = "0x1824E0520")]
		public static PlayerActivity.PlayerAct4D0Activity GetAct4D0PlayerInfoFromPlayerData(string actId, PlayerDataModel playerModel)
		{
			return null;
		}

		// Token: 0x060297FA RID: 169978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60297FA")]
		[Address(RVA = "0x24E0720", Offset = "0x24DF320", VA = "0x1824E0720")]
		public Act4D0StageController()
		{
		}

		// Token: 0x0403B4B9 RID: 242873
		[Token(Token = "0x403B4B9")]
		[FieldOffset(Offset = "0x60")]
		private Act4D0InitMeta m_initMetaObj;

		// Token: 0x0403B4BA RID: 242874
		[Token(Token = "0x403B4BA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_staticActivityId;

		// Token: 0x0403B4BB RID: 242875
		[Token(Token = "0x403B4BB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_initMetaObj;

		// Token: 0x0403B4BC RID: 242876
		[Token(Token = "0x403B4BC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CreateBridge;

		// Token: 0x0403B4BD RID: 242877
		[Token(Token = "0x403B4BD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CreateInitMeta4StoryState;

		// Token: 0x0403B4BE RID: 242878
		[Token(Token = "0x403B4BE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetAct4D0PlayerInfo;

		// Token: 0x0403B4BF RID: 242879
		[Token(Token = "0x403B4BF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetAct4D0PlayerInfoFromPlayerData;

		// Token: 0x0403B4C0 RID: 242880
		[Token(Token = "0x403B4C0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200726A RID: 29290
		[Token(Token = "0x200726A")]
		private class Bridge : ActivityStageBridge
		{
			// Token: 0x060297FB RID: 169979 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60297FB")]
			[Address(RVA = "0x24BE8D0", Offset = "0x24BD4D0", VA = "0x1824BE8D0")]
			public Bridge(Act4D0StageController controller)
			{
			}

			// Token: 0x0403B4C1 RID: 242881
			[Token(Token = "0x403B4C1")]
			[FieldOffset(Offset = "0x18")]
			private Act4D0StageController m_controller;
		}
	}
}
