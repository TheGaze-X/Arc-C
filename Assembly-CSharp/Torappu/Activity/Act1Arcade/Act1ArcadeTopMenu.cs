using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x020079A4 RID: 31140
	[Token(Token = "0x20079A4")]
	public class Act1ArcadeTopMenu : MonoBehaviour, IHotfixable
	{
		// Token: 0x17006674 RID: 26228
		// (get) Token: 0x0602BAEF RID: 178927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006674")]
		public RectTransform backRect
		{
			[Token(Token = "0x602BAEF")]
			[Address(RVA = "0x27A8150", Offset = "0x27A6D50", VA = "0x1827A8150")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602BAF0 RID: 178928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BAF0")]
		[Address(RVA = "0x27A8080", Offset = "0x27A6C80", VA = "0x1827A8080")]
		public void EventOnClickBack()
		{
		}

		// Token: 0x0602BAF1 RID: 178929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BAF1")]
		[Address(RVA = "0x27A80F0", Offset = "0x27A6CF0", VA = "0x1827A80F0")]
		public Act1ArcadeTopMenu()
		{
		}

		// Token: 0x0403F33E RID: 258878
		[Token(Token = "0x403F33E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public RectTransform _backRect;

		// Token: 0x0403F33F RID: 258879
		[Token(Token = "0x403F33F")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public Action onClickBack;

		// Token: 0x0403F340 RID: 258880
		[Token(Token = "0x403F340")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_backRect;

		// Token: 0x0403F341 RID: 258881
		[Token(Token = "0x403F341")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnClickBack;

		// Token: 0x0403F342 RID: 258882
		[Token(Token = "0x403F342")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
