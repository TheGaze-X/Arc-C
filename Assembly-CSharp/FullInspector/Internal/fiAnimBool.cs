using System;
using Il2CppDummyDll;
using UnityEngine;

namespace FullInspector.Internal
{
	// Token: 0x02007C79 RID: 31865
	[Token(Token = "0x2007C79")]
	[Serializable]
	public class fiAnimBool : fiBaseAnimValue<bool>
	{
		// Token: 0x17006835 RID: 26677
		// (get) Token: 0x0602C84D RID: 182349 RVA: 0x000E07D8 File Offset: 0x000DE9D8
		[Token(Token = "0x17006835")]
		public float faded
		{
			[Token(Token = "0x602C84D")]
			[Address(RVA = "0x28666C0", Offset = "0x28652C0", VA = "0x1828666C0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0602C84E RID: 182350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C84E")]
		[Address(RVA = "0x2866630", Offset = "0x2865230", VA = "0x182866630")]
		public fiAnimBool()
		{
		}

		// Token: 0x0602C84F RID: 182351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C84F")]
		[Address(RVA = "0x2866670", Offset = "0x2865270", VA = "0x182866670")]
		public fiAnimBool(bool value)
		{
		}

		// Token: 0x0602C850 RID: 182352 RVA: 0x000E07F0 File Offset: 0x000DE9F0
		[Token(Token = "0x602C850")]
		[Address(RVA = "0x2866560", Offset = "0x2865160", VA = "0x182866560", Slot = "4")]
		protected override bool GetValue()
		{
			return default(bool);
		}

		// Token: 0x0602C851 RID: 182353 RVA: 0x000E0808 File Offset: 0x000DEA08
		[Token(Token = "0x602C851")]
		[Address(RVA = "0x28664E0", Offset = "0x28650E0", VA = "0x1828664E0")]
		public float Fade(float from, float to)
		{
			return 0f;
		}

		// Token: 0x0404035E RID: 263006
		[Token(Token = "0x404035E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_Value;
	}
}
