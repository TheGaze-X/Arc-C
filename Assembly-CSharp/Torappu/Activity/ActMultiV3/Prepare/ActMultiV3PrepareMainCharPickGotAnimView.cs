using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3.Prepare
{
	// Token: 0x02007058 RID: 28760
	[Token(Token = "0x2007058")]
	public class ActMultiV3PrepareMainCharPickGotAnimView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06028D7A RID: 167290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D7A")]
		[Address(RVA = "0x2433FC0", Offset = "0x2432BC0", VA = "0x182433FC0")]
		public void PlayGotAnim(ActMultiV3PrepareMainCharCardModel model)
		{
		}

		// Token: 0x06028D7B RID: 167291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D7B")]
		[Address(RVA = "0x2434120", Offset = "0x2432D20", VA = "0x182434120")]
		public ActMultiV3PrepareMainCharPickGotAnimView()
		{
		}

		// Token: 0x0403A410 RID: 238608
		[Token(Token = "0x403A410")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation _anim;

		// Token: 0x0403A411 RID: 238609
		[Token(Token = "0x403A411")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ActMultiV3PrepareMainCharCard _cardPrefab;

		// Token: 0x0403A412 RID: 238610
		[Token(Token = "0x403A412")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _cardContainer;

		// Token: 0x0403A413 RID: 238611
		[Token(Token = "0x403A413")]
		[FieldOffset(Offset = "0x38")]
		private ActMultiV3PrepareMainCharCard m_card;

		// Token: 0x0403A414 RID: 238612
		[Token(Token = "0x403A414")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_PlayGotAnim;

		// Token: 0x0403A415 RID: 238613
		[Token(Token = "0x403A415")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
