using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.Squad
{
	// Token: 0x02003E0B RID: 15883
	[Token(Token = "0x2003E0B")]
	public struct SquadCardViewModel : IHotfixable
	{
		// Token: 0x0401E4ED RID: 124141
		[Token(Token = "0x401E4ED")]
		[FieldOffset(Offset = "0x0")]
		public CharacterCardViewModel cardModel;

		// Token: 0x0401E4EE RID: 124142
		[Token(Token = "0x401E4EE")]
		[FieldOffset(Offset = "0x8")]
		public bool isEmptyNotClickable;

		// Token: 0x0401E4EF RID: 124143
		[Token(Token = "0x401E4EF")]
		[FieldOffset(Offset = "0x10")]
		public GameObject banPrefab;

		// Token: 0x0401E4F0 RID: 124144
		[Token(Token = "0x401E4F0")]
		[FieldOffset(Offset = "0x18")]
		public bool isBannedInSquad;
	}
}
