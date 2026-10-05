using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003CDD RID: 15581
	[Token(Token = "0x2003CDD")]
	public class TuningProductSlotEyeView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060184AB RID: 99499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60184AB")]
		[Address(RVA = "0x10CC700", Offset = "0x10CB300", VA = "0x1810CC700")]
		public void Render(bool isShow)
		{
		}

		// Token: 0x060184AC RID: 99500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60184AC")]
		[Address(RVA = "0x10CC9A0", Offset = "0x10CB5A0", VA = "0x1810CC9A0")]
		public void ResetStatus(bool isShow)
		{
		}

		// Token: 0x060184AD RID: 99501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60184AD")]
		[Address(RVA = "0x10CCAA0", Offset = "0x10CB6A0", VA = "0x1810CCAA0")]
		public TuningProductSlotEyeView()
		{
		}

		// Token: 0x0401DA9E RID: 121502
		[Token(Token = "0x401DA9E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TuningProductEyeItemView _eyeItemPrefab;

		// Token: 0x0401DA9F RID: 121503
		[Token(Token = "0x401DA9F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _content;

		// Token: 0x0401DAA0 RID: 121504
		[Token(Token = "0x401DAA0")]
		[FieldOffset(Offset = "0x28")]
		private TuningProductEyeItemView m_eyeView;

		// Token: 0x0401DAA1 RID: 121505
		[Token(Token = "0x401DAA1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401DAA2 RID: 121506
		[Token(Token = "0x401DAA2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ResetStatus;

		// Token: 0x0401DAA3 RID: 121507
		[Token(Token = "0x401DAA3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
