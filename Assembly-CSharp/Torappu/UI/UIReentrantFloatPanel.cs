using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003829 RID: 14377
	[Token(Token = "0x2003829")]
	public class UIReentrantFloatPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003681 RID: 13953
		// (get) Token: 0x06016CAE RID: 93358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003681")]
		protected ReentrantFloatOpt reentrant
		{
			[Token(Token = "0x6016CAE")]
			[Address(RVA = "0xF4CB90", Offset = "0xF4B790", VA = "0x180F4CB90")]
			get
			{
				return null;
			}
		}

		// Token: 0x06016CAF RID: 93359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016CAF")]
		[Address(RVA = "0xF4C6D0", Offset = "0xF4B2D0", VA = "0x180F4C6D0", Slot = "4")]
		protected virtual IEnumerator ShowEffect()
		{
			return null;
		}

		// Token: 0x06016CB0 RID: 93360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016CB0")]
		[Address(RVA = "0xF4C520", Offset = "0xF4B120", VA = "0x180F4C520", Slot = "5")]
		protected virtual IEnumerator HideEffect()
		{
			return null;
		}

		// Token: 0x06016CB1 RID: 93361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016CB1")]
		[Address(RVA = "0xF4C810", Offset = "0xF4B410", VA = "0x180F4C810", Slot = "6")]
		protected virtual void Start()
		{
		}

		// Token: 0x06016CB2 RID: 93362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016CB2")]
		[Address(RVA = "0xF4CA10", Offset = "0xF4B610", VA = "0x180F4CA10")]
		private void _EnableGameObject()
		{
		}

		// Token: 0x06016CB3 RID: 93363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016CB3")]
		[Address(RVA = "0xF4C970", Offset = "0xF4B570", VA = "0x180F4C970")]
		private void _DisableGameObject()
		{
		}

		// Token: 0x17003682 RID: 13954
		// (get) Token: 0x06016CB4 RID: 93364 RVA: 0x00092F88 File Offset: 0x00091188
		[Token(Token = "0x17003682")]
		public bool isShown
		{
			[Token(Token = "0x6016CB4")]
			[Address(RVA = "0xF4CAE0", Offset = "0xF4B6E0", VA = "0x180F4CAE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06016CB5 RID: 93365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016CB5")]
		[Address(RVA = "0xF4C760", Offset = "0xF4B360", VA = "0x180F4C760")]
		public void Show()
		{
		}

		// Token: 0x06016CB6 RID: 93366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016CB6")]
		[Address(RVA = "0xF4C660", Offset = "0xF4B260", VA = "0x180F4C660")]
		public IEnumerator ShowCoroutine()
		{
			return null;
		}

		// Token: 0x06016CB7 RID: 93367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016CB7")]
		[Address(RVA = "0xF4C5B0", Offset = "0xF4B1B0", VA = "0x180F4C5B0")]
		public void Hide()
		{
		}

		// Token: 0x06016CB8 RID: 93368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016CB8")]
		[Address(RVA = "0xF4C4B0", Offset = "0xF4B0B0", VA = "0x180F4C4B0")]
		public IEnumerator HideCoroutine()
		{
			return null;
		}

		// Token: 0x06016CB9 RID: 93369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016CB9")]
		[Address(RVA = "0xF4CA80", Offset = "0xF4B680", VA = "0x180F4CA80")]
		public UIReentrantFloatPanel()
		{
		}

		// Token: 0x0401B7D2 RID: 112594
		[Token(Token = "0x401B7D2")]
		[FieldOffset(Offset = "0x18")]
		private ReentrantFloatOpt m_internalOpt;

		// Token: 0x0401B7D3 RID: 112595
		[Token(Token = "0x401B7D3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_reentrant;

		// Token: 0x0401B7D4 RID: 112596
		[Token(Token = "0x401B7D4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ShowEffect;

		// Token: 0x0401B7D5 RID: 112597
		[Token(Token = "0x401B7D5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_HideEffect;

		// Token: 0x0401B7D6 RID: 112598
		[Token(Token = "0x401B7D6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0401B7D7 RID: 112599
		[Token(Token = "0x401B7D7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__EnableGameObject;

		// Token: 0x0401B7D8 RID: 112600
		[Token(Token = "0x401B7D8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__DisableGameObject;

		// Token: 0x0401B7D9 RID: 112601
		[Token(Token = "0x401B7D9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_isShown;

		// Token: 0x0401B7DA RID: 112602
		[Token(Token = "0x401B7DA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x0401B7DB RID: 112603
		[Token(Token = "0x401B7DB")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x0401B7DC RID: 112604
		[Token(Token = "0x401B7DC")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x0401B7DD RID: 112605
		[Token(Token = "0x401B7DD")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x0401B7DE RID: 112606
		[Token(Token = "0x401B7DE")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
