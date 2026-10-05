using System;
using Il2CppDummyDll;
using Torappu.Battle.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.GameCity.Battle.UI
{
	// Token: 0x02007909 RID: 30985
	[Token(Token = "0x2007909")]
	public class GameCityPauseButton : MonoBehaviour, IHotfixable
	{
		// Token: 0x170065D9 RID: 26073
		// (get) Token: 0x0602B772 RID: 178034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170065D9")]
		public UIBattleSwitchToggle pauseToggle
		{
			[Token(Token = "0x602B772")]
			[Address(RVA = "0x275B870", Offset = "0x275A470", VA = "0x18275B870")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602B773 RID: 178035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B773")]
		[Address(RVA = "0x275B550", Offset = "0x275A150", VA = "0x18275B550")]
		public void OnPauseButtonClick()
		{
		}

		// Token: 0x0602B774 RID: 178036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B774")]
		[Address(RVA = "0x275B390", Offset = "0x2759F90", VA = "0x18275B390")]
		public void ActivePauseButton(bool active)
		{
		}

		// Token: 0x0602B775 RID: 178037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B775")]
		[Address(RVA = "0x275B730", Offset = "0x275A330", VA = "0x18275B730")]
		private void _OnPauseToggled(object arg)
		{
		}

		// Token: 0x0602B776 RID: 178038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B776")]
		[Address(RVA = "0x275B610", Offset = "0x275A210", VA = "0x18275B610")]
		private void Start()
		{
		}

		// Token: 0x0602B777 RID: 178039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B777")]
		[Address(RVA = "0x275B430", Offset = "0x275A030", VA = "0x18275B430")]
		private void OnDestroy()
		{
		}

		// Token: 0x0602B778 RID: 178040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B778")]
		[Address(RVA = "0x275B810", Offset = "0x275A410", VA = "0x18275B810")]
		public GameCityPauseButton()
		{
		}

		// Token: 0x0403ED7A RID: 257402
		[Token(Token = "0x403ED7A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIBattleSwitchToggle _pauseToggle;

		// Token: 0x0403ED7B RID: 257403
		[Token(Token = "0x403ED7B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button _pauseButton;

		// Token: 0x0403ED7C RID: 257404
		[Token(Token = "0x403ED7C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_pauseToggle;

		// Token: 0x0403ED7D RID: 257405
		[Token(Token = "0x403ED7D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnPauseButtonClick;

		// Token: 0x0403ED7E RID: 257406
		[Token(Token = "0x403ED7E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ActivePauseButton;

		// Token: 0x0403ED7F RID: 257407
		[Token(Token = "0x403ED7F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnPauseToggled;

		// Token: 0x0403ED80 RID: 257408
		[Token(Token = "0x403ED80")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0403ED81 RID: 257409
		[Token(Token = "0x403ED81")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0403ED82 RID: 257410
		[Token(Token = "0x403ED82")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
