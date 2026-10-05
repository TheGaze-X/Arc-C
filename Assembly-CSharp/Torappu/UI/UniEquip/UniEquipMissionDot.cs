using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.UniEquip
{
	// Token: 0x02003C30 RID: 15408
	[Token(Token = "0x2003C30")]
	public class UniEquipMissionDot : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018187 RID: 98695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018187")]
		[Address(RVA = "0x10985C0", Offset = "0x10971C0", VA = "0x1810985C0")]
		public void Render(bool isFinish)
		{
		}

		// Token: 0x06018188 RID: 98696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018188")]
		[Address(RVA = "0x1098640", Offset = "0x1097240", VA = "0x181098640")]
		public UniEquipMissionDot()
		{
		}

		// Token: 0x0401D3E6 RID: 119782
		[Token(Token = "0x401D3E6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TwoStateToggle _toggle;

		// Token: 0x0401D3E7 RID: 119783
		[Token(Token = "0x401D3E7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401D3E8 RID: 119784
		[Token(Token = "0x401D3E8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
