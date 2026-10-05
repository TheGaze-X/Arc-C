using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004333 RID: 17203
	[Token(Token = "0x2004333")]
	public class SandboxV2HomeShopEntryView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601A6D9 RID: 108249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A6D9")]
		[Address(RVA = "0x1385E70", Offset = "0x1384A70", VA = "0x181385E70")]
		public void Render(SandboxV2HomeModel model)
		{
		}

		// Token: 0x0601A6DA RID: 108250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A6DA")]
		[Address(RVA = "0x1386070", Offset = "0x1384C70", VA = "0x181386070")]
		public SandboxV2HomeShopEntryView()
		{
		}

		// Token: 0x04021957 RID: 137559
		[Token(Token = "0x4021957")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _txtShopCoinCount;

		// Token: 0x04021958 RID: 137560
		[Token(Token = "0x4021958")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelUpdate;

		// Token: 0x04021959 RID: 137561
		[Token(Token = "0x4021959")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _txtUpdate;

		// Token: 0x0402195A RID: 137562
		[Token(Token = "0x402195A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402195B RID: 137563
		[Token(Token = "0x402195B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
