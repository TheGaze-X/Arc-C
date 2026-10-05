using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;

namespace Torappu.Battle.Dialog
{
	// Token: 0x02002805 RID: 10245
	[Token(Token = "0x2002805")]
	public static class DialogConsts
	{
		// Token: 0x04013128 RID: 78120
		[Token(Token = "0x4013128")]
		public const float MIN_DIALOG_TRIGGER = 1f;

		// Token: 0x04013129 RID: 78121
		[Token(Token = "0x4013129")]
		[FieldOffset(Offset = "0x0")]
		public static string[] OPTIONS;

		// Token: 0x0401312A RID: 78122
		[Token(Token = "0x401312A")]
		[FieldOffset(Offset = "0x8")]
		public static string[] VALUES;

		// Token: 0x0401312B RID: 78123
		[Token(Token = "0x401312B")]
		public const string DIALUG = "dialog";

		// Token: 0x0401312C RID: 78124
		[Token(Token = "0x401312C")]
		public const string CHARACTER = "character";

		// Token: 0x0401312D RID: 78125
		[Token(Token = "0x401312D")]
		public const string END = "end";

		// Token: 0x0401312E RID: 78126
		[Token(Token = "0x401312E")]
		public const string HEADER = "header";

		// Token: 0x0401312F RID: 78127
		[Token(Token = "0x401312F")]
		public const string CHARACTER_COUNT = "charactercount";

		// Token: 0x04013130 RID: 78128
		[Token(Token = "0x4013130")]
		public const string SUMMON_ENEMY = "summonenemy";

		// Token: 0x04013131 RID: 78129
		[Token(Token = "0x4013131")]
		public const string SUMMON_TRAP = "summontrap";

		// Token: 0x04013132 RID: 78130
		[Token(Token = "0x4013132")]
		public const string MOVE = "move";

		// Token: 0x04013133 RID: 78131
		[Token(Token = "0x4013133")]
		public const string DELAY = "delay";

		// Token: 0x04013134 RID: 78132
		[Token(Token = "0x4013134")]
		public const string CAMERA_FOCUS_TO = "camerafocusto";

		// Token: 0x04013135 RID: 78133
		[Token(Token = "0x4013135")]
		public const string CAMERA_SCALE = "camerascale";

		// Token: 0x04013136 RID: 78134
		[Token(Token = "0x4013136")]
		public const string PLAY_ANIM = "playanim";

		// Token: 0x04013137 RID: 78135
		[Token(Token = "0x4013137")]
		public const string RESET_CAMERA = "resetcamera";

		// Token: 0x04013138 RID: 78136
		[Token(Token = "0x4013138")]
		public const string EXECUTE_ACTION_ARRAY = "executeactionarray";

		// Token: 0x04013139 RID: 78137
		[Token(Token = "0x4013139")]
		public const string VISIBLE_CONDITION = "visibleCondition";

		// Token: 0x0401313A RID: 78138
		[Token(Token = "0x401313A")]
		public const string SELECTABLE_CONDITION = "selectableCondition";

		// Token: 0x0401313B RID: 78139
		[Token(Token = "0x401313B")]
		public const string PREDICATE = "predicate";

		// Token: 0x0401313C RID: 78140
		[Token(Token = "0x401313C")]
		public const string WITHDRAW = "withdraw";

		// Token: 0x0401313D RID: 78141
		[Token(Token = "0x401313D")]
		public const string CREATE_EFFECT = "createeffect";

		// Token: 0x0401313E RID: 78142
		[Token(Token = "0x401313E")]
		public const string FINISH_EFFECT = "finisheffect";

		// Token: 0x0401313F RID: 78143
		[Token(Token = "0x401313F")]
		public const string DECISION = "decision";

		// Token: 0x04013140 RID: 78144
		[Token(Token = "0x4013140")]
		public const string CHANGE_SIGNAL = "changesignal";

		// Token: 0x04013141 RID: 78145
		[Token(Token = "0x4013141")]
		public const string EMOJI = "emoji";

		// Token: 0x04013142 RID: 78146
		[Token(Token = "0x4013142")]
		public const string CONDITION = "condition";

		// Token: 0x04013143 RID: 78147
		[Token(Token = "0x4013143")]
		public const string REFERENCES = "references";

		// Token: 0x04013144 RID: 78148
		[Token(Token = "0x4013144")]
		public const string TRUE = "true";

		// Token: 0x04013145 RID: 78149
		[Token(Token = "0x4013145")]
		public const string UI_OPERATION = "uioperation";

		// Token: 0x04013146 RID: 78150
		[Token(Token = "0x4013146")]
		public const string TIME_SCALE = "timescale";

		// Token: 0x04013147 RID: 78151
		[Token(Token = "0x4013147")]
		public const string CAMERA_SHAKE = "camerashake";

		// Token: 0x04013148 RID: 78152
		[Token(Token = "0x4013148")]
		public const string SET_POSITION = "setposition";

		// Token: 0x04013149 RID: 78153
		[Token(Token = "0x4013149")]
		public const Ease CAMERA_FOCUS_MOVE_EASE_TYPE = Ease.InOutQuad;

		// Token: 0x0401314A RID: 78154
		[Token(Token = "0x401314A")]
		public const Ease CAMERA_FOCUS_SCALE_EASE_TYPE = Ease.InOutQuad;

		// Token: 0x0401314B RID: 78155
		[Token(Token = "0x401314B")]
		public const float DEFAULT_CAMERA_ANIM_TIME = 0.5f;

		// Token: 0x0401314C RID: 78156
		[Token(Token = "0x401314C")]
		[FieldOffset(Offset = "0x10")]
		public static readonly Dictionary<string, float> CAMERA_FOCUS_SCALE_DIC;

		// Token: 0x0401314D RID: 78157
		[Token(Token = "0x401314D")]
		public const string ITEM_GE = "itemge";

		// Token: 0x0401314E RID: 78158
		[Token(Token = "0x401314E")]
		public const string ITEM_GT = "itemgt";

		// Token: 0x0401314F RID: 78159
		[Token(Token = "0x401314F")]
		public const string CONDITION_GT = "conditiongt";

		// Token: 0x04013150 RID: 78160
		[Token(Token = "0x4013150")]
		public const string CONDITION_GE = "conditionge";

		// Token: 0x04013151 RID: 78161
		[Token(Token = "0x4013151")]
		public const string ADD_ITEM = "additem";

		// Token: 0x04013152 RID: 78162
		[Token(Token = "0x4013152")]
		public const string SET_CONDITION_PROGRESS = "setConditionprogress";

		// Token: 0x04013153 RID: 78163
		[Token(Token = "0x4013153")]
		public const string SAVE = "save";

		// Token: 0x04013154 RID: 78164
		[Token(Token = "0x4013154")]
		public const string GACHA = "gacha";

		// Token: 0x04013155 RID: 78165
		[Token(Token = "0x4013155")]
		public const string FOG_IN_VIEW = "foginview";

		// Token: 0x04013156 RID: 78166
		[Token(Token = "0x4013156")]
		public const string FOG_NOT_IN_VIEW = "fognotinview";

		// Token: 0x04013157 RID: 78167
		[Token(Token = "0x4013157")]
		public const string CHECK_RIFT = "checkriftordered";

		// Token: 0x04013158 RID: 78168
		[Token(Token = "0x4013158")]
		public const string CHECK_RIFT_ID_IS = "checkriftidis";

		// Token: 0x04013159 RID: 78169
		[Token(Token = "0x4013159")]
		public const string CHECK_CAN_ORDER_RANDOM_RIFT = "checkcanorderrandomrift";

		// Token: 0x0401315A RID: 78170
		[Token(Token = "0x401315A")]
		public const string ORDER_RIFT = "orderrift";

		// Token: 0x0401315B RID: 78171
		[Token(Token = "0x401315B")]
		public const string CHECK_FAVOR = "checkfavor";

		// Token: 0x0401315C RID: 78172
		[Token(Token = "0x401315C")]
		public const string ADD_FAVOR = "addfavor";
	}
}
