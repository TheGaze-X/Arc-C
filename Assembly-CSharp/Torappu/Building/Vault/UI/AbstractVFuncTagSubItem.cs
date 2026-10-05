using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Building.Vault.UI
{
	// Token: 0x02001A85 RID: 6789
	[Token(Token = "0x2001A85")]
	public abstract class AbstractVFuncTagSubItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600AB33 RID: 43827 RVA: 0x00042330 File Offset: 0x00040530
		[Token(Token = "0x600AB33")]
		[Address(RVA = "0x32509C0", Offset = "0x324F5C0", VA = "0x1832509C0")]
		public bool MatchObject(VCharacter vChar)
		{
			return default(bool);
		}

		// Token: 0x0600AB34 RID: 43828
		[Token(Token = "0x600AB34")]
		protected abstract bool OnMatchObject(VCharacter vChar);

		// Token: 0x0600AB35 RID: 43829
		[Token(Token = "0x600AB35")]
		public abstract void RenderItem(BuildingCharModel charModel, bool isIconVisible);

		// Token: 0x0600AB36 RID: 43830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB36")]
		[Address(RVA = "0x3250A90", Offset = "0x324F690", VA = "0x183250A90")]
		protected AbstractVFuncTagSubItem()
		{
		}

		// Token: 0x0400A37F RID: 41855
		[Token(Token = "0x400A37F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_MatchObject;

		// Token: 0x0400A380 RID: 41856
		[Token(Token = "0x400A380")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
