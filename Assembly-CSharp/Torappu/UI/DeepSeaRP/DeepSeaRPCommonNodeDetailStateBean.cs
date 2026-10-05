using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.DeepSeaRP
{
	// Token: 0x0200518F RID: 20879
	[Token(Token = "0x200518F")]
	public class DeepSeaRPCommonNodeDetailStateBean : IStateBean, IHotfixable
	{
		// Token: 0x170047E8 RID: 18408
		// (get) Token: 0x0601EDA7 RID: 126375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170047E8")]
		public string actId
		{
			[Token(Token = "0x601EDA7")]
			[Address(RVA = "0x1897A40", Offset = "0x1896640", VA = "0x181897A40")]
			get
			{
				return null;
			}
		}

		// Token: 0x170047E9 RID: 18409
		// (get) Token: 0x0601EDA8 RID: 126376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170047E9")]
		public DeepSeaRPNodeModel nodeModel
		{
			[Token(Token = "0x601EDA8")]
			[Address(RVA = "0x1897B00", Offset = "0x1896700", VA = "0x181897B00")]
			get
			{
				return null;
			}
		}

		// Token: 0x170047EA RID: 18410
		// (get) Token: 0x0601EDA9 RID: 126377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170047EA")]
		public Act17sideData.EventData lockedEventData
		{
			[Token(Token = "0x601EDA9")]
			[Address(RVA = "0x1897AA0", Offset = "0x18966A0", VA = "0x181897AA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601EDAA RID: 126378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EDAA")]
		[Address(RVA = "0x1897920", Offset = "0x1896520", VA = "0x181897920")]
		public void LoadData(string actId, DeepSeaRPNodeModel nodeModel, Act17sideData.EventData eventData)
		{
		}

		// Token: 0x0601EDAB RID: 126379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EDAB")]
		[Address(RVA = "0x18979E0", Offset = "0x18965E0", VA = "0x1818979E0")]
		public DeepSeaRPCommonNodeDetailStateBean()
		{
		}

		// Token: 0x0402962B RID: 169515
		[Token(Token = "0x402962B")]
		[FieldOffset(Offset = "0x10")]
		private string m_actId;

		// Token: 0x0402962C RID: 169516
		[Token(Token = "0x402962C")]
		[FieldOffset(Offset = "0x18")]
		private DeepSeaRPNodeModel m_nodeModel;

		// Token: 0x0402962D RID: 169517
		[Token(Token = "0x402962D")]
		[FieldOffset(Offset = "0x20")]
		private Act17sideData.EventData m_lockedEventData;

		// Token: 0x0402962E RID: 169518
		[Token(Token = "0x402962E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_actId;

		// Token: 0x0402962F RID: 169519
		[Token(Token = "0x402962F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_nodeModel;

		// Token: 0x04029630 RID: 169520
		[Token(Token = "0x4029630")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_lockedEventData;

		// Token: 0x04029631 RID: 169521
		[Token(Token = "0x4029631")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04029632 RID: 169522
		[Token(Token = "0x4029632")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
