using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x02007611 RID: 30225
	[Token(Token = "0x2007611")]
	public class Act24sideStageRankItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602A8DB RID: 174299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A8DB")]
		[Address(RVA = "0x26621E0", Offset = "0x2660DE0", VA = "0x1826621E0")]
		public void Render(bool isComplete, bool isHard, bool isHighlight)
		{
		}

		// Token: 0x0602A8DC RID: 174300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A8DC")]
		[Address(RVA = "0x26622C0", Offset = "0x2660EC0", VA = "0x1826622C0")]
		public Act24sideStageRankItemView()
		{
		}

		// Token: 0x0403D430 RID: 250928
		[Token(Token = "0x403D430")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _incompleteGo;

		// Token: 0x0403D431 RID: 250929
		[Token(Token = "0x403D431")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _normalCompleteGo;

		// Token: 0x0403D432 RID: 250930
		[Token(Token = "0x403D432")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _hardCompleteGo;

		// Token: 0x0403D433 RID: 250931
		[Token(Token = "0x403D433")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _hardHighlightCompleteGo;

		// Token: 0x0403D434 RID: 250932
		[Token(Token = "0x403D434")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403D435 RID: 250933
		[Token(Token = "0x403D435")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
