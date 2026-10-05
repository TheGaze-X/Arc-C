using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.Mission
{
	// Token: 0x020048A7 RID: 18599
	[Token(Token = "0x20048A7")]
	public class MissionSineAlphaImage : MonoBehaviour
	{
		// Token: 0x0601C10D RID: 114957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C10D")]
		[Address(RVA = "0x156CF10", Offset = "0x156BB10", VA = "0x18156CF10")]
		private void Start()
		{
		}

		// Token: 0x0601C10E RID: 114958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C10E")]
		[Address(RVA = "0x156CF20", Offset = "0x156BB20", VA = "0x18156CF20")]
		private void Update()
		{
		}

		// Token: 0x0601C10F RID: 114959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C10F")]
		[Address(RVA = "0x156D000", Offset = "0x156BC00", VA = "0x18156D000")]
		public MissionSineAlphaImage()
		{
		}

		// Token: 0x04024A80 RID: 150144
		[Token(Token = "0x4024A80")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _targetCanvasGroup;

		// Token: 0x04024A81 RID: 150145
		[Token(Token = "0x4024A81")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _period;

		// Token: 0x04024A82 RID: 150146
		[Token(Token = "0x4024A82")]
		[FieldOffset(Offset = "0x24")]
		private float m_timer;
	}
}
