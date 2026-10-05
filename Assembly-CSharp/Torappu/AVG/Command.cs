using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.AVG
{
	// Token: 0x02001E6E RID: 7790
	[Token(Token = "0x2001E6E")]
	public class Command
	{
		// Token: 0x0600C117 RID: 49431 RVA: 0x00046F50 File Offset: 0x00045150
		[Token(Token = "0x600C117")]
		[Address(RVA = "0x33E8660", Offset = "0x33E7260", VA = "0x1833E8660")]
		public bool TryGetParam(string key, out object value)
		{
			return default(bool);
		}

		// Token: 0x0600C118 RID: 49432 RVA: 0x00046F68 File Offset: 0x00045168
		[Token(Token = "0x600C118")]
		[Address(RVA = "0x33E8A50", Offset = "0x33E7650", VA = "0x1833E8A50")]
		public bool TryGetParam(string key, out float value)
		{
			return default(bool);
		}

		// Token: 0x0600C119 RID: 49433 RVA: 0x00046F80 File Offset: 0x00045180
		[Token(Token = "0x600C119")]
		[Address(RVA = "0x33E86F0", Offset = "0x33E72F0", VA = "0x1833E86F0")]
		public bool TryGetParam(string key, out int value)
		{
			return default(bool);
		}

		// Token: 0x0600C11A RID: 49434 RVA: 0x00046F98 File Offset: 0x00045198
		[Token(Token = "0x600C11A")]
		[Address(RVA = "0x33E8580", Offset = "0x33E7180", VA = "0x1833E8580")]
		public bool TryGetParam(string key, out bool value)
		{
			return default(bool);
		}

		// Token: 0x0600C11B RID: 49435 RVA: 0x00046FB0 File Offset: 0x000451B0
		[Token(Token = "0x600C11B")]
		[Address(RVA = "0x33E8490", Offset = "0x33E7090", VA = "0x1833E8490")]
		public bool TryGetParam(string key, out string value)
		{
			return default(bool);
		}

		// Token: 0x0600C11C RID: 49436 RVA: 0x00046FC8 File Offset: 0x000451C8
		[Token(Token = "0x600C11C")]
		[Address(RVA = "0x33E8470", Offset = "0x33E7070", VA = "0x1833E8470")]
		public bool TryGetParam(string key, out float[] value)
		{
			return default(bool);
		}

		// Token: 0x0600C11D RID: 49437 RVA: 0x00046FE0 File Offset: 0x000451E0
		[Token(Token = "0x600C11D")]
		[Address(RVA = "0x33E87D0", Offset = "0x33E73D0", VA = "0x1833E87D0")]
		public bool TryGetParam(string key, out float[] value, out string rawValue)
		{
			return default(bool);
		}

		// Token: 0x0600C11E RID: 49438 RVA: 0x00046FF8 File Offset: 0x000451F8
		[Token(Token = "0x600C11E")]
		public static bool TryGetParam<T>(IList<string> keys, out T value, Command.TryGetParamDelegate<T> getter)
		{
			return default(bool);
		}

		// Token: 0x0600C11F RID: 49439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C11F")]
		public static T GetOrDefault<T>(string key, T defaultValue, Command.TryGetParamDelegate<T> getter)
		{
			return null;
		}

		// Token: 0x0600C120 RID: 49440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C120")]
		public static T GetOrDefault<T>(IList<string> keys, T defaultValue, Command.TryGetParamDelegate<T> getter)
		{
			return null;
		}

		// Token: 0x0600C121 RID: 49441 RVA: 0x00047010 File Offset: 0x00045210
		[Token(Token = "0x600C121")]
		[Address(RVA = "0x33E8420", Offset = "0x33E7020", VA = "0x1833E8420")]
		public bool IsDecisionCommand()
		{
			return default(bool);
		}

		// Token: 0x0600C122 RID: 49442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C122")]
		[Address(RVA = "0x33E8B40", Offset = "0x33E7740", VA = "0x1833E8B40")]
		public Command()
		{
		}

		// Token: 0x0400C296 RID: 49814
		[Token(Token = "0x400C296")]
		[FieldOffset(Offset = "0x10")]
		public string command;

		// Token: 0x0400C297 RID: 49815
		[Token(Token = "0x400C297")]
		[FieldOffset(Offset = "0x18")]
		public string content;

		// Token: 0x0400C298 RID: 49816
		[Token(Token = "0x400C298")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, object> param;

		// Token: 0x0400C299 RID: 49817
		[Token(Token = "0x400C299")]
		[FieldOffset(Offset = "0x28")]
		public int lineNumber;

		// Token: 0x02001E6F RID: 7791
		// (Invoke) Token: 0x0600C124 RID: 49444
		[Token(Token = "0x2001E6F")]
		public delegate bool TryGetParamDelegate<T>(string key, out T value);
	}
}
