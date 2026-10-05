using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004AF6 RID: 19190
	[Token(Token = "0x2004AF6")]
	public class HomeCharRotationPresetListViewModel : IHotfixable
	{
		// Token: 0x0601CD2C RID: 118060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD2C")]
		[Address(RVA = "0x1643580", Offset = "0x1642180", VA = "0x181643580")]
		public void LoadData()
		{
		}

		// Token: 0x0601CD2D RID: 118061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD2D")]
		[Address(RVA = "0x1643A70", Offset = "0x1642670", VA = "0x181643A70")]
		public HomeCharRotationPresetListViewModel()
		{
		}

		// Token: 0x04025D3C RID: 154940
		[Token(Token = "0x4025D3C")]
		[FieldOffset(Offset = "0x10")]
		public ListDict<string, HomeCharRotationPresetItemViewModel> presetItemList;

		// Token: 0x04025D3D RID: 154941
		[Token(Token = "0x4025D3D")]
		[FieldOffset(Offset = "0x18")]
		public string currPresetInstId;

		// Token: 0x04025D3E RID: 154942
		[Token(Token = "0x4025D3E")]
		[FieldOffset(Offset = "0x20")]
		public int maxPresetNum;

		// Token: 0x04025D3F RID: 154943
		[Token(Token = "0x4025D3F")]
		[FieldOffset(Offset = "0x24")]
		public int createPresetSeqNum;

		// Token: 0x04025D40 RID: 154944
		[Token(Token = "0x4025D40")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04025D41 RID: 154945
		[Token(Token = "0x4025D41")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
