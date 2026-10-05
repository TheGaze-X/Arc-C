using System;
using System.Collections;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI
{
	// Token: 0x02003A38 RID: 14904
	[Token(Token = "0x2003A38")]
	public class UIToast : MonoBehaviour
	{
		// Token: 0x1700385C RID: 14428
		// (get) Token: 0x0601785C RID: 96348 RVA: 0x00096ED0 File Offset: 0x000950D0
		[Token(Token = "0x1700385C")]
		public bool isShown
		{
			[Token(Token = "0x601785C")]
			[Address(RVA = "0xFD66E0", Offset = "0xFD52E0", VA = "0x180FD66E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700385D RID: 14429
		// (get) Token: 0x0601785D RID: 96349 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601785E RID: 96350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700385D")]
		public string text
		{
			[Token(Token = "0x601785D")]
			[Address(RVA = "0xD23170", Offset = "0xD21D70", VA = "0x180D23170")]
			get
			{
				return null;
			}
			[Token(Token = "0x601785E")]
			[Address(RVA = "0xD231C0", Offset = "0xD21DC0", VA = "0x180D231C0")]
			set
			{
			}
		}

		// Token: 0x0601785F RID: 96351 RVA: 0x00096EE8 File Offset: 0x000950E8
		[Token(Token = "0x601785F")]
		[Address(RVA = "0xFD61A0", Offset = "0xFD4DA0", VA = "0x180FD61A0")]
		public bool Show(Action finishCallback)
		{
			return default(bool);
		}

		// Token: 0x06017860 RID: 96352 RVA: 0x00096F00 File Offset: 0x00095100
		[Token(Token = "0x6017860")]
		[Address(RVA = "0xFD6410", Offset = "0xFD5010", VA = "0x180FD6410")]
		public bool Show()
		{
			return default(bool);
		}

		// Token: 0x06017861 RID: 96353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017861")]
		[Address(RVA = "0xFD6640", Offset = "0xFD5240", VA = "0x180FD6640")]
		private static IEnumerator _LocalDurationCoroutine(Action callback, float duration)
		{
			return null;
		}

		// Token: 0x06017862 RID: 96354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017862")]
		[Address(RVA = "0xFD64B0", Offset = "0xFD50B0", VA = "0x180FD64B0")]
		[ReflectMethod]
		private void _Hide()
		{
		}

		// Token: 0x06017863 RID: 96355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017863")]
		[Address(RVA = "0xFD66D0", Offset = "0xFD52D0", VA = "0x180FD66D0")]
		public UIToast()
		{
		}

		// Token: 0x0401C67C RID: 116348
		[Token(Token = "0x401C67C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textContent;

		// Token: 0x0401C67D RID: 116349
		[Token(Token = "0x401C67D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAnimationLocation _animShow;

		// Token: 0x0401C67E RID: 116350
		[Token(Token = "0x401C67E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _animHide;

		// Token: 0x0401C67F RID: 116351
		[Token(Token = "0x401C67F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Tooltip("After how many seconds should the toast auto hide")]
		private float _showDuration;

		// Token: 0x0401C680 RID: 116352
		[Token(Token = "0x401C680")]
		[FieldOffset(Offset = "0x48")]
		private Tween m_showTween;

		// Token: 0x0401C681 RID: 116353
		[Token(Token = "0x401C681")]
		[FieldOffset(Offset = "0x50")]
		private Tween m_hideTween;

		// Token: 0x0401C682 RID: 116354
		[Token(Token = "0x401C682")]
		[FieldOffset(Offset = "0x58")]
		private Action m_toastFinishCallback;
	}
}
