using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.Dialog
{
	// Token: 0x02002828 RID: 10280
	[Token(Token = "0x2002828")]
	public class DialogSandboxUIPluginIconPair : MonoBehaviour, IHotfixable
	{
		// Token: 0x060111D6 RID: 70102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60111D6")]
		[Address(RVA = "0x90ACA0", Offset = "0x9098A0", VA = "0x18090ACA0")]
		public void Render(string itemId)
		{
		}

		// Token: 0x060111D7 RID: 70103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60111D7")]
		[Address(RVA = "0x90AFA0", Offset = "0x909BA0", VA = "0x18090AFA0")]
		private void _UpdateVal()
		{
		}

		// Token: 0x060111D8 RID: 70104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60111D8")]
		[Address(RVA = "0x90AF40", Offset = "0x909B40", VA = "0x18090AF40")]
		private void Update()
		{
		}

		// Token: 0x060111D9 RID: 70105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60111D9")]
		[Address(RVA = "0x90B090", Offset = "0x909C90", VA = "0x18090B090")]
		public DialogSandboxUIPluginIconPair()
		{
		}

		// Token: 0x040132E3 RID: 78563
		[Token(Token = "0x40132E3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _iconVal;

		// Token: 0x040132E4 RID: 78564
		[Token(Token = "0x40132E4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _image;

		// Token: 0x040132E5 RID: 78565
		[Token(Token = "0x40132E5")]
		[FieldOffset(Offset = "0x28")]
		private int m_lastVal;

		// Token: 0x040132E6 RID: 78566
		[Token(Token = "0x40132E6")]
		[FieldOffset(Offset = "0x30")]
		private string m_itemId;

		// Token: 0x040132E7 RID: 78567
		[Token(Token = "0x40132E7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040132E8 RID: 78568
		[Token(Token = "0x40132E8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__UpdateVal;

		// Token: 0x040132E9 RID: 78569
		[Token(Token = "0x40132E9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x040132EA RID: 78570
		[Token(Token = "0x40132EA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
