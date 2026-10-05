using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004F93 RID: 20371
	[Token(Token = "0x2004F93")]
	public class EnemyDuelEntryRewardFormItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601E499 RID: 124057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E499")]
		[Address(RVA = "0x17FD420", Offset = "0x17FC020", VA = "0x1817FD420")]
		public void Render(string up, string down)
		{
		}

		// Token: 0x0601E49A RID: 124058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E49A")]
		[Address(RVA = "0x17FD520", Offset = "0x17FC120", VA = "0x1817FD520")]
		public EnemyDuelEntryRewardFormItemView()
		{
		}

		// Token: 0x040286C8 RID: 165576
		[Token(Token = "0x40286C8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _up;

		// Token: 0x040286C9 RID: 165577
		[Token(Token = "0x40286C9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _down;

		// Token: 0x040286CA RID: 165578
		[Token(Token = "0x40286CA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040286CB RID: 165579
		[Token(Token = "0x40286CB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
