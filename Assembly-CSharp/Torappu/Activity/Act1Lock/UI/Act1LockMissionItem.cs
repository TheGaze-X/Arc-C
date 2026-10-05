using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1Lock.UI
{
	// Token: 0x020078B8 RID: 30904
	[Token(Token = "0x20078B8")]
	public class Act1LockMissionItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x14000091 RID: 145
		// (add) Token: 0x0602B56B RID: 177515 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0602B56C RID: 177516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000091")]
		public event Action<string> eClick
		{
			[Token(Token = "0x602B56B")]
			[Address(RVA = "0x272B8B0", Offset = "0x272A4B0", VA = "0x18272B8B0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x602B56C")]
			[Address(RVA = "0x272B9B0", Offset = "0x272A5B0", VA = "0x18272B9B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0602B56D RID: 177517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B56D")]
		[Address(RVA = "0x272B170", Offset = "0x2729D70", VA = "0x18272B170")]
		public void Flush(Act1LockMissionItem.Mission mission)
		{
		}

		// Token: 0x0602B56E RID: 177518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B56E")]
		[Address(RVA = "0x272B780", Offset = "0x272A380", VA = "0x18272B780")]
		private void _ChangeStatus(Act1LockMissionItem.Status status)
		{
		}

		// Token: 0x0602B56F RID: 177519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B56F")]
		[Address(RVA = "0x272B0E0", Offset = "0x2729CE0", VA = "0x18272B0E0")]
		public void EventOnClick()
		{
		}

		// Token: 0x0602B570 RID: 177520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B570")]
		[Address(RVA = "0x272B850", Offset = "0x272A450", VA = "0x18272B850")]
		public Act1LockMissionItem()
		{
		}

		// Token: 0x0403EA83 RID: 256643
		[Token(Token = "0x403EA83")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _bg;

		// Token: 0x0403EA84 RID: 256644
		[Token(Token = "0x403EA84")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite _doingBg;

		// Token: 0x0403EA85 RID: 256645
		[Token(Token = "0x403EA85")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Sprite _doneBg;

		// Token: 0x0403EA86 RID: 256646
		[Token(Token = "0x403EA86")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _doneGlow;

		// Token: 0x0403EA87 RID: 256647
		[Token(Token = "0x403EA87")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _completeMask;

		// Token: 0x0403EA88 RID: 256648
		[Token(Token = "0x403EA88")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _descText;

		// Token: 0x0403EA89 RID: 256649
		[Token(Token = "0x403EA89")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _prgText;

		// Token: 0x0403EA8A RID: 256650
		[Token(Token = "0x403EA8A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Slider _prgBar;

		// Token: 0x0403EA8B RID: 256651
		[Token(Token = "0x403EA8B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _prgRoot;

		// Token: 0x0403EA8C RID: 256652
		[Token(Token = "0x403EA8C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RectTransform _rewardCellRoot;

		// Token: 0x0403EA8D RID: 256653
		[Token(Token = "0x403EA8D")]
		[FieldOffset(Offset = "0x68")]
		private Act1LockMissionItem.Mission m_mission;

		// Token: 0x0403EA8F RID: 256655
		[Token(Token = "0x403EA8F")]
		[FieldOffset(Offset = "0x78")]
		private Act1LockMissionItem.Status m_status;

		// Token: 0x0403EA90 RID: 256656
		[Token(Token = "0x403EA90")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_add_eClick;

		// Token: 0x0403EA91 RID: 256657
		[Token(Token = "0x403EA91")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_remove_eClick;

		// Token: 0x0403EA92 RID: 256658
		[Token(Token = "0x403EA92")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Flush;

		// Token: 0x0403EA93 RID: 256659
		[Token(Token = "0x403EA93")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ChangeStatus;

		// Token: 0x0403EA94 RID: 256660
		[Token(Token = "0x403EA94")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnClick;

		// Token: 0x0403EA95 RID: 256661
		[Token(Token = "0x403EA95")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020078B9 RID: 30905
		[Token(Token = "0x20078B9")]
		public enum Status
		{
			// Token: 0x0403EA97 RID: 256663
			[Token(Token = "0x403EA97")]
			NONE,
			// Token: 0x0403EA98 RID: 256664
			[Token(Token = "0x403EA98")]
			DOING,
			// Token: 0x0403EA99 RID: 256665
			[Token(Token = "0x403EA99")]
			DONE,
			// Token: 0x0403EA9A RID: 256666
			[Token(Token = "0x403EA9A")]
			COMPLETE
		}

		// Token: 0x020078BA RID: 30906
		[Token(Token = "0x20078BA")]
		public class Mission
		{
			// Token: 0x0602B571 RID: 177521 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B571")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Mission()
			{
			}

			// Token: 0x0403EA9B RID: 256667
			[Token(Token = "0x403EA9B")]
			[FieldOffset(Offset = "0x10")]
			public MissionData data;

			// Token: 0x0403EA9C RID: 256668
			[Token(Token = "0x403EA9C")]
			[FieldOffset(Offset = "0x18")]
			public MissionHoldingState state;

			// Token: 0x0403EA9D RID: 256669
			[Token(Token = "0x403EA9D")]
			[FieldOffset(Offset = "0x1C")]
			public int target;

			// Token: 0x0403EA9E RID: 256670
			[Token(Token = "0x403EA9E")]
			[FieldOffset(Offset = "0x20")]
			public int value;
		}
	}
}
