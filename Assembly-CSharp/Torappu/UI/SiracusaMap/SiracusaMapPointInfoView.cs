using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F2E RID: 16174
	[Token(Token = "0x2003F2E")]
	public class SiracusaMapPointInfoView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06019204 RID: 102916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019204")]
		[Address(RVA = "0x11D7EA0", Offset = "0x11D6AA0", VA = "0x1811D7EA0")]
		public void Render(string name, string desc)
		{
		}

		// Token: 0x06019205 RID: 102917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019205")]
		[Address(RVA = "0x11D7FA0", Offset = "0x11D6BA0", VA = "0x1811D7FA0")]
		public SiracusaMapPointInfoView()
		{
		}

		// Token: 0x0401F1C1 RID: 127425
		[Token(Token = "0x401F1C1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textPointName;

		// Token: 0x0401F1C2 RID: 127426
		[Token(Token = "0x401F1C2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textPointDesc;

		// Token: 0x0401F1C3 RID: 127427
		[Token(Token = "0x401F1C3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401F1C4 RID: 127428
		[Token(Token = "0x401F1C4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
