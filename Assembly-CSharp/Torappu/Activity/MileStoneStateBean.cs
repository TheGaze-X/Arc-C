using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006D8B RID: 28043
	[Token(Token = "0x2006D8B")]
	public abstract class MileStoneStateBean : MonoBehaviour, IStateBean, IHotfixable
	{
		// Token: 0x06027F2F RID: 163631
		[Token(Token = "0x6027F2F")]
		protected abstract List<MileStoneInfo> GetMileStoneList();

		// Token: 0x06027F30 RID: 163632
		[Token(Token = "0x6027F30")]
		protected abstract MileStonePlayerInfo GetMileStonePlayerInfo();

		// Token: 0x06027F31 RID: 163633
		[Token(Token = "0x6027F31")]
		protected abstract string GetMileStoneToken();

		// Token: 0x06027F32 RID: 163634
		[Token(Token = "0x6027F32")]
		protected abstract string GetSpReward();

		// Token: 0x06027F33 RID: 163635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F33")]
		[Address(RVA = "0x2342700", Offset = "0x2341300", VA = "0x182342700")]
		public void InitInfo()
		{
		}

		// Token: 0x06027F34 RID: 163636
		[Token(Token = "0x6027F34")]
		protected abstract void OnInitInfo();

		// Token: 0x06027F35 RID: 163637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F35")]
		[Address(RVA = "0x2342A50", Offset = "0x2341650", VA = "0x182342A50")]
		protected MileStoneStateBean()
		{
		}

		// Token: 0x040389E0 RID: 231904
		[Token(Token = "0x40389E0")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public List<MileStoneViewModel> viewModelList;

		// Token: 0x040389E1 RID: 231905
		[Token(Token = "0x40389E1")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public int currentStone;

		// Token: 0x040389E2 RID: 231906
		[Token(Token = "0x40389E2")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public string spRewardId;

		// Token: 0x040389E3 RID: 231907
		[Token(Token = "0x40389E3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitInfo;

		// Token: 0x040389E4 RID: 231908
		[Token(Token = "0x40389E4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
