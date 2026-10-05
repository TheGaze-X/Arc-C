using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;

namespace Torappu.Battle.UI
{
	// Token: 0x02003314 RID: 13076
	[Token(Token = "0x2003314")]
	public class UIAnimationPerform : UIPerform
	{
		// Token: 0x1700312D RID: 12589
		// (get) Token: 0x06014C5D RID: 85085 RVA: 0x00088488 File Offset: 0x00086688
		[Token(Token = "0x1700312D")]
		private bool useWrapper
		{
			[Token(Token = "0x6014C5D")]
			[Address(RVA = "0xD36A60", Offset = "0xD35660", VA = "0x180D36A60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06014C5E RID: 85086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C5E")]
		[Address(RVA = "0xD368B0", Offset = "0xD354B0", VA = "0x180D368B0", Slot = "4")]
		protected override void DoPlay()
		{
		}

		// Token: 0x06014C5F RID: 85087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C5F")]
		[Address(RVA = "0xCED460", Offset = "0xCEC060", VA = "0x180CED460", Slot = "5")]
		protected override void DoComplete()
		{
		}

		// Token: 0x06014C60 RID: 85088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C60")]
		[Address(RVA = "0xCED460", Offset = "0xCEC060", VA = "0x180CED460", Slot = "6")]
		protected override void DoKill()
		{
		}

		// Token: 0x06014C61 RID: 85089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C61")]
		[Address(RVA = "0xD36A20", Offset = "0xD35620", VA = "0x180D36A20", Slot = "7")]
		public override void OnUpdate(float deltaTime)
		{
		}

		// Token: 0x06014C62 RID: 85090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C62")]
		[Address(RVA = "0x5B5830", Offset = "0x5B4430", VA = "0x1805B5830")]
		public UIAnimationPerform()
		{
		}

		// Token: 0x04018B70 RID: 101232
		[Token(Token = "0x4018B70")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Animation _animation;

		// Token: 0x04018B71 RID: 101233
		[Token(Token = "0x4018B71")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool _useWrapper;

		// Token: 0x04018B72 RID: 101234
		[Token(Token = "0x4018B72")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Inspect("useWrapper")]
		private AnimationWrapper _animationWrapper;

		// Token: 0x04018B73 RID: 101235
		[Token(Token = "0x4018B73")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Inspect("useWrapper")]
		private string _wrapperAnimKey;

		// Token: 0x04018B74 RID: 101236
		[Token(Token = "0x4018B74")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Inspect("useWrapper")]
		private bool _setFixedUpdateMode;
	}
}
