using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006D65 RID: 28005
	[Token(Token = "0x2006D65")]
	public class ActivitySpriteAssetHolder : ActivityAssetHolder
	{
		// Token: 0x06027E91 RID: 163473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027E91")]
		[Address(RVA = "0x233CB40", Offset = "0x233B740", VA = "0x18233CB40", Slot = "4")]
		public override string[] GetAssetIdList()
		{
			return null;
		}

		// Token: 0x06027E92 RID: 163474 RVA: 0x000CFF30 File Offset: 0x000CE130
		[Token(Token = "0x6027E92")]
		[Address(RVA = "0x233CCF0", Offset = "0x233B8F0", VA = "0x18233CCF0")]
		public bool TryFindSprite(string id, out Sprite sprite)
		{
			return default(bool);
		}

		// Token: 0x06027E93 RID: 163475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027E93")]
		[Address(RVA = "0x233CE50", Offset = "0x233BA50", VA = "0x18233CE50")]
		public ActivitySpriteAssetHolder()
		{
		}

		// Token: 0x0403891D RID: 231709
		[Token(Token = "0x403891D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Sprite[] _sprites;

		// Token: 0x0403891E RID: 231710
		[Token(Token = "0x403891E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetAssetIdList;

		// Token: 0x0403891F RID: 231711
		[Token(Token = "0x403891F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_TryFindSprite;

		// Token: 0x04038920 RID: 231712
		[Token(Token = "0x4038920")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
