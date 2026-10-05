using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005CBD RID: 23741
	[Token(Token = "0x2005CBD")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class ClimbTowerConst
	{
		// Token: 0x0402F38C RID: 193420
		[Token(Token = "0x402F38C")]
		public const string CLIMB_TOWER_OFFER_DROP_ID = "exDrop_climb_tower";

		// Token: 0x0402F38D RID: 193421
		[Token(Token = "0x402F38D")]
		public const string TOWER_TRAINING_BKG_ID = "tower_tr";

		// Token: 0x0402F38E RID: 193422
		[Token(Token = "0x402F38E")]
		public const string DATA_DUNBLE_KEY_TOWER_ID = "CLIMB_TOWER_TOWER_ID";

		// Token: 0x0402F38F RID: 193423
		[Token(Token = "0x402F38F")]
		public const string DATA_BUNDLE_KEY_COORD = "CLIMB_TOWER_COORD";

		// Token: 0x0402F390 RID: 193424
		[Token(Token = "0x402F390")]
		public const string DATA_DUNBLE_KEY_FROM_BATTLE = "CLIMB_TOWER_FROM_BATTLE";

		// Token: 0x0402F391 RID: 193425
		[Token(Token = "0x402F391")]
		public const string TOWER_ICON_NAME_FORMAT = "icon_{0}";

		// Token: 0x0402F392 RID: 193426
		[Token(Token = "0x402F392")]
		public const string TOWER_BKG_NAME_FORMAT = "bkg_{0}";

		// Token: 0x0402F393 RID: 193427
		[Token(Token = "0x402F393")]
		public const string TOWER_BTN_NAME_FORMAT = "btn_{0}";

		// Token: 0x0402F394 RID: 193428
		[Token(Token = "0x402F394")]
		public const string NORMAL_MODE_POSTFIX = "_normal";

		// Token: 0x0402F395 RID: 193429
		[Token(Token = "0x402F395")]
		public const string HARD_MODE_POSTFIX = "_hard";

		// Token: 0x0402F396 RID: 193430
		[Token(Token = "0x402F396")]
		[FieldOffset(Offset = "0x0")]
		public static Color NORM_MODE_COL;

		// Token: 0x0402F397 RID: 193431
		[Token(Token = "0x402F397")]
		[FieldOffset(Offset = "0x10")]
		public static Color HARD_MODE_COL;

		// Token: 0x0402F398 RID: 193432
		[Token(Token = "0x402F398")]
		public const int NORMAL_TOTAL_STEP_COUNT = 3;

		// Token: 0x0402F399 RID: 193433
		[Token(Token = "0x402F399")]
		public const int HARD_TOTAL_STEP_COUNT = 4;

		// Token: 0x0402F39A RID: 193434
		[Token(Token = "0x402F39A")]
		public const int NORMAL_INIT_GOD_STEP_VAL = 1;

		// Token: 0x0402F39B RID: 193435
		[Token(Token = "0x402F39B")]
		public const int HARD_INIT_GOD_STEP_VAL = 2;

		// Token: 0x0402F39C RID: 193436
		[Token(Token = "0x402F39C")]
		public const int NORMAL_INIT_BUFF_STEP_VAL = 2;

		// Token: 0x0402F39D RID: 193437
		[Token(Token = "0x402F39D")]
		public const int HARD_INIT_BUFF_STEP_VAL = 3;

		// Token: 0x0402F39E RID: 193438
		[Token(Token = "0x402F39E")]
		public const int NORMAL_INIT_SQUAD_STEP_VAL = 3;

		// Token: 0x0402F39F RID: 193439
		[Token(Token = "0x402F39F")]
		public const int HARD_INIT_SQUAD_STEP_VAL = 4;

		// Token: 0x0402F3A0 RID: 193440
		[Token(Token = "0x402F3A0")]
		[FieldOffset(Offset = "0x20")]
		public static List<ProfessionCategory> PROFESSION_LIST;
	}
}
