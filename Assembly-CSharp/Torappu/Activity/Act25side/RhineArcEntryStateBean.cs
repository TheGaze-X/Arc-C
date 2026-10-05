using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x020074E8 RID: 29928
	[Token(Token = "0x20074E8")]
	public class RhineArcEntryStateBean : MonoBehaviour, IStateBean, IHotfixable, IDataBindWrapper
	{
		// Token: 0x0602A2F8 RID: 172792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A2F8")]
		[Address(RVA = "0x25D5820", Offset = "0x25D4420", VA = "0x1825D5820")]
		public void LoadData(string actId, RhineArcPage.EnterType enterType, string selectAreaId)
		{
		}

		// Token: 0x0602A2F9 RID: 172793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A2F9")]
		[Address(RVA = "0x25D63A0", Offset = "0x25D4FA0", VA = "0x1825D63A0")]
		public void UpdateAllNewMark(string actId)
		{
		}

		// Token: 0x0602A2FA RID: 172794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A2FA")]
		[Address(RVA = "0x25D6640", Offset = "0x25D5240", VA = "0x1825D6640")]
		public void UpdateKeyItemNewMark(string itemId, string actId)
		{
		}

		// Token: 0x0602A2FB RID: 172795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A2FB")]
		[Address(RVA = "0x25D68A0", Offset = "0x25D54A0", VA = "0x1825D68A0")]
		public RhineArcEntryStateBean()
		{
		}

		// Token: 0x0403C9D2 RID: 248274
		[Token(Token = "0x403C9D2")]
		[FieldOffset(Offset = "0x18")]
		public RhineArcProperty property;

		// Token: 0x0403C9D3 RID: 248275
		[Token(Token = "0x403C9D3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403C9D4 RID: 248276
		[Token(Token = "0x403C9D4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateAllNewMark;

		// Token: 0x0403C9D5 RID: 248277
		[Token(Token = "0x403C9D5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateKeyItemNewMark;

		// Token: 0x0403C9D6 RID: 248278
		[Token(Token = "0x403C9D6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
