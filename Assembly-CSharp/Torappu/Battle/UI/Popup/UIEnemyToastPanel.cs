using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI.Popup
{
	// Token: 0x020033CF RID: 13263
	[Token(Token = "0x20033CF")]
	public class UIEnemyToastPanel : UIToastController.UIToastSubPanel
	{
		// Token: 0x060152AC RID: 86700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152AC")]
		[Address(RVA = "0xDAD200", Offset = "0xDABE00", VA = "0x180DAD200", Slot = "4")]
		public override void OnInit(UIToastController controller)
		{
		}

		// Token: 0x060152AD RID: 86701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152AD")]
		[Address(RVA = "0xDAD480", Offset = "0xDAC080", VA = "0x180DAD480", Slot = "5")]
		public override void OnShow(UIToastController.Options options)
		{
		}

		// Token: 0x060152AE RID: 86702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152AE")]
		[Address(RVA = "0xDAD190", Offset = "0xDABD90", VA = "0x180DAD190")]
		private void OnDestroy()
		{
		}

		// Token: 0x060152AF RID: 86703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152AF")]
		[Address(RVA = "0xDAD9C0", Offset = "0xDAC5C0", VA = "0x180DAD9C0", Slot = "7")]
		public override void SetPaused(bool value)
		{
		}

		// Token: 0x060152B0 RID: 86704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152B0")]
		[Address(RVA = "0xDAD6D0", Offset = "0xDAC2D0", VA = "0x180DAD6D0", Slot = "8")]
		public override void OnUIStateChanged(IUIStateNode stateNode)
		{
		}

		// Token: 0x060152B1 RID: 86705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152B1")]
		[Address(RVA = "0xDAD2B0", Offset = "0xDABEB0", VA = "0x180DAD2B0")]
		public void OnPauseButtonClicked()
		{
		}

		// Token: 0x060152B2 RID: 86706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152B2")]
		[Address(RVA = "0xDAD840", Offset = "0xDAC440", VA = "0x180DAD840", Slot = "6")]
		public override void OnUpdate()
		{
		}

		// Token: 0x060152B3 RID: 86707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152B3")]
		[Address(RVA = "0xDADB70", Offset = "0xDAC770", VA = "0x180DADB70")]
		public UIEnemyToastPanel()
		{
		}

		// Token: 0x060152B4 RID: 86708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152B4")]
		[Address(RVA = "0xDADB40", Offset = "0xDAC740", VA = "0x180DADB40")]
		private void <>xLuaBaseProxy_OnInit(UIToastController P0)
		{
		}

		// Token: 0x060152B5 RID: 86709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152B5")]
		[Address(RVA = "0xDADB60", Offset = "0xDAC760", VA = "0x180DADB60")]
		private void <>xLuaBaseProxy_SetPaused(bool P0)
		{
		}

		// Token: 0x060152B6 RID: 86710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152B6")]
		[Address(RVA = "0xDADB50", Offset = "0xDAC750", VA = "0x180DADB50")]
		private void <>xLuaBaseProxy_OnUIStateChanged(IUIStateNode P0)
		{
		}

		// Token: 0x060152B7 RID: 86711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152B7")]
		[Address(RVA = "0xD5A470", Offset = "0xD59070", VA = "0x180D5A470")]
		private void <>xLuaBaseProxy_OnUpdate()
		{
		}

		// Token: 0x0401941B RID: 103451
		[Token(Token = "0x401941B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _enemyIcon;

		// Token: 0x0401941C RID: 103452
		[Token(Token = "0x401941C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _enemyName;

		// Token: 0x0401941D RID: 103453
		[Token(Token = "0x401941D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _enemyDesc;

		// Token: 0x0401941E RID: 103454
		[Token(Token = "0x401941E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Slider _processSlider;

		// Token: 0x0401941F RID: 103455
		[Token(Token = "0x401941F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UISwitchToggle _pauseToggle;

		// Token: 0x04019420 RID: 103456
		[Token(Token = "0x4019420")]
		[FieldOffset(Offset = "0x50")]
		private bool m_pause;

		// Token: 0x04019421 RID: 103457
		[Token(Token = "0x4019421")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04019422 RID: 103458
		[Token(Token = "0x4019422")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnShow;

		// Token: 0x04019423 RID: 103459
		[Token(Token = "0x4019423")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04019424 RID: 103460
		[Token(Token = "0x4019424")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetPaused;

		// Token: 0x04019425 RID: 103461
		[Token(Token = "0x4019425")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnUIStateChanged;

		// Token: 0x04019426 RID: 103462
		[Token(Token = "0x4019426")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnPauseButtonClicked;

		// Token: 0x04019427 RID: 103463
		[Token(Token = "0x4019427")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnUpdate;

		// Token: 0x04019428 RID: 103464
		[Token(Token = "0x4019428")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
