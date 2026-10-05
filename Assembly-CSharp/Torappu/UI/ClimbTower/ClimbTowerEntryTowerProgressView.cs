using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005C52 RID: 23634
	[Token(Token = "0x2005C52")]
	public class ClimbTowerEntryTowerProgressView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060223F9 RID: 140281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60223F9")]
		[Address(RVA = "0x1CA7DB0", Offset = "0x1CA69B0", VA = "0x181CA7DB0")]
		public void Render(int current, int total)
		{
		}

		// Token: 0x060223FA RID: 140282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60223FA")]
		[Address(RVA = "0x1CA7F30", Offset = "0x1CA6B30", VA = "0x181CA7F30")]
		public ClimbTowerEntryTowerProgressView()
		{
		}

		// Token: 0x0402F017 RID: 192535
		[Token(Token = "0x402F017")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textStage;

		// Token: 0x0402F018 RID: 192536
		[Token(Token = "0x402F018")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Slider _progress;

		// Token: 0x0402F019 RID: 192537
		[Token(Token = "0x402F019")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402F01A RID: 192538
		[Token(Token = "0x402F01A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
