using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Rendering.PostProcess
{
	// Token: 0x02002077 RID: 8311
	[Token(Token = "0x2002077")]
	public class ColorGradingCtrl : MonoBehaviour
	{
		// Token: 0x0600CCD9 RID: 52441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCD9")]
		[Address(RVA = "0x156CF10", Offset = "0x156BB10", VA = "0x18156CF10")]
		private void Start()
		{
		}

		// Token: 0x0600CCDA RID: 52442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCDA")]
		[Address(RVA = "0x34D01A0", Offset = "0x34CEDA0", VA = "0x1834D01A0")]
		private void Update()
		{
		}

		// Token: 0x0600CCDB RID: 52443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCDB")]
		[Address(RVA = "0x156D000", Offset = "0x156BC00", VA = "0x18156D000")]
		public ColorGradingCtrl()
		{
		}

		// Token: 0x0400D816 RID: 55318
		[Token(Token = "0x400D816")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AnimationCurve _curve;

		// Token: 0x0400D817 RID: 55319
		[Token(Token = "0x400D817")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Range(0.01f, 65536f)]
		private float _anmTime;

		// Token: 0x0400D818 RID: 55320
		[Token(Token = "0x400D818")]
		[FieldOffset(Offset = "0x24")]
		private float time;
	}
}
