using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1Lock.UI
{
	// Token: 0x020078B2 RID: 30898
	[Token(Token = "0x20078B2")]
	public class Act1LockMainView : DataBinder<Act1LockMainProperty>
	{
		// Token: 0x0602B548 RID: 177480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B548")]
		[Address(RVA = "0x2728160", Offset = "0x2726D60", VA = "0x182728160", Slot = "7")]
		public override void OnValueChanged(Act1LockMainProperty property)
		{
		}

		// Token: 0x0602B549 RID: 177481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B549")]
		[Address(RVA = "0x2727F70", Offset = "0x2726B70", VA = "0x182727F70")]
		public void EventOnEnterClick()
		{
		}

		// Token: 0x0602B54A RID: 177482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B54A")]
		[Address(RVA = "0x27280A0", Offset = "0x2726CA0", VA = "0x1827280A0")]
		public void EventOnEnterMissionState()
		{
		}

		// Token: 0x0602B54B RID: 177483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B54B")]
		[Address(RVA = "0x2727FE0", Offset = "0x2726BE0", VA = "0x182727FE0")]
		public void EventOnEnterMilestoneState()
		{
		}

		// Token: 0x0602B54C RID: 177484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B54C")]
		[Address(RVA = "0x2728610", Offset = "0x2727210", VA = "0x182728610")]
		public Act1LockMainView()
		{
		}

		// Token: 0x0403EA2B RID: 256555
		[Token(Token = "0x403EA2B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _pointCntLabel;

		// Token: 0x0403EA2C RID: 256556
		[Token(Token = "0x403EA2C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _missionPrgLabel;

		// Token: 0x0403EA2D RID: 256557
		[Token(Token = "0x403EA2D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _timeDescLabel;

		// Token: 0x0403EA2E RID: 256558
		[Token(Token = "0x403EA2E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _timeLabel;

		// Token: 0x0403EA2F RID: 256559
		[Token(Token = "0x403EA2F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button _enterBtn;

		// Token: 0x0403EA30 RID: 256560
		[Token(Token = "0x403EA30")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _finalUnlock;

		// Token: 0x0403EA31 RID: 256561
		[Token(Token = "0x403EA31")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _defendList;

		// Token: 0x0403EA32 RID: 256562
		[Token(Token = "0x403EA32")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Button[] _defendFlags;

		// Token: 0x0403EA33 RID: 256563
		[Token(Token = "0x403EA33")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _battleEndMask;

		// Token: 0x0403EA34 RID: 256564
		[Token(Token = "0x403EA34")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _btnLight;

		// Token: 0x0403EA35 RID: 256565
		[Token(Token = "0x403EA35")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403EA36 RID: 256566
		[Token(Token = "0x403EA36")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnEnterClick;

		// Token: 0x0403EA37 RID: 256567
		[Token(Token = "0x403EA37")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnEnterMissionState;

		// Token: 0x0403EA38 RID: 256568
		[Token(Token = "0x403EA38")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnEnterMilestoneState;

		// Token: 0x0403EA39 RID: 256569
		[Token(Token = "0x403EA39")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
