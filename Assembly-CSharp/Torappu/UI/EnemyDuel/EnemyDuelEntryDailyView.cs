using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004F91 RID: 20369
	[Token(Token = "0x2004F91")]
	public class EnemyDuelEntryDailyView : DataBinder<EnemyDuelEntryDailyProperty>, IHotfixable
	{
		// Token: 0x0601E495 RID: 124053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E495")]
		[Address(RVA = "0x17FC6F0", Offset = "0x17FB2F0", VA = "0x1817FC6F0", Slot = "7")]
		public override void OnValueChanged(EnemyDuelEntryDailyProperty property)
		{
		}

		// Token: 0x0601E496 RID: 124054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E496")]
		[Address(RVA = "0x17FC8E0", Offset = "0x17FB4E0", VA = "0x1817FC8E0")]
		public EnemyDuelEntryDailyView()
		{
		}

		// Token: 0x040286BB RID: 165563
		[Token(Token = "0x40286BB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _progress;

		// Token: 0x040286BC RID: 165564
		[Token(Token = "0x40286BC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _desc;

		// Token: 0x040286BD RID: 165565
		[Token(Token = "0x40286BD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Slider _progressBar;

		// Token: 0x040286BE RID: 165566
		[Token(Token = "0x40286BE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040286BF RID: 165567
		[Token(Token = "0x40286BF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
