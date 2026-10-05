using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.Meeting
{
	// Token: 0x02001D60 RID: 7520
	[Token(Token = "0x2001D60")]
	public class MeetingAutoEquipCluesView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600B9C3 RID: 47555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9C3")]
		[Address(RVA = "0x3376C60", Offset = "0x3375860", VA = "0x183376C60")]
		public void Render(int num)
		{
		}

		// Token: 0x0600B9C4 RID: 47556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9C4")]
		[Address(RVA = "0x3376D40", Offset = "0x3375940", VA = "0x183376D40")]
		public MeetingAutoEquipCluesView()
		{
		}

		// Token: 0x0400B872 RID: 47218
		[Token(Token = "0x400B872")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textNum;

		// Token: 0x0400B873 RID: 47219
		[Token(Token = "0x400B873")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelActive;

		// Token: 0x0400B874 RID: 47220
		[Token(Token = "0x400B874")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelInActive;

		// Token: 0x0400B875 RID: 47221
		[Token(Token = "0x400B875")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0400B876 RID: 47222
		[Token(Token = "0x400B876")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
