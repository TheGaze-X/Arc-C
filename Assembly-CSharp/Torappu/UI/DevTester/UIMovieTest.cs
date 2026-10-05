using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.Video;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.DevTester
{
	// Token: 0x0200510A RID: 20746
	[Token(Token = "0x200510A")]
	public class UIMovieTest : MonoBehaviour
	{
		// Token: 0x0601EA29 RID: 125481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA29")]
		[Address(RVA = "0x1865DE0", Offset = "0x18649E0", VA = "0x181865DE0")]
		private void Start()
		{
		}

		// Token: 0x0601EA2A RID: 125482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA2A")]
		[Address(RVA = "0x1865C80", Offset = "0x1864880", VA = "0x181865C80")]
		public void OnPlayVideo()
		{
		}

		// Token: 0x0601EA2B RID: 125483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EA2B")]
		[Address(RVA = "0x1865D60", Offset = "0x1864960", VA = "0x181865D60")]
		public IEnumerator Show()
		{
			return null;
		}

		// Token: 0x0601EA2C RID: 125484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA2C")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public UIMovieTest()
		{
		}

		// Token: 0x0402914E RID: 168270
		[Token(Token = "0x402914E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private InputField _inputField;

		// Token: 0x0402914F RID: 168271
		[Token(Token = "0x402914F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AbstractMediaPlayerHolder _mediaPlayer;
	}
}
