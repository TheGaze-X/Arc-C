using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020067F9 RID: 26617
	[Token(Token = "0x20067F9")]
	public class MainlineResHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602625A RID: 156250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602625A")]
		[Address(RVA = "0x2130E00", Offset = "0x212FA00", VA = "0x182130E00")]
		public Sprite GetHomeSprite()
		{
			return null;
		}

		// Token: 0x0602625B RID: 156251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602625B")]
		[Address(RVA = "0x2130DA0", Offset = "0x212F9A0", VA = "0x182130DA0")]
		public Sprite GetHomeSpriteMutli()
		{
			return null;
		}

		// Token: 0x0602625C RID: 156252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602625C")]
		[Address(RVA = "0x2130E60", Offset = "0x212FA60", VA = "0x182130E60")]
		public MainlineResHolder()
		{
		}

		// Token: 0x04035B9B RID: 220059
		[Token(Token = "0x4035B9B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Sprite _homeSprite;

		// Token: 0x04035B9C RID: 220060
		[Token(Token = "0x4035B9C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite _homeSpriteMulti;

		// Token: 0x04035B9D RID: 220061
		[Token(Token = "0x4035B9D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetHomeSprite;

		// Token: 0x04035B9E RID: 220062
		[Token(Token = "0x4035B9E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetHomeSpriteMutli;

		// Token: 0x04035B9F RID: 220063
		[Token(Token = "0x4035B9F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
