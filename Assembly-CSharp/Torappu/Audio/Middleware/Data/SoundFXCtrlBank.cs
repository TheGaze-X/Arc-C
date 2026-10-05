using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Audio.Middleware.Data
{
	// Token: 0x02001FBF RID: 8127
	[Token(Token = "0x2001FBF")]
	[Serializable]
	public class SoundFXCtrlBank : Bank
	{
		// Token: 0x0600C9E4 RID: 51684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C9E4")]
		[Address(RVA = "0x34B2C90", Offset = "0x34B1890", VA = "0x1834B2C90", Slot = "4")]
		public override AudioAtom Play(Vector3 position)
		{
			return null;
		}

		// Token: 0x0600C9E5 RID: 51685 RVA: 0x000494B8 File Offset: 0x000476B8
		[Token(Token = "0x600C9E5")]
		[Address(RVA = "0x34B2D40", Offset = "0x34B1940", VA = "0x1834B2D40")]
		private bool _InitTargetBank()
		{
			return default(bool);
		}

		// Token: 0x0600C9E6 RID: 51686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C9E6")]
		[Address(RVA = "0x34B2F80", Offset = "0x34B1B80", VA = "0x1834B2F80")]
		public SoundFXCtrlBank()
		{
		}

		// Token: 0x0400D251 RID: 53841
		[Token(Token = "0x400D251")]
		[FieldOffset(Offset = "0x30")]
		private Bank m_targetBank;

		// Token: 0x0400D252 RID: 53842
		[Token(Token = "0x400D252")]
		[FieldOffset(Offset = "0x38")]
		public string targetBank;

		// Token: 0x0400D253 RID: 53843
		[Token(Token = "0x400D253")]
		[FieldOffset(Offset = "0x40")]
		public bool ctrlStop;

		// Token: 0x0400D254 RID: 53844
		[Token(Token = "0x400D254")]
		[FieldOffset(Offset = "0x44")]
		public float ctrlStopFadetime;

		// Token: 0x0400D255 RID: 53845
		[Token(Token = "0x400D255")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Play;

		// Token: 0x0400D256 RID: 53846
		[Token(Token = "0x400D256")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitTargetBank;

		// Token: 0x0400D257 RID: 53847
		[Token(Token = "0x400D257")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
