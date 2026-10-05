using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006DE3 RID: 28131
	[Token(Token = "0x2006DE3")]
	public class ActVecBreakV2DefenseBattleFinishCharCardView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060280DC RID: 164060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60280DC")]
		[Address(RVA = "0x234CE60", Offset = "0x234BA60", VA = "0x18234CE60")]
		public void Render(ActVecBreakV2BattleFinishCharModel charModel, bool isLocked)
		{
		}

		// Token: 0x060280DD RID: 164061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60280DD")]
		[Address(RVA = "0x234CF80", Offset = "0x234BB80", VA = "0x18234CF80")]
		public ActVecBreakV2DefenseBattleFinishCharCardView()
		{
		}

		// Token: 0x04038CE6 RID: 232678
		[Token(Token = "0x4038CE6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CommonCharCardView _panelNormal;

		// Token: 0x04038CE7 RID: 232679
		[Token(Token = "0x4038CE7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelEmpty;

		// Token: 0x04038CE8 RID: 232680
		[Token(Token = "0x4038CE8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x04038CE9 RID: 232681
		[Token(Token = "0x4038CE9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04038CEA RID: 232682
		[Token(Token = "0x4038CEA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
