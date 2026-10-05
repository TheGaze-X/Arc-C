using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI
{
	// Token: 0x02003816 RID: 14358
	[Token(Token = "0x2003816")]
	public abstract class UIOneshotEffectFloatPanel : MonoBehaviour
	{
		// Token: 0x17003676 RID: 13942
		// (get) Token: 0x06016C58 RID: 93272 RVA: 0x00092E50 File Offset: 0x00091050
		// (set) Token: 0x06016C59 RID: 93273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003676")]
		public bool isShown
		{
			[Token(Token = "0x6016C58")]
			[Address(RVA = "0x4F4E70", Offset = "0x4F3A70", VA = "0x1804F4E70")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6016C59")]
			[Address(RVA = "0xF453F0", Offset = "0xF43FF0", VA = "0x180F453F0")]
			protected set
			{
			}
		}

		// Token: 0x06016C5A RID: 93274 RVA: 0x00092E68 File Offset: 0x00091068
		[Token(Token = "0x6016C5A")]
		[Address(RVA = "0xF45170", Offset = "0xF43D70", VA = "0x180F45170", Slot = "4")]
		public virtual bool ShowIfNot()
		{
			return default(bool);
		}

		// Token: 0x06016C5B RID: 93275 RVA: 0x00092E80 File Offset: 0x00091080
		[Token(Token = "0x6016C5B")]
		[Address(RVA = "0xF45150", Offset = "0xF43D50", VA = "0x180F45150", Slot = "5")]
		public virtual bool FinishIfNot()
		{
			return default(bool);
		}

		// Token: 0x06016C5C RID: 93276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016C5C")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
		protected virtual void OnReset()
		{
		}

		// Token: 0x06016C5D RID: 93277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016C5D")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "7")]
		protected virtual void OnStart()
		{
		}

		// Token: 0x06016C5E RID: 93278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016C5E")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "8")]
		protected virtual void OnFinish()
		{
		}

		// Token: 0x06016C5F RID: 93279
		[Token(Token = "0x6016C5F")]
		protected abstract IEnumerator PlayEffect();

		// Token: 0x06016C60 RID: 93280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016C60")]
		[Address(RVA = "0xF45280", Offset = "0xF43E80", VA = "0x180F45280", Slot = "10")]
		protected virtual void Start()
		{
		}

		// Token: 0x06016C61 RID: 93281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016C61")]
		[Address(RVA = "0xF45330", Offset = "0xF43F30", VA = "0x180F45330")]
		private void _FinishMe()
		{
		}

		// Token: 0x06016C62 RID: 93282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016C62")]
		[Address(RVA = "0xF452B0", Offset = "0xF43EB0", VA = "0x180F452B0")]
		private IEnumerator _EffectCoroutine()
		{
			return null;
		}

		// Token: 0x06016C63 RID: 93283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016C63")]
		[Address(RVA = "0xF453B0", Offset = "0xF43FB0", VA = "0x180F453B0")]
		private void _StopCoroutineIfNot()
		{
		}

		// Token: 0x06016C64 RID: 93284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016C64")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		protected UIOneshotEffectFloatPanel()
		{
		}

		// Token: 0x0401B732 RID: 112434
		[Token(Token = "0x401B732")]
		[FieldOffset(Offset = "0x18")]
		private bool m_isShown;

		// Token: 0x0401B733 RID: 112435
		[Token(Token = "0x401B733")]
		[FieldOffset(Offset = "0x20")]
		private Coroutine m_coroutine;
	}
}
