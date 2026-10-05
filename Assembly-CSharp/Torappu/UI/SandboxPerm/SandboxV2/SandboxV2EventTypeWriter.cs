using System;
using System.Runtime.InteropServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004247 RID: 16967
	[Token(Token = "0x2004247")]
	[RequireComponent(typeof(Text))]
	public class SandboxV2EventTypeWriter : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003E29 RID: 15913
		// (get) Token: 0x0601A26B RID: 107115 RVA: 0x000A0650 File Offset: 0x0009E850
		[Token(Token = "0x17003E29")]
		public bool isTyping
		{
			[Token(Token = "0x601A26B")]
			[Address(RVA = "0x13063E0", Offset = "0x1304FE0", VA = "0x1813063E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601A26C RID: 107116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A26C")]
		[Address(RVA = "0x1305C90", Offset = "0x1304890", VA = "0x181305C90")]
		public void BeginText(string text, float delay = 0f)
		{
		}

		// Token: 0x0601A26D RID: 107117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A26D")]
		[Address(RVA = "0x1305F80", Offset = "0x1304B80", VA = "0x181305F80")]
		public void TryFinish()
		{
		}

		// Token: 0x0601A26E RID: 107118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A26E")]
		[Address(RVA = "0x1305D80", Offset = "0x1304980", VA = "0x181305D80")]
		public void ResetText([Optional] string text)
		{
		}

		// Token: 0x0601A26F RID: 107119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A26F")]
		[Address(RVA = "0x1305E90", Offset = "0x1304A90", VA = "0x181305E90")]
		public void SetColor(Color color)
		{
		}

		// Token: 0x0601A270 RID: 107120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A270")]
		[Address(RVA = "0x1306240", Offset = "0x1304E40", VA = "0x181306240")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A271 RID: 107121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A271")]
		[Address(RVA = "0x1306070", Offset = "0x1304C70", VA = "0x181306070")]
		private void _BeginTextImp(string text, float delay = 0f)
		{
		}

		// Token: 0x0601A272 RID: 107122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A272")]
		[Address(RVA = "0x13062E0", Offset = "0x1304EE0", VA = "0x1813062E0")]
		private void _ResetTweenImp()
		{
		}

		// Token: 0x0601A273 RID: 107123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A273")]
		[Address(RVA = "0x1306370", Offset = "0x1304F70", VA = "0x181306370")]
		public SandboxV2EventTypeWriter()
		{
		}

		// Token: 0x040210A1 RID: 135329
		[Token(Token = "0x40210A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _typeInterval;

		// Token: 0x040210A2 RID: 135330
		[Token(Token = "0x40210A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private bool m_isInited;

		// Token: 0x040210A3 RID: 135331
		[Token(Token = "0x40210A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string m_cachedText;

		// Token: 0x040210A4 RID: 135332
		[Token(Token = "0x40210A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Text m_text;

		// Token: 0x040210A5 RID: 135333
		[Token(Token = "0x40210A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Tween m_textTween;

		// Token: 0x040210A6 RID: 135334
		[Token(Token = "0x40210A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isTyping;

		// Token: 0x040210A7 RID: 135335
		[Token(Token = "0x40210A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_BeginText;

		// Token: 0x040210A8 RID: 135336
		[Token(Token = "0x40210A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_TryFinish;

		// Token: 0x040210A9 RID: 135337
		[Token(Token = "0x40210A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ResetText;

		// Token: 0x040210AA RID: 135338
		[Token(Token = "0x40210AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetColor;

		// Token: 0x040210AB RID: 135339
		[Token(Token = "0x40210AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040210AC RID: 135340
		[Token(Token = "0x40210AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__BeginTextImp;

		// Token: 0x040210AD RID: 135341
		[Token(Token = "0x40210AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ResetTweenImp;

		// Token: 0x040210AE RID: 135342
		[Token(Token = "0x40210AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
