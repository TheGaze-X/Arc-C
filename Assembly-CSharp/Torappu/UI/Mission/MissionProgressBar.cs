using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.Mission
{
	// Token: 0x020048A5 RID: 18597
	[Token(Token = "0x20048A5")]
	public class MissionProgressBar : MonoBehaviour
	{
		// Token: 0x170042A1 RID: 17057
		// (get) Token: 0x0601C104 RID: 114948 RVA: 0x000A71C0 File Offset: 0x000A53C0
		// (set) Token: 0x0601C105 RID: 114949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170042A1")]
		public float fullLength
		{
			[Token(Token = "0x601C104")]
			[Address(RVA = "0x7E7500", Offset = "0x7E6100", VA = "0x1807E7500")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x601C105")]
			[Address(RVA = "0x156C9D0", Offset = "0x156B5D0", VA = "0x18156C9D0")]
			set
			{
			}
		}

		// Token: 0x0601C106 RID: 114950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C106")]
		[Address(RVA = "0x156C950", Offset = "0x156B550", VA = "0x18156C950")]
		private void _RefreshLength()
		{
		}

		// Token: 0x0601C107 RID: 114951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C107")]
		[Address(RVA = "0x156C810", Offset = "0x156B410", VA = "0x18156C810")]
		public void InitData(int target, int value)
		{
		}

		// Token: 0x0601C108 RID: 114952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C108")]
		[Address(RVA = "0x156C9B0", Offset = "0x156B5B0", VA = "0x18156C9B0")]
		public MissionProgressBar()
		{
		}

		// Token: 0x04024A6C RID: 150124
		[Token(Token = "0x4024A6C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _rectTransform;

		// Token: 0x04024A6D RID: 150125
		[Token(Token = "0x4024A6D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _valueText;

		// Token: 0x04024A6E RID: 150126
		[Token(Token = "0x4024A6E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _fullLength;

		// Token: 0x04024A6F RID: 150127
		[Token(Token = "0x4024A6F")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _height;

		// Token: 0x04024A70 RID: 150128
		[Token(Token = "0x4024A70")]
		[FieldOffset(Offset = "0x30")]
		private int m_currentTarget;

		// Token: 0x04024A71 RID: 150129
		[Token(Token = "0x4024A71")]
		[FieldOffset(Offset = "0x34")]
		private int m_currentValue;
	}
}
