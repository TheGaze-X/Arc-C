using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.TemplateMission
{
	// Token: 0x02003DA0 RID: 15776
	[Token(Token = "0x2003DA0")]
	public class TemplateMissionCustomResHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018882 RID: 100482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018882")]
		[Address(RVA = "0x1112540", Offset = "0x1111140", VA = "0x181112540")]
		public Sprite GetTitleImg()
		{
			return null;
		}

		// Token: 0x06018883 RID: 100483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018883")]
		[Address(RVA = "0x11123B0", Offset = "0x1110FB0", VA = "0x1811123B0")]
		public Sprite GetBgImg()
		{
			return null;
		}

		// Token: 0x06018884 RID: 100484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018884")]
		[Address(RVA = "0x1112410", Offset = "0x1111010", VA = "0x181112410")]
		public Sprite GetCoinImg()
		{
			return null;
		}

		// Token: 0x06018885 RID: 100485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018885")]
		[Address(RVA = "0x1112470", Offset = "0x1111070", VA = "0x181112470")]
		public Sprite GetPicRewardImg()
		{
			return null;
		}

		// Token: 0x06018886 RID: 100486 RVA: 0x0009AA70 File Offset: 0x00098C70
		[Token(Token = "0x6018886")]
		[Address(RVA = "0x11124D0", Offset = "0x11110D0", VA = "0x1811124D0")]
		public Vector2 GetPicRewardOffset()
		{
			return default(Vector2);
		}

		// Token: 0x06018887 RID: 100487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018887")]
		[Address(RVA = "0x11125A0", Offset = "0x11111A0", VA = "0x1811125A0")]
		public TemplateMissionCustomResHolder()
		{
		}

		// Token: 0x0401E13D RID: 123197
		[Token(Token = "0x401E13D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Sprite _titleImg;

		// Token: 0x0401E13E RID: 123198
		[Token(Token = "0x401E13E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite _bgImg;

		// Token: 0x0401E13F RID: 123199
		[Token(Token = "0x401E13F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Sprite _coinImg;

		// Token: 0x0401E140 RID: 123200
		[Token(Token = "0x401E140")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Sprite _picRewardImg;

		// Token: 0x0401E141 RID: 123201
		[Token(Token = "0x401E141")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Vector2 _picRewardOffset;

		// Token: 0x0401E142 RID: 123202
		[Token(Token = "0x401E142")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetTitleImg;

		// Token: 0x0401E143 RID: 123203
		[Token(Token = "0x401E143")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetBgImg;

		// Token: 0x0401E144 RID: 123204
		[Token(Token = "0x401E144")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetCoinImg;

		// Token: 0x0401E145 RID: 123205
		[Token(Token = "0x401E145")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetPicRewardImg;

		// Token: 0x0401E146 RID: 123206
		[Token(Token = "0x401E146")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetPicRewardOffset;

		// Token: 0x0401E147 RID: 123207
		[Token(Token = "0x401E147")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
