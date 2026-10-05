using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006D64 RID: 28004
	[Token(Token = "0x2006D64")]
	[RequireComponent(typeof(UIPage))]
	public class ActivityPageAssetHolder : ActivityAssetHolder
	{
		// Token: 0x06027E8D RID: 163469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027E8D")]
		[Address(RVA = "0x233C870", Offset = "0x233B470", VA = "0x18233C870", Slot = "4")]
		public override string[] GetAssetIdList()
		{
			return null;
		}

		// Token: 0x06027E8E RID: 163470 RVA: 0x000CFF00 File Offset: 0x000CE100
		[Token(Token = "0x6027E8E")]
		[Address(RVA = "0x233C9C0", Offset = "0x233B5C0", VA = "0x18233C9C0", Slot = "7")]
		protected override bool LockAspect(string curAspect, Action<string> setAspect)
		{
			return default(bool);
		}

		// Token: 0x06027E8F RID: 163471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027E8F")]
		[Address(RVA = "0x233CAA0", Offset = "0x233B6A0", VA = "0x18233CAA0")]
		public ActivityPageAssetHolder()
		{
		}

		// Token: 0x06027E90 RID: 163472 RVA: 0x000CFF18 File Offset: 0x000CE118
		[Token(Token = "0x6027E90")]
		[Address(RVA = "0x1140F60", Offset = "0x113FB60", VA = "0x181140F60")]
		private bool <>xLuaBaseProxy_LockAspect(string P0, Action<string> P1)
		{
			return default(bool);
		}

		// Token: 0x04038919 RID: 231705
		[Token(Token = "0x4038919")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _pageName;

		// Token: 0x0403891A RID: 231706
		[Token(Token = "0x403891A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetAssetIdList;

		// Token: 0x0403891B RID: 231707
		[Token(Token = "0x403891B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LockAspect;

		// Token: 0x0403891C RID: 231708
		[Token(Token = "0x403891C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
