using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.DB
{
	// Token: 0x0200169B RID: 5787
	[Token(Token = "0x200169B")]
	[CreateAssetMenu(menuName = "Torappu/Options/DBOptions")]
	public class DBOptions : SingletonScriptableObject<DBOptions>
	{
		// Token: 0x060092A9 RID: 37545 RVA: 0x00039150 File Offset: 0x00037350
		[Token(Token = "0x60092A9")]
		[Address(RVA = "0x2B31210", Offset = "0x2B2FE10", VA = "0x182B31210")]
		public static bool TryLoadDataVersionStr(out string dataVerStr)
		{
			return default(bool);
		}

		// Token: 0x060092AA RID: 37546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092AA")]
		[Address(RVA = "0x2B313D0", Offset = "0x2B2FFD0", VA = "0x182B313D0")]
		public DBOptions()
		{
		}

		// Token: 0x04008847 RID: 34887
		[Token(Token = "0x4008847")]
		[FieldOffset(Offset = "0x18")]
		public DBOptions.Mode mode;

		// Token: 0x04008848 RID: 34888
		[Token(Token = "0x4008848")]
		[FieldOffset(Offset = "0x1C")]
		public ConverterFactory.ConverterType defaultEncryptType;

		// Token: 0x04008849 RID: 34889
		[Token(Token = "0x4008849")]
		[FieldOffset(Offset = "0x20")]
		public ConverterFactory.ConverterType excelEncryptType;

		// Token: 0x0400884A RID: 34890
		[Token(Token = "0x400884A")]
		[FieldOffset(Offset = "0x28")]
		public AbstractTable[] tableAssets;

		// Token: 0x0200169C RID: 5788
		[Token(Token = "0x200169C")]
		public enum Mode
		{
			// Token: 0x0400884C RID: 34892
			[Token(Token = "0x400884C")]
			DEVELOPMENT,
			// Token: 0x0400884D RID: 34893
			[Token(Token = "0x400884D")]
			PRODUCTION
		}
	}
}
