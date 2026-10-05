using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B6D RID: 23405
	[Token(Token = "0x2005B6D")]
	public class ShopSocialStateBean : MonoBehaviour, IStateBean, IHotfixable
	{
		// Token: 0x06021FBA RID: 139194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021FBA")]
		[Address(RVA = "0x1C76740", Offset = "0x1C75340", VA = "0x181C76740")]
		public void InitSocialGetInfo()
		{
		}

		// Token: 0x06021FBB RID: 139195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021FBB")]
		[Address(RVA = "0x1C76430", Offset = "0x1C75030", VA = "0x181C76430")]
		public void ApplyData(GetSocialGoodListResponse response)
		{
		}

		// Token: 0x06021FBC RID: 139196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021FBC")]
		[Address(RVA = "0x1C767F0", Offset = "0x1C753F0", VA = "0x181C767F0")]
		public ShopSocialStateBean()
		{
		}

		// Token: 0x0402E931 RID: 190769
		[Token(Token = "0x402E931")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public long refreshTime;

		// Token: 0x0402E932 RID: 190770
		[Token(Token = "0x402E932")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public List<ShopCreditViewModel> shopCreditList;

		// Token: 0x0402E933 RID: 190771
		[Token(Token = "0x402E933")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public Dictionary<string, int> charUnlockState;

		// Token: 0x0402E934 RID: 190772
		[Token(Token = "0x402E934")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public bool ableToGet;

		// Token: 0x0402E935 RID: 190773
		[Token(Token = "0x402E935")]
		[FieldOffset(Offset = "0x34")]
		[NonSerialized]
		public int socialFromAssist;

		// Token: 0x0402E936 RID: 190774
		[Token(Token = "0x402E936")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		public int socialFromDorm;

		// Token: 0x0402E937 RID: 190775
		[Token(Token = "0x402E937")]
		[FieldOffset(Offset = "0x3C")]
		[NonSerialized]
		public int creditUsed;

		// Token: 0x0402E938 RID: 190776
		[Token(Token = "0x402E938")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public string creditGroup;

		// Token: 0x0402E939 RID: 190777
		[Token(Token = "0x402E939")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public SocialGetCrisisV2ViewModel socialCrisisV2Model;

		// Token: 0x0402E93A RID: 190778
		[Token(Token = "0x402E93A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitSocialGetInfo;

		// Token: 0x0402E93B RID: 190779
		[Token(Token = "0x402E93B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x0402E93C RID: 190780
		[Token(Token = "0x402E93C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
