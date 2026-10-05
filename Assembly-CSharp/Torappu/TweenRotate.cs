using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x02000594 RID: 1428
	[Token(Token = "0x2000594")]
	public class TweenRotate : BasicTween<Vector3>
	{
		// Token: 0x06005C39 RID: 23609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C39")]
		[Address(RVA = "0x1CFC860", Offset = "0x1CFB460", VA = "0x181CFC860", Slot = "4")]
		protected override void OnInit()
		{
		}

		// Token: 0x06005C3A RID: 23610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C3A")]
		[Address(RVA = "0x1CFC630", Offset = "0x1CFB230", VA = "0x181CFC630", Slot = "7")]
		protected override Tweener ConstructTweener(Vector3 fromValue, Vector3 toValue, float duration)
		{
			return null;
		}

		// Token: 0x06005C3B RID: 23611 RVA: 0x0002F1D8 File Offset: 0x0002D3D8
		[Token(Token = "0x6005C3B")]
		[Address(RVA = "0x1CFC750", Offset = "0x1CFB350", VA = "0x181CFC750", Slot = "5")]
		protected override Vector3 GetTweenValue()
		{
			return default(Vector3);
		}

		// Token: 0x06005C3C RID: 23612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C3C")]
		[Address(RVA = "0x1CFC8E0", Offset = "0x1CFB4E0", VA = "0x181CFC8E0", Slot = "6")]
		protected override void SetTweenValue(Vector3 val)
		{
		}

		// Token: 0x06005C3D RID: 23613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C3D")]
		[Address(RVA = "0x1CFC9D0", Offset = "0x1CFB5D0", VA = "0x181CFC9D0")]
		public TweenRotate()
		{
		}

		// Token: 0x040021EB RID: 8683
		[Token(Token = "0x40021EB")]
		[FieldOffset(Offset = "0x60")]
		private Transform m_transform;

		// Token: 0x040021EC RID: 8684
		[Token(Token = "0x40021EC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040021ED RID: 8685
		[Token(Token = "0x40021ED")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ConstructTweener;

		// Token: 0x040021EE RID: 8686
		[Token(Token = "0x40021EE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetTweenValue;

		// Token: 0x040021EF RID: 8687
		[Token(Token = "0x40021EF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetTweenValue;

		// Token: 0x040021F0 RID: 8688
		[Token(Token = "0x40021F0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
