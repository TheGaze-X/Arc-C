using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Informant
{
	// Token: 0x02004A29 RID: 18985
	[Token(Token = "0x2004A29")]
	public class InformantResultCustomerItemViewModel : IHotfixable
	{
		// Token: 0x0601C8E5 RID: 116965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C8E5")]
		[Address(RVA = "0x1614F00", Offset = "0x1613B00", VA = "0x181614F00")]
		public void LoadData(Act44SideData.Act44SideCustomerData customerData, Act44SideData.Act44SideTagData tagData, Act44SideData.Act44SideConstData constData, PlayerActivity.PlayerAct44SideActivity.PlayerInformantSettle playerData)
		{
		}

		// Token: 0x0601C8E6 RID: 116966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C8E6")]
		[Address(RVA = "0x1615010", Offset = "0x1613C10", VA = "0x181615010")]
		public InformantResultCustomerItemViewModel()
		{
		}

		// Token: 0x04025746 RID: 153414
		[Token(Token = "0x4025746")]
		[FieldOffset(Offset = "0x10")]
		public string customerName;

		// Token: 0x04025747 RID: 153415
		[Token(Token = "0x4025747")]
		[FieldOffset(Offset = "0x18")]
		public string tagName;

		// Token: 0x04025748 RID: 153416
		[Token(Token = "0x4025748")]
		[FieldOffset(Offset = "0x20")]
		public string iconId;

		// Token: 0x04025749 RID: 153417
		[Token(Token = "0x4025749")]
		[FieldOffset(Offset = "0x28")]
		public bool isSp;

		// Token: 0x0402574A RID: 153418
		[Token(Token = "0x402574A")]
		[FieldOffset(Offset = "0x29")]
		public bool isWin;

		// Token: 0x0402574B RID: 153419
		[Token(Token = "0x402574B")]
		[FieldOffset(Offset = "0x2C")]
		public int getCount;

		// Token: 0x0402574C RID: 153420
		[Token(Token = "0x402574C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402574D RID: 153421
		[Token(Token = "0x402574D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
