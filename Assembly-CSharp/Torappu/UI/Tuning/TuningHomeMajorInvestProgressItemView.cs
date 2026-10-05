using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003CA3 RID: 15523
	[Token(Token = "0x2003CA3")]
	public class TuningHomeMajorInvestProgressItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060183A3 RID: 99235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183A3")]
		[Address(RVA = "0x10B86F0", Offset = "0x10B72F0", VA = "0x1810B86F0")]
		public void Render(bool isComplete)
		{
		}

		// Token: 0x060183A4 RID: 99236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183A4")]
		[Address(RVA = "0x10B8780", Offset = "0x10B7380", VA = "0x1810B8780")]
		public TuningHomeMajorInvestProgressItemView()
		{
		}

		// Token: 0x0401D863 RID: 120931
		[Token(Token = "0x401D863")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelComplete;

		// Token: 0x0401D864 RID: 120932
		[Token(Token = "0x401D864")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelUncomplete;

		// Token: 0x0401D865 RID: 120933
		[Token(Token = "0x401D865")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401D866 RID: 120934
		[Token(Token = "0x401D866")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
