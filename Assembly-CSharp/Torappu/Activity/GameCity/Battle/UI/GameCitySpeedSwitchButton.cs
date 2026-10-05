using System;
using Il2CppDummyDll;
using Torappu.Battle;
using Torappu.Battle.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.GameCity.Battle.UI
{
	// Token: 0x0200790C RID: 30988
	[Token(Token = "0x200790C")]
	public class GameCitySpeedSwitchButton : MonoBehaviour, IHotfixable
	{
		// Token: 0x170065DA RID: 26074
		// (get) Token: 0x0602B780 RID: 178048 RVA: 0x000DC290 File Offset: 0x000DA490
		[Token(Token = "0x170065DA")]
		public bool isInteractive
		{
			[Token(Token = "0x602B780")]
			[Address(RVA = "0x275CCF0", Offset = "0x275B8F0", VA = "0x18275CCF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602B781 RID: 178049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B781")]
		[Address(RVA = "0x275C8A0", Offset = "0x275B4A0", VA = "0x18275C8A0")]
		public void OnInit()
		{
		}

		// Token: 0x0602B782 RID: 178050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B782")]
		[Address(RVA = "0x275C9A0", Offset = "0x275B5A0", VA = "0x18275C9A0")]
		public void OnSpeedButtonClick()
		{
		}

		// Token: 0x0602B783 RID: 178051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B783")]
		[Address(RVA = "0x275C790", Offset = "0x275B390", VA = "0x18275C790")]
		public void ActiveSpeedButton(bool active)
		{
		}

		// Token: 0x0602B784 RID: 178052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B784")]
		[Address(RVA = "0x275CA90", Offset = "0x275B690", VA = "0x18275CA90")]
		private void _OnSpeedLevelChanged(object arg)
		{
		}

		// Token: 0x0602B785 RID: 178053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B785")]
		[Address(RVA = "0x275CBE0", Offset = "0x275B7E0", VA = "0x18275CBE0")]
		private void _ToggleSpeedLevel(SpeedLevel level)
		{
		}

		// Token: 0x0602B786 RID: 178054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B786")]
		[Address(RVA = "0x275CC90", Offset = "0x275B890", VA = "0x18275CC90")]
		public GameCitySpeedSwitchButton()
		{
		}

		// Token: 0x0403ED93 RID: 257427
		[Token(Token = "0x403ED93")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIBattleSwitchToggle _speedToggle;

		// Token: 0x0403ED94 RID: 257428
		[Token(Token = "0x403ED94")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button _speedButton;

		// Token: 0x0403ED95 RID: 257429
		[Token(Token = "0x403ED95")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Graphic _slowMotionImage;

		// Token: 0x0403ED96 RID: 257430
		[Token(Token = "0x403ED96")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isInteractive;

		// Token: 0x0403ED97 RID: 257431
		[Token(Token = "0x403ED97")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0403ED98 RID: 257432
		[Token(Token = "0x403ED98")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnSpeedButtonClick;

		// Token: 0x0403ED99 RID: 257433
		[Token(Token = "0x403ED99")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ActiveSpeedButton;

		// Token: 0x0403ED9A RID: 257434
		[Token(Token = "0x403ED9A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnSpeedLevelChanged;

		// Token: 0x0403ED9B RID: 257435
		[Token(Token = "0x403ED9B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ToggleSpeedLevel;

		// Token: 0x0403ED9C RID: 257436
		[Token(Token = "0x403ED9C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
