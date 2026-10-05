using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Informant
{
	// Token: 0x02004A18 RID: 18968
	[Token(Token = "0x2004A18")]
	public class InformantMilestoneGrandRewardView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601C899 RID: 116889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C899")]
		[Address(RVA = "0x15FDEC0", Offset = "0x15FCAC0", VA = "0x1815FDEC0")]
		public void Render(InformantMilestoneGroupViewModel.InformantMilestoneDisplayRewardModel model)
		{
		}

		// Token: 0x0601C89A RID: 116890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C89A")]
		[Address(RVA = "0x15FDFE0", Offset = "0x15FCBE0", VA = "0x1815FDFE0")]
		public InformantMilestoneGrandRewardView()
		{
		}

		// Token: 0x040256C6 RID: 153286
		[Token(Token = "0x40256C6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textName;

		// Token: 0x040256C7 RID: 153287
		[Token(Token = "0x40256C7")]
		[FieldOffset(Offset = "0x20")]
		[FormerlySerializedAs("_textLevel")]
		[SerializeField]
		private Text _textPoint;

		// Token: 0x040256C8 RID: 153288
		[Token(Token = "0x40256C8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040256C9 RID: 153289
		[Token(Token = "0x40256C9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
