using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Fx
{
	// Token: 0x0200202D RID: 8237
	[Token(Token = "0x200202D")]
	public class FxAnimationEvent : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600CAFD RID: 51965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CAFD")]
		[Address(RVA = "0x34C0AD0", Offset = "0x34BF6D0", VA = "0x1834C0AD0")]
		private void OnEnable()
		{
		}

		// Token: 0x0600CAFE RID: 51966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CAFE")]
		[Address(RVA = "0x34C0950", Offset = "0x34BF550", VA = "0x1834C0950")]
		public void EnableObject(string name)
		{
		}

		// Token: 0x0600CAFF RID: 51967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CAFF")]
		[Address(RVA = "0x34C07D0", Offset = "0x34BF3D0", VA = "0x1834C07D0")]
		public void DisbaleObject(string name)
		{
		}

		// Token: 0x0600CB00 RID: 51968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB00")]
		[Address(RVA = "0x34C0640", Offset = "0x34BF240", VA = "0x1834C0640")]
		public void DisableAndEnableObject(string name)
		{
		}

		// Token: 0x0600CB01 RID: 51969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB01")]
		[Address(RVA = "0x34C0500", Offset = "0x34BF100", VA = "0x1834C0500")]
		public void DisableAll()
		{
		}

		// Token: 0x0600CB02 RID: 51970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB02")]
		[Address(RVA = "0x34C0B40", Offset = "0x34BF740", VA = "0x1834C0B40")]
		public FxAnimationEvent()
		{
		}

		// Token: 0x0400D4DE RID: 54494
		[Token(Token = "0x400D4DE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<GameObject> _objects;

		// Token: 0x0400D4DF RID: 54495
		[Token(Token = "0x400D4DF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _disableAllOnEnable;

		// Token: 0x0400D4E0 RID: 54496
		[Token(Token = "0x400D4E0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0400D4E1 RID: 54497
		[Token(Token = "0x400D4E1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EnableObject;

		// Token: 0x0400D4E2 RID: 54498
		[Token(Token = "0x400D4E2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DisbaleObject;

		// Token: 0x0400D4E3 RID: 54499
		[Token(Token = "0x400D4E3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DisableAndEnableObject;

		// Token: 0x0400D4E4 RID: 54500
		[Token(Token = "0x400D4E4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_DisableAll;

		// Token: 0x0400D4E5 RID: 54501
		[Token(Token = "0x400D4E5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
