using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.AVG;
using UnityEngine;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B37 RID: 23351
	[Token(Token = "0x2005B37")]
	public class ShopAVGAdapter : ExecutorComponent
	{
		// Token: 0x06021E75 RID: 138869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021E75")]
		[Address(RVA = "0x1C5F860", Offset = "0x1C5E460", VA = "0x181C5F860", Slot = "8")]
		public override Dictionary<string, ExecutorComponent.Executor> GetExecutors()
		{
			return null;
		}

		// Token: 0x06021E76 RID: 138870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021E76")]
		[Address(RVA = "0x1C5F9F0", Offset = "0x1C5E5F0", VA = "0x181C5F9F0", Slot = "9")]
		public override Dictionary<string, ExecutorComponent.SignalReceiver> GetSignalReceivers()
		{
			return null;
		}

		// Token: 0x06021E77 RID: 138871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E77")]
		[Address(RVA = "0x1C5FBC0", Offset = "0x1C5E7C0", VA = "0x181C5FBC0", Slot = "7")]
		public override void OnReset()
		{
		}

		// Token: 0x06021E78 RID: 138872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E78")]
		[Address(RVA = "0x1C5F7F0", Offset = "0x1C5E3F0", VA = "0x181C5F7F0", Slot = "12")]
		protected override void ForceCommandEnd()
		{
		}

		// Token: 0x06021E79 RID: 138873 RVA: 0x000BBB78 File Offset: 0x000B9D78
		[Token(Token = "0x6021E79")]
		[Address(RVA = "0x1C5FD00", Offset = "0x1C5E900", VA = "0x181C5FD00")]
		private bool _ExecuteSwitchShopTopTab(Command command)
		{
			return default(bool);
		}

		// Token: 0x06021E7A RID: 138874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E7A")]
		[Address(RVA = "0x1C5FE90", Offset = "0x1C5EA90", VA = "0x181C5FE90")]
		private void _ReceiveSwitchShopTopTabSignal(Command command)
		{
		}

		// Token: 0x06021E7B RID: 138875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E7B")]
		[Address(RVA = "0x1C5FC30", Offset = "0x1C5E830", VA = "0x181C5FC30")]
		private void Start()
		{
		}

		// Token: 0x06021E7C RID: 138876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E7C")]
		[Address(RVA = "0x1C5FB10", Offset = "0x1C5E710", VA = "0x181C5FB10")]
		private void OnDestroy()
		{
		}

		// Token: 0x06021E7D RID: 138877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E7D")]
		[Address(RVA = "0x1C5FF80", Offset = "0x1C5EB80", VA = "0x181C5FF80")]
		public ShopAVGAdapter()
		{
		}

		// Token: 0x06021E7E RID: 138878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021E7E")]
		[Address(RVA = "0x1C5FCE0", Offset = "0x1C5E8E0", VA = "0x181C5FCE0")]
		private Dictionary<string, ExecutorComponent.SignalReceiver> <>xLuaBaseProxy_GetSignalReceivers()
		{
			return null;
		}

		// Token: 0x06021E7F RID: 138879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E7F")]
		[Address(RVA = "0x1C5FCF0", Offset = "0x1C5E8F0", VA = "0x181C5FCF0")]
		private void <>xLuaBaseProxy_OnReset()
		{
		}

		// Token: 0x0402E780 RID: 190336
		[Token(Token = "0x402E780")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ShopStateItemContainer _container;

		// Token: 0x0402E781 RID: 190337
		[Token(Token = "0x402E781")]
		[FieldOffset(Offset = "0x58")]
		private string m_waitForSignal;

		// Token: 0x0402E782 RID: 190338
		[Token(Token = "0x402E782")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetExecutors;

		// Token: 0x0402E783 RID: 190339
		[Token(Token = "0x402E783")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetSignalReceivers;

		// Token: 0x0402E784 RID: 190340
		[Token(Token = "0x402E784")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x0402E785 RID: 190341
		[Token(Token = "0x402E785")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ForceCommandEnd;

		// Token: 0x0402E786 RID: 190342
		[Token(Token = "0x402E786")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ExecuteSwitchShopTopTab;

		// Token: 0x0402E787 RID: 190343
		[Token(Token = "0x402E787")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ReceiveSwitchShopTopTabSignal;

		// Token: 0x0402E788 RID: 190344
		[Token(Token = "0x402E788")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0402E789 RID: 190345
		[Token(Token = "0x402E789")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0402E78A RID: 190346
		[Token(Token = "0x402E78A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
