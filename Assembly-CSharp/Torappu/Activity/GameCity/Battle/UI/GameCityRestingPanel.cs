using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.GameCity.Battle.UI
{
	// Token: 0x0200790A RID: 30986
	[Token(Token = "0x200790A")]
	public class GameCityRestingPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602B779 RID: 178041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B779")]
		[Address(RVA = "0x275BA50", Offset = "0x275A650", VA = "0x18275BA50")]
		public void OnInit()
		{
		}

		// Token: 0x0602B77A RID: 178042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B77A")]
		[Address(RVA = "0x275BBC0", Offset = "0x275A7C0", VA = "0x18275BBC0")]
		public void OnUpdate(int time)
		{
		}

		// Token: 0x0602B77B RID: 178043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B77B")]
		[Address(RVA = "0x275B8D0", Offset = "0x275A4D0", VA = "0x18275B8D0")]
		public void OnButtonClick()
		{
		}

		// Token: 0x0602B77C RID: 178044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B77C")]
		[Address(RVA = "0x275BC90", Offset = "0x275A890", VA = "0x18275BC90")]
		private void _Oncomplete()
		{
		}

		// Token: 0x0602B77D RID: 178045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B77D")]
		[Address(RVA = "0x275BDD0", Offset = "0x275A9D0", VA = "0x18275BDD0")]
		public GameCityRestingPanel()
		{
		}

		// Token: 0x0403ED83 RID: 257411
		[Token(Token = "0x403ED83")]
		private const string BUTTON_ANIMATION_KEY = "act1arcade_hud_skipresstbtn_once";

		// Token: 0x0403ED84 RID: 257412
		[Token(Token = "0x403ED84")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _timeText;

		// Token: 0x0403ED85 RID: 257413
		[Token(Token = "0x403ED85")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text skipTitle;

		// Token: 0x0403ED86 RID: 257414
		[Token(Token = "0x403ED86")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text skipInfo;

		// Token: 0x0403ED87 RID: 257415
		[Token(Token = "0x403ED87")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button _skipButton;

		// Token: 0x0403ED88 RID: 257416
		[Token(Token = "0x403ED88")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AnimationWrapper _buttonAnimationWrapper;

		// Token: 0x0403ED89 RID: 257417
		[Token(Token = "0x403ED89")]
		[FieldOffset(Offset = "0x40")]
		private bool buttonClicked;

		// Token: 0x0403ED8A RID: 257418
		[Token(Token = "0x403ED8A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0403ED8B RID: 257419
		[Token(Token = "0x403ED8B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnUpdate;

		// Token: 0x0403ED8C RID: 257420
		[Token(Token = "0x403ED8C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnButtonClick;

		// Token: 0x0403ED8D RID: 257421
		[Token(Token = "0x403ED8D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__Oncomplete;

		// Token: 0x0403ED8E RID: 257422
		[Token(Token = "0x403ED8E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
