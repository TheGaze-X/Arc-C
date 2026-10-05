using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act3D5
{
	// Token: 0x020073C1 RID: 29633
	[Token(Token = "0x20073C1")]
	public class Act3D5Entry : ActivityCommonEntry, IHotfixable
	{
		// Token: 0x06029DD8 RID: 171480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029DD8")]
		[Address(RVA = "0x256BB30", Offset = "0x256A730", VA = "0x18256BB30", Slot = "4")]
		public override void OnEnter(string activityId)
		{
		}

		// Token: 0x06029DD9 RID: 171481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029DD9")]
		[Address(RVA = "0x256D360", Offset = "0x256BF60", VA = "0x18256D360")]
		private void _SynPrg(List<ActivityCollectionData.CollectionInfo> collections, int completeIdx, int pointCurCnt, int lastCanGetIdx)
		{
		}

		// Token: 0x06029DDA RID: 171482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029DDA")]
		[Address(RVA = "0x256CD60", Offset = "0x256B960", VA = "0x18256CD60")]
		private void _CheckMissionStatus()
		{
		}

		// Token: 0x06029DDB RID: 171483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029DDB")]
		[Address(RVA = "0x256C7F0", Offset = "0x256B3F0", VA = "0x18256C7F0")]
		public void OnOpenHelpPage()
		{
		}

		// Token: 0x06029DDC RID: 171484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029DDC")]
		[Address(RVA = "0x256D2C0", Offset = "0x256BEC0", VA = "0x18256D2C0")]
		private void _HandleHelpViewClose()
		{
		}

		// Token: 0x06029DDD RID: 171485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029DDD")]
		[Address(RVA = "0x256C990", Offset = "0x256B590", VA = "0x18256C990")]
		public void OnScrollTo()
		{
		}

		// Token: 0x06029DDE RID: 171486 RVA: 0x000D6D58 File Offset: 0x000D4F58
		[Token(Token = "0x6029DDE")]
		[Address(RVA = "0x256CBF0", Offset = "0x256B7F0", VA = "0x18256CBF0")]
		private float _CalculateItemScrollPrg(int itemIdx, int totalCount)
		{
			return 0f;
		}

		// Token: 0x06029DDF RID: 171487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029DDF")]
		[Address(RVA = "0x256D7E0", Offset = "0x256C3E0", VA = "0x18256D7E0")]
		public Act3D5Entry()
		{
		}

		// Token: 0x0403BFEF RID: 245743
		[Token(Token = "0x403BFEF")]
		[FieldOffset(Offset = "0x0")]
		private static bool s_sorted;

		// Token: 0x0403BFF0 RID: 245744
		[Token(Token = "0x403BFF0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _actDescLabel;

		// Token: 0x0403BFF1 RID: 245745
		[Token(Token = "0x403BFF1")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _pointTitle;

		// Token: 0x0403BFF2 RID: 245746
		[Token(Token = "0x403BFF2")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _pointCnt;

		// Token: 0x0403BFF3 RID: 245747
		[Token(Token = "0x403BFF3")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _timeDesc;

		// Token: 0x0403BFF4 RID: 245748
		[Token(Token = "0x403BFF4")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _pointIcon;

		// Token: 0x0403BFF5 RID: 245749
		[Token(Token = "0x403BFF5")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _helpBtnDesc;

		// Token: 0x0403BFF6 RID: 245750
		[Token(Token = "0x403BFF6")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Slider _prg;

		// Token: 0x0403BFF7 RID: 245751
		[Token(Token = "0x403BFF7")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Transform _itemContainer;

		// Token: 0x0403BFF8 RID: 245752
		[Token(Token = "0x403BFF8")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private ScrollRect _scrollView;

		// Token: 0x0403BFF9 RID: 245753
		[Token(Token = "0x403BFF9")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Activity3D5Item _itemPrefab;

		// Token: 0x0403BFFA RID: 245754
		[Token(Token = "0x403BFFA")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Activity3D5HelpView _helpViewPrefab;

		// Token: 0x0403BFFB RID: 245755
		[Token(Token = "0x403BFFB")]
		[FieldOffset(Offset = "0x98")]
		private List<Activity3D5Item> m_itemList;

		// Token: 0x0403BFFC RID: 245756
		[Token(Token = "0x403BFFC")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_adjustPrgWidth;

		// Token: 0x0403BFFD RID: 245757
		[Token(Token = "0x403BFFD")]
		[FieldOffset(Offset = "0xA8")]
		private Activity3D5HelpView m_helpView;

		// Token: 0x0403BFFE RID: 245758
		[Token(Token = "0x403BFFE")]
		[FieldOffset(Offset = "0xB0")]
		private string m_activityId;

		// Token: 0x0403BFFF RID: 245759
		[Token(Token = "0x403BFFF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403C000 RID: 245760
		[Token(Token = "0x403C000")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SynPrg;

		// Token: 0x0403C001 RID: 245761
		[Token(Token = "0x403C001")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CheckMissionStatus;

		// Token: 0x0403C002 RID: 245762
		[Token(Token = "0x403C002")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnOpenHelpPage;

		// Token: 0x0403C003 RID: 245763
		[Token(Token = "0x403C003")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__HandleHelpViewClose;

		// Token: 0x0403C004 RID: 245764
		[Token(Token = "0x403C004")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnScrollTo;

		// Token: 0x0403C005 RID: 245765
		[Token(Token = "0x403C005")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CalculateItemScrollPrg;

		// Token: 0x0403C006 RID: 245766
		[Token(Token = "0x403C006")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
