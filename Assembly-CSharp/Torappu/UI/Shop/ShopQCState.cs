using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B8B RID: 23435
	[Token(Token = "0x2005B8B")]
	public class ShopQCState : ShopCommonState
	{
		// Token: 0x06022025 RID: 139301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022025")]
		[Address(RVA = "0x1C73620", Offset = "0x1C72220", VA = "0x181C73620", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06022026 RID: 139302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022026")]
		[Address(RVA = "0x1C738B0", Offset = "0x1C724B0", VA = "0x181C738B0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06022027 RID: 139303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022027")]
		[Address(RVA = "0x1C734A0", Offset = "0x1C720A0", VA = "0x181C734A0")]
		public void ApplyDetailState(QCShopDetailShopEnum type)
		{
		}

		// Token: 0x06022028 RID: 139304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022028")]
		[Address(RVA = "0x1C73AC0", Offset = "0x1C726C0", VA = "0x181C73AC0")]
		public void OpenConverter()
		{
		}

		// Token: 0x06022029 RID: 139305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022029")]
		[Address(RVA = "0x1C739B0", Offset = "0x1C725B0", VA = "0x181C739B0")]
		public void OpenClassicConverter()
		{
		}

		// Token: 0x0602202A RID: 139306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602202A")]
		[Address(RVA = "0x1C73750", Offset = "0x1C72350", VA = "0x181C73750")]
		public void OnQCInfoClick()
		{
		}

		// Token: 0x0602202B RID: 139307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602202B")]
		[Address(RVA = "0x1C73BD0", Offset = "0x1C727D0", VA = "0x181C73BD0")]
		private void _ApplyDetailState(QCShopDetailShopEnum type)
		{
		}

		// Token: 0x0602202C RID: 139308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602202C")]
		[Address(RVA = "0x1C735C0", Offset = "0x1C721C0", VA = "0x181C735C0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602202D RID: 139309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602202D")]
		[Address(RVA = "0x1C73D40", Offset = "0x1C72940", VA = "0x181C73D40")]
		public ShopQCState()
		{
		}

		// Token: 0x0602202E RID: 139310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602202E")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0602202F RID: 139311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602202F")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0402E9E2 RID: 190946
		[Token(Token = "0x402E9E2")]
		public const QCShopDetailShopEnum DEFAULT_STATE = QCShopDetailShopEnum.LOW;

		// Token: 0x0402E9E3 RID: 190947
		[Token(Token = "0x402E9E3")]
		public const int DEFAULT_LQC_GROUP = -1;

		// Token: 0x0402E9E4 RID: 190948
		[Token(Token = "0x402E9E4")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		public QCShopDetailShopEnum currentState;

		// Token: 0x0402E9E5 RID: 190949
		[Token(Token = "0x402E9E5")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private QCShopController _controller;

		// Token: 0x0402E9E6 RID: 190950
		[Token(Token = "0x402E9E6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402E9E7 RID: 190951
		[Token(Token = "0x402E9E7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0402E9E8 RID: 190952
		[Token(Token = "0x402E9E8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ApplyDetailState;

		// Token: 0x0402E9E9 RID: 190953
		[Token(Token = "0x402E9E9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OpenConverter;

		// Token: 0x0402E9EA RID: 190954
		[Token(Token = "0x402E9EA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OpenClassicConverter;

		// Token: 0x0402E9EB RID: 190955
		[Token(Token = "0x402E9EB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnQCInfoClick;

		// Token: 0x0402E9EC RID: 190956
		[Token(Token = "0x402E9EC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ApplyDetailState;

		// Token: 0x0402E9ED RID: 190957
		[Token(Token = "0x402E9ED")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402E9EE RID: 190958
		[Token(Token = "0x402E9EE")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
