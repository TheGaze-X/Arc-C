using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Building.DIY.Test
{
	// Token: 0x02001900 RID: 6400
	[Token(Token = "0x2001900")]
	public class InteractCheck : SingletonMonoBehaviour<InteractCheck>, ISingletonNotAutoCreate
	{
		// Token: 0x0600A145 RID: 41285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A145")]
		[Address(RVA = "0x31CB490", Offset = "0x31CA090", VA = "0x1831CB490")]
		public InteractCheck()
		{
		}

		// Token: 0x04009785 RID: 38789
		[Token(Token = "0x4009785")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _characterScale;

		// Token: 0x04009786 RID: 38790
		[Token(Token = "0x4009786")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _characterDefaultPosition;

		// Token: 0x04009787 RID: 38791
		[Token(Token = "0x4009787")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		public string characterFolderPath;

		// Token: 0x04009788 RID: 38792
		[Token(Token = "0x4009788")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		public string furnitureFolderPath;

		// Token: 0x04009789 RID: 38793
		[Token(Token = "0x4009789")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _gridMark;

		// Token: 0x0400978A RID: 38794
		[Token(Token = "0x400978A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Renderer _gridRenderer;

		// Token: 0x0400978B RID: 38795
		[Token(Token = "0x400978B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _listWidth;

		// Token: 0x0400978C RID: 38796
		[Token(Token = "0x400978C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
