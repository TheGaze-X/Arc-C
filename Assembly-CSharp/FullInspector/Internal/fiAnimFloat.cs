using System;
using Il2CppDummyDll;
using UnityEngine;

namespace FullInspector.Internal
{
	// Token: 0x02007C78 RID: 31864
	[Token(Token = "0x2007C78")]
	[Serializable]
	public class fiAnimFloat : fiBaseAnimValue<float>
	{
		// Token: 0x0602C84B RID: 182347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C84B")]
		[Address(RVA = "0x28667B0", Offset = "0x28653B0", VA = "0x1828667B0")]
		public fiAnimFloat(float value)
		{
		}

		// Token: 0x0602C84C RID: 182348 RVA: 0x000E07C0 File Offset: 0x000DE9C0
		[Token(Token = "0x602C84C")]
		[Address(RVA = "0x2866700", Offset = "0x2865300", VA = "0x182866700", Slot = "4")]
		protected override float GetValue()
		{
			return 0f;
		}

		// Token: 0x0404035D RID: 263005
		[Token(Token = "0x404035D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_Value;
	}
}
