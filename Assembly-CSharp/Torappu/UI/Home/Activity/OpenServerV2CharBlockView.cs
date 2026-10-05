using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home.Activity
{
	// Token: 0x02004C86 RID: 19590
	[Token(Token = "0x2004C86")]
	public class OpenServerV2CharBlockView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601D5EA RID: 120298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D5EA")]
		[Address(RVA = "0x16EE2F0", Offset = "0x16ECEF0", VA = "0x1816EE2F0")]
		public void Init(int index, Action<int> onClick)
		{
		}

		// Token: 0x0601D5EB RID: 120299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D5EB")]
		[Address(RVA = "0x16EE390", Offset = "0x16ECF90", VA = "0x1816EE390")]
		public void OnClick()
		{
		}

		// Token: 0x0601D5EC RID: 120300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D5EC")]
		[Address(RVA = "0x16EE400", Offset = "0x16ED000", VA = "0x1816EE400")]
		public OpenServerV2CharBlockView()
		{
		}

		// Token: 0x04026A75 RID: 158325
		[Token(Token = "0x4026A75")]
		[FieldOffset(Offset = "0x18")]
		private int m_index;

		// Token: 0x04026A76 RID: 158326
		[Token(Token = "0x4026A76")]
		[FieldOffset(Offset = "0x20")]
		private Action<int> m_onClick;

		// Token: 0x04026A77 RID: 158327
		[Token(Token = "0x4026A77")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04026A78 RID: 158328
		[Token(Token = "0x4026A78")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x04026A79 RID: 158329
		[Token(Token = "0x4026A79")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
