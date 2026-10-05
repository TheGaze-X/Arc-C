using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x0200735D RID: 29533
	[Token(Token = "0x200735D")]
	public class Act42D0ChallengeMissionItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029C46 RID: 171078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029C46")]
		[Address(RVA = "0x2555210", Offset = "0x2553E10", VA = "0x182555210")]
		public void Render(Act42D0ChallengeMissionItemViewModel data)
		{
		}

		// Token: 0x06029C47 RID: 171079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029C47")]
		[Address(RVA = "0x25553F0", Offset = "0x2553FF0", VA = "0x1825553F0")]
		public Act42D0ChallengeMissionItemView()
		{
		}

		// Token: 0x0403BC8C RID: 244876
		[Token(Token = "0x403BC8C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelEmpty;

		// Token: 0x0403BC8D RID: 244877
		[Token(Token = "0x403BC8D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelNotEmpty;

		// Token: 0x0403BC8E RID: 244878
		[Token(Token = "0x403BC8E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _maskCompleted;

		// Token: 0x0403BC8F RID: 244879
		[Token(Token = "0x403BC8F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _imageCompleted;

		// Token: 0x0403BC90 RID: 244880
		[Token(Token = "0x403BC90")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _description;

		// Token: 0x0403BC91 RID: 244881
		[Token(Token = "0x403BC91")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _milestoneCount;

		// Token: 0x0403BC92 RID: 244882
		[Token(Token = "0x403BC92")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403BC93 RID: 244883
		[Token(Token = "0x403BC93")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
