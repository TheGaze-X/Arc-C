using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Audio.Middleware.Data
{
	// Token: 0x02001FC0 RID: 8128
	[Token(Token = "0x2001FC0")]
	public class SnapshotBank : Bank
	{
		// Token: 0x0600C9E7 RID: 51687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C9E7")]
		[Address(RVA = "0x34B1240", Offset = "0x34AFE40", VA = "0x1834B1240", Slot = "4")]
		public override AudioAtom Play(Vector3 position)
		{
			return null;
		}

		// Token: 0x0600C9E8 RID: 51688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C9E8")]
		[Address(RVA = "0x34B15A0", Offset = "0x34B01A0", VA = "0x1834B15A0")]
		public void PopAtom()
		{
		}

		// Token: 0x0600C9E9 RID: 51689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C9E9")]
		[Address(RVA = "0x34B17C0", Offset = "0x34B03C0", VA = "0x1834B17C0")]
		public static void TriggerSnapshot(SnapshotBank bank)
		{
		}

		// Token: 0x0600C9EA RID: 51690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C9EA")]
		[Address(RVA = "0x34B1650", Offset = "0x34B0250", VA = "0x1834B1650")]
		public static void ReverseSnapshot(SnapshotBank deadBank)
		{
		}

		// Token: 0x0600C9EB RID: 51691 RVA: 0x000494D0 File Offset: 0x000476D0
		[Token(Token = "0x600C9EB")]
		[Address(RVA = "0x34B1930", Offset = "0x34B0530", VA = "0x1834B1930")]
		private bool _InitTargetBank()
		{
			return default(bool);
		}

		// Token: 0x0600C9EC RID: 51692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C9EC")]
		[Address(RVA = "0x34B1BA0", Offset = "0x34B07A0", VA = "0x1834B1BA0")]
		public SnapshotBank()
		{
		}

		// Token: 0x0400D258 RID: 53848
		[Token(Token = "0x400D258")]
		[FieldOffset(Offset = "0x0")]
		private static List<SnapshotBank> s_activeSnapshotBank;

		// Token: 0x0400D259 RID: 53849
		[Token(Token = "0x400D259")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public Bank targetFxBank;

		// Token: 0x0400D25A RID: 53850
		[Token(Token = "0x400D25A")]
		[FieldOffset(Offset = "0x38")]
		public string targetSnapshot;

		// Token: 0x0400D25B RID: 53851
		[Token(Token = "0x400D25B")]
		[FieldOffset(Offset = "0x40")]
		public string hookSoundFxBank;

		// Token: 0x0400D25C RID: 53852
		[Token(Token = "0x400D25C")]
		[FieldOffset(Offset = "0x48")]
		public float delay;

		// Token: 0x0400D25D RID: 53853
		[Token(Token = "0x400D25D")]
		[FieldOffset(Offset = "0x4C")]
		public float duration;

		// Token: 0x0400D25E RID: 53854
		[Token(Token = "0x400D25E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Play;

		// Token: 0x0400D25F RID: 53855
		[Token(Token = "0x400D25F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PopAtom;

		// Token: 0x0400D260 RID: 53856
		[Token(Token = "0x400D260")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_TriggerSnapshot;

		// Token: 0x0400D261 RID: 53857
		[Token(Token = "0x400D261")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ReverseSnapshot;

		// Token: 0x0400D262 RID: 53858
		[Token(Token = "0x400D262")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitTargetBank;

		// Token: 0x0400D263 RID: 53859
		[Token(Token = "0x400D263")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
