using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006DE2 RID: 28130
	[Token(Token = "0x2006DE2")]
	public class ActVecBreakV2DefenseBattleFinishCharAvatarView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060280DA RID: 164058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60280DA")]
		[Address(RVA = "0x234CCD0", Offset = "0x234B8D0", VA = "0x18234CCD0")]
		public void Render(string avatarId, bool isLocked)
		{
		}

		// Token: 0x060280DB RID: 164059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60280DB")]
		[Address(RVA = "0x234CE00", Offset = "0x234BA00", VA = "0x18234CE00")]
		public ActVecBreakV2DefenseBattleFinishCharAvatarView()
		{
		}

		// Token: 0x04038CE0 RID: 232672
		[Token(Token = "0x4038CE0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelNormal;

		// Token: 0x04038CE1 RID: 232673
		[Token(Token = "0x4038CE1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _avatarIcon;

		// Token: 0x04038CE2 RID: 232674
		[Token(Token = "0x4038CE2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelEmpty;

		// Token: 0x04038CE3 RID: 232675
		[Token(Token = "0x4038CE3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelLock;

		// Token: 0x04038CE4 RID: 232676
		[Token(Token = "0x4038CE4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04038CE5 RID: 232677
		[Token(Token = "0x4038CE5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
