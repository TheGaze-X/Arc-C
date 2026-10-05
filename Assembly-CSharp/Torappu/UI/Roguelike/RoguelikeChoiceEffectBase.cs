using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020051A6 RID: 20902
	[Token(Token = "0x20051A6")]
	public abstract class RoguelikeChoiceEffectBase : MonoBehaviour, IHotfixable
	{
		// Token: 0x170047F4 RID: 18420
		// (get) Token: 0x0601EE06 RID: 126470 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601EE07 RID: 126471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170047F4")]
		public UIPage bindPage
		{
			[Token(Token = "0x601EE06")]
			[Address(RVA = "0x18A0230", Offset = "0x189EE30", VA = "0x1818A0230")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x601EE07")]
			[Address(RVA = "0x18A0290", Offset = "0x189EE90", VA = "0x1818A0290")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601EE08 RID: 126472
		[Token(Token = "0x601EE08")]
		public abstract void SetChoiceBgEffectVisible(bool isActive, string assetName);

		// Token: 0x0601EE09 RID: 126473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EE09")]
		[Address(RVA = "0x18A01D0", Offset = "0x189EDD0", VA = "0x1818A01D0")]
		protected RoguelikeChoiceEffectBase()
		{
		}

		// Token: 0x040296CA RID: 169674
		[Token(Token = "0x40296CA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected UIDynImage _choiceDynBg;

		// Token: 0x040296CC RID: 169676
		[Token(Token = "0x40296CC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_bindPage;

		// Token: 0x040296CD RID: 169677
		[Token(Token = "0x40296CD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_bindPage;

		// Token: 0x040296CE RID: 169678
		[Token(Token = "0x40296CE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
