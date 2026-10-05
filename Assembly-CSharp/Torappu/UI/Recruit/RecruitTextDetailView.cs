using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Recruit
{
	// Token: 0x0200474C RID: 18252
	[Token(Token = "0x200474C")]
	public class RecruitTextDetailView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601BA44 RID: 113220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA44")]
		[Address(RVA = "0x1504F50", Offset = "0x1503B50", VA = "0x181504F50")]
		public void Render(GachaDetailData.GachaObject textInfo)
		{
		}

		// Token: 0x0601BA45 RID: 113221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA45")]
		[Address(RVA = "0x1505030", Offset = "0x1503C30", VA = "0x181505030")]
		public RecruitTextDetailView()
		{
		}

		// Token: 0x04023DCB RID: 146891
		[Token(Token = "0x4023DCB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _showText;

		// Token: 0x04023DCC RID: 146892
		[Token(Token = "0x4023DCC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04023DCD RID: 146893
		[Token(Token = "0x4023DCD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
