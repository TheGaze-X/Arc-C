using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020077FB RID: 30715
	[Token(Token = "0x20077FB")]
	public class Act1VHalfIdleSquadCustomFloatView : CommonSquadFloatViewBase
	{
		// Token: 0x0602B164 RID: 176484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B164")]
		[Address(RVA = "0x26E3B20", Offset = "0x26E2720", VA = "0x1826E3B20", Slot = "7")]
		public override void OnValueChanged(CommonSquadGroupViewProperty property)
		{
		}

		// Token: 0x0602B165 RID: 176485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B165")]
		[Address(RVA = "0x26E39E0", Offset = "0x26E25E0", VA = "0x1826E39E0")]
		public void EventOnNextStepClick()
		{
		}

		// Token: 0x0602B166 RID: 176486 RVA: 0x000DACA0 File Offset: 0x000D8EA0
		[Token(Token = "0x602B166")]
		[Address(RVA = "0x26E3D30", Offset = "0x26E2930", VA = "0x1826E3D30")]
		private bool _CheckCanGoNextStep()
		{
			return default(bool);
		}

		// Token: 0x0602B167 RID: 176487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B167")]
		[Address(RVA = "0x26E3C80", Offset = "0x26E2880", VA = "0x1826E3C80", Slot = "8")]
		public override void RegisterTutorialGO()
		{
		}

		// Token: 0x0602B168 RID: 176488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B168")]
		[Address(RVA = "0x26E3D90", Offset = "0x26E2990", VA = "0x1826E3D90")]
		public Act1VHalfIdleSquadCustomFloatView()
		{
		}

		// Token: 0x0602B169 RID: 176489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B169")]
		[Address(RVA = "0x26E3D20", Offset = "0x26E2920", VA = "0x1826E3D20")]
		private void <>xLuaBaseProxy_RegisterTutorialGO()
		{
		}

		// Token: 0x0403E432 RID: 255026
		[Token(Token = "0x403E432")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TwoStateToggle _startBtnState;

		// Token: 0x0403E433 RID: 255027
		[Token(Token = "0x403E433")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _btnStartGO;

		// Token: 0x0403E434 RID: 255028
		[Token(Token = "0x403E434")]
		[FieldOffset(Offset = "0x40")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403E435 RID: 255029
		[Token(Token = "0x403E435")]
		[FieldOffset(Offset = "0x50")]
		private string m_cachedActId;

		// Token: 0x0403E436 RID: 255030
		[Token(Token = "0x403E436")]
		[FieldOffset(Offset = "0x58")]
		private int m_cachedSquadCount;

		// Token: 0x0403E437 RID: 255031
		[Token(Token = "0x403E437")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403E438 RID: 255032
		[Token(Token = "0x403E438")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnNextStepClick;

		// Token: 0x0403E439 RID: 255033
		[Token(Token = "0x403E439")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CheckCanGoNextStep;

		// Token: 0x0403E43A RID: 255034
		[Token(Token = "0x403E43A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterTutorialGO;

		// Token: 0x0403E43B RID: 255035
		[Token(Token = "0x403E43B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
