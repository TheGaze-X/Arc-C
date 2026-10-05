using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Home.Activity
{
	// Token: 0x02004C97 RID: 19607
	[Token(Token = "0x2004C97")]
	public class OpenServerV2ChainLoginViewModel : IHotfixable
	{
		// Token: 0x0601D62B RID: 120363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D62B")]
		[Address(RVA = "0x16ED680", Offset = "0x16EC280", VA = "0x1816ED680")]
		public void LoadData(OpenServerData openServerData, OpenServerScheduleItem groupData)
		{
		}

		// Token: 0x0601D62C RID: 120364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D62C")]
		[Address(RVA = "0x16ED900", Offset = "0x16EC500", VA = "0x1816ED900")]
		public void UpdateStatusByPlayerData()
		{
		}

		// Token: 0x0601D62D RID: 120365 RVA: 0x000AB558 File Offset: 0x000A9758
		[Token(Token = "0x601D62D")]
		[Address(RVA = "0x16ED620", Offset = "0x16EC220", VA = "0x1816ED620")]
		public bool CheckAvailable()
		{
			return default(bool);
		}

		// Token: 0x0601D62E RID: 120366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D62E")]
		[Address(RVA = "0x16EDB00", Offset = "0x16EC700", VA = "0x1816EDB00")]
		public OpenServerV2ChainLoginViewModel()
		{
		}

		// Token: 0x04026AFB RID: 158459
		[Token(Token = "0x4026AFB")]
		[FieldOffset(Offset = "0x10")]
		public string desc;

		// Token: 0x04026AFC RID: 158460
		[Token(Token = "0x4026AFC")]
		[FieldOffset(Offset = "0x18")]
		public string bkgImgId;

		// Token: 0x04026AFD RID: 158461
		[Token(Token = "0x4026AFD")]
		[FieldOffset(Offset = "0x20")]
		public List<OpenServerV2ChainLoginItemData> items;

		// Token: 0x04026AFE RID: 158462
		[Token(Token = "0x4026AFE")]
		[FieldOffset(Offset = "0x28")]
		public List<string> displayChars;

		// Token: 0x04026AFF RID: 158463
		[Token(Token = "0x4026AFF")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isAvailable;

		// Token: 0x04026B00 RID: 158464
		[Token(Token = "0x4026B00")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04026B01 RID: 158465
		[Token(Token = "0x4026B01")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateStatusByPlayerData;

		// Token: 0x04026B02 RID: 158466
		[Token(Token = "0x4026B02")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckAvailable;

		// Token: 0x04026B03 RID: 158467
		[Token(Token = "0x4026B03")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
