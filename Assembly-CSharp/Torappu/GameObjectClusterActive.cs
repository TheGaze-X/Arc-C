using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x02000556 RID: 1366
	[Token(Token = "0x2000556")]
	[ExecuteInEditMode]
	public class GameObjectClusterActive : MonoBehaviour, IHotfixable
	{
		// Token: 0x17000C9B RID: 3227
		// (get) Token: 0x06005AD7 RID: 23255 RVA: 0x0002EB18 File Offset: 0x0002CD18
		// (set) Token: 0x06005AD8 RID: 23256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C9B")]
		[Inspect]
		public bool active
		{
			[Token(Token = "0x6005AD7")]
			[Address(RVA = "0x1AF0BC0", Offset = "0x1AEF7C0", VA = "0x181AF0BC0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005AD8")]
			[Address(RVA = "0x1AF0C20", Offset = "0x1AEF820", VA = "0x181AF0C20")]
			set
			{
			}
		}

		// Token: 0x06005AD9 RID: 23257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AD9")]
		[Address(RVA = "0x1AF0A20", Offset = "0x1AEF620", VA = "0x181AF0A20")]
		private void OnEnable()
		{
		}

		// Token: 0x06005ADA RID: 23258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ADA")]
		[Address(RVA = "0x1AF09C0", Offset = "0x1AEF5C0", VA = "0x181AF09C0")]
		private void OnDisable()
		{
		}

		// Token: 0x06005ADB RID: 23259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ADB")]
		[Address(RVA = "0x1AF0A80", Offset = "0x1AEF680", VA = "0x181AF0A80")]
		private void _SetActive(bool active)
		{
		}

		// Token: 0x06005ADC RID: 23260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ADC")]
		[Address(RVA = "0x1AF0B60", Offset = "0x1AEF760", VA = "0x181AF0B60")]
		public GameObjectClusterActive()
		{
		}

		// Token: 0x0400209F RID: 8351
		[Token(Token = "0x400209F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject[] _gos;

		// Token: 0x040020A0 RID: 8352
		[Token(Token = "0x40020A0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_active;

		// Token: 0x040020A1 RID: 8353
		[Token(Token = "0x40020A1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_active;

		// Token: 0x040020A2 RID: 8354
		[Token(Token = "0x40020A2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x040020A3 RID: 8355
		[Token(Token = "0x40020A3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x040020A4 RID: 8356
		[Token(Token = "0x40020A4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SetActive;

		// Token: 0x040020A5 RID: 8357
		[Token(Token = "0x40020A5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
