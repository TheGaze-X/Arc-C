using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x0200598D RID: 22925
	[Token(Token = "0x200598D")]
	public class CrisisV2AchievementPageItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060216C0 RID: 136896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60216C0")]
		[Address(RVA = "0x1BBC270", Offset = "0x1BBAE70", VA = "0x181BBC270")]
		public void Render(bool isSelected)
		{
		}

		// Token: 0x060216C1 RID: 136897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60216C1")]
		[Address(RVA = "0x1BBC300", Offset = "0x1BBAF00", VA = "0x181BBC300")]
		public CrisisV2AchievementPageItemView()
		{
		}

		// Token: 0x0402D96C RID: 186732
		[Token(Token = "0x402D96C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelSelected;

		// Token: 0x0402D96D RID: 186733
		[Token(Token = "0x402D96D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelUnselected;

		// Token: 0x0402D96E RID: 186734
		[Token(Token = "0x402D96E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402D96F RID: 186735
		[Token(Token = "0x402D96F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
