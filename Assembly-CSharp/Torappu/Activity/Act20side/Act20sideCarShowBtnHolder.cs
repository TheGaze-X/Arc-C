using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x02007679 RID: 30329
	[Token(Token = "0x2007679")]
	public class Act20sideCarShowBtnHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602AA93 RID: 174739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA93")]
		[Address(RVA = "0x2667CF0", Offset = "0x26668F0", VA = "0x182667CF0")]
		public void SetUnlockState(bool isUnlocked, int count, bool isActAvail)
		{
		}

		// Token: 0x0602AA94 RID: 174740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA94")]
		[Address(RVA = "0x2667EA0", Offset = "0x2666AA0", VA = "0x182667EA0")]
		public Act20sideCarShowBtnHolder()
		{
		}

		// Token: 0x0403D6FF RID: 251647
		[Token(Token = "0x403D6FF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TwoStateToggle _twoStateToggle;

		// Token: 0x0403D700 RID: 251648
		[Token(Token = "0x403D700")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _lockReason;

		// Token: 0x0403D701 RID: 251649
		[Token(Token = "0x403D701")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetUnlockState;

		// Token: 0x0403D702 RID: 251650
		[Token(Token = "0x403D702")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
