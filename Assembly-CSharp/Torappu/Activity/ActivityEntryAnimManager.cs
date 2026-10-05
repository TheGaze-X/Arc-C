using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006D4B RID: 27979
	[Token(Token = "0x2006D4B")]
	public class ActivityEntryAnimManager : MonoBehaviour, IHotfixable
	{
		// Token: 0x06027E13 RID: 163347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027E13")]
		[Address(RVA = "0x22F0E20", Offset = "0x22EFA20", VA = "0x1822F0E20")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06027E14 RID: 163348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027E14")]
		[Address(RVA = "0x22F0D40", Offset = "0x22EF940", VA = "0x1822F0D40")]
		public void PlayLoopAnim(IActAnimContext context)
		{
		}

		// Token: 0x06027E15 RID: 163349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027E15")]
		[Address(RVA = "0x22F0C40", Offset = "0x22EF840", VA = "0x1822F0C40")]
		public void PlayEnterAnim(IActAnimContext context, [Optional] Action completeCallback)
		{
		}

		// Token: 0x06027E16 RID: 163350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027E16")]
		[Address(RVA = "0x22F0EF0", Offset = "0x22EFAF0", VA = "0x1822F0EF0")]
		public ActivityEntryAnimManager()
		{
		}

		// Token: 0x04038874 RID: 231540
		[Token(Token = "0x4038874")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation[] _enterAnimList;

		// Token: 0x04038875 RID: 231541
		[Token(Token = "0x4038875")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAnimationLocation[] _loopAnimList;

		// Token: 0x04038876 RID: 231542
		[Token(Token = "0x4038876")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private UITwoStepAnimation m_player;

		// Token: 0x04038877 RID: 231543
		[Token(Token = "0x4038877")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04038878 RID: 231544
		[Token(Token = "0x4038878")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_PlayLoopAnim;

		// Token: 0x04038879 RID: 231545
		[Token(Token = "0x4038879")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PlayEnterAnim;

		// Token: 0x0403887A RID: 231546
		[Token(Token = "0x403887A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
