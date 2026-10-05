using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066EA RID: 26346
	[Token(Token = "0x20066EA")]
	public static class HandBookV2Util
	{
		// Token: 0x06025CF9 RID: 154873 RVA: 0x000C91B0 File Offset: 0x000C73B0
		[Token(Token = "0x6025CF9")]
		[Address(RVA = "0x20C8F50", Offset = "0x20C7B50", VA = "0x1820C8F50")]
		public static bool CheckIsNPC(string charId)
		{
			return default(bool);
		}

		// Token: 0x06025CFA RID: 154874 RVA: 0x000C91C8 File Offset: 0x000C73C8
		[Token(Token = "0x6025CFA")]
		[Address(RVA = "0x20CAA50", Offset = "0x20C9650", VA = "0x1820CAA50")]
		public static HexagonDirection GetOppDirect(HexagonDirection direction)
		{
			return HexagonDirection.TOP_LEFT;
		}

		// Token: 0x06025CFB RID: 154875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025CFB")]
		[Address(RVA = "0x20CA0E0", Offset = "0x20C8CE0", VA = "0x1820CA0E0")]
		public static HandBookV2GroupForceFavorData GetGroupForceFavorData(UIPage page, string forceId)
		{
			return null;
		}

		// Token: 0x06025CFC RID: 154876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025CFC")]
		[Address(RVA = "0x20CA4D0", Offset = "0x20C90D0", VA = "0x1820CA4D0")]
		public static string GetGroupIdByCharId(UIPage page, string charId)
		{
			return null;
		}

		// Token: 0x06025CFD RID: 154877 RVA: 0x000C91E0 File Offset: 0x000C73E0
		[Token(Token = "0x6025CFD")]
		[Address(RVA = "0x20C9F50", Offset = "0x20C8B50", VA = "0x1820C9F50")]
		public static Vector3 GetConnectPos(Vector3 initPos, int totalCount, int index)
		{
			return default(Vector3);
		}

		// Token: 0x06025CFE RID: 154878 RVA: 0x000C91F8 File Offset: 0x000C73F8
		[Token(Token = "0x6025CFE")]
		[Address(RVA = "0x20BA020", Offset = "0x20B8C20", VA = "0x1820BA020")]
		public static Vector2 GetConnectHexagonDirectionPos(HexagonDirection direction)
		{
			return default(Vector2);
		}

		// Token: 0x06025CFF RID: 154879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025CFF")]
		[Address(RVA = "0x20CAAB0", Offset = "0x20C96B0", VA = "0x1820CAAB0")]
		public static HandBookV2MapGroupView LoadGroupView()
		{
			return null;
		}

		// Token: 0x06025D00 RID: 154880 RVA: 0x000C9210 File Offset: 0x000C7410
		[Token(Token = "0x6025D00")]
		[Address(RVA = "0x20C8FC0", Offset = "0x20C7BC0", VA = "0x1820C8FC0")]
		public static bool CheckLineAvail(HandBookV2GroupCharViewModel charViewModel, HandBookV2GroupCharViewModel charViewModel2)
		{
			return default(bool);
		}

		// Token: 0x06025D01 RID: 154881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025D01")]
		[Address(RVA = "0x20C9950", Offset = "0x20C8550", VA = "0x1820C9950")]
		public static HandBookV2GroupCharViewModel GetCharViewModelWithOutLine(UIPage page, string charId)
		{
			return null;
		}

		// Token: 0x06025D02 RID: 154882 RVA: 0x000C9228 File Offset: 0x000C7428
		[Token(Token = "0x6025D02")]
		[Address(RVA = "0x20C8E20", Offset = "0x20C7A20", VA = "0x1820C8E20")]
		public static bool CheckCharExist(string charId)
		{
			return default(bool);
		}

		// Token: 0x06025D03 RID: 154883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D03")]
		[Address(RVA = "0x20CABB0", Offset = "0x20C97B0", VA = "0x1820CABB0")]
		public static void TraverseCharForceId(string charId, CharacterData charDBData, List<string> resultList)
		{
		}

		// Token: 0x06025D04 RID: 154884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D04")]
		[Address(RVA = "0x20C94B0", Offset = "0x20C80B0", VA = "0x1820C94B0")]
		public static void FindViewModelLineInfo(UIPage page, HandBookV2GroupCharViewModel viewModel)
		{
		}

		// Token: 0x06025D05 RID: 154885 RVA: 0x000C9240 File Offset: 0x000C7440
		[Token(Token = "0x6025D05")]
		[Address(RVA = "0x20C93B0", Offset = "0x20C7FB0", VA = "0x1820C93B0")]
		public static bool CheckNPCExist(DataUnlockType type, string param)
		{
			return default(bool);
		}

		// Token: 0x06025D06 RID: 154886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025D06")]
		[Address(RVA = "0x20CAB20", Offset = "0x20C9720", VA = "0x1820CAB20")]
		public static NPCData LoadNPCDataOrNull(string npcId)
		{
			return null;
		}

		// Token: 0x06025D07 RID: 154887 RVA: 0x000C9258 File Offset: 0x000C7458
		[Token(Token = "0x6025D07")]
		[Address(RVA = "0x20C9030", Offset = "0x20C7C30", VA = "0x1820C9030")]
		public static bool CheckNPCAvail(NPCData npcData)
		{
			return default(bool);
		}

		// Token: 0x06025D08 RID: 154888 RVA: 0x000C9270 File Offset: 0x000C7470
		[Token(Token = "0x6025D08")]
		[Address(RVA = "0x20C9180", Offset = "0x20C7D80", VA = "0x1820C9180")]
		public static bool CheckNPCExist(NPCData npcData)
		{
			return default(bool);
		}

		// Token: 0x04035277 RID: 217719
		[Token(Token = "0x4035277")]
		public const float INIT_SCALE = 1.2f;

		// Token: 0x04035278 RID: 217720
		[Token(Token = "0x4035278")]
		public const float INIT_FADE_SCALE = 1f;

		// Token: 0x04035279 RID: 217721
		[Token(Token = "0x4035279")]
		public const float INIT_DURATION = 0.8f;

		// Token: 0x0403527A RID: 217722
		[Token(Token = "0x403527A")]
		public const int FAVOR_POINT_1 = 60;

		// Token: 0x0403527B RID: 217723
		[Token(Token = "0x403527B")]
		public const int FAVOR_POINT_2 = 100;

		// Token: 0x0403527C RID: 217724
		[Token(Token = "0x403527C")]
		public const int FAVOR_POINT_3 = 160;

		// Token: 0x0403527D RID: 217725
		[Token(Token = "0x403527D")]
		public const int FAVOR_MAX = 200;

		// Token: 0x0403527E RID: 217726
		[Token(Token = "0x403527E")]
		public const float FORCE_HEX_WIDTH = 50f;

		// Token: 0x0403527F RID: 217727
		[Token(Token = "0x403527F")]
		public const float FORCE_HEX_HEIGHT = 43.3f;

		// Token: 0x04035280 RID: 217728
		[Token(Token = "0x4035280")]
		public const string UNKOWN_NAME = "???";

		// Token: 0x04035281 RID: 217729
		[Token(Token = "0x4035281")]
		public const float SP_LINE_WIDTH = 26f;

		// Token: 0x04035282 RID: 217730
		[Token(Token = "0x4035282")]
		public const float COMMON_LINE_WIDTH = 23f;

		// Token: 0x04035283 RID: 217731
		[Token(Token = "0x4035283")]
		public const float CORO_FADE_TIME = 0.23f;

		// Token: 0x04035284 RID: 217732
		[Token(Token = "0x4035284")]
		public const float ADD_SIZE_X = 1400f;

		// Token: 0x04035285 RID: 217733
		[Token(Token = "0x4035285")]
		public const float ADD_SIZE_Y = 800f;

		// Token: 0x04035286 RID: 217734
		[Token(Token = "0x4035286")]
		[FieldOffset(Offset = "0x0")]
		public static string TEMPLATE_ID_CONST;
	}
}
