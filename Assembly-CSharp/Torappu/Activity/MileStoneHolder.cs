using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006D85 RID: 28037
	[Token(Token = "0x2006D85")]
	public abstract class MileStoneHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x06027F01 RID: 163585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F01")]
		[Address(RVA = "0x2341B40", Offset = "0x2340740", VA = "0x182341B40")]
		public void RenderInfo(List<MileStoneViewModel> viewModelList, int count, string spReward)
		{
		}

		// Token: 0x06027F02 RID: 163586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F02")]
		[Address(RVA = "0x2341A70", Offset = "0x2340670", VA = "0x182341A70")]
		public void RefreshInfo(List<MileStoneViewModel> viewModelList, int count, string spReward)
		{
		}

		// Token: 0x06027F03 RID: 163587
		[Token(Token = "0x6027F03")]
		protected abstract void OnRefreshHolderInfo(List<MileStoneViewModel> viewModelList, int count, string spReward);

		// Token: 0x06027F04 RID: 163588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F04")]
		[Address(RVA = "0x2341D80", Offset = "0x2340980", VA = "0x182341D80")]
		private void _RenderMileStonePart(List<MileStoneViewModel> viewModelList)
		{
		}

		// Token: 0x06027F05 RID: 163589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F05")]
		[Address(RVA = "0x2341E20", Offset = "0x2340A20", VA = "0x182341E20")]
		private void _ScrollToRewardableSlot(List<MileStoneViewModel> viewModelList)
		{
		}

		// Token: 0x06027F06 RID: 163590
		[Token(Token = "0x6027F06")]
		protected abstract float GetScrollToTargetIndex(int firstAbleGet);

		// Token: 0x06027F07 RID: 163591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027F07")]
		[Address(RVA = "0x2341CC0", Offset = "0x23408C0", VA = "0x182341CC0")]
		private IEnumerator _RefreshTargetState(float index)
		{
			return null;
		}

		// Token: 0x06027F08 RID: 163592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F08")]
		[Address(RVA = "0x2342000", Offset = "0x2340C00", VA = "0x182342000")]
		protected MileStoneHolder()
		{
		}

		// Token: 0x040389B4 RID: 231860
		[Token(Token = "0x40389B4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private LoopVerticalScrollRect _content;

		// Token: 0x040389B5 RID: 231861
		[Token(Token = "0x40389B5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MileStoneGridAdapter _adapter;

		// Token: 0x040389B6 RID: 231862
		[Token(Token = "0x40389B6")]
		[FieldOffset(Offset = "0x28")]
		protected int _max;

		// Token: 0x040389B7 RID: 231863
		[Token(Token = "0x40389B7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderInfo;

		// Token: 0x040389B8 RID: 231864
		[Token(Token = "0x40389B8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshInfo;

		// Token: 0x040389B9 RID: 231865
		[Token(Token = "0x40389B9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderMileStonePart;

		// Token: 0x040389BA RID: 231866
		[Token(Token = "0x40389BA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ScrollToRewardableSlot;

		// Token: 0x040389BB RID: 231867
		[Token(Token = "0x40389BB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RefreshTargetState;

		// Token: 0x040389BC RID: 231868
		[Token(Token = "0x40389BC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
