using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.EnemyHandBook
{
	// Token: 0x02004F2B RID: 20267
	[Token(Token = "0x2004F2B")]
	public class EnemyHandbookDetailDescItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601E316 RID: 123670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E316")]
		[Address(RVA = "0x17EEAB0", Offset = "0x17ED6B0", VA = "0x1817EEAB0")]
		public void Render(EnemyHandBookData.Abilty textRes)
		{
		}

		// Token: 0x0601E317 RID: 123671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E317")]
		[Address(RVA = "0x17EEC30", Offset = "0x17ED830", VA = "0x1817EEC30")]
		public EnemyHandbookDetailDescItem()
		{
		}

		// Token: 0x04028387 RID: 164743
		[Token(Token = "0x4028387")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _titlePart;

		// Token: 0x04028388 RID: 164744
		[Token(Token = "0x4028388")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _detailPart;

		// Token: 0x04028389 RID: 164745
		[Token(Token = "0x4028389")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _titleText;

		// Token: 0x0402838A RID: 164746
		[Token(Token = "0x402838A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _detailText;

		// Token: 0x0402838B RID: 164747
		[Token(Token = "0x402838B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _commonIcon;

		// Token: 0x0402838C RID: 164748
		[Token(Token = "0x402838C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _titleIcon;

		// Token: 0x0402838D RID: 164749
		[Token(Token = "0x402838D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402838E RID: 164750
		[Token(Token = "0x402838E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
