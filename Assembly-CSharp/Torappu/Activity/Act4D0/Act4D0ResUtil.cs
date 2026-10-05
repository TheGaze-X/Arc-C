using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;

namespace Torappu.Activity.Act4D0
{
	// Token: 0x02007267 RID: 29287
	[Token(Token = "0x2007267")]
	public class Act4D0ResUtil
	{
		// Token: 0x060297E6 RID: 169958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60297E6")]
		[Address(RVA = "0x24DFC50", Offset = "0x24DE850", VA = "0x1824DFC50")]
		public static Sprite GetStoryImage(string storyKey, bool largeFlag)
		{
			return null;
		}

		// Token: 0x17006230 RID: 25136
		// (get) Token: 0x060297E7 RID: 169959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006230")]
		public static UIItemCard uiItemCard
		{
			[Token(Token = "0x60297E7")]
			[Address(RVA = "0x23336C0", Offset = "0x23322C0", VA = "0x1823336C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006231 RID: 25137
		// (get) Token: 0x060297E8 RID: 169960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006231")]
		public static CommonTopMenu commonTopMenu
		{
			[Token(Token = "0x60297E8")]
			[Address(RVA = "0x24C7840", Offset = "0x24C6440", VA = "0x1824C7840")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006232 RID: 25138
		// (get) Token: 0x060297E9 RID: 169961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006232")]
		public static PlayerActivity.PlayerAct4D0Activity playerInfo
		{
			[Token(Token = "0x60297E9")]
			[Address(RVA = "0x24E0260", Offset = "0x24DEE60", VA = "0x1824E0260")]
			get
			{
				return null;
			}
		}

		// Token: 0x060297EA RID: 169962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60297EA")]
		[Address(RVA = "0x24DFDB0", Offset = "0x24DE9B0", VA = "0x1824DFDB0")]
		public static Act4D0Data.StoryInfo GetStoryInfo(string storyId)
		{
			return null;
		}

		// Token: 0x17006233 RID: 25139
		// (get) Token: 0x060297EB RID: 169963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006233")]
		public static Act4D0Data act4d0Data
		{
			[Token(Token = "0x60297EB")]
			[Address(RVA = "0x24DFEA0", Offset = "0x24DEAA0", VA = "0x1824DFEA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006234 RID: 25140
		// (get) Token: 0x060297EC RID: 169964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006234")]
		public static ActivityTable.BasicData basicData
		{
			[Token(Token = "0x60297EC")]
			[Address(RVA = "0x24DFFF0", Offset = "0x24DEBF0", VA = "0x1824DFFF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060297ED RID: 169965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60297ED")]
		[Address(RVA = "0x24DFB50", Offset = "0x24DE750", VA = "0x1824DFB50")]
		public static PlayerActivity.PlayerAct4D0Activity GetAct4D0PlayerInfo(string actId)
		{
			return null;
		}

		// Token: 0x060297EE RID: 169966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60297EE")]
		[Address(RVA = "0x24DFAC0", Offset = "0x24DE6C0", VA = "0x1824DFAC0")]
		public static PlayerActivity.PlayerAct4D0Activity GetAct4D0PlayerInfoFromPlayerData(string actId, PlayerDataModel playerModel)
		{
			return null;
		}

		// Token: 0x17006235 RID: 25141
		// (get) Token: 0x060297EF RID: 169967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006235")]
		public static SpriteHub entrySpriteHub
		{
			[Token(Token = "0x60297EF")]
			[Address(RVA = "0x24E0090", Offset = "0x24DEC90", VA = "0x1824E0090")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006236 RID: 25142
		// (get) Token: 0x060297F0 RID: 169968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006236")]
		public static UIItemViewModel mileStoneToken
		{
			[Token(Token = "0x60297F0")]
			[Address(RVA = "0x24E01A0", Offset = "0x24DEDA0", VA = "0x1824E01A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060297F1 RID: 169969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60297F1")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act4D0ResUtil()
		{
		}

		// Token: 0x0403B4B2 RID: 242866
		[Token(Token = "0x403B4B2")]
		private const string HEAD_ICON = "{0}_small";

		// Token: 0x0403B4B3 RID: 242867
		[Token(Token = "0x403B4B3")]
		private const string LARGE_IMAGE = "{0}_large";

		// Token: 0x0403B4B4 RID: 242868
		[Token(Token = "0x403B4B4")]
		private const string HUB_PATH_FORMAT = "Activity/[UC]{0}/Prefabs/{0}_sprite";

		// Token: 0x0403B4B5 RID: 242869
		[Token(Token = "0x403B4B5")]
		[FieldOffset(Offset = "0x0")]
		public static float MILESTONE_HEIGHT;

		// Token: 0x0403B4B6 RID: 242870
		[Token(Token = "0x403B4B6")]
		[FieldOffset(Offset = "0x4")]
		public static float MILESTONE_DELTA_HEIGHT;

		// Token: 0x0403B4B7 RID: 242871
		[Token(Token = "0x403B4B7")]
		[FieldOffset(Offset = "0x8")]
		public static float MILESTONE_OFFSET;
	}
}
