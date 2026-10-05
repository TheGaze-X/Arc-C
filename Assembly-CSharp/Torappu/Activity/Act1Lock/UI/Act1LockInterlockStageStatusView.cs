using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1Lock.UI
{
	// Token: 0x020078B1 RID: 30897
	[Token(Token = "0x20078B1")]
	public class Act1LockInterlockStageStatusView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602B546 RID: 177478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B546")]
		[Address(RVA = "0x27277E0", Offset = "0x27263E0", VA = "0x1827277E0")]
		public void RenderStatus(bool isInterlocked)
		{
		}

		// Token: 0x0602B547 RID: 177479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B547")]
		[Address(RVA = "0x2727870", Offset = "0x2726470", VA = "0x182727870")]
		public Act1LockInterlockStageStatusView()
		{
		}

		// Token: 0x0403EA27 RID: 256551
		[Token(Token = "0x403EA27")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _notDefend;

		// Token: 0x0403EA28 RID: 256552
		[Token(Token = "0x403EA28")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _isDefended;

		// Token: 0x0403EA29 RID: 256553
		[Token(Token = "0x403EA29")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderStatus;

		// Token: 0x0403EA2A RID: 256554
		[Token(Token = "0x403EA2A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
