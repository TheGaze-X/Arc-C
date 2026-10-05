using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.Utilities
{
	// Token: 0x02000244 RID: 580
	[Token(Token = "0x2000244")]
	public struct NameAndParameters
	{
		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06001514 RID: 5396 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001515 RID: 5397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005D2")]
		public string name
		{
			[Token(Token = "0x6001514")]
			[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001515")]
			[Address(RVA = "0xE7C280", Offset = "0xE7AE80", VA = "0x180E7C280")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06001516 RID: 5398 RVA: 0x0000B358 File Offset: 0x00009558
		// (set) Token: 0x06001517 RID: 5399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005D3")]
		public ReadOnlyArray<NamedValue> parameters
		{
			[Token(Token = "0x6001516")]
			[Address(RVA = "0x4007430", Offset = "0x4006030", VA = "0x184007430")]
			[CompilerGenerated]
			readonly get
			{
				return default(ReadOnlyArray<NamedValue>);
			}
			[Token(Token = "0x6001517")]
			[Address(RVA = "0x5611190", Offset = "0x560FD90", VA = "0x185611190")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001518 RID: 5400 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001518")]
		[Address(RVA = "0x5610F80", Offset = "0x560FB80", VA = "0x185610F80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001519 RID: 5401 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001519")]
		[Address(RVA = "0x5610610", Offset = "0x560F210", VA = "0x185610610")]
		public static IEnumerable<NameAndParameters> ParseMultiple(string text)
		{
			return null;
		}

		// Token: 0x0600151A RID: 5402 RVA: 0x0000B370 File Offset: 0x00009570
		[Token(Token = "0x600151A")]
		[Address(RVA = "0x5610880", Offset = "0x560F480", VA = "0x185610880")]
		internal static bool ParseMultiple(string text, ref List<NameAndParameters> list)
		{
			return default(bool);
		}

		// Token: 0x0600151B RID: 5403 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600151B")]
		[Address(RVA = "0x5610E50", Offset = "0x560FA50", VA = "0x185610E50")]
		internal static string ParseName(string text)
		{
			return null;
		}

		// Token: 0x0600151C RID: 5404 RVA: 0x0000B388 File Offset: 0x00009588
		[Token(Token = "0x600151C")]
		[Address(RVA = "0x5610EE0", Offset = "0x560FAE0", VA = "0x185610EE0")]
		public static NameAndParameters Parse(string text)
		{
			return default(NameAndParameters);
		}

		// Token: 0x0600151D RID: 5405 RVA: 0x0000B3A0 File Offset: 0x000095A0
		[Token(Token = "0x600151D")]
		[Address(RVA = "0x5610A70", Offset = "0x560F670", VA = "0x185610A70")]
		private static NameAndParameters ParseNameAndParameters(string text, ref int index, bool nameOnly = false)
		{
			return default(NameAndParameters);
		}
	}
}
