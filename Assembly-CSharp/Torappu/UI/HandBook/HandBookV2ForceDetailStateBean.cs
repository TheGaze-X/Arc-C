using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x0200671E RID: 26398
	[Token(Token = "0x200671E")]
	public class HandBookV2ForceDetailStateBean : MonoBehaviour, IStateBean, IHotfixable
	{
		// Token: 0x170059AD RID: 22957
		// (get) Token: 0x06025DF3 RID: 155123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170059AD")]
		public HandBookV2GroupCharViewModel charViewModel
		{
			[Token(Token = "0x6025DF3")]
			[Address(RVA = "0x20D3650", Offset = "0x20D2250", VA = "0x1820D3650")]
			get
			{
				return null;
			}
		}

		// Token: 0x06025DF4 RID: 155124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025DF4")]
		[Address(RVA = "0x20D3480", Offset = "0x20D2080", VA = "0x1820D3480")]
		public void SetCharViewModel(UIPage page, HandBookV2GroupCharViewModel value)
		{
		}

		// Token: 0x06025DF5 RID: 155125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025DF5")]
		[Address(RVA = "0x20D35F0", Offset = "0x20D21F0", VA = "0x1820D35F0")]
		public HandBookV2ForceDetailStateBean()
		{
		}

		// Token: 0x0403544D RID: 218189
		[Token(Token = "0x403544D")]
		[FieldOffset(Offset = "0x18")]
		private HandBookV2GroupCharViewModel m_charViewModel;

		// Token: 0x0403544E RID: 218190
		[Token(Token = "0x403544E")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public Vector3 pos;

		// Token: 0x0403544F RID: 218191
		[Token(Token = "0x403544F")]
		[FieldOffset(Offset = "0x2C")]
		[NonSerialized]
		public Vector3 scale;

		// Token: 0x04035450 RID: 218192
		[Token(Token = "0x4035450")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_charViewModel;

		// Token: 0x04035451 RID: 218193
		[Token(Token = "0x4035451")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetCharViewModel;

		// Token: 0x04035452 RID: 218194
		[Token(Token = "0x4035452")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
