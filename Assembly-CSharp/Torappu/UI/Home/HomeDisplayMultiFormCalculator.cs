using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Torappu.UI.Home
{
	// Token: 0x02004B4C RID: 19276
	[Token(Token = "0x2004B4C")]
	public static class HomeDisplayMultiFormCalculator
	{
		// Token: 0x0601D082 RID: 118914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D082")]
		[Address(RVA = "0x166F840", Offset = "0x166E440", VA = "0x18166F840")]
		private static string _CalculateCurrentForm(string mainId, HomeMultiFormChangeRule rule, [Optional] MultiFormEditRef editRef)
		{
			return null;
		}

		// Token: 0x0601D083 RID: 118915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D083")]
		[Address(RVA = "0x166F9C0", Offset = "0x166E5C0", VA = "0x18166F9C0")]
		private static string _CalculateTimeBasedForm(string mainId, MultiFormEditRef editRef)
		{
			return null;
		}

		// Token: 0x02004B4D RID: 19277
		[Token(Token = "0x2004B4D")]
		public static class Runtime
		{
			// Token: 0x0601D084 RID: 118916 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601D084")]
			[Address(RVA = "0x167A880", Offset = "0x1679480", VA = "0x18167A880")]
			public static string CalculateFormId(MultiFormLoadParam param)
			{
				return null;
			}
		}

		// Token: 0x02004B4E RID: 19278
		[Token(Token = "0x2004B4E")]
		public static class Edit
		{
			// Token: 0x0601D085 RID: 118917 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601D085")]
			[Address(RVA = "0x1667850", Offset = "0x1666450", VA = "0x181667850")]
			public static string CalculateFormId(MultiFormLoadParam param, MultiFormEditRef editRef)
			{
				return null;
			}

			// Token: 0x0601D086 RID: 118918 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601D086")]
			[Address(RVA = "0x16678C0", Offset = "0x16664C0", VA = "0x1816678C0")]
			public static string CalculateNextFormId(string currentFormId, HomeDisplayMultiFormRawData rawData)
			{
				return null;
			}
		}
	}
}
