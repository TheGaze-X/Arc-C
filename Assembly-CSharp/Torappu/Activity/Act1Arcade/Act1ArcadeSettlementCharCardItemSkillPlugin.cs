using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x0200796D RID: 31085
	[Token(Token = "0x200796D")]
	public class Act1ArcadeSettlementCharCardItemSkillPlugin : Act1ArcadeSettlementCharCardItemAdvanceInfoPlugin
	{
		// Token: 0x0602B9A9 RID: 178601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B9A9")]
		[Address(RVA = "0x277F6D0", Offset = "0x277E2D0", VA = "0x18277F6D0", Slot = "4")]
		public override void OnRender(bool isAssist, CharacterCardViewModel cardViewModel)
		{
		}

		// Token: 0x0602B9AA RID: 178602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B9AA")]
		[Address(RVA = "0x277F970", Offset = "0x277E570", VA = "0x18277F970")]
		public Act1ArcadeSettlementCharCardItemSkillPlugin()
		{
		}

		// Token: 0x0403F13D RID: 258365
		[Token(Token = "0x403F13D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelNoSkill;

		// Token: 0x0403F13E RID: 258366
		[Token(Token = "0x403F13E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelSkill;

		// Token: 0x0403F13F RID: 258367
		[Token(Token = "0x403F13F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgSkill;

		// Token: 0x0403F140 RID: 258368
		[Token(Token = "0x403F140")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textSkillLevel;

		// Token: 0x0403F141 RID: 258369
		[Token(Token = "0x403F141")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imgSkillSpecializeLv;

		// Token: 0x0403F142 RID: 258370
		[Token(Token = "0x403F142")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0403F143 RID: 258371
		[Token(Token = "0x403F143")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
