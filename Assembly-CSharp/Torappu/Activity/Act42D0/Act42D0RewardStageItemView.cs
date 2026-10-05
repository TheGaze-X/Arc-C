using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x020073A7 RID: 29607
	[Token(Token = "0x20073A7")]
	public class Act42D0RewardStageItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029D8E RID: 171406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D8E")]
		[Address(RVA = "0x2573CE0", Offset = "0x25728E0", VA = "0x182573CE0")]
		public void Render(Act42D0RewardStageItemViewModel viewModel)
		{
		}

		// Token: 0x06029D8F RID: 171407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D8F")]
		[Address(RVA = "0x2573E10", Offset = "0x2572A10", VA = "0x182573E10")]
		public Act42D0RewardStageItemView()
		{
		}

		// Token: 0x0403BF72 RID: 245618
		[Token(Token = "0x403BF72")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _milestoneCount;

		// Token: 0x0403BF73 RID: 245619
		[Token(Token = "0x403BF73")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelIsGained;

		// Token: 0x0403BF74 RID: 245620
		[Token(Token = "0x403BF74")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color _normalColor;

		// Token: 0x0403BF75 RID: 245621
		[Token(Token = "0x403BF75")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Color _gainedColor;

		// Token: 0x0403BF76 RID: 245622
		[Token(Token = "0x403BF76")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelNoInfo;

		// Token: 0x0403BF77 RID: 245623
		[Token(Token = "0x403BF77")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelInfo;

		// Token: 0x0403BF78 RID: 245624
		[Token(Token = "0x403BF78")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403BF79 RID: 245625
		[Token(Token = "0x403BF79")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
