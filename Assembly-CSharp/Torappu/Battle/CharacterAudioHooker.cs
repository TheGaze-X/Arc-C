using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle
{
	// Token: 0x02002463 RID: 9315
	[Token(Token = "0x2002463")]
	public class CharacterAudioHooker : MonoBehaviour
	{
		// Token: 0x17001F19 RID: 7961
		// (get) Token: 0x0600EFC9 RID: 61385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001F19")]
		public IEnumerable<CharacterAudioHooker.ReplacePair> replaceAudioPairs
		{
			[Token(Token = "0x600EFC9")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600EFCA RID: 61386 RVA: 0x000584E8 File Offset: 0x000566E8
		[Token(Token = "0x600EFCA")]
		[Address(RVA = "0x66DB20", Offset = "0x66C720", VA = "0x18066DB20")]
		public bool TryHookAudio(string signal, string subSingal, out string newSignal, out string newSubSignal)
		{
			return default(bool);
		}

		// Token: 0x0600EFCB RID: 61387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFCB")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public CharacterAudioHooker()
		{
		}

		// Token: 0x04010928 RID: 67880
		[Token(Token = "0x4010928")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CharacterAudioHooker.ReplacePair[] _replaceAudioPairs;

		// Token: 0x02002464 RID: 9316
		[Token(Token = "0x2002464")]
		[Serializable]
		public struct ReplacePair
		{
			// Token: 0x04010929 RID: 67881
			[Token(Token = "0x4010929")]
			[FieldOffset(Offset = "0x0")]
			public string fromSignal;

			// Token: 0x0401092A RID: 67882
			[Token(Token = "0x401092A")]
			[FieldOffset(Offset = "0x8")]
			public string fromSubsignal;

			// Token: 0x0401092B RID: 67883
			[Token(Token = "0x401092B")]
			[FieldOffset(Offset = "0x10")]
			public string toSignal;

			// Token: 0x0401092C RID: 67884
			[Token(Token = "0x401092C")]
			[FieldOffset(Offset = "0x18")]
			public string toSubSignal;
		}
	}
}
