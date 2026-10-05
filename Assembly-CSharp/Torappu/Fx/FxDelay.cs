using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Fx
{
	// Token: 0x0200202F RID: 8239
	[Token(Token = "0x200202F")]
	public class FxDelay : MonoBehaviour, IHotfixable
	{
		// Token: 0x17001804 RID: 6148
		// (get) Token: 0x0600CB0B RID: 51979 RVA: 0x00049788 File Offset: 0x00047988
		// (set) Token: 0x0600CB0C RID: 51980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001804")]
		public float playbackSpeed
		{
			[Token(Token = "0x600CB0B")]
			[Address(RVA = "0x34C18F0", Offset = "0x34C04F0", VA = "0x1834C18F0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600CB0C")]
			[Address(RVA = "0x34C1950", Offset = "0x34C0550", VA = "0x1834C1950")]
			set
			{
			}
		}

		// Token: 0x17001805 RID: 6149
		// (get) Token: 0x0600CB0D RID: 51981 RVA: 0x000497A0 File Offset: 0x000479A0
		[Token(Token = "0x17001805")]
		public float delayTime
		{
			[Token(Token = "0x600CB0D")]
			[Address(RVA = "0x34C1890", Offset = "0x34C0490", VA = "0x1834C1890")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600CB0E RID: 51982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB0E")]
		[Address(RVA = "0x34C1650", Offset = "0x34C0250", VA = "0x1834C1650")]
		private void OnEnable()
		{
		}

		// Token: 0x0600CB0F RID: 51983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB0F")]
		[Address(RVA = "0x34C1590", Offset = "0x34C0190", VA = "0x1834C1590")]
		public void ForceToEnd()
		{
		}

		// Token: 0x0600CB10 RID: 51984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB10")]
		[Address(RVA = "0x34C1700", Offset = "0x34C0300", VA = "0x1834C1700")]
		public void OnRecycle()
		{
		}

		// Token: 0x0600CB11 RID: 51985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB11")]
		[Address(RVA = "0x34C1790", Offset = "0x34C0390", VA = "0x1834C1790")]
		private void _DelayFunc()
		{
		}

		// Token: 0x0600CB12 RID: 51986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB12")]
		[Address(RVA = "0x34C1820", Offset = "0x34C0420", VA = "0x1834C1820")]
		public FxDelay()
		{
		}

		// Token: 0x0400D4F4 RID: 54516
		[Token(Token = "0x400D4F4")]
		private const string DELAY_FUNC = "_DelayFunc";

		// Token: 0x0400D4F5 RID: 54517
		[Token(Token = "0x400D4F5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _delayTime;

		// Token: 0x0400D4F6 RID: 54518
		[Token(Token = "0x400D4F6")]
		[FieldOffset(Offset = "0x1C")]
		private float m_playbackSpeed;

		// Token: 0x0400D4F7 RID: 54519
		[Token(Token = "0x400D4F7")]
		[FieldOffset(Offset = "0x20")]
		private bool m_isWaiting;

		// Token: 0x0400D4F8 RID: 54520
		[Token(Token = "0x400D4F8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_playbackSpeed;

		// Token: 0x0400D4F9 RID: 54521
		[Token(Token = "0x400D4F9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_playbackSpeed;

		// Token: 0x0400D4FA RID: 54522
		[Token(Token = "0x400D4FA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_delayTime;

		// Token: 0x0400D4FB RID: 54523
		[Token(Token = "0x400D4FB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0400D4FC RID: 54524
		[Token(Token = "0x400D4FC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ForceToEnd;

		// Token: 0x0400D4FD RID: 54525
		[Token(Token = "0x400D4FD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnRecycle;

		// Token: 0x0400D4FE RID: 54526
		[Token(Token = "0x400D4FE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__DelayFunc;

		// Token: 0x0400D4FF RID: 54527
		[Token(Token = "0x400D4FF")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
