using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act9D0
{
	// Token: 0x0200718C RID: 29068
	[Token(Token = "0x200718C")]
	public class Act9D0BannableObject : MonoBehaviour, IHotfixable
	{
		// Token: 0x170061AA RID: 25002
		// (get) Token: 0x0602941C RID: 168988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170061AA")]
		public string key
		{
			[Token(Token = "0x602941C")]
			[Address(RVA = "0x2491F70", Offset = "0x2490B70", VA = "0x182491F70")]
			get
			{
				return null;
			}
		}

		// Token: 0x170061AB RID: 25003
		// (get) Token: 0x0602941D RID: 168989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170061AB")]
		public List<Sprite> sprites
		{
			[Token(Token = "0x602941D")]
			[Address(RVA = "0x2491FD0", Offset = "0x2490BD0", VA = "0x182491FD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602941E RID: 168990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602941E")]
		[Address(RVA = "0x2491F10", Offset = "0x2490B10", VA = "0x182491F10")]
		public Act9D0BannableObject()
		{
		}

		// Token: 0x0403AECA RID: 241354
		[Token(Token = "0x403AECA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _key;

		// Token: 0x0403AECB RID: 241355
		[Token(Token = "0x403AECB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<Sprite> _sprites;

		// Token: 0x0403AECC RID: 241356
		[Token(Token = "0x403AECC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_key;

		// Token: 0x0403AECD RID: 241357
		[Token(Token = "0x403AECD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_sprites;

		// Token: 0x0403AECE RID: 241358
		[Token(Token = "0x403AECE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
