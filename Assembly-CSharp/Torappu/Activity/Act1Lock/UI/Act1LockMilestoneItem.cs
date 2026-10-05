using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1Lock.UI
{
	// Token: 0x020078B5 RID: 30901
	[Token(Token = "0x20078B5")]
	public class Act1LockMilestoneItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x17006562 RID: 25954
		// (get) Token: 0x0602B560 RID: 177504 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602B561 RID: 177505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006562")]
		public ActivityInterlockData.MileStoneItemInfo itemInfo
		{
			[Token(Token = "0x602B560")]
			[Address(RVA = "0x272AD10", Offset = "0x2729910", VA = "0x18272AD10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602B561")]
			[Address(RVA = "0x272ADD0", Offset = "0x27299D0", VA = "0x18272ADD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006563 RID: 25955
		// (get) Token: 0x0602B562 RID: 177506 RVA: 0x000DB738 File Offset: 0x000D9938
		// (set) Token: 0x0602B563 RID: 177507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006563")]
		public Act1LockMilestoneItem.Status status
		{
			[Token(Token = "0x602B562")]
			[Address(RVA = "0x272AD70", Offset = "0x2729970", VA = "0x18272AD70")]
			[CompilerGenerated]
			get
			{
				return Act1LockMilestoneItem.Status.NONE;
			}
			[Token(Token = "0x602B563")]
			[Address(RVA = "0x272AE50", Offset = "0x2729A50", VA = "0x18272AE50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0602B564 RID: 177508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B564")]
		[Address(RVA = "0x272A650", Offset = "0x2729250", VA = "0x18272A650")]
		public void Init(ActivityInterlockData.MileStoneItemInfo msitem, UIItemViewModel point, Action<string> getfunc)
		{
		}

		// Token: 0x0602B565 RID: 177509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B565")]
		[Address(RVA = "0x272AB90", Offset = "0x2729790", VA = "0x18272AB90")]
		public void UpdateStatus(int pointCnt, bool getted)
		{
		}

		// Token: 0x0602B566 RID: 177510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B566")]
		[Address(RVA = "0x272A570", Offset = "0x2729170", VA = "0x18272A570")]
		public void EventOnClick()
		{
		}

		// Token: 0x0602B567 RID: 177511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B567")]
		[Address(RVA = "0x272A1E0", Offset = "0x2728DE0", VA = "0x18272A1E0")]
		public void ChangeStatus(Act1LockMilestoneItem.Status newStatus)
		{
		}

		// Token: 0x0602B568 RID: 177512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B568")]
		[Address(RVA = "0x272ACB0", Offset = "0x27298B0", VA = "0x18272ACB0")]
		public Act1LockMilestoneItem()
		{
		}

		// Token: 0x0403EA63 RID: 256611
		[Token(Token = "0x403EA63")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _bg;

		// Token: 0x0403EA64 RID: 256612
		[Token(Token = "0x403EA64")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite _completedBg;

		// Token: 0x0403EA65 RID: 256613
		[Token(Token = "0x403EA65")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Sprite _uncompletedBg;

		// Token: 0x0403EA66 RID: 256614
		[Token(Token = "0x403EA66")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _grow;

		// Token: 0x0403EA67 RID: 256615
		[Token(Token = "0x403EA67")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _getedMask;

		// Token: 0x0403EA68 RID: 256616
		[Token(Token = "0x403EA68")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _descBg;

		// Token: 0x0403EA69 RID: 256617
		[Token(Token = "0x403EA69")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _white;

		// Token: 0x0403EA6A RID: 256618
		[Token(Token = "0x403EA6A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Color _blue;

		// Token: 0x0403EA6B RID: 256619
		[Token(Token = "0x403EA6B")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _needCnt;

		// Token: 0x0403EA6C RID: 256620
		[Token(Token = "0x403EA6C")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _needDesc;

		// Token: 0x0403EA6D RID: 256621
		[Token(Token = "0x403EA6D")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _rewardName;

		// Token: 0x0403EA6E RID: 256622
		[Token(Token = "0x403EA6E")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _rewardCnt;

		// Token: 0x0403EA6F RID: 256623
		[Token(Token = "0x403EA6F")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RectTransform _rewardIconRoot;

		// Token: 0x0403EA71 RID: 256625
		[Token(Token = "0x403EA71")]
		[FieldOffset(Offset = "0x98")]
		private Action<string> m_getFunc;

		// Token: 0x0403EA73 RID: 256627
		[Token(Token = "0x403EA73")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_itemInfo;

		// Token: 0x0403EA74 RID: 256628
		[Token(Token = "0x403EA74")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_itemInfo;

		// Token: 0x0403EA75 RID: 256629
		[Token(Token = "0x403EA75")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_status;

		// Token: 0x0403EA76 RID: 256630
		[Token(Token = "0x403EA76")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_status;

		// Token: 0x0403EA77 RID: 256631
		[Token(Token = "0x403EA77")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0403EA78 RID: 256632
		[Token(Token = "0x403EA78")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_UpdateStatus;

		// Token: 0x0403EA79 RID: 256633
		[Token(Token = "0x403EA79")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnClick;

		// Token: 0x0403EA7A RID: 256634
		[Token(Token = "0x403EA7A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ChangeStatus;

		// Token: 0x0403EA7B RID: 256635
		[Token(Token = "0x403EA7B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020078B6 RID: 30902
		[Token(Token = "0x20078B6")]
		public enum Status
		{
			// Token: 0x0403EA7D RID: 256637
			[Token(Token = "0x403EA7D")]
			NONE,
			// Token: 0x0403EA7E RID: 256638
			[Token(Token = "0x403EA7E")]
			UNCOMPLETED,
			// Token: 0x0403EA7F RID: 256639
			[Token(Token = "0x403EA7F")]
			COMPLETED,
			// Token: 0x0403EA80 RID: 256640
			[Token(Token = "0x403EA80")]
			GOT
		}
	}
}
