using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Atlas;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004EBD RID: 20157
	[Token(Token = "0x2004EBD")]
	public static class FifthAnnivExploreUtil
	{
		// Token: 0x0601E141 RID: 123201 RVA: 0x000AD670 File Offset: 0x000AB870
		[Token(Token = "0x601E141")]
		[Address(RVA = "0x17C34F0", Offset = "0x17C20F0", VA = "0x1817C34F0")]
		public static bool EnsurePlayerExplore()
		{
			return default(bool);
		}

		// Token: 0x0601E142 RID: 123202 RVA: 0x000AD688 File Offset: 0x000AB888
		[Token(Token = "0x601E142")]
		[Address(RVA = "0x17C3470", Offset = "0x17C2070", VA = "0x1817C3470")]
		public static bool EnsurePlayerExploreIsOpen()
		{
			return default(bool);
		}

		// Token: 0x0601E143 RID: 123203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E143")]
		[Address(RVA = "0x17C40C0", Offset = "0x17C2CC0", VA = "0x1817C40C0")]
		public static FifthAnnivExploreMapViewConfig LoadFifthAnnivExploreMapViewConfig(ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x0601E144 RID: 123204 RVA: 0x000AD6A0 File Offset: 0x000AB8A0
		[Token(Token = "0x601E144")]
		[Address(RVA = "0x17C3AB0", Offset = "0x17C26B0", VA = "0x1817C3AB0")]
		public static int GetTotalIndexByStageAndIndex(string stageId, int stageIndex)
		{
			return 0;
		}

		// Token: 0x0601E145 RID: 123205 RVA: 0x000AD6B8 File Offset: 0x000AB8B8
		[Token(Token = "0x601E145")]
		[Address(RVA = "0x17C3930", Offset = "0x17C2530", VA = "0x1817C3930")]
		public static int GetStageTotalNodeCount(int stageNum)
		{
			return 0;
		}

		// Token: 0x0601E146 RID: 123206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E146")]
		[Address(RVA = "0x17C3820", Offset = "0x17C2420", VA = "0x1817C3820")]
		public static string GetLastPassTarget()
		{
			return null;
		}

		// Token: 0x0601E147 RID: 123207 RVA: 0x000AD6D0 File Offset: 0x000AB8D0
		[Token(Token = "0x601E147")]
		[Address(RVA = "0x17C3780", Offset = "0x17C2380", VA = "0x1817C3780")]
		public static int GetCurrAbility(int abilityIdx)
		{
			return 0;
		}

		// Token: 0x0601E148 RID: 123208 RVA: 0x000AD6E8 File Offset: 0x000AB8E8
		[Token(Token = "0x601E148")]
		[Address(RVA = "0x17C3DD0", Offset = "0x17C29D0", VA = "0x1817C3DD0")]
		public static bool IsCurrAbilitiesAllSatisfy(Dictionary<string, int> abilityDict)
		{
			return default(bool);
		}

		// Token: 0x0601E149 RID: 123209 RVA: 0x000AD700 File Offset: 0x000AB900
		[Token(Token = "0x601E149")]
		[Address(RVA = "0x17C3F80", Offset = "0x17C2B80", VA = "0x1817C3F80")]
		public static bool IsRequireEventComplete(string eventId)
		{
			return default(bool);
		}

		// Token: 0x0601E14A RID: 123210 RVA: 0x000AD718 File Offset: 0x000AB918
		[Token(Token = "0x601E14A")]
		[Address(RVA = "0x17C3770", Offset = "0x17C2370", VA = "0x1817C3770")]
		public static int GetAbilityValueFromDict(Dictionary<string, int> abilityDict, int abilityIndex)
		{
			return 0;
		}

		// Token: 0x0601E14B RID: 123211 RVA: 0x000AD730 File Offset: 0x000AB930
		[Token(Token = "0x601E14B")]
		[Address(RVA = "0x17C44B0", Offset = "0x17C30B0", VA = "0x1817C44B0")]
		private static int _GetAbilityValueFromDict(Dictionary<string, int> abilityDict, int abilityIndex)
		{
			return 0;
		}

		// Token: 0x0601E14C RID: 123212 RVA: 0x000AD748 File Offset: 0x000AB948
		[Token(Token = "0x601E14C")]
		[Address(RVA = "0x17C3580", Offset = "0x17C2180", VA = "0x1817C3580")]
		public static SpriteRenderData GetAbilitySprite(UIAtlasObject atlasObject, int abilityIndex)
		{
			return default(SpriteRenderData);
		}

		// Token: 0x0601E14D RID: 123213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E14D")]
		[Address(RVA = "0x17C41E0", Offset = "0x17C2DE0", VA = "0x1817C41E0")]
		public static void RestPageStackToExplorePage()
		{
		}

		// Token: 0x0601E14E RID: 123214 RVA: 0x000AD760 File Offset: 0x000AB960
		[Token(Token = "0x601E14E")]
		[Address(RVA = "0x17C3BD0", Offset = "0x17C27D0", VA = "0x1817C3BD0")]
		public static bool HasMissionRewardToCollect()
		{
			return default(bool);
		}
	}
}
