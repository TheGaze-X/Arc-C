using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020036E9 RID: 14057
	[Token(Token = "0x20036E9")]
	public class UITweenColor : BasicTween<Color>
	{
		// Token: 0x0601652A RID: 91434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601652A")]
		[Address(RVA = "0xED50C0", Offset = "0xED3CC0", VA = "0x180ED50C0", Slot = "4")]
		protected override void OnInit()
		{
		}

		// Token: 0x0601652B RID: 91435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601652B")]
		[Address(RVA = "0xED4F20", Offset = "0xED3B20", VA = "0x180ED4F20", Slot = "7")]
		protected override Tweener ConstructTweener(Color fromValue, Color toValue, float duration)
		{
			return null;
		}

		// Token: 0x0601652C RID: 91436 RVA: 0x000908E8 File Offset: 0x0008EAE8
		[Token(Token = "0x601652C")]
		[Address(RVA = "0xED5010", Offset = "0xED3C10", VA = "0x180ED5010", Slot = "5")]
		protected override Color GetTweenValue()
		{
			return default(Color);
		}

		// Token: 0x0601652D RID: 91437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601652D")]
		[Address(RVA = "0xED5140", Offset = "0xED3D40", VA = "0x180ED5140", Slot = "6")]
		protected override void SetTweenValue(Color val)
		{
		}

		// Token: 0x0601652E RID: 91438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601652E")]
		[Address(RVA = "0xED51F0", Offset = "0xED3DF0", VA = "0x180ED51F0")]
		public UITweenColor()
		{
		}

		// Token: 0x0401AD93 RID: 109971
		[Token(Token = "0x401AD93")]
		[FieldOffset(Offset = "0x68")]
		private Graphic m_targetGraphic;

		// Token: 0x0401AD94 RID: 109972
		[Token(Token = "0x401AD94")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0401AD95 RID: 109973
		[Token(Token = "0x401AD95")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ConstructTweener;

		// Token: 0x0401AD96 RID: 109974
		[Token(Token = "0x401AD96")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetTweenValue;

		// Token: 0x0401AD97 RID: 109975
		[Token(Token = "0x401AD97")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetTweenValue;

		// Token: 0x0401AD98 RID: 109976
		[Token(Token = "0x401AD98")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
