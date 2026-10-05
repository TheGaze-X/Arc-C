using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.I18N
{
	// Token: 0x02001628 RID: 5672
	[Token(Token = "0x2001628")]
	public class LocalizeTextUIConfig : MonoBehaviour
	{
		// Token: 0x060080BA RID: 32954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080BA")]
		[Address(RVA = "0x2889F70", Offset = "0x2888B70", VA = "0x182889F70")]
		private void Start()
		{
		}

		// Token: 0x060080BB RID: 32955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080BB")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public LocalizeTextUIConfig()
		{
		}

		// Token: 0x0400821B RID: 33307
		[Token(Token = "0x400821B")]
		[FieldOffset(Offset = "0x18")]
		public LocalizeTextUIConfig.PlaceholderType type;

		// Token: 0x0400821C RID: 33308
		[Token(Token = "0x400821C")]
		[FieldOffset(Offset = "0x20")]
		public string pathRecord;

		// Token: 0x02001629 RID: 5673
		[Token(Token = "0x2001629")]
		public enum PlaceholderType
		{
			// Token: 0x0400821E RID: 33310
			[Token(Token = "0x400821E")]
			PlaceholderByCode,
			// Token: 0x0400821F RID: 33311
			[Token(Token = "0x400821F")]
			ManualPlaceholder,
			// Token: 0x04008220 RID: 33312
			[Token(Token = "0x4008220")]
			ManualNonPlaceholder
		}
	}
}
