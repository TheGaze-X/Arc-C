using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002467 RID: 9319
	[Token(Token = "0x2002467")]
	public class SpineSkinAudioHooker : MonoBehaviour, IHotfixable
	{
		// Token: 0x17001F1A RID: 7962
		// (get) Token: 0x0600EFD1 RID: 61393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001F1A")]
		public IEnumerable<SpineSkinAudioHooker.ReplacePair> replaceAudioPairs
		{
			[Token(Token = "0x600EFD1")]
			[Address(RVA = "0x67B0D0", Offset = "0x679CD0", VA = "0x18067B0D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600EFD2 RID: 61394 RVA: 0x00058530 File Offset: 0x00056730
		[Token(Token = "0x600EFD2")]
		[Address(RVA = "0x67AE20", Offset = "0x679A20", VA = "0x18067AE20")]
		public bool TryHookAudio(string signal, string subSingal, string skin, out string newSignal, out string newSubSignal)
		{
			return default(bool);
		}

		// Token: 0x0600EFD3 RID: 61395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFD3")]
		[Address(RVA = "0x67B040", Offset = "0x679C40", VA = "0x18067B040")]
		public SpineSkinAudioHooker()
		{
		}

		// Token: 0x04010932 RID: 67890
		[Token(Token = "0x4010932")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SpineSkinAudioHooker.ReplacePair[] _replaceAudioPairs;

		// Token: 0x04010933 RID: 67891
		[Token(Token = "0x4010933")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_replaceAudioPairs;

		// Token: 0x04010934 RID: 67892
		[Token(Token = "0x4010934")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_TryHookAudio;

		// Token: 0x04010935 RID: 67893
		[Token(Token = "0x4010935")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002468 RID: 9320
		[Token(Token = "0x2002468")]
		[Serializable]
		public struct ReplacePair
		{
			// Token: 0x04010936 RID: 67894
			[Token(Token = "0x4010936")]
			[FieldOffset(Offset = "0x0")]
			public string targetSkin;

			// Token: 0x04010937 RID: 67895
			[Token(Token = "0x4010937")]
			[FieldOffset(Offset = "0x8")]
			public string fromSignal;

			// Token: 0x04010938 RID: 67896
			[Token(Token = "0x4010938")]
			[FieldOffset(Offset = "0x10")]
			public string fromSubsignal;

			// Token: 0x04010939 RID: 67897
			[Token(Token = "0x4010939")]
			[FieldOffset(Offset = "0x18")]
			public string toSignal;

			// Token: 0x0401093A RID: 67898
			[Token(Token = "0x401093A")]
			[FieldOffset(Offset = "0x20")]
			public string toSubSignal;
		}
	}
}
