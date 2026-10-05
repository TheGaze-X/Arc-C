using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle.UI
{
	// Token: 0x02003315 RID: 13077
	[Token(Token = "0x2003315")]
	public class UIAnimatorPerform : UIPerform
	{
		// Token: 0x06014C63 RID: 85091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C63")]
		[Address(RVA = "0xD36A70", Offset = "0xD35670", VA = "0x180D36A70", Slot = "4")]
		protected override void DoPlay()
		{
		}

		// Token: 0x06014C64 RID: 85092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C64")]
		[Address(RVA = "0x8F3060", Offset = "0x8F1C60", VA = "0x1808F3060", Slot = "5")]
		protected override void DoComplete()
		{
		}

		// Token: 0x06014C65 RID: 85093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C65")]
		[Address(RVA = "0x8F3060", Offset = "0x8F1C60", VA = "0x1808F3060", Slot = "6")]
		protected override void DoKill()
		{
		}

		// Token: 0x06014C66 RID: 85094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C66")]
		[Address(RVA = "0xD36AB0", Offset = "0xD356B0", VA = "0x180D36AB0", Slot = "7")]
		public override void OnUpdate(float deltaTime)
		{
		}

		// Token: 0x06014C67 RID: 85095 RVA: 0x000884A0 File Offset: 0x000866A0
		[Token(Token = "0x6014C67")]
		[Address(RVA = "0xD36B70", Offset = "0xD35770", VA = "0x180D36B70")]
		private bool _AnimatorIsPlaying()
		{
			return default(bool);
		}

		// Token: 0x06014C68 RID: 85096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C68")]
		[Address(RVA = "0x5B5830", Offset = "0x5B4430", VA = "0x1805B5830")]
		public UIAnimatorPerform()
		{
		}

		// Token: 0x04018B75 RID: 101237
		[Token(Token = "0x4018B75")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Animator _animator;
	}
}
