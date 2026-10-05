using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.I18N
{
	// Token: 0x02001624 RID: 5668
	[Token(Token = "0x2001624")]
	[RequireComponent(typeof(Text))]
	public class LocalizeTextContentFormat : MonoBehaviour, IHotfixable
	{
		// Token: 0x060080B0 RID: 32944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080B0")]
		[Address(RVA = "0x28894C0", Offset = "0x28880C0", VA = "0x1828894C0")]
		private void Awake()
		{
		}

		// Token: 0x060080B1 RID: 32945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080B1")]
		[Address(RVA = "0x28896F0", Offset = "0x28882F0", VA = "0x1828896F0")]
		private void OnTextChange()
		{
		}

		// Token: 0x060080B2 RID: 32946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080B2")]
		[Address(RVA = "0x28898E0", Offset = "0x28884E0", VA = "0x1828898E0")]
		public LocalizeTextContentFormat()
		{
		}

		// Token: 0x040081FB RID: 33275
		[Token(Token = "0x40081FB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Tooltip("是否处理空格换行")]
		private bool _noBreakingSpace;

		// Token: 0x040081FC RID: 33276
		[Token(Token = "0x40081FC")]
		[FieldOffset(Offset = "0x20")]
		private Text text;

		// Token: 0x040081FD RID: 33277
		[Token(Token = "0x40081FD")]
		[FieldOffset(Offset = "0x28")]
		private RectTransform rectransform;

		// Token: 0x040081FE RID: 33278
		[Token(Token = "0x40081FE")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string NO_BREAKING_SPACE;

		// Token: 0x040081FF RID: 33279
		[Token(Token = "0x40081FF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x04008200 RID: 33280
		[Token(Token = "0x4008200")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnTextChange;

		// Token: 0x04008201 RID: 33281
		[Token(Token = "0x4008201")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
