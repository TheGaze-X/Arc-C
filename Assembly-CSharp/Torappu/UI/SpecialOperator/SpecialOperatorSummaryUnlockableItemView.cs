using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SpecialOperator
{
	// Token: 0x02003E6B RID: 15979
	[Token(Token = "0x2003E6B")]
	public class SpecialOperatorSummaryUnlockableItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018D81 RID: 101761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D81")]
		[Address(RVA = "0x117D080", Offset = "0x117BC80", VA = "0x18117D080")]
		public void Render(bool isUnlock)
		{
		}

		// Token: 0x06018D82 RID: 101762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D82")]
		[Address(RVA = "0x117D120", Offset = "0x117BD20", VA = "0x18117D120")]
		public SpecialOperatorSummaryUnlockableItemView()
		{
		}

		// Token: 0x0401E8FF RID: 125183
		[Token(Token = "0x401E8FF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _alphaLock;

		// Token: 0x0401E900 RID: 125184
		[Token(Token = "0x401E900")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgTalent;

		// Token: 0x0401E901 RID: 125185
		[Token(Token = "0x401E901")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401E902 RID: 125186
		[Token(Token = "0x401E902")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
