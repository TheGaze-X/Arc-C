using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1BossRush.Battle.UI
{
	// Token: 0x020070D8 RID: 28888
	[Token(Token = "0x20070D8")]
	public class BossRushSystemMenuPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029100 RID: 168192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029100")]
		[Address(RVA = "0x2477550", Offset = "0x2476150", VA = "0x182477550")]
		public void SetData()
		{
		}

		// Token: 0x06029101 RID: 168193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029101")]
		[Address(RVA = "0x2477730", Offset = "0x2476330", VA = "0x182477730")]
		public void Show()
		{
		}

		// Token: 0x06029102 RID: 168194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029102")]
		[Address(RVA = "0x2477470", Offset = "0x2476070", VA = "0x182477470")]
		public void Hide()
		{
		}

		// Token: 0x06029103 RID: 168195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029103")]
		[Address(RVA = "0x24774E0", Offset = "0x24760E0", VA = "0x1824774E0")]
		public void OnInit()
		{
		}

		// Token: 0x06029104 RID: 168196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029104")]
		[Address(RVA = "0x2477810", Offset = "0x2476410", VA = "0x182477810")]
		public BossRushSystemMenuPanel()
		{
		}

		// Token: 0x0403A9B2 RID: 240050
		[Token(Token = "0x403A9B2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UITextSlider _slider;

		// Token: 0x0403A9B3 RID: 240051
		[Token(Token = "0x403A9B3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _fadeInTime;

		// Token: 0x0403A9B4 RID: 240052
		[Token(Token = "0x403A9B4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0403A9B5 RID: 240053
		[Token(Token = "0x403A9B5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _waveText;

		// Token: 0x0403A9B6 RID: 240054
		[Token(Token = "0x403A9B6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x0403A9B7 RID: 240055
		[Token(Token = "0x403A9B7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x0403A9B8 RID: 240056
		[Token(Token = "0x403A9B8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x0403A9B9 RID: 240057
		[Token(Token = "0x403A9B9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0403A9BA RID: 240058
		[Token(Token = "0x403A9BA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
