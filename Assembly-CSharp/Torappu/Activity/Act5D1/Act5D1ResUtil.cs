using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle;
using Torappu.UI;
using UnityEngine;

namespace Torappu.Activity.Act5D1
{
	// Token: 0x0200720F RID: 29199
	[Token(Token = "0x200720F")]
	public class Act5D1ResUtil
	{
		// Token: 0x1700620B RID: 25099
		// (get) Token: 0x06029652 RID: 169554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700620B")]
		public static PlayerActivity.PlayerAct5D1Activity playerInfo
		{
			[Token(Token = "0x6029652")]
			[Address(RVA = "0x24C7920", Offset = "0x24C6520", VA = "0x1824C7920")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700620C RID: 25100
		// (get) Token: 0x06029653 RID: 169555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700620C")]
		public static List<MissionGroup> missionGroup
		{
			[Token(Token = "0x6029653")]
			[Address(RVA = "0x24C78C0", Offset = "0x24C64C0", VA = "0x1824C78C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700620D RID: 25101
		// (get) Token: 0x06029654 RID: 169556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700620D")]
		public static List<MissionData> missionData
		{
			[Token(Token = "0x6029654")]
			[Address(RVA = "0x24C7860", Offset = "0x24C6460", VA = "0x1824C7860")]
			get
			{
				return null;
			}
		}

		// Token: 0x06029655 RID: 169557 RVA: 0x000D58E8 File Offset: 0x000D3AE8
		[Token(Token = "0x6029655")]
		[Address(RVA = "0x24C7390", Offset = "0x24C5F90", VA = "0x1824C7390")]
		public static bool IsPermanent(MissionGroup grp)
		{
			return default(bool);
		}

		// Token: 0x06029656 RID: 169558 RVA: 0x000D5900 File Offset: 0x000D3B00
		[Token(Token = "0x6029656")]
		[Address(RVA = "0x24C73C0", Offset = "0x24C5FC0", VA = "0x1824C73C0")]
		public static bool IsRuneMission(MissionData mission)
		{
			return default(bool);
		}

		// Token: 0x06029657 RID: 169559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029657")]
		[Address(RVA = "0x24C6DF0", Offset = "0x24C59F0", VA = "0x1824C6DF0")]
		public static MissionData GetMissionData(string missionId)
		{
			return null;
		}

		// Token: 0x06029658 RID: 169560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029658")]
		[Address(RVA = "0x24C6410", Offset = "0x24C5010", VA = "0x1824C6410")]
		public static void CheckActiveAndRun(Action action)
		{
		}

		// Token: 0x1700620E RID: 25102
		// (get) Token: 0x06029659 RID: 169561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700620E")]
		public static Act5D1Data act5d1Data
		{
			[Token(Token = "0x6029659")]
			[Address(RVA = "0x24C7540", Offset = "0x24C6140", VA = "0x1824C7540")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700620F RID: 25103
		// (get) Token: 0x0602965A RID: 169562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700620F")]
		public static ActivityTable.BasicData basicData
		{
			[Token(Token = "0x602965A")]
			[Address(RVA = "0x24C77A0", Offset = "0x24C63A0", VA = "0x1824C77A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602965B RID: 169563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602965B")]
		[Address(RVA = "0x24C66C0", Offset = "0x24C52C0", VA = "0x1824C66C0")]
		public static PlayerActivity.PlayerAct5D1Activity GetAct5D1PlayerInfo(string actId)
		{
			return null;
		}

		// Token: 0x0602965C RID: 169564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602965C")]
		[Address(RVA = "0x24C6630", Offset = "0x24C5230", VA = "0x1824C6630")]
		public static PlayerActivity.PlayerAct5D1Activity GetAct5D1PlayerInfoFromPlayerData(string actId, PlayerDataModel playerModel)
		{
			return null;
		}

		// Token: 0x0602965D RID: 169565 RVA: 0x000D5918 File Offset: 0x000D3B18
		[Token(Token = "0x602965D")]
		[Address(RVA = "0x24C6A20", Offset = "0x24C5620", VA = "0x1824C6A20")]
		public static int GetGoodBoughtCnt(string goodId)
		{
			return 0;
		}

		// Token: 0x0602965E RID: 169566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602965E")]
		[Address(RVA = "0x24C6F70", Offset = "0x24C5B70", VA = "0x1824C6F70")]
		public static PlayerActivity.PlayerAct5D1Activity.PlayerAct5D1Shop.ProgressInfo GetProgressGoodInfo(string prgId)
		{
			return null;
		}

		// Token: 0x17006210 RID: 25104
		// (get) Token: 0x0602965F RID: 169567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006210")]
		public static CommonTopMenu commonTopMenu
		{
			[Token(Token = "0x602965F")]
			[Address(RVA = "0x24C7840", Offset = "0x24C6440", VA = "0x1824C7840")]
			get
			{
				return null;
			}
		}

		// Token: 0x06029660 RID: 169568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029660")]
		[Address(RVA = "0x24C6DE0", Offset = "0x24C59E0", VA = "0x1824C6DE0")]
		public static Sprite GetMapImg(string stageId, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x06029661 RID: 169569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029661")]
		[Address(RVA = "0x24C68F0", Offset = "0x24C54F0", VA = "0x1824C68F0")]
		public static Sprite GetEntryImg(string stageId)
		{
			return null;
		}

		// Token: 0x06029662 RID: 169570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029662")]
		[Address(RVA = "0x24C7250", Offset = "0x24C5E50", VA = "0x1824C7250")]
		public static Act5D1Data.RuneStageData GetStageInfo(string stageId)
		{
			return null;
		}

		// Token: 0x06029663 RID: 169571 RVA: 0x000D5930 File Offset: 0x000D3B30
		[Token(Token = "0x6029663")]
		[Address(RVA = "0x24C64A0", Offset = "0x24C50A0", VA = "0x1824C64A0")]
		public static BattleStageInfo GenerateBattleStageInfo(string stageId)
		{
			return default(BattleStageInfo);
		}

		// Token: 0x06029664 RID: 169572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029664")]
		[Address(RVA = "0x24C6CB0", Offset = "0x24C58B0", VA = "0x1824C6CB0")]
		public static Sprite GetIconImg(string stageId)
		{
			return null;
		}

		// Token: 0x17006211 RID: 25105
		// (get) Token: 0x06029665 RID: 169573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006211")]
		public static SpriteHub act5d1SpriteHub
		{
			[Token(Token = "0x6029665")]
			[Address(RVA = "0x24C76E0", Offset = "0x24C62E0", VA = "0x1824C76E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06029666 RID: 169574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029666")]
		[Address(RVA = "0x24C6B80", Offset = "0x24C5780", VA = "0x1824C6B80")]
		public static Sprite GetIconImgForBattleFinish(string stageId)
		{
			return null;
		}

		// Token: 0x06029667 RID: 169575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029667")]
		[Address(RVA = "0x24C67C0", Offset = "0x24C53C0", VA = "0x1824C67C0")]
		public static Sprite GetEntryImgForBattleFinish(string stageId)
		{
			return null;
		}

		// Token: 0x17006212 RID: 25106
		// (get) Token: 0x06029668 RID: 169576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006212")]
		public static SpriteHub act5d1SpriteHubForBattleFinish
		{
			[Token(Token = "0x6029668")]
			[Address(RVA = "0x24C75F0", Offset = "0x24C61F0", VA = "0x1824C75F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06029669 RID: 169577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029669")]
		[Address(RVA = "0x24C70D0", Offset = "0x24C5CD0", VA = "0x1824C70D0")]
		public static Act5D1Data.RuneStageData GetStageInfoFromBattleFinish(string stageId)
		{
			return null;
		}

		// Token: 0x0602966A RID: 169578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602966A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act5D1ResUtil()
		{
		}

		// Token: 0x0403B20E RID: 242190
		[Token(Token = "0x403B20E")]
		[FieldOffset(Offset = "0x0")]
		public static string CHARACTER_BATTLE_RESULT_ASSIST;

		// Token: 0x0403B20F RID: 242191
		[Token(Token = "0x403B20F")]
		[FieldOffset(Offset = "0x8")]
		public static string CHARACTER_BATTLE_RESULT_NONE;

		// Token: 0x0403B210 RID: 242192
		[Token(Token = "0x403B210")]
		[FieldOffset(Offset = "0x10")]
		public static string CHARACTER_BATTLE_RESULT_BG;

		// Token: 0x0403B211 RID: 242193
		[Token(Token = "0x403B211")]
		private const string HUB_PATH = "Activity/[UC]act5D1/Prefabs/act_5d1_sprite";

		// Token: 0x0403B212 RID: 242194
		[Token(Token = "0x403B212")]
		private const string ENTRY_IMG_PATH = "{0}_entry";

		// Token: 0x0403B213 RID: 242195
		[Token(Token = "0x403B213")]
		private const string STAGE_GROUP_ICON_PATH = "{0}_icon";

		// Token: 0x0403B214 RID: 242196
		[Token(Token = "0x403B214")]
		private const string MAP_PREVIEW = "{0}_map";

		// Token: 0x0403B215 RID: 242197
		[Token(Token = "0x403B215")]
		public const string ACT5D1_ID = "act5d1";
	}
}
