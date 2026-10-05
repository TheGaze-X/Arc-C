using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI
{
	// Token: 0x020037C8 RID: 14280
	[Token(Token = "0x20037C8")]
	[RequireComponent(typeof(Text))]
	public class TempFPSComponent : MonoBehaviour
	{
		// Token: 0x06016A2D RID: 92717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016A2D")]
		[Address(RVA = "0xF07370", Offset = "0xF05F70", VA = "0x180F07370")]
		private void Start()
		{
		}

		// Token: 0x06016A2E RID: 92718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016A2E")]
		[Address(RVA = "0xF073E0", Offset = "0xF05FE0", VA = "0x180F073E0")]
		private void Update()
		{
		}

		// Token: 0x17003627 RID: 13863
		// (get) Token: 0x06016A2F RID: 92719 RVA: 0x00092100 File Offset: 0x00090300
		[Token(Token = "0x17003627")]
		public float FPS
		{
			[Token(Token = "0x6016A2F")]
			[Address(RVA = "0x73B8E0", Offset = "0x73A4E0", VA = "0x18073B8E0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06016A30 RID: 92720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016A30")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public TempFPSComponent()
		{
		}

		// Token: 0x0401B495 RID: 111765
		[Token(Token = "0x401B495")]
		private const float UPDATE_INTERVAL = 0.5f;

		// Token: 0x0401B496 RID: 111766
		[Token(Token = "0x401B496")]
		[FieldOffset(Offset = "0x18")]
		private double _lastInterval;

		// Token: 0x0401B497 RID: 111767
		[Token(Token = "0x401B497")]
		[FieldOffset(Offset = "0x20")]
		private int _frames;

		// Token: 0x0401B498 RID: 111768
		[Token(Token = "0x401B498")]
		[FieldOffset(Offset = "0x24")]
		private float _fps;

		// Token: 0x0401B499 RID: 111769
		[Token(Token = "0x401B499")]
		[FieldOffset(Offset = "0x28")]
		private Text m_text;
	}
}
