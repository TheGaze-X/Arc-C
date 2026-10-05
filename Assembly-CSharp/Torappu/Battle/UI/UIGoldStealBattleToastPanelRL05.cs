using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x02003342 RID: 13122
	[Token(Token = "0x2003342")]
	public class UIGoldStealBattleToastPanelRL05 : UIToastController.UIToastSubPanel
	{
		// Token: 0x06014EEF RID: 85743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014EEF")]
		[Address(RVA = "0xD5A860", Offset = "0xD59460", VA = "0x180D5A860", Slot = "5")]
		public override void OnShow(UIToastController.Options options)
		{
		}

		// Token: 0x06014EF0 RID: 85744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014EF0")]
		[Address(RVA = "0xD5A980", Offset = "0xD59580", VA = "0x180D5A980", Slot = "6")]
		public override void OnUpdate()
		{
		}

		// Token: 0x06014EF1 RID: 85745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014EF1")]
		[Address(RVA = "0xD5AA20", Offset = "0xD59620", VA = "0x180D5AA20")]
		public UIGoldStealBattleToastPanelRL05()
		{
		}

		// Token: 0x06014EF2 RID: 85746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014EF2")]
		[Address(RVA = "0xD5A470", Offset = "0xD59070", VA = "0x180D5A470")]
		private void <>xLuaBaseProxy_OnUpdate()
		{
		}

		// Token: 0x04018E48 RID: 101960
		[Token(Token = "0x4018E48")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _descText;

		// Token: 0x04018E49 RID: 101961
		[Token(Token = "0x4018E49")]
		[FieldOffset(Offset = "0x30")]
		private float m_lastTime;

		// Token: 0x04018E4A RID: 101962
		[Token(Token = "0x4018E4A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnShow;

		// Token: 0x04018E4B RID: 101963
		[Token(Token = "0x4018E4B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnUpdate;

		// Token: 0x04018E4C RID: 101964
		[Token(Token = "0x4018E4C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
