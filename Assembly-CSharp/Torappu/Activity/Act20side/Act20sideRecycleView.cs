using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x0200768B RID: 30347
	[Token(Token = "0x200768B")]
	public class Act20sideRecycleView : PageSingleComponent
	{
		// Token: 0x0602AAED RID: 174829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AAED")]
		[Address(RVA = "0x267A5F0", Offset = "0x26791F0", VA = "0x18267A5F0")]
		public void Render(Act20sideMilestoneViewModel viewModel)
		{
		}

		// Token: 0x0602AAEE RID: 174830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AAEE")]
		[Address(RVA = "0x267A330", Offset = "0x2678F30", VA = "0x18267A330")]
		public void OnCancel()
		{
		}

		// Token: 0x0602AAEF RID: 174831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AAEF")]
		[Address(RVA = "0x267A2C0", Offset = "0x2678EC0", VA = "0x18267A2C0")]
		private void Hide()
		{
		}

		// Token: 0x0602AAF0 RID: 174832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AAF0")]
		[Address(RVA = "0x267A3D0", Offset = "0x2678FD0", VA = "0x18267A3D0")]
		public void OnRecycleClick()
		{
		}

		// Token: 0x0602AAF1 RID: 174833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AAF1")]
		[Address(RVA = "0x267AA90", Offset = "0x2679690", VA = "0x18267AA90")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602AAF2 RID: 174834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AAF2")]
		[Address(RVA = "0x267AC30", Offset = "0x2679830", VA = "0x18267AC30")]
		private IEnumerator _ReceiveItemsCoroutine(List<RewardItemModel> rewardList, Action onConfirm)
		{
			return null;
		}

		// Token: 0x0602AAF3 RID: 174835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AAF3")]
		[Address(RVA = "0x267AD10", Offset = "0x2679910", VA = "0x18267AD10")]
		public Act20sideRecycleView()
		{
		}

		// Token: 0x0403D7EA RID: 251882
		[Token(Token = "0x403D7EA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _recycleNum;

		// Token: 0x0403D7EB RID: 251883
		[Token(Token = "0x403D7EB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _goldNum;

		// Token: 0x0403D7EC RID: 251884
		[Token(Token = "0x403D7EC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button _confirmBtn;

		// Token: 0x0403D7ED RID: 251885
		[Token(Token = "0x403D7ED")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Button _cancelBtn;

		// Token: 0x0403D7EE RID: 251886
		[Token(Token = "0x403D7EE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIBlurFloatPanel _blurBg;

		// Token: 0x0403D7EF RID: 251887
		[Token(Token = "0x403D7EF")]
		[FieldOffset(Offset = "0x48")]
		private string m_activityId;

		// Token: 0x0403D7F0 RID: 251888
		[Token(Token = "0x403D7F0")]
		[FieldOffset(Offset = "0x50")]
		private bool m_hasInited;

		// Token: 0x0403D7F1 RID: 251889
		[Token(Token = "0x403D7F1")]
		[FieldOffset(Offset = "0x58")]
		private Coroutine _hideCoroutine;

		// Token: 0x0403D7F2 RID: 251890
		[Token(Token = "0x403D7F2")]
		[FieldOffset(Offset = "0x60")]
		private Coroutine _claimCoroutine;

		// Token: 0x0403D7F3 RID: 251891
		[Token(Token = "0x403D7F3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403D7F4 RID: 251892
		[Token(Token = "0x403D7F4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCancel;

		// Token: 0x0403D7F5 RID: 251893
		[Token(Token = "0x403D7F5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x0403D7F6 RID: 251894
		[Token(Token = "0x403D7F6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnRecycleClick;

		// Token: 0x0403D7F7 RID: 251895
		[Token(Token = "0x403D7F7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403D7F8 RID: 251896
		[Token(Token = "0x403D7F8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ReceiveItemsCoroutine;

		// Token: 0x0403D7F9 RID: 251897
		[Token(Token = "0x403D7F9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
