using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle;
using Torappu.Battle.UI;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act49side.Battle.UI
{
	// Token: 0x0200729D RID: 29341
	[Token(Token = "0x200729D")]
	public class Act49SideBattleUIPlugin : UIController.Plugin
	{
		// Token: 0x060298AC RID: 170156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60298AC")]
		[Address(RVA = "0x24DAEF0", Offset = "0x24D9AF0", VA = "0x1824DAEF0", Slot = "12")]
		public override void OnInitStateMachine(UIStateMachine stateMachine)
		{
		}

		// Token: 0x060298AD RID: 170157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60298AD")]
		[Address(RVA = "0x24DAD20", Offset = "0x24D9920", VA = "0x1824DAD20", Slot = "17")]
		public override void OnGameStart()
		{
		}

		// Token: 0x060298AE RID: 170158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60298AE")]
		[Address(RVA = "0x24DAC50", Offset = "0x24D9850", VA = "0x1824DAC50", Slot = "19")]
		public override void OnGameOver(BattleController.GameResult result)
		{
		}

		// Token: 0x060298AF RID: 170159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60298AF")]
		[Address(RVA = "0x24DB070", Offset = "0x24D9C70", VA = "0x1824DB070", Slot = "21")]
		public override void UpdateGameInfo()
		{
		}

		// Token: 0x060298B0 RID: 170160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60298B0")]
		[Address(RVA = "0x24DB3B0", Offset = "0x24D9FB0", VA = "0x1824DB3B0")]
		private void _UpdateSlider()
		{
		}

		// Token: 0x060298B1 RID: 170161 RVA: 0x000D5E58 File Offset: 0x000D4058
		[Token(Token = "0x60298B1")]
		[Address(RVA = "0x24DB140", Offset = "0x24D9D40", VA = "0x1824DB140")]
		private Act49SideBattleUIPlugin.PrintStage _GetCurPrintStage()
		{
			return Act49SideBattleUIPlugin.PrintStage.None;
		}

		// Token: 0x060298B2 RID: 170162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60298B2")]
		[Address(RVA = "0x24DB700", Offset = "0x24DA300", VA = "0x1824DB700")]
		public Act49SideBattleUIPlugin()
		{
		}

		// Token: 0x060298B4 RID: 170164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60298B4")]
		[Address(RVA = "0x7D24C0", Offset = "0x7D10C0", VA = "0x1807D24C0")]
		private void <>xLuaBaseProxy_OnInitStateMachine(UIStateMachine P0)
		{
		}

		// Token: 0x060298B5 RID: 170165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60298B5")]
		[Address(RVA = "0x960A30", Offset = "0x95F630", VA = "0x180960A30")]
		private void <>xLuaBaseProxy_OnGameStart()
		{
		}

		// Token: 0x060298B6 RID: 170166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60298B6")]
		[Address(RVA = "0x7D24A0", Offset = "0x7D10A0", VA = "0x1807D24A0")]
		private void <>xLuaBaseProxy_OnGameOver(BattleController.GameResult P0)
		{
		}

		// Token: 0x060298B7 RID: 170167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60298B7")]
		[Address(RVA = "0x7D24E0", Offset = "0x7D10E0", VA = "0x1807D24E0")]
		private void <>xLuaBaseProxy_UpdateGameInfo()
		{
		}

		// Token: 0x0403B623 RID: 243235
		[Token(Token = "0x403B623")]
		[FieldOffset(Offset = "0x0")]
		public static readonly UIStateEnum UI_STATE_MOVE_CAMERA;

		// Token: 0x0403B624 RID: 243236
		[Token(Token = "0x403B624")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIStateNode[] _states;

		// Token: 0x0403B625 RID: 243237
		[Token(Token = "0x403B625")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("printCountDown")]
		private Transform _transPrintCountDown;

		// Token: 0x0403B626 RID: 243238
		[Token(Token = "0x403B626")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("printCountDown")]
		private GameObject _goPrintCountDown;

		// Token: 0x0403B627 RID: 243239
		[Token(Token = "0x403B627")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("printCountDown")]
		private Slider _sliderPrint;

		// Token: 0x0403B628 RID: 243240
		[Token(Token = "0x403B628")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("printCountDown")]
		private Image _fillArea;

		// Token: 0x0403B629 RID: 243241
		[Token(Token = "0x403B629")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("printCountDown")]
		private float _stage1bound;

		// Token: 0x0403B62A RID: 243242
		[Token(Token = "0x403B62A")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		[Group("printCountDown")]
		private float _stage2bound;

		// Token: 0x0403B62B RID: 243243
		[Token(Token = "0x403B62B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("animation")]
		private UIAnimationLocation _animationS1ToS2;

		// Token: 0x0403B62C RID: 243244
		[Token(Token = "0x403B62C")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("animation")]
		private UIAnimationLocation _animationS2ToS3;

		// Token: 0x0403B62D RID: 243245
		[Token(Token = "0x403B62D")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("animation")]
		private UIAnimationLocation _animationS3ToS4;

		// Token: 0x0403B62E RID: 243246
		[Token(Token = "0x403B62E")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("printCountDown")]
		private Image _imgDecoBackGround;

		// Token: 0x0403B62F RID: 243247
		[Token(Token = "0x403B62F")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("printCountDown")]
		private CanvasGroup _cgDecoWarning;

		// Token: 0x0403B630 RID: 243248
		[Token(Token = "0x403B630")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("printCountDown")]
		private CanvasGroup _cgGlow;

		// Token: 0x0403B631 RID: 243249
		[Token(Token = "0x403B631")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("printCountDown")]
		private Image _imgGlow;

		// Token: 0x0403B632 RID: 243250
		[Token(Token = "0x403B632")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("printCountDown")]
		private Color _initialColorGlow;

		// Token: 0x0403B633 RID: 243251
		[Token(Token = "0x403B633")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("printCountDown")]
		private Color _initialColorBg;

		// Token: 0x0403B634 RID: 243252
		[Token(Token = "0x403B634")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("printCountDown")]
		private GameObject[] _goToBeSetActiveWhenGameStart;

		// Token: 0x0403B635 RID: 243253
		[Token(Token = "0x403B635")]
		[FieldOffset(Offset = "0xD0")]
		private Act49SidePrintingManager m_envSysManager;

		// Token: 0x0403B636 RID: 243254
		[Token(Token = "0x403B636")]
		[FieldOffset(Offset = "0xD8")]
		private Act49SideBattleUIPlugin.PrintStage m_cachedStage;

		// Token: 0x0403B637 RID: 243255
		[Token(Token = "0x403B637")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInitStateMachine;

		// Token: 0x0403B638 RID: 243256
		[Token(Token = "0x403B638")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnGameStart;

		// Token: 0x0403B639 RID: 243257
		[Token(Token = "0x403B639")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnGameOver;

		// Token: 0x0403B63A RID: 243258
		[Token(Token = "0x403B63A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdateGameInfo;

		// Token: 0x0403B63B RID: 243259
		[Token(Token = "0x403B63B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateSlider;

		// Token: 0x0403B63C RID: 243260
		[Token(Token = "0x403B63C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GetCurPrintStage;

		// Token: 0x0403B63D RID: 243261
		[Token(Token = "0x403B63D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200729E RID: 29342
		[Token(Token = "0x200729E")]
		private enum PrintStage
		{
			// Token: 0x0403B63F RID: 243263
			[Token(Token = "0x403B63F")]
			None,
			// Token: 0x0403B640 RID: 243264
			[Token(Token = "0x403B640")]
			Stage1,
			// Token: 0x0403B641 RID: 243265
			[Token(Token = "0x403B641")]
			Stage2,
			// Token: 0x0403B642 RID: 243266
			[Token(Token = "0x403B642")]
			Stage3,
			// Token: 0x0403B643 RID: 243267
			[Token(Token = "0x403B643")]
			Stage4
		}
	}
}
