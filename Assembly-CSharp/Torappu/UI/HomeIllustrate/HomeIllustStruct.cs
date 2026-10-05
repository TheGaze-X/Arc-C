using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu.UI.HomeIllustrate
{
	// Token: 0x02004AD5 RID: 19157
	[Token(Token = "0x2004AD5")]
	[Serializable]
	public class HomeIllustStruct
	{
		// Token: 0x170043E2 RID: 17378
		// (get) Token: 0x0601CC4D RID: 117837 RVA: 0x000A9740 File Offset: 0x000A7940
		[Token(Token = "0x170043E2")]
		[JsonProperty]
		public bool isEmpty
		{
			[Token(Token = "0x601CC4D")]
			[Address(RVA = "0x1645330", Offset = "0x1643F30", VA = "0x181645330")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601CC4E RID: 117838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CC4E")]
		[Address(RVA = "0x16451F0", Offset = "0x1643DF0", VA = "0x1816451F0")]
		public static HomeIllustStruct GetSelfSecretaryHomeIllustStruct()
		{
			return null;
		}

		// Token: 0x0601CC4F RID: 117839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CC4F")]
		[Address(RVA = "0x1644BB0", Offset = "0x16437B0", VA = "0x181644BB0")]
		public static HomeIllustStruct GetSelfCharRotationHomeIllustStruct()
		{
			return null;
		}

		// Token: 0x0601CC50 RID: 117840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CC50")]
		[Address(RVA = "0x1644D50", Offset = "0x1643950", VA = "0x181644D50")]
		public static HomeIllustStruct GetSelfCharRotationHomeIllustStruct(string instId)
		{
			return null;
		}

		// Token: 0x0601CC51 RID: 117841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CC51")]
		[Address(RVA = "0x1644E50", Offset = "0x1643A50", VA = "0x181644E50")]
		public static HomeIllustStruct GetSelfHomeIllustStruct(string charId, string skinId, bool showSpDynIllust)
		{
			return null;
		}

		// Token: 0x0601CC52 RID: 117842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CC52")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HomeIllustStruct()
		{
		}

		// Token: 0x04025C1D RID: 154653
		[Token(Token = "0x4025C1D")]
		[JsonIgnore]
		[NonSerialized]
		private const string INIT_CHAR_HOME = "char_002_amiya";

		// Token: 0x04025C1E RID: 154654
		[Token(Token = "0x4025C1E")]
		[FieldOffset(Offset = "0x0")]
		[NonSerialized]
		public static readonly HomeIllustStruct EMPTY;

		// Token: 0x04025C1F RID: 154655
		[Token(Token = "0x4025C1F")]
		[FieldOffset(Offset = "0x10")]
		public int instId;

		// Token: 0x04025C20 RID: 154656
		[Token(Token = "0x4025C20")]
		[FieldOffset(Offset = "0x18")]
		public CharUISkinStruct skin;
	}
}
