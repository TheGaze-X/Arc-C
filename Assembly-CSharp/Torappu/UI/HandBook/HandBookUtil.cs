using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x0200666B RID: 26219
	[Token(Token = "0x200666B")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class HandBookUtil
	{
		// Token: 0x06025A5E RID: 154206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025A5E")]
		[Address(RVA = "0x209DB90", Offset = "0x209C790", VA = "0x18209DB90")]
		public static DataBundle GenDataBundleToHandBook(HandBookUtil.DataParam param)
		{
			return null;
		}

		// Token: 0x06025A5F RID: 154207 RVA: 0x000C8A90 File Offset: 0x000C6C90
		[Token(Token = "0x6025A5F")]
		[Address(RVA = "0x209DD90", Offset = "0x209C990", VA = "0x18209DD90")]
		public static UIPageStackParam GenPageStackParamToHandBook(DataBundle bundleToHandBook, bool preserveBottom = true)
		{
			return default(UIPageStackParam);
		}

		// Token: 0x06025A60 RID: 154208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025A60")]
		[Address(RVA = "0x209EB90", Offset = "0x209D790", VA = "0x18209EB90")]
		public static UIPageControllerParam SceneParamToHandBook(DataBundle bundleToHandBook)
		{
			return null;
		}

		// Token: 0x06025A61 RID: 154209 RVA: 0x000C8AA8 File Offset: 0x000C6CA8
		[Token(Token = "0x6025A61")]
		[Address(RVA = "0x209D340", Offset = "0x209BF40", VA = "0x18209D340")]
		public static bool CheckBanFlag(int barIndex)
		{
			return default(bool);
		}

		// Token: 0x06025A62 RID: 154210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A62")]
		[Address(RVA = "0x209E890", Offset = "0x209D490", VA = "0x18209E890")]
		public static void HandleTopMenu(State topState, bool isDismiss)
		{
		}

		// Token: 0x06025A63 RID: 154211 RVA: 0x000C8AC0 File Offset: 0x000C6CC0
		[Token(Token = "0x6025A63")]
		[Address(RVA = "0x209D6E0", Offset = "0x209C2E0", VA = "0x18209D6E0")]
		public static bool CheckStageStoryOpenFlag(long startTime)
		{
			return default(bool);
		}

		// Token: 0x06025A64 RID: 154212 RVA: 0x000C8AD8 File Offset: 0x000C6CD8
		[Token(Token = "0x6025A64")]
		[Address(RVA = "0x209D420", Offset = "0x209C020", VA = "0x18209D420")]
		public static bool CheckExist(string charId, HandbookUnlockParam unlockParam)
		{
			return default(bool);
		}

		// Token: 0x06025A65 RID: 154213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025A65")]
		[Address(RVA = "0x209E530", Offset = "0x209D130", VA = "0x18209E530")]
		public static List<StateCache> GetStateCache(HandBookJumpParam param)
		{
			return null;
		}

		// Token: 0x06025A66 RID: 154214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025A66")]
		[Address(RVA = "0x209E260", Offset = "0x209CE60", VA = "0x18209E260")]
		public static HandBookJumpParam GetJumpParam(UIPage page)
		{
			return null;
		}

		// Token: 0x06025A67 RID: 154215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A67")]
		[Address(RVA = "0x209D7C0", Offset = "0x209C3C0", VA = "0x18209D7C0")]
		public static void ClearJumpParam(UIPage page)
		{
		}

		// Token: 0x06025A68 RID: 154216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A68")]
		[Address(RVA = "0x209ECB0", Offset = "0x209D8B0", VA = "0x18209ECB0")]
		public static void StartStageBattle(HandBookUtil.BattleInputParam param)
		{
		}

		// Token: 0x04034E1A RID: 216602
		[Token(Token = "0x4034E1A")]
		[FieldOffset(Offset = "0x0")]
		public static string PAGE_NAME_PARAM;

		// Token: 0x04034E1B RID: 216603
		[Token(Token = "0x4034E1B")]
		[FieldOffset(Offset = "0x8")]
		public static string HANDBOOK_PARAM;

		// Token: 0x04034E1C RID: 216604
		[Token(Token = "0x4034E1C")]
		[FieldOffset(Offset = "0x10")]
		public static string CHAR_INFO_PARAM;

		// Token: 0x04034E1D RID: 216605
		[Token(Token = "0x4034E1D")]
		[FieldOffset(Offset = "0x18")]
		public static string CHAR_ID_PARAM;

		// Token: 0x04034E1E RID: 216606
		[Token(Token = "0x4034E1E")]
		[FieldOffset(Offset = "0x20")]
		public static string CHAR_LIST_PARAM;

		// Token: 0x04034E1F RID: 216607
		[Token(Token = "0x4034E1F")]
		[FieldOffset(Offset = "0x28")]
		public static string IS_BATTLE_PARAM;

		// Token: 0x04034E20 RID: 216608
		[Token(Token = "0x4034E20")]
		[FieldOffset(Offset = "0x30")]
		public static string IS_AVG_PARAM;

		// Token: 0x04034E21 RID: 216609
		[Token(Token = "0x4034E21")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GenDataBundleToHandBook;

		// Token: 0x04034E22 RID: 216610
		[Token(Token = "0x4034E22")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GenPageStackParamToHandBook;

		// Token: 0x04034E23 RID: 216611
		[Token(Token = "0x4034E23")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_SceneParamToHandBook;

		// Token: 0x04034E24 RID: 216612
		[Token(Token = "0x4034E24")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_CheckBanFlag;

		// Token: 0x04034E25 RID: 216613
		[Token(Token = "0x4034E25")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_HandleTopMenu;

		// Token: 0x04034E26 RID: 216614
		[Token(Token = "0x4034E26")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_CheckStageStoryOpenFlag;

		// Token: 0x04034E27 RID: 216615
		[Token(Token = "0x4034E27")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_CheckExist;

		// Token: 0x04034E28 RID: 216616
		[Token(Token = "0x4034E28")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_GetStateCache;

		// Token: 0x04034E29 RID: 216617
		[Token(Token = "0x4034E29")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GetJumpParam;

		// Token: 0x04034E2A RID: 216618
		[Token(Token = "0x4034E2A")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_ClearJumpParam;

		// Token: 0x04034E2B RID: 216619
		[Token(Token = "0x4034E2B")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_StartStageBattle;

		// Token: 0x0200666C RID: 26220
		[Token(Token = "0x200666C")]
		public struct DataParam
		{
			// Token: 0x04034E2C RID: 216620
			[Token(Token = "0x4034E2C")]
			[FieldOffset(Offset = "0x0")]
			public string pageName;

			// Token: 0x04034E2D RID: 216621
			[Token(Token = "0x4034E2D")]
			[FieldOffset(Offset = "0x8")]
			public List<int> charList;

			// Token: 0x04034E2E RID: 216622
			[Token(Token = "0x4034E2E")]
			[FieldOffset(Offset = "0x10")]
			public string charId;

			// Token: 0x04034E2F RID: 216623
			[Token(Token = "0x4034E2F")]
			[FieldOffset(Offset = "0x18")]
			public bool isBattle;

			// Token: 0x04034E30 RID: 216624
			[Token(Token = "0x4034E30")]
			[FieldOffset(Offset = "0x19")]
			public bool isStory;
		}

		// Token: 0x0200666D RID: 26221
		[Token(Token = "0x200666D")]
		public struct BattleInputParam
		{
			// Token: 0x04034E31 RID: 216625
			[Token(Token = "0x4034E31")]
			[FieldOffset(Offset = "0x0")]
			public HandBookStageViewModel handbookViewModel;

			// Token: 0x04034E32 RID: 216626
			[Token(Token = "0x4034E32")]
			[FieldOffset(Offset = "0x8")]
			public SkillGroupViewModel skillGroupModel;

			// Token: 0x04034E33 RID: 216627
			[Token(Token = "0x4034E33")]
			[FieldOffset(Offset = "0x10")]
			public List<int> charList;

			// Token: 0x04034E34 RID: 216628
			[Token(Token = "0x4034E34")]
			[FieldOffset(Offset = "0x18")]
			public int selectIdx;
		}
	}
}
