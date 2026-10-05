using System;
using Il2CppDummyDll;
using Torappu.Battle.UI.GameCity;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x0200338F RID: 13199
	[Token(Token = "0x200338F")]
	public class UINumericTextWithoutModifier : UIPopup
	{
		// Token: 0x060150B6 RID: 86198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150B6")]
		[Address(RVA = "0xD79A50", Offset = "0xD78650", VA = "0x180D79A50", Slot = "9")]
		protected override void SetTweens(float duration)
		{
		}

		// Token: 0x060150B7 RID: 86199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150B7")]
		[Address(RVA = "0xD79840", Offset = "0xD78440", VA = "0x180D79840")]
		public void Init(int value, Transform spawnPoint, Color color)
		{
		}

		// Token: 0x060150B8 RID: 86200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150B8")]
		[Address(RVA = "0xD79AD0", Offset = "0xD786D0", VA = "0x180D79AD0")]
		public UINumericTextWithoutModifier()
		{
		}

		// Token: 0x040190C9 RID: 102601
		[Token(Token = "0x40190C9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameCityBattleScoreUIPanel _label;

		// Token: 0x040190CA RID: 102602
		[Token(Token = "0x40190CA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetTweens;

		// Token: 0x040190CB RID: 102603
		[Token(Token = "0x40190CB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x040190CC RID: 102604
		[Token(Token = "0x40190CC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
