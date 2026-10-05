using System;
using Il2CppDummyDll;
using Torappu.UI.Stage;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006C93 RID: 27795
	[Token(Token = "0x2006C93")]
	public class TemplateActivityResourceBar : MonoBehaviour, IHotfixable
	{
		// Token: 0x06027A7D RID: 162429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A7D")]
		[Address(RVA = "0x22E7BE0", Offset = "0x22E67E0", VA = "0x1822E7BE0")]
		public void Render(IStageSelectHandler handler)
		{
		}

		// Token: 0x06027A7E RID: 162430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A7E")]
		[Address(RVA = "0x22E7C40", Offset = "0x22E6840", VA = "0x1822E7C40")]
		public TemplateActivityResourceBar()
		{
		}

		// Token: 0x04038411 RID: 230417
		[Token(Token = "0x4038411")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04038412 RID: 230418
		[Token(Token = "0x4038412")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
