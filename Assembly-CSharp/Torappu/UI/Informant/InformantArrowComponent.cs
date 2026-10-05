using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Informant
{
	// Token: 0x02004A2A RID: 18986
	[Token(Token = "0x2004A2A")]
	public class InformantArrowComponent : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601C8E7 RID: 116967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C8E7")]
		[Address(RVA = "0x1612ED0", Offset = "0x1611AD0", VA = "0x181612ED0")]
		public void Render(int arrowNumber)
		{
		}

		// Token: 0x0601C8E8 RID: 116968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C8E8")]
		[Address(RVA = "0x1613010", Offset = "0x1611C10", VA = "0x181613010")]
		public InformantArrowComponent()
		{
		}

		// Token: 0x0402574E RID: 153422
		[Token(Token = "0x402574E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TwoStateToggle _positiveToggle;

		// Token: 0x0402574F RID: 153423
		[Token(Token = "0x402574F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject[] _positiveArrows;

		// Token: 0x04025750 RID: 153424
		[Token(Token = "0x4025750")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject[] _negativeArrows;

		// Token: 0x04025751 RID: 153425
		[Token(Token = "0x4025751")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04025752 RID: 153426
		[Token(Token = "0x4025752")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
