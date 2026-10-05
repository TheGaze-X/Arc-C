using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle;
using Torappu.UI;
using Torappu.UI.Squad;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act5D1
{
	// Token: 0x02007230 RID: 29232
	[Token(Token = "0x2007230")]
	public class RuneBattleFinishStateBean : MonoBehaviour, IStateBean, IHotfixable
	{
		// Token: 0x060296DB RID: 169691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60296DB")]
		[Address(RVA = "0x24D58A0", Offset = "0x24D44A0", VA = "0x1824D58A0")]
		public void InitInfo()
		{
		}

		// Token: 0x060296DC RID: 169692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60296DC")]
		[Address(RVA = "0x24D60D0", Offset = "0x24D4CD0", VA = "0x1824D60D0")]
		public RuneBattleFinishStateBean()
		{
		}

		// Token: 0x0403B2C6 RID: 242374
		[Token(Token = "0x403B2C6")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public SquadItemStruct[] squadList;

		// Token: 0x0403B2C7 RID: 242375
		[Token(Token = "0x403B2C7")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public SquadItemStruct assistSquad;

		// Token: 0x0403B2C8 RID: 242376
		[Token(Token = "0x403B2C8")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public List<RuneTable.PackedRuneData> runeList;

		// Token: 0x0403B2C9 RID: 242377
		[Token(Token = "0x403B2C9")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		public BattleStageInfo battleStage;

		// Token: 0x0403B2CA RID: 242378
		[Token(Token = "0x403B2CA")]
		[FieldOffset(Offset = "0xA8")]
		[NonSerialized]
		public CharUISkinStruct randomIllust;

		// Token: 0x0403B2CB RID: 242379
		[Token(Token = "0x403B2CB")]
		[FieldOffset(Offset = "0xC0")]
		[NonSerialized]
		public int leftHp;

		// Token: 0x0403B2CC RID: 242380
		[Token(Token = "0x403B2CC")]
		[FieldOffset(Offset = "0xC4")]
		[NonSerialized]
		public bool isNewRecord;

		// Token: 0x0403B2CD RID: 242381
		[Token(Token = "0x403B2CD")]
		[FieldOffset(Offset = "0xC8")]
		[NonSerialized]
		public int runeValue;

		// Token: 0x0403B2CE RID: 242382
		[Token(Token = "0x403B2CE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitInfo;

		// Token: 0x0403B2CF RID: 242383
		[Token(Token = "0x403B2CF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
