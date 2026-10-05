using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI
{
	// Token: 0x02001B43 RID: 6979
	[Token(Token = "0x2001B43")]
	public class BuildingStaticIconLoader : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600AF81 RID: 44929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF81")]
		[Address(RVA = "0x32A66E0", Offset = "0x32A52E0", VA = "0x1832A66E0")]
		private void OnEnable()
		{
		}

		// Token: 0x0600AF82 RID: 44930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF82")]
		[Address(RVA = "0x32A68A0", Offset = "0x32A54A0", VA = "0x1832A68A0")]
		public BuildingStaticIconLoader()
		{
		}

		// Token: 0x0400A92F RID: 43311
		[Token(Token = "0x400A92F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _image;

		// Token: 0x0400A930 RID: 43312
		[Token(Token = "0x400A930")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BuildingStaticIconHub.IconType _iconType;

		// Token: 0x0400A931 RID: 43313
		[Token(Token = "0x400A931")]
		[FieldOffset(Offset = "0x28")]
		private Sprite m_icon;

		// Token: 0x0400A932 RID: 43314
		[Token(Token = "0x400A932")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0400A933 RID: 43315
		[Token(Token = "0x400A933")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
