using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200385D RID: 14429
	[Token(Token = "0x200385D")]
	public class UIDynAvatarSpineAdapter : UISpineHolder.Adapter, IHotfixable
	{
		// Token: 0x06016DA8 RID: 93608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016DA8")]
		[Address(RVA = "0xF3F8F0", Offset = "0xF3E4F0", VA = "0x180F3F8F0")]
		public void UpdateParam(string spineId)
		{
		}

		// Token: 0x06016DA9 RID: 93609 RVA: 0x000934B0 File Offset: 0x000916B0
		[Token(Token = "0x6016DA9")]
		[Address(RVA = "0xF3F780", Offset = "0xF3E380", VA = "0x180F3F780", Slot = "6")]
		public override UISpineHolder.SpineAnimParam GetAnimParam()
		{
			return default(UISpineHolder.SpineAnimParam);
		}

		// Token: 0x06016DAA RID: 93610 RVA: 0x000934C8 File Offset: 0x000916C8
		[Token(Token = "0x6016DAA")]
		[Address(RVA = "0xF3F850", Offset = "0xF3E450", VA = "0x180F3F850", Slot = "4")]
		public override UISpineHolder.SpineID GetSpineID()
		{
			return default(UISpineHolder.SpineID);
		}

		// Token: 0x06016DAB RID: 93611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016DAB")]
		[Address(RVA = "0xF3F970", Offset = "0xF3E570", VA = "0x180F3F970")]
		public UIDynAvatarSpineAdapter()
		{
		}

		// Token: 0x0401B900 RID: 112896
		[Token(Token = "0x401B900")]
		[FieldOffset(Offset = "0x48")]
		private string m_spineId;

		// Token: 0x0401B901 RID: 112897
		[Token(Token = "0x401B901")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateParam;

		// Token: 0x0401B902 RID: 112898
		[Token(Token = "0x401B902")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetAnimParam;

		// Token: 0x0401B903 RID: 112899
		[Token(Token = "0x401B903")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetSpineID;

		// Token: 0x0401B904 RID: 112900
		[Token(Token = "0x401B904")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
