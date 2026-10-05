using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.AVG
{
	// Token: 0x02001E53 RID: 7763
	[Token(Token = "0x2001E53")]
	public class AVGLoader : MonoBehaviour
	{
		// Token: 0x0600BFEF RID: 49135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BFEF")]
		[Address(RVA = "0x33DDAC0", Offset = "0x33DC6C0", VA = "0x1833DDAC0")]
		private IEnumerator Start()
		{
			return null;
		}

		// Token: 0x0600BFF0 RID: 49136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BFF0")]
		[Address(RVA = "0x33DDA20", Offset = "0x33DC620", VA = "0x1833DDA20")]
		protected IEnumerator LoadStory()
		{
			return null;
		}

		// Token: 0x0600BFF1 RID: 49137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFF1")]
		[Address(RVA = "0x33DDB40", Offset = "0x33DC740", VA = "0x1833DDB40")]
		protected void SwitchToNextScene(Story story)
		{
		}

		// Token: 0x0600BFF2 RID: 49138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFF2")]
		[Address(RVA = "0x33DDAB0", Offset = "0x33DC6B0", VA = "0x1833DDAB0")]
		private void OnEnable()
		{
		}

		// Token: 0x0600BFF3 RID: 49139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFF3")]
		[Address(RVA = "0x33DDAA0", Offset = "0x33DC6A0", VA = "0x1833DDAA0")]
		private void OnDisable()
		{
		}

		// Token: 0x0600BFF4 RID: 49140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFF4")]
		[Address(RVA = "0x33DDF10", Offset = "0x33DCB10", VA = "0x1833DDF10")]
		public AVGLoader()
		{
		}

		// Token: 0x0400C14F RID: 49487
		[Token(Token = "0x400C14F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _startDelay;

		// Token: 0x0400C150 RID: 49488
		[Token(Token = "0x400C150")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _debugStoryId;
	}
}
