using System;
using DG.Tweening;
using DG.Tweening.Core;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.DynTargetTween
{
	// Token: 0x02000192 RID: 402
	[Token(Token = "0x2000192")]
	public class CanvasGroupAlphaTweener : UISwitchTween.ITweenProgress, IHotfixable
	{
		// Token: 0x0600098D RID: 2445 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600098D")]
		[Address(RVA = "0x554DA80", Offset = "0x554C680", VA = "0x18554DA80")]
		public Tween CreateTween(float from, float to, float duration)
		{
			return null;
		}

		// Token: 0x0600098E RID: 2446 RVA: 0x000074B4 File Offset: 0x000056B4
		[Token(Token = "0x600098E")]
		[Address(RVA = "0x554DC50", Offset = "0x554C850", VA = "0x18554DC50", Slot = "4")]
		public float GetCurrPos()
		{
			return 0f;
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x000074CC File Offset: 0x000056CC
		[Token(Token = "0x600098F")]
		[Address(RVA = "0x554DCB0", Offset = "0x554C8B0", VA = "0x18554DCB0")]
		private float _Getter()
		{
			return 0f;
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000990")]
		[Address(RVA = "0x554DD10", Offset = "0x554C910", VA = "0x18554DD10")]
		private void _Setter(float val)
		{
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000991")]
		[Address(RVA = "0x554DE30", Offset = "0x554CA30", VA = "0x18554DE30")]
		public CanvasGroupAlphaTweener()
		{
		}

		// Token: 0x04000906 RID: 2310
		[Token(Token = "0x4000906")]
		[FieldOffset(Offset = "0x10")]
		private float m_from;

		// Token: 0x04000907 RID: 2311
		[Token(Token = "0x4000907")]
		[FieldOffset(Offset = "0x14")]
		private float m_to;

		// Token: 0x04000908 RID: 2312
		[Token(Token = "0x4000908")]
		[FieldOffset(Offset = "0x18")]
		private DOGetter<float> m_getter;

		// Token: 0x04000909 RID: 2313
		[Token(Token = "0x4000909")]
		[FieldOffset(Offset = "0x20")]
		private DOSetter<float> m_setter;

		// Token: 0x0400090A RID: 2314
		[Token(Token = "0x400090A")]
		[FieldOffset(Offset = "0x28")]
		public RefTuple<CanvasGroup> targets;

		// Token: 0x0400090B RID: 2315
		[Token(Token = "0x400090B")]
		[FieldOffset(Offset = "0x30")]
		public float current;

		// Token: 0x0400090C RID: 2316
		[Token(Token = "0x400090C")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate213 __Hotfix0_CreateTween;

		// Token: 0x0400090D RID: 2317
		[Token(Token = "0x400090D")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate23 __Hotfix0_GetCurrPos;

		// Token: 0x0400090E RID: 2318
		[Token(Token = "0x400090E")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate23 __Hotfix0__Getter;

		// Token: 0x0400090F RID: 2319
		[Token(Token = "0x400090F")]
		[FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate24 __Hotfix0__Setter;

		// Token: 0x04000910 RID: 2320
		[Token(Token = "0x4000910")]
		[FieldOffset(Offset = "0x20")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;
	}
}
