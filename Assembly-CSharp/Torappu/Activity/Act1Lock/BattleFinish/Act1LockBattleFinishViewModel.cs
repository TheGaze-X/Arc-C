using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.BattleFinish;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1Lock.BattleFinish
{
	// Token: 0x020078EE RID: 30958
	[Token(Token = "0x20078EE")]
	public class Act1LockBattleFinishViewModel : IHotfixable
	{
		// Token: 0x0602B6A7 RID: 177831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B6A7")]
		[Address(RVA = "0x2755CE0", Offset = "0x27548E0", VA = "0x182755CE0")]
		public void LoadData(CommonFinishBattleResponse response)
		{
		}

		// Token: 0x0602B6A8 RID: 177832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B6A8")]
		[Address(RVA = "0x2756200", Offset = "0x2754E00", VA = "0x182756200")]
		private void _LoadBattleInfo()
		{
		}

		// Token: 0x0602B6A9 RID: 177833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B6A9")]
		[Address(RVA = "0x2756960", Offset = "0x2755560", VA = "0x182756960")]
		private void _LoadExpInfo()
		{
		}

		// Token: 0x0602B6AA RID: 177834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B6AA")]
		[Address(RVA = "0x2756610", Offset = "0x2755210", VA = "0x182756610")]
		private void _LoadDropInfo()
		{
		}

		// Token: 0x0602B6AB RID: 177835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B6AB")]
		[Address(RVA = "0x2756B10", Offset = "0x2755710", VA = "0x182756B10")]
		private void _LoadFinalStagePointModel()
		{
		}

		// Token: 0x0602B6AC RID: 177836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B6AC")]
		[Address(RVA = "0x27570A0", Offset = "0x2755CA0", VA = "0x1827570A0")]
		private void _LoadInterlockStageDefendModel()
		{
		}

		// Token: 0x0602B6AD RID: 177837 RVA: 0x000DBD38 File Offset: 0x000D9F38
		[Token(Token = "0x602B6AD")]
		[Address(RVA = "0x27560D0", Offset = "0x2754CD0", VA = "0x1827560D0")]
		private int _CalcAddExp()
		{
			return 0;
		}

		// Token: 0x0602B6AE RID: 177838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B6AE")]
		[Address(RVA = "0x2757D70", Offset = "0x2756970", VA = "0x182757D70")]
		public Act1LockBattleFinishViewModel()
		{
		}

		// Token: 0x0403EC74 RID: 257140
		[Token(Token = "0x403EC74")]
		[FieldOffset(Offset = "0x10")]
		public bool isValid;

		// Token: 0x0403EC75 RID: 257141
		[Token(Token = "0x403EC75")]
		[FieldOffset(Offset = "0x18")]
		public string activityId;

		// Token: 0x0403EC76 RID: 257142
		[Token(Token = "0x403EC76")]
		[FieldOffset(Offset = "0x20")]
		public string stageId;

		// Token: 0x0403EC77 RID: 257143
		[Token(Token = "0x403EC77")]
		[FieldOffset(Offset = "0x28")]
		public Sprite spriteBlurBkg;

		// Token: 0x0403EC78 RID: 257144
		[Token(Token = "0x403EC78")]
		[FieldOffset(Offset = "0x30")]
		public BattleInfoViewModel battleInfoModel;

		// Token: 0x0403EC79 RID: 257145
		[Token(Token = "0x403EC79")]
		[FieldOffset(Offset = "0x38")]
		public UIExpBarController.ControlModel expBarControlModel;

		// Token: 0x0403EC7A RID: 257146
		[Token(Token = "0x403EC7A")]
		[FieldOffset(Offset = "0x40")]
		public int curLevel;

		// Token: 0x0403EC7B RID: 257147
		[Token(Token = "0x403EC7B")]
		[FieldOffset(Offset = "0x44")]
		public int curExp;

		// Token: 0x0403EC7C RID: 257148
		[Token(Token = "0x403EC7C")]
		[FieldOffset(Offset = "0x48")]
		public bool needShowLvlUp;

		// Token: 0x0403EC7D RID: 257149
		[Token(Token = "0x403EC7D")]
		[FieldOffset(Offset = "0x50")]
		public DropInfoGroupViewModel dropInfoModel;

		// Token: 0x0403EC7E RID: 257150
		[Token(Token = "0x403EC7E")]
		[FieldOffset(Offset = "0x58")]
		public bool hasDrop;

		// Token: 0x0403EC7F RID: 257151
		[Token(Token = "0x403EC7F")]
		[FieldOffset(Offset = "0x60")]
		public FinalStagePointModel finalStagePointModel;

		// Token: 0x0403EC80 RID: 257152
		[Token(Token = "0x403EC80")]
		[FieldOffset(Offset = "0x68")]
		public InterlockStageDefendModel interlockStageDefendModel;

		// Token: 0x0403EC81 RID: 257153
		[Token(Token = "0x403EC81")]
		[FieldOffset(Offset = "0x70")]
		private CommonFinishBattleResponse m_cachedResponse;

		// Token: 0x0403EC82 RID: 257154
		[Token(Token = "0x403EC82")]
		[FieldOffset(Offset = "0x78")]
		private ActivityInterlockData m_cachedActData;

		// Token: 0x0403EC83 RID: 257155
		[Token(Token = "0x403EC83")]
		[FieldOffset(Offset = "0x80")]
		private PlayerActivity.PlayerInterlockActivity m_cachedPlayerActData;

		// Token: 0x0403EC84 RID: 257156
		[Token(Token = "0x403EC84")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403EC85 RID: 257157
		[Token(Token = "0x403EC85")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadBattleInfo;

		// Token: 0x0403EC86 RID: 257158
		[Token(Token = "0x403EC86")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LoadExpInfo;

		// Token: 0x0403EC87 RID: 257159
		[Token(Token = "0x403EC87")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__LoadDropInfo;

		// Token: 0x0403EC88 RID: 257160
		[Token(Token = "0x403EC88")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__LoadFinalStagePointModel;

		// Token: 0x0403EC89 RID: 257161
		[Token(Token = "0x403EC89")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__LoadInterlockStageDefendModel;

		// Token: 0x0403EC8A RID: 257162
		[Token(Token = "0x403EC8A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CalcAddExp;

		// Token: 0x0403EC8B RID: 257163
		[Token(Token = "0x403EC8B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
