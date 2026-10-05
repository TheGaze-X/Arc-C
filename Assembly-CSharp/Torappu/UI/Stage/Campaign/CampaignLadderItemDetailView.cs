using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage.Campaign
{
	// Token: 0x02006A47 RID: 27207
	[Token(Token = "0x2006A47")]
	public class CampaignLadderItemDetailView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06026E3E RID: 159294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E3E")]
		[Address(RVA = "0x21E9400", Offset = "0x21E8000", VA = "0x1821E9400")]
		public void RenderView(LadderItem.Type type, int data)
		{
		}

		// Token: 0x06026E3F RID: 159295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E3F")]
		[Address(RVA = "0x21E9550", Offset = "0x21E8150", VA = "0x1821E9550")]
		public CampaignLadderItemDetailView()
		{
		}

		// Token: 0x04036FEB RID: 225259
		[Token(Token = "0x4036FEB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textVal;

		// Token: 0x04036FEC RID: 225260
		[Token(Token = "0x4036FEC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x04036FED RID: 225261
		[Token(Token = "0x4036FED")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
