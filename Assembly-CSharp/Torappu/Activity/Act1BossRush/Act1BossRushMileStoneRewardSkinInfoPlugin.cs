using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1BossRush
{
	// Token: 0x020070C0 RID: 28864
	[Token(Token = "0x20070C0")]
	public class Act1BossRushMileStoneRewardSkinInfoPlugin : Act1BossRushMileStoneRewardInfoPlugin
	{
		// Token: 0x06029059 RID: 168025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029059")]
		[Address(RVA = "0x2468230", Offset = "0x2466E30", VA = "0x182468230", Slot = "4")]
		public override void Render(Act1BossRushMileStoneViewModel model)
		{
		}

		// Token: 0x0602905A RID: 168026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602905A")]
		[Address(RVA = "0x24683F0", Offset = "0x2466FF0", VA = "0x1824683F0")]
		public Act1BossRushMileStoneRewardSkinInfoPlugin()
		{
		}

		// Token: 0x0403A8E8 RID: 239848
		[Token(Token = "0x403A8E8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textRewardSkinName;

		// Token: 0x0403A8E9 RID: 239849
		[Token(Token = "0x403A8E9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textRewardCharName;

		// Token: 0x0403A8EA RID: 239850
		[Token(Token = "0x403A8EA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textMainItemDesc;

		// Token: 0x0403A8EB RID: 239851
		[Token(Token = "0x403A8EB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403A8EC RID: 239852
		[Token(Token = "0x403A8EC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
